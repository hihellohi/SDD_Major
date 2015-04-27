Public Class RootForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Screen.PrimaryScreen.Bounds.Width > 1366 And Screen.PrimaryScreen.Bounds.Height > 768) Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
