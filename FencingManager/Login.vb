﻿Imports System.Data.OleDb

Public Class Login
    Dim formForgotPW As New ForgotPW()
    'Dim formAdministration As New Admistration
    Dim loggedin = False


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        formForgotPW.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Query, Parameters
        Dim sql As String = "SELECT USERNAME FROM Logins WHERE USERNAME=@p_userid AND PASSWORD=@p_passw;"
        Dim cmd As New OleDbCommand(sql, RootForm.connection)

        ' Add parameters
        With cmd
            .Parameters.AddWithValue("p_userid", txtUser.Text)
            .Parameters.AddWithValue("p_passw", txtPW.Text)
        End With

        ' Perform Query
        Try
            Dim usr As String = cmd.ExecuteScalar.ToString
            Dim pw As String = cmd.ExecuteScalar.ToString
            If Not (IsDBNull(usr)) AndAlso usr = txtUser.Text Then
                GlobalVariables.Username = txtUser.Text
                GlobalVariables.Password = txtPW.Text
                MsgBox("Login Success", MsgBoxStyle.OkOnly)   ' User Found, PW Match
                ' Admistration.Show()
            ElseIf Not (IsDBNull(usr)) AndAlso pw <> txtPW.Text Then
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
            RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] " + txtUser.Text + " tried to log in with incorrect password")



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
            txtUser.Visible = False
            txtPW.Visible = False
            btnForgot.Visible = False
            btnLogin.Visible = False
            Button4.Visible = False

            Label4.Visible = True
            usr.Visible = True
            usr.Text = GlobalVariables.Username
            btnOff.Visible = True
            btnPWchange.Visible = True
        Else
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            txtUser.Visible = True
            txtPW.Visible = True
            btnForgot.Visible = True
            btnLogin.Visible = True
            Button4.Visible = True

            Label4.Visible = False
            usr.Visible = False
            btnOff.Visible = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CreateAcc.ShowDialog()
        txtUser.Text = ""
        txtPW.Text = ""
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click


        If (MessageBox.Show("Are you sure you want to log off?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Label3.Visible = True
            txtUser.Visible = True
            txtPW.Visible = True
            btnForgot.Visible = True
            btnLogin.Visible = True
            Button4.Visible = True

            Label4.Visible = False
            usr.Visible = False
            btnOff.Visible = False
            txtUser.Text = ""
            txtPW.Text = ""
            GlobalVariables.Username = Nothing
            GlobalVariables.Password = Nothing
            RootForm.access_level = 0
            btnPWchange.Visible = False
            Label1.Visible = True
            Label2.Visible = True
        Else
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            txtUser.Visible = False
            txtPW.Visible = False
            btnForgot.Visible = False
            btnLogin.Visible = False
            Button4.Visible = False

            Label4.Visible = True
            usr.Visible = True
            usr.Text = GlobalVariables.Username
            btnOff.Visible = True
            btnPWchange.Visible = True
        End If
    End Sub

    Private Sub btnPWchange_Click(sender As Object, e As EventArgs) Handles btnPWchange.Click
        PWChange.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.ShowDialog()
    End Sub
End Class

Public Class GlobalVariables
    Public Shared Username As String
    Public Shared Password As String
End Class
