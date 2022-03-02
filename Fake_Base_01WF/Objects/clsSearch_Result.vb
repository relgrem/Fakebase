Public Class clsSearch_Result
    Public Song_Title$ = ""
    Public Sub_Title$ = ""
    Public Artist_Name$ = ""
    Public URL$ = ""
    Public Err$ = ""
    Private w1$ = "", w2$ = "", w3$ = ""
    Public Sub Populate_From_HTML_AZ(source$)
        '<tr><td class="text-left visitedlyr">
        '<a href="https://www.azlyrics.com/lyrics/beatles/letitbe.html">
        '1. <span><b>"Let It Be"</b> "Let It Be" Version </span> - <b>The Beatles</b></a>
        '</td></tr>
        Try
            Me.URL = String_Between(source, "<a href=""", """>")
            w1 = String_Between(source, "<span>", "</a>").Trim
            Me.Song_Title = String_Rightof(String_Leftof(w1, "</b>"), "<b>").Trim.Replace("""", "")
            w2 = String_Rightof(w1, "</span>").Trim
            w3 = String_Rightof(w2, "<b>").Trim
            Me.Artist_Name = String_Leftof(w3, "</b")
            Me.Sub_Title = String_Leftof(w2, "<b>").Trim
        Catch ex As Exception
            Me.Err = ex.Message
        End Try
    End Sub

    Public Sub Clear()
        Me.Err = ""
        Me.Artist_Name = ""
        Me.Song_Title = ""
        Me.Sub_Title = ""
        Me.URL = ""
        Me.w1 = ""
        Me.w2 = ""
        Me.w3 = ""
    End Sub

End Class
