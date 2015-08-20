Public Class AttendanceForm
    Dim year, month, day As Integer
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim rollDataTable As New FencingDataSet.StudentProfilesDataTable

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'SplitContainer1.Panel1.Enabled = False

        year = DateTimePicker1.Value.Year
        month = DateTimePicker1.Value.Month
        day = DateTimePicker1.Value.Day

        Dim commandText = "SELECT StudentID, Surname, FirstName FROM StudentProfiles "
        Dim commandWeapon As String = ""
        Dim commandGroup As String = ""
        If rdbFoil.Checked Then
            commandWeapon = "WHERE Weapon = '1'"
        ElseIf rdbSabre.Checked Then
            commandWeapon = "WHERE Weapon = '2'"
        ElseIf rdbEpee.Checked Then
            commandWeapon = "WHERE Weapon = '3'"
        End If

        If rdbJunior.Checked Then
            commandGroup = "WHERE YearGroup = 0"
        ElseIf rdbSenior.Checked Then
            commandGroup = "WHERE YearGroup = 1"
        End If

        If commandGroup <> "" And commandWeapon <> "" Then 'Both are not empty
            commandText = commandText + commandWeapon + " AND " + commandGroup
        Else
            commandText = commandText + commandWeapon + commandGroup
        End If
        rollDataTable.Clear()
        adapter = New OleDb.OleDbDataAdapter(commandText, RootForm.connection)
        adapter.SelectCommand.ExecuteNonQuery()
        adapter.Fill(rollDataTable)
        MessageBox.Show(rollDataTable.Count)
    End Sub

End Class