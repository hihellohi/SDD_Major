<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfileView
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.infoPanel = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.txtWeapon = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.absenceList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkUnexplained = New System.Windows.Forms.CheckBox()
        Me.btnAddReason = New System.Windows.Forms.Button()
        Me.absencesPanel = New System.Windows.Forms.Panel()
        Me.btnCancelReason = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAbsences = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.btnShowStats = New System.Windows.Forms.Button()
        Me.btnShowAbsences = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.lblDeaths = New System.Windows.Forms.Label()
        Me.lblRatio = New System.Windows.Forms.Label()
        Me.statisticsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddScores = New System.Windows.Forms.Button()
        Me.infoPanel.SuspendLayout()
        Me.absencesPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 26)
        Me.Label4.TabIndex = 3
        '
        'infoPanel
        '
        Me.infoPanel.Controls.Add(Me.btnCancel)
        Me.infoPanel.Controls.Add(Me.btnEdit)
        Me.infoPanel.Controls.Add(Me.ComboBox1)
        Me.infoPanel.Controls.Add(Me.Label9)
        Me.infoPanel.Controls.Add(Me.Label8)
        Me.infoPanel.Controls.Add(Me.txtPhoneNum)
        Me.infoPanel.Controls.Add(Me.txtEmail)
        Me.infoPanel.Controls.Add(Me.Label7)
        Me.infoPanel.Controls.Add(Me.Label6)
        Me.infoPanel.Controls.Add(Me.cbbYear)
        Me.infoPanel.Controls.Add(Me.txtWeapon)
        Me.infoPanel.Controls.Add(Me.TextBox4)
        Me.infoPanel.Controls.Add(Me.txtSurname)
        Me.infoPanel.Controls.Add(Me.txtFirstName)
        Me.infoPanel.Controls.Add(Me.txtID)
        Me.infoPanel.Controls.Add(Me.Label1)
        Me.infoPanel.Controls.Add(Me.Label2)
        Me.infoPanel.Controls.Add(Me.Label3)
        Me.infoPanel.Location = New System.Drawing.Point(32, 156)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Size = New System.Drawing.Size(449, 467)
        Me.infoPanel.TabIndex = 4
        Me.infoPanel.TabStop = False
        Me.infoPanel.Text = "Personal Information"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(144, 407)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 42)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(275, 407)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(109, 42)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Foil", "Sabre", "Epee"})
        Me.ComboBox1.Location = New System.Drawing.Point(180, 250)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 33)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 26)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Phone No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 26)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Email"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(180, 350)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(204, 32)
        Me.txtPhoneNum.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 300)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 32)
        Me.txtEmail.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Weapon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Year"
        '
        'cbbYear
        '
        Me.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cbbYear.Location = New System.Drawing.Point(180, 200)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(73, 33)
        Me.cbbYear.TabIndex = 8
        Me.cbbYear.Visible = False
        '
        'txtWeapon
        '
        Me.txtWeapon.Location = New System.Drawing.Point(180, 250)
        Me.txtWeapon.Name = "txtWeapon"
        Me.txtWeapon.Size = New System.Drawing.Size(204, 32)
        Me.txtWeapon.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(180, 200)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(73, 32)
        Me.TextBox4.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(180, 150)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(204, 32)
        Me.txtSurname.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(180, 100)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(204, 32)
        Me.txtFirstName.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(180, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(204, 32)
        Me.txtID.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Absences"
        '
        'absenceList
        '
        Me.absenceList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.absenceList.FullRowSelect = True
        Me.absenceList.HideSelection = False
        Me.absenceList.Location = New System.Drawing.Point(12, 56)
        Me.absenceList.MultiSelect = False
        Me.absenceList.Name = "absenceList"
        Me.absenceList.Size = New System.Drawing.Size(429, 555)
        Me.absenceList.TabIndex = 6
        Me.absenceList.UseCompatibleStateImageBehavior = False
        Me.absenceList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Reason"
        Me.ColumnHeader2.Width = 250
        '
        'chkUnexplained
        '
        Me.chkUnexplained.AutoSize = True
        Me.chkUnexplained.Location = New System.Drawing.Point(458, 82)
        Me.chkUnexplained.Name = "chkUnexplained"
        Me.chkUnexplained.Size = New System.Drawing.Size(264, 30)
        Me.chkUnexplained.TabIndex = 7
        Me.chkUnexplained.Text = "Only Show Unexplained"
        Me.chkUnexplained.UseVisualStyleBackColor = True
        '
        'btnAddReason
        '
        Me.btnAddReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReason.Location = New System.Drawing.Point(458, 376)
        Me.btnAddReason.Name = "btnAddReason"
        Me.btnAddReason.Size = New System.Drawing.Size(264, 32)
        Me.btnAddReason.TabIndex = 17
        Me.btnAddReason.Text = "Enter Reason"
        Me.btnAddReason.UseVisualStyleBackColor = True
        '
        'absencesPanel
        '
        Me.absencesPanel.Controls.Add(Me.btnCancelReason)
        Me.absencesPanel.Controls.Add(Me.btnDone)
        Me.absencesPanel.Controls.Add(Me.Label10)
        Me.absencesPanel.Controls.Add(Me.lblAbsences)
        Me.absencesPanel.Controls.Add(Me.lblAttendance)
        Me.absencesPanel.Controls.Add(Me.absenceList)
        Me.absencesPanel.Controls.Add(Me.btnAddReason)
        Me.absencesPanel.Controls.Add(Me.Label5)
        Me.absencesPanel.Controls.Add(Me.chkUnexplained)
        Me.absencesPanel.Controls.Add(Me.txtReason)
        Me.absencesPanel.Location = New System.Drawing.Point(506, 12)
        Me.absencesPanel.Name = "absencesPanel"
        Me.absencesPanel.Size = New System.Drawing.Size(102, 79)
        Me.absencesPanel.TabIndex = 18
        '
        'btnCancelReason
        '
        Me.btnCancelReason.BackColor = System.Drawing.Color.White
        Me.btnCancelReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelReason.Location = New System.Drawing.Point(636, 414)
        Me.btnCancelReason.Name = "btnCancelReason"
        Me.btnCancelReason.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelReason.TabIndex = 24
        Me.btnCancelReason.UseVisualStyleBackColor = False
        Me.btnCancelReason.Visible = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.White
        Me.btnDone.Enabled = False
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(682, 414)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(40, 40)
        Me.btnDone.TabIndex = 23
        Me.btnDone.UseVisualStyleBackColor = False
        Me.btnDone.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(453, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Unexplained: "
        '
        'lblAbsences
        '
        Me.lblAbsences.AutoSize = True
        Me.lblAbsences.Location = New System.Drawing.Point(453, 197)
        Me.lblAbsences.Name = "lblAbsences"
        Me.lblAbsences.Size = New System.Drawing.Size(120, 26)
        Me.lblAbsences.TabIndex = 19
        Me.lblAbsences.Text = "Absences: "
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.Location = New System.Drawing.Point(453, 144)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(134, 26)
        Me.lblAttendance.TabIndex = 18
        Me.lblAttendance.Text = "Attendance: "
        '
        'txtReason
        '
        Me.txtReason.Enabled = False
        Me.txtReason.Location = New System.Drawing.Point(458, 376)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(264, 32)
        Me.txtReason.TabIndex = 25
        '
        'btnShowStats
        '
        Me.btnShowStats.Location = New System.Drawing.Point(51, 87)
        Me.btnShowStats.Name = "btnShowStats"
        Me.btnShowStats.Size = New System.Drawing.Size(192, 42)
        Me.btnShowStats.TabIndex = 19
        Me.btnShowStats.Text = "Statistics"
        Me.btnShowStats.UseVisualStyleBackColor = True
        '
        'btnShowAbsences
        '
        Me.btnShowAbsences.Location = New System.Drawing.Point(270, 87)
        Me.btnShowAbsences.Name = "btnShowAbsences"
        Me.btnShowAbsences.Size = New System.Drawing.Size(192, 42)
        Me.btnShowAbsences.TabIndex = 20
        Me.btnShowAbsences.Text = "Absences"
        Me.btnShowAbsences.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddScores)
        Me.Panel1.Controls.Add(Me.statisticsList)
        Me.Panel1.Controls.Add(Me.lblRatio)
        Me.Panel1.Controls.Add(Me.lblDeaths)
        Me.Panel1.Controls.Add(Me.lblKills)
        Me.Panel1.Controls.Add(Me.lblWins)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(532, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 634)
        Me.Panel1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(290, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 31)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Statistics"
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(39, 91)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(73, 26)
        Me.lblWins.TabIndex = 22
        Me.lblWins.Text = "Wins: "
        '
        'lblKills
        '
        Me.lblKills.AutoSize = True
        Me.lblKills.Location = New System.Drawing.Point(328, 91)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(53, 26)
        Me.lblKills.TabIndex = 23
        Me.lblKills.Text = "Kills"
        '
        'lblDeaths
        '
        Me.lblDeaths.AutoSize = True
        Me.lblDeaths.Location = New System.Drawing.Point(328, 144)
        Me.lblDeaths.Name = "lblDeaths"
        Me.lblDeaths.Size = New System.Drawing.Size(163, 26)
        Me.lblDeaths.TabIndex = 24
        Me.lblDeaths.Text = "Kill/Death Ratio"
        '
        'lblRatio
        '
        Me.lblRatio.AutoSize = True
        Me.lblRatio.Location = New System.Drawing.Point(39, 144)
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Size = New System.Drawing.Size(81, 26)
        Me.lblRatio.TabIndex = 25
        Me.lblRatio.Text = "Deaths"
        '
        'statisticsList
        '
        Me.statisticsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.statisticsList.FullRowSelect = True
        Me.statisticsList.HideSelection = False
        Me.statisticsList.Location = New System.Drawing.Point(44, 197)
        Me.statisticsList.MultiSelect = False
        Me.statisticsList.Name = "statisticsList"
        Me.statisticsList.Size = New System.Drawing.Size(633, 378)
        Me.statisticsList.TabIndex = 26
        Me.statisticsList.UseCompatibleStateImageBehavior = False
        Me.statisticsList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Opponent"
        Me.ColumnHeader3.Width = 157
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Outcome"
        Me.ColumnHeader4.Width = 111
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Kills"
        Me.ColumnHeader5.Width = 72
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Deaths"
        Me.ColumnHeader6.Width = 94
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Kill/Death Ratio"
        Me.ColumnHeader7.Width = 182
        '
        'btnAddScores
        '
        Me.btnAddScores.Location = New System.Drawing.Point(543, 581)
        Me.btnAddScores.Name = "btnAddScores"
        Me.btnAddScores.Size = New System.Drawing.Size(134, 43)
        Me.btnAddScores.TabIndex = 27
        Me.btnAddScores.Text = "Add Scores"
        Me.btnAddScores.UseVisualStyleBackColor = True
        '
        'StudentProfileView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 658)
        Me.Controls.Add(Me.btnShowAbsences)
        Me.Controls.Add(Me.btnShowStats)
        Me.Controls.Add(Me.absencesPanel)
        Me.Controls.Add(Me.infoPanel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfileView"
        Me.Text = "l"
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        Me.absencesPanel.ResumeLayout(False)
        Me.absencesPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents infoPanel As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtWeapon As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents absenceList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkUnexplained As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddReason As System.Windows.Forms.Button
    Friend WithEvents absencesPanel As System.Windows.Forms.Panel
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelReason As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAbsences As System.Windows.Forms.Label
    Friend WithEvents lblAttendance As System.Windows.Forms.Label
    Friend WithEvents btnShowStats As System.Windows.Forms.Button
    Friend WithEvents btnShowAbsences As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAddScores As System.Windows.Forms.Button
    Friend WithEvents statisticsList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRatio As System.Windows.Forms.Label
    Friend WithEvents lblDeaths As System.Windows.Forms.Label
    Friend WithEvents lblKills As System.Windows.Forms.Label
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
