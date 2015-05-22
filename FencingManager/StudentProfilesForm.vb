Public Class StudentProfilesForm

    'Dim connection As OleDb.OleDbConnection
    Public adapter As New OleDb.OleDbDataAdapter
    Public searchResults As New DataSet()
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'MessageBox.Show(ListView1.SelectedIndices.Item(0))
    End Sub

    Private Sub StudentProfilesForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BasicSearchQuery()
    End Sub

    Private Sub BasicSearchQuery()
        searchResults.Clear()
        Dim command As String =
            "SELECT StudentID, FirstName, Surname, SchoolYear " +
            "FROM StudentProfiles " +
            "WHERE FirstName LIKE @Search1 + '%' OR Surname LIKE @Search2 + '%'" +
            "ORDER BY Surname, FirstName"

        adapter = New OleDb.OleDbDataAdapter()
        adapter.SelectCommand = New OleDb.OleDbCommand()
        With adapter.SelectCommand
            .Connection = RootForm.connection
            .CommandText = command
            ' SECURITY: PREVENTS SQL INJECTIONS
            .Parameters.AddWithValue("@Search1", Me.TextBox1.Text)
            .Parameters.AddWithValue("@Search2", Me.TextBox1.Text)
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        adapter.Fill(searchResults, "StudentProfiles")

        'Populate Results Table
        ListView1.Items.Clear()
        Dim row As DataRow
        For Each row In searchResults.Tables("StudentProfiles").Rows
            If row.RowState <> DataRowState.Deleted Then
                Dim rowItem = New ListViewItem(row("StudentID").ToString())
                rowItem.SubItems.Add(row("FirstName").ToString())
                rowItem.SubItems.Add(row("Surname").ToString())
                rowItem.SubItems.Add(row("SchoolYear").ToString())
                ListView1.Items.Add(rowItem)
            End If
        Next
    End Sub
End Class