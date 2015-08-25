Public Class Loans

    Dim student As String
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()

    Dim sort As Integer = -1
    Dim old As String = ""
    Const HEAD_FONT As String = "trebuchet MS"
    Const BODY_FONT As String = "helvetica"

    Public Sub reload()
        'Reload the student dataset
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
        If student <> "" Then
            Dim found As Boolean = False
            For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                'check if student has been deleted
                If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = student Then
                    found = True
                End If
            Next
            If found = False Then
                'log out student if deleted
                student = ""
                grbInventory.Text = "logged out"
                lblOutput.Text = "Scan or input student ID to log in"
                btnLogout.Visible = False
                btnPrint.Visible = False
                btnPreview.Visible = False
                'ListView1.Items.Clear()

            End If
        End If
        loadTable()
    End Sub

    Private Sub loadTable()
        'Clear table

        tableList.Items.Clear()
        Dim row As DataRow
        lblTableCount.Text = 0
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            'find all records that are loaned to the student and load it into the table

            If row("StudentLoaned").ToString = student And row.RowState <> DataRowState.Deleted Then
                Dim rowItem = New ListViewItem(row("GearID").ToString())
                rowItem.SubItems.Add(row("GearType"))
                Dim due As New Date(row("DueYear"), row("DueMonth"), row("DueDay"))
                rowItem.SubItems.Add(due)
                If due < Date.Today Then
                    rowItem.BackColor = Color.Red
                ElseIf due = Date.Today Then
                    rowItem.BackColor = Color.Yellow
                End If
                tableList.Items.Add(rowItem)
                lblTableCount.Text += 1
            End If
        Next
    End Sub

    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim show = False
            e.SuppressKeyPress = True
            If student = "" Then
                'things to do when student is logged out

                Dim found As Boolean = False
                For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                    'find student
                    If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = txtInput.Text Then
                        student = txtInput.Text
                        grbInventory.Text = dataS.Tables("StudentProfiles").Rows(i)("FirstName") + " " + dataS.Tables("StudentProfiles").Rows(i)("Surname") + "'s Inventory"
                        lblOutput.Text = "Scan or input gear ID to loan"
                        found = True
                        btnLogout.Visible = True
                        btnPrint.Visible = True
                        btnPreview.Visible = True
                        loadTable()

                    End If
                Next
                If found = False Then
                    lblInputError.Text = "Student not Found"
                    show = True
                End If
            Else

                'Data validation
                Dim valid = True
                If rdbFor.Checked Then
                    If txtFor.Text = "" Then
                        valid = False
                    End If
                    If cmbFor.SelectedIndex = 0 Then
                        valid = False
                    End If
                    Label3.Visible = Not valid
                ElseIf Not datevalid() Then
                    valid = False
                    lblUntilError.Visible = True
                Else
                    lblUntilError.Visible = False
                End If


                If valid Then
                    Dim found As Boolean = False
                    For i = 0 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1

                        'find item with id matching input
                        If RootForm.GearDataS.Tables("Gear").Rows(i)("GearID").ToString = txtInput.Text Then
                            If RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = 0 Then
                                RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = student
                                If rdbFor.Checked Then

                                    'calculate loan length
                                    Dim cur As Date = Date.Today
                                    Select Case cmbFor.SelectedIndex
                                        Case 1
                                            cur = cur.AddDays(txtFor.Text)
                                        Case 2
                                            cur = cur.AddDays(txtFor.Text * 7)
                                        Case 3
                                            cur = cur.AddMonths(txtFor.Text)
                                        Case 4
                                            cur = cur.AddYears(txtFor.Text)
                                    End Select
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueDay") = cur.Day
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueMonth") = cur.Month
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueYear") = cur.Year
                                Else
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueDay") = cmbDay.SelectedIndex
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueMonth") = cmbMonth.SelectedIndex
                                    RootForm.GearDataS.Tables("Gear").Rows(i)("DueYear") = txtYear.Text
                                End If
                                RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")
                                loadTable()
                            Else
                                lblInputError.Text = "Item already loaned to " + RootForm.GearDataS.Tables("Gear").Rows(i)("studentLoaned").ToString
                                show = True
                            End If
                            found = True
                        End If
                    Next
                    If Not found Then
                        lblInputError.Text = "item not found"
                        show = True
                    End If
                End If
            End If

            txtInput.Text = ""
            lblInputError.Visible = show

        End If
    End Sub


    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialise
        txtInput.Text = ""
        student = ""
        SetCueText(txtFor, "Loan Length")
        SetCueText(txtYear, "Year")
        cmbFor.SelectedIndex = 0
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'log the student out
        student = ""
        btnLogout.Visible = False
        btnPrint.Visible = False
        btnPreview.Visible = True
        grbInventory.Text = "logged out"
        lblOutput.Text = "Scan or input student ID to log in"
        lblTableCount.Text = 0
        tableList.Items.Clear()
    End Sub

    Private Sub txtFor_TextChanged(sender As Object, e As EventArgs) Handles txtFor.TextChanged
        'data validation

        txtFor.Text = System.Text.RegularExpressions.Regex.Replace(txtFor.Text, "[^0-9]", "")
        txtFor.Select(txtFor.Text.Length, 0)

        'grammar check the combobox
        If txtFor.Text = "1" Then
            cmbFor.Items(1) = "Day"
            cmbFor.Items(2) = "Week"
            cmbFor.Items(3) = "Month"
            cmbFor.Items(4) = "Year"
        Else
            cmbFor.Items(1) = "Days"
            cmbFor.Items(2) = "Weeks"
            cmbFor.Items(3) = "Months"
            cmbFor.Items(4) = "Years"
        End If
    End Sub


    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        txtInput.Focus()
        old = txtInput.Text
        txtInput.Text = ""
        btnBarcode.BackColor = Color.Green
        btnBarcode.Text = "Scanning..."
    End Sub


    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        btnManual.Visible = False
        txtInput.Focus()
    End Sub

    Private Sub txtInput_LostFocus(sender As Object, e As EventArgs) Handles txtInput.LostFocus
        'When textbox is clicked away
        If btnManual.Visible Then
            txtInput.Text = old
        End If
        btnManual.Visible = True
        btnBarcode.BackColor = btnManual.BackColor
        btnBarcode.Text = "Use Barcode Scanner"
    End Sub

    Private Function datevalid()
        'validate that the date in the combobox exists
        If txtYear.Text = "" Then
            Return False
        End If
        'check Year is correct
        If cmbDay.SelectedIndex = 0 Or cmbMonth.SelectedIndex = 0 Or txtYear.Text < 1000 Or txtYear.Text > 9999 Then
            Return False
        End If
        'check 31 day months
        If cmbDay.SelectedIndex > 31 Then
            Return False
        End If
        'check 30 day months
        Dim thirty() = {4, 6, 9, 11}
        For i = 0 To 3
            If cmbMonth.SelectedIndex = thirty(i) And cmbDay.SelectedIndex = 31 Then
                Return False
            End If
        Next
        'check leap years
        If cmbMonth.SelectedIndex = 2 Then
            If (txtYear.Text Mod 400 = 0 Or (txtYear.Text Mod 4 = 0 And (Not txtYear.Text Mod 100 = 0))) Then
                If cmbDay.SelectedIndex = 30 Then
                    Return False
                End If
            ElseIf cmbDay.SelectedIndex > 28 Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub rdbUntil_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUntil.CheckedChanged
        cmbDay.Enabled = rdbUntil.Checked
        cmbMonth.Enabled = rdbUntil.Checked
        txtYear.Enabled = rdbUntil.Checked
        txtFor.Enabled = rdbFor.Checked
        cmbFor.Enabled = rdbFor.Checked
        Label3.Visible = rdbFor.Checked And Label3.Visible
        lblUntilError.Visible = rdbUntil.Checked And lblUntilError.Visible
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        'data validation
        txtYear.Text = System.Text.RegularExpressions.Regex.Replace(txtYear.Text, "[^0-9]", "")
        txtYear.Select(txtYear.Text.Length, 0)
    End Sub


    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            'make header
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            'make title
            out += "<font face=""" + HEAD_FONT + """ size = 6>L</font><font face=""" + HEAD_FONT + """ size = 5>OANED</font>"
            out += " <font face=""" + HEAD_FONT + """ size = 6>I</font><font face=""" + HEAD_FONT + """ size = 5>TEMS"
            out += " FOR " + student + "</font></p>"
            'make table
            out += "<font face=""" + BODY_FONT + """ size = 4><p><table width=""500"" align=""center""><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
            For Each item In tableList.Items
                out += "<tr align=""center""><td>" + item.SubItems(0).Text.ToString + "</td><td>" + item.SubItems(1).Text.ToString + "</td><td>" + item.SubItems(2).Text.ToString + "</td></tr>"
            Next
            out += "</table></p></font></body></html>"
            tmp.Document.Write(out)
            tmp.ShowPrintPreviewDialog()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            'make header
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            'make title
            out += "<font face=""" + HEAD_FONT + """ size = 6>L</font><font face=""" + HEAD_FONT + """ size = 5>OANED</font>"
            out += " <font face=""" + HEAD_FONT + """ size = 6>I</font><font face=""" + HEAD_FONT + """ size = 5>TEMS"
            out += " FOR " + student + "</font></p>"
            'make table
            out += "<font face=""" + BODY_FONT + """ size = 4><p><table width=""500"" align=""center""><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
            For Each item In tableList.Items
                out += "<tr align=""center""><td>" + item.SubItems(0).Text.ToString + "</td><td>" + item.SubItems(1).Text.ToString + "</td><td>" + item.SubItems(2).Text.ToString + "</td></tr>"
            Next
            out += "</table></p></font></body></html>"
            tmp.Document.Write(out)

            tmp.Print()
        End If
    End Sub
End Class
