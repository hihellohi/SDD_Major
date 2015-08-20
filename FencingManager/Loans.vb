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
                Label1.Text = "logged out"
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
            End If
        Next
    End Sub

    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If student = "" Then
                Dim tmp As Boolean = False
                For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                    If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = TextBox1.Text Then
                        student = TextBox1.Text
                        Label1.Text = dataS.Tables("StudentProfiles").Rows(i)("FirstName") + " " + dataS.Tables("StudentProfiles").Rows(i)("Surname")
                        tmp = True
                        loadTable()
                        
                    End If
                Next
                If tmp = False Then
                    Label1.Text = "Student not Found"
                End If

            Else
                Dim valid = True
                If TextBox2.Text = "" Then
                    TextBox2.BackColor = Color.Red
                    valid = False
                Else
                    TextBox2.BackColor = Color.White
                End If
                If ComboBox1.SelectedIndex = -1 Then
                    ComboBox1.BackColor = Color.Red
                    valid = False
                Else
                    ComboBox1.BackColor = Color.White
                End If
                If valid Then
                    Dim tmp As Boolean = True
                    For i = 0 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
                        If RootForm.GearDataS.Tables("Gear").Rows(i)("GearID").ToString = TextBox1.Text Then
                            If RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = 0 Then
                                RootForm.GearDataS.Tables("Gear").Rows(i)("StudentLoaned") = student
                                Dim cur As Date = Date.Today
                                Select Case ComboBox1.SelectedIndex
                                    Case 0
                                        cur = cur.AddDays(TextBox2.Text)
                                    Case 1
                                        cur = cur.AddDays(TextBox2.Text * 7)
                                    Case 2
                                        cur = cur.AddMonths(TextBox2.Text)
                                    Case 3
                                        cur = cur.AddYears(TextBox2.Text)
                                End Select

                                RootForm.GearDataS.Tables("Gear").Rows(i)("DueDay") = cur.Day
                                RootForm.GearDataS.Tables("Gear").Rows(i)("DueMonth") = cur.Month
                                RootForm.GearDataS.Tables("Gear").Rows(i)("DueYear") = cur.Year
                                RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")
                                loadTable()
                            Else
                                Label1.Text = "Item already loaned to " + RootForm.GearDataS.Tables("Gear").Rows(i)("studentLoaned").ToString
                            End If
                            tmp = False
                        End If
                    Next
                    If tmp = True Then
                        Label1.Text = "item not found"
                    End If
                End If
            End If
            TextBox1.Text = ""
        End If
    End Sub


    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        student = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        student = ""
        Label1.Text = "logged out"
        ListView1.Items.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = System.Text.RegularExpressions.Regex.Replace(TextBox2.Text, "[^0-9]", "")
        TextBox2.Select(TextBox2.Text.Length, 0)
        If TextBox2.Text = "1" Then
            ComboBox1.Items(0) = "Day"
            ComboBox1.Items(1) = "Week"
            ComboBox1.Items(2) = "Month"
            ComboBox1.Items(3) = "Year"
        Else
            ComboBox1.Items(0) = "Days"
            ComboBox1.Items(1) = "Weeks"
            ComboBox1.Items(2) = "Months"
            ComboBox1.Items(3) = "Years"
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedIndices.Count = 1 Then
            Dim iter As DataRow
            For Each iter In RootForm.GearDataS.Tables("Gear").Rows
                If iter("ID") = things(ListView1.SelectedIndices(0)) Then
                    MsgBox(iter("ID"))
                    'Do things
                End If
            Next
        End If
    End Sub

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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
