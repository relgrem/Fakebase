Public Class clsLyric_Browser
    Public Lyrics_Found$ = ""
    '
    Public spTitle$ = ""
    Public spArtist$ = ""
    Private ixp1% = 0
    Private ixp2% = 0
    Private ixp3% = 0
    Private ixp4% = 0
    Private ixp5% = 0
    '
    Private ept% = 0
    Public Match_Buffer As New List(Of String)
    Public result_lines As New List(Of clsSearch_Result)

    Public Sub LookFor(SongTitle$, artist$)
        Me.spTitle = SongTitle
        Me.spArtist = artist
        AZ_Method()
    End Sub

    Public Sub Find_Matches(Songtitle$, artist$)
        Me.Match_Buffer.Clear()
        Me.spTitle = Songtitle
        Me.spArtist = artist
        Dim u$ = "http://search.azlyrics.com/search.php?q="
        If Me.spArtist.Trim.Length > 0 Then
            u += Me.spArtist.Trim & " " & Me.spTitle
        Else
            u += Me.spTitle
        End If
        u = u.Replace(" ", "+")
        Dim search_page$ = GetPage(u)
        Clipboard.SetText(search_page)
        Beep()
        Dim ptr% = 0
        Dim sub_ptr% = 0
        Dim ne$ = "", nc$ = ""
        Do
            ptr = search_page.IndexOf("www.azlyrics.com/lyrics/", ptr + 1) 'earthgang/waywardsons.html")
            If ptr > 1 Then
                ne = ""
                sub_ptr = 0
                Do
                    nc = search_page.Substring(ptr + sub_ptr, 1)
                    If nc <> """" Then ne += nc
                    sub_ptr += 1
                Loop Until nc = """" Or sub_ptr >= search_page.Length
                If ne <> "" Then Me.Match_Buffer.Add(ne)
            End If
        Loop While ptr > 1

    End Sub
    Private Sub Google_Method()


    End Sub


    'https://search.azlyrics.com/search.php?q=Carry+on+Wayward
    Private Sub AZ_Method()
        '1) Search
        Dim u$ = "http://search.azlyrics.com/search.php?q="
        If Me.spArtist.Trim.Length > 0 Then
            u += Me.spArtist.Trim & " " & Me.spTitle
        Else
            u += Me.spTitle
        End If
        u = u.Replace(" ", "+")
        Dim search_page$ = GetPage(u)
        Me.result_lines.Clear()
        '<div class="panel-heading"><b>Song results:
        ixp1 = search_page.IndexOf("<b>Song results:</b>")
        If search_page <> "" Then
            Clipboard.SetText(search_page)
        End If
        If ixp1 > 0 Then
            For Each table_row As String In String_Get_HTML_Rows(String_Between(search_page.Substring(ixp1), "<table class=", "</table>"))
                If table_row.Length > 10 Then
                    Dim ni As New clsSearch_Result
                    ni.Populate_From_HTML_AZ(table_row)
                    If ni.Err.Length = 0 And ni.Song_Title.Length > 0 Then
                        Me.result_lines.Add(ni)
                        ni = Nothing
                    End If
                End If
            Next
        End If

    End Sub

    Public Function Get_AZ_Lyrics(URL$) As String
        Dim rv$ = ""
        Dim ResultPage$ = GetPage(URL)
        ixp1 = ResultPage.IndexOf("lyricsh")
        ixp2 = ResultPage.IndexOf("""</b><br>", ixp1)
        ixp3 = ResultPage.IndexOf("</div>", ixp2)
        If ixp3 > 0 And ixp2 > 0 Then
            Dim rslt$ = ResultPage.Substring(ixp2 + 16, ixp3 - ixp2 - 15)
            If rslt.Length > 0 Then
                ixp4 = rslt.IndexOf("-->")
                If ixp4 > 0 Then
                    rslt = rslt.Substring(ixp4 + 5)
                End If
                rslt = rslt.Trim
                If rslt.EndsWith(vbCrLf) Then rslt = rslt.Substring(0, rslt.Length - 2)
                If rslt.Contains(vbCrLf) Then
                    rslt = rslt.Replace("<br>", "")
                Else
                    rslt = rslt.Replace("<br>", vbCrLf)
                End If
                rslt = rslt.Replace("<", "").Replace("/", "").Replace("&amp", "&").Replace("&quot", """").Replace("i>", "")
                rv = rslt
                Me.Lyrics_Found = rslt
            End If
        End If
        Return rv
    End Function


    Public Function GetPage(URL$) As String
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL$)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim sourcecode As String = sr.ReadToEnd()
            sr.Close()
            response = Nothing
            request = Nothing
            Return sourcecode

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Get_Source(URL$) As String
        Return New System.Net.WebClient().DownloadString(URL)
    End Function




End Class


Public Class clsTab_Browser
    Public Result_String$ = ""

    Private ix1% = 0
    Private ix2% = 0
    Private ix3% = 0
    Private ix4% = 0

    'http://www.chordie.com/results.php?q=down+by+the+river+neil+young&np=0&ps=10&wf=2221&s=RPD&wf=2221&wm=wrd&type=&sp=1&sy=1&cat=&ul=&np=0

    Public Sub Search(Title$, Artist$)
        Dim url$ = "http://www.chordie.com/results.php?q=" 'down+by+the+river+neil+young&np=0&ps=10&wf=2221&s=RPD&wf=2221&wm=wrd&type=&sp=1&sy=1&cat=&ul=&np=0"
        Dim s$ = Title
        If Artist.Length > 0 Then s += " " & Artist
        url += s.Trim.Replace(" ", "+")
        url += "&np=0&ps=10&wf=2221&s=RPD&wf=2221&wm=wrd&type=&sp=1&sy=1&cat=&ul=&np=0"
        Dim search_page$ = GetPage(url)
        '"/chord.pere/tabfu.thudspace.net/y/young_neil/down_by_the_river.crd"
        Dim results As New List(Of String)
        ix2 = 0
        Do
            ix1 = search_page.IndexOf("/chord.pere", ix2)
            If ix1 > 0 Then
                ix2 = search_page.IndexOf("""", ix1)
                If ix2 > 0 Then
                    results.Add(search_page.Substring(ix1, ix2 - ix1))
                End If
            End If
        Loop Until ix1 = -1
        Dim result_page$ = ""
        If results.Count > 0 Then
            result_page = GetPage("http://www.chordie.com/" & results(0))
            Parse_Chordie_Page(result_page)
        End If

    End Sub

    Public Sub Parse_Chordie_Page(Source$)
        ix1 = Source.IndexOf("songChord")
        If ix1 > 0 Then
            ix2 = Source.IndexOf("<pre>", ix1)
            ix3 = Source.IndexOf("</pre>", ix2)
            Dim rv As String = Source.Substring(ix2 + 6, ix3 - ix2 - 6).Trim.Replace("&nbsp;", " ")
            Me.Result_String = rv
        Else
            Clipboard.SetText(Source)
            Beep()
        End If
    End Sub



    Public Function GetPage(URL$) As String
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL$)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim sourcecode As String = sr.ReadToEnd()
        sr.Close()
        response = Nothing
        request = Nothing
        Return sourcecode
    End Function


End Class
