<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loans
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
        Me.lblInputError = New System.Windows.Forms.Label()
        Me.tableList = New System.Windows.Forms.ListView()
        Me.colItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtFor = New System.Windows.Forms.TextBox()
        Me.cmbFor = New System.Windows.Forms.ComboBox()
        Me.grbInventory = New System.Windows.Forms.GroupBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblTableCount = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBarcode = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUntilError = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.rdbUntil = New System.Windows.Forms.RadioButton()
        Me.rdbFor = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grbInventory.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInputError
        '
        Me.lblInputError.AutoSize = True
        Me.lblInputError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputError.ForeColor = System.Drawing.Color.Red
        Me.lblInputError.Location = New System.Drawing.Point(57, 145)
        Me.lblInputError.Name = "lblInputError"
        Me.lblInputError.Size = New System.Drawing.Size(39, 13)
        Me.lblInputError.TabIndex = 1
        Me.lblInputError.Text = "Label1"
        Me.lblInputError.Visible = False
        '
        'tableList
        '
        Me.tableList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem, Me.colDesc, Me.colDueDate})
        Me.tableList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableList.FullRowSelect = True
        Me.tableList.GridLines = True
        Me.tableList.Location = New System.Drawing.Point(16, 30)
        Me.tableList.Name = "tableList"
        Me.tableList.Size = New System.Drawing.Size(468, 459)
        Me.tableList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.tableList.TabIndex = 2
        Me.tableList.UseCompatibleStateImageBehavior = False
        Me.tableList.View = System.Windows.Forms.View.Details
        '
        'colItem
        '
        Me.colItem.Text = "Loaned Item ID"
        Me.colItem.Width = 143
        '
        'colDesc
        '
        Me.colDesc.Text = "Item Description"
        Me.colDesc.Width = 175
        '
        'colDueDate
        '
        Me.colDueDate.Text = "Due Date"
        Me.colDueDate.Width = 125
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(60, 100)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(327, 31)
        Me.txtInput.TabIndex = 3
        '
        'txtFor
        '
        Me.txtFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFor.Location = New System.Drawing.Point(105, 48)
        Me.txtFor.MaxLength = 3
        Me.txtFor.Name = "txtFor"
        Me.txtFor.Size = New System.Drawing.Size(126, 26)
        Me.txtFor.TabIndex = 4
        '
        'cmbFor
        '
        Me.cmbFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbFor.FormattingEnabled = True
        Me.cmbFor.Items.AddRange(New Object() {"Select Unit of Time", "Days", "Weeks", "Months", "Years"})
        Me.cmbFor.Location = New System.Drawing.Point(242, 48)
        Me.cmbFor.Name = "cmbFor"
        Me.cmbFor.Size = New System.Drawing.Size(156, 26)
        Me.cmbFor.TabIndex = 5
        '
        'grbInventory
        '
        Me.grbInventory.Controls.Add(Me.btnPreview)
        Me.grbInventory.Controls.Add(Me.btnPrint)
        Me.grbInventory.Controls.Add(Me.lblTableCount)
        Me.grbInventory.Controls.Add(Me.btnLogout)
        Me.grbInventory.Controls.Add(Me.tableList)
        Me.grbInventory.Controls.Add(Me.Label6)
        Me.grbInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbInventory.Location = New System.Drawing.Point(644, 35)
        Me.grbInventory.Name = "grbInventory"
        Me.grbInventory.Size = New System.Drawing.Size(505, 568)
        Me.grbInventory.TabIndex = 6
        Me.grbInventory.TabStop = False
        Me.grbInventory.Text = "Logged out"
        '
        'btnPreview
        '
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(376, 522)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(108, 31)
        Me.btnPreview.TabIndex = 18
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        Me.btnPreview.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(262, 522)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 31)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'lblTableCount
        '
        Me.lblTableCount.AutoSize = True
        Me.lblTableCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableCount.Location = New System.Drawing.Point(131, 496)
        Me.lblTableCount.Name = "lblTableCount"
        Me.lblTableCount.Size = New System.Drawing.Size(16, 18)
        Me.lblTableCount.TabIndex = 16
        Me.lblTableCount.Text = "0"
        '
        'btnLogout
        '
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(16, 522)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(108, 31)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        Me.btnLogout.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Items Listed:"
        '
        'btnBarcode
        '
        Me.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcode.Location = New System.Drawing.Point(60, 46)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(327, 31)
        Me.btnBarcode.TabIndex = 15
        Me.btnBarcode.Text = "Use Barcode Scanner"
        Me.btnBarcode.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.Location = New System.Drawing.Point(60, 100)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(327, 31)
        Me.btnManual.TabIndex = 16
        Me.btnManual.Text = "Use Manual Input"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUntilError)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.cmbDay)
        Me.GroupBox2.Controls.Add(Me.rdbUntil)
        Me.GroupBox2.Controls.Add(Me.rdbFor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFor)
        Me.GroupBox2.Controls.Add(Me.cmbFor)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(104, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 269)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loan Duration"
        '
        'lblUntilError
        '
        Me.lblUntilError.AutoSize = True
        Me.lblUntilError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUntilError.ForeColor = System.Drawing.Color.Red
        Me.lblUntilError.Location = New System.Drawing.Point(112, 204)
        Me.lblUntilError.Name = "lblUntilError"
        Me.lblUntilError.Size = New System.Drawing.Size(226, 13)
        Me.lblUntilError.TabIndex = 31
        Me.lblUntilError.Text = "Enter a valid date between 1000 and 9999 CE"
        Me.lblUntilError.Visible = False
        '
        'txtYear
        '
        Me.txtYear.Enabled = False
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(298, 175)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 26)
        Me.txtYear.TabIndex = 30
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Enabled = False
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Month", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cmbMonth.Location = New System.Drawing.Point(193, 175)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(72, 26)
        Me.cmbMonth.TabIndex = 29
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.Enabled = False
        Me.cmbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"Day", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(115, 175)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(56, 26)
        Me.cmbDay.TabIndex = 28
        '
        'rdbUntil
        '
        Me.rdbUntil.AutoSize = True
        Me.rdbUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbUntil.Location = New System.Drawing.Point(18, 177)
        Me.rdbUntil.Name = "rdbUntil"
        Me.rdbUntil.Size = New System.Drawing.Size(89, 22)
        Me.rdbUntil.TabIndex = 8
        Me.rdbUntil.Text = "Loan until"
        Me.rdbUntil.UseVisualStyleBackColor = True
        '
        'rdbFor
        '
        Me.rdbFor.AutoSize = True
        Me.rdbFor.Checked = True
        Me.rdbFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFor.Location = New System.Drawing.Point(18, 50)
        Me.rdbFor.Name = "rdbFor"
        Me.rdbFor.Size = New System.Drawing.Size(81, 22)
        Me.rdbFor.TabIndex = 7
        Me.rdbFor.TabStop = True
        Me.rdbFor.Text = "Loan for"
        Me.rdbFor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(102, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Complete the fields"
        Me.Label3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBarcode)
        Me.GroupBox3.Controls.Add(Me.lblInputError)
        Me.GroupBox3.Controls.Add(Me.btnManual)
        Me.GroupBox3.Controls.Add(Me.txtInput)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(104, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(446, 186)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(99, 35)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(324, 25)
        Me.lblOutput.TabIndex = 19
        Me.lblOutput.Text = "Scan or input student ID to log in"
        '
        'Loans
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1238, 658)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loans"
        Me.Text = "Loans"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbInventory.ResumeLayout(False)
        Me.grbInventory.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInputError As System.Windows.Forms.Label
    Friend WithEvents tableList As System.Windows.Forms.ListView
    Friend WithEvents colItem As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDueDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtFor As System.Windows.Forms.TextBox
    Friend WithEvents cmbFor As System.Windows.Forms.ComboBox
    Friend WithEvents grbInventory As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTableCount As System.Windows.Forms.Label
    Friend WithEvents btnBarcode As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents rdbFor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUntil As System.Windows.Forms.RadioButton
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblUntilError As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
End Class
