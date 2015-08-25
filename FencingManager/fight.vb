Public Class fight

    Dim lock = False

    Private Sub btnBegin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBegin.KeyDown
        If e.KeyCode = Keys.Escape Then
            lock = False
            btnBegin.Text = "En Garde"
        End If
    End Sub

    Private Sub btnBegin_LostFocus(sender As Object, e As EventArgs) Handles btnBegin.LostFocus
        If lock Then
            btnBegin.Focus()
        End If
    End Sub

    Private Sub btnbegin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBegin.MouseDown
        If lock Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                MsgBox("RED")
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                MsgBox("GREEN")
            Else
                MsgBox("TOGETHER")
            End If
        Else
            lock = True
            btnBegin.Text = "Press Esc to stop"
        End If
    End Sub

    Private Sub btnBegin_MouseLeave(sender As Object, e As EventArgs) Handles btnBegin.MouseLeave
        If lock Then
            Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
        End If
    End Sub

    Private Sub btnBegin_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBegin.MouseMove
        If lock Then
            Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
        End If
    End Sub
End Class