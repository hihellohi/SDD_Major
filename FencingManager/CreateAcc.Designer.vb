<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAcc
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
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCPW = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLN
        '
        Me.txtLN.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLN.Location = New System.Drawing.Point(223, 196)
        Me.txtLN.MaxLength = 9
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(202, 35)
        Me.txtLN.TabIndex = 31
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(223, 145)
        Me.txtFN.MaxLength = 9
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(202, 35)
        Me.txtFN.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(443, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Enter a password"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(443, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Passwords don't match"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(443, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Invalid ID Number"
        Me.Label5.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(256, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCPW
        '
        Me.txtCPW.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPW.Location = New System.Drawing.Point(223, 312)
        Me.txtCPW.MaxLength = 32
        Me.txtCPW.Name = "txtCPW"
        Me.txtCPW.Size = New System.Drawing.Size(202, 35)
        Me.txtCPW.TabIndex = 33
        Me.txtCPW.UseSystemPasswordChar = True
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(223, 254)
        Me.txtPW.MaxLength = 32
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(202, 35)
        Me.txtPW.TabIndex = 32
        Me.txtPW.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(223, 90)
        Me.txtUser.MaxLength = 9
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(202, 35)
        Me.txtUser.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Create a new Account"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(545, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 25)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Confirm PW"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 25)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Last Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 25)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "First Name"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(223, 371)
        Me.txtEmail.MaxLength = 32
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 35)
        Me.txtEmail.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Email"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Member", "Weapon Captain", "Captain / Coach"})
        Me.ComboBox1.Location = New System.Drawing.Point(223, 427)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 33)
        Me.ComboBox1.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Position"
        '
        'CreateAcc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(636, 548)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAcc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateAcc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLN As System.Windows.Forms.TextBox
    Friend WithEvents txtFN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCPW As System.Windows.Forms.TextBox
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
