<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picMuffin = New System.Windows.Forms.PictureBox()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.picDonut = New System.Windows.Forms.PictureBox()
        Me.grpSales = New System.Windows.Forms.GroupBox()
        Me.txtMuffin = New System.Windows.Forms.TextBox()
        Me.txtDonut = New System.Windows.Forms.TextBox()
        Me.lblMuffin = New System.Windows.Forms.Label()
        Me.lblDonut = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.printMain = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMuffin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDonut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjBakerySolution_Luchavez.My.Resources.Resources.baker
        Me.PictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'picMuffin
        '
        Me.picMuffin.Image = Global.prjBakerySolution_Luchavez.My.Resources.Resources.muffin
        Me.picMuffin.Location = New System.Drawing.Point(270, 34)
        Me.picMuffin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picMuffin.Name = "picMuffin"
        Me.picMuffin.Size = New System.Drawing.Size(117, 123)
        Me.picMuffin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMuffin.TabIndex = 2
        Me.picMuffin.TabStop = False
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Brush Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(198, 104)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(329, 79)
        Me.lblAppName.TabIndex = 11
        Me.lblAppName.Text = "Sales Receipt"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(209, 183)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 17)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date"
        '
        'picDonut
        '
        Me.picDonut.Image = Global.prjBakerySolution_Luchavez.My.Resources.Resources.donut
        Me.picDonut.Location = New System.Drawing.Point(6, 34)
        Me.picDonut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picDonut.Name = "picDonut"
        Me.picDonut.Padding = New System.Windows.Forms.Padding(12, 25, 12, 25)
        Me.picDonut.Size = New System.Drawing.Size(117, 123)
        Me.picDonut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDonut.TabIndex = 1
        Me.picDonut.TabStop = False
        '
        'grpSales
        '
        Me.grpSales.Controls.Add(Me.txtMuffin)
        Me.grpSales.Controls.Add(Me.txtDonut)
        Me.grpSales.Controls.Add(Me.lblMuffin)
        Me.grpSales.Controls.Add(Me.lblDonut)
        Me.grpSales.Controls.Add(Me.picDonut)
        Me.grpSales.Controls.Add(Me.picMuffin)
        Me.grpSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSales.Location = New System.Drawing.Point(14, 229)
        Me.grpSales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSales.Size = New System.Drawing.Size(513, 165)
        Me.grpSales.TabIndex = 2
        Me.grpSales.TabStop = False
        Me.grpSales.Text = "Sales Information"
        '
        'txtMuffin
        '
        Me.txtMuffin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuffin.Location = New System.Drawing.Point(397, 108)
        Me.txtMuffin.Name = "txtMuffin"
        Me.txtMuffin.Size = New System.Drawing.Size(98, 22)
        Me.txtMuffin.TabIndex = 3
        Me.txtMuffin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDonut
        '
        Me.txtDonut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonut.Location = New System.Drawing.Point(134, 108)
        Me.txtDonut.Name = "txtDonut"
        Me.txtDonut.Size = New System.Drawing.Size(100, 22)
        Me.txtDonut.TabIndex = 1
        Me.txtDonut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMuffin
        '
        Me.lblMuffin.AutoSize = True
        Me.lblMuffin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuffin.Location = New System.Drawing.Point(393, 62)
        Me.lblMuffin.Name = "lblMuffin"
        Me.lblMuffin.Size = New System.Drawing.Size(68, 22)
        Me.lblMuffin.TabIndex = 2
        Me.lblMuffin.Text = "Muffin"
        '
        'lblDonut
        '
        Me.lblDonut.AutoSize = True
        Me.lblDonut.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonut.Location = New System.Drawing.Point(132, 62)
        Me.lblDonut.Name = "lblDonut"
        Me.lblDonut.Size = New System.Drawing.Size(102, 22)
        Me.lblDonut.TabIndex = 0
        Me.lblDonut.Text = "Doughnut"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(254, 179)
        Me.DateTimePicker1.MaxDate = New Date(2020, 6, 5, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 22)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2020, 6, 5, 0, 0, 0, 0)
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.Location = New System.Drawing.Point(322, 403)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(78, 17)
        Me.lblTotalItems.TabIndex = 3
        Me.lblTotalItems.Text = "Total Items"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(322, 431)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(79, 17)
        Me.lblTotalSales.TabIndex = 5
        Me.lblTotalSales.Text = "Total Sales"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtTotalItems.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.Location = New System.Drawing.Point(411, 401)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.ReadOnly = True
        Me.txtTotalItems.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalItems.TabIndex = 4
        Me.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtTotalSales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSales.Location = New System.Drawing.Point(411, 429)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.ReadOnly = True
        Me.txtTotalSales.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalSales.TabIndex = 6
        Me.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(399, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 30)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(273, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Goldenrod
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(147, 479)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 30)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(21, 479)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 30)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'printMain
        '
        Me.printMain.DocumentName = "document"
        Me.printMain.Form = Me
        Me.printMain.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.printMain.PrinterSettings = CType(resources.GetObject("printMain.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printMain.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 522)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.txtTotalItems)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.grpSales)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bakery Solutions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMuffin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDonut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picMuffin As PictureBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents picDonut As PictureBox
    Friend WithEvents grpSales As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDonut As TextBox
    Friend WithEvents lblMuffin As Label
    Friend WithEvents lblDonut As Label
    Friend WithEvents txtMuffin As TextBox
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents txtTotalItems As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents printMain As PowerPacks.Printing.PrintForm
End Class
