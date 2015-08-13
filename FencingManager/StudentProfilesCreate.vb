Public Class StudentProfilesCreate
    Public newRow As FencingDataSet.StudentProfilesRow

    Public Sub New(row As FencingDataSet.StudentProfilesRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        newRow = row
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msg = MessageBox.Show("Are you sure you want to cancel?", "Create New Profile", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2)
        If msg = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class