<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.labelDvds = New System.Windows.Forms.Label()
        Me.lblBluRays = New System.Windows.Forms.Label()
        Me.lblTotalDiscs = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDvds = New System.Windows.Forms.TextBox()
        Me.txtBluRays = New System.Windows.Forms.TextBox()
        Me.txtTotalDiscs = New System.Windows.Forms.TextBox()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales Receipt"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(61, 97)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Da&te:"
        '
        'labelDvds
        '
        Me.labelDvds.AutoSize = True
        Me.labelDvds.Location = New System.Drawing.Point(61, 122)
        Me.labelDvds.Name = "labelDvds"
        Me.labelDvds.Size = New System.Drawing.Size(38, 13)
        Me.labelDvds.TabIndex = 3
        Me.labelDvds.Text = "&DVDs:"
        '
        'lblBluRays
        '
        Me.lblBluRays.AutoSize = True
        Me.lblBluRays.Location = New System.Drawing.Point(61, 148)
        Me.lblBluRays.Name = "lblBluRays"
        Me.lblBluRays.Size = New System.Drawing.Size(47, 13)
        Me.lblBluRays.TabIndex = 4
        Me.lblBluRays.Text = "&Blu-rays:"
        '
        'lblTotalDiscs
        '
        Me.lblTotalDiscs.AutoSize = True
        Me.lblTotalDiscs.Location = New System.Drawing.Point(61, 181)
        Me.lblTotalDiscs.Name = "lblTotalDiscs"
        Me.lblTotalDiscs.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalDiscs.TabIndex = 5
        Me.lblTotalDiscs.Text = "Total discs:"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(61, 208)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalSales.TabIndex = 6
        Me.lblTotalSales.Text = "Total sales:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(126, 94)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 7
        '
        'txtDvds
        '
        Me.txtDvds.Location = New System.Drawing.Point(126, 119)
        Me.txtDvds.Name = "txtDvds"
        Me.txtDvds.Size = New System.Drawing.Size(100, 20)
        Me.txtDvds.TabIndex = 8
        '
        'txtBluRays
        '
        Me.txtBluRays.Location = New System.Drawing.Point(126, 145)
        Me.txtBluRays.Name = "txtBluRays"
        Me.txtBluRays.Size = New System.Drawing.Size(100, 20)
        Me.txtBluRays.TabIndex = 9
        '
        'txtTotalDiscs
        '
        Me.txtTotalDiscs.Location = New System.Drawing.Point(126, 178)
        Me.txtTotalDiscs.Name = "txtTotalDiscs"
        Me.txtTotalDiscs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDiscs.TabIndex = 10
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(126, 205)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSales.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(343, 94)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(82, 23)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(343, 119)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 23)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "&Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(343, 145)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 171)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 253)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.txtTotalDiscs)
        Me.Controls.Add(Me.txtBluRays)
        Me.Controls.Add(Me.txtDvds)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblTotalDiscs)
        Me.Controls.Add(Me.lblBluRays)
        Me.Controls.Add(Me.labelDvds)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Play It Again Movies"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents labelDvds As Label
    Friend WithEvents lblBluRays As Label
    Friend WithEvents lblTotalDiscs As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtDvds As TextBox
    Friend WithEvents txtBluRays As TextBox
    Friend WithEvents txtTotalDiscs As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
