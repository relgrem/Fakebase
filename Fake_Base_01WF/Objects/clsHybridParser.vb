Public Class clsHybridParser
    Public Elements As New List(Of Sheet_Render_element)
    Public FontSize_Lyrics% = 12
    Public FontSize_Chord% = 16
    Public FontSize_Chord_Super_Script% = 12
    Public Line_Height% = 120

    Public Sub Initialize(FromSource$, Render_width%)
        Dim bt As New clsChordParser.Chord
        Dim b As Image
        b = New Bitmap(100, 100)
        '
        Dim font_Lyrics As Font = New Font("Ariel", Me.FontSize_Lyrics)
        'Dim font8 As Font = New Font("Ariel", 8)
        'Dim font12 As Font = New Font("Ariel", 12)
        'Dim font10B As Font = New Font("Ariel", 10, FontStyle.Bold)


        Dim br As Brush = New SolidBrush(Color.Black)
        Dim br2 As Brush = New SolidBrush(Color.Black)
        Dim pn As Pen = New Pen(br2, 3)
        Dim pn2 As Pen = New Pen(br2, 5)
        '
        'g is only being used as a measuring instrument for determining spacing
        Dim g As Graphics
        g = Graphics.FromImage(b)
        '
        Dim Chord_Markers As List(Of Integer) = String_Get_Delim_Positions(FromSource, "<")
        Dim Chunks = String_List(FromSource, "<")
        Dim ChordString$, ChordCommentString$, BeatsString$, LyricsString$
        Dim lyric_lines As List(Of String)
        Dim Previous_Chord_String$ = ""
        Dim beats% = 0, bars% = 0, cx% = 0, cy% = 0, bnx% = 0, bim% = 0, line_x% = 1, rx% = 15, bx% = 1
        Dim lfx% = 0, lly% = 0, mx% = 0
        Dim wid_lyric% = 0, Wid_Chord% = 0, wid_Beats% = 0, wid_Chunk% = 0, wid_Beatspace% = 0
        Dim eCtr% = 0
        For Each chunk As String In Chunks
            If chunk.Contains(">") And chunk.Contains("};") Then
                LyricsString = String_Rightof(chunk, ";")
                If LyricsString.Contains(">") Then
                    LyricsString = String_Leftof(LyricsString, ">").Trim
                End If
                ChordString = String_Leftof(chunk, ";")
                If ChordString = Previous_Chord_String Then ChordString = ""
                If ChordString <> "" Then
                    If ChordString.Contains("{") Then
                        BeatsString = String_Between(ChordString, "{", "}")
                        beats = Int(Val(BeatsString))
                        ChordString = String_Leftof(ChordString, "{")
                    End If
                    If beats = 0 Then beats = 1
                    If ChordString.Contains("'") Then
                        ChordCommentString = String_Rightof(ChordString, "'")
                    End If
                End If
                '
                lyric_lines = String_List(LyricsString, "/")
                'So, now we have chord, Comment, Beats, Lyrics
                Wid_Chord = bt.Get_Chord_Text_Width(ChordString)
                wid_Beats = 0
                wid_Beatspace = 0
                bars = 0
                wid_lyric = 0
                For Each ll$ In lyric_lines
                    mx = g.MeasureString(ll, font_Lyrics).Width
                    If mx > wid_lyric Then wid_lyric = mx
                Next
                bnx = bx
                For beat_index = 1 To beats
                    wid_Beats += 15
                    wid_Beatspace += 10
                    bnx += 1
                    If bnx = 5 Then
                        bars += 1
                        wid_Beats += 30
                        wid_Beatspace += 15
                        bnx = 1
                    End If
                Next
                wid_Beats = (beats * 20) + (bars * 20)
                '---------------------------------------------------------------------------
                '---------------------------------------------------------------------------
                wid_Beatspace = 0
                wid_Chunk = Wid_Chord
                If wid_Beats > wid_Chunk Then wid_Chunk = wid_Beats
                If wid_lyric > wid_Chunk Then wid_Chunk = wid_lyric
                'wid_chunk is the total space we need to allocate to this chord
                If wid_Chunk > wid_Beats Then
                    wid_Beatspace = Int((wid_Chunk - wid_Beats) / (beats + bars))
                End If
                eCtr = Me.Elements.Count - 1
                Add_element(Sheet_Render_element.element_type.chord, cx, cy, 0, 0, ChordString, 0, line_x)
                rx = 0
                lfx = 0
                lly = 0
                For Each l_line$ In lyric_lines
                    Add_element(Sheet_Render_element.element_type.text, cx, cy + 80 + lly, 0, 0, l_line, 0, line_x)
                    lly += Me.FontSize_Lyrics + 4
                Next
                For beat_index = 1 To beats
                    Add_element(Sheet_Render_element.element_type.image, cx + rx, cy + 45, 15, 30, "", 1, line_x)
                    rx += 20 + wid_Beatspace
                    bx += 1
                    If bx = 5 Then
                        rx += 25
                        Add_element(Sheet_Render_element.element_type.line_Vertical, cx + rx, cy + 42, 0, 34, "|", 0, line_x)
                        If cx + rx > Render_width Then
                            lfx = Line_Feed(line_x, cx + rx)
                            cx = 0
                            rx = 15
                            line_x += 1
                            cy += Me.Line_Height
                        Else
                            rx += 10
                        End If
                        bx = 1
                    End If
                Next
                cx += wid_Chunk + 10 + lfx
            Else
                'May be a command
                If chunk.Contains(">") Then
                    ChordCommentString = String_Between(chunk, "{", "}")
                    ChordString = String_Leftof(chunk, "{").ToUpper
                    lyric_lines = String_List(ChordCommentString, ",", 3, False, "-")
                    Select Case ChordString
                        Case "NEW_LINE"
                            cx = 0
                            rx = 15
                            line_x += 1
                            cy += Me.Line_Height
                        Case "GAP"
                            Wid_Chord = Int(Val(lyric_lines(0)))

                    End Select
                End If
            End If
        Next

        g.Dispose()
    End Sub

    Public Function Line_Feed(line%, bar_X%) As Integer
        Dim last_bar_line_index% = 0
        Dim last_bar_X% = 0
        Try
            For t As Integer = Me.Elements.Count - 2 To 0 Step -1
                If Me.Elements(t).Line_Index = line Then
                    If Me.Elements(t).Element = Sheet_Render_element.element_type.line_Vertical And Me.Elements(t).Text = "|" Then
                        last_bar_line_index = t
                        last_bar_X = Me.Elements(t).X
                        Exit For
                    End If
                End If
            Next
            If last_bar_line_index = 0 Then Return 0
            For r As Integer = last_bar_line_index + 1 To Me.Elements.Count - 1
                Me.Elements(r).X = Me.Elements(r).X - last_bar_X
                Me.Elements(r).Y += Me.Line_Height
                Me.Elements(r).Line_Index = line + 1
            Next
        Catch ex As Exception

        End Try
        Return bar_X - last_bar_X
    End Function


    Public Sub Add_element(eType As Sheet_Render_element.element_type, X%, Y%, W%, H%, Text$, ImageIndex%, LineIndex%)
        Dim ni As New Sheet_Render_element
        ni.Element = eType
        ni.X = X
        ni.Y = Y
        ni.Width = W
        ni.Height = H
        ni.Text = Text
        ni.Line_Index = LineIndex
        ni.ImageIndex = ImageIndex
        Me.Elements.Add(ni)
        ni = Nothing
    End Sub

    Public Function Lines() As Integer
        Dim rv%
        For Each I As Sheet_Render_element In Me.Elements
            If I.Line_Index > rv Then rv = I.Line_Index
        Next
        Return rv
    End Function

    Public Function Line_Elements(Index%) As List(Of Sheet_Render_element)
        Dim rv As New List(Of Sheet_Render_element)
        For Each I As Sheet_Render_element In Me.Elements
            If I.Line_Index = Index Then rv.Add(I)
        Next
        Return rv
    End Function

    Public Function Line_Width(Line_Index%) As Integer
        Dim rv% = 0
        For Each I As Sheet_Render_element In Me.Elements
            If I.Line_Index = Line_Index And I.X + I.Width > rv Then rv = I.X + I.Width
        Next
        Return rv
    End Function


End Class



Public Class Sheet_Render_element
    Public Enum element_type
        text
        line_Horizontal
        line_Vertical
        chord
        image
    End Enum
    Public Enum Image_Type
        None
        Slash_01

    End Enum
    Public Element As element_type = Text
    Public X% = 0
    Public Y% = 0
    Public Height% = 0
    Public Width% = 0
    Public Text$ = ""
    Public ImageIndex As Image_Type = Image_Type.None
    Public Line_Index% = 0

    Public Sub Set_Image_By_Index(Image_Index%)
        Select Case ImageIndex
            Case 1
                Me.ImageIndex = Image_Type.Slash_01
            Case Else
                Me.ImageIndex = Image_Type.None

        End Select
    End Sub

    Public Function Get_Image() As Bitmap
        Select Case Me.ImageIndex
            Case Image_Type.None
                Return New Bitmap(1, 1)
            Case Image_Type.Slash_01
                Return My.Resources.slash_01
            Case Else
                Return New Bitmap(1, 1)

        End Select
    End Function


End Class
