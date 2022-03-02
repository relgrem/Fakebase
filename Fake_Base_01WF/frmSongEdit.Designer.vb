<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSongEdit))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmbViewSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cmbViewMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtPatch = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtTimeSig = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTempo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.gbTitle = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lblSts = New System.Windows.Forms.Label()
        Me.pnlDialogButtons = New System.Windows.Forms.Panel()
        Me.cmdOKAY = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TABS = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtBottomNote = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTopNote = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSubTitle = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtLyrics = New System.Windows.Forms.TextBox()
        Me.pnlLyricsLeft = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdLyrEnter = New System.Windows.Forms.Button()
        Me.cmdLyrSpace = New System.Windows.Forms.Button()
        Me.cmdLyrTab = New System.Windows.Forms.Button()
        Me.pnlLyricsTop = New System.Windows.Forms.Panel()
        Me.cmdLyric_alt_search = New System.Windows.Forms.Button()
        Me.cmdCompress3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdViewBytes = New System.Windows.Forms.Button()
        Me.cmdFindChords = New System.Windows.Forms.Button()
        Me.cmdInternet = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SC_Chords = New System.Windows.Forms.SplitContainer()
        Me.txtChords = New System.Windows.Forms.TextBox()
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddChords = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlChordRend = New System.Windows.Forms.Panel()
        Me.picChords = New System.Windows.Forms.PictureBox()
        Me.VS = New System.Windows.Forms.VScrollBar()
        Me.pnlChordSec = New System.Windows.Forms.Panel()
        Me.cmdC_Add = New System.Windows.Forms.Button()
        Me.cmdB_Sec = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.cmdBridge = New System.Windows.Forms.Button()
        Me.cmdPrechorus = New System.Windows.Forms.Button()
        Me.cmdChorus = New System.Windows.Forms.Button()
        Me.cmdVerse = New System.Windows.Forms.Button()
        Me.SD = New System.Windows.Forms.SaveFileDialog()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnlTop.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTitle.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlDialogButtons.SuspendLayout()
        Me.TABS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlLyricsLeft.SuspendLayout()
        Me.pnlLyricsTop.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SC_Chords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC_Chords.Panel1.SuspendLayout()
        Me.SC_Chords.Panel2.SuspendLayout()
        Me.SC_Chords.SuspendLayout()
        Me.CTX.SuspendLayout()
        Me.pnlChordRend.SuspendLayout()
        CType(Me.picChords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChordSec.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.GroupBox10)
        Me.pnlTop.Controls.Add(Me.GroupBox9)
        Me.pnlTop.Controls.Add(Me.GroupBox8)
        Me.pnlTop.Controls.Add(Me.GroupBox7)
        Me.pnlTop.Controls.Add(Me.GroupBox3)
        Me.pnlTop.Controls.Add(Me.GroupBox2)
        Me.pnlTop.Controls.Add(Me.GroupBox1)
        Me.pnlTop.Controls.Add(Me.gbTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(841, 100)
        Me.pnlTop.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmbViewSize)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox10.Location = New System.Drawing.Point(650, 48)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Line Spacing"
        '
        'cmbViewSize
        '
        Me.cmbViewSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbViewSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbViewSize.FormattingEnabled = True
        Me.cmbViewSize.Items.AddRange(New Object() {"Default", "14", "18", "20", "24", "36", "48"})
        Me.cmbViewSize.Location = New System.Drawing.Point(3, 16)
        Me.cmbViewSize.Name = "cmbViewSize"
        Me.cmbViewSize.Size = New System.Drawing.Size(139, 28)
        Me.cmbViewSize.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmbViewMode)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox9.Location = New System.Drawing.Point(505, 48)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "View Mode"
        '
        'cmbViewMode
        '
        Me.cmbViewMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbViewMode.FormattingEnabled = True
        Me.cmbViewMode.Items.AddRange(New Object() {"Auto", "Lyrics Only", "Lyrics and Chords", "Hybrid"})
        Me.cmbViewMode.Location = New System.Drawing.Point(3, 16)
        Me.cmbViewMode.Name = "cmbViewMode"
        Me.cmbViewMode.Size = New System.Drawing.Size(139, 28)
        Me.cmbViewMode.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtPatch)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox8.Location = New System.Drawing.Point(410, 48)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(95, 52)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Patch"
        '
        'txtPatch
        '
        Me.txtPatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatch.Location = New System.Drawing.Point(3, 16)
        Me.txtPatch.Name = "txtPatch"
        Me.txtPatch.Size = New System.Drawing.Size(89, 26)
        Me.txtPatch.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtTimeSig)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(341, 48)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(69, 52)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Time Sig"
        '
        'txtTimeSig
        '
        Me.txtTimeSig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTimeSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeSig.Location = New System.Drawing.Point(3, 16)
        Me.txtTimeSig.Name = "txtTimeSig"
        Me.txtTimeSig.Size = New System.Drawing.Size(63, 26)
        Me.txtTimeSig.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTempo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(272, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(69, 52)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tempo"
        '
        'txtTempo
        '
        Me.txtTempo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempo.Location = New System.Drawing.Point(3, 16)
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(63, 26)
        Me.txtTempo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKey)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(200, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(72, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Key"
        '
        'txtKey
        '
        Me.txtKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(3, 16)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(66, 26)
        Me.txtKey.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artist"
        '
        'txtArtist
        '
        Me.txtArtist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtist.Location = New System.Drawing.Point(3, 16)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(194, 26)
        Me.txtArtist.TabIndex = 0
        '
        'gbTitle
        '
        Me.gbTitle.Controls.Add(Me.txtName)
        Me.gbTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbTitle.Location = New System.Drawing.Point(0, 0)
        Me.gbTitle.Name = "gbTitle"
        Me.gbTitle.Size = New System.Drawing.Size(841, 48)
        Me.gbTitle.TabIndex = 0
        Me.gbTitle.TabStop = False
        Me.gbTitle.Text = "Title"
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(3, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(835, 29)
        Me.txtName.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lblSts)
        Me.pnlBottom.Controls.Add(Me.pnlDialogButtons)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 466)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(841, 83)
        Me.pnlBottom.TabIndex = 1
        '
        'lblSts
        '
        Me.lblSts.AutoSize = True
        Me.lblSts.Location = New System.Drawing.Point(12, 3)
        Me.lblSts.Name = "lblSts"
        Me.lblSts.Size = New System.Drawing.Size(38, 13)
        Me.lblSts.TabIndex = 1
        Me.lblSts.Text = "Ready"
        '
        'pnlDialogButtons
        '
        Me.pnlDialogButtons.Controls.Add(Me.cmdOKAY)
        Me.pnlDialogButtons.Controls.Add(Me.cmdCancel)
        Me.pnlDialogButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDialogButtons.Location = New System.Drawing.Point(641, 0)
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
        'TABS
        '
        Me.TABS.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TABS.Controls.Add(Me.TabPage1)
        Me.TABS.Controls.Add(Me.TabPage2)
        Me.TABS.Controls.Add(Me.TabPage3)
        Me.TABS.Controls.Add(Me.TabPage4)
        Me.TABS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABS.Location = New System.Drawing.Point(0, 100)
        Me.TABS.Multiline = True
        Me.TABS.Name = "TABS"
        Me.TABS.SelectedIndex = 0
        Me.TABS.Size = New System.Drawing.Size(841, 366)
        Me.TABS.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 337)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Song Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtBottomNote)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(3, 175)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(827, 120)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bottom Note"
        '
        'txtBottomNote
        '
        Me.txtBottomNote.AcceptsReturn = True
        Me.txtBottomNote.AcceptsTab = True
        Me.txtBottomNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBottomNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBottomNote.Location = New System.Drawing.Point(3, 16)
        Me.txtBottomNote.Multiline = True
        Me.txtBottomNote.Name = "txtBottomNote"
        Me.txtBottomNote.Size = New System.Drawing.Size(821, 101)
        Me.txtBottomNote.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTopNote)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(827, 120)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Top Note"
        '
        'txtTopNote
        '
        Me.txtTopNote.AcceptsReturn = True
        Me.txtTopNote.AcceptsTab = True
        Me.txtTopNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTopNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopNote.Location = New System.Drawing.Point(3, 16)
        Me.txtTopNote.Multiline = True
        Me.txtTopNote.Name = "txtTopNote"
        Me.txtTopNote.Size = New System.Drawing.Size(821, 101)
        Me.txtTopNote.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSubTitle)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(827, 52)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sub Title"
        '
        'txtSubTitle
        '
        Me.txtSubTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTitle.Location = New System.Drawing.Point(3, 16)
        Me.txtSubTitle.Name = "txtSubTitle"
        Me.txtSubTitle.Size = New System.Drawing.Size(821, 26)
        Me.txtSubTitle.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtLyrics)
        Me.TabPage2.Controls.Add(Me.pnlLyricsLeft)
        Me.TabPage2.Controls.Add(Me.pnlLyricsTop)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(833, 337)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lyrics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtLyrics
        '
        Me.txtLyrics.AcceptsReturn = True
        Me.txtLyrics.AcceptsTab = True
        Me.txtLyrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLyrics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLyrics.Location = New System.Drawing.Point(112, 39)
        Me.txtLyrics.Multiline = True
        Me.txtLyrics.Name = "txtLyrics"
        Me.txtLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLyrics.Size = New System.Drawing.Size(718, 295)
        Me.txtLyrics.TabIndex = 1
        '
        'pnlLyricsLeft
        '
        Me.pnlLyricsLeft.Controls.Add(Me.Button1)
        Me.pnlLyricsLeft.Controls.Add(Me.cmdLyrEnter)
        Me.pnlLyricsLeft.Controls.Add(Me.cmdLyrSpace)
        Me.pnlLyricsLeft.Controls.Add(Me.cmdLyrTab)
        Me.pnlLyricsLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLyricsLeft.Location = New System.Drawing.Point(3, 39)
        Me.pnlLyricsLeft.Name = "pnlLyricsLeft"
        Me.pnlLyricsLeft.Size = New System.Drawing.Size(109, 295)
        Me.pnlLyricsLeft.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "[DEL]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdLyrEnter
        '
        Me.cmdLyrEnter.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdLyrEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLyrEnter.Location = New System.Drawing.Point(0, 140)
        Me.cmdLyrEnter.Name = "cmdLyrEnter"
        Me.cmdLyrEnter.Size = New System.Drawing.Size(109, 70)
        Me.cmdLyrEnter.TabIndex = 2
        Me.cmdLyrEnter.Text = "[ENTER]"
        Me.cmdLyrEnter.UseVisualStyleBackColor = True
        '
        'cmdLyrSpace
        '
        Me.cmdLyrSpace.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdLyrSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLyrSpace.Location = New System.Drawing.Point(0, 70)
        Me.cmdLyrSpace.Name = "cmdLyrSpace"
        Me.cmdLyrSpace.Size = New System.Drawing.Size(109, 70)
        Me.cmdLyrSpace.TabIndex = 1
        Me.cmdLyrSpace.Text = "[SPACE]"
        Me.cmdLyrSpace.UseVisualStyleBackColor = True
        '
        'cmdLyrTab
        '
        Me.cmdLyrTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdLyrTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLyrTab.Location = New System.Drawing.Point(0, 0)
        Me.cmdLyrTab.Name = "cmdLyrTab"
        Me.cmdLyrTab.Size = New System.Drawing.Size(109, 70)
        Me.cmdLyrTab.TabIndex = 0
        Me.cmdLyrTab.Text = "[TAB]"
        Me.cmdLyrTab.UseVisualStyleBackColor = True
        '
        'pnlLyricsTop
        '
        Me.pnlLyricsTop.Controls.Add(Me.cmdLyric_alt_search)
        Me.pnlLyricsTop.Controls.Add(Me.cmdCompress3)
        Me.pnlLyricsTop.Controls.Add(Me.Button2)
        Me.pnlLyricsTop.Controls.Add(Me.cmdViewBytes)
        Me.pnlLyricsTop.Controls.Add(Me.cmdFindChords)
        Me.pnlLyricsTop.Controls.Add(Me.cmdInternet)
        Me.pnlLyricsTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLyricsTop.Location = New System.Drawing.Point(3, 3)
        Me.pnlLyricsTop.Name = "pnlLyricsTop"
        Me.pnlLyricsTop.Size = New System.Drawing.Size(827, 36)
        Me.pnlLyricsTop.TabIndex = 0
        '
        'cmdLyric_alt_search
        '
        Me.cmdLyric_alt_search.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdLyric_alt_search.Location = New System.Drawing.Point(484, 0)
        Me.cmdLyric_alt_search.Name = "cmdLyric_alt_search"
        Me.cmdLyric_alt_search.Size = New System.Drawing.Size(93, 36)
        Me.cmdLyric_alt_search.TabIndex = 5
        Me.cmdLyric_alt_search.Text = "Search Lyrics"
        Me.cmdLyric_alt_search.UseVisualStyleBackColor = True
        '
        'cmdCompress3
        '
        Me.cmdCompress3.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdCompress3.Location = New System.Drawing.Point(403, 0)
        Me.cmdCompress3.Name = "cmdCompress3"
        Me.cmdCompress3.Size = New System.Drawing.Size(81, 36)
        Me.cmdCompress3.TabIndex = 4
        Me.cmdCompress3.Text = "Compress"
        Me.cmdCompress3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Location = New System.Drawing.Point(279, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Remove Dbl Spacing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdViewBytes
        '
        Me.cmdViewBytes.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdViewBytes.Location = New System.Drawing.Point(186, 0)
        Me.cmdViewBytes.Name = "cmdViewBytes"
        Me.cmdViewBytes.Size = New System.Drawing.Size(93, 36)
        Me.cmdViewBytes.TabIndex = 2
        Me.cmdViewBytes.Text = "Byte View"
        Me.cmdViewBytes.UseVisualStyleBackColor = True
        '
        'cmdFindChords
        '
        Me.cmdFindChords.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdFindChords.Location = New System.Drawing.Point(93, 0)
        Me.cmdFindChords.Name = "cmdFindChords"
        Me.cmdFindChords.Size = New System.Drawing.Size(93, 36)
        Me.cmdFindChords.TabIndex = 1
        Me.cmdFindChords.Text = "Find Chords"
        Me.cmdFindChords.UseVisualStyleBackColor = True
        '
        'cmdInternet
        '
        Me.cmdInternet.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdInternet.Location = New System.Drawing.Point(0, 0)
        Me.cmdInternet.Name = "cmdInternet"
        Me.cmdInternet.Size = New System.Drawing.Size(93, 36)
        Me.cmdInternet.TabIndex = 0
        Me.cmdInternet.Text = "Find Lyrics"
        Me.cmdInternet.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SC_Chords)
        Me.TabPage3.Controls.Add(Me.pnlChordSec)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(833, 337)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Chords"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SC_Chords
        '
        Me.SC_Chords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC_Chords.Location = New System.Drawing.Point(91, 0)
        Me.SC_Chords.Name = "SC_Chords"
        Me.SC_Chords.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC_Chords.Panel1
        '
        Me.SC_Chords.Panel1.Controls.Add(Me.txtChords)
        '
        'SC_Chords.Panel2
        '
        Me.SC_Chords.Panel2.Controls.Add(Me.pnlChordRend)
        Me.SC_Chords.Size = New System.Drawing.Size(742, 337)
        Me.SC_Chords.SplitterDistance = 164
        Me.SC_Chords.TabIndex = 3
        '
        'txtChords
        '
        Me.txtChords.ContextMenuStrip = Me.CTX
        Me.txtChords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChords.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChords.Location = New System.Drawing.Point(0, 0)
        Me.txtChords.Multiline = True
        Me.txtChords.Name = "txtChords"
        Me.txtChords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChords.Size = New System.Drawing.Size(742, 164)
        Me.txtChords.TabIndex = 0
        '
        'CTX
        '
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddChords})
        Me.CTX.Name = "CTX"
        Me.CTX.Size = New System.Drawing.Size(146, 26)
        '
        'mnuAddChords
        '
        Me.mnuAddChords.Name = "mnuAddChords"
        Me.mnuAddChords.Size = New System.Drawing.Size(145, 22)
        Me.mnuAddChords.Text = "Add Chord(s)"
        '
        'pnlChordRend
        '
        Me.pnlChordRend.Controls.Add(Me.VS)
        Me.pnlChordRend.Controls.Add(Me.picChords)
        Me.pnlChordRend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChordRend.Location = New System.Drawing.Point(0, 0)
        Me.pnlChordRend.Name = "pnlChordRend"
        Me.pnlChordRend.Size = New System.Drawing.Size(742, 169)
        Me.pnlChordRend.TabIndex = 2
        '
        'picChords
        '
        Me.picChords.Location = New System.Drawing.Point(3, 3)
        Me.picChords.Name = "picChords"
        Me.picChords.Size = New System.Drawing.Size(100, 50)
        Me.picChords.TabIndex = 1
        Me.picChords.TabStop = False
        '
        'VS
        '
        Me.VS.Dock = System.Windows.Forms.DockStyle.Right
        Me.VS.Location = New System.Drawing.Point(684, 0)
        Me.VS.Name = "VS"
        Me.VS.Size = New System.Drawing.Size(58, 169)
        Me.VS.TabIndex = 0
        '
        'pnlChordSec
        '
        Me.pnlChordSec.Controls.Add(Me.cmdC_Add)
        Me.pnlChordSec.Controls.Add(Me.cmdB_Sec)
        Me.pnlChordSec.Controls.Add(Me.cmdIntro)
        Me.pnlChordSec.Controls.Add(Me.cmdBridge)
        Me.pnlChordSec.Controls.Add(Me.cmdPrechorus)
        Me.pnlChordSec.Controls.Add(Me.cmdChorus)
        Me.pnlChordSec.Controls.Add(Me.cmdVerse)
        Me.pnlChordSec.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlChordSec.Location = New System.Drawing.Point(0, 0)
        Me.pnlChordSec.Name = "pnlChordSec"
        Me.pnlChordSec.Size = New System.Drawing.Size(91, 337)
        Me.pnlChordSec.TabIndex = 1
        '
        'cmdC_Add
        '
        Me.cmdC_Add.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdC_Add.Image = CType(resources.GetObject("cmdC_Add.Image"), System.Drawing.Image)
        Me.cmdC_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdC_Add.Location = New System.Drawing.Point(0, 292)
        Me.cmdC_Add.Name = "cmdC_Add"
        Me.cmdC_Add.Size = New System.Drawing.Size(91, 45)
        Me.cmdC_Add.TabIndex = 6
        Me.cmdC_Add.Text = "ADD"
        Me.cmdC_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdC_Add.UseVisualStyleBackColor = True
        '
        'cmdB_Sec
        '
        Me.cmdB_Sec.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdB_Sec.Location = New System.Drawing.Point(0, 225)
        Me.cmdB_Sec.Name = "cmdB_Sec"
        Me.cmdB_Sec.Size = New System.Drawing.Size(91, 45)
        Me.cmdB_Sec.TabIndex = 5
        Me.cmdB_Sec.Text = "B Section"
        Me.cmdB_Sec.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdIntro.Location = New System.Drawing.Point(0, 180)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(91, 45)
        Me.cmdIntro.TabIndex = 4
        Me.cmdIntro.Text = "Intro"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'cmdBridge
        '
        Me.cmdBridge.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdBridge.Location = New System.Drawing.Point(0, 135)
        Me.cmdBridge.Name = "cmdBridge"
        Me.cmdBridge.Size = New System.Drawing.Size(91, 45)
        Me.cmdBridge.TabIndex = 3
        Me.cmdBridge.Text = "Bridge"
        Me.cmdBridge.UseVisualStyleBackColor = True
        '
        'cmdPrechorus
        '
        Me.cmdPrechorus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPrechorus.Location = New System.Drawing.Point(0, 90)
        Me.cmdPrechorus.Name = "cmdPrechorus"
        Me.cmdPrechorus.Size = New System.Drawing.Size(91, 45)
        Me.cmdPrechorus.TabIndex = 2
        Me.cmdPrechorus.Text = "Prechorus"
        Me.cmdPrechorus.UseVisualStyleBackColor = True
        '
        'cmdChorus
        '
        Me.cmdChorus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdChorus.Location = New System.Drawing.Point(0, 45)
        Me.cmdChorus.Name = "cmdChorus"
        Me.cmdChorus.Size = New System.Drawing.Size(91, 45)
        Me.cmdChorus.TabIndex = 1
        Me.cmdChorus.Text = "Chorus"
        Me.cmdChorus.UseVisualStyleBackColor = True
        '
        'cmdVerse
        '
        Me.cmdVerse.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdVerse.Location = New System.Drawing.Point(0, 0)
        Me.cmdVerse.Name = "cmdVerse"
        Me.cmdVerse.Size = New System.Drawing.Size(91, 45)
        Me.cmdVerse.TabIndex = 0
        Me.cmdVerse.Text = "Verse"
        Me.cmdVerse.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(833, 337)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Hybrid"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'frmSongEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 549)
        Me.Controls.Add(Me.TABS)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSongEdit"
        Me.Text = "Song Properties"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTitle.ResumeLayout(False)
        Me.gbTitle.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlDialogButtons.ResumeLayout(False)
        Me.TABS.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pnlLyricsLeft.ResumeLayout(False)
        Me.pnlLyricsTop.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SC_Chords.Panel1.ResumeLayout(False)
        Me.SC_Chords.Panel1.PerformLayout()
        Me.SC_Chords.Panel2.ResumeLayout(False)
        CType(Me.SC_Chords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC_Chords.ResumeLayout(False)
        Me.CTX.ResumeLayout(False)
        Me.pnlChordRend.ResumeLayout(False)
        CType(Me.picChords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChordSec.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents gbTitle As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlDialogButtons As Panel
    Friend WithEvents cmdOKAY As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents TABS As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTempo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtKey As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtBottomNote As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtTopNote As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSubTitle As TextBox
    Friend WithEvents txtLyrics As TextBox
    Friend WithEvents pnlLyricsTop As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtTimeSig As TextBox
    Friend WithEvents SD As SaveFileDialog
    Friend WithEvents txtChords As TextBox
    Friend WithEvents pnlChordSec As Panel
    Friend WithEvents cmdB_Sec As Button
    Friend WithEvents cmdIntro As Button
    Friend WithEvents cmdBridge As Button
    Friend WithEvents cmdPrechorus As Button
    Friend WithEvents cmdChorus As Button
    Friend WithEvents cmdVerse As Button
    Friend WithEvents pnlChordRend As Panel
    Friend WithEvents CTX As ContextMenuStrip
    Friend WithEvents mnuAddChords As ToolStripMenuItem
    Friend WithEvents picChords As PictureBox
    Friend WithEvents VS As VScrollBar
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtPatch As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents cmbViewMode As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents cmbViewSize As ComboBox
    Friend WithEvents cmdC_Add As Button
    Friend WithEvents cmdInternet As Button
    Friend WithEvents lblSts As Label
    Friend WithEvents pnlLyricsLeft As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdLyrEnter As Button
    Friend WithEvents cmdLyrSpace As Button
    Friend WithEvents cmdLyrTab As Button
    Friend WithEvents cmdFindChords As Button
    Friend WithEvents cmdViewBytes As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdCompress3 As Button
    Friend WithEvents cmdLyric_alt_search As Button
    Friend WithEvents SC_Chords As SplitContainer
    Friend WithEvents TabPage4 As TabPage
End Class
