<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrinter1 = New System.Windows.Forms.Label()
        Me.cmdChangePrinter = New System.Windows.Forms.Button()
        Me.pnlOK = New System.Windows.Forms.Panel()
        Me.cmdSavePDF = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.PD = New System.Windows.Forms.PrintDialog()
        Me.SD = New System.Windows.Forms.SaveFileDialog()
        Me.Print_Preview = New Fake_Base_01WF.udPrint_Preview()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlOK.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Print_Preview)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlOK)
        Me.SplitContainer1.Size = New System.Drawing.Size(1165, 701)
        Me.SplitContainer1.SplitterDistance = 776
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrinter1)
        Me.GroupBox1.Controls.Add(Me.cmdChangePrinter)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer"
        '
        'lblPrinter1
        '
        Me.lblPrinter1.AutoSize = True
        Me.lblPrinter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinter1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPrinter1.Location = New System.Drawing.Point(7, 20)
        Me.lblPrinter1.Name = "lblPrinter1"
        Me.lblPrinter1.Size = New System.Drawing.Size(98, 16)
        Me.lblPrinter1.TabIndex = 1
        Me.lblPrinter1.Text = "Printer Name"
        '
        'cmdChangePrinter
        '
        Me.cmdChangePrinter.Location = New System.Drawing.Point(6, 101)
        Me.cmdChangePrinter.Name = "cmdChangePrinter"
        Me.cmdChangePrinter.Size = New System.Drawing.Size(84, 31)
        Me.cmdChangePrinter.TabIndex = 0
        Me.cmdChangePrinter.Text = "Change"
        Me.cmdChangePrinter.UseVisualStyleBackColor = True
        '
        'pnlOK
        '
        Me.pnlOK.Controls.Add(Me.cmdSavePDF)
        Me.pnlOK.Controls.Add(Me.cmdPrint)
        Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlOK.Location = New System.Drawing.Point(0, 616)
        Me.pnlOK.Name = "pnlOK"
        Me.pnlOK.Size = New System.Drawing.Size(385, 85)
        Me.pnlOK.TabIndex = 0
        '
        'cmdSavePDF
        '
        Me.cmdSavePDF.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdSavePDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSavePDF.Location = New System.Drawing.Point(0, 0)
        Me.cmdSavePDF.Name = "cmdSavePDF"
        Me.cmdSavePDF.Size = New System.Drawing.Size(127, 85)
        Me.cmdSavePDF.TabIndex = 1
        Me.cmdSavePDF.Text = "SAVE PDF"
        Me.cmdSavePDF.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(247, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(138, 85)
        Me.cmdPrint.TabIndex = 0
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'PD
        '
        Me.PD.UseEXDialog = True
        '
        'Print_Preview
        '
        Me.Print_Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Print_Preview.Location = New System.Drawing.Point(0, 0)
        Me.Print_Preview.Name = "Print_Preview"
        Me.Print_Preview.Size = New System.Drawing.Size(776, 701)
        Me.Print_Preview.TabIndex = 0
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 701)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrint"
        Me.Text = "Print Preview"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlOK.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Print_Preview As udPrint_Preview
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrinter1 As Label
    Friend WithEvents cmdChangePrinter As Button
    Friend WithEvents pnlOK As Panel
    Friend WithEvents cmdPrint As Button
    Friend WithEvents PD As PrintDialog
    Friend WithEvents cmdSavePDF As Button
    Friend WithEvents SD As SaveFileDialog
End Class
