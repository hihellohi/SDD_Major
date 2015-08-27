Imports System.Data.OleDb

Public Class Login
    Dim formForgotPW As New ForgotPW()
    'Dim formAdministration As New Admistration
    Dim loggedin = False


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
            RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] " + GlobalVariables.Username + " has logged in")
            loggedin = True

        Catch ex As NullReferenceException
            'wrong password
            MsgBox("Username or Password incorrect")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel


            FencingManager.Admin.RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)
            RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] " + TextBox1.Text + " tried to log in with incorrect password")



        Catch ex1 As Exception
            ' Catch database connection or query errors:
            MsgBox(ex1.Message)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel

        End Try
        If loggedin = True Then
            Dim asql As String = "SELECT * FROM Logins WHERE (Username = '" & GlobalVariables.Username & "')"
            Dim acmd As New OleDbCommand(asql, RootForm.connection)
            Dim reader As OleDbDataReader
            reader = acmd.ExecuteReader
            While reader.Read()
                RootForm.access_level = reader("AccessLevel").ToString
            End While
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            CheckBox2.Visible = False
            Label4.Visible = True
            usr.Visible = True
            usr.Text = GlobalVariables.Username
            btnOff.Visible = True
        Else
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            CheckBox2.Visible = True
            Label4.Visible = False
            usr.Visible = False
            btnOff.Visible = False

        End If
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

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        loggedin = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        CheckBox2.Visible = True
        Label4.Visible = False
        usr.Visible = False
        btnOff.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        GlobalVariables.Username = Nothing
        RootForm.access_level = 0
    End Sub
End Class

Public Class GlobalVariables
    Public Shared Username As String
    Public Shared Password As String
End Class
