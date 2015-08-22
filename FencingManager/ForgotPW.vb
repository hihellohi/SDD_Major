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
            If TextBox1.TextLength = 9 And IsNumeric(TextBox1.Text) Then
                Button1.Text = ("Please Wait")
                Button1.Enabled = False
                Button2.Enabled = False
                Label4.Visible = False

                Try
                    Dim Smtp_Server As New SmtpClient
                    Dim email As New MailMessage()
                    Smtp_Server.UseDefaultCredentials = False
                    Smtp_Server.Credentials = New Net.NetworkCredential("shithy15@gmail.com", "a123b765")
                    Smtp_Server.Port = 587
                    Smtp_Server.EnableSsl = True
                    Smtp_Server.Host = "smtp.gmail.com"

                    email = New MailMessage()
                    email.From = New MailAddress("shithy15@gmail.com")
                    email.To.Add(TextBox1.Text + "@student.sbhs.nsw.edu.au")
                    email.Subject = "Your Password"
                    email.IsBodyHtml = True
                    email.Body = ("Your Password is: 123456")

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
            Else : Label4.Visible = True
                TextBox1.Text = ("")
            End If
        Else : Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class