Public Class frmSearchDB


    Sub Refresh_List()
        Dim filtit As Boolean = False
        Dim filt As New SongHeader
        filt.Load("")
        filt.Artist = ""
        filt.Title = ""
        If txtAny.Text.Length > 0 Then
            filtit = True
        End If
        If txtTitle.Text.Length > 0 Then
            filtit = True
            filt.Title = txtTitle.Text
        End If
        If txtArtist.Text.Length > 0 Then
            filtit = True
            filt.Artist = txtArtist.Text
        End If
        Dim lvi As ListViewItem
        LV.Items.Clear()
        LV.FullRowSelect = True
        LV.GridLines = True
        For Each I As SongHeader In SongBase.Items
            If filtit Then
                If I.Match(filt, txtAny.Text) Then
                    lvi = LV.Items.Add(I.Title)
                    lvi.SubItems.Add(I.Artist)
                    lvi.Tag = I.file_info.FullName
                    If rbHighlight.Checked Then
                        lvi.BackColor = Color.FromArgb(128, 220, 200)
                    End If
                ElseIf rbHighlight.Checked Then
                    lvi = LV.Items.Add(I.Title)
                    lvi.SubItems.Add(I.Artist)
                    lvi.Tag = I.file_info.FullName
                    lvi.BackColor = Color.FromArgb(200, 200, 200)
                End If
            Else
                lvi = LV.Items.Add(I.Title)
                lvi.SubItems.Add(I.Artist)
                lvi.Tag = I.file_info.FullName
            End If
        Next
        lblCt.Text = LV.Items.Count.ToString & " of " & SongBase.Items.Count.ToString & " songs"
    End Sub


    Private Sub cmdOKAY_Click(sender As Object, e As EventArgs) Handles cmdOKAY.Click
        If pnlRight.Visible Then
            If LV.SelectedItems.Count > 0 Then
                'ADD TO PLAYLIST
                Dim skipit As Boolean = False
                For Each si As ListViewItem In LV.SelectedItems
                    skipit = False
                    For Each i As ListViewItem In lvPlaylist.Items
                        If i.Tag Is si.Tag Then
                            'The selected record is already
                            'in the playlist
                            skipit = True
                        End If
                    Next
                    If Not skipit Then
                        Dim lvi As ListViewItem = lvPlaylist.Items.Add(si.Text)
                        lvi.Tag = si.Tag
                    End If
                Next
            End If
            Exit Sub
        End If
        If LV.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Public Function Selected_record() As String
        If Not Selection_Made() Then Return ""
        Return LV.SelectedItems(0).Tag
    End Function

    Public Function Multiple_selections() As Boolean
        Return LV.SelectedItems.Count > 1
    End Function

    Public Function Selection_Made() As Boolean
        Return LV.SelectedItems.Count > 0
    End Function

    Public Function Selected_records() As List(Of String)
        Dim rv As New List(Of String)
        If Not Selection_Made() Then Return rv
        For Each lvi As ListViewItem In LV.SelectedItems
            rv.Add(lvi.Tag.ToString)
        Next
        Return rv
    End Function


    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Refresh_List()
        If LV.Items.Count > 1 Then LV.Focus()
        If LV.Items.Count = 1 Then
            LV.Items(0).Selected = True
            LV.Select()
        End If
    End Sub

    Private Sub cmdPlaylist_Click(sender As Object, e As EventArgs) Handles cmdPlaylist.Click
        pnlRight.Visible = Not pnlRight.Visible
    End Sub

    Private Sub lvPlaylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPlaylist.SelectedIndexChanged
        pnlPlaylist_Tool.Enabled = lvPlaylist.SelectedItems.Count > 0
    End Sub

    Private Sub cmdSave_PL_Click(sender As Object, e As EventArgs) Handles cmdSave_PL.Click
        If lvPlaylist.Items.Count = 0 Then Exit Sub
        SD.Title = "Save Playlist"
        SD.Filter = "Playlist|*.fkbList"
        SD.DefaultExt = ".fkbList"
        If SD.ShowDialog = DialogResult.OK Then
            Dim fData$ = "", fnm$ = ""
            For Each lvi As ListViewItem In lvPlaylist.Items
                fnm = lvi.Tag.ToString
                If fnm.ToUpper.StartsWith(Global_Settings.Song_DIR.ToUpper) Then
                    fnm = "{SDIR}" & fnm.Substring(Global_Settings.Song_DIR.Length)
                End If
                fData += fnm & Chr(8)
            Next
            SaveFile(SD.FileName, fData, True)
            Me.DialogResult = DialogResult.Yes
        End If
    End Sub

    Public Sub Load_Playlist(fromList As List(Of String))
        pnlRight.Visible = True
        lvPlaylist.Items.Clear()
        For Each s As String In fromList
            For Each I As SongHeader In SongBase.Items
                If I.file_info.FullName = s Then
                    Dim lvi As ListViewItem = lvPlaylist.Items.Add(I.Title)
                    lvi.Tag = s
                    Exit For
                End If
            Next
        Next

    End Sub

    Public Sub Load_Playlist(fromLV As ListView)
        'pnlRight.Visible = True
        lvPlaylist.Items.Clear()
        For Each i As ListViewItem In fromLV.Items
            For Each H As SongHeader In SongBase.Items
                If H.file_info.FullName = i.Tag.ToString Then
                    Dim lvi As ListViewItem = lvPlaylist.Items.Add(H.Title)
                    lvi.Tag = i.Tag.ToString
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cmdPL_DELETE_Click(sender As Object, e As EventArgs) Handles cmdPL_DELETE.Click
        If lvPlaylist.SelectedItems.Count = 0 Then Exit Sub
        Dim Files_to_Remove As New List(Of String)
        For Each lvi As ListViewItem In lvPlaylist.SelectedItems
            Files_to_Remove.Add(lvi.Tag.ToString)
        Next

        Dim lss As New List(Of String)
        For Each lvi As ListViewItem In lvPlaylist.Items
            If Not Files_to_Remove.Contains(lvi.Tag.ToString) Then
                lss.Add(lvi.Tag)
            End If
        Next
        Load_Playlist(lss)
    End Sub

    Private Sub cmdPL_Up_Click(sender As Object, e As EventArgs) Handles cmdPL_Up.Click
        If lvPlaylist.SelectedItems.Count = 0 Then Exit Sub
        If lvPlaylist.SelectedItems(0).Index = 0 Then Exit Sub
        Dim lss As New List(Of String)
        Dim ix As Integer = lvPlaylist.SelectedItems(0).Index
        For t As Integer = 0 To ix - 1
            lss.Add(lvPlaylist.Items(t).Tag)
        Next
        lss.Add(lvPlaylist.Items(ix + 1).Tag.ToString)
        lss.Add(lvPlaylist.Items(ix).Tag.ToString)
        If ix + 2 >= lvPlaylist.Items.Count Then
            For t As Integer = ix + 2 To lvPlaylist.Items.Count - 1
                lss.Add(lvPlaylist.Items(t).Tag.ToString)
            Next
        End If
        Load_Playlist(lss)
    End Sub

    Private Sub cmdPL_Down_Click(sender As Object, e As EventArgs) Handles cmdPL_Down.Click
        If lvPlaylist.SelectedItems.Count = 0 Then Exit Sub
        If lvPlaylist.SelectedItems(0).Index = 0 Then Exit Sub
        Dim lss As New List(Of String)
        Dim ix As Integer = lvPlaylist.SelectedItems(0).Index
        If ix = lvPlaylist.Items.Count - 1 Then Exit Sub
        For t As Integer = 0 To ix - 1
            lss.Add(lvPlaylist.Items(t).Tag)
        Next
        lss.Add(lvPlaylist.Items(ix + 1).Tag.ToString)
        lss.Add(lvPlaylist.Items(ix).Tag.ToString)
        If ix + 2 <= lvPlaylist.Items.Count Then
            For t As Integer = ix + 2 To lvPlaylist.Items.Count - 1
                lss.Add(lvPlaylist.Items(t).Tag.ToString)
            Next
        End If
        Load_Playlist(lss)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If LV.SelectedItems.Count = 0 Then Exit Sub
        If MsgBox("Are you sure you want to delete: " & LV.SelectedItems(0).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteFile(LV.SelectedItems(0).Tag.ToString)
            SongBase.Remove_Item(LV.SelectedItems(0).Tag.ToString)
            Refresh_List()
        End If
    End Sub

    Private Sub txtTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitle.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Shift Or e.Control Then
                txtArtist.Focus()
            Else
                cmdBrowse.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged

    End Sub

    Private Sub txtArtist_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArtist.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Shift Or e.Control Then
                txtAny.Focus()
            Else
                cmdBrowse.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtAny_TextChanged(sender As Object, e As EventArgs) Handles txtAny.TextChanged

    End Sub

    Private Sub txtAny_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAny.KeyPress
    End Sub

    Private Sub txtAny_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAny.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdBrowse.PerformClick()
        End If
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub LV_DoubleClick(sender As Object, e As EventArgs) Handles LV.DoubleClick
        If LV.SelectedItems.Count = 0 Then Exit Sub
        cmdOKAY.PerformClick()
    End Sub

    Private Sub LV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LV.KeyPress
        If LV.SelectedItems.Count = 0 Then Exit Sub
        If e.KeyChar = vbCr Then cmdOKAY.PerformClick()
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub frmSearchDB_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtTitle.Select()
    End Sub
End Class