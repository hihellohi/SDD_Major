Public Class RootForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Screen.PrimaryScreen.Bounds.Width > 1366 And Screen.PrimaryScreen.Bounds.Height > 768) Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If

        'Load Forms
        Dim formAttendance As New AttendanceForm()
        formAttendance.TopLevel = False
        Me.Panel1.Controls.Add(formAttendance)

        Dim formStudentProfile As New StudentProfilesForm()
        formStudentProfile.TopLevel = False
        Me.Panel1.Controls.Add(formStudentProfile)

        ' Show Student Profile on Load
        formStudentProfile.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnStudentProf_Click(sender As Object, e As EventArgs) Handles btnStudentProf.Click

    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click

    End Sub
End Class
