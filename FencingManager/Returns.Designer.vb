<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Returns
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnBarcode = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-100, -100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(100, 312)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(327, 31)
        Me.txtInput.TabIndex = 2
        '
        'btnBarcode
        '
        Me.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcode.Location = New System.Drawing.Point(831, 312)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(327, 31)
        Me.btnBarcode.TabIndex = 16
        Me.btnBarcode.Text = "Use Barcode Scanner"
        Me.btnBarcode.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.Location = New System.Drawing.Point(100, 312)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(327, 31)
        Me.btnManual.TabIndex = 17
        Me.btnManual.Text = "Use Manual Input"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(0, 154)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(1258, 25)
        Me.lblOutput.TabIndex = 20
        Me.lblOutput.Text = "Scan or input gear ID to return"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Returns
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1258, 658)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnBarcode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Returns"
        Me.Tag = "returns"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GearType As System.Windows.Forms.ColumnHeader
    Friend WithEvents GearID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Loaned As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnBarcode As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
