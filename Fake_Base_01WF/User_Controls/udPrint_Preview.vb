Public Class udPrint_Preview
    Private pObj As New clsImagePrinter
    Public Sub Initialize(FromPrint As clsImagePrinter)
        pic.SizeMode = PictureBoxSizeMode.AutoSize
        Me.pObj = FromPrint
        Show_Page(0)
    End Sub

    Public Sub Show_Page(Index As Integer)
        Try
            pic.Image = pObj.Images(Index)
        Catch ex As Exception

        End Try
    End Sub
End Class
