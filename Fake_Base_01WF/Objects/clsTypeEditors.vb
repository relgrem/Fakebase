Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Public Class Key_Code_Editor
    Inherits UITypeEditor
    Dim rv$ = ""
    Public Overloads Overrides Function GetEditStyle(ByVal context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overloads Overrides Function EditValue(ByVal context As ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object
        rv = ""
        Try
            rv = value = ToString()
            Dim f As New frmKeyCode
            f.Initialize(value)
            If f.ShowDialog = DialogResult.OK Then
                rv = f.Key_Code_String
            End If
        Catch ex As Exception

        End Try
        Return rv
    End Function

End Class

Public Class Path_Editor
    Inherits UITypeEditor
    Dim rv$ = ""
    Public Overloads Overrides Function GetEditStyle(ByVal context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overloads Overrides Function EditValue(ByVal context As ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object
        rv = ""
        Try
            rv = value = ToString()
            Dim f As New frmPath
            f.Initialize(value)
            If f.ShowDialog = DialogResult.OK Then
                rv = f.Selected_Path
            End If
        Catch ex As Exception

        End Try
        Return rv
    End Function

End Class
