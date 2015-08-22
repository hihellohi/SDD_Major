Public Class Loans

    Dim student As String
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()
    Dim things As ArrayList = New ArrayList
    Dim sort As Integer = -1

    Public Sub reload()
        loadTable()
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
                GroupBox1.Text = "logged out"
                Label2.Text = "Scan or input student ID to log in"
                'ListView1.Items.Clear()

            End If
        End If
    End Sub

    Private Sub loadTable()
        ListView1.Items.Clear()
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
                ListView1.Items.Add(rowItem)
                things.Add(row("ID"))
                Label10.Text += 1
            End If
        Next
    End Sub

    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim show = False
            e.SuppressKeyPress = True
            If student = "" Then
                Dim tmp As Boolean = False
                For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                    If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = TextBox1.Text Then
                        student = TextBox1.Text
                        GroupBox1.Text = dataS.Tables("StudentProfiles").Rows(i)("FirstName") + " " + dataS.Tables("StudentProfiles").Rows(i)("Surname") + "'s Inventory"
                        Label2.Text = "Scan or input gear ID to loan"
                        tmp = True
                        loadTable()
                        Button1.Visible = True
                    End If
                Next
                If tmp = False Then
                    Label1.Text = "Student not Found"
                    show = True
                End If

            Else
                Dim valid = True
                If RadioButton1.Checked Then
                    If TextBox2.Text = "" Then
                        valid = False
                    End If
                    If ComboBox1.SelectedIndex = 0 Then
                        valid = False
                    End If

                    Label3.Visible = Not valid

                ElseIf Not datevalid() Then
                    valid = False
                    Label4.Visible = True
                Else
                    Label4.Visible = False
                End If
                If valid Then
                    Dim tmp As Boolean = True
                    For i = 0 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
                        If RootForm.GearDataS.Tables("Gear").Rows(i)("GearID").ToString = TextBox1.Text Then
                            If RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = 0 Then
                                RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = student
                                If RadioButton1.Checked Then
                                    Dim cur As Date = Date.Today
                                    Select Case ComboBox1.SelectedIndex
                                        Case 1
                                            cur = cur.AddDays(TextBox2.Text)
                                        Case 2
                                            cur = cur.AddDays(TextBox2.Text * 7)
                                        Case 3
                                            cur = cur.AddMonths(TextBox2.Text)
                                        Case 4
                                            cur = cur.AddYears(TextBox2.Text)
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
                                Label1.Text = "Item already loaned to " + RootForm.GearDataS.Tables("Gear").Rows(i)("studentLoaned").ToString
                                show = True
                            End If
                                tmp = False
                            End If
                    Next
                    If tmp = True Then
                        Label1.Text = "item not found"
                        show = True
                    End If
                End If
                End If
                TextBox1.Text = ""

                Label1.Visible = show

        End If
    End Sub


    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        student = ""
        SetCueText(TextBox2, "Loan Length")
        SetCueText(txtyear, "Year")
        ComboBox1.SelectedIndex = 0
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        student = ""
        Button1.Visible = False
        GroupBox1.Text = "logged out"
        Label2.Text = "Scan or input student ID to log in"
        Label10.Text = 0
        ListView1.Items.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = System.Text.RegularExpressions.Regex.Replace(TextBox2.Text, "[^0-9]", "")
        TextBox2.Select(TextBox2.Text.Length, 0)
        If TextBox2.Text = "1" Then
            ComboBox1.Items(1) = "Day"
            ComboBox1.Items(2) = "Week"
            ComboBox1.Items(3) = "Month"
            ComboBox1.Items(4) = "Year"
        Else
            ComboBox1.Items(1) = "Days"
            ComboBox1.Items(2) = "Weeks"
            ComboBox1.Items(3) = "Months"
            ComboBox1.Items(4) = "Years"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Focus()
        Button2.BackColor = Color.Green
        Button2.Text = "Scanning..."
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Button3.Visible = True
        Button2.BackColor = Button3.BackColor
        Button2.Text = "Use Barcode Scanner"
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cmbDay.Enabled = RadioButton2.Checked
        cmbMonth.Enabled = RadioButton2.Checked
        txtYear.Enabled = RadioButton2.Checked
        TextBox2.Enabled = RadioButton1.Checked
        ComboBox1.Enabled = RadioButton1.Checked
        Label3.Visible = RadioButton1.Checked And Label3.Visible
        Label4.Visible = RadioButton2.Checked And Label4.Visible
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        txtYear.Text = System.Text.RegularExpressions.Regex.Replace(txtYear.Text, "[^0-9]", "")
        txtYear.Select(txtYear.Text.Length, 0)
    End Sub


End Class
