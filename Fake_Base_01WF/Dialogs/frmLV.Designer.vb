<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLV))
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlDialogButtons = New System.Windows.Forms.Panel()
        Me.cmdOKAY = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.SC = New System.Windows.Forms.SplitContainer()
        Me.LV = New System.Windows.Forms.ListView()
        Me.pnlBottom.SuspendLayout()
        Me.pnlDialogButtons.SuspendLayout()
        CType(Me.SC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC.Panel1.SuspendLayout()
        Me.SC.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.pnlDialogButtons)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 472)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(950, 83)
        Me.pnlBottom.TabIndex = 0
        '
        'pnlDialogButtons
        '
        Me.pnlDialogButtons.Controls.Add(Me.cmdOKAY)
        Me.pnlDialogButtons.Controls.Add(Me.cmdCancel)
        Me.pnlDialogButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDialogButtons.Location = New System.Drawing.Point(750, 0)
        Me.pnlDialogButtons.Name = "pnlDialogButtons"
        Me.pnlDialogButtons.Size = New System.Drawing.Size(200, 83)
        Me.pnlDialogButtons.TabIndex = 0
        '
        'cmdOKAY
        '
        Me.cmdOKAY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOKAY.Location = New System.Drawing.Point(0, 0)
        Me.cmdOKAY.Name = "cmdOKAY"
        Me.cmdOKAY.Size = New System.Drawing.Size(200, 54)
        Me.cmdOKAY.TabIndex = 1
        Me.cmdOKAY.Text = "OKAY"
        Me.cmdOKAY.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdCancel.Location = New System.Drawing.Point(0, 54)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(200, 29)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(950, 35)
        Me.pnlTop.TabIndex = 1
        '
        'pnlLeft
        '
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 35)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(78, 437)
        Me.pnlLeft.TabIndex = 2
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(870, 35)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(80, 437)
        Me.pnlRight.TabIndex = 3
        '
        'SC
        '
        Me.SC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC.Location = New System.Drawing.Point(78, 35)
        Me.SC.Name = "SC"
        Me.SC.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC.Panel1
        '
        Me.SC.Panel1.Controls.Add(Me.LV)
        Me.SC.Size = New System.Drawing.Size(792, 437)
        Me.SC.SplitterDistance = 315
        Me.SC.TabIndex = 4
        '
        'LV
        '
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(0, 0)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(792, 315)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'frmLV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 555)
        Me.Controls.Add(Me.SC)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLV"
        Me.Text = "Listing"
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlDialogButtons.ResumeLayout(False)
        Me.SC.Panel1.ResumeLayout(False)
        CType(Me.SC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents SC As SplitContainer
    Friend WithEvents pnlDialogButtons As Panel
    Friend WithEvents cmdOKAY As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents LV As ListView
End Class
