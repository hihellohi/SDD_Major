Imports System.Data.OleDb

Public Class Login
    Dim formForgotPW As New ForgotPW()
    'Dim formAdministration As New Admistration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formForgotPW.ShowDialog()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If CheckBox2.Checked Then
            SaveSetting("Login Screen", "Login", "TextBox1", TextBox1.Text)
            SaveSetting("Login Screen", "Login", "CheckBox2", CheckBox2.Checked = True)
        Else : SaveSetting("Login Screen", "Login", "TextBox1", "")
            SaveSetting("Login Screen", "Login", "CheckBox2", CheckBox2.Checked = False)
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Connection
        'Dim conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\SDD_Major-master\FencingManager\Fencing.accdb")
        ' Query, Parameters
        Dim sql As String = "SELECT USERNAME FROM Logins WHERE USERNAME=@p_userid AND PASSWORD=@p_passw;"
        Dim cmd As New OleDbCommand(sql, RootForm.connection)

        ' Add parameters
        With cmd
            .Parameters.AddWithValue("p_userid", TextBox1.Text)
            .Parameters.AddWithValue("p_passw", TextBox2.Text)
        End With

        ' Perform Query
        Try
            Dim usr As String = cmd.ExecuteScalar.ToString
            Dim pw As String = cmd.ExecuteScalar.ToString
            If Not (IsDBNull(usr)) AndAlso usr = TextBox1.Text Then
                GlobalVariables.Username = TextBox1.Text
                GlobalVariables.Password = TextBox2.Text
                MsgBox("Login Success", MsgBoxStyle.OkOnly)   ' User Found, PW Match
                ' Admistration.Show()
            ElseIf Not (IsDBNull(usr)) AndAlso pw <> TextBox2.Text Then
                'This doesnt work
                MsgBox("Username or Password Wrong", MsgBoxStyle.OkOnly)
            End If
            FencingManager.Admin.RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)
            My.Computer.FileSystem.WriteAllText("edits.txt", "[" + DateString + " " + TimeOfDay + "] " + GlobalVariables.Username + " logged in" & Environment.NewLine, True)

        Catch ex As NullReferenceException
            'wrong password
            MsgBox("Username or Password incorrect")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            FencingManager.Admin.RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)
            My.Computer.FileSystem.WriteAllText("edits.txt", "[" + DateString + " " + TimeOfDay + "] " + TextBox1.Text + " tried to log in with incorrect password" & Environment.NewLine, True)

            Dim asql As String = "SELECT AccessLevel FROM Logins WHERE Username=" + GlobalVariables.Username
            Dim acmd As New OleDbCommand(asql, RootForm.connection)

            With acmd
                RootForm.access_level = acmd.ExecuteScalar.ToString
            End With

        Catch ex1 As Exception
            ' Catch database connection or query errors:
            MsgBox(ex1.Message)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CreateAcc.ShowDialog()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = GetSetting("Login Screen", "Login", "TextBox1")
        If TextBox1.Text <> "" Then
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    ' Form99.ShowDialog()
    'End Sub

    ' Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '     Me.WindowState = FormWindowState.Minimized
    ' End Sub

End Class

Public Class GlobalVariables
    Public Shared Username As String
    Public Shared Password As String
End Class
