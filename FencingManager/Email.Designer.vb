<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnODYes = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnboth = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.btnOverdue = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUntilError = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.rdbUntil = New System.Windows.Forms.RadioButton()
        Me.rdbNext = New System.Windows.Forms.RadioButton()
        Me.lblNextError = New System.Windows.Forms.Label()
        Me.txtNext = New System.Windows.Forms.TextBox()
        Me.cmbNext = New System.Windows.Forms.ComboBox()
        Me.btnGEYes = New System.Windows.Forms.Button()
        Me.btnBothYes = New System.Windows.Forms.Button()
        Me.timerWait = New System.Windows.Forms.Timer(Me.components)
        Me.ptbHelp = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ptbHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(61, 41)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(522, 143)
        Me.txtMessage.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.btnHelp)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 4
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.DarkOrange
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(1182, 37)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(39, 39)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnMain
        '
        Me.btnMain.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.btnMain.BackColor = System.Drawing.Color.White
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(1070, 37)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(80, 39)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email"
        '
        'btnODYes
        '
        Me.btnODYes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnODYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnODYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnODYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnODYes.Location = New System.Drawing.Point(231, 256)
        Me.btnODYes.Name = "btnODYes"
        Me.btnODYes.Size = New System.Drawing.Size(90, 31)
        Me.btnODYes.TabIndex = 16
        Me.btnODYes.Text = "Yes"
        Me.btnODYes.UseVisualStyleBackColor = False
        '
        'btnGeneral
        '
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.Location = New System.Drawing.Point(367, 345)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(239, 31)
        Me.btnGeneral.TabIndex = 17
        Me.btnGeneral.Text = "Send General Email"
        Me.btnGeneral.UseVisualStyleBackColor = True
        '
        'btnboth
        '
        Me.btnboth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnboth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnboth.Location = New System.Drawing.Point(82, 525)
        Me.btnboth.Name = "btnboth"
        Me.btnboth.Size = New System.Drawing.Size(239, 31)
        Me.btnboth.TabIndex = 18
        Me.btnboth.Text = "Send Both"
        Me.btnboth.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Personalised Message"
        '
        'timerMove
        '
        Me.timerMove.Interval = 10
        '
        'btnOverdue
        '
        Me.btnOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverdue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverdue.Location = New System.Drawing.Point(82, 256)
        Me.btnOverdue.Name = "btnOverdue"
        Me.btnOverdue.Size = New System.Drawing.Size(239, 31)
        Me.btnOverdue.TabIndex = 20
        Me.btnOverdue.Text = "Send Overdue Notices"
        Me.btnOverdue.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblUntilError)
        Me.GroupBox2.Controls.Add(Me.txtMessage)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.cmbDay)
        Me.GroupBox2.Controls.Add(Me.rdbUntil)
        Me.GroupBox2.Controls.Add(Me.rdbNext)
        Me.GroupBox2.Controls.Add(Me.lblNextError)
        Me.GroupBox2.Controls.Add(Me.txtNext)
        Me.GroupBox2.Controls.Add(Me.cmbNext)
        Me.GroupBox2.Controls.Add(Me.btnGeneral)
        Me.GroupBox2.Controls.Add(Me.btnGEYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(567, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 397)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General Email"
        '
        'lblUntilError
        '
        Me.lblUntilError.AutoSize = True
        Me.lblUntilError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUntilError.ForeColor = System.Drawing.Color.Red
        Me.lblUntilError.Location = New System.Drawing.Point(259, 288)
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
        Me.txtYear.Location = New System.Drawing.Point(483, 258)
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
        Me.cmbMonth.Location = New System.Drawing.Point(367, 258)
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
        Me.cmbDay.Location = New System.Drawing.Point(262, 258)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(56, 26)
        Me.cmbDay.TabIndex = 28
        '
        'rdbUntil
        '
        Me.rdbUntil.AutoSize = True
        Me.rdbUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbUntil.Location = New System.Drawing.Point(61, 259)
        Me.rdbUntil.Name = "rdbUntil"
        Me.rdbUntil.Size = New System.Drawing.Size(155, 22)
        Me.rdbUntil.TabIndex = 8
        Me.rdbUntil.Text = "Send all events until"
        Me.rdbUntil.UseVisualStyleBackColor = True
        '
        'rdbNext
        '
        Me.rdbNext.AutoSize = True
        Me.rdbNext.Checked = True
        Me.rdbNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNext.Location = New System.Drawing.Point(61, 205)
        Me.rdbNext.Name = "rdbNext"
        Me.rdbNext.Size = New System.Drawing.Size(177, 22)
        Me.rdbNext.TabIndex = 7
        Me.rdbNext.TabStop = True
        Me.rdbNext.Text = "Send events in the next"
        Me.rdbNext.UseVisualStyleBackColor = True
        '
        'lblNextError
        '
        Me.lblNextError.AutoSize = True
        Me.lblNextError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextError.ForeColor = System.Drawing.Color.Red
        Me.lblNextError.Location = New System.Drawing.Point(259, 232)
        Me.lblNextError.Name = "lblNextError"
        Me.lblNextError.Size = New System.Drawing.Size(96, 13)
        Me.lblNextError.TabIndex = 6
        Me.lblNextError.Text = "Complete the fields"
        Me.lblNextError.Visible = False
        '
        'txtNext
        '
        Me.txtNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNext.Location = New System.Drawing.Point(262, 203)
        Me.txtNext.MaxLength = 3
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(126, 26)
        Me.txtNext.TabIndex = 4
        '
        'cmbNext
        '
        Me.cmbNext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNext.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNext.FormattingEnabled = True
        Me.cmbNext.Items.AddRange(New Object() {"Select Unit of Time", "Days", "Weeks", "Months", "Years"})
        Me.cmbNext.Location = New System.Drawing.Point(427, 203)
        Me.cmbNext.Name = "cmbNext"
        Me.cmbNext.Size = New System.Drawing.Size(156, 26)
        Me.cmbNext.TabIndex = 5
        '
        'btnGEYes
        '
        Me.btnGEYes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnGEYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGEYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGEYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGEYes.Location = New System.Drawing.Point(367, 345)
        Me.btnGEYes.Name = "btnGEYes"
        Me.btnGEYes.Size = New System.Drawing.Size(90, 31)
        Me.btnGEYes.TabIndex = 23
        Me.btnGEYes.Text = "Yes"
        Me.btnGEYes.UseVisualStyleBackColor = False
        '
        'btnBothYes
        '
        Me.btnBothYes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBothYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBothYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBothYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBothYes.Location = New System.Drawing.Point(231, 525)
        Me.btnBothYes.Name = "btnBothYes"
        Me.btnBothYes.Size = New System.Drawing.Size(90, 31)
        Me.btnBothYes.TabIndex = 22
        Me.btnBothYes.Text = "Yes"
        Me.btnBothYes.UseVisualStyleBackColor = False
        '
        'timerWait
        '
        Me.timerWait.Interval = 1000
        '
        'ptbHelp
        '
        Me.ptbHelp.BackgroundImage = Global.FencingManager.My.Resources.Resources.email
        Me.ptbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHelp.Location = New System.Drawing.Point(0, 110)
        Me.ptbHelp.Name = "ptbHelp"
        Me.ptbHelp.Size = New System.Drawing.Size(1255, 657)
        Me.ptbHelp.TabIndex = 23
        Me.ptbHelp.TabStop = False
        Me.ptbHelp.Visible = False
        '
        'Email
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.ptbHelp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOverdue)
        Me.Controls.Add(Me.btnODYes)
        Me.Controls.Add(Me.btnboth)
        Me.Controls.Add(Me.btnBothYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Email"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ptbHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnODYes As System.Windows.Forms.Button
    Friend WithEvents btnGeneral As System.Windows.Forms.Button
    Friend WithEvents btnboth As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timerMove As System.Windows.Forms.Timer
    Friend WithEvents btnOverdue As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUntilError As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents rdbUntil As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNext As System.Windows.Forms.RadioButton
    Friend WithEvents lblNextError As System.Windows.Forms.Label
    Friend WithEvents txtNext As System.Windows.Forms.TextBox
    Friend WithEvents cmbNext As System.Windows.Forms.ComboBox
    Friend WithEvents btnGEYes As System.Windows.Forms.Button
    Friend WithEvents btnBothYes As System.Windows.Forms.Button
    Friend WithEvents timerWait As System.Windows.Forms.Timer
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents ptbHelp As System.Windows.Forms.PictureBox
End Class
