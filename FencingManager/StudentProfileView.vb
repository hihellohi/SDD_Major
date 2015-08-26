Public Class StudentProfileView
    Public editMode As Boolean = False
    Dim absencesAdapter As OleDb.OleDbDataAdapter
    Dim absencesDataTable As FencingDataSet.AbsencesDataTable


    Private Sub StudentProfileView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub FillStudent(selectedID As Integer)
        absencesAdapter = New OleDb.OleDbDataAdapter()
        absencesDataTable = New FencingDataSet.AbsencesDataTable()
        absencesAdapter.SelectCommand = New OleDb.OleDbCommand("SELECT * FROM Absences WHERE StudentID = @StuID", RootForm.connection)
        absencesAdapter.SelectCommand.CommandType = CommandType.Text
        absencesAdapter.SelectCommand.Parameters.AddWithValue("@StuID", selectedID)
        absencesAdapter.SelectCommand.ExecuteNonQuery()
        absencesAdapter.Fill(absencesDataTable)
        For Each absence As FencingDataSet.AbsencesRow In absencesDataTable.Select("", "AbsenceDate")
            Dim row = New ListViewItem()
            row.Text = absence.AbsenceDate.ToString("dd/MM/yyyy")
            row.SubItems.Add("Unexplained")
            absenceList.Items.Add(row)
        Next
    End Sub


End Class