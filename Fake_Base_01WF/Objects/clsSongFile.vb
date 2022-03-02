Imports System.ComponentModel
Public Class clsSongFile
    Public Song As New SongHeader
    Public Chords$
    Public Lyrics As String = ""
    Public SongStructure As String = ""
    Public FileID$ = ""
    Public FileName$ = ""

    Public Function Load(FromFile$) As Boolean
        Me.FileName = FromFile
        Dim file_contents As String = LoadFile(FromFile) & StrDup(120, Chr(1))

        Dim sections As String() = file_contents.Split(Chr(1))
        '
        Me.Song.Load(sections(0))
        'Section 1 Chords
        Me.Chords = sections(1)
        '
        'Section 2 Lyrics
        Me.Lyrics = sections(2)
        '
        'Section 3 Structure
        Me.SongStructure = sections(3)
        '
        Return True
        '
    End Function

    Public Function Save(toFile$) As Boolean
        If toFile = "" Then
            toFile = Me.Song.file_info.FullName
        End If
        Dim FileData$ = ""
        '
        FileData += Me.Song.Get_String() & Chr(1)
        FileData += Me.Chords & Chr(1)
        FileData += Me.Lyrics & Chr(1)
        FileData += Me.SongStructure & Chr(1)
        '
        SaveFile(toFile, FileData, True)
        Return True
    End Function

    Public Sub New_song_ID()
        Me.FileID = "%%"
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += "_" & My.Computer.Name & "_" & My.Computer.Network.ToString & "_"
        Me.FileID += Date.Now.ToUniversalTime.ToString
        Me.FileID += "_"
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += Chr(Int(Rnd() * 20) + 65)
        Me.FileID += "||"
    End Sub

End Class
Public Class SongHeader
    Private vbuf As Integer = 14            'Data Buffer Size
    Private fDat As String()
    Public file_info As System.IO.FileInfo  '----------------
    '
#Region "Properties"
    Public Property Title$
        Get
            Return fDat(0)
        End Get
        Set(value$)
            fDat(0) = value
        End Set
    End Property

    Public Property Subtitle$
        Get
            Return fDat(1)
        End Get
        Set(value$)
            fDat(1) = value
        End Set
    End Property

    Public Property Key$
        Get
            Return fDat(2)
        End Get
        Set(value$)
            fDat(2) = value
        End Set
    End Property

    Public Property Tempo$
        Get
            Return fDat(3)
        End Get
        Set(value$)
            fDat(3) = value
        End Set
    End Property

    Public Property TopNote$
        Get
            Return fDat(4)
        End Get
        Set(value$)
            fDat(4) = value
        End Set
    End Property

    Public Property BottomNote$
        Get
            Return fDat(5)
        End Get
        Set(value$)
            fDat(5) = value
        End Set
    End Property

    Public Property ViewMode$
        Get
            Return fDat(6)
        End Get
        Set(value$)
            fDat(6) = value
        End Set
    End Property

    Public Property ViewSize$
        Get
            Return fDat(7)
        End Get
        Set(value$)
            fDat(7) = value
        End Set
    End Property

    Public Property Classifications$
        Get
            Return fDat(8)
        End Get
        Set(value$)
            fDat(8) = value
        End Set
    End Property

    Public Property Artist$
        Get
            Return fDat(9)
        End Get
        Set(value$)
            fDat(9) = value
        End Set
    End Property

    Public Property TimeSig$
        Get
            Return fDat(10)
        End Get
        Set(value$)
            fDat(10) = value
        End Set
    End Property

    Public Property Patch$
        Get
            Return fDat(11)
        End Get
        Set(value$)
            fDat(11) = value
        End Set
    End Property

#End Region

    Public Function Beats_Per_Measure() As Integer
        Select Case Me.TimeSig
            Case "12", "12/4", "12/8"
                Return 12
            Case "3", "3/4"
                Return 3
            Case "6", "6,4"
                Return 6
            Case "5", "5/4"
                Return 5
            Case "7", "7/4"
                Return 7
            Case "2", "6/8"
                Return 2
            Case Else
                Return 4
        End Select
    End Function

    Public Function V_Size() As Integer
        Return Int(Val(Me.ViewSize))
    End Function

    Public Sub Load(FromSec_String$)
        FromSec_String += StrDup(vbuf, Chr(2))
        fDat = FromSec_String.Split(Chr(2))
    End Sub

    Public Sub New()
        ReDim fDat(vbuf)
    End Sub

    Public Function Get_String() As String
        Dim rv$ = ""
        For t As Integer = 0 To vbuf
            rv += fDat(t) & Chr(2)
        Next
        Return rv
    End Function

    Public Function Match(Compare_Object As SongHeader, AllFieldsValue$) As Boolean
        If AllFieldsValue.Length > 1 Then
            If Comp(Artist, AllFieldsValue) Then Return True
            If Comp(BottomNote, AllFieldsValue) Then Return True
            If Comp(Key, AllFieldsValue) Then Return True
            If Comp(Subtitle, AllFieldsValue) Then Return True
            If Comp(Tempo, AllFieldsValue) Then Return True
            If Comp(TimeSig, AllFieldsValue) Then Return True
            If Comp(Title, AllFieldsValue) Then Return True
            If Comp(TopNote, AllFieldsValue) Then Return True
        End If
        If Compare_Object IsNot Nothing Then
            If Compare_Object.Artist.Length > 0 Then
                If Comp(Artist, Compare_Object.Artist) Then Return True
            End If
            If Compare_Object.BottomNote.Length > 0 Then
                If Comp(BottomNote, Compare_Object.BottomNote) Then Return True
            End If
            If Compare_Object.Key.Length > 0 Then
                If Comp(Key, Compare_Object.Key) Then Return True
            End If
            If Compare_Object.Subtitle.Length > 0 Then
                If Comp(Subtitle, Compare_Object.Subtitle) Then Return True
            End If
            If Compare_Object.Tempo.Length > 0 Then
                If Comp(Tempo, Compare_Object.Tempo) Then Return True
            End If
            If Compare_Object.TimeSig.Length > 0 Then
                If Comp(TimeSig, Compare_Object.TimeSig) Then Return True
            End If
            If Compare_Object.Title.Length > 0 Then
                If Comp(Title, Compare_Object.Title) Then Return True
            End If
            If Compare_Object.TopNote.Length > 0 Then
                If Comp(TopNote, Compare_Object.TopNote) Then Return True
            End If
            'Flag Match
            If Compare_Object.Classifications.Length > 0 Then
                If FlagMatch(Me.Classifications, Compare_Object.Classifications, "-") Then Return True
            End If
        End If
        Return False
    End Function

    Public Function Comp(SourceString As String, Value As String) As Boolean
        Return SourceString.ToUpper.Contains(Value.ToUpper)
    End Function
End Class