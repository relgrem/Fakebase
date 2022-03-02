<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchDB))
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.pnlDialogButtons = New System.Windows.Forms.Panel()
        Me.cmdOKAY = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SC = New System.Windows.Forms.SplitContainer()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCt = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lvPlaylist = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlRightBottom = New System.Windows.Forms.Panel()
        Me.cmdSave_PL = New System.Windows.Forms.Button()
        Me.pnlRight_Top = New System.Windows.Forms.Panel()
        Me.pnlPlaylist_Tool = New System.Windows.Forms.Panel()
        Me.cmdPL_Down = New System.Windows.Forms.Button()
        Me.cmdPL_Up = New System.Windows.Forms.Button()
        Me.cmdPL_DELETE = New System.Windows.Forms.Button()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.cmdPlaylist = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbHighlight = New System.Windows.Forms.RadioButton()
        Me.rbFilter = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAny = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.SD = New System.Windows.Forms.SaveFileDialog()
        Me.pnlBottom.SuspendLayout()
        Me.pnlDialogButtons.SuspendLayout()
        CType(Me.SC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC.Panel1.SuspendLayout()
        Me.SC.Panel2.SuspendLayout()
        Me.SC.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlRightBottom.SuspendLayout()
        Me.pnlRight_Top.SuspendLayout()
        Me.pnlPlaylist_Tool.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdDelete)
        Me.pnlBottom.Controls.Add(Me.pnlDialogButtons)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(36, 465)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(749, 83)
        Me.pnlBottom.TabIndex = 5
        '
        'cmdDelete
        '
        Me.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(0, 0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(130, 83)
        Me.cmdDelete.TabIndex = 99
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'pnlDialogButtons
        '
        Me.pnlDialogButtons.Controls.Add(Me.cmdOKAY)
        Me.pnlDialogButtons.Controls.Add(Me.cmdCancel)
        Me.pnlDialogButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDialogButtons.Location = New System.Drawing.Point(549, 0)
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
        Me.cmdOKAY.TabIndex = 5
        Me.cmdOKAY.Text = "OKAY"
        Me.cmdOKAY.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdCancel.Location = New System.Drawing.Point(0, 54)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(200, 29)
        Me.cmdCancel.TabIndex = 99
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'SC
        '
        Me.SC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC.Location = New System.Drawing.Point(36, 66)
        Me.SC.Name = "SC"
        Me.SC.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC.Panel1
        '
        Me.SC.Panel1.Controls.Add(Me.LV)
        '
        'SC.Panel2
        '
        Me.SC.Panel2.Controls.Add(Me.lblCt)
        Me.SC.Size = New System.Drawing.Size(749, 482)
        Me.SC.SplitterDistance = 347
        Me.SC.TabIndex = 9
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(0, 0)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(749, 347)
        Me.LV.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LV.TabIndex = 4
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Song"
        Me.ColumnHeader1.Width = 422
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Artist"
        Me.ColumnHeader2.Width = 305
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "File"
        Me.ColumnHeader4.Width = 100
        '
        'lblCt
        '
        Me.lblCt.AutoSize = True
        Me.lblCt.Location = New System.Drawing.Point(6, 0)
        Me.lblCt.Name = "lblCt"
        Me.lblCt.Size = New System.Drawing.Size(38, 13)
        Me.lblCt.TabIndex = 0
        Me.lblCt.Text = "Ready"
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.lvPlaylist)
        Me.pnlRight.Controls.Add(Me.pnlRightBottom)
        Me.pnlRight.Controls.Add(Me.pnlRight_Top)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(785, 66)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(211, 482)
        Me.pnlRight.TabIndex = 8
        Me.pnlRight.Visible = False
        '
        'lvPlaylist
        '
        Me.lvPlaylist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lvPlaylist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPlaylist.HideSelection = False
        Me.lvPlaylist.Location = New System.Drawing.Point(0, 71)
        Me.lvPlaylist.Name = "lvPlaylist"
        Me.lvPlaylist.Size = New System.Drawing.Size(211, 328)
        Me.lvPlaylist.TabIndex = 99
        Me.lvPlaylist.UseCompatibleStateImageBehavior = False
        Me.lvPlaylist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Song"
        Me.ColumnHeader3.Width = 186
        '
        'pnlRightBottom
        '
        Me.pnlRightBottom.Controls.Add(Me.cmdSave_PL)
        Me.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRightBottom.Location = New System.Drawing.Point(0, 399)
        Me.pnlRightBottom.Name = "pnlRightBottom"
        Me.pnlRightBottom.Size = New System.Drawing.Size(211, 83)
        Me.pnlRightBottom.TabIndex = 1
        '
        'cmdSave_PL
        '
        Me.cmdSave_PL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSave_PL.Location = New System.Drawing.Point(0, 0)
        Me.cmdSave_PL.Name = "cmdSave_PL"
        Me.cmdSave_PL.Size = New System.Drawing.Size(211, 83)
        Me.cmdSave_PL.TabIndex = 99
        Me.cmdSave_PL.Text = "SAVE PLAYLIST"
        Me.cmdSave_PL.UseVisualStyleBackColor = True
        '
        'pnlRight_Top
        '
        Me.pnlRight_Top.Controls.Add(Me.pnlPlaylist_Tool)
        Me.pnlRight_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRight_Top.Location = New System.Drawing.Point(0, 0)
        Me.pnlRight_Top.Name = "pnlRight_Top"
        Me.pnlRight_Top.Size = New System.Drawing.Size(211, 71)
        Me.pnlRight_Top.TabIndex = 0
        '
        'pnlPlaylist_Tool
        '
        Me.pnlPlaylist_Tool.Controls.Add(Me.cmdPL_Down)
        Me.pnlPlaylist_Tool.Controls.Add(Me.cmdPL_Up)
        Me.pnlPlaylist_Tool.Controls.Add(Me.cmdPL_DELETE)
        Me.pnlPlaylist_Tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPlaylist_Tool.Location = New System.Drawing.Point(0, 36)
        Me.pnlPlaylist_Tool.Name = "pnlPlaylist_Tool"
        Me.pnlPlaylist_Tool.Size = New System.Drawing.Size(211, 35)
        Me.pnlPlaylist_Tool.TabIndex = 0
        '
        'cmdPL_Down
        '
        Me.cmdPL_Down.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPL_Down.Image = CType(resources.GetObject("cmdPL_Down.Image"), System.Drawing.Image)
        Me.cmdPL_Down.Location = New System.Drawing.Point(68, 0)
        Me.cmdPL_Down.Name = "cmdPL_Down"
        Me.cmdPL_Down.Size = New System.Drawing.Size(34, 35)
        Me.cmdPL_Down.TabIndex = 99
        Me.cmdPL_Down.UseVisualStyleBackColor = True
        '
        'cmdPL_Up
        '
        Me.cmdPL_Up.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPL_Up.Image = CType(resources.GetObject("cmdPL_Up.Image"), System.Drawing.Image)
        Me.cmdPL_Up.Location = New System.Drawing.Point(34, 0)
        Me.cmdPL_Up.Name = "cmdPL_Up"
        Me.cmdPL_Up.Size = New System.Drawing.Size(34, 35)
        Me.cmdPL_Up.TabIndex = 99
        Me.cmdPL_Up.UseVisualStyleBackColor = True
        '
        'cmdPL_DELETE
        '
        Me.cmdPL_DELETE.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPL_DELETE.Image = CType(resources.GetObject("cmdPL_DELETE.Image"), System.Drawing.Image)
        Me.cmdPL_DELETE.Location = New System.Drawing.Point(0, 0)
        Me.cmdPL_DELETE.Name = "cmdPL_DELETE"
        Me.cmdPL_DELETE.Size = New System.Drawing.Size(34, 35)
        Me.cmdPL_DELETE.TabIndex = 99
        Me.cmdPL_DELETE.UseVisualStyleBackColor = True
        '
        'pnlLeft
        '
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 66)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(36, 482)
        Me.pnlLeft.TabIndex = 7
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.cmdPlaylist)
        Me.pnlTop.Controls.Add(Me.GroupBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(996, 66)
        Me.pnlTop.TabIndex = 6
        '
        'cmdPlaylist
        '
        Me.cmdPlaylist.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdPlaylist.Location = New System.Drawing.Point(893, 0)
        Me.cmdPlaylist.Name = "cmdPlaylist"
        Me.cmdPlaylist.Size = New System.Drawing.Size(103, 66)
        Me.cmdPlaylist.TabIndex = 99
        Me.cmdPlaylist.Text = "Playlist"
        Me.cmdPlaylist.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHighlight)
        Me.GroupBox1.Controls.Add(Me.rbFilter)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmdBrowse)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By"
        '
        'rbHighlight
        '
        Me.rbHighlight.AutoSize = True
        Me.rbHighlight.Location = New System.Drawing.Point(585, 42)
        Me.rbHighlight.Name = "rbHighlight"
        Me.rbHighlight.Size = New System.Drawing.Size(66, 17)
        Me.rbHighlight.TabIndex = 5
        Me.rbHighlight.Text = "Highlight"
        Me.rbHighlight.UseVisualStyleBackColor = True
        '
        'rbFilter
        '
        Me.rbFilter.AutoSize = True
        Me.rbFilter.Checked = True
        Me.rbFilter.Location = New System.Drawing.Point(585, 21)
        Me.rbFilter.Name = "rbFilter"
        Me.rbFilter.Size = New System.Drawing.Size(47, 17)
        Me.rbFilter.TabIndex = 4
        Me.rbFilter.TabStop = True
        Me.rbFilter.Text = "Filter"
        Me.rbFilter.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtAny)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(391, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 47)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Any Field"
        '
        'txtAny
        '
        Me.txtAny.BackColor = System.Drawing.Color.MintCream
        Me.txtAny.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAny.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAny.Location = New System.Drawing.Point(3, 16)
        Me.txtAny.Name = "txtAny"
        Me.txtAny.Size = New System.Drawing.Size(178, 31)
        Me.txtAny.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtArtist)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(199, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 47)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Artist"
        '
        'txtArtist
        '
        Me.txtArtist.BackColor = System.Drawing.Color.MintCream
        Me.txtArtist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtist.Location = New System.Drawing.Point(3, 16)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(186, 31)
        Me.txtArtist.TabIndex = 1
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdBrowse.Location = New System.Drawing.Point(657, 16)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(122, 47)
        Me.cmdBrowse.TabIndex = 3
        Me.cmdBrowse.Text = "Apply"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 47)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.MintCream
        Me.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(3, 16)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(190, 31)
        Me.txtTitle.TabIndex = 0
        '
        'frmSearchDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 548)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.SC)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchDB"
        Me.Text = "Search DB"
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlDialogButtons.ResumeLayout(False)
        Me.SC.Panel1.ResumeLayout(False)
        Me.SC.Panel2.ResumeLayout(False)
        Me.SC.Panel2.PerformLayout()
        CType(Me.SC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRightBottom.ResumeLayout(False)
        Me.pnlRight_Top.ResumeLayout(False)
        Me.pnlPlaylist_Tool.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlDialogButtons As Panel
    Friend WithEvents cmdOKAY As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents SC As SplitContainer
    Friend WithEvents LV As ListView
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtAny As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents rbHighlight As RadioButton
    Friend WithEvents rbFilter As RadioButton
    Friend WithEvents cmdPlaylist As Button
    Friend WithEvents lvPlaylist As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents pnlRightBottom As Panel
    Friend WithEvents pnlRight_Top As Panel
    Friend WithEvents pnlPlaylist_Tool As Panel
    Friend WithEvents cmdPL_Down As Button
    Friend WithEvents cmdPL_Up As Button
    Friend WithEvents cmdPL_DELETE As Button
    Friend WithEvents cmdSave_PL As Button
    Friend WithEvents SD As SaveFileDialog
    Friend WithEvents cmdDelete As Button
    Friend WithEvents lblCt As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
