<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfilesCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfilesCreate))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.cbbWeapon = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.errFirstName = New System.Windows.Forms.PictureBox()
        Me.errSurname = New System.Windows.Forms.PictureBox()
        Me.errStudentID = New System.Windows.Forms.PictureBox()
        Me.errEmail = New System.Windows.Forms.PictureBox()
        Me.errPhone = New System.Windows.Forms.PictureBox()
        Me.errorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errSurname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStudentID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Student ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Weapon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Phone No."
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(241, 38)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(291, 32)
        Me.txtFirstName.TabIndex = 9
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(241, 88)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(291, 32)
        Me.txtSurname.TabIndex = 10
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(241, 138)
        Me.txtID.MaxLength = 9
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(291, 32)
        Me.txtID.TabIndex = 11
        '
        'cbbYear
        '
        Me.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbYear.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cbbYear.Location = New System.Drawing.Point(241, 188)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(76, 33)
        Me.cbbYear.TabIndex = 12
        '
        'cbbWeapon
        '
        Me.cbbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbWeapon.FormattingEnabled = True
        Me.cbbWeapon.Items.AddRange(New Object() {"Foil", "Sabre", "Epee"})
        Me.cbbWeapon.Location = New System.Drawing.Point(241, 238)
        Me.cbbWeapon.Name = "cbbWeapon"
        Me.cbbWeapon.Size = New System.Drawing.Size(172, 33)
        Me.cbbWeapon.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(241, 288)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(291, 32)
        Me.txtEmail.TabIndex = 14
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(241, 338)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(291, 32)
        Me.txtPhone.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(358, 413)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 42)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(505, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 42)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'errFirstName
        '
        Me.errFirstName.Image = CType(resources.GetObject("errFirstName.Image"), System.Drawing.Image)
        Me.errFirstName.Location = New System.Drawing.Point(560, 35)
        Me.errFirstName.Name = "errFirstName"
        Me.errFirstName.Size = New System.Drawing.Size(32, 32)
        Me.errFirstName.TabIndex = 18
        Me.errFirstName.TabStop = False
        Me.errorToolTip.SetToolTip(Me.errFirstName, "Please enter the student's name")
        Me.errFirstName.Visible = False
        '
        'errSurname
        '
        Me.errSurname.Image = CType(resources.GetObject("errSurname.Image"), System.Drawing.Image)
        Me.errSurname.Location = New System.Drawing.Point(560, 88)
        Me.errSurname.Name = "errSurname"
        Me.errSurname.Size = New System.Drawing.Size(32, 32)
        Me.errSurname.TabIndex = 19
        Me.errSurname.TabStop = False
        Me.errorToolTip.SetToolTip(Me.errSurname, "Please enter the student's surname")
        Me.errSurname.Visible = False
        '
        'errStudentID
        '
        Me.errStudentID.Image = CType(resources.GetObject("errStudentID.Image"), System.Drawing.Image)
        Me.errStudentID.Location = New System.Drawing.Point(560, 138)
        Me.errStudentID.Name = "errStudentID"
        Me.errStudentID.Size = New System.Drawing.Size(32, 32)
        Me.errStudentID.TabIndex = 20
        Me.errStudentID.TabStop = False
        Me.errorToolTip.SetToolTip(Me.errStudentID, "Please enter a valid student number")
        Me.errStudentID.Visible = False
        '
        'errEmail
        '
        Me.errEmail.Image = CType(resources.GetObject("errEmail.Image"), System.Drawing.Image)
        Me.errEmail.Location = New System.Drawing.Point(560, 288)
        Me.errEmail.Name = "errEmail"
        Me.errEmail.Size = New System.Drawing.Size(32, 32)
        Me.errEmail.TabIndex = 21
        Me.errEmail.TabStop = False
        Me.errorToolTip.SetToolTip(Me.errEmail, "Email address is invalid")
        Me.errEmail.Visible = False
        '
        'errPhone
        '
        Me.errPhone.Image = CType(resources.GetObject("errPhone.Image"), System.Drawing.Image)
        Me.errPhone.Location = New System.Drawing.Point(560, 338)
        Me.errPhone.Name = "errPhone"
        Me.errPhone.Size = New System.Drawing.Size(32, 32)
        Me.errPhone.TabIndex = 22
        Me.errPhone.TabStop = False
        Me.errorToolTip.SetToolTip(Me.errPhone, "Please enter the student's phone number")
        Me.errPhone.Visible = False
        '
        'errorToolTip
        '
        Me.errorToolTip.AutoPopDelay = 5000
        Me.errorToolTip.InitialDelay = 200
        Me.errorToolTip.IsBalloon = True
        Me.errorToolTip.ReshowDelay = 100
        Me.errorToolTip.ShowAlways = True
        '
        'StudentProfilesCreate
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(641, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.errPhone)
        Me.Controls.Add(Me.errEmail)
        Me.Controls.Add(Me.errStudentID)
        Me.Controls.Add(Me.errSurname)
        Me.Controls.Add(Me.errFirstName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cbbWeapon)
        Me.Controls.Add(Me.cbbYear)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentProfilesCreate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Profile"
        CType(Me.errFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errSurname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStudentID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbbWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents errFirstName As System.Windows.Forms.PictureBox
    Friend WithEvents errSurname As System.Windows.Forms.PictureBox
    Friend WithEvents errStudentID As System.Windows.Forms.PictureBox
    Friend WithEvents errEmail As System.Windows.Forms.PictureBox
    Friend WithEvents errPhone As System.Windows.Forms.PictureBox
    Friend WithEvents errorToolTip As System.Windows.Forms.ToolTip
End Class
