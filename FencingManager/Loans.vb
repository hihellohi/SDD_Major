Public Class Loans

    Dim student As String
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()

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
                Label1.Text = "logged out"
                ListView1.Clear()
            End If
        End If
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
                        ListView1.Items.Clear()
                        Dim row As DataRow
                        For Each row In RootForm.GearDataS.Tables("Gear").Rows
                            'listview not adding things properly
                            If row("StudentLoaned").ToString = student And row.RowState <> DataRowState.Deleted Then
                                Dim rowItem = New ListViewItem(row("ID").ToString())
                                rowItem.SubItems.Add(row("GearType"))
                                rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
                                ListView1.Items.Add(rowItem)
                            End If
                        Next
                    End If
                Next
                If tmp = False Then
                    Label1.Text = "Student not Found"
                End If

            Else
                'TBC

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
        ListView1.Clear()
    End Sub

End Class