<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RootForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStudentProf = New System.Windows.Forms.Button()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnGearLoan = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(110, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 768)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1094, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 72)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStudentProf
        '
        Me.btnStudentProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProf.Location = New System.Drawing.Point(0, 0)
        Me.btnStudentProf.Name = "btnStudentProf"
        Me.btnStudentProf.Size = New System.Drawing.Size(110, 110)
        Me.btnStudentProf.TabIndex = 2
        Me.btnStudentProf.Text = "Student Profiles"
        Me.btnStudentProf.UseVisualStyleBackColor = True
        '
        'btnCalendar
        '
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Location = New System.Drawing.Point(0, 110)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(110, 110)
        Me.btnCalendar.TabIndex = 3
        Me.btnCalendar.Text = "Calendar"
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnAttendance
        '
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Location = New System.Drawing.Point(0, 220)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(110, 110)
        Me.btnAttendance.TabIndex = 4
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'btnGearLoan
        '
        Me.btnGearLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGearLoan.Location = New System.Drawing.Point(0, 330)
        Me.btnGearLoan.Name = "btnGearLoan"
        Me.btnGearLoan.Size = New System.Drawing.Size(110, 110)
        Me.btnGearLoan.TabIndex = 5
        Me.btnGearLoan.Text = "Gear Loaning"
        Me.btnGearLoan.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Location = New System.Drawing.Point(0, 440)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(110, 110)
        Me.btnAdmin.TabIndex = 6
        Me.btnAdmin.Text = "Administration"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.Location = New System.Drawing.Point(0, 550)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(110, 110)
        Me.btnEmail.TabIndex = 7
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(0, 660)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 110)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'RootForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnGearLoan)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.btnCalendar)
        Me.Controls.Add(Me.btnStudentProf)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "RootForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnStudentProf As System.Windows.Forms.Button
    Friend WithEvents btnCalendar As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnGearLoan As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button

End Class
