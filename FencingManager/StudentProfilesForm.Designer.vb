<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfilesForm
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSurname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.rdbCertainYear = New System.Windows.Forms.RadioButton()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.rdbJunior = New System.Windows.Forms.RadioButton()
        Me.rdbAll = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAdvanced = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(849, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(51, 47)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(755, 32)
        Me.TextBox1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colFName, Me.colSurname, Me.colYear})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(68, 145)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(573, 590)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.DisplayIndex = 2
        Me.colID.Text = "Student ID"
        Me.colID.Width = 174
        '
        'colFName
        '
        Me.colFName.DisplayIndex = 0
        Me.colFName.Text = "First Name"
        Me.colFName.Width = 122
        '
        'colSurname
        '
        Me.colSurname.DisplayIndex = 1
        Me.colSurname.Text = "Surname"
        Me.colSurname.Width = 106
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.rdbCertainYear)
        Me.GroupBox1.Controls.Add(Me.rdbSenior)
        Me.GroupBox1.Controls.Add(Me.rdbJunior)
        Me.GroupBox1.Controls.Add(Me.rdbAll)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(746, 408)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 190)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Year Group"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(90, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(70, 33)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "7"
        '
        'rdbCertainYear
        '
        Me.rdbCertainYear.AutoSize = True
        Me.rdbCertainYear.Location = New System.Drawing.Point(7, 141)
        Me.rdbCertainYear.Name = "rdbCertainYear"
        Me.rdbCertainYear.Size = New System.Drawing.Size(77, 30)
        Me.rdbCertainYear.TabIndex = 3
        Me.rdbCertainYear.Text = "Year"
        Me.rdbCertainYear.UseVisualStyleBackColor = True
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.Location = New System.Drawing.Point(7, 104)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(93, 30)
        Me.rdbSenior.TabIndex = 2
        Me.rdbSenior.Text = "Senior"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'rdbJunior
        '
        Me.rdbJunior.AutoSize = True
        Me.rdbJunior.Location = New System.Drawing.Point(7, 68)
        Me.rdbJunior.Name = "rdbJunior"
        Me.rdbJunior.Size = New System.Drawing.Size(89, 30)
        Me.rdbJunior.TabIndex = 1
        Me.rdbJunior.Text = "Junior"
        Me.rdbJunior.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Checked = True
        Me.rdbAll.Location = New System.Drawing.Point(7, 32)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(55, 30)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "All"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(734, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Options"
        '
        'chkAdvanced
        '
        Me.chkAdvanced.AutoSize = True
        Me.chkAdvanced.Location = New System.Drawing.Point(740, 193)
        Me.chkAdvanced.Name = "chkAdvanced"
        Me.chkAdvanced.Size = New System.Drawing.Size(209, 30)
        Me.chkAdvanced.TabIndex = 4
        Me.chkAdvanced.Text = "Advanced Options"
        Me.chkAdvanced.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(740, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 142)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 103)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(134, 30)
        Me.CheckBox4.TabIndex = 2
        Me.CheckBox4.Text = "Student ID"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 67)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(120, 30)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "Surname"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 31)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(138, 30)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "First Name"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(928, 28)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 47)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New.."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'StudentProfilesForm
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkAdvanced)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfilesForm"
        Me.Text = "StudentProfilesForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colSurname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colYear As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents colFName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents rdbCertainYear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJunior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAdvanced As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
