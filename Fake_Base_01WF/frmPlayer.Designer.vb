<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlayer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSS = New System.Windows.Forms.Panel()
        Me.picSS_View = New System.Windows.Forms.PictureBox()
        Me.gbSS_Mode = New System.Windows.Forms.GroupBox()
        Me.rbSS_Slideshow_Mode = New System.Windows.Forms.RadioButton()
        Me.rbS2_Lyrics = New System.Windows.Forms.RadioButton()
        Me.cmdRemoteScreen = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdSys = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.pnlSEP1 = New System.Windows.Forms.Panel()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdFindInDB = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.btnFocus = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadPlaylist = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPL_UP = New System.Windows.Forms.Button()
        Me.gbPlayList = New System.Windows.Forms.GroupBox()
        Me.cmbPlayList = New System.Windows.Forms.ComboBox()
        Me.pnlPL_Load = New System.Windows.Forms.Panel()
        Me.cmdDropdownPLMenu = New System.Windows.Forms.Button()
        Me.cmdPL_Clear = New System.Windows.Forms.Button()
        Me.cmdPL_Load = New System.Windows.Forms.Button()
        Me.cmdPL_Down = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SC = New System.Windows.Forms.SplitContainer()
        Me.VS_Top = New System.Windows.Forms.VScrollBar()
        Me.picChart = New System.Windows.Forms.PictureBox()
        Me.VS = New System.Windows.Forms.VScrollBar()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.gbSong_tempo = New System.Windows.Forms.GroupBox()
        Me.lblSong_Tempo = New System.Windows.Forms.Label()
        Me.gbSong_artist = New System.Windows.Forms.GroupBox()
        Me.lblSong_artist = New System.Windows.Forms.Label()
        Me.gbSong_patch = New System.Windows.Forms.GroupBox()
        Me.lblSong_Patch = New System.Windows.Forms.Label()
        Me.gbKey = New System.Windows.Forms.GroupBox()
        Me.lblSong_Key = New System.Windows.Forms.Label()
        Me.gbTitle = New System.Windows.Forms.GroupBox()
        Me.lblSong_title = New System.Windows.Forms.Label()
        Me.CD = New System.Windows.Forms.OpenFileDialog()
        Me.TMR = New System.Windows.Forms.Timer(Me.components)
        Me.SD = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlSS.SuspendLayout()
        CType(Me.picSS_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSS_Mode.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.CTX.SuspendLayout()
        Me.gbPlayList.SuspendLayout()
        Me.pnlPL_Load.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SC.Panel1.SuspendLayout()
        Me.SC.Panel2.SuspendLayout()
        Me.SC.SuspendLayout()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.gbSong_tempo.SuspendLayout()
        Me.gbSong_artist.SuspendLayout()
        Me.gbSong_patch.SuspendLayout()
        Me.gbKey.SuspendLayout()
        Me.gbTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.pnlSS)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cmdSys)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.cmdNew)
        Me.Panel1.Controls.Add(Me.cmdTest)
        Me.Panel1.Controls.Add(Me.pnlSEP1)
        Me.Panel1.Controls.Add(Me.cmdLoad)
        Me.Panel1.Controls.Add(Me.cmdFindInDB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 65)
        Me.Panel1.TabIndex = 0
        '
        'pnlSS
        '
        Me.pnlSS.Controls.Add(Me.picSS_View)
        Me.pnlSS.Controls.Add(Me.gbSS_Mode)
        Me.pnlSS.Controls.Add(Me.cmdRemoteScreen)
        Me.pnlSS.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSS.Location = New System.Drawing.Point(279, 0)
        Me.pnlSS.Name = "pnlSS"
        Me.pnlSS.Size = New System.Drawing.Size(61, 65)
        Me.pnlSS.TabIndex = 9
        '
        'picSS_View
        '
        Me.picSS_View.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picSS_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSS_View.Dock = System.Windows.Forms.DockStyle.Left
        Me.picSS_View.Location = New System.Drawing.Point(198, 0)
        Me.picSS_View.Name = "picSS_View"
        Me.picSS_View.Size = New System.Drawing.Size(100, 65)
        Me.picSS_View.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSS_View.TabIndex = 15
        Me.picSS_View.TabStop = False
        '
        'gbSS_Mode
        '
        Me.gbSS_Mode.Controls.Add(Me.rbSS_Slideshow_Mode)
        Me.gbSS_Mode.Controls.Add(Me.rbS2_Lyrics)
        Me.gbSS_Mode.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbSS_Mode.Location = New System.Drawing.Point(61, 0)
        Me.gbSS_Mode.Name = "gbSS_Mode"
        Me.gbSS_Mode.Size = New System.Drawing.Size(137, 65)
        Me.gbSS_Mode.TabIndex = 14
        Me.gbSS_Mode.TabStop = False
        Me.gbSS_Mode.Text = "Display Mode"
        '
        'rbSS_Slideshow_Mode
        '
        Me.rbSS_Slideshow_Mode.AutoSize = True
        Me.rbSS_Slideshow_Mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSS_Slideshow_Mode.Location = New System.Drawing.Point(6, 12)
        Me.rbSS_Slideshow_Mode.Name = "rbSS_Slideshow_Mode"
        Me.rbSS_Slideshow_Mode.Size = New System.Drawing.Size(123, 28)
        Me.rbSS_Slideshow_Mode.TabIndex = 12
        Me.rbSS_Slideshow_Mode.TabStop = True
        Me.rbSS_Slideshow_Mode.Text = "Slide Show"
        Me.rbSS_Slideshow_Mode.UseVisualStyleBackColor = True
        '
        'rbS2_Lyrics
        '
        Me.rbS2_Lyrics.AutoSize = True
        Me.rbS2_Lyrics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbS2_Lyrics.Location = New System.Drawing.Point(6, 34)
        Me.rbS2_Lyrics.Name = "rbS2_Lyrics"
        Me.rbS2_Lyrics.Size = New System.Drawing.Size(76, 28)
        Me.rbS2_Lyrics.TabIndex = 13
        Me.rbS2_Lyrics.TabStop = True
        Me.rbS2_Lyrics.Text = "Lyrics"
        Me.rbS2_Lyrics.UseVisualStyleBackColor = True
        '
        'cmdRemoteScreen
        '
        Me.cmdRemoteScreen.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRemoteScreen.Image = CType(resources.GetObject("cmdRemoteScreen.Image"), System.Drawing.Image)
        Me.cmdRemoteScreen.Location = New System.Drawing.Point(0, 0)
        Me.cmdRemoteScreen.Name = "cmdRemoteScreen"
        Me.cmdRemoteScreen.Size = New System.Drawing.Size(61, 65)
        Me.cmdRemoteScreen.TabIndex = 11
        Me.cmdRemoteScreen.TabStop = False
        Me.cmdRemoteScreen.Text = "Screen 2"
        Me.cmdRemoteScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRemoteScreen.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(1097, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(61, 65)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(255, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(24, 65)
        Me.Panel3.TabIndex = 7
        '
        'cmdSys
        '
        Me.cmdSys.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdSys.Image = CType(resources.GetObject("cmdSys.Image"), System.Drawing.Image)
        Me.cmdSys.Location = New System.Drawing.Point(1158, 0)
        Me.cmdSys.Name = "cmdSys"
        Me.cmdSys.Size = New System.Drawing.Size(61, 65)
        Me.cmdSys.TabIndex = 5
        Me.cmdSys.TabStop = False
        Me.cmdSys.Text = "System"
        Me.cmdSys.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSys.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(194, 0)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(61, 65)
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.TabStop = False
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(133, 0)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(61, 65)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.TabStop = False
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdTest.Image = CType(resources.GetObject("cmdTest.Image"), System.Drawing.Image)
        Me.cmdTest.Location = New System.Drawing.Point(1219, 0)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(61, 65)
        Me.cmdTest.TabIndex = 1
        Me.cmdTest.TabStop = False
        Me.cmdTest.Text = "Export"
        Me.cmdTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'pnlSEP1
        '
        Me.pnlSEP1.BackColor = System.Drawing.Color.Gray
        Me.pnlSEP1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSEP1.Location = New System.Drawing.Point(122, 0)
        Me.pnlSEP1.Name = "pnlSEP1"
        Me.pnlSEP1.Size = New System.Drawing.Size(11, 65)
        Me.pnlSEP1.TabIndex = 6
        '
        'cmdLoad
        '
        Me.cmdLoad.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdLoad.Image = CType(resources.GetObject("cmdLoad.Image"), System.Drawing.Image)
        Me.cmdLoad.Location = New System.Drawing.Point(61, 0)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(61, 65)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.TabStop = False
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdFindInDB
        '
        Me.cmdFindInDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdFindInDB.Image = CType(resources.GetObject("cmdFindInDB.Image"), System.Drawing.Image)
        Me.cmdFindInDB.Location = New System.Drawing.Point(0, 0)
        Me.cmdFindInDB.Name = "cmdFindInDB"
        Me.cmdFindInDB.Size = New System.Drawing.Size(61, 65)
        Me.cmdFindInDB.TabIndex = 3
        Me.cmdFindInDB.TabStop = False
        Me.cmdFindInDB.Text = "Find"
        Me.cmdFindInDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFindInDB.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.PB)
        Me.Panel2.Controls.Add(Me.btnFocus)
        Me.Panel2.Controls.Add(Me.lblFileName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 712)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 21)
        Me.Panel2.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Location = New System.Drawing.Point(112, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(158, 21)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Ready"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PB.Location = New System.Drawing.Point(0, 0)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(112, 21)
        Me.PB.TabIndex = 2
        '
        'btnFocus
        '
        Me.btnFocus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFocus.Location = New System.Drawing.Point(1258, 0)
        Me.btnFocus.Name = "btnFocus"
        Me.btnFocus.Size = New System.Drawing.Size(22, 21)
        Me.btnFocus.TabIndex = 1
        Me.btnFocus.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(276, 4)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(22, 13)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "C:\"
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.LV)
        Me.pnlLeft.Controls.Add(Me.cmdPL_UP)
        Me.pnlLeft.Controls.Add(Me.gbPlayList)
        Me.pnlLeft.Controls.Add(Me.cmdPL_Down)
        Me.pnlLeft.Controls.Add(Me.Button1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 65)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(112, 647)
        Me.pnlLeft.TabIndex = 2
        Me.pnlLeft.Visible = False
        '
        'LV
        '
        Me.LV.AutoArrange = False
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LV.ContextMenuStrip = Me.CTX
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(0, 123)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(112, 430)
        Me.LV.TabIndex = 3
        Me.LV.TabStop = False
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Song"
        Me.ColumnHeader1.Width = 154
        '
        'CTX
        '
        Me.CTX.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.mnuLoadPlaylist})
        Me.CTX.Name = "CTX"
        Me.CTX.Size = New System.Drawing.Size(161, 64)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(160, 30)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'mnuLoadPlaylist
        '
        Me.mnuLoadPlaylist.Name = "mnuLoadPlaylist"
        Me.mnuLoadPlaylist.Size = New System.Drawing.Size(160, 30)
        Me.mnuLoadPlaylist.Text = "Load"
        '
        'cmdPL_UP
        '
        Me.cmdPL_UP.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPL_UP.Image = CType(resources.GetObject("cmdPL_UP.Image"), System.Drawing.Image)
        Me.cmdPL_UP.Location = New System.Drawing.Point(0, 76)
        Me.cmdPL_UP.Name = "cmdPL_UP"
        Me.cmdPL_UP.Size = New System.Drawing.Size(112, 47)
        Me.cmdPL_UP.TabIndex = 1
        Me.cmdPL_UP.TabStop = False
        Me.cmdPL_UP.UseVisualStyleBackColor = True
        '
        'gbPlayList
        '
        Me.gbPlayList.Controls.Add(Me.cmbPlayList)
        Me.gbPlayList.Controls.Add(Me.pnlPL_Load)
        Me.gbPlayList.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbPlayList.Location = New System.Drawing.Point(0, 0)
        Me.gbPlayList.Name = "gbPlayList"
        Me.gbPlayList.Size = New System.Drawing.Size(112, 76)
        Me.gbPlayList.TabIndex = 5
        Me.gbPlayList.TabStop = False
        Me.gbPlayList.Text = "PlayList"
        '
        'cmbPlayList
        '
        Me.cmbPlayList.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbPlayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayList.FormattingEnabled = True
        Me.cmbPlayList.Location = New System.Drawing.Point(3, 47)
        Me.cmbPlayList.Name = "cmbPlayList"
        Me.cmbPlayList.Size = New System.Drawing.Size(106, 21)
        Me.cmbPlayList.TabIndex = 1
        '
        'pnlPL_Load
        '
        Me.pnlPL_Load.Controls.Add(Me.cmdDropdownPLMenu)
        Me.pnlPL_Load.Controls.Add(Me.cmdPL_Clear)
        Me.pnlPL_Load.Controls.Add(Me.cmdPL_Load)
        Me.pnlPL_Load.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPL_Load.Location = New System.Drawing.Point(3, 16)
        Me.pnlPL_Load.Name = "pnlPL_Load"
        Me.pnlPL_Load.Size = New System.Drawing.Size(106, 31)
        Me.pnlPL_Load.TabIndex = 0
        '
        'cmdDropdownPLMenu
        '
        Me.cmdDropdownPLMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdDropdownPLMenu.Image = CType(resources.GetObject("cmdDropdownPLMenu.Image"), System.Drawing.Image)
        Me.cmdDropdownPLMenu.Location = New System.Drawing.Point(72, 0)
        Me.cmdDropdownPLMenu.Name = "cmdDropdownPLMenu"
        Me.cmdDropdownPLMenu.Size = New System.Drawing.Size(32, 31)
        Me.cmdDropdownPLMenu.TabIndex = 2
        Me.cmdDropdownPLMenu.UseVisualStyleBackColor = True
        '
        'cmdPL_Clear
        '
        Me.cmdPL_Clear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPL_Clear.Image = CType(resources.GetObject("cmdPL_Clear.Image"), System.Drawing.Image)
        Me.cmdPL_Clear.Location = New System.Drawing.Point(40, 0)
        Me.cmdPL_Clear.Name = "cmdPL_Clear"
        Me.cmdPL_Clear.Size = New System.Drawing.Size(32, 31)
        Me.cmdPL_Clear.TabIndex = 1
        Me.cmdPL_Clear.UseVisualStyleBackColor = True
        '
        'cmdPL_Load
        '
        Me.cmdPL_Load.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdPL_Load.Image = CType(resources.GetObject("cmdPL_Load.Image"), System.Drawing.Image)
        Me.cmdPL_Load.Location = New System.Drawing.Point(0, 0)
        Me.cmdPL_Load.Name = "cmdPL_Load"
        Me.cmdPL_Load.Size = New System.Drawing.Size(40, 31)
        Me.cmdPL_Load.TabIndex = 0
        Me.cmdPL_Load.UseVisualStyleBackColor = True
        '
        'cmdPL_Down
        '
        Me.cmdPL_Down.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdPL_Down.Image = CType(resources.GetObject("cmdPL_Down.Image"), System.Drawing.Image)
        Me.cmdPL_Down.Location = New System.Drawing.Point(0, 553)
        Me.cmdPL_Down.Name = "cmdPL_Down"
        Me.cmdPL_Down.Size = New System.Drawing.Size(112, 47)
        Me.cmdPL_Down.TabIndex = 2
        Me.cmdPL_Down.TabStop = False
        Me.cmdPL_Down.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1167, 65)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(113, 647)
        Me.pnlRight.TabIndex = 3
        Me.pnlRight.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.SC)
        Me.Panel5.Controls.Add(Me.pnlTitle)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(112, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1055, 647)
        Me.Panel5.TabIndex = 4
        '
        'SC
        '
        Me.SC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC.Location = New System.Drawing.Point(0, 47)
        Me.SC.Name = "SC"
        Me.SC.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC.Panel1
        '
        Me.SC.Panel1.Controls.Add(Me.VS_Top)
        Me.SC.Panel1.Controls.Add(Me.picChart)
        '
        'SC.Panel2
        '
        Me.SC.Panel2.Controls.Add(Me.VS)
        Me.SC.Panel2.Controls.Add(Me.pic)
        Me.SC.Size = New System.Drawing.Size(1055, 600)
        Me.SC.SplitterDistance = 118
        Me.SC.SplitterWidth = 12
        Me.SC.TabIndex = 0
        '
        'VS_Top
        '
        Me.VS_Top.Dock = System.Windows.Forms.DockStyle.Right
        Me.VS_Top.Location = New System.Drawing.Point(982, 0)
        Me.VS_Top.Name = "VS_Top"
        Me.VS_Top.Size = New System.Drawing.Size(73, 118)
        Me.VS_Top.TabIndex = 2
        '
        'picChart
        '
        Me.picChart.Location = New System.Drawing.Point(0, 0)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(133, 75)
        Me.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChart.TabIndex = 3
        Me.picChart.TabStop = False
        '
        'VS
        '
        Me.VS.Dock = System.Windows.Forms.DockStyle.Right
        Me.VS.Location = New System.Drawing.Point(982, 0)
        Me.VS.Name = "VS"
        Me.VS.Size = New System.Drawing.Size(73, 470)
        Me.VS.TabIndex = 1
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(3, 3)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(100, 100)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.gbSong_tempo)
        Me.pnlTitle.Controls.Add(Me.gbSong_artist)
        Me.pnlTitle.Controls.Add(Me.gbSong_patch)
        Me.pnlTitle.Controls.Add(Me.gbKey)
        Me.pnlTitle.Controls.Add(Me.gbTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1055, 47)
        Me.pnlTitle.TabIndex = 1
        '
        'gbSong_tempo
        '
        Me.gbSong_tempo.Controls.Add(Me.lblSong_Tempo)
        Me.gbSong_tempo.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbSong_tempo.Location = New System.Drawing.Point(686, 0)
        Me.gbSong_tempo.Name = "gbSong_tempo"
        Me.gbSong_tempo.Size = New System.Drawing.Size(99, 47)
        Me.gbSong_tempo.TabIndex = 4
        Me.gbSong_tempo.TabStop = False
        Me.gbSong_tempo.Text = "Tempo"
        '
        'lblSong_Tempo
        '
        Me.lblSong_Tempo.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblSong_Tempo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSong_Tempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong_Tempo.Location = New System.Drawing.Point(3, 16)
        Me.lblSong_Tempo.Name = "lblSong_Tempo"
        Me.lblSong_Tempo.Size = New System.Drawing.Size(93, 28)
        Me.lblSong_Tempo.TabIndex = 0
        Me.lblSong_Tempo.Text = "Tempo"
        Me.lblSong_Tempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbSong_artist
        '
        Me.gbSong_artist.Controls.Add(Me.lblSong_artist)
        Me.gbSong_artist.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbSong_artist.Location = New System.Drawing.Point(478, 0)
        Me.gbSong_artist.Name = "gbSong_artist"
        Me.gbSong_artist.Size = New System.Drawing.Size(208, 47)
        Me.gbSong_artist.TabIndex = 3
        Me.gbSong_artist.TabStop = False
        Me.gbSong_artist.Text = "Artist"
        '
        'lblSong_artist
        '
        Me.lblSong_artist.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblSong_artist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSong_artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong_artist.Location = New System.Drawing.Point(3, 16)
        Me.lblSong_artist.Name = "lblSong_artist"
        Me.lblSong_artist.Size = New System.Drawing.Size(202, 28)
        Me.lblSong_artist.TabIndex = 0
        Me.lblSong_artist.Text = "Artist"
        Me.lblSong_artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbSong_patch
        '
        Me.gbSong_patch.Controls.Add(Me.lblSong_Patch)
        Me.gbSong_patch.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbSong_patch.Location = New System.Drawing.Point(333, 0)
        Me.gbSong_patch.Name = "gbSong_patch"
        Me.gbSong_patch.Size = New System.Drawing.Size(145, 47)
        Me.gbSong_patch.TabIndex = 2
        Me.gbSong_patch.TabStop = False
        Me.gbSong_patch.Text = "Patch"
        '
        'lblSong_Patch
        '
        Me.lblSong_Patch.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblSong_Patch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSong_Patch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong_Patch.Location = New System.Drawing.Point(3, 16)
        Me.lblSong_Patch.Name = "lblSong_Patch"
        Me.lblSong_Patch.Size = New System.Drawing.Size(139, 28)
        Me.lblSong_Patch.TabIndex = 0
        Me.lblSong_Patch.Text = "Patch"
        Me.lblSong_Patch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbKey
        '
        Me.gbKey.Controls.Add(Me.lblSong_Key)
        Me.gbKey.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbKey.Location = New System.Drawing.Point(271, 0)
        Me.gbKey.Name = "gbKey"
        Me.gbKey.Size = New System.Drawing.Size(62, 47)
        Me.gbKey.TabIndex = 1
        Me.gbKey.TabStop = False
        Me.gbKey.Text = "KEY"
        '
        'lblSong_Key
        '
        Me.lblSong_Key.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblSong_Key.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSong_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong_Key.Location = New System.Drawing.Point(3, 16)
        Me.lblSong_Key.Name = "lblSong_Key"
        Me.lblSong_Key.Size = New System.Drawing.Size(56, 28)
        Me.lblSong_Key.TabIndex = 0
        Me.lblSong_Key.Text = "Key"
        Me.lblSong_Key.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbTitle
        '
        Me.gbTitle.Controls.Add(Me.lblSong_title)
        Me.gbTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbTitle.Location = New System.Drawing.Point(0, 0)
        Me.gbTitle.Name = "gbTitle"
        Me.gbTitle.Size = New System.Drawing.Size(271, 47)
        Me.gbTitle.TabIndex = 0
        Me.gbTitle.TabStop = False
        Me.gbTitle.Text = "Song"
        '
        'lblSong_title
        '
        Me.lblSong_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblSong_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSong_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSong_title.Location = New System.Drawing.Point(3, 16)
        Me.lblSong_title.Name = "lblSong_title"
        Me.lblSong_title.Size = New System.Drawing.Size(265, 28)
        Me.lblSong_title.TabIndex = 0
        Me.lblSong_title.Text = "Song Title"
        Me.lblSong_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CD
        '
        Me.CD.FileName = "Load Song"
        Me.CD.Multiselect = True
        '
        'TMR
        '
        Me.TMR.Enabled = True
        Me.TMR.Interval = 3000
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1036, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 65)
        Me.Button2.TabIndex = 10
        Me.Button2.TabStop = False
        Me.Button2.Text = "Manual"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 733)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmPlayer"
        Me.Text = "Fake Base 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlSS.ResumeLayout(False)
        CType(Me.picSS_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSS_Mode.ResumeLayout(False)
        Me.gbSS_Mode.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.CTX.ResumeLayout(False)
        Me.gbPlayList.ResumeLayout(False)
        Me.pnlPL_Load.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.SC.Panel1.ResumeLayout(False)
        Me.SC.Panel1.PerformLayout()
        Me.SC.Panel2.ResumeLayout(False)
        Me.SC.Panel2.PerformLayout()
        CType(Me.SC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SC.ResumeLayout(False)
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.gbSong_tempo.ResumeLayout(False)
        Me.gbSong_artist.ResumeLayout(False)
        Me.gbSong_patch.ResumeLayout(False)
        Me.gbKey.ResumeLayout(False)
        Me.gbTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SC As SplitContainer
    Friend WithEvents pic As PictureBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents CD As OpenFileDialog
    Friend WithEvents cmdTest As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdFindInDB As Button
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents gbSong_artist As GroupBox
    Friend WithEvents lblSong_artist As Label
    Friend WithEvents gbSong_patch As GroupBox
    Friend WithEvents lblSong_Patch As Label
    Friend WithEvents gbKey As GroupBox
    Friend WithEvents lblSong_Key As Label
    Friend WithEvents gbTitle As GroupBox
    Friend WithEvents lblSong_title As Label
    Friend WithEvents gbSong_tempo As GroupBox
    Friend WithEvents lblSong_Tempo As Label
    Friend WithEvents picChart As PictureBox
    Friend WithEvents VS_Top As VScrollBar
    Friend WithEvents VS As VScrollBar
    Friend WithEvents cmdEdit As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents cmdSys As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlSEP1 As Panel
    Friend WithEvents cmdPrint As Button
    Friend WithEvents LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cmdPL_Down As Button
    Friend WithEvents cmdPL_UP As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFocus As Button
    Friend WithEvents TMR As Timer
    Friend WithEvents pnlSS As Panel
    Friend WithEvents picSS_View As PictureBox
    Friend WithEvents gbSS_Mode As GroupBox
    Friend WithEvents rbSS_Slideshow_Mode As RadioButton
    Friend WithEvents rbS2_Lyrics As RadioButton
    Friend WithEvents cmdRemoteScreen As Button
    Friend WithEvents gbPlayList As GroupBox
    Friend WithEvents cmbPlayList As ComboBox
    Friend WithEvents pnlPL_Load As Panel
    Friend WithEvents cmdPL_Clear As Button
    Friend WithEvents cmdPL_Load As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents PB As ProgressBar
    Friend WithEvents cmdDropdownPLMenu As Button
    Friend WithEvents CTX As ContextMenuStrip
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SD As SaveFileDialog
    Friend WithEvents mnuLoadPlaylist As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
