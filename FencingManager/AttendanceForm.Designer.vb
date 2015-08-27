<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnBarcode = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbAllYears = New System.Windows.Forms.RadioButton()
        Me.rdbJunior = New System.Windows.Forms.RadioButton()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbEpee = New System.Windows.Forms.RadioButton()
        Me.rdbSabre = New System.Windows.Forms.RadioButton()
        Me.rdbFoil = New System.Windows.Forms.RadioButton()
        Me.rdbAllWeapons = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.barcodePanel = New System.Windows.Forms.Panel()
        Me.lblScanMsg = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEnterBarcode = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.roll = New System.Windows.Forms.CheckedListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.panelHelp1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelHelp2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.barcodePanel.SuspendLayout()
        Me.panelHelp1.SuspendLayout()
        Me.panelHelp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 123)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Controls.Add(Me.btnHelp)
        Me.Panel1.Controls.Add(Me.titleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 1
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(65, 37)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(300, 39)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Attendance Check"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 110)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelHelp2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRoll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBarcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelHelp1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.barcodePanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblAbsent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblPresent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.roll)
        Me.SplitContainer1.Panel2.Enabled = False
        Me.SplitContainer1.Size = New System.Drawing.Size(1256, 658)
        Me.SplitContainer1.SplitterDistance = 418
        Me.SplitContainer1.TabIndex = 2
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(53, 592)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(308, 47)
        Me.btnRoll.TabIndex = 5
        Me.btnRoll.Text = "Use Manual Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnBarcode
        '
        Me.btnBarcode.Location = New System.Drawing.Point(53, 533)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(308, 47)
        Me.btnBarcode.TabIndex = 4
        Me.btnBarcode.Text = "Use Barcode Scanner"
        Me.btnBarcode.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbAllYears)
        Me.GroupBox2.Controls.Add(Me.rdbJunior)
        Me.GroupBox2.Controls.Add(Me.rdbSenior)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 148)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mark For Year Group"
        '
        'rdbAllYears
        '
        Me.rdbAllYears.AutoSize = True
        Me.rdbAllYears.Checked = True
        Me.rdbAllYears.Location = New System.Drawing.Point(32, 31)
        Me.rdbAllYears.Name = "rdbAllYears"
        Me.rdbAllYears.Size = New System.Drawing.Size(55, 30)
        Me.rdbAllYears.TabIndex = 3
        Me.rdbAllYears.TabStop = True
        Me.rdbAllYears.Text = "All"
        Me.rdbAllYears.UseVisualStyleBackColor = True
        '
        'rdbJunior
        '
        Me.rdbJunior.AutoSize = True
        Me.rdbJunior.Location = New System.Drawing.Point(32, 67)
        Me.rdbJunior.Name = "rdbJunior"
        Me.rdbJunior.Size = New System.Drawing.Size(89, 30)
        Me.rdbJunior.TabIndex = 2
        Me.rdbJunior.Text = "Junior"
        Me.rdbJunior.UseVisualStyleBackColor = True
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.Location = New System.Drawing.Point(32, 103)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(93, 30)
        Me.rdbSenior.TabIndex = 1
        Me.rdbSenior.Text = "Senior"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbEpee)
        Me.GroupBox1.Controls.Add(Me.rdbSabre)
        Me.GroupBox1.Controls.Add(Me.rdbFoil)
        Me.GroupBox1.Controls.Add(Me.rdbAllWeapons)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mark For Weapon"
        '
        'rdbEpee
        '
        Me.rdbEpee.AutoSize = True
        Me.rdbEpee.Location = New System.Drawing.Point(32, 148)
        Me.rdbEpee.Name = "rdbEpee"
        Me.rdbEpee.Size = New System.Drawing.Size(81, 30)
        Me.rdbEpee.TabIndex = 3
        Me.rdbEpee.Text = "Epee"
        Me.rdbEpee.UseVisualStyleBackColor = True
        '
        'rdbSabre
        '
        Me.rdbSabre.AutoSize = True
        Me.rdbSabre.Location = New System.Drawing.Point(32, 112)
        Me.rdbSabre.Name = "rdbSabre"
        Me.rdbSabre.Size = New System.Drawing.Size(88, 30)
        Me.rdbSabre.TabIndex = 2
        Me.rdbSabre.Text = "Sabre"
        Me.rdbSabre.UseVisualStyleBackColor = True
        '
        'rdbFoil
        '
        Me.rdbFoil.AutoSize = True
        Me.rdbFoil.Location = New System.Drawing.Point(32, 76)
        Me.rdbFoil.Name = "rdbFoil"
        Me.rdbFoil.Size = New System.Drawing.Size(65, 30)
        Me.rdbFoil.TabIndex = 1
        Me.rdbFoil.Text = "Foil"
        Me.rdbFoil.UseVisualStyleBackColor = True
        '
        'rdbAllWeapons
        '
        Me.rdbAllWeapons.AutoSize = True
        Me.rdbAllWeapons.Checked = True
        Me.rdbAllWeapons.Location = New System.Drawing.Point(32, 40)
        Me.rdbAllWeapons.Name = "rdbAllWeapons"
        Me.rdbAllWeapons.Size = New System.Drawing.Size(55, 30)
        Me.rdbAllWeapons.TabIndex = 0
        Me.rdbAllWeapons.TabStop = True
        Me.rdbAllWeapons.Text = "All"
        Me.rdbAllWeapons.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attendance Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(365, 32)
        Me.DateTimePicker1.TabIndex = 0
        '
        'barcodePanel
        '
        Me.barcodePanel.Controls.Add(Me.lblScanMsg)
        Me.barcodePanel.Controls.Add(Me.btnBack)
        Me.barcodePanel.Controls.Add(Me.btnEnterBarcode)
        Me.barcodePanel.Controls.Add(Me.btnNext)
        Me.barcodePanel.Controls.Add(Me.txtBarcode)
        Me.barcodePanel.Controls.Add(Me.Label7)
        Me.barcodePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodePanel.Location = New System.Drawing.Point(0, 0)
        Me.barcodePanel.Name = "barcodePanel"
        Me.barcodePanel.Size = New System.Drawing.Size(834, 658)
        Me.barcodePanel.TabIndex = 10
        Me.barcodePanel.Visible = False
        '
        'lblScanMsg
        '
        Me.lblScanMsg.AutoSize = True
        Me.lblScanMsg.Location = New System.Drawing.Point(337, 247)
        Me.lblScanMsg.Name = "lblScanMsg"
        Me.lblScanMsg.Size = New System.Drawing.Size(192, 26)
        Me.lblScanMsg.TabIndex = 5
        Me.lblScanMsg.Text = "444444444   13:00"
        Me.lblScanMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(577, 592)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(116, 47)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEnterBarcode
        '
        Me.btnEnterBarcode.Location = New System.Drawing.Point(838, 286)
        Me.btnEnterBarcode.Name = "btnEnterBarcode"
        Me.btnEnterBarcode.Size = New System.Drawing.Size(110, 41)
        Me.btnEnterBarcode.TabIndex = 3
        Me.btnEnterBarcode.Text = "Button3"
        Me.btnEnterBarcode.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(712, 592)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(110, 47)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(845, 298)
        Me.txtBarcode.MaxLength = 9
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(115, 32)
        Me.txtBarcode.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(576, 37)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Scan your ID card to record attendance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Attendance Roll"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsent.Location = New System.Drawing.Point(693, 343)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(0, 39)
        Me.lblAbsent.TabIndex = 8
        Me.lblAbsent.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(631, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Students Absent"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresent.Location = New System.Drawing.Point(693, 220)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(0, 39)
        Me.lblPresent.TabIndex = 6
        Me.lblPresent.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(631, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Students Present"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(693, 102)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 39)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(642, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Students"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(647, 604)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 42)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(28, 604)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'roll
        '
        Me.roll.FormattingEnabled = True
        Me.roll.Location = New System.Drawing.Point(19, 49)
        Me.roll.Name = "roll"
        Me.roll.Size = New System.Drawing.Size(597, 544)
        Me.roll.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 2400
        '
        'btnHelp
        '
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(1069, 37)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(48, 48)
        Me.btnHelp.TabIndex = 1
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'panelHelp1
        '
        Me.panelHelp1.Controls.Add(Me.Label9)
        Me.panelHelp1.Controls.Add(Me.Label8)
        Me.panelHelp1.Controls.Add(Me.Label1)
        Me.panelHelp1.Location = New System.Drawing.Point(3, 25)
        Me.panelHelp1.Name = "panelHelp1"
        Me.panelHelp1.Size = New System.Drawing.Size(542, 621)
        Me.panelHelp1.TabIndex = 6
        Me.panelHelp1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select or change the date of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the students' attendance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(309, 78)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Select the students to record " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attendance, by weapon and/or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by year group" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(349, 104)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "<- Record attendance by scanning " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "student ID cards" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<- Record attendance using a" & _
    "n" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "electronic roll"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(320, 546)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tick a student's checkbox to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mark him absent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Untick to mark a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "student presen" & _
    "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click 'Save' when you are done."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelHelp2
        '
        Me.panelHelp2.Controls.Add(Me.Label10)
        Me.panelHelp2.Location = New System.Drawing.Point(3, 18)
        Me.panelHelp2.Name = "panelHelp2"
        Me.panelHelp2.Size = New System.Drawing.Size(402, 621)
        Me.panelHelp2.TabIndex = 6
        Me.panelHelp2.Visible = False
        '
        'AttendanceForm
        '
        Me.AcceptButton = Me.btnEnterBarcode
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AttendanceForm"
        Me.Text = "AttendanceForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.barcodePanel.ResumeLayout(False)
        Me.barcodePanel.PerformLayout()
        Me.panelHelp1.ResumeLayout(False)
        Me.panelHelp1.PerformLayout()
        Me.panelHelp2.ResumeLayout(False)
        Me.panelHelp2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnBarcode As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAllYears As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJunior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEpee As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSabre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFoil As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAllWeapons As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAbsent As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPresent As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents roll As System.Windows.Forms.CheckedListBox
    Friend WithEvents barcodePanel As System.Windows.Forms.Panel
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnEnterBarcode As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblScanMsg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents panelHelp1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelHelp2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
