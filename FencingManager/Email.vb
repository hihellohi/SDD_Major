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
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
        cadapter = New OleDb.OleDbDataAdapter("SELECT * FROM Calendar", RootForm.connection)
        cadapter.Fill(cdataS, "Calendar")
    End Sub


    Private Function sendOverdue()
        Dim hashtable As New Hashtable()
        Dim count As Integer = 0
        Dim things(RootForm.GearDataS.Tables("Gear").Rows.Count) As List(Of Integer)

        Dim tmp As DataRow
        For Each tmp In RootForm.GearDataS.Tables("Gear").Rows
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
            If Not all Then
                Button4.Text = Math.Round(((count * 100) / hashtable.Count)).ToString + "%"
            Else
                Button2.Text = Math.Round(((count * 50) / hashtable.Count)).ToString + "%"
            End If

            count += 1
            System.Windows.Forms.Application.DoEvents()
            Dim tmpb As DataRow
            For Each tmpb In dataS.Tables("StudentProfiles").Rows
                If tmpa = tmpb("StudentID") Then
                    'email
                    Try
                        'YUNO WORK
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
                        email.Body += "<p><table><tr><th>Gear ID</th><th>Gear Type</th><th>Due Date</th></tr>"
                        Dim iter As Integer
                        For Each iter In things(hashtable(tmpa))
                            email.Body += "<tr><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearID").ToString() + "</td><td>" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("GearType").ToString() + "</td><td>"
                            email.Body += RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueDay").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueMonth").ToString() + "/" + RootForm.GearDataS.Tables("Gear").Rows(iter).Item("DueYear").ToString() + "</td></tr>"
                        Next
                        email.Body += "</table></p><p>This was an automated message. Do not reply to this email</p></body></html>"
                        'top kek
                        Smtp_Server.Send(email)
                    Catch error_t As Exception
                        MsgBox(error_t.ToString)
                        Return True
                    End Try
                End If
            Next
        Next
        Return False
    End Function

    Private Sub Button1_Click() Handles Button4.Click
        Timer1.Enabled = False
        Button4.BackgroundImage = My.Resources.spinner
        Button4.Enabled = False
        all = False
        mode = -1

        Dim fail As Boolean = sendOverdue()
        If fail Then
            Button4.Text = "Failure!"
        Else
            Button4.Text = "Success!"
        End If
        Button4.BackgroundImage = Nothing
        Button4.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mode = 1 Then
            Button4.Left = Math.Min(Button4.Left + 10, 321)
            If Button4.Left = 321 Then
                Button3.Text = "Are you sure?"
                Timer1.Enabled = False
            End If
        ElseIf mode = 0 Then
            Button4.Left = Math.Max(Button4.Left - 10, 231)
            If Button4.Left = 231 Then
                Timer1.Enabled = False
                Button3.Text = "Send Overdue Notices"
                Button4.Text = "Yes"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mode = 1
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        mode = 1
        'Button3.Text = "Are you sure?"
    End Sub

    Private Sub Button3_LostFocus(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        mode = 0

        Timer1.Enabled = True

    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        mode = 1
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        mode = 0

        Timer1.Enabled = True
    End Sub

    Private Function sendGeneral()
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
        Dim row As DataRow
        For Each row In cdataS.Tables("Calendar").Rows
            If row("EventDate") < Date.Today Then
                Continue For
            End If
            Dim cur As Date
            If RadioButton1.Checked Then
                cur = Date.Today
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        cur = cur.AddDays(TextBox2.Text)
                    Case 2
                        cur = cur.AddDays(TextBox2.Text * 7)
                    Case 3
                        cur = cur.AddMonths(TextBox2.Text)
                    Case 4
                        cur = cur.AddYears(TextBox2.Text)
                End Select
            Else
                cur = New Date(txtYear.Text, cmbMonth.SelectedIndex, cmbDay.SelectedIndex)
            End If
            If cur < row("EventDate") Then
                Continue For
            End If
            Dim none As Boolean = True
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
                        senior(i).Add(tmp)
                    Else
                        junior(i).Add(tmp)
                        senior(i).Add(tmp)
                    End If
                Next
            End If
        Next
        For Each row In dataS.Tables("StudentProfiles").Rows
            If row("YearGroup") = 1 Then
                esenior(row("Weapon") - 1).Add(row("email"))
            Else
                ejunior(row("Weapon") - 1).Add(row("email"))
            End If
        Next
        Dim count = 0
        For i = 0 To 2
            If Not all Then
                Button5.Text = Math.Round(((count * 100) / 6)).ToString + "%"
            Else
                Button2.Text = Math.Round(((count * 50) / 6) + 50).ToString + "%"
            End If
            count += 1
            System.Windows.Forms.Application.DoEvents()
            If send_email(esenior(i), senior(i)) Then
                Return True
            End If
            If Not all Then
                Button5.Text = Math.Round(((count * 100) / 6)).ToString + "%"
            Else
                Button2.Text = Math.Round(((count * 50) / 6) + 50).ToString + "%"
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
            email.Body = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p>" + TextBox1.Text.Replace(vbNewLine, "<br>").ToString
            If events.Count <> 0 Then
                email.Body += "</p><p>upcoming events<table><tr><th>Event Name</th><th>Event Date</th><th>Event Time</th><th>Venue</th><th>Weapon</th><th>Age Group</th></tr>"
                Dim iter As item
                For Each iter In events
                    email.Body += "<tr><td>" + iter.eventName.ToString() + "</td><td>" + iter.day.Day.ToString() + "/" + iter.day.Month.ToString() + "/" + iter.day.Year.ToString() + "</td><td>" + iter.time.ToString() + "</td><td>" + iter.venue.ToString() + "</td><td>" + iter.weapon.ToString() + "</td><td>" + iter.group.ToString()
                    email.Body += "</td></tr>"
                Next
                email.Body += "</table>"
            End If
            email.Body += "</p><p>This was an automated message. Do not reply to this email</p></body></html>"
            'top kek
            Smtp_Server.Send(email)
        Catch error_t As Exception
            MsgBox(error_t.ToString)
            Return True
        End Try
        Return False
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = System.Text.RegularExpressions.Regex.Replace(TextBox2.Text, "[^0-9]", "")
        TextBox2.Select(TextBox2.Text.Length, 0)
        If TextBox2.Text = "1" Then
            ComboBox1.Items(1) = "Day"
            ComboBox1.Items(2) = "Week"
            ComboBox1.Items(3) = "Month"
            ComboBox1.Items(4) = "Year"
        Else
            ComboBox1.Items(1) = "Days"
            ComboBox1.Items(2) = "Weeks"
            ComboBox1.Items(3) = "Months"
            ComboBox1.Items(4) = "Years"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim valid = True
        If RadioButton1.Checked Then
            If TextBox2.Text = "" Then
                valid = False
            End If
            If ComboBox1.SelectedIndex = 0 Then
                valid = False
            End If

            Label3.Visible = Not valid

        ElseIf Not datevalid() Then
            valid = False
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If
        If valid Then
            Button5.BackgroundImage = My.Resources.spinner
            Button5.Enabled = False
            all = False
            mode = -2
            Dim fail = sendGeneral()
            If fail Then
                Button5.Text = "Failure!"
            Else
                Button5.Text = "Success!"
            End If
            Button5.BackgroundImage = Nothing
            Button5.Enabled = True
            'Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        mode = 0
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Function datevalid()
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
        SetCueText(txtYear, "Year")
        ComboBox1.SelectedIndex = 0
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cmbDay.Enabled = RadioButton2.Checked
        cmbMonth.Enabled = RadioButton2.Checked
        txtYear.Enabled = RadioButton2.Checked
        TextBox2.Enabled = RadioButton1.Checked
        ComboBox1.Enabled = RadioButton1.Checked
        Label3.Visible = RadioButton1.Checked And Label3.Visible
        Label4.Visible = RadioButton2.Checked And Label4.Visible
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valid = True
        If RadioButton1.Checked Then
            If TextBox2.Text = "" Then
                valid = False
            End If
            If ComboBox1.SelectedIndex = 0 Then
                valid = False
            End If

            Label3.Visible = Not valid

        ElseIf Not datevalid() Then
            valid = False
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If
        If valid Then
            Button2.BackgroundImage = My.Resources.spinner
            Button2.Enabled = False
            all = True
            mode = -3
            Dim fail = sendOverdue()
            If Not fail Then
                fail = sendGeneral()
            End If
            If fail Then
                Button2.Text = "Failure!"
            Else
                Button2.Text = "Success!"
            End If
            Button2.BackgroundImage = Nothing
            Button2.Enabled = True
            'Timer2.Enabled = True
        End If
    End Sub
End Class