<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChords))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBeats = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChord = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlChord = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdClearChord = New System.Windows.Forms.Button()
        Me.cmdA = New System.Windows.Forms.Button()
        Me.cmdB = New System.Windows.Forms.Button()
        Me.cmdD = New System.Windows.Forms.Button()
        Me.cmdC = New System.Windows.Forms.Button()
        Me.cmdF = New System.Windows.Forms.Button()
        Me.cmdE = New System.Windows.Forms.Button()
        Me.cmd7Chord = New System.Windows.Forms.Button()
        Me.cmdG = New System.Windows.Forms.Button()
        Me.cmd9Chord = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdSharp = New System.Windows.Forms.Button()
        Me.cmdFlat = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmdHit = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmdRest = New System.Windows.Forms.Button()
        Me.cmd12 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd16 = New System.Windows.Forms.Button()
        Me.cmdClearBeats = New System.Windows.Forms.Button()
        Me.cmdTap = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlChord.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 528)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 50)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdDone)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(468, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 50)
        Me.Panel2.TabIndex = 0
        '
        'cmdDone
        '
        Me.cmdDone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDone.Location = New System.Drawing.Point(0, 0)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(138, 50)
        Me.cmdDone.TabIndex = 0
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.GroupBox2)
        Me.pnlTop.Controls.Add(Me.cmdAdd)
        Me.pnlTop.Controls.Add(Me.GroupBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(606, 60)
        Me.pnlTop.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBeats)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(136, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 60)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "# of Beats"
        '
        'txtBeats
        '
        Me.txtBeats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeats.Location = New System.Drawing.Point(3, 16)
        Me.txtBeats.Name = "txtBeats"
        Me.txtBeats.Size = New System.Drawing.Size(101, 31)
        Me.txtBeats.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(104, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 41)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(519, 0)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(87, 60)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtChord)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chord"
        '
        'txtChord
        '
        Me.txtChord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChord.Location = New System.Drawing.Point(3, 16)
        Me.txtChord.Name = "txtChord"
        Me.txtChord.Size = New System.Drawing.Size(101, 31)
        Me.txtChord.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(104, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.Location = New System.Drawing.Point(272, 60)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(334, 468)
        Me.LV.TabIndex = 2
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Chord"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "# Beats"
        Me.ColumnHeader2.Width = 159
        '
        'pnlChord
        '
        Me.pnlChord.Controls.Add(Me.cmdSharp)
        Me.pnlChord.Controls.Add(Me.cmdFlat)
        Me.pnlChord.Controls.Add(Me.cmd9Chord)
        Me.pnlChord.Controls.Add(Me.cmdMin)
        Me.pnlChord.Controls.Add(Me.cmd7Chord)
        Me.pnlChord.Controls.Add(Me.cmdG)
        Me.pnlChord.Controls.Add(Me.cmdF)
        Me.pnlChord.Controls.Add(Me.cmdE)
        Me.pnlChord.Controls.Add(Me.cmdD)
        Me.pnlChord.Controls.Add(Me.cmdC)
        Me.pnlChord.Controls.Add(Me.cmdB)
        Me.pnlChord.Controls.Add(Me.cmdA)
        Me.pnlChord.Controls.Add(Me.cmdClearChord)
        Me.pnlChord.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlChord.Location = New System.Drawing.Point(0, 60)
        Me.pnlChord.Name = "pnlChord"
        Me.pnlChord.Size = New System.Drawing.Size(136, 468)
        Me.pnlChord.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.cmdTap)
        Me.Panel3.Controls.Add(Me.cmdClearBeats)
        Me.Panel3.Controls.Add(Me.cmd3)
        Me.Panel3.Controls.Add(Me.cmd16)
        Me.Panel3.Controls.Add(Me.cmdRest)
        Me.Panel3.Controls.Add(Me.cmd12)
        Me.Panel3.Controls.Add(Me.cmdHit)
        Me.Panel3.Controls.Add(Me.cmd1)
        Me.Panel3.Controls.Add(Me.cmd6)
        Me.Panel3.Controls.Add(Me.cmd2)
        Me.Panel3.Controls.Add(Me.cmd8)
        Me.Panel3.Controls.Add(Me.cmd4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(136, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(136, 468)
        Me.Panel3.TabIndex = 4
        '
        'cmdClearChord
        '
        Me.cmdClearChord.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdClearChord.Location = New System.Drawing.Point(0, 417)
        Me.cmdClearChord.Name = "cmdClearChord"
        Me.cmdClearChord.Size = New System.Drawing.Size(136, 51)
        Me.cmdClearChord.TabIndex = 0
        Me.cmdClearChord.Text = "CLEAR"
        Me.cmdClearChord.UseVisualStyleBackColor = True
        '
        'cmdA
        '
        Me.cmdA.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdA.Location = New System.Drawing.Point(3, 6)
        Me.cmdA.Name = "cmdA"
        Me.cmdA.Size = New System.Drawing.Size(63, 62)
        Me.cmdA.TabIndex = 1
        Me.cmdA.Text = "A"
        Me.cmdA.UseVisualStyleBackColor = True
        '
        'cmdB
        '
        Me.cmdB.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdB.Location = New System.Drawing.Point(67, 6)
        Me.cmdB.Name = "cmdB"
        Me.cmdB.Size = New System.Drawing.Size(63, 62)
        Me.cmdB.TabIndex = 2
        Me.cmdB.Text = "B"
        Me.cmdB.UseVisualStyleBackColor = True
        '
        'cmdD
        '
        Me.cmdD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD.Location = New System.Drawing.Point(67, 74)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(63, 62)
        Me.cmdD.TabIndex = 4
        Me.cmdD.Text = "D"
        Me.cmdD.UseVisualStyleBackColor = True
        '
        'cmdC
        '
        Me.cmdC.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdC.Location = New System.Drawing.Point(3, 74)
        Me.cmdC.Name = "cmdC"
        Me.cmdC.Size = New System.Drawing.Size(63, 62)
        Me.cmdC.TabIndex = 3
        Me.cmdC.Text = "C"
        Me.cmdC.UseVisualStyleBackColor = True
        '
        'cmdF
        '
        Me.cmdF.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdF.Location = New System.Drawing.Point(67, 142)
        Me.cmdF.Name = "cmdF"
        Me.cmdF.Size = New System.Drawing.Size(63, 62)
        Me.cmdF.TabIndex = 6
        Me.cmdF.Text = "F"
        Me.cmdF.UseVisualStyleBackColor = True
        '
        'cmdE
        '
        Me.cmdE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdE.Location = New System.Drawing.Point(3, 142)
        Me.cmdE.Name = "cmdE"
        Me.cmdE.Size = New System.Drawing.Size(63, 62)
        Me.cmdE.TabIndex = 5
        Me.cmdE.Text = "E"
        Me.cmdE.UseVisualStyleBackColor = True
        '
        'cmd7Chord
        '
        Me.cmd7Chord.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7Chord.Location = New System.Drawing.Point(67, 210)
        Me.cmd7Chord.Name = "cmd7Chord"
        Me.cmd7Chord.Size = New System.Drawing.Size(63, 62)
        Me.cmd7Chord.TabIndex = 8
        Me.cmd7Chord.Text = "7"
        Me.cmd7Chord.UseVisualStyleBackColor = True
        '
        'cmdG
        '
        Me.cmdG.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdG.Location = New System.Drawing.Point(3, 210)
        Me.cmdG.Name = "cmdG"
        Me.cmdG.Size = New System.Drawing.Size(63, 62)
        Me.cmdG.TabIndex = 7
        Me.cmdG.Text = "G"
        Me.cmdG.UseVisualStyleBackColor = True
        '
        'cmd9Chord
        '
        Me.cmd9Chord.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9Chord.Location = New System.Drawing.Point(67, 278)
        Me.cmd9Chord.Name = "cmd9Chord"
        Me.cmd9Chord.Size = New System.Drawing.Size(63, 62)
        Me.cmd9Chord.TabIndex = 10
        Me.cmd9Chord.Text = "9"
        Me.cmd9Chord.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.Location = New System.Drawing.Point(3, 278)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(63, 62)
        Me.cmdMin.TabIndex = 9
        Me.cmdMin.Text = "min"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdSharp
        '
        Me.cmdSharp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSharp.Location = New System.Drawing.Point(67, 346)
        Me.cmdSharp.Name = "cmdSharp"
        Me.cmdSharp.Size = New System.Drawing.Size(63, 62)
        Me.cmdSharp.TabIndex = 12
        Me.cmdSharp.Text = "#"
        Me.cmdSharp.UseVisualStyleBackColor = True
        '
        'cmdFlat
        '
        Me.cmdFlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFlat.Location = New System.Drawing.Point(3, 346)
        Me.cmdFlat.Name = "cmdFlat"
        Me.cmdFlat.Size = New System.Drawing.Size(63, 62)
        Me.cmdFlat.TabIndex = 11
        Me.cmdFlat.Text = "b"
        Me.cmdFlat.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8.Location = New System.Drawing.Point(67, 6)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(63, 62)
        Me.cmd8.TabIndex = 4
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(3, 6)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(63, 62)
        Me.cmd4.TabIndex = 3
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(67, 74)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(63, 62)
        Me.cmd6.TabIndex = 6
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(3, 74)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(63, 62)
        Me.cmd2.TabIndex = 5
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmdHit
        '
        Me.cmdHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHit.Location = New System.Drawing.Point(67, 278)
        Me.cmdHit.Name = "cmdHit"
        Me.cmdHit.Size = New System.Drawing.Size(63, 62)
        Me.cmdHit.TabIndex = 8
        Me.cmdHit.Text = "hit"
        Me.cmdHit.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(3, 142)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(63, 62)
        Me.cmd1.TabIndex = 7
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmdRest
        '
        Me.cmdRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRest.Location = New System.Drawing.Point(3, 346)
        Me.cmdRest.Name = "cmdRest"
        Me.cmdRest.Size = New System.Drawing.Size(63, 62)
        Me.cmdRest.TabIndex = 10
        Me.cmdRest.Text = "rest"
        Me.cmdRest.UseVisualStyleBackColor = True
        '
        'cmd12
        '
        Me.cmd12.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd12.Location = New System.Drawing.Point(3, 208)
        Me.cmd12.Name = "cmd12"
        Me.cmd12.Size = New System.Drawing.Size(63, 62)
        Me.cmd12.TabIndex = 9
        Me.cmd12.Text = "12"
        Me.cmd12.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(67, 142)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(63, 62)
        Me.cmd3.TabIndex = 12
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd16
        '
        Me.cmd16.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd16.Location = New System.Drawing.Point(67, 208)
        Me.cmd16.Name = "cmd16"
        Me.cmd16.Size = New System.Drawing.Size(63, 62)
        Me.cmd16.TabIndex = 11
        Me.cmd16.Text = "16"
        Me.cmd16.UseVisualStyleBackColor = True
        '
        'cmdClearBeats
        '
        Me.cmdClearBeats.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdClearBeats.Location = New System.Drawing.Point(0, 417)
        Me.cmdClearBeats.Name = "cmdClearBeats"
        Me.cmdClearBeats.Size = New System.Drawing.Size(136, 51)
        Me.cmdClearBeats.TabIndex = 13
        Me.cmdClearBeats.Text = "CLEAR"
        Me.cmdClearBeats.UseVisualStyleBackColor = True
        '
        'cmdTap
        '
        Me.cmdTap.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTap.Location = New System.Drawing.Point(3, 278)
        Me.cmdTap.Name = "cmdTap"
        Me.cmdTap.Size = New System.Drawing.Size(63, 62)
        Me.cmdTap.TabIndex = 14
        Me.cmdTap.Text = "tap"
        Me.cmdTap.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(67, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 62)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "/"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmChords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 578)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlChord)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Chords"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlChord.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdDone As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBeats As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtChord As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents pnlChord As Panel
    Friend WithEvents cmdSharp As Button
    Friend WithEvents cmdFlat As Button
    Friend WithEvents cmd9Chord As Button
    Friend WithEvents cmdMin As Button
    Friend WithEvents cmd7Chord As Button
    Friend WithEvents cmdG As Button
    Friend WithEvents cmdF As Button
    Friend WithEvents cmdE As Button
    Friend WithEvents cmdD As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdB As Button
    Friend WithEvents cmdA As Button
    Friend WithEvents cmdClearChord As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdTap As Button
    Friend WithEvents cmdClearBeats As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd16 As Button
    Friend WithEvents cmdRest As Button
    Friend WithEvents cmd12 As Button
    Friend WithEvents cmdHit As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents Button3 As Button
End Class
