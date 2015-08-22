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
        Dim things(RootForm.GearDataS.Tables("Gear").Rows.Count) As Integer
        Dim tmp As DataRow
        For Each tmp In RootForm.GearDataS.Tables("Gear").Rows
            If tmp("StudentLoaned") <> 0 Then

                Dim due As New Date(tmp("DueYear"), tmp("DueMonth"), tmp("DueDay"))
                If due < Date.Today Then
                    If hashtable.Contains(tmp("StudentLoaned")) Then
                        things(hashtable(tmp("StudentLoaned"))) += 1
                    Else
                        hashtable.Add(tmp("StudentLoaned"), count)
                        count += 1
                        things(hashtable(tmp("StudentLoaned"))) = 1
                    End If
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
                        email.Body = "<html>You have loaned " + things(hashtable(tmpa)).ToString() + " items from your fencing organisation that are overdue. Please return immediately</html>"

                        Smtp_Server.Send(email)
                    Catch error_t As Exception
                        MsgBox(error_t.ToString)
                        MsgBox("Email failed.")
                    End Try
                End If
            Next
        Next
    End Sub

End Class