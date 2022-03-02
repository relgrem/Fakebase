<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreen2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScreen2))
        Me.PIC = New System.Windows.Forms.PictureBox()
        Me.TMR1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIC
        '
        Me.PIC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PIC.Location = New System.Drawing.Point(0, 0)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(800, 450)
        Me.PIC.TabIndex = 0
        Me.PIC.TabStop = False
        '
        'TMR1
        '
        '
        'frmScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PIC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScreen2"
        Me.Text = "Hello"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PIC As PictureBox
    Friend WithEvents TMR1 As Timer
End Class
