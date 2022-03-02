Public Class frmPrint
    Dim PP As New clsImagePrinter
    Private S As clsSongFile
    Public Sub Initialize(WithSong As clsSongFile)
        Me.S = WithSong
        PP.Render_Chart(WithSong)
        Print_Preview.Initialize(PP)
        lblPrinter1.Text = PD.PrinterSettings.PrinterName
    End Sub

    Private Sub cmdChangePrinter_Click(sender As Object, e As EventArgs) Handles cmdChangePrinter.Click
        PD.ShowDialog()
        lblPrinter1.Text = PD.PrinterSettings.PrinterName
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim printDoc As New System.Drawing.Printing.PrintDocument()
        printDoc.PrinterSettings = PD.PrinterSettings
        printDoc.DocumentName = "Chart (" & S.Song.Title & ")"
        PP.Initialize()
        PP.Print(printDoc)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Sub Print_PDF(SongFile As clsSongFile, ToFile$)
        Try
            PP.Clear()
            Dim PDoc As New PdfSharp.Pdf.PdfDocument
            PDoc.Info.Title = SongFile.Song.Title
            PP.Initialize(True)
            PP.Render_Chart(SongFile)
            PP.Save_PDF(ToFile)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Save Error")
        End Try
    End Sub

    Private Sub cmdSavePDF_Click(sender As Object, e As EventArgs) Handles cmdSavePDF.Click
        SD.Filter = "PDF Document (*.pdf)|*.pdf|All Files|*.*"
        SD.DefaultExt = ".pdf"
        SD.FileName = (S.Song.Title & " -by " & S.Song.Artist).Trim
        If SD.ShowDialog = DialogResult.OK Then
            Print_PDF(S, SD.FileName)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class