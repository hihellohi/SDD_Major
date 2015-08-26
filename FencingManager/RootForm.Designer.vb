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
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnFight = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.btnminimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(110, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 768)
        Me.Panel1.TabIndex = 0
        '
        'btnminimize
        '
        Me.btnminimize.Location = New System.Drawing.Point(1191, 31)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(53, 49)
        Me.btnminimize.TabIndex = 1
        Me.btnminimize.Text = "↓"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnFight
        '
        Me.btnFight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFight.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFight.Location = New System.Drawing.Point(0, 576)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(110, 96)
        Me.btnFight.TabIndex = 2
        Me.btnFight.Text = "Fight!"
        Me.btnFight.UseVisualStyleBackColor = False
        '
        'btnStudentProf
        '
        Me.btnStudentProf.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStudentProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStudentProf.Location = New System.Drawing.Point(0, 0)
        Me.btnStudentProf.Name = "btnStudentProf"
        Me.btnStudentProf.Size = New System.Drawing.Size(110, 96)
        Me.btnStudentProf.TabIndex = 2
        Me.btnStudentProf.Text = "Student Profiles"
        Me.btnStudentProf.UseVisualStyleBackColor = False
        '
        'btnCalendar
        '
        Me.btnCalendar.BackColor = System.Drawing.Color.Indigo
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalendar.Location = New System.Drawing.Point(0, 96)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(110, 96)
        Me.btnCalendar.TabIndex = 3
        Me.btnCalendar.Text = "Calendar"
        Me.btnCalendar.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.Brown
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAttendance.Location = New System.Drawing.Point(0, 192)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(110, 96)
        Me.btnAttendance.TabIndex = 4
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnGearLoan
        '
        Me.btnGearLoan.BackColor = System.Drawing.Color.Green
        Me.btnGearLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGearLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGearLoan.Location = New System.Drawing.Point(0, 288)
        Me.btnGearLoan.Name = "btnGearLoan"
        Me.btnGearLoan.Size = New System.Drawing.Size(110, 96)
        Me.btnGearLoan.TabIndex = 5
        Me.btnGearLoan.Text = "Gear Loaning"
        Me.btnGearLoan.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.DarkViolet
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmin.Location = New System.Drawing.Point(0, 384)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(110, 96)
        Me.btnAdmin.TabIndex = 6
        Me.btnAdmin.Text = "Administration"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.Orange
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEmail.Location = New System.Drawing.Point(0, 480)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(110, 96)
        Me.btnEmail.TabIndex = 7
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(0, 672)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 96)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'RootForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnFight)
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
        Me.Text = "Fencing Manager"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnStudentProf As System.Windows.Forms.Button
    Friend WithEvents btnCalendar As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnGearLoan As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnFight As System.Windows.Forms.Button

End Class
