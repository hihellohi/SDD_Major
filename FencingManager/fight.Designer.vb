<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fight
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblKD1 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblKills1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWL1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblWins1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblSurname1 = New System.Windows.Forms.Label()
        Me.lblFirstName1 = New System.Windows.Forms.Label()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblKD2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblKills2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblWL2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblWins2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblSurname2 = New System.Windows.Forms.Label()
        Me.lblFirstName2 = New System.Windows.Forms.Label()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHide = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHelp)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 5
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(1051, 79)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(39, 31)
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
        Me.btnMain.Location = New System.Drawing.Point(972, 71)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(80, 39)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fight"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.lblKD1)
        Me.Panel2.Controls.Add(Me.label6)
        Me.Panel2.Controls.Add(Me.lblKills1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblWL1)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.lblWins1)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.lblSurname1)
        Me.Panel2.Controls.Add(Me.lblFirstName1)
        Me.Panel2.Controls.Add(Me.txtPlayer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 658)
        Me.Panel2.TabIndex = 6
        '
        'lblKD1
        '
        Me.lblKD1.AutoSize = True
        Me.lblKD1.BackColor = System.Drawing.Color.Transparent
        Me.lblKD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKD1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblKD1.Location = New System.Drawing.Point(160, 259)
        Me.lblKD1.Name = "lblKD1"
        Me.lblKD1.Size = New System.Drawing.Size(20, 24)
        Me.lblKD1.TabIndex = 14
        Me.lblKD1.Text = "0"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label6.Location = New System.Drawing.Point(48, 259)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(97, 24)
        Me.label6.TabIndex = 13
        Me.label6.Text = "K/D Ratio: "
        '
        'lblKills1
        '
        Me.lblKills1.AutoSize = True
        Me.lblKills1.BackColor = System.Drawing.Color.Transparent
        Me.lblKills1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKills1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblKills1.Location = New System.Drawing.Point(160, 235)
        Me.lblKills1.Name = "lblKills1"
        Me.lblKills1.Size = New System.Drawing.Size(20, 24)
        Me.lblKills1.TabIndex = 12
        Me.lblKills1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(92, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kills: "
        '
        'lblWL1
        '
        Me.lblWL1.AutoSize = True
        Me.lblWL1.BackColor = System.Drawing.Color.Transparent
        Me.lblWL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWL1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWL1.Location = New System.Drawing.Point(160, 162)
        Me.lblWL1.Name = "lblWL1"
        Me.lblWL1.Size = New System.Drawing.Size(20, 24)
        Me.lblWL1.TabIndex = 10
        Me.lblWL1.Text = "0"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label3.Location = New System.Drawing.Point(54, 162)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 24)
        Me.label3.TabIndex = 9
        Me.label3.Text = "W/L Ratio: "
        '
        'lblWins1
        '
        Me.lblWins1.AutoSize = True
        Me.lblWins1.BackColor = System.Drawing.Color.Transparent
        Me.lblWins1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWins1.Location = New System.Drawing.Point(160, 138)
        Me.lblWins1.Name = "lblWins1"
        Me.lblWins1.Size = New System.Drawing.Size(20, 24)
        Me.lblWins1.TabIndex = 8
        Me.lblWins1.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label2.Location = New System.Drawing.Point(92, 138)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 24)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Wins: "
        '
        'lblSurname1
        '
        Me.lblSurname1.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSurname1.Location = New System.Drawing.Point(9, 64)
        Me.lblSurname1.Name = "lblSurname1"
        Me.lblSurname1.Size = New System.Drawing.Size(279, 24)
        Me.lblSurname1.TabIndex = 6
        Me.lblSurname1.Text = "Guest"
        '
        'lblFirstName1
        '
        Me.lblFirstName1.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFirstName1.Location = New System.Drawing.Point(9, 40)
        Me.lblFirstName1.Name = "lblFirstName1"
        Me.lblFirstName1.Size = New System.Drawing.Size(279, 24)
        Me.lblFirstName1.TabIndex = 5
        Me.lblFirstName1.Text = "Red"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer1.Location = New System.Drawing.Point(12, 6)
        Me.txtPlayer1.MaxLength = 9
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(276, 31)
        Me.txtPlayer1.TabIndex = 4
        '
        'btnBegin
        '
        Me.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(533, 254)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(190, 71)
        Me.btnBegin.TabIndex = 7
        Me.btnBegin.Text = "En Garde"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblKD2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lblKills2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lblWL2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lblWins2)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.lblSurname2)
        Me.Panel3.Controls.Add(Me.lblFirstName2)
        Me.Panel3.Controls.Add(Me.txtPlayer2)
        Me.Panel3.Location = New System.Drawing.Point(956, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 658)
        Me.Panel3.TabIndex = 8
        '
        'lblKD2
        '
        Me.lblKD2.AutoSize = True
        Me.lblKD2.BackColor = System.Drawing.Color.Transparent
        Me.lblKD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKD2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblKD2.Location = New System.Drawing.Point(160, 259)
        Me.lblKD2.Name = "lblKD2"
        Me.lblKD2.Size = New System.Drawing.Size(20, 24)
        Me.lblKD2.TabIndex = 14
        Me.lblKD2.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(57, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "K/D Ratio: "
        '
        'lblKills2
        '
        Me.lblKills2.AutoSize = True
        Me.lblKills2.BackColor = System.Drawing.Color.Transparent
        Me.lblKills2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKills2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblKills2.Location = New System.Drawing.Point(160, 235)
        Me.lblKills2.Name = "lblKills2"
        Me.lblKills2.Size = New System.Drawing.Size(20, 24)
        Me.lblKills2.TabIndex = 12
        Me.lblKills2.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(101, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Kills: "
        '
        'lblWL2
        '
        Me.lblWL2.AutoSize = True
        Me.lblWL2.BackColor = System.Drawing.Color.Transparent
        Me.lblWL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWL2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWL2.Location = New System.Drawing.Point(160, 162)
        Me.lblWL2.Name = "lblWL2"
        Me.lblWL2.Size = New System.Drawing.Size(20, 24)
        Me.lblWL2.TabIndex = 10
        Me.lblWL2.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(54, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 24)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "W/L Ratio: "
        '
        'lblWins2
        '
        Me.lblWins2.AutoSize = True
        Me.lblWins2.BackColor = System.Drawing.Color.Transparent
        Me.lblWins2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWins2.Location = New System.Drawing.Point(160, 138)
        Me.lblWins2.Name = "lblWins2"
        Me.lblWins2.Size = New System.Drawing.Size(20, 24)
        Me.lblWins2.TabIndex = 8
        Me.lblWins2.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(92, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 24)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Wins: "
        '
        'lblSurname2
        '
        Me.lblSurname2.AutoSize = True
        Me.lblSurname2.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSurname2.Location = New System.Drawing.Point(229, 64)
        Me.lblSurname2.Name = "lblSurname2"
        Me.lblSurname2.Size = New System.Drawing.Size(59, 24)
        Me.lblSurname2.TabIndex = 6
        Me.lblSurname2.Text = "Guest"
        '
        'lblFirstName2
        '
        Me.lblFirstName2.AutoSize = True
        Me.lblFirstName2.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFirstName2.Location = New System.Drawing.Point(225, 40)
        Me.lblFirstName2.Name = "lblFirstName2"
        Me.lblFirstName2.Size = New System.Drawing.Size(63, 24)
        Me.lblFirstName2.TabIndex = 5
        Me.lblFirstName2.Text = "Green"
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer2.Location = New System.Drawing.Point(12, 6)
        Me.txtPlayer2.MaxLength = 9
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(276, 31)
        Me.txtPlayer2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(529, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "First to: "
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(610, 187)
        Me.txtLength.MaxLength = 3
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(113, 31)
        Me.txtLength.TabIndex = 10
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 102.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(306, 576)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(644, 159)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "0 - 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(306, 493)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(644, 59)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "0:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FencingManager.My.Resources.Resources.mouseleft
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(360, 400)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.FencingManager.My.Resources.Resources.mousemiddle
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(543, 400)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.FencingManager.My.Resources.Resources.mouseright
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(738, 400)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(414, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Red Point"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(597, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Undo Last Point"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(792, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Green Point"
        '
        'lblHide
        '
        Me.lblHide.Location = New System.Drawing.Point(343, 387)
        Me.lblHide.Name = "lblHide"
        Me.lblHide.Size = New System.Drawing.Size(578, 75)
        Me.lblHide.TabIndex = 19
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(572, 332)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 35)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'fight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.lblHide)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fight"
        Me.Text = "fight"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname1 As System.Windows.Forms.Label
    Friend WithEvents lblFirstName1 As System.Windows.Forms.Label
    Friend WithEvents lblKD1 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblKills1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblWL1 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents lblWins1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblKD2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblKills2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblWL2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblWins2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblSurname2 As System.Windows.Forms.Label
    Friend WithEvents lblFirstName2 As System.Windows.Forms.Label
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblHide As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
