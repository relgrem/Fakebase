Public Class frmPlayer
    Public Current_Record As New clsSongFile
    Public Current_SBase_Item As SongHeader
    Dim CP As New clsChordParser
    '
    Public Image1 As Image
    Private g As Graphics
    Private b As Bitmap
    '
    Public Zoom As Double = 1
    Dim sr As New Rectangle
    Dim dr As New Rectangle
    '
    Dim sw%
    Dim sh%
    Dim czy%
    Dim czx%
    Dim xOffest%
    Dim yOffset%
    Dim chart_width% = 100
    Dim chart_height% = 100
    Dim ix%
    Dim v$
    Dim StartX As Integer
    Dim StartY As Integer
    Dim PlayLists_Loaded As New List(Of String)
    Dim auto_focus_skip% = 0
    '
    Friend WithEvents Screen2 As frmScreen2

    Public Sub Load_Song(FileName$)
        Current_Record.Load(FileName)
        CP = Nothing
        CP = New clsChordParser
        picChart.Width = Me.chart_width
        CP.Load(Current_Record.Chords)
        CP.Parse_Sections_into_lines(Current_Record.Song.Beats_Per_Measure, Me.chart_width)
        cmdEdit.Enabled = True
        '---------------------------------------------------------
    End Sub


    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        CD.Filter = "Song (*.fkbkdat)|*.fkbkdat|Play List|*.fkbList|All Files|*.*"
        If CD.ShowDialog = DialogResult.OK Then
            Dim fnm$
            If CD.FileNames.Count > 1 Then
                For Each filename As String In CD.FileNames
                    fnm = filename
                    If CD.FilterIndex = 2 Then

                    Else

                    End If
                Next
            Else
                If CD.FilterIndex = 2 Then
                    Dim ix = Me.PlayLists_Loaded.Count + 1
                    PlayLists_Loaded.Add(CD.FileName)
                    cmbPlayList.Items.Add(String_Filename(CD.FileName))
                    Load_PlayList(CD.FileName)
                Else
                    Load_Song(CD.FileName)
                    refresh_song()
                End If
            End If
        End If
    End Sub


    Sub Load_PlayList(filename As String)
        Dim lDat As String = LoadFile(filename)
        Dim recs As String() = lDat.Split(vbBack)
        LV.Items.Clear()
        Cursor.Current = Cursors.WaitCursor
        Dim lvi As ListViewItem
        Dim fnm$ = ""
        For Each s As String In recs
            fnm = s.Replace("{SDIR}", Global_Settings.Song_DIR)
            For Each I As SongHeader In SongBase.Items
                If I.file_info.FullName.ToUpper = fnm.ToUpper Then
                    lvi = LV.Items.Add(I.Title)
                    lvi.Tag = I
                    Exit For
                End If
            Next
        Next
        pnlLeft.Visible = True
        If LV.Items.Count > 0 Then
            LV.Items(0).Selected = True
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Sub Load_PlayList(songs As List(Of String))
        Cursor.Current = Cursors.WaitCursor
        Dim lvi As ListViewItem
        Dim fnm$ = ""
        For Each s As String In songs
            fnm = s.Replace("{SDIR}", Global_Settings.Song_DIR)
            For Each I As SongHeader In SongBase.Items
                If I.file_info.FullName.ToUpper = fnm.ToUpper Then
                    lvi = LV.Items.Add(I.Title)
                    lvi.Tag = I
                    Exit For
                End If
            Next
        Next
        pnlLeft.Visible = True
        If LV.Items.Count > 0 Then
            LV.Items(0).Selected = True
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Sub Play_List_Select()
        If LV.SelectedItems.Count = 0 Then Exit Sub
        Try
            Current_SBase_Item = LV.SelectedItems(0).Tag
            Current_Record.Load(Current_SBase_Item.file_info.FullName)
            refresh_song()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        Dim f As New frmExport
        If f.ShowDialog = DialogResult.OK Then
            lblStatus.Text = "Running Export"
            Dim workload As New List(Of SongHeader)
            Dim data$ = "", exFile$ = ""
            Dim ni As SongHeader
            Dim S As clsSongFile
            Dim PP As New clsImagePrinter
            Select Case f.SaveMode
                Case "PLAYLIST"
                    For Each LVI As ListViewItem In LV.Items ' As SongHeader In SongBase.Items
                        ni = LVI.Tag
                        workload.Add(ni)
                        ni = Nothing
                    Next
                Case Else
                    For Each I As SongHeader In SongBase.Items
                        workload.Add(I)
                    Next
            End Select
            PB.Maximum = workload.Count
            PB.Value = 0
            If f.Run_TAB Then
                data = String_Tab_Delim({"Title", "Artist", "Key", "Patch"})
            End If
            If f.Run_PDF Then

            End If
            If f.Run_Files Then

            End If
            For Each I As SongHeader In workload
                If f.Run_TAB Then
                    data += nString(I.Title) & vbTab
                    data += nString(I.Artist) & vbTab
                    data += nString(I.Key) & vbTab
                    data += nString(I.Patch)
                    data += vbCrLf
                End If
                If f.Run_PDF Then
                    Try
                        exFile = f.Path_PDF & "\" & String_Filename(I.file_info.FullName) & ".pdf"
                        If My.Computer.FileSystem.FileExists(exFile) Then
                            exFile = f.Path_PDF & "\copy of - " & String_Filename(I.file_info.FullName) & ".pdf"
                        End If
                        PP.Clear()
                        Dim PDoc As New PdfSharp.Pdf.PdfDocument
                        PDoc.Info.Title = I.Title
                        PP.Initialize(True)
                        S = New clsSongFile
                        S.Load(I.file_info.FullName)
                        PP.Render_Chart(S)
                        PP.Save_PDF(exFile)
                    Catch ex As Exception
                        If MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "PDF Save Error") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If
                    End Try
                End If
                If f.Run_Files Then
                    exFile = f.Path_FileCopy & "\" & String_Filename(I.file_info.FullName)
                    If My.Computer.FileSystem.FileExists(exFile) Then
                        exFile = f.Path_FileCopy & "\copy of - " & String_Filename(I.file_info.FullName)
                    End If
                    If Not My.Computer.FileSystem.FileExists(exFile) Then
                        My.Computer.FileSystem.CopyFile(I.file_info.FullName, exFile)
                    End If
                End If
                PB.Value += 1
            Next
            'LOOP DONE
            If f.Run_TAB Then
                SaveFile(f.FileName, data, True)
            End If
            If f.Run_PDF Then

            End If
            If f.Run_Files Then

            End If
            PP = Nothing
        End If
        f.Dispose()

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Dim f As New frmSongEdit
        f.NewSong()
        If f.ShowDialog() = DialogResult.OK Then
            Load_Song(f.FileName)
            refresh_song()
            SongBase.Load_If_Missing(f.FileName)
        End If
        f.Dispose()
    End Sub


    Private Sub frmPlayer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Start_up()
        pnlLeft.Width = Global_Settings.Playlist_Width
    End Sub


    Private Sub Find_In_DB(sender As Object, e As EventArgs) Handles cmdFindInDB.Click
        Dim f As New frmSearchDB
        f.Refresh_List()
        f.WindowState = FormWindowState.Maximized

        If pnlLeft.Visible Then
            'Play list is active
            f.Load_Playlist(Me.LV)
        End If
        Dim drst As DialogResult = f.ShowDialog
        If drst = DialogResult.OK Then
            If f.Multiple_selections Then
                Load_PlayList(f.Selected_records)
            End If
            Load_Song(f.Selected_record)
            refresh_song()
            cmdEdit.Enabled = True
            lblFileName.Text = f.Selected_record
            VS.Focus()
        ElseIf drst = DialogResult.Yes Then
            Load_PlayList(f.SD.FileName)
        End If

    End Sub


    Sub refresh_song()
        VS.Value = 0
        If Me.Current_Record.Song.ViewMode = "Hybrid" Then
            RenderHybridChart()
        Else
            Render_Chart()
            Render_Lyrics()
        End If
        lblSong_artist.Text = Me.Current_Record.Song.Artist
        lblSong_Key.Text = Me.Current_Record.Song.Key
        lblSong_Patch.Text = Me.Current_Record.Song.Patch
        lblSong_Tempo.Text = Me.Current_Record.Song.Tempo
        lblSong_title.Text = Me.Current_Record.Song.Title
        Select Case Me.Current_Record.Song.ViewMode
            Case "Lyrics Only"
                SC.Panel1Collapsed = True
            Case "Hybrid"
                SC.Panel1Collapsed = True

            Case Else
                'Auto
                If Me.Current_Record.Chords.Length < 10 Then
                    SC.Panel1Collapsed = True
                Else
                    SC.Panel1Collapsed = False
                End If
        End Select
        lblFileName.Text = Me.Current_Record.FileName
        VS_Top.LargeChange = SC.Panel1.Height
        VS_Top.Maximum = Me.chart_height
        VS.Maximum = pic.Height
        VS.LargeChange = SC.Panel2.Height
        Try
            If Screen2 IsNot Nothing Then
                Screen2.Update_Lyrics(pic.Image)
            End If
        Catch ex As Exception

        End Try
        pic.Top = 0
    End Sub


    Sub Render_Lyrics()
        VS.Value = 0
        Dim ls$ = ""
        Dim rs$ = ""
        Dim cptr% = 0
        Dim rw% = 0
        Dim rendxy As Integer = Global_Settings.Default_Size
        If Me.Current_Record.Song.V_Size > 0 Then rendxy = Current_Record.Song.V_Size
        Dim cty As Integer = 4
        Dim LyricLines As String() = Me.Current_Record.Lyrics.Split(vbLf)
        Dim maxwid As Integer = 0
        Dim maxlines As Integer = LyricLines.Count
        For Each L As String In LyricLines
            If L.Length > maxwid Then maxwid = L.Length
        Next
        If Not b Is Nothing Then
            b.Dispose()
            b = Nothing
        End If
        If maxwid = 0 Then maxwid = 1
        If maxlines = 0 Then maxlines = 1
        Dim H As Integer = ((maxlines + 1) * (rendxy * 1.5)) + 10
        Dim W As Integer = SC.Width - VS.Width  '(maxwid + 4) * rendxy + 1
        '
        b = New Bitmap(W, H)
        '
        pic.BackColor = Color.White
        'pic.Width = dr.Width
        'pic.Height = dr.Height
        '
        Dim f As Font = New Font("Ariel", 24)
        Dim br As Brush = New SolidBrush(Color.Black)
        Dim g As Graphics
        g = Graphics.FromImage(b)
        g.Clear(Color.White)
        For Each L As String In LyricLines
            If L.Contains("|") Then
                cptr = L.IndexOf("|")
                rs = L.Substring(cptr + 1)
                ls = L.Substring(0, cptr)
                g.DrawString(ls, f, br, 10, cty)
                rw = g.MeasureString(rs, f).Width
                g.DrawString(rs, f, br, W - 10 - rw, cty)
            ElseIf L.Contains("\") Then
                cptr = L.IndexOf("\")
                rs = L.Substring(cptr + 1).Trim
                ls = L.Substring(0, cptr).Trim
                g.DrawString(ls, f, br, 10, cty)
                g.DrawString(rs, f, br, (W / 2) + 20 - rw, cty)
            Else
                g.DrawString(L, f, br, 10, cty)
            End If
            cty += Int(rendxy * 1.5)
        Next
        pic.Image = b
        g.Dispose()
        VS.Maximum = pic.Height
        VS.LargeChange = SC.Panel2.Height
    End Sub

    Sub Render_Chart()
        Dim b As Bitmap
        Dim H As Integer = Get_Chord_Chart_Height(CP, chart_width)
        b = New Bitmap(chart_width, H)
        Dim g As Graphics
        g = Graphics.FromImage(b)
        g.Clear(Color.White)
        Render_Chord_Chart(g, CP, chart_width)
        Me.chart_height = Bottom_Y
        pic.Height = H
        picChart.Image = b
        g.Dispose()
        b = Nothing
        If Bottom_Y < 601 Then SC.SplitterDistance = Bottom_Y
    End Sub

    Sub RenderHybridChart()
        Dim g As Graphics
        pic.Image = Render_Hybrid_Chart(g, Me.Current_Record.Chords, chart_width)
        g.Dispose()
        If Bottom_Y < 601 Then SC.SplitterDistance = Bottom_Y
    End Sub

    Private Sub VS_Scroll_1(sender As Object, e As ScrollEventArgs) Handles VS.Scroll
        pic.Top = -VS.Value
    End Sub

    Private Sub VS_Top_Scroll(sender As Object, e As ScrollEventArgs) Handles VS_Top.Scroll
        picChart.Top = -VS_Top.Value
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim f As New frmSongEdit
        f.ShowSong(Me.Current_Record)
        If f.ShowDialog() = DialogResult.OK Then
            Load_Song(f.FileName)
            refresh_song()
        End If
        f.Dispose()
    End Sub

    Private Sub frmPlayer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.chart_width = SC.Width - VS_Top.Width
    End Sub

    Private Sub SC_SizeChanged(sender As Object, e As EventArgs) Handles SC.SizeChanged
        VS_Top.LargeChange = SC.Panel1.Height
        VS_Top.Maximum = picChart.Height
        VS.Maximum = pic.Height
        VS.LargeChange = SC.Panel2.Height
    End Sub

    Private Sub SC_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SC.SplitterMoved
        VS_Top.LargeChange = SC.Panel1.Height
        VS_Top.Maximum = picChart.Height
         VS.Maximum = pic.Height
        VS.LargeChange = SC.Panel2.Height
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrint
        f.Initialize(Me.Current_Record)
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count > 0 Then
            Current_SBase_Item = (LV.SelectedItems(0).Tag)
            Load_Song(Current_SBase_Item.file_info.FullName)
            refresh_song()
            pic.Top = 0
            cmdEdit.Enabled = True
        End If
    End Sub

    Private Sub cmdPL_UP_Click(sender As Object, e As EventArgs) Handles cmdPL_UP.Click
        If LV.Items.Count = 0 Then Exit Sub
        ix = LV.SelectedItems(0).Index - 1
        If ix < 0 Then ix = LV.Items.Count - 1
        LV.SelectedItems.Clear()
        LV.Items(ix).Selected = True
    End Sub

    Private Sub cmdPL_Down_Click(sender As Object, e As EventArgs) Handles cmdPL_Down.Click
        ix = selected_playlist_index() + 1
        LV.SelectedItems.Clear()
        If ix >= LV.Items.Count Then ix = 0
        LV.Items(ix).Selected = True
    End Sub

    Function selected_playlist_index() As Integer
        If LV.SelectedItems.Count = 0 Then Return -1
        Return LV.SelectedItems(0).Index
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlLeft.Visible = False
    End Sub

    Private Sub frmPlayer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Dim kk$ = e.KeyData.ToString & ","
            If kk = "," Then Exit Sub
            If Global_Settings.Key_Map_Find_Button.Contains(kk) Then
                cmdFindInDB.PerformClick()
            End If
            If Global_Settings.Key_Map_Lyrics_Down.Contains(kk) Then
                If (VS.Value + Int(VS.LargeChange * 0.9)) <= VS.Maximum Then
                    VS.Value += Int(VS.LargeChange * 0.9)
                Else
                    VS.Value = 0
                End If
                If VS.Value > VS.Maximum - VS.LargeChange Then VS.Value = VS.Maximum - VS.LargeChange
                pic.Top = -VS.Value
            End If
            If Global_Settings.Key_Map_Playlist_Down.Contains(kk) Then
                cmdPL_Down.PerformClick()
            End If
            If Global_Settings.Key_Map_Playlist_Up.Contains(kk) Then
                cmdPL_UP.PerformClick()
            End If
            If Global_Settings.Key_Map_Toggle_Playlist.Contains(kk) Then
                pnlLeft.Visible = Not pnlLeft.Visible
            End If
            If Global_Settings.Key_Map_Toggle_Chords.Contains(kk) Then
                SC.Panel1Collapsed = Not SC.Panel1Collapsed
            End If
            If Global_Settings.Key_Map_Lyrics_Mode.Contains(kk) Then
                rbS2_Lyrics.Checked = True
            End If
            If Global_Settings.Key_Map_Slide_Show.Contains(kk) Then
                rbSS_Slideshow_Mode.Checked = True
            End If
            If Global_Settings.Key_Map_Lyrics_Top.Contains(kk) Then
                VS.Value = 0
                pic.Top = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdRemoteScreen_Click_1(sender As Object, e As EventArgs) Handles cmdRemoteScreen.Click
        Try
            If Screen2 IsNot Nothing Then
                Screen2.Dispose()
                Screen2 = Nothing
            End If
            Screen2 = New frmScreen2
            Screen2.Show()
            If Global_Settings.Slide_Show_DIR <> "" Then
                If My.Computer.FileSystem.DirectoryExists(Global_Settings.Slide_Show_DIR) Then
                    Screen2.Start_SS_Mode(Global_Settings.Slide_Show_DIR, Global_Settings.Slide_Speed * 1000)
                End If
            End If
            pnlSS.Width = 305
        Catch ex As Exception
            Screen2 = Nothing
        End Try
    End Sub

    Sub Handle_SS_Change(sender As Object, Img_Thumb As Image) Handles Screen2.Image_Changed
        picSS_View.Image = Img_Thumb
        Exit Sub
        b = Nothing
        b = New Bitmap(picSS_View.Width, picSS_View.Height)
        g = Graphics.FromImage(b)
        g.DrawImage(Img_Thumb, b.Width, b.Height)
        picSS_View.Image = b
    End Sub

    Private Sub cmdSys_Click(sender As Object, e As EventArgs) Handles cmdSys.Click
        Dim f As New frmSystem
        f.Initialize()
        If f.ShowDialog() = DialogResult.OK Then
            Global_Settings.Save()

        End If
        f.Dispose()
    End Sub

    Private Sub TMR_Tick(sender As Object, e As EventArgs) Handles TMR.Tick
        If auto_focus_skip > 0 Then
            auto_focus_skip -= 1
            Exit Sub
        End If
        btnFocus.Select()
    End Sub

    Private Sub cmdPL_Load_Click(sender As Object, e As EventArgs) Handles cmdPL_Load.Click
        CD.Filter = "Play List|*.fkbList|All Files|*.*"
        If CD.ShowDialog = DialogResult.OK Then
            Load_PlayList(CD.FileName)
        End If
    End Sub

    Private Sub cmdPL_Clear_Click(sender As Object, e As EventArgs) Handles cmdPL_Clear.Click
        If MsgBox("Clear All Playlists?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            LV.Items.Clear()
            cmbPlayList.Items.Clear()
            PlayLists_Loaded.Clear()
        End If
    End Sub

    Private Sub CTX_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CTX.Opening

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SD.Title = "Save Playlist"
        SD.Filter = ""
        SD.Filter = "Playlist|*.fkbList"
        SD.DefaultExt = ".fkbList"
        Try
            If SD.ShowDialog = DialogResult.OK Then
                Dim fData$ = "", fnm$ = ""
                For Each lvi As ListViewItem In LV.Items
                    Current_SBase_Item = lvi.Tag
                    fnm = Current_SBase_Item.file_info.FullName
                    If fnm.ToUpper.StartsWith(Global_Settings.Song_DIR.ToUpper) Then
                        fnm = "{SDIR}" & fnm.Substring(Global_Settings.Song_DIR.Length)
                    End If
                    fData += fnm & Chr(8)
                Next
                SaveFile(SD.FileName, fData, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "save Playlist Error")
        End Try
    End Sub

    Private Sub cmdDropdownPLMenu_Click(sender As Object, e As EventArgs) Handles cmdDropdownPLMenu.Click
        CTX.Location = New Point(75, 75)
        CTX.Show()
    End Sub

    Private Sub mnuLoadPlaylist_Click(sender As Object, e As EventArgs) Handles mnuLoadPlaylist.Click
        CD.Filter = "Play List|*.fkbList|All Files|*.*"
        If CD.ShowDialog = DialogResult.OK Then
            Dim ix = Me.PlayLists_Loaded.Count + 1
            PlayLists_Loaded.Add(CD.FileName)
            cmbPlayList.Items.Add(String_Filename(CD.FileName))
            Load_PlayList(CD.FileName)
        End If
    End Sub

    Private Sub cmbPlayList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayList.SelectedIndexChanged
        Try
            For Each s As String In Me.PlayLists_Loaded
                If cmbPlayList.Text = String_Filename(s) Then
                    Load_PlayList(s)
                    auto_focus_skip = 0
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbPlayList_DropDown(sender As Object, e As EventArgs) Handles cmbPlayList.DropDown
        auto_focus_skip = 5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim fnm$ = App_path & "Fakebase.pdf"
            System.Diagnostics.Process.Start(fnm, "")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Help Doc Not Found")
        End Try
    End Sub
End Class
