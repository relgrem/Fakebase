Imports System.Drawing.Printing
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class clsImagePrinter
    Public PDF_Mode As Boolean = False
    Public FrameIndex As Integer
    Public ImageIndex As Integer
    Public Images As IList(Of Image) = New List(Of Image)()
    Public CurrentImage As Image
    '
    Private S As New clsSongFile
    Private CP As New clsChordParser
    '
    Private b As Bitmap
    Private g As Graphics
    Private gPDF As XGraphics
    Private gDoc As PdfDocument
    Private PdfPage As PdfPage
    Private GDIG As Object
    Private br As Brush = New SolidBrush(Color.Black)
    Private pw% = 0
    Private ph% = 0
    Private px As Single = 0
    Private py As Single = 0
    Private sz As SizeF
    '
    Public H% = 1650
    Public W% = 1275
    Public LyricFont As Font = New Font("Ariel", 24)
    Public TitleFont As Font = New Font("Ariel", 48)
    Public SubTitleFont As Font = New Font("Ariel", 20)
    Public YSpace_LyricLine% = 40
    '
    '---------------------------------------------------------------------------
    'PDF Sharp Graphics Objects
    Public pdfLyricFont As XFont = New XFont("Ariel", 24)
    Public pdfTitleFont As XFont = New XFont("Ariel", 48)
    Public pdfSubTitleFont As XFont = New XFont("Ariel", 20)
    Private sz_pdf As XSize
    '---------------------------------------------------------------------------

    Public Sub Clear()
        CurrentImage = Nothing
        CP = Nothing
        CP = New clsChordParser

        Try
            Images.Clear()
        Catch ex As Exception
        End Try
        FrameIndex = 0
        ImageIndex = 0
    End Sub

    Public Sub Render_Chart(FromSong As clsSongFile)
        Me.S = FromSong
        If S.Song.ViewMode = "Hybrid" Then
            print_Render_Hybrid()
        End If
        CP.Load(S.Chords)
        CP.Parse_Sections_into_lines(S.Song.Beats_Per_Measure, W - 100)
        New_render_Page()
        render_title()
        Dim chH As Integer = Get_Chord_Chart_Height(CP, W)
        Dim LL% = 0
        If PDF_Mode Then
            Render_Chord_Chart_PDF(gPDF, CP, W, 200, 100, 50)
            LL = Render_Lyrics(chH + 260, 0, 100)
            While LL > 0
                New_render_PDF_Page()
                LL = Render_Lyrics(120, LL, 100)
            End While
        Else
            Render_Chord_Chart(g, CP, W, 200, 100, 50)
            LL = Render_Lyrics(chH + 260, 0, 100)
            Me.Images.Add(b)
            If LL > 0 Then
                'Not all lines fit on the page
            End If
        End If
        'Clean_up()
    End Sub

    Private Sub print_Render_Hybrid()
        New_render_Page()
        render_title()
        Me.Images.Add(Render_Hybrid_Chart(g, S.Chords, W, 120, 50, 10))

    End Sub

    Private Sub render_title()
        If Me.PDF_Mode Then
            sz_pdf = gPDF.MeasureString(S.Song.Title, Me.pdfTitleFont)
            px = (Me.W / 2) - (sz_pdf.Width / 2)
            py = 50
            gPDF.DrawString(S.Song.Title, Me.pdfTitleFont, Me.br, px, py)
            sz_pdf = gPDF.MeasureString(S.Song.Artist, Me.pdfSubTitleFont)
            px = (Me.W / 2) - (sz_pdf.Width / 2)
            py = 116
            gPDF.DrawString(S.Song.Artist, Me.pdfSubTitleFont, Me.br, px, py)
        Else
            sz = g.MeasureString(S.Song.Title, Me.TitleFont)
            px = (Me.W / 2) - (sz.Width / 2)
            py = 50
            g.DrawString(S.Song.Title, Me.TitleFont, Me.br, px, py)
            sz = g.MeasureString(S.Song.Artist, Me.SubTitleFont)
            px = (Me.W / 2) - (sz.Width / 2)
            py = 116
            g.DrawString(S.Song.Artist, Me.SubTitleFont, Me.br, px, py)
        End If
    End Sub

    Public Sub Initialize(Optional PdfMode As Boolean = False)
        If PdfMode Then
            Me.PDF_Mode = True
            New_render_PDF_Page()
            Exit Sub
        End If
        Me.PDF_Mode = False
        New_render_Page()
    End Sub

    Public Sub Save_PDF(ToFile$)
        Try
            gDoc.Save(ToFile)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub New_render_Page()
        If Me.PDF_Mode Then
            New_render_PDF_Page()
            Exit Sub
        End If
        b = New Bitmap(W, H)
        g = Graphics.FromImage(b)
        g.Clear(Color.White)
        GDIG = g
    End Sub

    Private Sub New_render_PDF_Page()
        b = New Bitmap(W, H)
        gDoc = New PdfDocument
        PdfPage = gDoc.AddPage()
        PdfPage.Width = W
        PdfPage.Height = H
        gPDF = XGraphics.FromPdfPage(PdfPage)
        GDIG = gPDF
        Me.PDF_Mode = True
    End Sub

    Private Sub Clean_up()
        Try
            b.Dispose()
        Catch ex As Exception

        End Try
        Try
            g.Dispose()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub Print_Chart(FromSong As clsSongFile, ToDoc As PrintDocument)
        Render_Chart(FromSong)
        Print(ToDoc)
    End Sub

    Function Render_Lyrics(Starting_Y As Integer, StartingLine As Integer, Optional Left_margin As Integer = 0) As Integer
        Dim cty% = Starting_Y
        Dim line_counter% = 0
        Dim LyricLines As String() = Me.S.Lyrics.Split(vbLf)
        '
        For Each L As String In LyricLines
            If line_counter >= StartingLine Then
                If Me.PDF_Mode Then
                    gPDF.DrawString(L.Replace(vbCr, ""), pdfLyricFont, br, 10 + Left_margin, cty)
                Else
                    g.DrawString(L, LyricFont, br, 10 + Left_margin, cty)
                End If
                cty += YSpace_LyricLine
            End If
            If cty > H - 100 Then
                'Ran out of page
                Return line_counter
            End If
            line_counter += 1
        Next
        Return 0
    End Function

    Sub Render_Chords()
        Dim chH As Integer = Get_Chord_Chart_Height(CP, W)
        Render_Chord_Chart(GDIG, CP, W)
    End Sub

    Public Sub AddFile(ByVal fromFileName$)
        If fromFileName = "" Then Exit Sub
        Dim b As Image = Image.FromFile(fromFileName)
        Images.Add(b)
        b = Nothing
    End Sub

    Public Sub AddImage(ByVal FromImage As Image)
        Images.Add(FromImage)
    End Sub
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        CurrentImage = Images(ImageIndex)
        Dim tpgs As Integer = 0
        Try
            tpgs = TotalPages()
        Catch ex As Exception
        End Try
        If tpgs = 0 Then tpgs = 1
        If tpgs > 1 Then
            CurrentImage.SelectActiveFrame(GetFrameDimension(0), FrameIndex)
        End If
        Try
            ev.Graphics.DrawImage(CurrentImage, ev.PageBounds)
            FrameIndex += 1
            If FrameIndex >= TotalPages() Then
                ImageIndex += 1
                FrameIndex = 0
                If ImageIndex = Images.Count Then
                    ev.HasMorePages = False
                Else
                    ev.HasMorePages = True
                End If
            Else
                ev.HasMorePages = True
            End If

        Catch ex As Exception
            MsgBox("Print Error: " & vbLf & ex.Message)
        End Try
    End Sub

    Private Function GetFrameDimension(ByVal index As Integer) As System.Drawing.Imaging.FrameDimension
        Return New System.Drawing.Imaging.FrameDimension(Me.CurrentImage.FrameDimensionsList(index))
    End Function

    Private Function TotalPages() As Integer
        Return CurrentImage.GetFrameCount(GetFrameDimension(0))
    End Function

    Public Sub Print()
        If Images.Count = 0 Then Exit Sub
        Dim printDoc As New PrintDocument()
        Dim pdlg As New PrintDialog
        pdlg.ShowDialog()
        printDoc.PrinterSettings = pdlg.PrinterSettings
        Print(printDoc)
    End Sub

    Public Sub Print(ByVal toPrinterName$)
        If Images.Count = 0 Then Exit Sub

        Dim printDoc As New PrintDocument()
        If Not toPrinterName = "" Then
            printDoc.PrinterSettings.PrinterName = toPrinterName
            Print(printDoc)
        End If
    End Sub
    Public Sub Print(ByVal toPrinter As PrintDocument)
        If Not toPrinter.PrinterSettings.IsValid Then
            Return
        End If
        AddHandler toPrinter.PrintPage, AddressOf PrintPage
        toPrinter.Print()
    End Sub


End Class
