<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarTableView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalendarTableView))
        Me.FencingDataSet = New FencingManager.FencingDataSet()
        Me.CalendarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalendarTableAdapter = New FencingManager.FencingDataSetTableAdapters.CalendarTableAdapter()
        Me.TableAdapterManager = New FencingManager.FencingDataSetTableAdapters.TableAdapterManager()
        Me.CalendarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalendarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButDisableSearch = New System.Windows.Forms.Button()
        Me.ButEnableSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EventNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EventNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EventNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EventNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FencingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalendarBindingNavigator.SuspendLayout()
        CType(Me.CalendarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EventNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FencingDataSet
        '
        Me.FencingDataSet.DataSetName = "FencingDataSet"
        Me.FencingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalendarBindingSource
        '
        Me.CalendarBindingSource.DataMember = "Calendar"
        Me.CalendarBindingSource.DataSource = Me.FencingDataSet
        '
        'CalendarTableAdapter
        '
        Me.CalendarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsencesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarTableAdapter = Me.CalendarTableAdapter
        Me.TableAdapterManager.GearTableAdapter = Nothing
        Me.TableAdapterManager.LoginsTableAdapter = Nothing
        Me.TableAdapterManager.StudentProfilesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FencingManager.FencingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CalendarBindingNavigator
        '
        Me.CalendarBindingNavigator.AddNewItem = Nothing
        Me.CalendarBindingNavigator.BindingSource = Me.CalendarBindingSource
        Me.CalendarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CalendarBindingNavigator.DeleteItem = Nothing
        Me.CalendarBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CalendarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CalendarBindingNavigator.Location = New System.Drawing.Point(0, 478)
        Me.CalendarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CalendarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CalendarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CalendarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CalendarBindingNavigator.Name = "CalendarBindingNavigator"
        Me.CalendarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CalendarBindingNavigator.Size = New System.Drawing.Size(842, 25)
        Me.CalendarBindingNavigator.TabIndex = 0
        Me.CalendarBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CalendarDataGridView
        '
        Me.CalendarDataGridView.AutoGenerateColumns = False
        Me.CalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalendarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CalendarDataGridView.DataSource = Me.CalendarBindingSource
        Me.CalendarDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CalendarDataGridView.Name = "CalendarDataGridView"
        Me.CalendarDataGridView.Size = New System.Drawing.Size(844, 450)
        Me.CalendarDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EventName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EventName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EventDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EventDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateDay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateDay"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Venue"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Venue"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Weapon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Weapon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Group"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ButDisableSearch
        '
        Me.ButDisableSearch.BackColor = System.Drawing.Color.White
        Me.ButDisableSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButDisableSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButDisableSearch.Location = New System.Drawing.Point(330, 477)
        Me.ButDisableSearch.Name = "ButDisableSearch"
        Me.ButDisableSearch.Size = New System.Drawing.Size(150, 26)
        Me.ButDisableSearch.TabIndex = 108
        Me.ButDisableSearch.Text = "Disable Search Function"
        Me.ButDisableSearch.UseVisualStyleBackColor = False
        Me.ButDisableSearch.Visible = False
        '
        'ButEnableSearch
        '
        Me.ButEnableSearch.BackColor = System.Drawing.Color.White
        Me.ButEnableSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButEnableSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButEnableSearch.Location = New System.Drawing.Point(330, 477)
        Me.ButEnableSearch.Name = "ButEnableSearch"
        Me.ButEnableSearch.Size = New System.Drawing.Size(150, 26)
        Me.ButEnableSearch.TabIndex = 107
        Me.ButEnableSearch.Text = "Enable Search Function"
        Me.ButEnableSearch.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(373, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 13)
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(768, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EventNameToolStrip
        '
        Me.EventNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventNameToolStripLabel, Me.EventNameToolStripTextBox, Me.EventNameToolStripButton})
        Me.EventNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.EventNameToolStrip.Name = "EventNameToolStrip"
        Me.EventNameToolStrip.Size = New System.Drawing.Size(842, 25)
        Me.EventNameToolStrip.TabIndex = 109
        Me.EventNameToolStrip.Text = "EventNameToolStrip"
        '
        'EventNameToolStripLabel
        '
        Me.EventNameToolStripLabel.Name = "EventNameToolStripLabel"
        Me.EventNameToolStripLabel.Size = New System.Drawing.Size(74, 22)
        Me.EventNameToolStripLabel.Text = "Event Name:"
        Me.EventNameToolStripLabel.Visible = False
        '
        'EventNameToolStripTextBox
        '
        Me.EventNameToolStripTextBox.Name = "EventNameToolStripTextBox"
        Me.EventNameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        Me.EventNameToolStripTextBox.Visible = False
        '
        'EventNameToolStripButton
        '
        Me.EventNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EventNameToolStripButton.Name = "EventNameToolStripButton"
        Me.EventNameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.EventNameToolStripButton.Text = "Search"
        Me.EventNameToolStripButton.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'CalendarTableView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 503)
        Me.Controls.Add(Me.ButDisableSearch)
        Me.Controls.Add(Me.ButEnableSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CalendarDataGridView)
        Me.Controls.Add(Me.CalendarBindingNavigator)
        Me.Controls.Add(Me.EventNameToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CalendarTableView"
        Me.Text = "Calendar Table View"
        CType(Me.FencingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalendarBindingNavigator.ResumeLayout(False)
        Me.CalendarBindingNavigator.PerformLayout()
        CType(Me.CalendarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EventNameToolStrip.ResumeLayout(False)
        Me.EventNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FencingDataSet As FencingManager.FencingDataSet
    Friend WithEvents CalendarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalendarTableAdapter As FencingManager.FencingDataSetTableAdapters.CalendarTableAdapter
    Friend WithEvents TableAdapterManager As FencingManager.FencingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CalendarBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalendarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButDisableSearch As System.Windows.Forms.Button
    Friend WithEvents ButEnableSearch As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EventNameToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents EventNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EventNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EventNameToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
