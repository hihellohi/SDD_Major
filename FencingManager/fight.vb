Public Class fight

    Dim lock = False
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataS As New DataSet()
    Dim target As Integer
    Dim score1 As Integer
    Dim score2 As Integer
    Dim guestk1 As Integer = 0
    Dim guestk2 As Integer = 0
    Dim guestw1 As Integer = 0
    Dim guestw2 As Integer = 0
    Dim guestd1 As Integer = 0
    Dim guestd2 As Integer = 0
    Dim guestl1 As Integer = 0
    Dim guestl2 As Integer = 0
    Dim clock As Integer = 0
    Dim p1Index As Integer = -1
    Dim p2index As Integer = -1

    Public Sub reload()
        'Reload the student dataset
        adapter = New OleDb.OleDbDataAdapter("SELECT * FROM StudentProfiles", RootForm.connection)
        adapter.Fill(dataS, "StudentProfiles")
        Dim found1 As Boolean = False
        Dim found2 As Boolean = False
        Dim count = 0
        Dim row As DataRow
        For Each row In dataS.Tables("StudentProfiles").Rows
            'check if student has been deleted
            If row("StudentID").ToString = txtPlayer1.Text Then
                found1 = True
                lblFirstName1.Text = row("FirstName")
                lblSurname1.Text = row("Surname")
                lblKills1.Text = row("Kills")
                lblWins1.Text = row("Wins")
                lblKD1.Text = Format(row("Kills") / Math.Max(row("Deaths"), 1), "0.00")
                lblWL1.Text = Format(row("Wins") / Math.Max(row("Losses"), 1), "0.00")
                p1Index = count
            End If
            If row("StudentID").ToString = txtPlayer2.Text Then
                found2 = True
                lblFirstName2.Text = row("FirstName")
                lblSurname2.Text = row("Surname")
                lblKills2.Text = row("Kills")
                lblWins2.Text = row("Wins")
                lblKD2.Text = Format(row("Kills") / Math.Max(row("Deaths"), 1), "0.00")
                lblWL2.Text = Format(row("Wins") / Math.Max(row("Losses"), 1), "0.00")
                p2index = count
            End If
            count += 1
        Next
        If Not found1 Then
            'reset
            lblFirstName1.Text = "Red"
            lblSurname1.Text = "Guest"
            lblKills1.Text = guestk1
            lblWins1.Text = guestw1
            lblKD1.Text = Format(guestk1 / Math.Max(guestd1, 1), "0.00")
            lblWL1.Text = Format(guestw1 / Math.Max(guestl1, 1), "0.00")
            p1Index = -1
        End If
        If Not found2 Then
            'reset
            lblFirstName2.Text = "Green"
            lblSurname2.Text = "Guest"
            lblKills2.Text = guestk2
            lblWins2.Text = guestw2
            lblKD2.Text = Format(guestk2 / Math.Max(guestd2, 1), "0.00")
            lblWL2.Text = Format(guestw2 / Math.Max(guestl2, 1), "0.00")
            p2index = -1
        End If
    End Sub

    Private Sub btnBegin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBegin.KeyDown
        If e.KeyCode = Keys.Escape Then
            tmrClock.Enabled = False
            lock = False
            Windows.Forms.Cursor.Show()
            btnBegin.Text = "En Garde"
            txtLength.ReadOnly = False
            txtPlayer1.ReadOnly = False
            txtPlayer2.ReadOnly = False
        End If
    End Sub

    Private Sub btnBegin_LostFocus(sender As Object, e As EventArgs) Handles btnBegin.LostFocus
        If lock Then
            btnBegin.Focus()
        End If
    End Sub

    Private Sub btnbegin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBegin.MouseDown
        Static history As New Stack(Of Boolean)

        Dim changew1 = 0
        Dim changew2 = 0
        Dim changel1 = 0
        Dim changel2 = 0
        Dim changek1 = 0
        Dim changek2 = 0
        Dim changed1 = 0
        Dim changed2 = 0

        If lock Then
            If e.Button = Windows.Forms.MouseButtons.Left Then

                'add score and check for win
                score1 += 1
                history.Push(False)

                changek1 = 1
                changed2 = 1

                If score1 = target Then
                    lock = False
                    btnBegin.Text = lblFirstName1.Text + " " + lblSurname1.Text + " Wins!"
                    changew1 = 1
                    changel2 = 1
                    txtLength.ReadOnly = False
                    txtPlayer1.ReadOnly = False
                    txtPlayer2.ReadOnly = False
                    tmrClock.Enabled = False
                    Windows.Forms.Cursor.Show()
                End If

            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                score2 += 1
                history.Push(True)
                changek2 = 1
                changed1 = 1
                If score2 = target Then
                    lock = False
                    btnBegin.Text = lblFirstName2.Text + " " + lblSurname2.Text + " Wins!"
                    changew2 = 1
                    changel1 = 1
                    txtLength.ReadOnly = False
                    txtPlayer1.ReadOnly = False
                    txtPlayer2.ReadOnly = False
                    tmrClock.Enabled = False
                    Windows.Forms.Cursor.Show()
                End If

            Else
                'undo last move
                If history.Count Then
                    If history.Pop() Then
                        score2 -= 1
                        changek2 = -1
                        changed1 = -1
                    Else
                        score1 -= 1
                        changek1 = -1
                        changed2 = -1
                    End If
                End If
            End If
            If p1Index <> -1 Then
                dataS.Tables("StudentProfiles").Rows(p1Index).Item("Kills") += changek1
                dataS.Tables("StudentProfiles").Rows(p1Index).Item("Deaths") += changed1
                dataS.Tables("StudentProfiles").Rows(p1Index).Item("Wins") += changew1
                dataS.Tables("StudentProfiles").Rows(p1Index).Item("Losses") += changel1
            Else
                guestk1 += changek1
                guestd1 += changed1
                guestw1 += changew1
                guestl1 += changel1
            End If
            If p2index <> -1 Then
                dataS.Tables("StudentProfiles").Rows(p2index).Item("Kills") += changek2
                dataS.Tables("StudentProfiles").Rows(p2index).Item("Deaths") += changed2
                dataS.Tables("StudentProfiles").Rows(p2index).Item("Wins") += changew2
                dataS.Tables("StudentProfiles").Rows(p2index).Item("Losses") += changel2
            Else
                guestk2 += changek2
                guestd2 += changed2
                guestw2 += changew2
                guestl2 += changel2
            End If
            'FIX DATABASE
            Dim cb As New OleDb.OleDbCommandBuilder(adapter)
            adapter.Update(dataS, "StudentProfiles")
            reload()
            lblScore.Text = score1.ToString + " - " + score2.ToString
            'Me.Refresh()

        Else
            If txtLength.Text = "" Then
                txtLength.BackColor = Color.Red
            Else
                history.Clear()
                txtLength.BackColor = Color.White
                target = txtLength.Text
                txtLength.ReadOnly = True
                txtPlayer1.ReadOnly = True
                txtPlayer2.ReadOnly = True
                score1 = 0
                score2 = 0
                lblScore.Text = "0 - 0"
                lblTime.Text = "0:00"
                lock = True
                tmrClock.Enabled = True
                clock = 0
                btnBegin.Text = "Press Esc to stop"
                Windows.Forms.Cursor.Hide()
            End If
        End If
    End Sub



    'Private Sub btnBegin_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBegin.MouseMove
    '    If lock Then
    '        Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
    '    End If
    'End Sub


    Private Sub txtPlayer1_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer1.TextChanged
        'data validation
        txtPlayer1.Text = System.Text.RegularExpressions.Regex.Replace(txtPlayer1.Text, "[^0-9]", "")
        txtPlayer1.Select(txtPlayer1.Text.Length, 0)
        lblFirstName1.Text = "Red"
        lblSurname1.Text = "Guest"
        lblKills1.Text = guestk1
        lblWins1.Text = guestw1
        lblKD1.Text = Format(guestk1 / Math.Max(guestd1, 1), "0.00")
        lblWL1.Text = Format(guestw1 / Math.Max(guestl1, 1), "0.00")
        p1Index = -1
        If txtPlayer1.TextLength = 9 Then
            Dim count = 0
            For Each row In dataS.Tables("StudentProfiles").Rows
                'check if student has been deleted
                If row("StudentID").ToString = txtPlayer1.Text Then
                    lblFirstName1.Text = row("FirstName")
                    lblSurname1.Text = row("Surname")
                    lblKills1.Text = row("Kills")
                    lblWins1.Text = row("Wins")
                    lblKD1.Text = Format(row("Kills") / Math.Max(row("Deaths"), 1), "0.00")
                    lblWL1.Text = Format(row("Wins") / Math.Max(row("Losses"), 1), "0.00")
                    p1Index = count
                End If
                count += 1
            Next
        End If
    End Sub

    Private Sub fight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetCueText(txtPlayer1, "Fencer 1 ID")
        SetCueText(txtPlayer2, "Fencer 2 ID")
        'MsgBox(ReceiveSerialData())
    End Sub
    'Function ReceiveSerialData() As String
    '    ' Receive strings from a serial port. 
    '    Dim returnStr As String = ""

    '    Dim com1 As IO.Ports.SerialPort = Nothing
    '    Try
    '        com1 = My.Computer.Ports.OpenSerialPort("COM2")
    '        com1.ReadTimeout = 10000
    '        Do
    '            Dim Incoming As String = com1.ReadLine()
    '            If Incoming Is Nothing Then
    '                Exit Do
    '            Else
    '                returnStr &= Incoming & vbCrLf
    '            End If
    '        Loop
    '    Catch ex As TimeoutException
    '        returnStr = "Error: Serial Port read timed out."
    '    Finally
    '        If com1 IsNot Nothing Then com1.Close()
    '    End Try

    '    Return returnStr
    'End Function
    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        'data validation
        txtLength.Text = System.Text.RegularExpressions.Regex.Replace(txtLength.Text, "[^0-9]", "")
        txtLength.Select(txtLength.Text.Length, 0)

    End Sub

    Private Sub txtPlayer2_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer2.TextChanged
        'data validation
        txtPlayer2.Text = System.Text.RegularExpressions.Regex.Replace(txtPlayer2.Text, "[^0-9]", "")
        txtPlayer2.Select(txtPlayer2.Text.Length, 0)
        lblFirstName2.Text = "Green"
        lblSurname2.Text = "Guest"
        lblKills2.Text = guestk2
        lblWins2.Text = guestw2
        lblKD2.Text = Format(guestk2 / Math.Max(guestd2, 1), "0.00")
        lblWL2.Text = Format(guestw2 / Math.Max(guestl2, 1), "0.00")
        p2index = -1
        If txtPlayer2.TextLength = 9 Then
            Dim count = 0
            For Each row In dataS.Tables("StudentProfiles").Rows
                'check if student has been deleted
                If row("StudentID").ToString = txtPlayer2.Text Then
                    lblFirstName2.Text = row("FirstName")
                    lblSurname2.Text = row("Surname")
                    lblKills2.Text = row("Kills")
                    lblWins2.Text = row("Wins")
                    lblKD2.Text = Format(row("Kills") / Math.Max(row("Deaths"), 1), "0.00")
                    lblWL2.Text = Format(row("Wins") / Math.Max(row("Losses"), 1), "0.00")
                    p2index = count

                End If
                count += 1
            Next
        End If
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        clock += 1
        lblTime.Text = Math.Floor(clock / 60).ToString + ":" + (clock Mod 60).ToString("D2")
        Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
    End Sub

    Private Sub fight_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If lock Then
            Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
        End If
    End Sub
    Private Sub btnBegin_MouseLeave(sender As Object, e As EventArgs) Handles btnBegin.MouseLeave
        If lock Then
            Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
        End If
    End Sub

    'Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
    '    If lock Then
    '        Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
    '    End If
    'End Sub

    'Private Sub panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
    '    If lock Then
    '        Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
    '    End If
    'End Sub

    'Private Sub panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
    '    If lock Then
    '        Windows.Forms.Cursor.Position = New Point(RootForm.Location.X + 110 + ((btnBegin.Left + btnBegin.Right) / 2), RootForm.Location.Y + 30 + ((btnBegin.Bottom + btnBegin.Top) / 2))
    '    End If
    'End Sub
End Class