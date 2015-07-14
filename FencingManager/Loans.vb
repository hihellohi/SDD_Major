Public Class Loans
    Dim input As String
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
            End If
        End If
    End Sub

    Public Sub kbHook(ByVal key As System.Windows.Forms.Keys)
        If key = Keys.Enter Then
            If student = "" Then
                Dim tmp As Boolean = False
                For i = 0 To dataS.Tables("StudentProfiles").Rows.Count - 1
                    If dataS.Tables("StudentProfiles").Rows(i).Item(1).ToString = input Then
                        student = input
                        Label1.Text = dataS.Tables("StudentProfiles").Rows(i)("FirstName") + " " + dataS.Tables("StudentProfiles").Rows(i)("Surname")
                        tmp = True
                        ListView1.Clear()
                        Dim row As DataRow
                        For Each row In GearLoaning.dataS.Tables("Gear").Rows
                            If row("StudentLoaned").ToString = student Then
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
                input = ""
            Else
                'TBC
                Dim tmp As Boolean = True
                For i = 0 To GearLoaning.dataS.Tables("Gear").Rows.Count - 1
                    If GearLoaning.dataS.Tables("Gear").Rows(i).Item(0).ToString = input Then
                        If GearLoaning.dataS.Tables("Gear").Rows(i).Item(3) = 0 Then
                            Label1.Text = "Item not loaned"
                        Else
                            Label1.Text = GearLoaning.dataS.Tables("Gear").Rows(i).Item(1)
                            GearLoaning.dataS.Tables("Gear").Rows(i).Item(3) = 0
                            GearLoaning.dataS.Tables("Gear").Rows(i).Item(4) = 0
                            GearLoaning.dataS.Tables("Gear").Rows(i).Item(5) = 0
                            GearLoaning.dataS.Tables("Gear").Rows(i).Item(6) = 0
                            GearLoaning.adapter.Update(GearLoaning.dataS, "Gear")
                        End If
                        tmp = False
                    End If
                Next
                If tmp = True Then
                    Label1.Text = "item not found"
                End If
                input = ""
            End If
        Else
            input += Mid(key.ToString(), key.ToString().Length)
        End If
    End Sub


    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input = ""
        student = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        student = ""
    End Sub
End Class