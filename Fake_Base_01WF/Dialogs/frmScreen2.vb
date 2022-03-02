Public Class frmScreen2
    Dim Img_Files As New List(Of String)
    Dim Errs As New List(Of String)
    Dim Current_Image_Inx% = 0
    Public Event Image_Changed(Sender As Object, New_Image As Image)
    '--------------------------------------------------------------------------------
    Private img_Path$ = "C:\"
    Public Property ImageDir As String
        Get
            Return Me.img_Path
        End Get
        Set(value As String)
            Me.img_Path = value
        End Set
    End Property
    '----------------------------------------
    Public Enum Shuffle_Mode_Enum
        None
        Sequential
        Random
    End Enum
    '----------------------------------------
    Private vShuf_Mode As Shuffle_Mode_Enum
    Public Property Shuffle_Mode As Shuffle_Mode_Enum
        Get
            Return vShuf_Mode
        End Get
        Set(value As Shuffle_Mode_Enum)
            vShuf_Mode = value
        End Set
    End Property

    Private vSlide_Speed_Ms% = 2500
    Public Property Slide_Speed%
        Get
            Return vSlide_Speed_Ms
        End Get
        Set(value%)
            vSlide_Speed_Ms = value
        End Set
    End Property

    Public Sub Update_Lyrics(WithImage As Image)
        Try
            PIC.Image.Dispose()
            PIC.Image = WithImage
        Catch ex As Exception
            Err_Log("Update_Lyrics", ex.Message)
        End Try
    End Sub

    Public Sub Start_SS_Mode()
        PIC.SizeMode = PictureBoxSizeMode.CenterImage

        TMR1.Interval = vSlide_Speed_Ms
        TMR1.Enabled = True
    End Sub

    Public Sub Start_SS_Mode(ImageDir$, SlideSpeed%)
        vSlide_Speed_Ms = SlideSpeed
        Load_Image_List(ImageDir)
        Start_SS_Mode()
    End Sub

    Public Sub Load_Image_List(FromDir$)
        Me.img_Path = FromDir
        Dim di As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(FromDir)
        If di IsNot Nothing Then
            Me.Img_Files.Clear()
            Dim ffls As System.IO.FileInfo() = di.GetFiles("*.*")
            '
            Dim Exts$ = ".bmp|.jpg|.png|"
            For Each zFile As System.IO.FileInfo In ffls
                If Exts.Contains(zFile.Extension.ToLower & "|") Then
                    Me.Img_Files.Add(zFile.FullName)
                End If
            Next
            '
            di = Nothing
        End If
    End Sub

    Private Sub Err_Log(OpName$, Ex_Message$)
        Try
            Me.Errs.Add(DateTime.Now.ToString & " -- " & OpName & " -- " & Ex_Message)
        Catch ex As Exception
            Me.Errs.Add("LOG ERR -- " & ex.Message)
        End Try
    End Sub

    Private Sub TMR1_Tick(sender As Object, e As EventArgs) Handles TMR1.Tick
        Try
            If Me.Img_Files.Count = 0 Then Exit Sub
            If Current_Image_Inx > Me.Img_Files.Count - 2 Then
                Current_Image_Inx = 0
            Else
                Current_Image_Inx += 1
            End If
            Set_Image(Me.Img_Files(Current_Image_Inx))
        Catch ex As Exception
            Err_Log("TMR1", ex.Message)
        End Try
    End Sub

    Sub Set_Image(FromFile$)
        Try
            If PIC.Image IsNot Nothing Then
                PIC.Image.Dispose()
            End If
            PIC.Image = New Bitmap(FromFile)
            RaiseEvent Image_Changed(Me, PIC.Image)
        Catch ex As Exception
            Err_Log("Set Image", ex.Message)
        End Try
    End Sub
End Class