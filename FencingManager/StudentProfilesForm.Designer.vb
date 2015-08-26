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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfilesForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.detailsTopPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSurname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.rdbSelectYear = New System.Windows.Forms.RadioButton()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.rdbJunior = New System.Windows.Forms.RadioButton()
        Me.rdbAll = New System.Windows.Forms.RadioButton()
        Me.chkFilter = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkUnexplainedAb = New System.Windows.Forms.CheckBox()
        Me.rdbID = New System.Windows.Forms.RadioButton()
        Me.rdbSurname = New System.Windows.Forms.RadioButton()
        Me.rdbFirstName = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.lblKDR = New System.Windows.Forms.Label()
        Me.lblWinPercent = New System.Windows.Forms.Label()
        Me.lblWeapon = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.detailsTopPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.detailsTopPanel)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 0
        '
        'detailsTopPanel
        '
        Me.detailsTopPanel.Controls.Add(Me.Label1)
        Me.detailsTopPanel.Controls.Add(Me.btnBack)
        Me.detailsTopPanel.ForeColor = System.Drawing.Color.White
        Me.detailsTopPanel.Location = New System.Drawing.Point(0, 12)
        Me.detailsTopPanel.Name = "detailsTopPanel"
        Me.detailsTopPanel.Size = New System.Drawing.Size(1003, 75)
        Me.detailsTopPanel.TabIndex = 7
        Me.detailsTopPanel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Profile"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(37, 20)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 42)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnNew.Location = New System.Drawing.Point(953, 28)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(50, 50)
        Me.btnNew.TabIndex = 4
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Location = New System.Drawing.Point(849, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 50)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(755, 38)
        Me.TextBox1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colSurname, Me.colFName, Me.colYear})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(28, 138)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(574, 604)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "Student ID"
        Me.colID.Width = 166
        '
        'colSurname
        '
        Me.colSurname.Text = "Surname"
        Me.colSurname.Width = 130
        '
        'colFName
        '
        Me.colFName.Text = "First Name"
        Me.colFName.Width = 146
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbYear)
        Me.GroupBox1.Controls.Add(Me.rdbSelectYear)
        Me.GroupBox1.Controls.Add(Me.rdbSenior)
        Me.GroupBox1.Controls.Add(Me.rdbJunior)
        Me.GroupBox1.Controls.Add(Me.rdbAll)
        Me.GroupBox1.Location = New System.Drawing.Point(971, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 215)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Year Group"
        '
        'cbbYear
        '
        Me.cbbYear.BackColor = System.Drawing.SystemColors.Window
        Me.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbYear.Enabled = False
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cbbYear.Location = New System.Drawing.Point(110, 152)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(70, 39)
        Me.cbbYear.TabIndex = 4
        '
        'rdbSelectYear
        '
        Me.rdbSelectYear.AutoSize = True
        Me.rdbSelectYear.Location = New System.Drawing.Point(27, 152)
        Me.rdbSelectYear.Name = "rdbSelectYear"
        Me.rdbSelectYear.Size = New System.Drawing.Size(92, 35)
        Me.rdbSelectYear.TabIndex = 3
        Me.rdbSelectYear.Text = "Year"
        Me.rdbSelectYear.UseVisualStyleBackColor = True
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.Location = New System.Drawing.Point(27, 115)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(113, 35)
        Me.rdbSenior.TabIndex = 2
        Me.rdbSenior.Text = "Senior"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'rdbJunior
        '
        Me.rdbJunior.AutoSize = True
        Me.rdbJunior.Location = New System.Drawing.Point(27, 79)
        Me.rdbJunior.Name = "rdbJunior"
        Me.rdbJunior.Size = New System.Drawing.Size(109, 35)
        Me.rdbJunior.TabIndex = 1
        Me.rdbJunior.Text = "Junior"
        Me.rdbJunior.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Checked = True
        Me.rdbAll.Location = New System.Drawing.Point(27, 43)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(65, 35)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "All"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'chkFilter
        '
        Me.chkFilter.AutoSize = True
        Me.chkFilter.Location = New System.Drawing.Point(21, 31)
        Me.chkFilter.Name = "chkFilter"
        Me.chkFilter.Size = New System.Drawing.Size(141, 35)
        Me.chkFilter.TabIndex = 4
        Me.chkFilter.Text = "Filter by:"
        Me.chkFilter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkUnexplainedAb)
        Me.GroupBox2.Controls.Add(Me.rdbID)
        Me.GroupBox2.Controls.Add(Me.rdbSurname)
        Me.GroupBox2.Controls.Add(Me.rdbFirstName)
        Me.GroupBox2.Controls.Add(Me.chkFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(647, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 215)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filters"
        '
        'chkUnexplainedAb
        '
        Me.chkUnexplainedAb.AutoSize = True
        Me.chkUnexplainedAb.Location = New System.Drawing.Point(21, 175)
        Me.chkUnexplainedAb.Name = "chkUnexplainedAb"
        Me.chkUnexplainedAb.Size = New System.Drawing.Size(313, 35)
        Me.chkUnexplainedAb.TabIndex = 8
        Me.chkUnexplainedAb.Text = "Unexplained Absences"
        Me.chkUnexplainedAb.UseVisualStyleBackColor = True
        '
        'rdbID
        '
        Me.rdbID.AutoSize = True
        Me.rdbID.Enabled = False
        Me.rdbID.Location = New System.Drawing.Point(21, 139)
        Me.rdbID.Name = "rdbID"
        Me.rdbID.Size = New System.Drawing.Size(164, 35)
        Me.rdbID.TabIndex = 7
        Me.rdbID.TabStop = True
        Me.rdbID.Text = "Student ID"
        Me.rdbID.UseVisualStyleBackColor = True
        '
        'rdbSurname
        '
        Me.rdbSurname.AutoSize = True
        Me.rdbSurname.Enabled = False
        Me.rdbSurname.Location = New System.Drawing.Point(21, 103)
        Me.rdbSurname.Name = "rdbSurname"
        Me.rdbSurname.Size = New System.Drawing.Size(144, 35)
        Me.rdbSurname.TabIndex = 6
        Me.rdbSurname.TabStop = True
        Me.rdbSurname.Text = "Surname"
        Me.rdbSurname.UseVisualStyleBackColor = True
        '
        'rdbFirstName
        '
        Me.rdbFirstName.AutoSize = True
        Me.rdbFirstName.Enabled = False
        Me.rdbFirstName.Location = New System.Drawing.Point(21, 67)
        Me.rdbFirstName.Name = "rdbFirstName"
        Me.rdbFirstName.Size = New System.Drawing.Size(168, 35)
        Me.rdbFirstName.TabIndex = 5
        Me.rdbFirstName.TabStop = True
        Me.rdbFirstName.Text = "First Name"
        Me.rdbFirstName.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnMore)
        Me.GroupBox3.Controls.Add(Me.lblKDR)
        Me.GroupBox3.Controls.Add(Me.lblWinPercent)
        Me.GroupBox3.Controls.Add(Me.lblWeapon)
        Me.GroupBox3.Controls.Add(Me.lblSchoolYear)
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 439)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 303)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Profile"
        '
        'btnMore
        '
        Me.btnMore.Enabled = False
        Me.btnMore.Location = New System.Drawing.Point(443, 244)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(121, 42)
        Me.btnMore.TabIndex = 5
        Me.btnMore.Text = "More..."
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'lblKDR
        '
        Me.lblKDR.AutoSize = True
        Me.lblKDR.Location = New System.Drawing.Point(16, 203)
        Me.lblKDR.Name = "lblKDR"
        Me.lblKDR.Size = New System.Drawing.Size(217, 31)
        Me.lblKDR.TabIndex = 4
        Me.lblKDR.Text = "Kill/Death Ratio: "
        '
        'lblWinPercent
        '
        Me.lblWinPercent.AutoSize = True
        Me.lblWinPercent.Location = New System.Drawing.Point(16, 154)
        Me.lblWinPercent.Name = "lblWinPercent"
        Me.lblWinPercent.Size = New System.Drawing.Size(235, 31)
        Me.lblWinPercent.TabIndex = 3
        Me.lblWinPercent.Text = "Wins Percentage: "
        '
        'lblWeapon
        '
        Me.lblWeapon.AutoSize = True
        Me.lblWeapon.Location = New System.Drawing.Point(16, 102)
        Me.lblWeapon.Name = "lblWeapon"
        Me.lblWeapon.Size = New System.Drawing.Size(129, 31)
        Me.lblWeapon.TabIndex = 2
        Me.lblWeapon.Text = "Weapon: "
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Location = New System.Drawing.Point(475, 52)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(78, 31)
        Me.lblSchoolYear.TabIndex = 1
        Me.lblSchoolYear.Text = "Year "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 52)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 31)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 7
        Me.Panel2.Visible = False
        '
        'StudentProfilesForm
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfilesForm"
        Me.Text = "StudentProfilesForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.detailsTopPanel.ResumeLayout(False)
        Me.detailsTopPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents rdbSelectYear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJunior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents chkFilter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents rdbID As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSurname As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFirstName As System.Windows.Forms.RadioButton
    Friend WithEvents chkUnexplainedAb As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKDR As System.Windows.Forms.Label
    Friend WithEvents lblWinPercent As System.Windows.Forms.Label
    Friend WithEvents lblWeapon As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents detailsTopPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
