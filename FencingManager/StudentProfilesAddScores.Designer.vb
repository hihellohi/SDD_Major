<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfilesAddScores
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateSelector = New System.Windows.Forms.DateTimePicker()
        Me.txtOpponent = New System.Windows.Forms.TextBox()
        Me.txtKills = New System.Windows.Forms.TextBox()
        Me.txtDeaths = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(317, 199)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(206, 51)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(107, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Opponent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kills"
        '
        'dateSelector
        '
        Me.dateSelector.Location = New System.Drawing.Point(169, 30)
        Me.dateSelector.Name = "dateSelector"
        Me.dateSelector.Size = New System.Drawing.Size(354, 32)
        Me.dateSelector.TabIndex = 4
        '
        'txtOpponent
        '
        Me.txtOpponent.Location = New System.Drawing.Point(169, 81)
        Me.txtOpponent.Name = "txtOpponent"
        Me.txtOpponent.Size = New System.Drawing.Size(354, 32)
        Me.txtOpponent.TabIndex = 5
        '
        'txtKills
        '
        Me.txtKills.Location = New System.Drawing.Point(169, 137)
        Me.txtKills.MaxLength = 2
        Me.txtKills.Name = "txtKills"
        Me.txtKills.Size = New System.Drawing.Size(100, 32)
        Me.txtKills.TabIndex = 6
        '
        'txtDeaths
        '
        Me.txtDeaths.Location = New System.Drawing.Point(371, 137)
        Me.txtDeaths.Name = "txtDeaths"
        Me.txtDeaths.Size = New System.Drawing.Size(100, 32)
        Me.txtDeaths.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Deaths"
        '
        'StudentProfilesAddScores
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(535, 262)
        Me.Controls.Add(Me.txtDeaths)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKills)
        Me.Controls.Add(Me.txtOpponent)
        Me.Controls.Add(Me.dateSelector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentProfilesAddScores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Scores"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dateSelector As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOpponent As System.Windows.Forms.TextBox
    Friend WithEvents txtKills As System.Windows.Forms.TextBox
    Friend WithEvents txtDeaths As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
