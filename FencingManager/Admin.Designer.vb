<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnPWchange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvEvents = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSurname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.lbAcc = New System.Windows.Forms.Label()
        Me.lvAbsences = New System.Windows.Forms.ListView()
        Me.btCLog = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPWchange
        '
        Me.btnPWchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPWchange.Location = New System.Drawing.Point(647, 654)
        Me.btnPWchange.Name = "btnPWchange"
        Me.btnPWchange.Size = New System.Drawing.Size(155, 61)
        Me.btnPWchange.TabIndex = 34
        Me.btnPWchange.Text = "Change Password"
        Me.btnPWchange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(647, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 430)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(528, 399)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 29)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Unexplained Absences:"
        '
        'lvEvents
        '
        Me.lvEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colFName, Me.colSurname, Me.colYear})
        Me.lvEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEvents.GridLines = True
        Me.lvEvents.Location = New System.Drawing.Point(37, 236)
        Me.lvEvents.Name = "lvEvents"
        Me.lvEvents.Size = New System.Drawing.Size(573, 251)
        Me.lvEvents.TabIndex = 30
        Me.lvEvents.UseCompatibleStateImageBehavior = False
        Me.lvEvents.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.DisplayIndex = 2
        Me.colID.Text = "Venue"
        Me.colID.Width = 214
        '
        'colFName
        '
        Me.colFName.DisplayIndex = 0
        Me.colFName.Text = "Date"
        Me.colFName.Width = 122
        '
        'colSurname
        '
        Me.colSurname.DisplayIndex = 1
        Me.colSurname.Text = "Time"
        Me.colSurname.Width = 103
        '
        'colYear
        '
        Me.colYear.Text = "Group"
        Me.colYear.Width = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 29)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Upcoming Events:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Currently Logged In:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(449, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(327, 55)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Administration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 111)
        Me.Panel1.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 39)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Administration"
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Location = New System.Drawing.Point(829, 654)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(155, 61)
        Me.btRefresh.TabIndex = 38
        Me.btRefresh.Text = "Refresh All"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'lbAcc
        '
        Me.lbAcc.AutoSize = True
        Me.lbAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAcc.Location = New System.Drawing.Point(219, 133)
        Me.lbAcc.Name = "lbAcc"
        Me.lbAcc.Size = New System.Drawing.Size(58, 24)
        Me.lbAcc.TabIndex = 39
        Me.lbAcc.Text = "lbAcc"
        '
        'lvAbsences
        '
        Me.lvAbsences.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvAbsences.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAbsences.GridLines = True
        Me.lvAbsences.HoverSelection = True
        Me.lvAbsences.Location = New System.Drawing.Point(37, 569)
        Me.lvAbsences.Name = "lvAbsences"
        Me.lvAbsences.Size = New System.Drawing.Size(573, 152)
        Me.lvAbsences.TabIndex = 42
        Me.lvAbsences.UseCompatibleStateImageBehavior = False
        Me.lvAbsences.View = System.Windows.Forms.View.Details
        '
        'btCLog
        '
        Me.btCLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCLog.Location = New System.Drawing.Point(1010, 654)
        Me.btCLog.Name = "btCLog"
        Me.btCLog.Size = New System.Drawing.Size(155, 61)
        Me.btCLog.TabIndex = 43
        Me.btCLog.Text = "Clear Log"
        Me.btCLog.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.btCLog)
        Me.Controls.Add(Me.lvAbsences)
        Me.Controls.Add(Me.lbAcc)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPWchange)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvEvents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPWchange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvEvents As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSurname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colYear As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents lbAcc As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lvAbsences As System.Windows.Forms.ListView
    Friend WithEvents btCLog As System.Windows.Forms.Button
End Class
