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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.absencesPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAbsences = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.infoPanel.SuspendLayout()
        Me.absencesPanel.SuspendLayout()
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
        Me.absenceList.Location = New System.Drawing.Point(12, 56)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(458, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(264, 30)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Only Show Unexplained"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(458, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 32)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Enter Reason"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'absencesPanel
        '
        Me.absencesPanel.Controls.Add(Me.TextBox1)
        Me.absencesPanel.Controls.Add(Me.Button4)
        Me.absencesPanel.Controls.Add(Me.btnDone)
        Me.absencesPanel.Controls.Add(Me.Label10)
        Me.absencesPanel.Controls.Add(Me.lblAbsences)
        Me.absencesPanel.Controls.Add(Me.lblAttendance)
        Me.absencesPanel.Controls.Add(Me.absenceList)
        Me.absencesPanel.Controls.Add(Me.Button1)
        Me.absencesPanel.Controls.Add(Me.Label5)
        Me.absencesPanel.Controls.Add(Me.CheckBox1)
        Me.absencesPanel.Location = New System.Drawing.Point(506, 12)
        Me.absencesPanel.Name = "absencesPanel"
        Me.absencesPanel.Size = New System.Drawing.Size(738, 634)
        Me.absencesPanel.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(458, 414)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 32)
        Me.TextBox1.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(636, 452)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 24
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'btnDone
        '
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(682, 452)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(40, 40)
        Me.btnDone.TabIndex = 23
        Me.btnDone.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 42)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Statistics"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(270, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 42)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Absences"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StudentProfileView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 658)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.absencesPanel)
        Me.Controls.Add(Me.infoPanel)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfileView"
        Me.Text = "l"
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        Me.absencesPanel.ResumeLayout(False)
        Me.absencesPanel.PerformLayout()
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents absencesPanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAbsences As System.Windows.Forms.Label
    Friend WithEvents lblAttendance As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
