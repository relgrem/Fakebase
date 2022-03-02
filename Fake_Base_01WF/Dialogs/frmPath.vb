Public Class frmPath
    Public Selected_Path As String = ""
    Public Sub Initialize(Value As Object)
        Try
            Selected_Path = Value.ToString
            txtPath.Text = Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Me.Selected_Path = txtPath.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FBD.SelectedPath = txtPath.Text
        If FBD.ShowDialog = DialogResult.OK Then
            txtPath.Text = FBD.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPath.Text = App_path
    End Sub

End Class