Imports System.ComponentModel
Imports System.Drawing.Design

Public Class clsSysSettings
    Private vdir$ = ""
    Private vdir2$ = ""
    Private vdir3$ = ""
    Private vdir_ss$ = ""
    Private vDir_PL$ = ""
    'Key Mapping
    Private vkmPlayList_Down$ = "L"
    Private vkmPlayList_Up$ = "K"
    Private vkmLyricsDown$ = "C,V,B,N,M"
    Private vkmToggleChords$ = "A"
    Private vkmTogglePlaylist$ = "P"
    Private vkmFindButton$ = "F"
    Private vkmLyricsTop$ = "T"
    Private vkmSlideShow$ = "1"
    Private vkmLyricsMode$ = "2"
    '-----------------------------------------------
    'UI
    Private vDefaultSize% = 24
    Private vPlay_List_width% = 112
    Private vSlide_speed% = 4
    '-----------------------------------------------
    'Runtime
    Public SongDirs As New List(Of String)
    Public Undefined_Settings As New List(Of KeyValuePair(Of String, String))
    '
    <CategoryAttribute("File"), Browsable(True), DescriptionAttribute("Base directory for placing song sheets ("".fkbkDat"")."),
        EditorAttribute(GetType(Path_Editor), GetType(UITypeEditor))>
    Public Property Song_DIR As String
        Get
            Return vdir
        End Get
        Set(value As String)
            vdir = value
        End Set
    End Property

    <CategoryAttribute("File"), Browsable(True), DescriptionAttribute("Additional directory for placing song sheets ("".fkbkDat"")."),
        EditorAttribute(GetType(Path_Editor), GetType(UITypeEditor))>
    Public Property Song_DIR_2 As String
        Get
            Return vdir2
        End Get
        Set(value As String)
            vdir2 = value
        End Set
    End Property

    <CategoryAttribute("File"), Browsable(True), DescriptionAttribute("Additional directory for placing song sheets ("".fkbkDat"")."),
        EditorAttribute(GetType(Path_Editor), GetType(UITypeEditor))>
    Public Property Song_DIR_3 As String
        Get
            Return vdir3
        End Get
        Set(value As String)
            vdir3 = value
        End Set
    End Property

    <CategoryAttribute("File"), Browsable(True), DescriptionAttribute("Screen 2 slide-shows will run from this directory."),
        EditorAttribute(GetType(Path_Editor), GetType(UITypeEditor))>
    Public Property Slide_Show_DIR As String
        Get
            Return vdir_ss
        End Get
        Set(value As String)
            vdir_ss = value
        End Set
    End Property

    <CategoryAttribute("File"), Browsable(True), DescriptionAttribute("Default directory for saving/loading playlists."),
        EditorAttribute(GetType(Path_Editor), GetType(UITypeEditor))>
    Public Property Playlist_DIR As String
        Get
            Return vDir_PL
        End Get
        Set(value As String)
            vDir_PL = value
        End Set
    End Property

    <CategoryAttribute("UI"), Browsable(True), DescriptionAttribute("Size of the Lyrics Font used.")
        >
    Public Property Default_Size As Integer
        Get
            Return vDefaultSize
        End Get
        Set(value As Integer)
            vDefaultSize = value
        End Set
    End Property

    <CategoryAttribute("UI"), Browsable(True), DescriptionAttribute("Screen 2 slide-show time between images in seconds")
        >
    Public Property Slide_Speed As Integer
        Get
            Return vSlide_speed
        End Get
        Set(value As Integer)
            If value > 1000 Then
                value = Int(value / 1000) + 1
            End If
            vSlide_speed = value
        End Set
    End Property

    <CategoryAttribute("UI"), Browsable(True), DescriptionAttribute("Size of the Left-hand playlist panel when running in playlist mode.")
        >
    Public Property Playlist_Width As Integer
        Get
            Return vPlay_List_width
        End Get
        Set(value As Integer)
            vPlay_List_width = value
        End Set
    End Property


    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Key to move to the next item in the playlist."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Playlist_Down As String
        Get
            If Not vkmPlayList_Down.EndsWith(",") Then vkmPlayList_Down += ","
            Return vkmPlayList_Down
        End Get
        Set(value As String)
            vkmPlayList_Down = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Key to move to the previous item in the playlist."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Playlist_Up As String
        Get
            If Not vkmPlayList_Up.EndsWith(",") Then vkmPlayList_Up += ","
            Return vkmPlayList_Up
        End Get
        Set(value As String)
            vkmPlayList_Up = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Key to scroll-down the lyics view."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Lyrics_Down As String
        Get
            If Not vkmLyricsDown.EndsWith(",") Then vkmLyricsDown += ","
            Return vkmLyricsDown
        End Get
        Set(value As String)
            vkmLyricsDown = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Key to show/hide the chords view."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Toggle_Chords As String
        Get
            If Not vkmToggleChords.EndsWith(",") Then vkmToggleChords += ","
            Return vkmToggleChords
        End Get
        Set(value As String)
            vkmToggleChords = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Key to show/hide the playlist view."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Toggle_Playlist As String
        Get
            If Not vkmTogglePlaylist.EndsWith(",") Then vkmTogglePlaylist += ","
            Return vkmTogglePlaylist
        End Get
        Set(value As String)
            vkmTogglePlaylist = value
        End Set
    End Property

    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Presses the ""Find"" button in the top toolbar."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Find_Button As String
        Get
            If Not vkmFindButton.EndsWith(",") Then vkmFindButton += ","
            Return vkmFindButton
        End Get
        Set(value As String)
            vkmFindButton = value
        End Set
    End Property

    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Scrolls the Lyrics view to the top."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Lyrics_Top As String
        Get
            If Not vkmLyricsTop.EndsWith(",") Then vkmLyricsTop += ","
            Return vkmLyricsTop
        End Get
        Set(value As String)
            vkmLyricsTop = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Puts screen 2 in slide show mode."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Slide_Show As String
        Get
            If Not vkmSlideShow.EndsWith(",") Then vkmSlideShow += ","
            Return vkmSlideShow
        End Get
        Set(value As String)
            vkmSlideShow = value
        End Set
    End Property
    <CategoryAttribute("Key_Mapping"), Browsable(True), DescriptionAttribute("Puts screen 2 in Lyrics view mode."),
        EditorAttribute(GetType(Key_Code_Editor), GetType(UITypeEditor))>
    Public Property Key_Map_Lyrics_Mode As String
        Get
            If Not vkmLyricsMode.EndsWith(",") Then vkmLyricsMode += ","
            Return vkmLyricsMode
        End Get
        Set(value As String)
            vkmLyricsMode = value
        End Set
    End Property

    ''' <summary>
    ''' Loads and parses the app's config files
    ''' </summary>
    Public Sub Load()
        Dim sBag$ = LoadFile(App_path & "FKBA_Settings.txt")
        If sBag = "" Then Exit Sub
        sBag = Replace(sBag, vbCr, "")
        Dim lines As String() = sBag.Split(Chr(10))
        Dim Setting As KeyValuePair(Of String, String)
        For Each l As String In lines
            If l.Trim.Length > 1 Then
                Setting = Get_Setting(l)
                Apply_Setting(Setting.Key, Setting.Value)
            End If
        Next
    End Sub

    Public Sub Apply_Setting(Setting_Name$, Value$)
        If Setting_Name = "" Then Exit Sub
        Dim fv$ = ""
        Dim iv As Integer
        Select Case Setting_Name.ToUpper
            Case "DIR", "DIR2", "DIR3"
                If Value.Length > 0 Then
                    fv = Value.Replace("{APP}", App_path)
                    If Not fv.EndsWith("\") Then fv += "\"
                    If Not Me.SongDirs.Contains(fv) Then
                        Me.SongDirs.Add(fv)
                    End If
                    If Setting_Name.ToUpper = "DIR" Then Me.Song_DIR = fv
                    If Setting_Name.ToUpper = "DIR2" Then Me.Song_DIR_2 = fv
                    If Setting_Name.ToUpper = "DIR3" Then Me.Song_DIR_3 = fv
                End If
            Case "SLIDE_SHOW_DIR"
                fv = Value.Replace("{APP}", App_path)
                If Not fv.EndsWith("\") Then fv += "\"
                vdir_ss = fv
            Case "SIZE"
                iv = Int(Val(Value))
                If iv > 0 Then
                    Me.Default_Size = iv
                Else
                    Me.Default_Size = 24
                End If
            Case "PLAY_LIST_WIDTH"
                iv = Int(Val(fv))
                If iv > 5 Then
                    Me.Playlist_Width = iv
                Else
                    Me.Playlist_Width = 112
                End If
            Case "SLIDE_SPEED"
                iv = Int(Val(fv))
                If iv > 1000 Then
                    iv = Int(iv / 1000) + 1
                End If
                If iv = 0 Then iv = 3
                Me.vSlide_speed = iv
            Case "KM_FIND"
                Me.vkmFindButton = Value
            Case "KM_LYRICS_DOWN" 'KM_Lyrics_Down
                Me.vkmLyricsDown = Value
            Case "KM_LYRICS_MODE" 'KM_SS_Lyrics_Mode
                Me.vkmLyricsMode = Value
            Case "KM_LYRICS_TOP" 'KM_Lyrics_Top
                Me.vkmLyricsTop = Value
            Case "KM_PLAYLIST_DOWN" 'KM_Playlist_Down
                Me.vkmPlayList_Down = Value
            Case "KM_PLAYLIST_UP" 'KM_Playlist_up
                Me.vkmPlayList_Up = Value
            Case "KM_SLIDESHOW_MODE" 'KM_Slide_Show_Mode
                Me.vkmSlideShow = Value
            Case "KM_TOGGLE_CHORDS" 'KM_Toggle_Chords
                Me.vkmToggleChords = Value
            Case "KM_TOGGLE_PLAYLIST" 'KM_Toggle_Playlist
                Me.vkmTogglePlaylist = Value
            Case "" '


                '-------------======================-------------------=======================---------------
            Case Else
                'To be used in Debug for settings file
                Me.Undefined_Settings.Add(New KeyValuePair(Of String, String)(Setting_Name, Value))
        End Select
    End Sub

    Public Function Get_Setting_Names() As List(Of String)
        Dim rv As New List(Of String)
        rv.Add("DIR")
        rv.Add("DIR2")
        rv.Add("DIR3")
        rv.Add("SLIDE_SHOW_DIR")
        rv.Add("SIZE")
        rv.Add("PLAY_LIST_WIDTH")
        rv.Add("SLIDE_SPEED")
        rv.Add("KM_FIND")
        rv.Add("KM_LYRICS_DOWN") 'KM_Lyrics_Down
        rv.Add("KM_LYRICS_MODE") 'KM_SS_Lyrics_Mode
        rv.Add("KM_LYRICS_TOP") 'KM_Lyrics_Top
        rv.Add("KM_PLAYLIST_DOWN") 'KM_Playlist_Down
        rv.Add("KM_PLAYLIST_UP") 'KM_Playlist_up
        rv.Add("KM_SLIDESHOW_MODE") 'KM_Slide_Show_Mode
        rv.Add("KM_TOGGLE_CHORDS") 'KM_Toggle_Chords
        rv.Add("KM_TOGGLE_PLAYLIST") 'KM_Toggle_Playlist
        Return rv
    End Function

    Public Sub Save()
        Dim SS$ = "[Fakebase Settings]" & vbCrLf & vbCrLf
        'Paste this
        'SS += String_Setting("", Me, True, True)
        SS += String_Setting("dir", Me.vdir, True, True)
        SS += String_Setting("dir2", Me.vdir2, True, True)
        SS += String_Setting("dir3", Me.vdir3, True, True)
        SS += String_Setting("Slide_show_dir", Me.vdir_ss, True, True)

        SS += String_Setting("PLAY_LIST_WIDTH", Me.vPlay_List_width, True, True)
        SS += String_Setting("size", Me.vDefaultSize, True, True)
        SS += String_Setting("slide_speed", Me.vSlide_speed, True, True)
        SS += String_Setting("KM_Find", Me.vkmFindButton, True, True)
        SS += String_Setting("KM_Lyrics_Down", Me.vkmLyricsDown, True, True)
        SS += String_Setting("KM_SS_Lyrics_Mode", Me.vkmLyricsMode, True, True)
        SS += String_Setting("KM_Lyrics_Top", Me.vkmLyricsTop, True, True)
        SS += String_Setting("KM_Playlist_Down", Me.vkmPlayList_Down, True, True)
        SS += String_Setting("KM_Playlist_up", Me.vkmPlayList_Up, True, True)
        SS += String_Setting("KM_Slide_Show_Mode", Me.vkmSlideShow, True, True)
        SS += String_Setting("KM_Toggle_Chords", Me.vkmToggleChords, True, True)
        SS += String_Setting("KM_Toggle_Playlist", Me.vkmTogglePlaylist, True, True)
        '====================================================================================
        Try
            SaveFile(App_path & "FKBA_Settings.Txt", SS)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



End Class
