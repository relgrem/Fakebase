Public Class frmSongEdit
    Public Song As clsSongFile
    Public FileName$ = ""
    Public Sub NewSong()
        Song = New clsSongFile
        txtName.Text = "New Song"
    End Sub

    Public Sub ShowSong(SONG As clsSongFile)
        Me.FileName = SONG.FileName
        Me.Song = SONG
        txtLyrics.Text = Normalize_LFs(SONG.Lyrics)
        txtChords.Text = Normalize_LFs(SONG.Chords)
        ' ""=        SONG.SongStructure 
        txtArtist.Text = SONG.Song.Artist
        txtBottomNote.Text = SONG.Song.BottomNote
        '""=        SONG.Song.Classifications 
        txtKey.Text = SONG.Song.Key
        txtSubTitle.Text = SONG.Song.Subtitle
        txtTempo.Text = SONG.Song.Tempo
        txtTimeSig.Text = SONG.Song.TimeSig
        txtName.Text = SONG.Song.Title
        cmbViewMode.Text = SONG.Song.ViewMode
        cmbViewSize.Text = SONG.Song.ViewSize
        txtPatch.Text = SONG.Song.Patch
    End Sub

    Private Sub Populate()
        Song.Lyrics = txtLyrics.Text
        Song.Chords = txtChords.Text
        Song.SongStructure = ""
        Song.Song.Artist = txtArtist.Text
        Song.Song.BottomNote = txtBottomNote.Text
        Song.Song.Classifications = ""
        Song.Song.Key = txtKey.Text
        Song.Song.Subtitle = txtSubTitle.Text
        Song.Song.Tempo = txtTempo.Text
        Song.Song.TimeSig = txtTimeSig.Text
        Song.Song.Title = txtName.Text
        Song.Song.ViewMode = cmbViewMode.Text
        Song.Song.ViewSize = cmbViewSize.Text
        Song.Song.Patch = txtPatch.Text
        Song.FileName = Me.FileName
    End Sub

    Private Sub cmdOKAY_Click(sender As Object, e As EventArgs) Handles cmdOKAY.Click
        If Song Is Nothing Then Song = New clsSongFile
        If Song.FileID = "" Then Song.New_song_ID()
        Populate()
        If Song.FileName = "" Then
            SD.Filter = "Fakebase Files|*.fkbkdat|All Files|*.*"
            Dim fnm$ = txtName.Text & " " & txtArtist.Text
            fnm = fnm.Replace(" ", "_")
            SD.FileName = fnm
            If SD.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            Song.FileName = SD.FileName
        End If
        Song.Save(Song.FileName)
        Me.FileName = Song.FileName
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdVerse_Click(sender As Object, e As EventArgs) Handles cmdVerse.Click
        txtChords.SelectedText = "[VERSE]" & vbCrLf
    End Sub

    Private Sub cmdChorus_Click(sender As Object, e As EventArgs) Handles cmdChorus.Click
        txtChords.SelectedText = "[CHORUS]" & vbCrLf
    End Sub

    Private Sub cmdPrechorus_Click(sender As Object, e As EventArgs) Handles cmdPrechorus.Click
        txtChords.SelectedText = "[PRE_CHORUS]" & vbCrLf
    End Sub

    Private Sub cmdBridge_Click(sender As Object, e As EventArgs) Handles cmdBridge.Click
        txtChords.SelectedText = "[BRIDGE]" & vbCrLf
    End Sub

    Private Sub cmdIntro_Click(sender As Object, e As EventArgs) Handles cmdIntro.Click
        txtChords.SelectedText = "[INTRO]" & vbCrLf
    End Sub

    Private Sub cmdB_Sec_Click(sender As Object, e As EventArgs) Handles cmdB_Sec.Click
        txtChords.SelectedText = "[B_SECTION]" & vbCrLf
    End Sub

    Private Sub mnuAddChords_Click(sender As Object, e As EventArgs) Handles mnuAddChords.Click
        Dim f As New frmChords
        If f.ShowDialog = DialogResult.OK Then
            Dim c$ = ""
            For Each lvi As ListViewItem In f.LV.Items
                c$ += lvi.Text + "{" & lvi.SubItems(1).Text & "},"
            Next
            txtChords.SelectedText = c
        End If
    End Sub

    Sub RenderChords()
        If txtChords.Text.StartsWith("<") Then
            picChords.SizeMode = PictureBoxSizeMode.AutoSize
            RenderHybrid()
            Exit Sub
        End If
        Dim CP As New clsChordParser
        If txtChords.SelectionLength > 0 Then
            CP.Load(txtChords.SelectedText)
        Else
            CP.Load(txtChords.Text)
        End If
        picChords.SizeMode = PictureBoxSizeMode.AutoSize
        CP.Parse_Sections_into_lines(Me.Song.Song.Beats_Per_Measure, pnlChordRend.Width - VS.Width)
        picChords.Width = pnlChordRend.Width - VS.Width

        Dim b As Bitmap
        Dim H As Integer = (CP.LineCount() + 1) * 200
        '
        b = New Bitmap(pnlChordRend.Width - VS.Width, H)
        Dim g As Graphics
        g = Graphics.FromImage(b)
        Render_Chord_Chart(g, CP)
        picChords.Image = b
        'picChords.Image = Render_Chords(CP, pnlChordRend.Width - VS.Width, Me.Song.Song.Beats_Per_Measure)
        g.Dispose()
        b = Nothing
    End Sub

    Sub RenderHybrid()
        Dim g As Graphics
        picChords.Image = Render_Hybrid_Chart(g, txtChords.Text, pnlChordRend.Width - VS.Width)
        g.Dispose()
    End Sub

    Private Sub txtChords_TextChanged(sender As Object, e As EventArgs) Handles txtChords.TextChanged
        RenderChords()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdC_Add_Click(sender As Object, e As EventArgs) Handles cmdC_Add.Click
        mnuAddChords.PerformClick()
    End Sub

    Private Sub cmdInternet_Click(sender As Object, e As EventArgs) Handles cmdInternet.Click
        Dim LB As New clsLyric_Browser
        Cursor.Current = Cursors.WaitCursor
        LB.LookFor(txtName.Text, txtArtist.Text)
        If LB.result_lines.Count > 1 Then
            Dim f As New frmLV
            f.LV.Font = New Font("Ariel", 18)
            f.QuickList(LB.result_lines)
            If f.ShowDialog = DialogResult.OK Then
                LB.Lyrics_Found = LB.Get_AZ_Lyrics(f.Selected_Row.SubItems(3).Text)
                txtLyrics.Text = Normalize_LFs(LB.Lyrics_Found)
            End If
            f.Dispose()
            Exit Sub
        End If
        If LB.result_lines.Count = 1 Then
            LB.Lyrics_Found = LB.Get_AZ_Lyrics(LB.result_lines(0).URL)
            txtLyrics.Text = Normalize_LFs(LB.Lyrics_Found)
        ElseIf LB.Lyrics_Found.Length > 0 Then
            txtLyrics.Text = Normalize_LFs(LB.Lyrics_Found)
        Else
            lblSts.Text = "No results found - " & txtName.Text & " - " & txtArtist.Text
        End If
        LB = Nothing
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdLyrTab_Click(sender As Object, e As EventArgs) Handles cmdLyrTab.Click
        txtLyrics.SelectedText = vbTab
    End Sub

    Private Sub cmdLyrSpace_Click(sender As Object, e As EventArgs) Handles cmdLyrSpace.Click
        txtLyrics.SelectedText = " "
    End Sub

    Private Sub cmdLyrEnter_Click(sender As Object, e As EventArgs) Handles cmdLyrEnter.Click
        txtLyrics.SelectedText = vbCrLf
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtLyrics.SelectionStart < txtLyrics.Text.Length Then
            Dim ix% = txtLyrics.SelectionStart
            Dim a$ = txtLyrics.Text
            txtLyrics.Text = a.Substring(0, ix) & a.Substring(ix + 1)
            Try
                txtLyrics.SelectionStart = ix
                txtLyrics.ScrollToCaret()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmdFindChords_Click(sender As Object, e As EventArgs) Handles cmdFindChords.Click
        Dim CSRCH As New clsTab_Browser
        CSRCH.Search(txtName.Text, txtArtist.Text)
        If CSRCH.Result_String.Length > 0 Then
            txtLyrics.Text = CSRCH.Result_String.Replace(vbLf, vbCrLf)
            'Dim m$ = ""
            'For t As Integer = 0 To 250
            'm += Format(t, "000") & " - " & Asc(CSRCH.Result_String.Substring(t, 1)) & vbCrLf
            'Next
            'txtLyrics.Text = m
        Else
            lblSts.Text = "No chord results found."
        End If

    End Sub

    Private Sub Byte_View(sender As Object, e As EventArgs) Handles cmdViewBytes.Click
        Dim f As New frmLV
        f.Add_Column("Pos", 50)
        f.Add_Column("Char", 70)
        f.Add_Column("ASC", 70)
        For t As Integer = 0 To txtLyrics.Text.Length - 1
            f.Add_row(t.ToString, txtLyrics.Text.Substring(t, 1), Asc(txtLyrics.Text.Substring(t, 1)).ToString)
        Next
        f.HighLight(2, "10", Color.GreenYellow)
        f.HighLight(2, "13", Color.GreenYellow)
        f.HighLight(2, "8", Color.Yellow)
        f.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtLyrics.Text = txtLyrics.Text.Replace(vbCrLf & vbCrLf, vbCrLf)
    End Sub

    Private Sub cmdCompress3_Click(sender As Object, e As EventArgs) Handles cmdCompress3.Click
        If txtLyrics.SelectionLength > 10 Then
            Dim EXT$ = txtLyrics.SelectedText
            Dim c As Char() = EXT.ToCharArray
            Dim tgl As Boolean
            Dim rv2$ = ""
            For Each cc As Char In c
                If cc = vbLf Then
                    tgl = Not tgl
                    If tgl Then
                        rv2 += " \ "
                    Else
                        rv2 += vbCrLf
                    End If
                ElseIf cc = vbCr Then
                    'do nothing
                Else
                    rv2 += cc
                End If
            Next
            txtLyrics.SelectedText = rv2
            Exit Sub
        End If
        Dim LNS As String() = txtLyrics.Lines
        Dim rv$ = ""
        Dim buf$ = ""
        Dim longest_line% = 0
        For t As Integer = 0 To LNS.Count - 2
            buf = LNS(t) & " " & LNS(t + 1)
            If buf.Length > longest_line Then longest_line = buf.Length
        Next
        Dim lptr% = 0
        Dim bz% = 0
        Do
            If lptr = LNS.Count - 1 Then
                rv += LNS(lptr)
            Else
                If LNS(lptr).Length < 3 Then
                    rv += vbCrLf
                    lptr += 1
                Else
                    If LNS(lptr).StartsWith("[") Then
                        rv += LNS(lptr) & vbCrLf
                        lptr += 1
                    Else
                        If LNS(lptr + 1).Length > 2 Then
                            bz = LNS(lptr).Length + LNS(lptr + 1).Length
                            'rv += LNS(lptr) & StrDup(longest_line - bz, " ") & LNS(lptr + 1) & vbCrLf
                            rv += LNS(lptr) & "  \  " & LNS(lptr + 1) & vbCrLf
                            lptr += 2
                        Else
                            rv += LNS(lptr) & vbCrLf & vbCrLf
                            lptr += 2
                        End If
                    End If
                End If
            End If
        Loop Until lptr >= LNS.Count - 1
        txtLyrics.Text = rv
    End Sub

    Private Sub cmdLyric_alt_search_Click(sender As Object, e As EventArgs) Handles cmdLyric_alt_search.Click
        Dim LB As New clsLyric_Browser
        Cursor.Current = Cursors.WaitCursor
        LB.Find_Matches(txtName.Text, txtArtist.Text)
        If LB.Match_Buffer.Count = 0 Then

            lblSts.Text = "No results found - " & txtName.Text & " - " & txtArtist.Text
        Else
            Dim f As New frmLV
            f.QuickList(LB.Match_Buffer, "Search Result")
            If f.ShowDialog = DialogResult.OK Then
                txtLyrics.Text = LB.Get_AZ_Lyrics("https://" + f.LV.SelectedItems(0).Text)
            End If
        End If

        LB = Nothing
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub txtChords_KeyDown(sender As Object, e As KeyEventArgs) Handles txtChords.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case 32
                    txtChords.SelectedText = "{4},"
                Case 52
                    txtChords.SelectedText = "{16},"
                Case 51
                    txtChords.SelectedText = "{12},"
                Case 50
                    txtChords.SelectedText = "{8},"
                Case 49
                    txtChords.SelectedText = "{2},"
            End Select
        End If
        If e.Shift Then
            If e.KeyCode = 32 Then txtChords.SelectedText = "{2},"
        End If
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        txtName.Text = String_Camel_Case(txtName.Text)
    End Sub

    Private Sub txtArtist_LostFocus(sender As Object, e As EventArgs) Handles txtArtist.LostFocus
        txtArtist.Text = String_Camel_Case(txtArtist.Text)
    End Sub

    Private Sub picChords_Click(sender As Object, e As EventArgs) Handles picChords.Click
        If txtChords.Text.StartsWith("<") Then
            Dim Chart As New clsHybridParser
            Chart.Initialize(txtChords.Text, pnlChordRend.Width - VS.Width)
            Dim f As New frmLV
            f.Add_Column("INX", 80)
            f.Add_Column("Type", 100)
            f.Add_Column("Text", 100)
            f.Add_Column("Image", 100)
            f.Add_Column("X", 80)
            f.Add_Column("Y", 80)
            f.Add_Column("Line", 80)
            '
            Dim ix% = 0
            For Each I As Sheet_Render_element In Chart.Elements
                ix += 1
                f.Add_Row(ix.ToString, I)
            Next
            f.Show()
        End If
    End Sub
End Class