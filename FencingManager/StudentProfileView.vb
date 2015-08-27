Imports System.Text.RegularExpressions

Public Class StudentProfileView
    Public editMode As Boolean
    Dim absencesAdapter As FencingDataSetTableAdapters.AbsencesTableAdapter
    Dim absencesDataTable As FencingDataSet.AbsencesDataTable
    Dim studentAdapter As FencingDataSetTableAdapters.StudentProfilesTableAdapter
    Dim studentDataTable As FencingDataSet.StudentProfilesDataTable
    Dim currentStudentID As String
    Dim scoresAdapter As FencingDataSetTableAdapters.ScoresTableAdapter
    Dim scoresTable As FencingDataSet.ScoresDataTable
    Dim emailRegex As Regex

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        absencesAdapter = New FencingDataSetTableAdapters.AbsencesTableAdapter()
        absencesDataTable = New FencingDataSet.AbsencesDataTable()
    End Sub

    Private Sub StudentProfileView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailRegex = New Regex("^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
    End Sub

    Sub FillStudent(selectedID As Integer)
        currentStudentID = selectedID
        PopulateDetails()
        PopulateAbsencesList()
        PopulateStatistics()
        btnAddReason.Enabled = False
        absencesPanel.Hide()
        statsPanel.Show()
    End Sub

    Sub PopulateAbsencesList()
        Dim filter As String
        If chkUnexplained.Checked Then
            filter = "StudentID = " & currentStudentID & " AND Explained = FALSE"
        Else
            filter = "StudentID = " & currentStudentID
        End If

        absencesAdapter.Fill(absencesDataTable)
        absenceList.Items.Clear()
        For Each absence As FencingDataSet.AbsencesRow In absencesDataTable.Select(filter, "AbsenceDate") 'Sort by date
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
        Dim studentRow = studentDataTable.FindByStudentID(currentStudentID)
        lblAttendance.Text = "Attendance: " & studentRow.totalPresences & "/" & (studentRow.totalPresences + studentRow.totalAbsences)
        lblAbsences.Text = "Absences: " & studentRow.totalAbsences
        lblUnexplained.Text = "Unexplained: " & studentRow.unexplainedAbsences
    End Sub

    Sub PopulateDetails()
        studentAdapter = New FencingDataSetTableAdapters.StudentProfilesTableAdapter()
        studentDataTable = New FencingDataSet.StudentProfilesDataTable()
        studentAdapter.Fill(studentDataTable)
        Dim studentRow As FencingDataSet.StudentProfilesRow = studentDataTable.Select("StudentID = " & currentStudentID)(0)
        txtID.Text = studentRow.StudentID
        txtFirstName.Text = studentRow.FirstName
        txtSurname.Text = studentRow.Surname
        cbbYear.SelectedIndex = studentRow.SchoolYear - 7
        cbbWeapon.SelectedIndex = studentRow.Weapon - 1
        txtEmail.Text = studentRow.Email
        txtPhone.Text = studentRow.PhoneNum

        txtID.ReadOnly = True
        txtFirstName.ReadOnly = True
        txtSurname.ReadOnly = True
        cbbYear.Enabled = False
        cbbWeapon.Enabled = False
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True

    End Sub

    Sub PopulateStatistics()
        Dim studentRow As FencingDataSet.StudentProfilesRow = studentDataTable.Select("StudentID = " & currentStudentID)(0)
        lblWins.Text = "Wins: " & studentRow.Wins & "/" & (studentRow.Wins + studentRow.Losses)
        lblKills.Text = "Total Kills: " & studentRow.Kills
        lblDeaths.Text = "Total Deaths: " & studentRow.Deaths
        Dim ratio As Double
        If studentRow.Deaths > 0 Then
            ratio = studentRow.Kills / studentRow.Deaths
        Else
            ratio = studentRow.Kills / 1.0
        End If
        lblRatio.Text = "Kill/Death Ratio: " + Math.Round(ratio, 3).ToString()
        statisticsList.Items.Clear()
        scoresAdapter = New FencingDataSetTableAdapters.ScoresTableAdapter()
        scoresTable = New FencingDataSet.ScoresDataTable()
        scoresAdapter.Fill(scoresTable)
        For Each matchRow As FencingDataSet.ScoresRow In scoresTable.Select("StudentID = " & currentStudentID, "MatchDate")
            If matchRow.RowState <> DataRowState.Deleted Then
                Dim item As New ListViewItem()
                item.Text = matchRow.MatchDate.ToString("dd/MM/yyyy")
                item.SubItems.Add(matchRow.Opponent)
                If matchRow.Kills > matchRow.Deaths Then
                    item.SubItems.Add("Won")
                ElseIf matchRow.Kills = matchRow.Deaths Then
                    item.SubItems.Add("Tie")
                Else
                    item.SubItems.Add("Lost")
                End If
                item.SubItems.Add(matchRow.Kills.ToString())
                item.SubItems.Add(matchRow.Deaths.ToString())
                Dim matchRatio As Double
                If matchRow.Deaths > 0 Then
                    matchRatio = matchRow.Kills / matchRow.Deaths
                Else
                    matchRatio = matchRow.Kills / 1.0
                End If
                item.SubItems.Add(Math.Round(matchRatio, 3).ToString())
                statisticsList.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub chkUnexplained_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnexplained.CheckedChanged
        PopulateAbsencesList()
    End Sub

    Sub ResetAll()
        ResetDetails()
        ResetAbsences()
    End Sub

    Private Sub absenceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles absenceList.SelectedIndexChanged
        Dim filter As String
        If chkUnexplained.Checked Then
            filter = "StudentID = " & currentStudentID & " AND Explained = FALSE"
        Else
            filter = "StudentID = " & currentStudentID
        End If
        Dim studentAbsences As FencingDataSet.AbsencesRow() = absencesDataTable.Select(filter, "AbsenceDate")
        If absenceList.SelectedIndices.Count = 1 Then
            Dim index = absenceList.SelectedIndices(0)
            If studentAbsences(index).Explained = False Then
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
        Me.AcceptButton = btnDone
        Me.CancelButton = btnCancelReason
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
        ResetAbsences()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim index = absenceList.SelectedIndices(0)
        Dim filter As String
        If chkUnexplained.Checked Then
            filter = "StudentID = " & currentStudentID & " AND Explained = FALSE"
        Else
            filter = "StudentID = " & currentStudentID
        End If
        Dim absence As FencingDataSet.AbsencesRow = absencesDataTable.Select(filter, "AbsenceDate")(index)
        absence.Explained = True
        absence.Explanation = txtReason.Text
        If absence.HasErrors = False Then
            absencesAdapter.Update(absencesDataTable) 'Update to database
        End If
        Dim studentRow = studentDataTable.FindByStudentID(currentStudentID)
        studentRow.unexplainedAbsences -= 1
        studentAdapter.Update(studentDataTable)
        ResetAbsences()
        btnAddReason.Enabled = False
        PopulateAbsencesList()
    End Sub

    Private Sub ResetAbsences()
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
        Me.AcceptButton = Nothing
        Me.CancelButton = Nothing
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not editMode Then
            'Edit personal info
            txtFirstName.ReadOnly = False
            txtSurname.ReadOnly = False
            cbbYear.Enabled = True
            cbbWeapon.Enabled = True
            txtEmail.ReadOnly = False
            txtPhone.ReadOnly = False

            editMode = True
            btnCancel.Show()
            btnEdit.Text = "Save"
            btnShowAbsences.Enabled = False
            btnShowStats.Enabled = False
            absencesPanel.Enabled = False
            statsPanel.Enabled = False
        Else
            Dim valid = True
            If txtFirstName.Text = "" Then
                valid = False
                errFirstName.Show()
            Else
                errFirstName.Hide()
            End If
            If txtSurname.Text = "" Then
                valid = False
                errSurname.Show()
            Else
                errSurname.Hide()
            End If
            If txtID.TextLength < 9 Then
                valid = False
                errStudentID.Show()
            Else
                errStudentID.Hide()
            End If
            If Not emailRegex.Match(txtEmail.Text).Success Then 'Check if valid email address
                valid = False
                errEmail.Show()
            Else
                errEmail.Hide()
            End If
            If txtPhone.Text = "" Then
                valid = False
                errPhone.Show()
            Else
                errPhone.Hide()
            End If
            If valid Then
                Dim studentRow = studentDataTable.FindByStudentID(currentStudentID)
                studentRow.FirstName = txtFirstName.Text
                studentRow.Surname = txtSurname.Text
                studentRow.StudentID = CInt(txtID.Text)
                studentRow.SchoolYear = CShort(cbbYear.Text)
                studentRow.Weapon = CByte(cbbWeapon.SelectedIndex + 1)
                studentRow.Email = txtEmail.Text
                studentRow.PhoneNum = txtPhone.Text

                If studentRow.SchoolYear < 10 Then
                    studentRow.YearGroup = 0 ' Junior
                Else
                    studentRow.YearGroup = 1 ' Senior
                End If
                studentAdapter.Update(studentDataTable)
                PopulateDetails()
                ResetDetails()
                currentStudentID = studentRow.StudentID
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PopulateDetails()
        ResetDetails()
    End Sub

    Sub ResetDetails()
        editMode = False
        btnCancel.Hide()
        btnEdit.Text = "Edit"
        btnShowAbsences.Enabled = True
        btnShowStats.Enabled = True
        absencesPanel.Enabled = True
        statsPanel.Enabled = True
    End Sub

    Private Sub btnAddScores_Click(sender As Object, e As EventArgs) Handles btnAddScores.Click
        Dim scoresDialog = New StudentProfilesAddScores(scoresTable.NewScoresRow())
        scoresDialog.ShowDialog()
        If scoresDialog.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim newRow = scoresDialog.newScore
            newRow.StudentID = currentStudentID
            'Update scores record
            scoresTable.AddScoresRow(newRow)
            scoresAdapter.Update(scoresTable)
            'Update student record
            Dim studentRow = studentDataTable.FindByStudentID(currentStudentID)
            If newRow.Kills > newRow.Deaths Then
                studentRow.Wins += 1
            Else
                studentRow.Losses += 1
            End If
            studentRow.Kills += newRow.Kills
            studentRow.Deaths += newRow.Deaths
            studentAdapter.Update(studentDataTable)
            PopulateStatistics()
        End If
    End Sub

    Private Sub btnShowAbsences_Click(sender As Object, e As EventArgs) Handles btnShowAbsences.Click
        absencesPanel.Show()
        statsPanel.Hide()
    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click
        statsPanel.Show()
        absencesPanel.Hide()
    End Sub
End Class