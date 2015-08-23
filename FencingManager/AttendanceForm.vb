Public Class AttendanceForm
    Dim year, month, day As Integer

    Private studentAdapter As FencingDataSetTableAdapters.StudentProfilesTableAdapter
    Private studentDataTable As New FencingDataSet.StudentProfilesDataTable()
    Private rowItems As FencingDataSet.StudentProfilesRow()
    Private absencesAdapter As FencingDataSetTableAdapters.AbsencesTableAdapter
    Private absencesTable As New FencingDataSet.AbsencesDataTable()


    Private Sub AttendanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            RefreshTables()
        Else
            Reset()
        End If
    End Sub

    Private Sub RefreshTables()
        studentAdapter = New FencingDataSetTableAdapters.StudentProfilesTableAdapter()
        studentAdapter.ClearBeforeFill = True
        studentAdapter.Fill(studentDataTable)
        absencesAdapter = New FencingDataSetTableAdapters.AbsencesTableAdapter()
        absencesAdapter.ClearBeforeFill = True
        absencesAdapter.Fill(absencesTable)
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        SplitContainer1.Panel1.Enabled = False

        year = DateTimePicker1.Value.Year
        month = DateTimePicker1.Value.Month
        day = DateTimePicker1.Value.Day

        Dim commandText As String = "StudentID > 0"
        If rdbFoil.Checked Then
            commandText += " AND Weapon = 1"
        ElseIf rdbSabre.Checked Then
            commandText += " AND Weapon = 2"
        ElseIf rdbEpee.Checked Then
            commandText += " AND Weapon = 3"
        End If

        If rdbJunior.Checked Then
            commandText += " AND YearGroup = 0"
        ElseIf rdbSenior.Checked Then
            commandText += " AND YearGroup = 1"
        End If

        rowItems = studentDataTable.Select(commandText, "Surname, FirstName")
        For Each row In rowItems
            roll.Items.Add(row.StudentID.ToString() + " " + row.FirstName + " " + row.Surname.ToUpper())
        Next
        lblTotal.Text = rowItems.Length
        lblPresent.Text = rowItems.Length
        lblAbsent.Text = 0
        SplitContainer1.Panel2.Enabled = True
    End Sub

    Private Sub Reset()
        roll.Items.Clear()
        lblTotal.Text = ""
        lblAbsent.Text = ""
        lblPresent.Text = ""
        SplitContainer1.Panel2.Enabled = False
        SplitContainer1.Panel1.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reset()
    End Sub

    Private Sub roll_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles roll.ItemCheck
        If e.NewValue = CheckState.Checked Then
            lblAbsent.Text = lblAbsent.Text + 1
            lblPresent.Text = lblPresent.Text - 1
        Else
            lblAbsent.Text = lblAbsent.Text - 1
            lblPresent.Text = lblPresent.Text + 1
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i = 0
        While i < roll.Items.Count
            'If roll.check Then
            i = i + 1
        End While
    End Sub
End Class