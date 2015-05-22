Imports System.Data.OleDb
Public Class CreateAcc

    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = TextBox3.Text And TextBox2.Text <> ("") And IsNumeric(TextBox1.Text) Then
            Dim ConnectString As String = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\SDD_Major-master\FencingManager\Fencing.accdb"
            myConnection = New OleDbConnection(ConnectString)
            If myConnection.State = ConnectionState.Closed Then
                myConnection.Open()
            End If
            Dim str As String
            str = "INSERT INTO [Logins] ([Password], [Username], FirstName, LastName) VALUES (?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.Add(New OleDbParameter("username", CType(TextBox2.Text, String)))  'this is reversed for some reason
            cmd.Parameters.Add(New OleDbParameter("password", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("FirstName", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LastName", CType(TextBox5.Text, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                MsgBox("Account Created Successfully. Please Log In.")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf TextBox2.Text <> TextBox3.Text Then
            Label6.Visible = True
        ElseIf TextBox2.TextLength = 9 Then
            Label7.Visible = True
        Else
            Try
                If TextBox1.Text <> IsNumeric(TextBox1.Text) Or TextBox2.TextLength <> 9 Then
                    Label5.Visible = True
                End If
            Catch ex As Exception
                Label5.Visible = True
            End Try

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged
        Label6.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label5.Visible = False
    End Sub
End Class