Public Class AttendanceForm

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

    Private Sub FillRoll()
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
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        SplitContainer1.Panel1.Enabled = False
        FillRoll()        
        SplitContainer1.Panel2.Enabled = True
        titleLabel.Text = "Attendance Check - Roll"
    End Sub

    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        btnHelp.Hide()
        SplitContainer1.Panel1.Enabled = False
        FillRoll()
        SplitContainer1.Panel2.Enabled = True
        barcodePanel.Show()
        lblScanMsg.Text = ""
        txtBarcode.Focus()
        For i = 0 To roll.Items.Count - 1
            roll.SetItemChecked(i, True)
        Next
        titleLabel.Text = "Attendance Check - Barcode Scan"
    End Sub

    Private Sub Reset()
        roll.Items.Clear()
        lblTotal.Text = ""
        lblAbsent.Text = ""
        lblPresent.Text = ""
        SplitContainer1.Panel2.Enabled = False
        SplitContainer1.Panel1.Enabled = True
        barcodePanel.Hide()
        titleLabel.Text = "Attendance Check"
        panelHelp2.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reset()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
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
        Dim row As FencingDataSet.StudentProfilesRow
        While i < roll.Items.Count
            row = studentDataTable.FindByStudentID(rowItems(i).StudentID)
            If roll.GetItemChecked(i) Then 'Student is absent
                row.totalAbsences += 1
                row.unexplainedAbsences += 1
                Dim absenceRecord = absencesTable.NewAbsencesRow()
                absenceRecord.AbsenceDate = DateTimePicker1.Value
                absenceRecord.StudentID = row.StudentID
                absenceRecord.Explained = False
                absenceRecord.Explanation = ""
                absencesTable.AddAbsencesRow(absenceRecord)
            Else
                row.totalPresences += 1
            End If
            i = i + 1
        End While
        studentAdapter.Update(studentDataTable)
        absencesAdapter.Update(absencesTable)
        RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] roll marked by " & GlobalVariables.Username & "with " & lblAbsent.Text & "absent")
        Reset()
        titleLabel.Text = "Attendance Check - Saved"
        btnSave.Text = "Saved"
        Timer1.Start()
    End Sub

    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave
        txtBarcode.Focus()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        btnHelp.Show()
        barcodePanel.Hide()
        titleLabel.Text = "Attendance Check - Confirm"
    End Sub

    Private Sub btnEnterBarcode_Click(sender As Object, e As EventArgs) Handles btnEnterBarcode.Click
        If IsNumeric(txtBarcode.Text) Then
            Dim scannedID As Integer = txtBarcode.Text
            Dim found = False
            Dim i = 0
            While found = False And i < roll.Items.Count
                If rowItems(i).StudentID = scannedID Then
                    roll.SetItemChecked(i, False)
                    found = True
                End If
                i = i + 1
            End While
            lblScanMsg.Text = txtBarcode.Text + "   " + Now.Hour.ToString() + ":" + Now.Minute.ToString()
            txtBarcode.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        titleLabel.Text = "Attendance Check"
        btnSave.Text = "Save"
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        If SplitContainer1.Panel1.Enabled Then
            panelHelp1.Visible = Not panelHelp1.Visible
        Else
            panelHelp2.Visible = Not panelHelp2.Visible
        End If
    End Sub
End Class