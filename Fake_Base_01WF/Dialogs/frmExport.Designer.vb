<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport))
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cdmOK = New System.Windows.Forms.Button()
        Me.SD = New System.Windows.Forms.SaveFileDialog()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbPlaylist = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTabzors = New System.Windows.Forms.CheckBox()
        Me.chkPDFs = New System.Windows.Forms.CheckBox()
        Me.chkFiles = New System.Windows.Forms.CheckBox()
        Me.pnlBottom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.Panel1)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 257)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(216, 100)
        Me.pnlBottom.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cdmOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(16, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(66, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cdmOK
        '
        Me.cdmOK.Location = New System.Drawing.Point(66, 3)
        Me.cdmOK.Name = "cdmOK"
        Me.cdmOK.Size = New System.Drawing.Size(121, 45)
        Me.cdmOK.TabIndex = 0
        Me.cdmOK.Text = "OK"
        Me.cdmOK.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(31, 32)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(101, 17)
        Me.rbAll.TabIndex = 1
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Entire Database"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbPlaylist
        '
        Me.rbPlaylist.AutoSize = True
        Me.rbPlaylist.Location = New System.Drawing.Point(31, 67)
        Me.rbPlaylist.Name = "rbPlaylist"
        Me.rbPlaylist.Size = New System.Drawing.Size(94, 17)
        Me.rbPlaylist.TabIndex = 2
        Me.rbPlaylist.Text = "Current Playlist"
        Me.rbPlaylist.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAll)
        Me.GroupBox1.Controls.Add(Me.rbPlaylist)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 115)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Records"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFiles)
        Me.GroupBox2.Controls.Add(Me.chkPDFs)
        Me.GroupBox2.Controls.Add(Me.chkTabzors)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'chkTabzors
        '
        Me.chkTabzors.AutoSize = True
        Me.chkTabzors.Location = New System.Drawing.Point(31, 19)
        Me.chkTabzors.Name = "chkTabzors"
        Me.chkTabzors.Size = New System.Drawing.Size(110, 17)
        Me.chkTabzors.TabIndex = 0
        Me.chkTabzors.Text = "Tab Delimited List"
        Me.chkTabzors.UseVisualStyleBackColor = True
        '
        'chkPDFs
        '
        Me.chkPDFs.AutoSize = True
        Me.chkPDFs.Location = New System.Drawing.Point(31, 43)
        Me.chkPDFs.Name = "chkPDFs"
        Me.chkPDFs.Size = New System.Drawing.Size(52, 17)
        Me.chkPDFs.TabIndex = 1
        Me.chkPDFs.Text = "PDFs"
        Me.chkPDFs.UseVisualStyleBackColor = True
        '
        'chkFiles
        '
        Me.chkFiles.AutoSize = True
        Me.chkFiles.Location = New System.Drawing.Point(31, 67)
        Me.chkFiles.Name = "chkFiles"
        Me.chkFiles.Size = New System.Drawing.Size(113, 17)
        Me.chkFiles.TabIndex = 2
        Me.chkFiles.Text = "Copy fkbkdat Files"
        Me.chkFiles.UseVisualStyleBackColor = True
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 357)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExport"
        Me.Text = "Export Song List"
        Me.pnlBottom.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottom As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents cdmOK As Button
    Friend WithEvents SD As SaveFileDialog
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents rbPlaylist As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFiles As CheckBox
    Friend WithEvents chkPDFs As CheckBox
    Friend WithEvents chkTabzors As CheckBox
End Class
