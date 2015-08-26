Public Class StudentProfilesForm

    'Dim connection As OleDb.OleDbConnection
    Public adapter As New OleDb.OleDbDataAdapter
    Public searchResults As New DataSet()

    Private adapter1 As FencingDataSetTableAdapters.StudentProfilesTableAdapter
    Private studentDataTable As New FencingDataSet.StudentProfilesDataTable()
    Dim sortColumn As Integer
    Dim sortAscending As Boolean = True
    Dim sortSql As String = "Surname, FirstName"
    Dim searchInitiated As Boolean = False

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 1 Then
            LoadSimpleProfile(ListView1.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub ResetSimpleProfile()
        lblName.Text = "Name: "
        lblSchoolYear.Text = "Year "
        lblWeapon.Text = "Weapon: "
        lblWinPercent.Text = "Wins Percentage: "
        lblKDR.Text = "Kill/Death Ratio: "
        btnMore.Enabled = False
    End Sub

    Private Function WeaponText(num As Integer) As String
        Select Case num
            Case 1
                Return "Foil"
            Case 2
                Return "Sabre"
            Case 3
                Return "Epee"
            Case Else
                Return "?"
        End Select
    End Function

    Private Sub LoadSimpleProfile(studentID As Integer)
        Dim row As FencingDataSet.StudentProfilesRow
        row = studentDataTable.FindByStudentID(studentID)
        lblName.Text = "Name: " + row.FirstName + " " + row.Surname.ToUpper()
        lblSchoolYear.Text = "Year " + row.SchoolYear.ToString()
        lblWeapon.Text = "Weapon: " + WeaponText(row.Weapon)
        If row.Wins + row.Losses > 0 Then
            Dim winPercent = row.Wins / (row.Wins + row.Losses) * 100
            lblWinPercent.Text = "Wins Percentage: " + Math.Round(winPercent, 2).ToString() + "%"
            Dim ratio As Double
            If row.Deaths > 0 Then
                ratio = row.Kills / row.Deaths
            Else
                ratio = row.Kills / 1.0
            End If
            lblKDR.Text = "Kill/Death Ratio: " + Math.Round(ratio, 3).ToString()
        Else
            lblWinPercent.Text = "Wins Percentage: N/A"
            lblKDR.Text = "Kill/Death Ratio: N/A"
            btnMore.Enabled = True
        End If
    End Sub

    Private Sub StudentProfilesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbbYear.SelectedIndex = 0
    End Sub

    Private Sub StudentProfilesForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            RefreshTables()
            searchInitiated = False
        End If
    End Sub

    Private Sub RefreshTables()
        adapter1 = New FencingDataSetTableAdapters.StudentProfilesTableAdapter()
        adapter1.ClearBeforeFill = True
        adapter1.Fill(studentDataTable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchQuery()
        searchInitiated = True
    End Sub

    Private Sub SearchQuery()
        ListView1.Items.Clear()
        ResetSimpleProfile()

        Dim filter = ""
        If chkFilter.Checked = False Or TextBox1.Text = "" Then
            filter = "(FirstName LIKE '{0}' + '%' OR Surname LIKE '{1}' + '%' OR FirstName + ' ' + Surname LIKE '{0}' + '%')"
            filter = String.Format(filter, TextBox1.Text, TextBox1.Text, TextBox1.Text)
        ElseIf rdbFirstName.Checked Then
            filter = "FirstName LIKE '{0}' + '%'"
            filter = String.Format(filter, TextBox1.Text)
        ElseIf rdbSurname.Checked Then
            filter = "Surname LIKE '{0}' + '%'"
            filter = String.Format(filter, TextBox1.Text)
        ElseIf rdbID.Checked Then
            filter = "StudentID > 0"
        End If
        If chkUnexplainedAb.Checked Then
            filter += " AND unexplainedAbsences > 0"
        End If
        If rdbJunior.Checked Then
            filter += " AND YearGroup = 0"
        ElseIf rdbSenior.Checked Then
            filter += " AND YearGroup = 1"
        ElseIf rdbSelectYear.Checked Then
            filter += " AND SchoolYear = " + cbbYear.Text
        End If


        For Each row As FencingDataSet.StudentProfilesRow In studentDataTable.Select(filter, sortSql)
            If row.RowState <> DataRowState.Deleted Then
                Dim rowItem = New ListViewItem(row.StudentID.ToString())
                rowItem.SubItems.Add(row.Surname.ToString())
                rowItem.SubItems.Add(row.FirstName.ToString())
                rowItem.SubItems.Add(row.SchoolYear.ToString())
                ListView1.Items.Add(rowItem)
            End If
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedIndices.Count = 1 Then

        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newRow As FencingDataSet.StudentProfilesRow
        newRow = studentDatatable.NewStudentProfilesRow()
        Dim formNew As New StudentProfilesCreate(newRow)
        formNew.ShowDialog()
        If formNew.DialogResult = Windows.Forms.DialogResult.Yes Then
            studentDatatable.AddStudentProfilesRow(formNew.newRow)
            adapter1.Update(studentDatatable)
        End If
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If sortColumn = e.Column Then
            sortAscending = Not sortAscending
        Else
            sortColumn = e.Column
            sortAscending = True
        End If
        Dim order As String
        If sortAscending Then
            order = "ASC"
        Else
            order = "DESC"
        End If
        Select Case e.Column
            Case 0 'StudentID
                sortSql = "StudentID " + order + ", Surname, FirstName"
            Case 1 'Surname
                sortSql = "Surname " + order + ", FirstName"
            Case 2 'FirstName
                sortSql = "FirstName " + order + ", Surname"
            Case 3 'Year
                sortSql = "SchoolYear " + order + ", Surname, FirstName"
        End Select
        If searchInitiated Then
            SearchQuery()
        End If
    End Sub

    Private Sub Filters_Changed(sender As Object, e As EventArgs) Handles rdbFirstName.CheckedChanged, rdbSurname.CheckedChanged,
        rdbID.CheckedChanged, chkUnexplainedAb.CheckedChanged, rdbAll.CheckedChanged, rdbJunior.CheckedChanged, rdbSenior.CheckedChanged, rdbSelectYear.CheckedChanged,
        cbbYear.SelectedIndexChanged

        If rdbSelectYear.Checked Then
            cbbYear.Enabled = True
        Else
            cbbYear.Enabled = False
        End If
        If searchInitiated Then
            SearchQuery()
        End If
    End Sub

    Private Sub chkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilter.CheckedChanged
        If chkFilter.Checked = True Then
            rdbFirstName.Enabled = True
            rdbSurname.Enabled = True
            rdbID.Enabled = True
            rdbFirstName.Checked = True
        Else
            rdbFirstName.Enabled = False
            rdbFirstName.Checked = False
            rdbSurname.Enabled = False
            rdbSurname.Checked = False
            rdbID.Enabled = False
            rdbAll.Checked = False
        End If
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click

    End Sub
End Class