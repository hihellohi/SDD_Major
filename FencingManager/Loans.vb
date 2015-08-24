Public Class Loans

    Dim student As String
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()
    Dim things As ArrayList = New ArrayList
    Dim sort As Integer = -1
    Dim old As String = ""
    Const HEAD_FONT As String = "trebuchet MS"
    Const BODY_FONT As String = "helvetica"

    Public Sub reload()

        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
        If student <> "" Then
            Dim tmp As Boolean = False
            For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = student Then
                    tmp = True
                End If
            Next
            If tmp = False Then
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
        tableList.Items.Clear()
        things.Clear()
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            If row("StudentLoaned").ToString = student And row.RowState <> DataRowState.Deleted Then
                Dim rowItem = New ListViewItem(row("GearID").ToString())
                rowItem.SubItems.Add(row("GearType"))
                'rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
                Dim due As New Date(row("DueYear"), row("DueMonth"), row("DueDay"))
                rowItem.SubItems.Add(due)
                If due < Date.Today Then
                    rowItem.BackColor = Color.Red
                ElseIf due = Date.Today Then
                    rowItem.BackColor = Color.Yellow
                End If
                tableList.Items.Add(rowItem)
                things.Add(row("ID"))
                lblTableCount.Text += 1
            End If
        Next
    End Sub

    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim show = False
            e.SuppressKeyPress = True
            If student = "" Then
                Dim tmp As Boolean = False
                For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                    If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = txtInput.Text Then
                        student = txtInput.Text
                        grbInventory.Text = dataS.Tables("StudentProfiles").Rows(i)("FirstName") + " " + dataS.Tables("StudentProfiles").Rows(i)("Surname") + "'s Inventory"
                        lblOutput.Text = "Scan or input gear ID to loan"
                        tmp = True
                        btnLogout.Visible = True
                        btnPrint.Visible = True
                        btnPreview.Visible = True
                        loadTable()

                    End If
                Next
                If tmp = False Then
                    lblInputError.Text = "Student not Found"
                    show = True
                End If

            Else
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
                    Dim tmp As Boolean = True
                    For i = 0 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
                        If RootForm.GearDataS.Tables("Gear").Rows(i)("GearID").ToString = txtInput.Text Then
                            If RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = 0 Then
                                RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = student
                                If rdbFor.Checked Then
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
                            tmp = False
                        End If
                    Next
                    If tmp = True Then
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
        txtInput.Text = ""
        student = ""
        SetCueText(txtFor, "Loan Length")
        SetCueText(txtyear, "Year")
        cmbFor.SelectedIndex = 0
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        student = ""
        btnLogout.Visible = False
        btnPrint.Visible = False
        btnPreview.Visible = True
        grbInventory.Text = "logged out"
        lblOutput.Text = "Scan or input student ID to log in"
        lblTableCount.Text = 0
        tableList.Items.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtFor.TextChanged
        txtFor.Text = System.Text.RegularExpressions.Regex.Replace(txtFor.Text, "[^0-9]", "")
        txtFor.Select(txtFor.Text.Length, 0)
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

    'Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
    '    If ListView1.SelectedIndices.Count = 1 Then
    '        Dim iter As DataRow
    '        For Each iter In RootForm.GearDataS.Tables("Gear").Rows
    '            If iter("ID") = things(ListView1.SelectedIndices(0)) Then

    '                GearLoaning.btnCatalog_Click()
    '                GearLoaning.frmCatalog.selected = iter("ID") - 1
    '            End If
    '        Next
    '    End If
    'End Sub

    '    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick


    '        For i = 1 To ListView1.Items.Count - 1
    '            Dim tmp As ListViewItem = ListView1.Items(i)
    '            For j = i - 1 To 0
    '                If comp(ListView1.Items(j), tmp, e.Column) And j <> 0 Then
    '                    ListView1.Items(j + 1) = ListView1.Items(j)
    '                Else
    '                    ListView1.Items(j + 1) = tmp
    '                    GoTo endoffor
    '                End If
    '            Next
    'endoffor:
    '        Next
    '    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        txtInput.Focus()
        old = txtInput.Text
        txtInput.Text = ""
        btnBarcode.BackColor = Color.Green
        btnBarcode.Text = "Scanning..."
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        btnManual.Visible = False
        txtInput.Focus()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles txtInput.LostFocus
        If btnManual.Visible Then
            txtInput.Text = old
        End If
        btnManual.Visible = True
        btnBarcode.BackColor = btnManual.BackColor
        btnBarcode.Text = "Use Barcode Scanner"
    End Sub

    Private Function datevalid()
        If txtYear.Text = "" Then
            Return False
        End If
        If cmbDay.SelectedIndex = 0 Or cmbMonth.SelectedIndex = 0 Or txtYear.Text < 1000 Or txtYear.Text > 9999 Then
            Return False
        End If
        If cmbDay.SelectedIndex > 31 Then
            Return False
        End If
        Dim thirty() = {4, 6, 9, 11}
        For i = 0 To 3
            If cmbMonth.SelectedIndex = thirty(i) And cmbDay.SelectedIndex = 31 Then
                Return False
            End If
        Next
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUntil.CheckedChanged
        cmbDay.Enabled = rdbUntil.Checked
        cmbMonth.Enabled = rdbUntil.Checked
        txtYear.Enabled = rdbUntil.Checked
        txtFor.Enabled = rdbFor.Checked
        cmbFor.Enabled = rdbFor.Checked
        Label3.Visible = rdbFor.Checked And Label3.Visible
        lblUntilError.Visible = rdbUntil.Checked And lblUntilError.Visible
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        txtYear.Text = System.Text.RegularExpressions.Regex.Replace(txtYear.Text, "[^0-9]", "")
        txtYear.Select(txtYear.Text.Length, 0)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            out += "<font face=""" + HEAD_FONT + """ size = 6>L</font><font face=""" + HEAD_FONT + """ size = 5>OANED</font>"
            out += " <font face=""" + HEAD_FONT + """ size = 6>I</font><font face=""" + HEAD_FONT + """ size = 5>TEMS"
            out += " FOR " + student + "</font></p>"
            out += "<font face=""" + BODY_FONT + """ size = 4><p><table width=""500"" align=""center""><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
            For Each item In tableList.Items
                out += "<tr align=""center""><td>" + item.SubItems(0).Text.ToString + "</td><td>" + item.SubItems(1).Text.ToString + "</td><td>" + item.SubItems(2).Text.ToString + "</td></tr>"
            Next
            out += "</table></p></font></body></html>"
            tmp.Document.Write(out)
            tmp.ShowPrintPreviewDialog()
        End If



    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            out += "<font face=""" + HEAD_FONT + """ size = 6>L</font><font face=""" + HEAD_FONT + """ size = 5>OANED</font>"
            out += " <font face=""" + HEAD_FONT + """ size = 6>I</font><font face=""" + HEAD_FONT + """ size = 5>TEMS"
            out += " FOR " + student + "</font></p>"
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
