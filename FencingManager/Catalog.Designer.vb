<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalog
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStudentLoaned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rdbType = New System.Windows.Forms.RadioButton()
        Me.rdbStudent = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem, Me.colDesc, Me.colStudentLoaned, Me.colDueDate})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(75, 211)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(521, 279)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colItem
        '
        Me.colItem.Text = "Loaned Item ID v"
        Me.colItem.Width = 113
        '
        'colDesc
        '
        Me.colDesc.Text = "Item Description "
        Me.colDesc.Width = 150
        '
        'colStudentLoaned
        '
        Me.colStudentLoaned.Text = "Student Loaned "
        Me.colStudentLoaned.Width = 118
        '
        'colDueDate
        '
        Me.colDueDate.Text = "Due Date "
        Me.colDueDate.Width = 132
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(690, 211)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'rdbType
        '
        Me.rdbType.AutoSize = True
        Me.rdbType.Checked = True
        Me.rdbType.Location = New System.Drawing.Point(856, 211)
        Me.rdbType.Name = "rdbType"
        Me.rdbType.Size = New System.Drawing.Size(97, 21)
        Me.rdbType.TabIndex = 5
        Me.rdbType.TabStop = True
        Me.rdbType.Text = "Gear Type"
        Me.rdbType.UseVisualStyleBackColor = True
        '
        'rdbStudent
        '
        Me.rdbStudent.AutoSize = True
        Me.rdbStudent.Location = New System.Drawing.Point(856, 239)
        Me.rdbStudent.Name = "rdbStudent"
        Me.rdbStudent.Size = New System.Drawing.Size(126, 21)
        Me.rdbStudent.TabIndex = 6
        Me.rdbStudent.TabStop = True
        Me.rdbStudent.Text = "StudentLoaned"
        Me.rdbStudent.UseVisualStyleBackColor = True
        '
        'Catalog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1238, 638)
        Me.Controls.Add(Me.rdbStudent)
        Me.Controls.Add(Me.rdbType)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Catalog"
        Me.Text = "Catalog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colItem As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStudentLoaned As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDueDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rdbType As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStudent As System.Windows.Forms.RadioButton
End Class
