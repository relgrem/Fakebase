Public Class frmSystem

    Public Sub Initialize()
        PG.SelectedObject = Global_Settings
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class