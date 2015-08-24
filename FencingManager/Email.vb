Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Net
Public Class Email

    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()

    Dim mode = 0

    Public Sub reload()
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
    End Sub


    Private Function sendOverdue()
        Dim hashtable As New Hashtable()
        Dim count As Integer = 0
        Dim things(RootForm.GearDataS.Tables("Gear").Rows.Count) As List(Of Integer)

        Dim tmp As DataRow
        For Each tmp In RootForm.GearDataS.Tables("Gear").Rows
            If tmp("StudentLoaned") <> 0 Then

                Dim due As New Date(tmp("DueYear"), tmp("DueMonth"), tmp("DueDay"))
                If due < Date.Today Then
                    If Not hashtable.Contains(tmp("StudentLoaned")) Then
                        hashtable.Add(tmp("StudentLoaned"), count)
                        count += 1
                        things(hashtable(tmp("StudentLoaned"))) = New List(Of Integer)
                    End If
                    things(hashtable(tmp("StudentLoaned"))).Add(tmp("ID") - 1)
                End If
            End If
        Next
        Dim tmpa As Integer
        For Each tmpa In hashtable.Keys
            Dim tmpb As DataRow
            For Each tmpb In dataS.Tables("StudentProfiles").Rows
                If tmpa = tmpb("StudentID") Then
                    'email
                    Try
                        'YUNO WORK
                        Dim Smtp_Server As New SmtpClient
                        Dim email As New MailMessage()
                        Smtp_Server.UseDefaultCredentials = False
                        Smtp_Server.Credentials = New Net.NetworkCredential("engardefencingmanager@gmail.com", "password?")
                        Smtp_Server.Port = 587
                        Smtp_Server.EnableSsl = True
                        Smtp_Server.Host = "smtp.gmail.com"

                        email = New MailMessage()
                        email.From = New MailAddress("engardefencingmanager@gmail.com")
                        email.To.Add(tmpb("Email"))
                        email.Subject = "Overdue Notice"
                        email.IsBodyHtml = True
                        email.Body = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body>You have loaned " + things(hashtable(tmpa)).Count.ToString() + " items from your fencing organisation that are overdue. Please return immediately"
                        email.Body += "<p><table><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
                        Dim iter As Integer
                        For Each iter In things(hashtable(tmpa))
                            email.Body += "<tr><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearID").ToString() + "</td><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearType").ToString() + "</td><td>"
                            email.Body += RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueDay").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueMonth").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueYear").ToString() + "</td></tr>"
                        Next
                        email.Body += "</table></p><p>This was an automated message. Do not reply to this email</p></body></html>"
                        'top kek
                        Smtp_Server.Send(email)
                    Catch error_t As Exception
                        MsgBox(error_t.ToString)
                        Return True
                    End Try
                End If
            Next
        Next
        Return False
    End Function

    Private Sub Button1_Click() Handles Button4.Click
        Button4.Text = "Please Wait..."
        Button4.BackgroundImage = My.Resources.spinner
        Button4.Enabled = False


        Dim fail = sendOverdue()
        'Timer2.Enabled = False
        If fail Then
            Button4.Text = "Failure!"
        Else
            Button4.Text = "Success!"
        End If
        Button4.BackgroundImage = Nothing
        Button4.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mode = 1 Then
            Button4.Left = Math.Min(Button4.Left + 10, 321)
            If Button4.Left = 321 Then
                Button3.Text = "Are you sure?"
                Timer1.Enabled = False
            End If
        ElseIf mode = 0 Then
            Button4.Left = Math.Max(Button4.Left - 10, 231)
            If Button4.Left = 231 Then
                Timer1.Enabled = False
                Button3.Text = "Send Overdue Notices"
                Button4.Text = "Yes"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mode = 1
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        mode = 1
        'Button3.Text = "Are you sure?"
    End Sub

    Private Sub Button3_LostFocus(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        mode = 0

        Timer1.Enabled = True

    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        mode = 1
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        mode = 0

        Timer1.Enabled = True
    End Sub


End Class