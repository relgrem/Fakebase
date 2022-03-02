Public Class frmExport
    Public SaveMode = ""
    Public FileName$ = ""
    Public Path_PDF$ = ""
    Public Path_FileCopy$ = ""

    Public Sub PlaylistActivate()
        rbPlaylist.Enabled = True
    End Sub

    Private Sub cdmOK_Click(sender As Object, e As EventArgs) Handles cdmOK.Click
        Me.SaveMode = "DB"
        If rbPlaylist.Checked Then
            Me.SaveMode = "PLAYLIST"
        End If
        If chkTabzors.Checked Then
            SD.DefaultExt = ".txt"
            SD.Filter = "Text Files|*.txt|All Files|*.*"
            SD.Title = "TAB FILE SAVE"
            If SD.ShowDialog = DialogResult.OK Then
                Me.FileName = SD.FileName
            Else
                Exit Sub
            End If
        End If
        If chkPDFs.Checked Then
            FBD.Description = "PDF Export Directory"
            FBD.SelectedPath = Global_Settings.Song_DIR
            If FBD.ShowDialog = DialogResult.OK Then
                Me.Path_PDF = FBD.SelectedPath
            Else
                Exit Sub
            End If
        End If
        If chkFiles.Checked Then
            FBD.Description = "Fakebook Song File Export Directory"
            FBD.SelectedPath = Global_Settings.Song_DIR
            If FBD.ShowDialog = DialogResult.OK Then
                Me.Path_FileCopy = FBD.SelectedPath
            Else
                Exit Sub
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Public Function Run_TAB() As Boolean
        Return chkTabzors.Checked
    End Function
    Public Function Run_PDF() As Boolean
        Return chkPDFs.Checked
    End Function
    Public Function Run_Files() As Boolean
        Return chkFiles.Checked
    End Function

End Class