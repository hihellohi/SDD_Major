Public Class StudentProfileView
    Public editMode As Boolean
    Dim absencesAdapter As OleDb.OleDbDataAdapter
    Dim absencesDataTable As FencingDataSet.AbsencesDataTable
    Dim currentStudentID As String


    Private Sub StudentProfileView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub FillStudent(selectedID As Integer)
        currentStudentID = selectedID
        Dim command = "SELECT * FROM Absences WHERE StudentID = @StuID ORDER BY AbsenceDate"
        absencesAdapter = New OleDb.OleDbDataAdapter()
        absencesDataTable = New FencingDataSet.AbsencesDataTable()
        absencesAdapter.SelectCommand = New OleDb.OleDbCommand(command, RootForm.connection)
        absencesAdapter.SelectCommand.CommandType = CommandType.Text
        absencesAdapter.SelectCommand.Parameters.AddWithValue("@StuID", selectedID)
        absencesAdapter.SelectCommand.ExecuteNonQuery()
        absencesAdapter.Fill(absencesDataTable)
        absenceList.Items.Clear()
        For Each absence As FencingDataSet.AbsencesRow In absencesDataTable.Select("", "AbsenceDate") 'Sort by date
            Dim row = New ListViewItem()
            row.Text = absence.AbsenceDate.ToString("dd/MM/yyyy")
            If absence.Explained = True Then
                row.SubItems.Add(absence.Explanation)
            Else
                row.SubItems.Add("Unexplained")
                row.ForeColor = Color.DarkRed
            End If
            absenceList.Items.Add(row)
        Next
        btnAddReason.Enabled = False
    End Sub


    Private Sub absenceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles absenceList.SelectedIndexChanged
        If absenceList.SelectedIndices.Count = 1 Then
            Dim index = absenceList.SelectedIndices(0)
            If absencesDataTable(index).Explained = False Then
                btnAddReason.Enabled = True
            Else
                btnAddReason.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAddReason_Click(sender As Object, e As EventArgs) Handles btnAddReason.Click
        editMode = True
        btnAddReason.Hide()
        txtReason.Enabled = True
        btnDone.Show()
        btnDone.Enabled = False
        btnCancelReason.Show()

        absenceList.Enabled = False
        chkUnexplained.Enabled = False
        infoPanel.Enabled = False
        btnShowAbsences.Enabled = False
        btnShowStats.Enabled = False
        txtReason.Focus()
    End Sub

    Private Sub txtReason_TextChanged(sender As Object, e As EventArgs) Handles txtReason.TextChanged
        If editMode Then
            If txtReason.Text = "" Then
                btnDone.Enabled = False
            Else
                btnDone.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnCancelReason_Click(sender As Object, e As EventArgs) Handles btnCancelReason.Click
        editMode = False
        btnAddReason.Show()
        txtReason.Clear()
        txtReason.Enabled = False
        btnDone.Hide()
        btnCancelReason.Hide()

        absenceList.Enabled = True
        chkUnexplained.Enabled = True
        infoPanel.Enabled = True
        btnShowAbsences.Enabled = True
        btnShowStats.Enabled = True
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim index = absenceList.SelectedIndices(0)
        Dim absence = absencesDataTable(index)
        absence.Explained = True
        absence.Explanation = txtReason.Text
        If absence.HasErrors = False Then
            absencesAdapter.UpdateCommand = New OleDb.OleDbCommand("UPDATE Absences SET Explained = TRUE, Explanation = '@expl' WHERE ID = @id", RootForm.connection)
            absencesAdapter.UpdateCommand.Parameters.AddWithValue("@expl", absence.Explanation)
            absencesAdapter.UpdateCommand.Parameters.AddWithValue("@id", absence.ID)
            absencesAdapter.Update(absencesDataTable) 'Update to database
            'Reflect changes in listview
            absenceList.Items(index).ForeColor = Color.Black
            absenceList.Items(index).SubItems(0).Text = absence.Explanation
        End If

        editMode = False
        btnAddReason.Show()
        txtReason.Clear()
        txtReason.Enabled = False
        btnDone.Hide()
        btnCancelReason.Hide()

        absenceList.Enabled = True
        chkUnexplained.Enabled = True
        infoPanel.Enabled = True
        btnShowAbsences.Enabled = True
        btnShowStats.Enabled = True
    End Sub
End Class