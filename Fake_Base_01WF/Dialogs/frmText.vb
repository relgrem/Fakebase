Public Class frmText
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wb As New clsLyric_Browser
        txt.Text = wb.GetPage("https://www.google.com/#q=lyrics+liviing+in+america")
    End Sub
End Class