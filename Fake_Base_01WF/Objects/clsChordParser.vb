Imports PdfSharp.Drawing
Public Class clsChordParser
    '------------------------------------------------------------------
    Public Sections As New List(Of ChordSection)
    Public Render_width% = 1200
    Public Sub Load(FromString As String)
        FromString = FromString.Replace(vbCr, "")
        Dim p1 As String() = FromString.Split("[")
        Dim ix1 As Integer = 0
        Dim ix2 As Integer = 0
        For Each s As String In p1
            ix1 = s.IndexOf(vbLf)
            ix2 = s.IndexOf("]")
            If ix2 > 0 And ix2 < ix1 Then
                Add_Section(s)
            End If
        Next
    End Sub

    Public Sub Add_Section(FromString As String)
        Dim TCA As Char() = FromString.ToCharArray
        Dim bfr$ = ""
        Dim ni As New ChordSection
        Dim acceptable$ = "_{}+-^#/,*'"
        For Each C As Char In TCA
            If C.ToString = "]" Then
                ni.SectionName = bfr
                bfr = ""
            Else
                If Char.IsLetterOrDigit(C) Or acceptable.Contains(C.ToString) Then
                    bfr += C
                End If
            End If
        Next
        If bfr <> "" Then ni.Load(bfr)
        Me.Sections.Add(ni)
        ni = Nothing
        '
    End Sub

    Public Sub Parse_Sections_into_lines(BPM As Integer, Render_wid As Integer)
        Me.Render_width = Render_width
        For Each S As ChordSection In Me.Sections
            S.ParseLines(BPM, Render_wid)
        Next
    End Sub

    Public Function LineCount() As Integer
        Dim rv% = 0
        For Each S As ChordSection In Me.Sections
            rv += S.Lines.Count
        Next
        Return rv
    End Function


    Public Class ChordSection
        Public SectionName$ = "" 'VERSE,CHORUS, etc.
        Public ChordString$ = ""
        Public ChordList As New List(Of Chord)
        Public Lines As New List(Of ChordLine)
        Public Measures As New List(Of Measure)
        Public Sub Load(FromString As String)
            Dim chds As String() = FromString.Split(",")
            For Each I As String In chds
                If I <> "" Then
                    Dim ni As New Chord
                    ni.Load(I)
                    Me.ChordList.Add(ni)
                    ni = Nothing
                End If
            Next
        End Sub

        ''' <summary>
        ''' Returns an array of chords representing each beat in the section
        ''' If a chord is held for eight beats, it returns 
        ''' eight identical element in the array
        ''' </summary>
        ''' <returns></returns>
        Public Function Get_beats() As List(Of Chord)
            Dim rv As New List(Of Chord)
            For Each C As Chord In Me.ChordList
                For t As Integer = 1 To C.Beats
                    rv.Add(C)
                Next
            Next
            Return rv
        End Function

        Public Sub ParseLines(BPM As Integer, RenderWidth As Integer)
            Me.Lines.Clear()
            If Me.ChordList.Count = 0 Then Exit Sub
            Dim msr As Measure
            Dim bctr As Integer = 0
            For Each C As Chord In Me.Get_beats
                bctr += 1
                If bctr = 1 Then
                    msr = New Measure
                End If
                msr.Beat.Add(C)
                If bctr = BPM Then
                    bctr = 0
                    Me.Measures.Add(msr)
                    msr = Nothing
                End If
            Next
            Dim ln As ChordLine
            bctr = 0
            Dim lc$ = ""
            For Each M As Measure In Me.Measures
                If bctr + M.Render_Width(lc) > RenderWidth Then
                    If ln IsNot Nothing Then
                        Me.Lines.Add(ln)
                        ln = Nothing
                    End If
                    bctr = 0
                End If
                If ln Is Nothing Then ln = New ChordLine
                ln.Measures.Add(M)
            Next
            Me.Lines.Add(ln)
            '
        End Sub

    End Class


    Public Class Chord
        Public Chart_text$ = ""
        Public Hit As Boolean
        Public Hold As Boolean = False
        Public Rest As Boolean
        Public Beats As Integer
        Private ixo As Integer = 0
        Public Render_width As Integer 'Run time render variable
        Public Sub Load(fromString As String)
            ixo = fromString.IndexOf("{")
            If ixo = -1 Or ixo >= fromString.Length - 1 Then
                Me.Beats = 1
                Me.Chart_text = fromString
                If fromString.Contains("^") Then Me.Hit = True
                If fromString.Contains("*") Then Me.Hold = True
                Exit Sub
            End If
            Me.Chart_text = fromString.Substring(0, ixo)
            If fromString.Contains("^") Then
                Me.Hit = True
                Me.Beats = 1
            ElseIf fromString.Contains("*") Then
                Me.Hold = True
                Me.Beats = 1
                If fromString.Contains("*4") Then Me.Beats = 4
            Else
                Me.Beats = Int(Val(fromString.Substring(ixo + 1)))
            End If
            If fromString.StartsWith("R") Then Me.Rest = True
        End Sub

        Function Render_Chord_Text(Code$, g As Graphics, x As Integer, y As Integer, WithBursh As Brush, BigFnt As Font, SubFont As Font) As Integer
            If Code = "" Then Return 0
            Code = Code.Replace("dim", "þ")
            Code = Code.Replace("13", "ý")
            Dim subtext$ = ""
            If Code.Contains("'") Then
                subtext = String_Rightof(Code, "'")
                Code = String_Leftof(Code, "'")
            End If
            Dim CCRS As Char() = Code.ToCharArray
            Dim xptr% = 0
            If subtext <> "" Then
                g.DrawString(subtext, SubFont, WithBursh, x + xptr, y + 75)
            End If
            For Each character As Char In CCRS
                Select Case character
                    Case "@", "þ"
                        g.DrawImage(My.Resources.dim_symbol, New Rectangle(x + xptr, y + 16, 9, 9))
                        xptr += 12
                    Case "ý", "!"
                        g.DrawString("13", SubFont, WithBursh, x + xptr, y + 10)
                        xptr += 28
                    Case "7", "9", "5"
                        g.DrawString(character.ToString, SubFont, WithBursh, x + xptr, y + 10)
                        xptr += 14
                    Case "#"
                        g.DrawImage(My.Resources.sharp_01, New Rectangle(x + xptr, y + 10, 15, 17))
                        xptr += 14
                    Case "b"
                        g.DrawImage(My.Resources.flat_01, New Rectangle(x + xptr, y + 10, 9, 19))
                        xptr += 12
                    Case "n"
                        g.DrawImage(My.Resources.Nat_01, New Rectangle(x + xptr, y + 10, 9, 19))
                        xptr += 12
                    Case "^", "*"
                        'hit indicator -- do nothing
                    Case "/"
                        g.DrawString(character.ToString, BigFnt, WithBursh, x + xptr - 4, y + 10)
                        xptr += 3
                    Case "-" ' Less Horizontal Spacing Following a dash
                        g.DrawString(character.ToString, BigFnt, WithBursh, x + xptr, y + 10)
                        xptr += 12
                    Case Else
                        g.DrawString(character.ToString, BigFnt, WithBursh, x + xptr, y + 10)
                        xptr += 20
                End Select
            Next
            Return xptr
        End Function

        Function Render_Chord_Text(Code$, g As XGraphics, x As Integer, y As Integer, WithBursh As XBrush, BigFnt As XFont, SubFont As XFont) As Integer
            If Code = "" Then Return 0
            Code = Code.Replace("dim", "þ")
            Code = Code.Replace("13", "ý")
            Dim subtext$ = ""
            If Code.Contains("'") Then
                subtext = String_Rightof(Code, "'")
                Code = String_Leftof(Code, "'")
            End If
            Dim CCRS As Char() = Code.ToCharArray
            Dim xptr% = 0
            If subtext <> "" Then
                g.DrawString(subtext, SubFont, WithBursh, x + xptr, y + 75)
            End If
            For Each character As Char In CCRS
                Select Case character
                    Case "þ"
                        g.DrawString("dim", SubFont, WithBursh, x + xptr, y + 10)
                        xptr += 40
                    Case "ý"
                        g.DrawString("13", SubFont, WithBursh, x + xptr, y + 10)
                        xptr += 28
                    Case "7", "9", "5"
                        g.DrawString(character.ToString, SubFont, WithBursh, x + xptr, y + 10)
                        xptr += 14
                    Case "#"
                        g.DrawImage(My.Resources.sharp_01, New Rectangle(x + xptr, y + 10, 15, 17))
                        xptr += 14
                    Case "b"
                        g.DrawImage(My.Resources.flat_01, New Rectangle(x + xptr, y + 10, 9, 19))
                        xptr += 12
                    Case "n"
                        g.DrawImage(My.Resources.Nat_01, New Rectangle(x + xptr, y + 10, 9, 19))
                        xptr += 12
                    Case "^", "*"
                        'hit indicator -- do nothing
                    Case "/"
                        g.DrawString(character.ToString, BigFnt, WithBursh, x + xptr - 4, y + 10)
                        xptr += 3
                    Case Else
                        g.DrawString(character.ToString, BigFnt, WithBursh, x + xptr, y + 10)
                        xptr += 20
                End Select
            Next
            Return xptr
        End Function

        Function Get_Chord_Text_Width(Code$) As Integer
            If Code = "" Then Return 0
            Code = Code.Replace("dim", "þ")
            Code = Code.Replace("13", "ý")
            Dim CCRS As Char() = Code.ToCharArray
            Dim xptr% = 0
            For Each character As Char In CCRS
                Select Case character
                    Case "þ"
                        xptr += 40
                    Case "ý"
                        xptr += 28
                    Case "7", "9", "5"
                        xptr += 14
                    Case "#"
                        xptr += 14
                    Case "b"
                        xptr += 12
                    Case "n"
                        xptr += 12
                    Case "^"
                        'hit indicator -- do nothing
                    Case Else
                        xptr += 20
                End Select
            Next
            Return xptr
        End Function

    End Class

    Public Class Measure
        Public Beat As New List(Of Chord)
        Public Function Render_Width(last_Chord$) As Integer
            Dim cct As Integer = Changes(last_Chord).Count
            If cct < 2 Then Return Beat.Count * 50
            Dim pc$ = last_Chord
            Dim rv As Integer = 0
            For t As Integer = 0 To Beat.Count - 1
                If Beat(t).Chart_text <> pc Then
                    rv += 35
                Else
                    rv += Beat(t).Chart_text.Length * 50
                End If
                pc = Beat(t).Chart_text
            Next
            Return rv
        End Function

        Public Function Changes(prev_measure_chord$) As List(Of Chord)
            Dim pc$ = prev_measure_chord
            Dim rv As New List(Of Chord)
            For t As Integer = 0 To Beat.Count - 1
                If Beat(t).Chart_text <> pc Then
                    rv.Add(Beat(t))
                End If
                pc = Beat(t).Chart_text
            Next
            Return rv
        End Function

        Public Function LastChordString() As String
            Return Me.Beat(Me.Beat.Count - 1).Chart_text
        End Function

    End Class

    Public Class ChordLine
        Public Measures As New List(Of Measure)
    End Class

End Class
