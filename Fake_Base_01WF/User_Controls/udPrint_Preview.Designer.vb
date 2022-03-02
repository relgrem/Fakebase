<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class udPrint_Preview
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.gbPages = New System.Windows.Forms.GroupBox()
        Me.rbPg1 = New System.Windows.Forms.RadioButton()
        Me.rbPg2 = New System.Windows.Forms.RadioButton()
        Me.rbPG3 = New System.Windows.Forms.RadioButton()
        Me.rbPg4 = New System.Windows.Forms.RadioButton()
        Me.rbPG5 = New System.Windows.Forms.RadioButton()
        Me.rbPg6 = New System.Windows.Forms.RadioButton()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.gbPages.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 648)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(485, 28)
        Me.pnlBottom.TabIndex = 0
        '
        'gbPages
        '
        Me.gbPages.Controls.Add(Me.rbPg6)
        Me.gbPages.Controls.Add(Me.rbPG5)
        Me.gbPages.Controls.Add(Me.rbPg4)
        Me.gbPages.Controls.Add(Me.rbPG3)
        Me.gbPages.Controls.Add(Me.rbPg2)
        Me.gbPages.Controls.Add(Me.rbPg1)
        Me.gbPages.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbPages.Location = New System.Drawing.Point(0, 587)
        Me.gbPages.Name = "gbPages"
        Me.gbPages.Size = New System.Drawing.Size(485, 61)
        Me.gbPages.TabIndex = 1
        Me.gbPages.TabStop = False
        Me.gbPages.Text = "Page"
        '
        'rbPg1
        '
        Me.rbPg1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPg1.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPg1.Location = New System.Drawing.Point(3, 16)
        Me.rbPg1.Name = "rbPg1"
        Me.rbPg1.Size = New System.Drawing.Size(45, 42)
        Me.rbPg1.TabIndex = 0
        Me.rbPg1.TabStop = True
        Me.rbPg1.Text = "1"
        Me.rbPg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPg1.UseVisualStyleBackColor = True
        '
        'rbPg2
        '
        Me.rbPg2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPg2.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPg2.Enabled = False
        Me.rbPg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPg2.Location = New System.Drawing.Point(48, 16)
        Me.rbPg2.Name = "rbPg2"
        Me.rbPg2.Size = New System.Drawing.Size(45, 42)
        Me.rbPg2.TabIndex = 1
        Me.rbPg2.TabStop = True
        Me.rbPg2.Text = "2"
        Me.rbPg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPg2.UseVisualStyleBackColor = True
        '
        'rbPG3
        '
        Me.rbPG3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPG3.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPG3.Enabled = False
        Me.rbPG3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPG3.Location = New System.Drawing.Point(93, 16)
        Me.rbPG3.Name = "rbPG3"
        Me.rbPG3.Size = New System.Drawing.Size(45, 42)
        Me.rbPG3.TabIndex = 2
        Me.rbPG3.TabStop = True
        Me.rbPG3.Text = "3"
        Me.rbPG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPG3.UseVisualStyleBackColor = True
        '
        'rbPg4
        '
        Me.rbPg4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPg4.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPg4.Enabled = False
        Me.rbPg4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPg4.Location = New System.Drawing.Point(138, 16)
        Me.rbPg4.Name = "rbPg4"
        Me.rbPg4.Size = New System.Drawing.Size(45, 42)
        Me.rbPg4.TabIndex = 3
        Me.rbPg4.TabStop = True
        Me.rbPg4.Text = "4"
        Me.rbPg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPg4.UseVisualStyleBackColor = True
        '
        'rbPG5
        '
        Me.rbPG5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPG5.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPG5.Enabled = False
        Me.rbPG5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPG5.Location = New System.Drawing.Point(183, 16)
        Me.rbPG5.Name = "rbPG5"
        Me.rbPG5.Size = New System.Drawing.Size(45, 42)
        Me.rbPG5.TabIndex = 4
        Me.rbPG5.TabStop = True
        Me.rbPG5.Text = "5"
        Me.rbPG5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPG5.UseVisualStyleBackColor = True
        '
        'rbPg6
        '
        Me.rbPg6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPg6.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbPg6.Enabled = False
        Me.rbPg6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPg6.Location = New System.Drawing.Point(228, 16)
        Me.rbPg6.Name = "rbPg6"
        Me.rbPg6.Size = New System.Drawing.Size(45, 42)
        Me.rbPg6.TabIndex = 5
        Me.rbPg6.TabStop = True
        Me.rbPg6.Text = "6"
        Me.rbPg6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPg6.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(485, 24)
        Me.pnlTop.TabIndex = 2
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.pic)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(485, 563)
        Me.pnlMain.TabIndex = 3
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(3, 3)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(100, 50)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'udPrint_Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.gbPages)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "udPrint_Preview"
        Me.Size = New System.Drawing.Size(485, 676)
        Me.gbPages.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottom As Panel
    Friend WithEvents gbPages As GroupBox
    Friend WithEvents rbPg6 As RadioButton
    Friend WithEvents rbPG5 As RadioButton
    Friend WithEvents rbPg4 As RadioButton
    Friend WithEvents rbPG3 As RadioButton
    Friend WithEvents rbPg2 As RadioButton
    Friend WithEvents rbPg1 As RadioButton
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pic As PictureBox
End Class
