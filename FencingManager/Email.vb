Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Net
Public Class Email

    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()

    Public Sub reload()
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
    End Sub


    Private Sub Button1_Click() Handles Button4.Click
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
                        MsgBox("Email failed.")
                    End Try
                End If
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class