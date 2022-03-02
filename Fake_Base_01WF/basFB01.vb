Imports System.IO
Imports PdfSharp.Drawing

Module basFB01
    Public SongBase As New DB.clsDBase
    Public Global_Settings As New clsSysSettings
    Public App_path$ = ""
    Public gsPlaylist_Panel_Width% = 112
    '
    'Chord Spacing Variables
    Public chdLeftPad% = 10
    Public chdBeat_pad% = 18
    Public chdFont_Chord_Big% = 18
    Public chdFont_Sub% = 12
    Public chdFont_Section% = 10
    Public chdLine_Height% = 100
    Public chdRightPad% = 10
    '
    Public Bottom_Y% = 0

    Sub Start_up()
        App_path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8))
        If Not App_path.EndsWith("\") Then App_path += "\"
        Global_Settings.Load()
        SongBase.Load(Global_Settings.SongDirs)
    End Sub


    Function Render_Chords(CParse As clsChordParser, pic_width As Integer, bpm As Integer) As Bitmap
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        Dim maxwid% = 0
        Dim maxlines% = 0
        Dim b As Bitmap
        If maxwid = 0 Then maxwid = 1
        If maxlines = 0 Then maxlines = 1

        Dim H As Integer = (CParse.LineCount() + 1) * 200
        '
        b = New Bitmap(pic_width, H)
        '
        Dim font1 As Font = New Font("Ariel", 24)
        Dim font8 As Font = New Font("Ariel", 8)
        Dim font12 As Font = New Font("Ariel", 12)
        Dim font10B As Font = New Font("Ariel", 10, FontStyle.Bold)


        Dim br As Brush = New SolidBrush(Color.Black)
        Dim br2 As Brush = New SolidBrush(Color.Black)
        Dim pn As Pen = New Pen(br2, 3)
        Dim pn2 As Pen = New Pen(br2, 5)

        Dim g As Graphics
        g = Graphics.FromImage(b)
        Dim lc$
        Dim lcw As Integer = 0
        Dim ncptr% = 0  'First X of free space after rendering a Chord Text
        For Each S As clsChordParser.ChordSection In CParse.Sections
            g.DrawString(S.SectionName, font10B, br, 10, cy)
            For Each L As clsChordParser.ChordLine In S.Lines
                If L IsNot Nothing Then
                    lc = ""
                    ncptr = 0
                    For Each M As clsChordParser.Measure In L.Measures
                        g.DrawLine(pn, cx, cy + 50, cx + M.Render_Width(lc), cy + 50)
                        g.DrawLine(pn2, cx + M.Render_Width(lc), cy + 75, cx + M.Render_Width(lc), cy + 25)
                        For Each bt As clsChordParser.Chord In M.Beat
                            If lc <> bt.Chart_text Then
                                'New chord
                                If cx < ncptr Then cx = ncptr + 10
                                If Not bt.Rest Then
                                    lcw = bt.Render_Chord_Text(bt.Chart_text, g, cx, cy, br, font1, font12)
                                    ncptr = cx + lcw
                                End If
                            End If
                            If Not bt.Rest Then
                                g.DrawImage(My.Resources.slash_01, New Rectangle(cx, cy + 40, cx + 25, cy + 120))
                            Else
                                g.DrawImage(My.Resources.QR_01, New Rectangle(cx, cy + 40, cx + 25, cy + 120))
                            End If
                            If bt.Hit Then
                                g.DrawImage(My.Resources.marcato_02, New Rectangle(cx, cy + 30, cx + 25, cy + 40))
                            End If
                            If bt.Hold Then
                                g.DrawImage(My.Resources.fermata_01, New Rectangle(cx, cy + 30, cx + 25, cy + 40))
                            End If
                            lc = bt.Chart_text
                        Next
                    Next
                    cy += 120
                End If
            Next
        Next


        g.Clear(Color.White)
        g.Dispose()
        Return b
    End Function

    Sub Render_Chord_Chart(ByRef g As Graphics, CParse As clsChordParser)
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        '
        Dim H As Integer = (CParse.LineCount() + 1) * 200
        '
        '
        Dim font1 As Font = New Font("Ariel", chdFont_Chord_Big)
        Dim font8 As Font = New Font("Ariel", chdFont_Section - 2)
        Dim font12 As Font = New Font("Ariel", chdFont_Sub)
        Dim font10B As Font = New Font("Ariel", chdFont_Section, FontStyle.Bold)
        '
        Dim br As Brush = New SolidBrush(Color.Black)
        Dim br2 As Brush = New SolidBrush(Color.Black)
        Dim pn As Pen = New Pen(br2, 2)
        Dim pn2 As Pen = New Pen(br2, 4)
        '
        g.Clear(Color.White)
        Dim lc$
        Dim lcw As Integer = 0
        Dim ncptr% = 0  'First X of free space after rendering a Chord Text
        Dim stx As Integer = 0
        '
        For Each S As clsChordParser.ChordSection In CParse.Sections
            g.DrawString(S.SectionName, font10B, br, 10, cy)
            cx = 0
            For Each L As clsChordParser.ChordLine In S.Lines
                If L IsNot Nothing Then
                    lc = ""
                    For Each M As clsChordParser.Measure In L.Measures
                        ncptr = 0
                        stx = cx
                        cx += chdLeftPad
                        For Each bt As clsChordParser.Chord In M.Beat
                            If lc <> bt.Chart_text Then
                                'New chord
                                If cx < ncptr Then cx = ncptr + 10
                                If Not bt.Rest Then
                                    lcw = bt.Render_Chord_Text(bt.Chart_text, g, cx, cy, br, font1, font12)
                                    ncptr = cx + lcw
                                End If
                            End If
                            If bt.Rest Then
                                g.DrawImage(My.Resources.QR_01, New Rectangle(cx, cy + 50, 10, 20))
                            ElseIf bt.Hit Then
                                g.DrawImage(My.Resources.marcato_02, New Rectangle(cx + 5, cy + 44, 14, 12))
                            ElseIf bt.Hold Then
                                g.DrawImage(My.Resources.fermata_01, New Rectangle(cx + 5, cy + 44, 14, 12))
                            Else
                                g.DrawImage(My.Resources.slash_01, New Rectangle(cx, cy + 50, 10, 20))
                            End If
                            lc = bt.Chart_text
                            cx += chdBeat_pad
                        Next
                        If cx < ncptr Then cx = ncptr + 10
                        cx += chdRightPad
                        g.DrawLine(pn, stx, cy + 60, cx, cy + 60)
                        g.DrawLine(pn2, cx, cy + 40, cx, cy + 80)
                        'cx += 30
                    Next
                    cy += chdLine_Height
                End If
            Next
        Next
    End Sub

    Sub Render_Chord_Chart(ByRef g As Graphics, CParse As clsChordParser, Width As Integer, Optional top_margin As Integer = 0, Optional left_margin As Integer = 0, Optional right_margin As Integer = 0)
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        Bottom_Y = 0
        '
        Dim H As Integer = (CParse.LineCount() + 1) * 200
        '
        '
        Dim font1 As Font = New Font("Ariel", chdFont_Chord_Big)
        Dim font8 As Font = New Font("Ariel", chdFont_Section - 2)
        Dim font12 As Font = New Font("Ariel", chdFont_Sub)
        Dim font10B As Font = New Font("Ariel", chdFont_Section, FontStyle.Bold)
        '
        Dim br As Brush = New SolidBrush(Color.Black)
        Dim br2 As Brush = New SolidBrush(Color.Black)
        Dim pn As Pen = New Pen(br2, 2)
        Dim pn2 As Pen = New Pen(br2, 4)
        '
        Dim lc$
        Dim lcw As Integer = 0
        Dim ncptr% = 0  'First X of free space after rendering a Chord Text
        Dim stx As Integer = 0
        '
        For Each S As clsChordParser.ChordSection In CParse.Sections
            If cx > Int(Width * 0.8) Then
                cx = 0
                cy += chdLine_Height
            ElseIf cx > 0 Then
                cx += 50
            End If
            g.DrawString(S.SectionName, font10B, br, cx + left_margin, cy + top_margin)
            lc = ""
            For Each M As clsChordParser.Measure In S.Measures
                ncptr = 0
                stx = cx
                cx += chdLeftPad
                For Each bt As clsChordParser.Chord In M.Beat
                    If lc <> bt.Chart_text Then
                        'New chord
                        If cx < ncptr Then cx = ncptr + 10
                        If Not bt.Rest Then
                            lcw = bt.Render_Chord_Text(bt.Chart_text, g, cx + left_margin, cy + top_margin + 6, br, font1, font12)
                            ncptr = cx + lcw
                        End If
                    End If
                    If bt.Rest Then
                        g.DrawImage(My.Resources.QR_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
                    ElseIf bt.Hit Then
                        g.DrawImage(My.Resources.marcato_02, New Rectangle(cx + 5 + left_margin, cy + 50 + top_margin, 14, 12))
                    Else
                        g.DrawImage(My.Resources.slash_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
                    End If
                    lc = bt.Chart_text
                    cx += chdBeat_pad
                Next
                If cx < ncptr Then cx = ncptr + 10
                cx += chdRightPad
                g.DrawLine(pn, stx + left_margin, cy + 66 + top_margin, cx + left_margin, cy + 66 + top_margin)
                g.DrawLine(pn2, cx + left_margin, cy + 46 + top_margin, cx + left_margin, cy + 86 + top_margin)
                Bottom_Y = cy + chdLine_Height
                If cx + 60 > Int((Width - left_margin) * 0.9) Then
                    cx = 0
                    cy += chdLine_Height
                End If
            Next
        Next
    End Sub

    Sub Render_Chord_Chart_PDF(ByRef g As XGraphics, CParse As clsChordParser, Width As Integer, Optional top_margin As Integer = 0, Optional left_margin As Integer = 0, Optional right_margin As Integer = 0)
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        '
        Dim H As Integer = (CParse.LineCount() + 1) * 200
        '
        '
        Dim font1 As XFont = New XFont("Ariel", chdFont_Chord_Big)
        Dim font8 As XFont = New XFont("Ariel", chdFont_Section - 2)
        Dim font12 As XFont = New XFont("Ariel", chdFont_Sub)
        Dim font10B As XFont = New XFont("Ariel", chdFont_Section, FontStyle.Bold)
        '
        Dim br As XBrush = New XSolidBrush(Color.Black)
        Dim br2 As XBrush = New XSolidBrush(Color.Black)
        Dim pn As XPen = New XPen(Color.Black, 2)
        Dim pn2 As XPen = New XPen(Color.Black, 4)
        '
        Dim lc$
        Dim lcw As Integer = 0
        Dim ncptr% = 0  'First X of free space after rendering a Chord Text
        Dim stx As Integer = 0
        '
        For Each S As clsChordParser.ChordSection In CParse.Sections
            If cx > Int(Width * 0.8) Then
                cx = 0
                cy += chdLine_Height
            ElseIf cx > 0 Then
                cx += 50
            End If
            g.DrawString(S.SectionName, font10B, br, cx + left_margin, cy + top_margin)
            lc = ""
            For Each M As clsChordParser.Measure In S.Measures
                ncptr = 0
                stx = cx
                cx += chdLeftPad
                For Each bt As clsChordParser.Chord In M.Beat
                    If lc <> bt.Chart_text Then
                        'New chord
                        If cx < ncptr Then cx = ncptr + 10
                        If Not bt.Rest Then
                            lcw = bt.Render_Chord_Text(bt.Chart_text, g, cx + left_margin, cy + top_margin + 6, br, font1, font12)
                            ncptr = cx + lcw
                        End If
                    End If
                    If bt.Rest Then
                        g.DrawImage(My.Resources.QR_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
                    ElseIf bt.Hit Then
                        g.DrawImage(My.Resources.marcato_02, New Rectangle(cx + 5 + left_margin, cy + 50 + top_margin, 14, 12))
                    Else
                        g.DrawImage(My.Resources.slash_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
                    End If
                    lc = bt.Chart_text
                    cx += chdBeat_pad
                Next
                If cx < ncptr Then cx = ncptr + 10
                cx += chdRightPad
                g.DrawLine(pn, stx + left_margin, cy + 66 + top_margin, cx + left_margin, cy + 66 + top_margin)
                g.DrawLine(pn2, cx + left_margin, cy + 46 + top_margin, cx + left_margin, cy + 86 + top_margin)
                If cx + 60 > Int((Width - left_margin) * 0.9) Then
                    cx = 0
                    cy += chdLine_Height
                End If
            Next
        Next
    End Sub

    Function Get_Chord_Chart_Height(CParse As clsChordParser, Width As Integer) As Integer
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        '
        Dim lc$
        Dim lcw As Integer = 0
        Dim ncptr% = 0  'First X of free space after rendering a Chord Text
        Dim stx As Integer = 0
        '
        For Each S As clsChordParser.ChordSection In CParse.Sections
            If cx > Int(Width * 0.8) Then
                cx = 0
                cy += chdLine_Height
            ElseIf cx > 0 Then
                cx += 50
            End If
            lc = ""
            For Each M As clsChordParser.Measure In S.Measures
                ncptr = 0
                stx = cx
                cx += chdLeftPad
                For Each bt As clsChordParser.Chord In M.Beat
                    If lc <> bt.Chart_text Then
                        'New chord
                        If cx < ncptr Then cx = ncptr + 10
                        If Not bt.Rest Then
                            lcw = bt.Get_Chord_Text_Width(bt.Chart_text)
                            ncptr = cx + lcw
                        End If
                    End If
                    lc = bt.Chart_text
                    cx += chdBeat_pad
                Next
                If cx < ncptr Then cx = ncptr + 10
                cx += chdRightPad
                If cx + 60 > Int(Width * 0.9) Then
                    cx = 0
                    cy += chdLine_Height
                End If
            Next
        Next
        Return cy + chdLine_Height
    End Function

    Function Render_Hybrid_Chart(ByRef g As Graphics, Source_Code$, Width As Integer, Optional top_margin As Integer = 0, Optional left_margin As Integer = 0, Optional right_margin As Integer = 0) As Bitmap
        Dim B As Bitmap
        Dim Chart As New clsHybridParser
        Chart.Initialize(Source_Code, Width)

        Dim H% = Chart.Lines * Chart.Line_Height
        Dim rendxy As Integer = Global_Settings.Default_Size
        Dim cx% = 0
        Dim cy% = 0
        Dim cty% = 4
        Dim last_bar_X% = 0
        Dim last_bar_Y% = 0
        Bottom_Y = 0
        '
        '
        Dim font_C As Font = New Font("Ariel", Chart.FontSize_Chord)
        Dim font_Super As Font = New Font("Ariel", Chart.FontSize_Chord_Super_Script)
        Dim font_L As Font = New Font("Ariel", Chart.FontSize_Lyrics)
        Dim font10B As Font = New Font("Ariel", chdFont_Section, FontStyle.Bold)
        '
        Dim br As Brush = New SolidBrush(Color.Black)
        Dim br2 As Brush = New SolidBrush(Color.Black)
        Dim pn As Pen = New Pen(br2, 2)
        Dim pn2 As Pen = New Pen(br2, 4)
        '
        If H = 0 Then H = 120
        B = New Bitmap(Width, H)
        '
        Dim bt As New clsChordParser.Chord
        g = Graphics.FromImage(B)
        g.Clear(Color.White)        '
        For Line_X As Integer = 1 To Chart.Lines
            For Each Item As Sheet_Render_element In Chart.Line_Elements(Line_X)
                Select Case Item.Element
                    Case Sheet_Render_element.element_type.chord
                        bt.Render_Chord_Text(Item.Text, g, Item.X + left_margin, Item.Y + top_margin + 6, br, font_C, font_Super)
                    Case Sheet_Render_element.element_type.text
                        g.DrawString(Item.Text, font_L, br, Item.X + left_margin, Item.Y + top_margin)
                    Case Sheet_Render_element.element_type.image
                        g.DrawImage(Item.Get_Image(), New Rectangle(Item.X + left_margin, Item.Y + top_margin, Item.Width, Item.Height))
                    Case Sheet_Render_element.element_type.line_Horizontal
                        g.DrawLine(pn, Item.X + left_margin, Item.Y + top_margin, Item.X + Item.Width + left_margin, Item.Y + top_margin)
                    Case Sheet_Render_element.element_type.line_Vertical
                        g.DrawLine(pn, Item.X + left_margin, Item.Y + top_margin, Item.X + left_margin, Item.Y + Item.Height + top_margin)
                        last_bar_X = Item.X
                        last_bar_Y = Item.Y + Int(Item.Height / 2)
                End Select
            Next
            g.DrawLine(pn, 0 + left_margin, last_bar_Y + top_margin, last_bar_X + left_margin, last_bar_Y + top_margin)
        Next
        'For Each S As clsChordParser.ChordSection In CParse.Sections
        '    If cx > Int(Width * 0.8) Then
        '        cx = 0
        '        cy += chdLine_Height
        '    ElseIf cx > 0 Then
        '        cx += 50
        '    End If
        '    g.DrawString(S.SectionName, font10B, br, cx + left_margin, cy + top_margin)
        '    lc = ""
        '    For Each M As clsChordParser.Measure In S.Measures
        '        ncptr = 0
        '        stx = cx
        '        cx += chdLeftPad
        '        For Each bt As clsChordParser.Chord In M.Beat
        '            If lc <> bt.Chart_text Then
        '                'New chord
        '                If cx < ncptr Then cx = ncptr + 10
        '                If Not bt.Rest Then
        '                    lcw = bt.Render_Chord_Text(bt.Chart_text, g, cx + left_margin, cy + top_margin + 6, br, font1, font12)
        '                    ncptr = cx + lcw
        '                End If
        '            End If
        '            If bt.Rest Then
        '                g.DrawImage(My.Resources.QR_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
        '            ElseIf bt.Hit Then
        '                g.DrawImage(My.Resources.marcato_02, New Rectangle(cx + 5 + left_margin, cy + 50 + top_margin, 14, 12))
        '            Else
        '                g.DrawImage(My.Resources.slash_01, New Rectangle(cx + left_margin, cy + 56 + top_margin, 10, 20))
        '            End If
        '            lc = bt.Chart_text
        '            cx += chdBeat_pad
        '        Next
        '        If cx < ncptr Then cx = ncptr + 10
        '        cx += chdRightPad
        '        g.DrawLine(pn, stx + left_margin, cy + 66 + top_margin, cx + left_margin, cy + 66 + top_margin)
        '        g.DrawLine(pn2, cx + left_margin, cy + 46 + top_margin, cx + left_margin, cy + 86 + top_margin)
        '        Bottom_Y = cy + chdLine_Height
        '        If cx + 60 > Int((Width - left_margin) * 0.9) Then
        '            cx = 0
        '            cy += chdLine_Height
        '        End If
        '    Next
        'Next
        '--------------------------------------------------------
        Return B
    End Function

#Region "File IO Functions"
    Sub SaveFile(ByVal Path$, ByVal data() As Byte, Optional ByVal kill As Boolean = False)
        If kill Then
            Try
                FileSystem.Kill(Path)
            Catch ex As Exception

            End Try
        End If
        Dim fs As FileStream
        fs = File.Create(Path)
        fs.Write(data, 0, data.GetLength(0))
        fs.Close()
        fs = Nothing
    End Sub


    Sub SaveFile(ByVal Path$, ByVal data As String, Optional ByVal kill As Boolean = False)
        Dim pdPath$ = Path.Substring(0, Path.LastIndexOf("\"))
        Dim di As New DirectoryInfo(pdPath)
        If Not di.Exists Then
            di.Create()
        End If
        di = Nothing

        If kill Then
            Try
                If File.Exists(Path) Then
                    FileSystem.Kill(Path)
                End If
            Catch ex As Exception

            End Try
        End If
        Dim fs As FileStream
        Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(data)
        fs = File.Create(Path)
        fs.Write(b, 0, b.GetLength(0))
        fs.Close()
        fs = Nothing
        b = Nothing
    End Sub

    Function LoadFile(ByVal path$, ByRef data() As Byte) As Integer
        Dim fs As FileStream
        Dim flen As Integer
        fs = File.OpenRead(path)
        flen = fs.Length
        ReDim data(flen)
        fs.Read(data, 0, flen)
        fs.Close()
        fs = Nothing
        Return flen
    End Function


    Function LoadFile(ByVal path$) As String
        If Not My.Computer.FileSystem.FileExists(path) Then Return ""
        Dim fs As FileStream
        Dim flen As Integer
        fs = File.OpenRead(path)
        flen = fs.Length
        Dim data(flen) As Byte
        fs.Read(data, 0, flen)
        fs.Close()
        fs = Nothing
        Return System.Text.Encoding.ASCII.GetString(data)
    End Function

    Function IO_Get_Next_Line(ByVal FromStream As FileStream, Optional skipbyte As Byte = 13, Optional endbyte As Byte = 10) As String
        Dim b As Byte
        Dim c As String
        Dim rv$ = ""
        Try
            Do
                b = FromStream.ReadByte
                c = Chr(b)
                Select Case b
                    Case skipbyte
                            'Skip
                    Case endbyte
                        Exit Do
                    Case Else
                        rv += c
                End Select
            Loop Until FromStream.Position = FromStream.Length - 1
        Catch ex As Exception

        End Try
        Return rv
    End Function

    Public Sub IO_Append_Line(ByVal Line$, ByVal ToStream As FileStream)
        Line += vbCrLf
        Dim b_read(Line.Length - 1) As Byte
        Dim ca() As Char = Line.ToCharArray
        Dim bp As Integer = 0
        For Each c As Char In ca
            b_read(bp) = Asc(c)
            bp += 1
        Next
        ToStream.Position = ToStream.Length
        ToStream.Write(b_read, 0, Line.Length)
        Line = ""
    End Sub

    Function IO_Create_Dir(ByVal Path$) As System.IO.DirectoryInfo
        Dim di As System.IO.DirectoryInfo
        di = New System.IO.DirectoryInfo(Path)
        If Not di.Exists Then
            di.Create()
        End If
        Return di
    End Function



    Public Function Get_All_Sub_Dirs(InFolder$) As List(Of String)
        Dim rv As New List(Of String)
        Dim fi As New IO.DirectoryInfo(InFolder)
        For Each DirRef As IO.DirectoryInfo In fi.GetDirectories()
            rv.Add(DirRef.FullName)
            For Each s As String In Get_All_Sub_Dirs(DirRef.FullName)
                rv.Add(s)
            Next
            'Because the recursive nature of this function could tie up
            'the system compiling thousands of directories,
            'limit output to 500 records
            If rv.Count > 499 Then Return rv
        Next
        Return rv
    End Function

#End Region

#Region "String Functions"
    Public Function Normalize_LFs(fromString$) As String
        Return fromString.Replace(vbCr, "").Replace(vbLf, vbCrLf)
    End Function

    Public Function Normalize_LFs(fromString$, Optional remove_char As String = vbLf, Optional replace_char As String = vbCr) As String
        Return fromString.Replace(replace_char, "").Replace(remove_char, replace_char)
    End Function

    Public Function String_Between(FromString$, Tag1$, Tag2$) As String
        Try
            Dim p1%, p2%, start%, Length%
            p1 = FromString.IndexOf(Tag1)
            If p1 < 1 Then Return ""
            p2 = FromString.IndexOf(Tag2, p1 + 1)
            start = p1 + Tag1.Length
            Length = p2 - p1 - Tag1.Length
            If Length < 1 Then Return ""
            Return FromString.Substring(start, Length)
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function String_Leftof(source$, Value$) As String
        If Not source.Contains(Value) Then Return ""
        If source.StartsWith(Value) Then Return ""
        Try
            Return source.Substring(0, source.IndexOf(Value))
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function String_Rightof(source$, Value$) As String
        If Not source.Contains(Value) Then Return ""
        If source.EndsWith(Value) Then Return ""
        Try
            Return source.Substring(source.IndexOf(Value) + Value.Length)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function String_Camel_Case(value$) As String
        Dim rv As String = ""
        Dim sw As Boolean = True
        For Each c As Char In value.ToUpper.ToCharArray
            If c = " " Then sw = True
            If sw Then
                rv += c
            Else
                rv += c.ToString.ToLower
            End If
            If c <> " " Then sw = False
        Next
        Return rv
    End Function

    Public Function String_Tab_Delim(FromString())
        Dim rv$ = ""
        For Each s As String In FromString
            If rv.Length > 0 Then rv += vbTab
            rv += s
        Next
        rv += vbCrLf
        Return rv
    End Function

    Public Function String_Line(Value$, Optional Trim As Boolean = False, Optional Force_Upper As Boolean = False, Optional Insert_Tabs As Integer = 0) As String
        Dim rv As String = Value
        If Not Value.EndsWith(vbCrLf) Then Value += vbCrLf
        Return rv
    End Function

    Public Function String_Setting(PropertyName$, Value$, Optional AddCRLF As Boolean = True, Optional Force_Upper_Property_Name As Boolean = False)
        If PropertyName = "" Then Return ""
        Dim rv$ = ""
        If Force_Upper_Property_Name Then
            rv += PropertyName.Trim.ToUpper
        Else
            rv = PropertyName
        End If
        rv += "="
        rv += Value
        If AddCRLF Then rv += vbCrLf
        Return rv
    End Function

    Public Function nString(FromValue)
        If FromValue Is Nothing Then Return ""
        Try
            Return FromValue.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function String_Get_HTML_Rows(FromHTML$) As List(Of String)
        Dim rv As New List(Of String)
        Try
            For Each s As String In FromHTML.Replace("</tr>", "§").Split("§")
                If s.Contains("https://www.azlyrics.com/lyrics") Then rv.Add(s)
            Next
        Catch ex As Exception

        End Try
        Return rv
    End Function


    Public Function String_Get_Delim_Positions(FromString$, Delim As String) As List(Of Integer)
        Dim rv As New List(Of Integer)
        Dim ix% = 0
        Do
            ix = FromString.IndexOf(Delim, ix + 1)
            If ix > -1 Then rv.Add(ix)
        Loop Until ix < 0
        Return rv
    End Function

    Public Function String_List(FromString$, Delim$, Optional Min_Members_Count% = 0, Optional Drop_Empties As Boolean = False, Optional Replace_Empties_with$ = "") As List(Of String)
        Dim rv As New List(Of String)
        If Not FromString.Contains(Delim) Then
            rv.Add(FromString)
            Return rv
        End If
        If Not FromString.EndsWith(Delim) Then FromString += Delim
        For Each s As String In FromString.Split(Delim)
            If s.Length > 0 Then
                rv.Add(s)
            Else
                If Not Drop_Empties Then
                    rv.Add(Replace_Empties_with)
                End If
            End If
        Next
        If Min_Members_Count > 0 Then
            If rv.Count < Min_Members_Count Then
                For t As Integer = rv.Count To Min_Members_Count
                    rv.Add(Replace_Empties_with)
                Next
            End If
        End If
        Return rv
    End Function



    ''' <summary>
    ''' Parses an HTML string to return an array of strings
    ''' corresponding to HTML table rows ( "<tr>" to "</tr>")
    ''' </summary>
    ''' <param name="FromHTML$"></param>
    ''' <param name="start_at%"></param>
    ''' <param name="end_at%"></param>
    ''' <returns></returns>
    Public Function HTML_Get_Rows(FromHTML$, Optional start_at% = 0, Optional end_at% = 0) As List(Of String)
        Dim rv As New List(Of String)
        Try
            Dim ptr% = start_at
            Dim eptr% = 0
            Dim sptr% = start_at
            Do
                ptr = FromHTML.IndexOf("<tr>", sptr, StringComparison.CurrentCultureIgnoreCase)
                If ptr > 0 Then
                    eptr = FromHTML.IndexOf("</tr>", sptr, StringComparison.CurrentCultureIgnoreCase)
                    If eptr > ptr Then
                        rv.Add(FromHTML.Substring(ptr, eptr - ptr))
                        sptr = eptr + 4
                    End If
                End If
            Loop Until ptr < 1
            Return rv
        Catch ex As Exception
            Return New List(Of String)
        End Try
    End Function



    Public Function String_Filename(FromURL$) As String
        Try
            If FromURL.LastIndexOf("\") < 1 Then Return ""
            Return FromURL.Substring(FromURL.LastIndexOf("\") + 1)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function FlagMatch(Source_flag1$, Compare_flag2$, NullChar As Char) As Boolean
        Dim hot_ordinals As New List(Of Integer)
        If Source_flag1.Length < Compare_flag2.Length Then Source_flag1 += StrDup(Compare_flag2.Length - Source_flag1.Length, NullChar)
        For t As Integer = 0 To Compare_flag2.Length - 1
            If Compare_flag2.Substring(t, 1) <> NullChar.ToString Then
                hot_ordinals.Add(t)
            End If
        Next
        For Each I As Integer In hot_ordinals
            If Source_flag1.Substring(I, 1) <> Compare_flag2.Substring(I, 1) Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' Returns true if the flag contains any non-null characters
    ''' </summary>
    ''' <param name="Compare_flag2$"></param>
    ''' <param name="NullChar"></param>
    ''' <returns></returns>
    Function Hot_Flag(Compare_flag2$, NullChar As Char) As Boolean
        Dim hot_ordinals As New List(Of Integer)
        For t As Integer = 0 To Compare_flag2.Length - 1
            If Compare_flag2.Substring(t, 1) <> NullChar.ToString Then
                hot_ordinals.Add(t)
            End If
        Next
        Return hot_ordinals.Count > 0
    End Function

    Function Get_Setting(fromVal$, Optional parse_char As String = "=") As KeyValuePair(Of String, String)
        Dim sp As Integer = fromVal.IndexOf(parse_char)
        Dim rv As New KeyValuePair(Of String, String)
        If sp > 0 Then
            If sp < fromVal.Length - 1 Then
                Return New KeyValuePair(Of String, String)(fromVal.Substring(0, sp).Trim, fromVal.Substring(sp + 1).Trim)
            Else
                Return New KeyValuePair(Of String, String)(fromVal.Substring(0, sp), "")
            End If
        End If
        Return New KeyValuePair(Of String, String)("", "")
    End Function
#End Region


End Module
