Imports FencingManager.GlobalVariables
Imports System.Data.OleDb


Public Class PWChange

    Private Sub PWChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOld.TextChanged
        Label5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtOld.Text = Password Then
            If txtNew1.Text = txtNew2.Text Then
                If txtNew1.TextLength >= 6 Then
                    Dim cmd As String = "UPDATE [Logins] SET [Password]=@pw WHERE Username=@user"
                    Using cmd1 = New OleDbCommand(cmd, RootForm.connection)
                        cmd1.Parameters.Add(New OleDbParameter("@pw", CType(txtNew1.Text, String)))
                        cmd1.Parameters.Add(New OleDbParameter("@user", Username))
                        cmd1.ExecuteNonQuery()
                        MsgBox("SUCCESS - PW CHANGED")
                        Me.Close()
                    End Using

                Else : Label7.Visible = True
                End If
            Else : Label6.Visible = True
            End If
        Else : Label5.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Are you sure you want to cancel?")
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNew1.TextChanged
        Label7.Visible = False
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtNew2.TextChanged, txtNew1.TextChanged
        Label6.Visible = False
    End Sub
End Class