Public Class StudentProfilesCreate
    Dim newRow As FencingDataSet.StudentProfilesRow

    Private Sub StudentProfilesCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msg = MessageBox.Show("Are you sure you want to cancel?", "Create New Profile", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2)
        If msg = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class