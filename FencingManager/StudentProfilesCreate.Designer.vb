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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSave.Location = New System.Drawing.Point(358, 413)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 42)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(505, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 42)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(556, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'StudentProfilesCreate
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(645, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
