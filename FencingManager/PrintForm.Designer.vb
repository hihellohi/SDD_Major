<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabTime = New System.Windows.Forms.Label()
        Me.LabEventName = New System.Windows.Forms.Label()
        Me.LabVenue = New System.Windows.Forms.Label()
        Me.LabWeapon = New System.Windows.Forms.Label()
        Me.LabGroup = New System.Windows.Forms.Label()
        Me.LabDatePrinted = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TexAdditionalInfo = New System.Windows.Forms.TextBox()
        Me.LabNoAdditionalInfo = New System.Windows.Forms.Label()
        ' Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sydney Boys High School Fencing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scheduled Event on:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Event Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 430)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Weapon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Group:"
        '
        'LabDate
        '
        Me.LabDate.AutoSize = True
        Me.LabDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDate.Location = New System.Drawing.Point(309, 187)
        Me.LabDate.Name = "LabDate"
        Me.LabDate.Size = New System.Drawing.Size(60, 29)
        Me.LabDate.TabIndex = 8
        Me.LabDate.Text = "date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Venue:"
        '
        'LabTime
        '
        Me.LabTime.AutoSize = True
        Me.LabTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTime.Location = New System.Drawing.Point(133, 329)
        Me.LabTime.Name = "LabTime"
        Me.LabTime.Size = New System.Drawing.Size(119, 24)
        Me.LabTime.TabIndex = 10
        Me.LabTime.Text = "Event Name:"
        '
        'LabEventName
        '
        Me.LabEventName.AutoSize = True
        Me.LabEventName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEventName.Location = New System.Drawing.Point(133, 281)
        Me.LabEventName.Name = "LabEventName"
        Me.LabEventName.Size = New System.Drawing.Size(154, 24)
        Me.LabEventName.TabIndex = 11
        Me.LabEventName.Text = "mmmmmmmmm"
        '
        'LabVenue
        '
        Me.LabVenue.AutoSize = True
        Me.LabVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabVenue.Location = New System.Drawing.Point(133, 378)
        Me.LabVenue.Name = "LabVenue"
        Me.LabVenue.Size = New System.Drawing.Size(119, 24)
        Me.LabVenue.TabIndex = 12
        Me.LabVenue.Text = "Event Name:"
        '
        'LabWeapon
        '
        Me.LabWeapon.AutoSize = True
        Me.LabWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWeapon.Location = New System.Drawing.Point(133, 430)
        Me.LabWeapon.Name = "LabWeapon"
        Me.LabWeapon.Size = New System.Drawing.Size(119, 24)
        Me.LabWeapon.TabIndex = 13
        Me.LabWeapon.Text = "Event Name:"
        '
        'LabGroup
        '
        Me.LabGroup.AutoSize = True
        Me.LabGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabGroup.Location = New System.Drawing.Point(133, 479)
        Me.LabGroup.Name = "LabGroup"
        Me.LabGroup.Size = New System.Drawing.Size(119, 24)
        Me.LabGroup.TabIndex = 14
        Me.LabGroup.Text = "Event Name:"
        '
        'LabDatePrinted
        '
        Me.LabDatePrinted.AutoSize = True
        Me.LabDatePrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDatePrinted.Location = New System.Drawing.Point(8, 830)
        Me.LabDatePrinted.Name = "LabDatePrinted"
        Me.LabDatePrinted.Size = New System.Drawing.Size(148, 20)
        Me.LabDatePrinted.TabIndex = 15
        Me.LabDatePrinted.Text = "Printed on the date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 761)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(591, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*Note: students required to show up 1 hour before a competition starts for warm u" & _
    "p"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FencingManager.My.Resources.Resources.printer_64_000000
        Me.Button1.Location = New System.Drawing.Point(565, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 65)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FencingManager.My.Resources.Resources.Sydneyboyscrest__1_
        Me.PictureBox1.Location = New System.Drawing.Point(255, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButCancel
        '
        Me.ButCancel.Location = New System.Drawing.Point(565, 95)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(67, 20)
        Me.ButCancel.TabIndex = 18
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Additional Notes:"
        '
        'TexAdditionalInfo
        '
        Me.TexAdditionalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexAdditionalInfo.Location = New System.Drawing.Point(12, 571)
        Me.TexAdditionalInfo.MaxLength = 500
        Me.TexAdditionalInfo.Multiline = True
        Me.TexAdditionalInfo.Name = "TexAdditionalInfo"
        Me.TexAdditionalInfo.Size = New System.Drawing.Size(587, 147)
        Me.TexAdditionalInfo.TabIndex = 20
        Me.TexAdditionalInfo.Text = "Enter additional notes here"
        '
        'LabNoAdditionalInfo
        '
        Me.LabNoAdditionalInfo.AutoSize = True
        Me.LabNoAdditionalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNoAdditionalInfo.Location = New System.Drawing.Point(166, 529)
        Me.LabNoAdditionalInfo.Name = "LabNoAdditionalInfo"
        Me.LabNoAdditionalInfo.Size = New System.Drawing.Size(57, 24)
        Me.LabNoAdditionalInfo.TabIndex = 21
        Me.LabNoAdditionalInfo.Text = "None"
        Me.LabNoAdditionalInfo.Visible = False
        '
        'PrintForm1
        '
        'Me.PrintForm1.DocumentName = "document"
        'Me.PrintForm1.Form = Me
        'Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        'Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        'Me.PrintForm1.PrintFileName = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(281, 830)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(318, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fencing MIC: Mr Dat Huynh, IA Department"
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(699, 853)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabNoAdditionalInfo)
        Me.Controls.Add(Me.TexAdditionalInfo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabDatePrinted)
        Me.Controls.Add(Me.LabGroup)
        Me.Controls.Add(Me.LabWeapon)
        Me.Controls.Add(Me.LabVenue)
        Me.Controls.Add(Me.LabEventName)
        Me.Controls.Add(Me.LabTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabTime As System.Windows.Forms.Label
    Friend WithEvents LabEventName As System.Windows.Forms.Label
    Friend WithEvents LabVenue As System.Windows.Forms.Label
    Friend WithEvents LabWeapon As System.Windows.Forms.Label
    Friend WithEvents LabGroup As System.Windows.Forms.Label
    Friend WithEvents LabDatePrinted As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TexAdditionalInfo As System.Windows.Forms.TextBox
    Friend WithEvents LabNoAdditionalInfo As System.Windows.Forms.Label
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
