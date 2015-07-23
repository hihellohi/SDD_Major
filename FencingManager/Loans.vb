Public Class Loans

    Dim student As String
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()

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
                ListView1.Clear()
            End If
        End If
    End Sub

    Private Sub loadTable()
        ListView1.Items.Clear()
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            If row("StudentLoaned").ToString = student And row.RowState <> DataRowState.Deleted Then
                Dim rowItem = New ListViewItem(row("ID").ToString())
                rowItem.SubItems.Add(row("GearType"))
                rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
                Dim due As New Date(row("DueYear"), row("DueMonth"), row("DueDay"))
                If due < Date.Today Then
                    rowItem.BackColor = Color.Red
                ElseIf due = Date.Today Then
                    rowItem.BackColor = Color.Yellow
                End If
                ListView1.Items.Add(rowItem)
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
                        If RootForm.GearDataS.Tables("Gear").Rows(i).Item(0).ToString = TextBox1.Text Then
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
                                Label1.Text = "Item already loaned to " + Label1.Text = RootForm.GearDataS.Tables("Gear").Rows(i)("studentLoaned")
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

End Class