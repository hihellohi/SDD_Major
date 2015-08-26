<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GearLoaning
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
        Me.formPanel = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnCatalog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'formPanel
        '
        Me.formPanel.BackColor = System.Drawing.SystemColors.Control
        Me.formPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.formPanel.Location = New System.Drawing.Point(0, 110)
        Me.formPanel.Name = "formPanel"
        Me.formPanel.Size = New System.Drawing.Size(1256, 658)
        Me.formPanel.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.btnReturn.BackColor = System.Drawing.Color.White
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(721, 71)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(111, 39)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Returns"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.Green
        Me.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Location = New System.Drawing.Point(831, 79)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(111, 31)
        Me.btnLoan.TabIndex = 2
        Me.btnLoan.Text = "Loans"
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'btnCatalog
        '
        Me.btnCatalog.BackColor = System.Drawing.Color.Green
        Me.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatalog.Location = New System.Drawing.Point(941, 79)
        Me.btnCatalog.Name = "btnCatalog"
        Me.btnCatalog.Size = New System.Drawing.Size(111, 31)
        Me.btnCatalog.TabIndex = 3
        Me.btnCatalog.Text = "Catalog"
        Me.btnCatalog.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gear Loaning"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Green
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(1051, 79)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(39, 31)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHelp)
        Me.Panel1.Controls.Add(Me.btnCatalog)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLoan)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 110)
        Me.Panel1.TabIndex = 6
        '
        'GearLoaning
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.formPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GearLoaning"
        Me.Text = "frmgear"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents formPanel As System.Windows.Forms.Panel
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnCatalog As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
