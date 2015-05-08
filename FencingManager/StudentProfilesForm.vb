Public Class StudentProfilesForm

    'Dim connection As OleDb.OleDbConnection
    Public adapter As New OleDb.OleDbDataAdapter
    Public dataS As New DataSet()
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        MessageBox.Show(ListView1.SelectedIndices.Item(0))
    End Sub

    Private Sub StudentProfilesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        adapter = New OleDb.OleDbDataAdapter()
        adapter.SelectCommand = New OleDb.OleDbCommand()
        With adapter.SelectCommand
            '.Connection = RootForm.connection
            .CommandText = "SELECT * FROM StudentProfiles"
            .CommandType = CommandType.Text
            '.ExecuteNonQuery()
        End With
        'adapter.Fill(dataS, "StudentProfiles")

    End Sub
End Class