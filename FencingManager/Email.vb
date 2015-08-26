Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Net
Public Class Email

    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()
    Dim cadapter As New OleDb.OleDbDataAdapter
    Dim cdataS As New DataSet()
    Dim mode = 0
    Dim all = False

    Structure item
        Public eventName As String
        Public day As Date
        Public time As String
        Public venue As String
        Public group As String
        Public weapon As String
    End Structure

    Public Sub reload()
        'refresh the datasets
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
        cadapter = New OleDb.OleDbDataAdapter("SELECT * FROM Calendar", RootForm.connection)
        cadapter.Fill(cdataS, "Calendar")
    End Sub


    Private Function sendOverdue()
        'send overdue notices
        Dim hashtable As New Hashtable()
        Dim count As Integer = 0
        Dim things(RootForm.GearDataS.Tables("Gear").Rows.Count) As List(Of Integer)

        Dim tmp As DataRow
        For Each tmp In RootForm.GearDataS.Tables("Gear").Rows
            'find all overdue items and record them in a hashtable and a list

            If tmp("StudentLoaned") <> 0 Then
                Dim due As New Date(tmp("DueYear"), tmp("DueMonth"), tmp("DueDay"))
                If due < Date.Today Then
                    If Not hashtable.Contains(tmp("StudentLoaned")) Then
                        hashtable.Add(tmp("StudentLoaned"), count)
                        count += 1
                        things(hashtable(tmp("StudentLoaned"))) = New List(Of Integer)
                    End If
                    things(hashtable(tmp("StudentLoaned"))).Add(tmp("ID") - 1)
                End If
            End If
        Next
        Dim tmpa As Integer
        count = 0
        For Each tmpa In hashtable.Keys

            'progress report
            If Not all Then
                btnODYes.Text = Math.Round(((count * 100) / hashtable.Count)).ToString + "%"
            Else
                btnBothYes.Text = Math.Round(((count * 50) / hashtable.Count)).ToString + "%"
            End If

            count += 1
            System.Windows.Forms.Application.DoEvents()
            Dim tmpb As DataRow
            'send the actual email
            For Each tmpb In dataS.Tables("StudentProfiles").Rows
                If tmpa = tmpb("StudentID") Then
                    Try
                        Dim Smtp_Server As New SmtpClient
                        Dim email As New MailMessage()
                        Smtp_Server.UseDefaultCredentials = False
                        Smtp_Server.Credentials = New Net.NetworkCredential("engardefencingmanager@gmail.com", "password?")
                        Smtp_Server.Port = 587
                        Smtp_Server.EnableSsl = True
                        Smtp_Server.Host = "smtp.gmail.com"

                        email = New MailMessage()
                        email.From = New MailAddress("engardefencingmanager@gmail.com")
                        email.To.Add(tmpb("Email"))
                        email.Subject = "Overdue Notice"
                        email.IsBodyHtml = True
                        email.Body = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body>You have loaned " + things(hashtable(tmpa)).Count.ToString() + " items from your fencing organisation that are overdue. Please return immediately"
                        'construct table
                        email.Body += "<p><table width = ""500""><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
                        Dim iter As Integer
                        For Each iter In things(hashtable(tmpa))
                            email.Body += "<tr align = center><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearID").ToString() + "</td><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearType").ToString() + "</td><td>"
                            email.Body += RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueDay").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueMonth").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueYear").ToString() + "</td></tr>"
                        Next
                        email.Body += "</table></p><p>This was an automated message. Do not reply to this email</p></body></html>"
                        Smtp_Server.Send(email)

                        FencingManager.Admin.RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)
                        My.Computer.FileSystem.WriteAllText("edits.txt", "[" + DateString + " " + TimeOfDay + "] Overdue Items Email sent " & Environment.NewLine, True)

                    Catch error_t As Exception
                        'If error occurs
                        MsgBox(error_t.ToString)
                        Return True
                    End Try
                End If
            Next
        Next
        Return False
    End Function

    Private Sub btnODYes_Click() Handles btnODYes.Click
        timerMove.Enabled = False
        btnODYes.BackgroundImage = My.Resources.spinner
        btnODYes.Enabled = False
        all = False
        mode = -1

        Dim fail As Boolean = sendOverdue()
        If fail Then
            btnODYes.Text = "Failure!"
        Else
            btnODYes.Text = "Success!"
        End If
        btnODYes.BackgroundImage = Nothing
        btnODYes.Enabled = True
        timerWait.Enabled = True

    End Sub



    Private Function sendGeneral()
        'initialise lists
        Dim weapons() = {"foil", "sabre", "epee"}
        Dim senior(3) As List(Of item)
        Dim junior(3) As List(Of item)
        Dim esenior(3) As List(Of String)
        Dim ejunior(3) As List(Of String)
        For i = 0 To 2
            senior(i) = New List(Of item)
            junior(i) = New List(Of item)
            esenior(i) = New List(Of String)
            ejunior(i) = New List(Of String)
        Next

        'find all valid events
        Dim row As DataRow
        For Each row In cdataS.Tables("Calendar").Rows
            If row("EventDate") < Date.Today Then
                Continue For
            End If
            Dim cur As Date
            If rdbNext.Checked Then
                cur = Date.Today
                Select Case cmbNext.SelectedIndex
                    Case 1
                        cur = cur.AddDays(txtNext.Text)
                    Case 2
                        cur = cur.AddDays(txtNext.Text * 7)
                    Case 3
                        cur = cur.AddMonths(txtNext.Text)
                    Case 4
                        cur = cur.AddYears(txtNext.Text)
                End Select
            Else
                cur = New Date(txtYear.Text, cmbMonth.SelectedIndex, cmbDay.SelectedIndex)
            End If
            If cur < row("EventDate") Then
                Continue For
            End If
            Dim none As Boolean = True
            'sort events into junior/senior foil/sabre/epee
            For i = 0 To 2
                If weapons(i) = row("Weapon").ToString.ToLower Then
                    none = False
                    Dim tmp As New item
                    tmp.day = row("EventDate")
                    tmp.eventName = row("EventName").ToString
                    tmp.time = row("Time").ToString
                    tmp.group = row("Group").ToString
                    tmp.venue = row("Venue").ToString
                    tmp.weapon = row("Weapon").ToString
                    If row("Group").ToString.ToLower = "junior" Then
                        junior(i).Add(tmp)
                    ElseIf row("Group").ToString.ToLower = "senior" Then
                        senior(i).Add(tmp)
                    Else
                        junior(i).Add(tmp)
                        senior(i).Add(tmp)
                    End If
                End If
            Next
            If none Then
                For i = 0 To 2
                    Dim tmp As New item
                    tmp.day = row("EventDate")
                    tmp.eventName = row("EventName").ToString
                    tmp.time = row("Time").ToString
                    tmp.group = row("Group").ToString
                    tmp.venue = row("Venue").ToString
                    tmp.weapon = row("Weapon").ToString
                    If row("Group").ToString.ToLower = "junior" Then
                        junior(i).Add(tmp)
                    ElseIf row("Group").ToString.ToLower = "senior" Then
                        senior(i).Add(tmp)
                    Else
                        junior(i).Add(tmp)
                        senior(i).Add(tmp)
                    End If
                Next
            End If
        Next
        'sort students into junior/senior foil/sabre/epee
        For Each row In dataS.Tables("StudentProfiles").Rows
            If row("YearGroup") = 1 Then
                esenior(row("Weapon") - 1).Add(row("email"))
            Else
                ejunior(row("Weapon") - 1).Add(row("email"))
            End If
        Next

        'send emails to all their relevant recipients
        Dim count = 0
        For i = 0 To 2
            If Not all Then
                btnGEYes.Text = Math.Round(((count * 100) / 6)).ToString + "%"
            Else
                btnBothYes.Text = Math.Round(((count * 50) / 6) + 50).ToString + "%"
            End If
            count += 1
            System.Windows.Forms.Application.DoEvents()
            If send_email(esenior(i), senior(i)) Then
                Return True
            End If
            If Not all Then
                btnGEYes.Text = Math.Round(((count * 100) / 6)).ToString + "%"
            Else
                btnBothYes.Text = Math.Round(((count * 50) / 6) + 50).ToString + "%"
            End If
            count += 1
            System.Windows.Forms.Application.DoEvents()
            If send_email(ejunior(i), junior(i)) Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Function send_email(ByRef blah As List(Of String), ByRef events As List(Of item))
        If blah.Count = 0 Then
            'if no recipients
            Return False
        End If
        Try
            Dim Smtp_Server As New SmtpClient
            Dim email As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("engardefencingmanager@gmail.com", "password?")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            email = New MailMessage()
            email.From = New MailAddress("engardefencingmanager@gmail.com")
            Dim tmp As String
            For Each tmp In blah
                email.Bcc.Add(tmp)
            Next
            email.Subject = "Message From Fencing"
            email.IsBodyHtml = True
            email.Body = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p>" + txtMessage.Text.Replace(vbNewLine, "<br>").ToString
            If events.Count <> 0 Then
                'construct table
                email.Body += "</p><p>upcoming events<table width=""500""><tr><th>Event Name</th><th>Event Date</th><th>Event Time</th><th>Venue</th><th>Weapon</th><th>Age Group</th></tr>"
                Dim iter As item
                For Each iter In events
                    email.Body += "<tr align=""center""><td>" + iter.eventName.ToString() + "</td><td>" + iter.day.Day.ToString() + "/" + iter.day.Month.ToString() + "/" + iter.day.Year.ToString() + "</td><td>" + iter.time.ToString() + "</td><td>" + iter.venue.ToString() + "</td><td>" + iter.weapon.ToString() + "</td><td>" + iter.group.ToString()
                    email.Body += "</td></tr>"
                Next
                email.Body += "</table>"
            End If
            email.Body += "</p><p>This was an automated message. Do not reply to this email</p></body></html>"
            Smtp_Server.Send(email)
        Catch error_t As Exception
            'if failure
            MsgBox(error_t.ToString)
            Return True
        End Try
        Return False
    End Function

    Private Sub txtNext_TextChanged(sender As Object, e As EventArgs) Handles txtNext.TextChanged
        'data validation
        txtNext.Text = System.Text.RegularExpressions.Regex.Replace(txtNext.Text, "[^0-9]", "")
        txtNext.Select(txtNext.Text.Length, 0)
        'correct grammar
        If txtNext.Text = "1" Then
            cmbNext.Items(1) = "Day"
            cmbNext.Items(2) = "Week"
            cmbNext.Items(3) = "Month"
            cmbNext.Items(4) = "Year"
        Else
            cmbNext.Items(1) = "Days"
            cmbNext.Items(2) = "Weeks"
            cmbNext.Items(3) = "Months"
            cmbNext.Items(4) = "Years"
        End If
    End Sub

    Private Sub btnGEYes_Click(sender As Object, e As EventArgs) Handles btnGEYes.Click
        'data validation
        Dim valid = True
        If rdbNext.Checked Then
            If txtNext.Text = "" Then
                valid = False
            End If
            If cmbNext.SelectedIndex = 0 Then
                valid = False
            End If

            lblNextError.Visible = Not valid

        ElseIf Not datevalid() Then
            valid = False
            lblUntilError.Visible = True
        Else
            lblUntilError.Visible = False
        End If
        If valid Then
            'send email
            btnGEYes.BackgroundImage = My.Resources.spinner
            btnGEYes.Enabled = False
            all = False
            mode = -2
            Dim fail = sendGeneral()
            If fail Then
                btnGEYes.Text = "Failure!"
            Else
                btnGEYes.Text = "Success!"
            End If
            btnGEYes.BackgroundImage = Nothing
            btnGEYes.Enabled = True
            timerWait.Enabled = True
        End If
    End Sub



    Private Function datevalid()
        'check if the input date exists
        If txtYear.Text = "" Then
            Return False
        End If
        If cmbDay.SelectedIndex = 0 Or cmbMonth.SelectedIndex = 0 Or txtYear.Text < 1000 Or txtYear.Text > 9999 Then
            Return False
        End If
        If cmbDay.SelectedIndex > 31 Then
            Return False
        End If
        Dim thirty() = {4, 6, 9, 11}
        For i = 0 To 3
            If cmbMonth.SelectedIndex = thirty(i) And cmbDay.SelectedIndex = 31 Then
                Return False
            End If
        Next
        If cmbMonth.SelectedIndex = 2 Then
            If (txtYear.Text Mod 400 = 0 Or (txtYear.Text Mod 4 = 0 And (Not txtYear.Text Mod 100 = 0))) Then
                If cmbDay.SelectedIndex = 30 Then
                    Return False
                End If
            ElseIf cmbDay.SelectedIndex > 28 Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialisation
        SetCueText(txtYear, "Year")
        cmbNext.SelectedIndex = 0
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub
    Private Sub rdbUntil_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUntil.CheckedChanged
        cmbDay.Enabled = rdbUntil.Checked
        cmbMonth.Enabled = rdbUntil.Checked
        txtYear.Enabled = rdbUntil.Checked
        txtNext.Enabled = rdbNext.Checked
        cmbNext.Enabled = rdbNext.Checked
        lblNextError.Visible = rdbNext.Checked And lblNextError.Visible
        lblUntilError.Visible = rdbUntil.Checked And lblUntilError.Visible
    End Sub

    Private Sub btnBothYes_Click(sender As Object, e As EventArgs) Handles btnBothYes.Click
        'data Validation
        Dim valid = True
        If rdbNext.Checked Then
            If txtNext.Text = "" Then
                valid = False
            End If
            If cmbNext.SelectedIndex = 0 Then
                valid = False
            End If

            lblNextError.Visible = Not valid

        ElseIf Not datevalid() Then
            valid = False
            lblUntilError.Visible = True
        Else
            lblUntilError.Visible = False
        End If
        If valid Then
            'send the emails
            btnBothYes.BackgroundImage = My.Resources.spinner
            btnBothYes.Enabled = False
            all = True
            mode = -3
            Dim fail = sendOverdue()
            If Not fail Then
                fail = sendGeneral()
            End If
            If fail Then
                btnBothYes.Text = "Failure!"
            Else
                btnBothYes.Text = "Success!"
            End If
            btnBothYes.BackgroundImage = Nothing
            btnBothYes.Enabled = True
            timerWait.Enabled = True
        End If
    End Sub
    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If mode = 1 Then
            'move OD right
            btnODYes.Left = Math.Min(btnODYes.Left + 10, 321)
            If btnODYes.Left = 321 Then
                btnOverdue.Text = "Are you sure?"
                timerMove.Enabled = False
            End If
        ElseIf mode = 2 Then
            'move GE left
            btnGEYes.Left = Math.Max(btnGEYes.Left - 10, 278)
            If btnGEYes.Left = 278 Then
                btnGeneral.Text = "Are you sure?"
                timerMove.Enabled = False
            End If
        ElseIf mode = 3 Then
            'move both right
            btnBothYes.Left = Math.Min(btnBothYes.Left + 10, 321)
            If btnBothYes.Left = 321 Then
                btnboth.Text = "Are you sure?"
                timerMove.Enabled = False
            End If
        ElseIf mode = 0 Then
            'move all back
            btnODYes.Left = Math.Max(btnODYes.Left - 10, 231)
            btnBothYes.Left = Math.Max(btnBothYes.Left - 10, 231)
            btnGEYes.Left = Math.Min(367, btnGEYes.Left + 10)
            Dim all = True
            If btnODYes.Left = 231 Then

                btnOverdue.Text = "Send Overdue Notices"
                btnODYes.Text = "Yes"
            Else
                all = False
            End If
            If btnBothYes.Left = 231 Then
                btnBothYes.Text = "Yes"
                btnboth.Text = "Send Both"
            Else
                all = False
            End If
            If btnGEYes.Left = 367 Then
                btnGEYes.Text = "Yes"
                btnGeneral.Text = "Send General Emails"
            Else
                all = False
            End If
            If all Then
                timerMove.Enabled = False
            End If
        End If
    End Sub
    Private Sub timerWait_Tick(sender As Object, e As EventArgs) Handles timerWait.Tick
        mode = 0
        timerWait.Enabled = False
        timerMove.Enabled = True
    End Sub

    Private Sub btnOverdue_Click(sender As Object, e As EventArgs) Handles btnOverdue.Click
        If mode >= 0 Then
            mode = 1
            timerMove.Enabled = True
        End If
    End Sub

    Private Sub btnOverdue_MouseEnter(sender As Object, e As EventArgs) Handles btnOverdue.MouseEnter
        If mode >= 0 Then
            mode = 1
        End If
        'Button3.Text = "Are you sure?"
    End Sub

    Private Sub btnOverdue_LostFocus(sender As Object, e As EventArgs) Handles btnOverdue.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub

    Private Sub btnODYes_MouseEnter(sender As Object, e As EventArgs) Handles btnODYes.MouseEnter
        If mode >= 0 Then
            mode = 1
        End If
    End Sub

    Private Sub btnODYes_MouseLeave(sender As Object, e As EventArgs) Handles btnODYes.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub
    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        If mode >= 0 Then
            mode = 2
            timerMove.Enabled = True
        End If
    End Sub
    Private Sub btnGeneral_MouseEnter(sender As Object, e As EventArgs) Handles btnGeneral.MouseEnter
        If mode >= 0 Then
            mode = 2
        End If
        'button1.Text = "Are you sure?"
    End Sub

    Private Sub btnGeneral_LostFocus(sender As Object, e As EventArgs) Handles btnGeneral.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub

    Private Sub btnGEYes_MouseEnter(sender As Object, e As EventArgs) Handles btnGEYes.MouseEnter
        If mode >= 0 Then
            mode = 2
        End If
    End Sub

    Private Sub btnGeYes_MouseLeave(sender As Object, e As EventArgs) Handles btnGEYes.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub
    Private Sub btnboth_Click(sender As Object, e As EventArgs) Handles btnboth.Click
        If mode >= 0 Then
            mode = 3
            timerMove.Enabled = True
        End If
    End Sub
    Private Sub btnboth_MouseEnter(sender As Object, e As EventArgs) Handles btnboth.MouseEnter
        If mode >= 0 Then
            mode = 3
        End If
        'btnboth.Text = "Are you sure?"
    End Sub

    Private Sub btnboth_LostFocus(sender As Object, e As EventArgs) Handles btnboth.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub

    Private Sub btnBothYes_MouseEnter(sender As Object, e As EventArgs) Handles btnBothYes.MouseEnter
        If mode >= 0 Then
            mode = 3
        End If
    End Sub

    Private Sub btnBothYes_MouseLeave(sender As Object, e As EventArgs) Handles btnBothYes.MouseLeave
        If mode > 0 Then
            mode = 0

            timerMove.Enabled = True
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        btnHelp.BackColor = Color.White
        btnMain.BackColor = Color.DarkOrange
        ptbHelp.Visible = True
        btnMain.Top = 79
        btnMain.Height = 31
        btnHelp.Top = 71
        btnHelp.Height = 39
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        btnHelp.BackColor = Color.DarkOrange
        btnMain.BackColor = Color.White
        ptbHelp.Visible = False
        btnMain.Top = 71
        btnMain.Height = 39
        btnHelp.Top = 79
        btnHelp.Height = 31
    End Sub

    Private Sub btnmain_Mouseenter(sender As Object, e As EventArgs) Handles btnMain.MouseEnter
        btnMain.Top = 71
        btnMain.Height = 39
    End Sub


    Private Sub btnHelp_Mouseenter(sender As Object, e As EventArgs) Handles btnHelp.MouseEnter
        btnHelp.Top = 71
        btnHelp.Height = 39
    End Sub

    Private Sub btnmain_Mouseleave(sender As Object, e As EventArgs) Handles btnMain.MouseLeave
        If btnHelp.BackColor = Color.White Then
            btnMain.Top = 79
            btnMain.Height = 31
        End If
    End Sub


    Private Sub btnHelp_Mouseleave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        If btnMain.BackColor = Color.White Then
            btnHelp.Top = 79
            btnHelp.Height = 31
        End If
    End Sub
End Class