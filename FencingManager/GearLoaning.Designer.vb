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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnCatalog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 685)
        Me.Panel1.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(38, 28)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Returns"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(158, 28)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(75, 23)
        Me.btnLoan.TabIndex = 2
        Me.btnLoan.Text = "loans"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnCatalog
        '
        Me.btnCatalog.Location = New System.Drawing.Point(285, 28)
        Me.btnCatalog.Name = "btnCatalog"
        Me.btnCatalog.Size = New System.Drawing.Size(75, 23)
        Me.btnCatalog.TabIndex = 3
        Me.btnCatalog.Text = "Catalog"
        Me.btnCatalog.UseVisualStyleBackColor = True
        '
        'GearLoaning
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1256, 768)
        Me.Controls.Add(Me.btnCatalog)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GearLoaning"
        Me.Text = "frmgear"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnCatalog As System.Windows.Forms.Button
End Class
