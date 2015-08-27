Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Net
Public Class ForgotPW

    Public Shared Sub DisableForMyRequest(ByVal resource As Uri)
        Dim request As WebRequest = WebRequest.Create(resource)
        request.Proxy = Nothing
        Dim response As WebResponse = request.GetResponse()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = ("Next") Then
            Button1.Text = "Please Wait"
            Button1.Enabled = False
            Button2.Enabled = False
            Dim asql As String = "SELECT * FROM Logins WHERE (Username = '" & TextBox1.Text & "')"
            Dim acmd As New OleDbCommand(asql, RootForm.connection)
            Dim reader As OleDbDataReader
            Dim password As String
            Dim recoveryemail As String
            reader = acmd.ExecuteReader
            While reader.Read()
                password = reader("password").ToString
                recoveryemail = reader("RecoveryEmail").ToString
            End While

            Try
                Dim Smtp_Server As New SmtpClient
                Dim email As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("engardefencingmanager@gmail.com", "password?")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                email = New MailMessage()
                email.From = New MailAddress("engardefencingmanager@gmail.com")
                email.To.Add(recoveryemail)
                email.Subject = "Your Password"
                email.IsBodyHtml = True
                email.Body = ("Your Password is: " + password)

                Smtp_Server.Send(email)
                TextBox1.Visible = False
                Button1.Text = ("OK")
                Button1.Enabled = True
                Button2.Enabled = True
                Label2.Text = ("An email has been sent with your password.")
            Catch error_t As Exception
                MsgBox(error_t.ToString)
                'Me.Close()
                MsgBox("Email failed.")
            End Try
        ElseIf Button1.Text = "OK" Then
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class