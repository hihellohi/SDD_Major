Public Class StudentProfilesForm

    'Dim connection As OleDb.OleDbConnection
    Public adapter As New OleDb.OleDbDataAdapter
    Public searchResults As New DataSet()
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub StudentProfilesForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If chkAdvanced.Checked = True Then

        Else
            BasicSearchQuery()
        End If
    End Sub

    Private Sub AdvancedSearchQuery()
        ' Todo
    End Sub

    Private Sub BasicSearchQuery()
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
        searchResults.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
       
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedIndices.Count = 1 Then

        End If
    End Sub
End Class