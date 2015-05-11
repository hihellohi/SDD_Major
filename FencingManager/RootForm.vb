Imports System.Data.OleDb

Public Class RootForm

    Dim formGearLoaning As New GearLoaning()
    Dim formStudentProfile As New StudentProfilesForm()
    Dim formAttendance As New AttendanceForm()
    Dim topform = formStudentProfile
    Public Shared connection As New OleDbConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(My.Settings.FencingConnectionString)
        connection.Open()

        If (Screen.PrimaryScreen.Bounds.Width > 1366 And Screen.PrimaryScreen.Bounds.Height > 768) Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If

        'Load Forms

        formAttendance.TopLevel = False
        Me.Panel1.Controls.Add(formAttendance)

        formStudentProfile.TopLevel = False
        Me.Panel1.Controls.Add(formStudentProfile)

        formGearLoaning.TopLevel = False
        Panel1.Controls.Add(formGearLoaning)

        ' Show Student Profile on Load
        formStudentProfile.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnStudentProf_Click(sender As Object, e As EventArgs) Handles btnStudentProf.Click
        topform.hide()
        topform = formStudentProfile
        topform.show()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click

    End Sub

    Private Sub btnGearLoan_Click(sender As Object, e As EventArgs) Handles btnGearLoan.Click
        topform.hide()
        topform = formGearLoaning
        topform.show()
    End Sub
End Class
