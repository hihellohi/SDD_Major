Imports System.Data.OleDb
Public Class CreateAcc

    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPW.Text = txtCPW.Text And txtPW.Text <> ("") Then
            Dim accesslevel As Integer = 0
            If ComboBox1.SelectedItem = "Weapon Captain" Then
                accesslevel = 1
            ElseIf ComboBox1.SelectedItem = "Captain / Coach" Then
                accesslevel = 2
            End If


            Dim str As String
            str = "INSERT INTO [Logins] ([Password], [Username], AccessLevel, RecoveryEmail, FirstName, LastName) VALUES (?, ?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, RootForm.connection)
            cmd.Parameters.Add(New OleDbParameter("username", CType(txtPW.Text, String)))  'this is reversed for some reason
            cmd.Parameters.Add(New OleDbParameter("password", CType(txtUser.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("password", CType(accesslevel, Integer)))
            cmd.Parameters.Add(New OleDbParameter("RecoveryEmail", CType(txtEmail.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFN.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtLN.Text, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                MsgBox("Account Created Successfully. Please Log In.")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf txtPW.Text <> txtCPW.Text Then
            Label6.Visible = True
        Else
            Try
                If txtUser.Text <> IsNumeric(txtUser.Text) Or txtPW.TextLength <> 9 Then
                    Label5.Visible = True
                End If
            Catch ex As Exception
                Label5.Visible = True
            End Try

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged, txtCPW.TextChanged
        Label6.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        Label5.Visible = False
    End Sub

End Class