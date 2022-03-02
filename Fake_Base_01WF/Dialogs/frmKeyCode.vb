Public Class frmKeyCode
    Public Key_Code_String = ""
    Public Sub Initialize(Value As Object)
        Try
            Me.Key_Code_String = Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Me.Key_Code_String = lblKeys.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtKeyCatcher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyCatcher.KeyDown
        If lblKeys.Text.Length > 0 Then
            lblKeys.Text += ","
        End If
        lblKeys.Text += e.KeyData.ToString
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtKeyCatcher.Text = ""
        lblKeys.Text = ""
        txtKeyCatcher.Select()
    End Sub
End Class