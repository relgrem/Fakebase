Namespace DB
    Public Class clsDBase
        Public Items As New List(Of SongHeader)

        Public Sub Load(FromDirs As List(Of String))
            Dim record$
            Dim dirf$
            Dim SubDirs As List(Of String)
            For Each source_dir As String In FromDirs
                dirf = source_dir
                If dirf.EndsWith("\") And dirf.Length > 1 Then dirf = dirf.Substring(0, dirf.Length - 1)
                SubDirs = Get_All_Sub_Dirs(dirf)
                SubDirs.Add(dirf)
                For Each Subdirectory As String In SubDirs
                    Dim di As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Subdirectory)
                    If di IsNot Nothing Then

                        Dim ffls As System.IO.FileInfo() = di.GetFiles("*.fkbkdat")
                        '
                        For Each zFile As System.IO.FileInfo In ffls
                            Dim ni As New SongHeader
                            ni.file_info = zFile
                            Dim fs As System.IO.FileStream
                            fs = System.IO.File.OpenRead(ni.file_info.FullName)
                            record = IO_Get_Next_Line(fs, 0, 1)
                            ni.Load(record)
                            Me.Items.Add(ni)
                            ni = Nothing
                            fs.Close()
                        Next
                        '
                        di = Nothing
                    End If
                Next
            Next
        End Sub

        Public Function Search(FromRec As SongHeader, Optional Search_All_Fields_For$ = "") As List(Of SongHeader)
            Dim rv As New List(Of SongHeader)
            For Each I As SongHeader In Me.Items
                If I.Match(FromRec, Search_All_Fields_For) Then
                    rv.Add(I)
                End If
            Next
            Return rv
        End Function

        Public Sub Load_If_Missing(FileName$)
            For Each I As SongHeader In Me.Items
                If I.file_info.FullName = FileName Then
                    Exit Sub
                End If
            Next
            Dim record$
            Dim ni As New SongHeader
            ni.file_info = New IO.FileInfo(FileName)
            Dim fs As System.IO.FileStream
            fs = System.IO.File.OpenRead(FileName)
            record = IO_Get_Next_Line(fs, 0, 1)
            ni.Load(record)
            Me.Items.Add(ni)
            ni = Nothing
            fs.Close()
        End Sub

        Public Sub Remove_Item(FileName$)
            Dim BFR As New List(Of SongHeader)
            For Each I As SongHeader In Me.Items
                If I.file_info.FullName <> FileName Then
                    BFR.Add(I)
                End If
            Next
            Me.Items.Clear()
            For Each I As SongHeader In BFR
                Me.Items.Add(I)
            Next
        End Sub

    End Class



End Namespace
