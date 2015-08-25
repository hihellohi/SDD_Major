Public Class Calendar


    'General Notes:


    '1256 x 768 form size

    '
    '
    '   
    ' useful site for dates: https://msdn.microsoft.com/en-us/library/3eaydw6e.aspx
    '



    'For Datepicker
    'Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
    '    Me.Label1.Text = FormatDateTime(Me.DateTimePicker1.Value, DateFormat.LongDate)
    ' End Sub

    'useful site https://msdn.microsoft.com/en-us/library/bb384500(v=vs.90).aspx

    'Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
    '    Me.Label1.Text = FormatDateTime(Me.MonthCalendar1.SelectionRange.Start, DateFormat.LongDate)
    'End Sub


    '//social.msdn.microsoft.com/Forums/vstudio/en-US/00831ee0-bc68-4e3c-bdaf-a8a9559f0ee2/vbnet-monthview-calendar-with-events





    'This block here is for intialising Calendar
    Public Sub ReloadCal(ByVal InputDate As Date, ByVal Selected As Integer)
        Me.clearall()       'Clears the calendar
        Dim FirstDate As DayOfWeek = GetFirstOfMonthDay(InputDate)
        Dim DateCounter As Integer = 1
        Dim RowOfTheTable As Integer = 1          'Row of 
        Do
            getlabel(FirstDate, RowOfTheTable).Text = DateCounter       'getlabel returns a name of a control (label)
            If FirstDate = DayOfWeek.Saturday Then
                RowOfTheTable += 1
            End If
            FirstDate = IncrementTheDay(FirstDate)        'continually increments to the next day
            DateCounter += 1
            If DateCounter = Date.DaysInMonth(InputDate.Year, InputDate.Month) + 1 Then     'If the datecounter exceeds the number of days in the month of the inputted date, then exit
                Exit Do
            End If
        Loop
    End Sub
    'Clears all labels
    Sub clearall()
        su1.Text = ""
        su2.Text = ""
        su3.Text = ""
        su4.Text = ""
        su5.Text = ""
        su6.Text = ""

        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        m5.Text = ""
        m6.Text = ""

        tu1.Text = ""
        tu2.Text = ""
        tu3.Text = ""
        pansa3.Text = ""
        tu5.Text = ""
        tu6.Text = ""

        w1.Text = ""
        w2.Text = ""
        w3.Text = ""
        w4.Text = ""
        w5.Text = ""
        w6.Text = ""

        th1.Text = ""
        th2.Text = ""
        th3.Text = ""
        th4.Text = ""
        th5.Text = ""
        th6.Text = ""

        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
        f4.Text = ""
        f5.Text = ""
        f6.Text = ""

        sa1.Text = ""
        sa2.Text = ""
        sa3.Text = ""
        sa4.Text = ""
        sa5.Text = ""
        sa6.Text = ""
    End Sub
    'Returns name of label
    Function getlabel(ByVal FirstDate As DayOfWeek, ByVal RowOfTheTable As Integer) As System.Windows.Forms.Label
        Select Case FirstDate
            Case DayOfWeek.Sunday
                Select Case RowOfTheTable
                    Case 1
                        Return su1
                    Case 2
                        Return su2
                    Case 3
                        Return su3
                    Case 4
                        Return su4
                    Case 5
                        Return su5
                    Case 6
                        Return su6
                End Select
            Case DayOfWeek.Monday
                Select Case RowOfTheTable
                    Case 1
                        Return m1
                    Case 2
                        Return m2
                    Case 3
                        Return m3
                    Case 4
                        Return m4
                    Case 5
                        Return m5
                    Case 6
                        Return m6
                End Select
            Case DayOfWeek.Tuesday
                Select Case RowOfTheTable
                    Case 1
                        Return tu1
                    Case 2
                        Return tu2
                    Case 3
                        Return tu3
                    Case 4
                        Return tu4
                    Case 5
                        Return tu5
                    Case 6
                        Return tu6
                End Select
            Case DayOfWeek.Wednesday
                Select Case RowOfTheTable
                    Case 1
                        Return w1
                    Case 2
                        Return w2
                    Case 3
                        Return w3
                    Case 4
                        Return w4
                    Case 5
                        Return w5
                    Case 6
                        Return w6
                End Select
            Case DayOfWeek.Thursday
                Select Case RowOfTheTable
                    Case 1
                        Return th1
                    Case 2
                        Return th2
                    Case 3
                        Return th3
                    Case 4
                        Return th4
                    Case 5
                        Return th5
                    Case 6
                        Return th6
                End Select
            Case DayOfWeek.Friday
                Select Case RowOfTheTable
                    Case 1
                        Return f1
                    Case 2
                        Return f2
                    Case 3
                        Return f3
                    Case 4
                        Return f4
                    Case 5
                        Return f5
                    Case 6
                        Return f6
                End Select
            Case Else 'DayOfWeek.Saturday
                Select Case RowOfTheTable
                    Case 1
                        Return sa1
                    Case 2
                        Return sa2
                    Case 3
                        Return sa3
                    Case 4
                        Return sa4
                    Case 5
                        Return sa5
                    Case Else
                        Return sa6
                End Select
        End Select
    End Function
    'Gets the first day of the month for the month of the inputted date
    Private Function GetFirstOfMonthDay(ByVal InputDate As Date) As DayOfWeek
        Dim NameOfInputDay As DayOfWeek = InputDate.DayOfWeek
        Dim InputDateDay As Integer = InputDate.Day
        If InputDateDay = 1 Then        'The input date is the first day of the month
            Return NameOfInputDay
            Exit Function
        End If
        Do                      'counts backwards until it reaches 1/the first day of the month
            InputDateDay -= 1
            NameOfInputDay = IncrementTheDay(NameOfInputDay)
            If InputDateDay = 1 Then Exit Do
        Loop
        Return NameOfInputDay
    End Function
    'Continually increments the day
    Private Function IncrementTheDay(ByVal NameOfInputDay As DayOfWeek) As DayOfWeek
        Dim DayOfWeekToBeReturned As DayOfWeek
        Select Case NameOfInputDay
            Case DayOfWeek.Sunday               'As you can see, if its sunday, returns monday, if monday, returns tuesday etc. It returns the next day
                DayOfWeekToBeReturned = DayOfWeek.Monday
            Case DayOfWeek.Monday
                DayOfWeekToBeReturned = DayOfWeek.Tuesday
            Case DayOfWeek.Tuesday
                DayOfWeekToBeReturned = DayOfWeek.Wednesday
            Case DayOfWeek.Wednesday
                DayOfWeekToBeReturned = DayOfWeek.Thursday
            Case DayOfWeek.Thursday
                DayOfWeekToBeReturned = DayOfWeek.Friday
            Case DayOfWeek.Friday
                DayOfWeekToBeReturned = DayOfWeek.Saturday
            Case DayOfWeek.Saturday
                DayOfWeekToBeReturned = DayOfWeek.Sunday
        End Select
        Return DayOfWeekToBeReturned
    End Function



    'Loads database and starts intialisation of Calendar
    'For School: "Data Source = \\SR8137CF01-FS02\StudentUsers\2015\431538393\Desktop\Calendar.accdb"
    'For Laptop: "Data Source = C:\Users\Mystearica\Documents\Visual Studio 2012\Projects\WindowsApplication3\WindowsApplication3\Calendar.accdb"
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Ace.OLEDB.12.0;"
    Dim dbSource As String = "Data Source = \\SR8137CF01-FS02\StudentUsers\2015\431538393\Desktop\Calendar.accdb"
    Dim dataset As New DataSet
    Dim data_adapter As OleDb.OleDbDataAdapter
    Dim sql As String

    Dim Admin As Boolean = True

    Dim Key(0) As DataColumn
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FencingDataSet.Calendar' table. You can move, or remove it, as needed.
        Me.CalendarTableAdapter.Fill(Me.FencingDataSet.Calendar)

        'Initially sets right location of the calendar panel:
        ControlPanelCalendar.Left = 0
        ControlPanelCalendar.Top = 110
        ControlPanelCalendar.Width = 1281
        ControlPanelCalendar.Height = 658

        ControlPanelCalendar.Show()

        ControlPanelCalendar.BringToFront()




        ReloadCal(Now, Now.Day)

        LabelDetails.Text = "Viewing " & CStr(MonthName(Now.Month)) & " of " & CStr(Now.Year)

        sql = "Select * FROM Calendar"           'In here goes the NAME OF THE TABLE
        data_adapter = New OleDb.OleDbDataAdapter(sql, RootForm.connection)
        data_adapter.Fill(dataset, "Calendar")      'In here goes the NAME OF THE DATABASE


        'Admin section: restriction/access levels
        'In this calendar module, one may (essentially) view and update the database
        'One solution for difference in admin levels is to simply hide the update controls

        RadAdvSearchEventName.Checked = True

        Key(0) = dataset.Tables("Calendar").Columns("EventDate")
        dataset.Tables("Calendar").PrimaryKey = Key


        If Admin = True Then
            PanelControls.Visible = True
        Else : Admin = False
            PanelControls.Visible = False
        End If

        Populate_Table(currentmonth)
    End Sub





    'For going to next month/previous month
    Dim currentmonth As Date = Now
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click

        currentmonth = DateAdd(DateInterval.Month, 1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)

        Reset_All_Graphics()

        'CalendarGroupbox.text = Format(currentmonth, "MMMM") & " " & currentmonth.Year

        tu4.Visible = False                 'just a little bug

        Populate_Table(currentmonth)

        tu4.Visible = True

    End Sub
    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click

        currentmonth = DateAdd(DateInterval.Month, -1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)

        Reset_All_Graphics()

        'CalendarGroupbox.text = Format(currentmonth, "MMMM") & " " & currentmonth.Year

        tu4.Visible = False

        Populate_Table(currentmonth)

        tu4.Visible = True

    End Sub
    Public Sub Reset_All_Graphics()

        LabClickToBegin.Visible = True

        WarningEventName.Visible = False
        WarningTime.Visible = False
        WarningVenue.Visible = False
        WarningWeapon.Visible = False
        WarningGroup.Visible = False

        ButUpdate.Visible = False

        LabelDetails.Text = "Viewing " & CStr(MonthName(currentmonth.Month)) & " of " & CStr(currentmonth.Year)

        PanInput.Visible = False

        ButCommit.Visible = False
        ButAddNew.Visible = False
        ButCancel.Visible = False
        ButUpdate.Visible = False
        ButClear.Visible = False
        ButDelete.Visible = False
        ButPrint.Visible = False
        ButEdit.Visible = False

        LabNoEventScheduled.Visible = False
    End Sub


    'Populate table populates the table no shit
    'accesses the database and gets dates
    Dim DateArray() As String = {"su1", "su2", "su3", "su4", "su5", "su6", "m1", "m2", "m3", "m4", "m5", "m6", "tu1", "tu2", "tu3", "tu4", "tu5", "tu6", "w1", "w2", "w3", "w4", "w5", "w6", "th1", "th2", "th3", "th4", "th5", "th6", "f1", "f2", "f3", "f4", "f5", "f6", "sa1", "sa2", "sa3", "sa4", "sa5", "sa6"}
    Public Sub Populate_Table(ByVal currentmonth As Date)
        Dim TemporaryDataRow As DataRow
        For LabelDate = 0 To 41
            Dim NameOfLabel = DateArray(LabelDate)                                                      'This part gets the name as a control of the label
            Dim ControlNameForTextBox As Control = Nothing

            Dim JoinedStringNameOfTextBox = "Text" & NameOfLabel
            Dim SearchedTextBoxControls = Me.Controls.Find(key:=JoinedStringNameOfTextBox, searchAllChildren:=True)
            If SearchedTextBoxControls.Count = 1 Then
                ControlNameForTextBox = SearchedTextBoxControls(0)
            End If


            Try
                Dim TemporaryDatabaseDate As Date = Date_Clicked(NameOfLabel)                                        'Gets Date of the label to be used to index in database
                TemporaryDataRow = dataset.Tables("Calendar").Rows.Find(TemporaryDatabaseDate)
                If TemporaryDataRow(4) = "N/A" Then
                    ControlNameForTextBox.Text = TemporaryDataRow(1)
                Else
                    ControlNameForTextBox.Text = TemporaryDataRow(1) & " at " & TemporaryDataRow(4)
                End If
            Catch ex As Exception
                ControlNameForTextBox.Text = ""
            End Try
        Next
    End Sub






    'These three subs/functions are called frequently by other functions

    'This sub is called by another sub which passes to it the name of the box clicked
    'It will then return the date of the chosen box
    'RETURNS A DATE VALUE THAT IS THE DATE OF THE BOX CHOSEN
    Public Function Date_Clicked(ByVal TextboxClicked As String) As Date

        Select Case TextboxClicked
            Case "su1"
                If su1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su1.Text)
                End If
            Case "su2"
                If su2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su2.Text)
                End If
            Case "su3"
                If su3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su3.Text)
                End If
            Case "su4"
                If su4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su4.Text)
                End If
            Case "su5"
                If su5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su5.Text)
                End If
            Case "su6"
                If su6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su6.Text)
                End If





            Case "m1"
                If m1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m1.Text)
                End If
            Case "m2"
                If m2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m2.Text)
                End If
            Case "m3"
                If m3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m3.Text)
                End If
            Case "m4"
                If m4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m4.Text)
                End If
            Case "m5"
                If m5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m5.Text)
                End If
            Case "m6"
                If m6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m6.Text)
                End If




            Case "tu1"
                If tu1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu1.Text)
                End If
            Case "tu2"
                If tu2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu2.Text)
                End If
            Case "tu3"
                If tu3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu3.Text)
                End If
            Case "tu4"
                If tu4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu4.Text)
                End If
            Case "tu5"
                If tu5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu5.Text)
                End If
            Case "tu6"
                If tu6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu6.Text)
                End If




            Case "w1"
                If w1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w1.Text)
                End If
            Case "w2"
                If w2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w2.Text)
                End If
            Case "w3"
                If w3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w3.Text)
                End If
            Case "w4"
                If w4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w4.Text)
                End If
            Case "w5"
                If w5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w5.Text)
                End If
            Case "w6"
                If w6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w6.Text)
                End If




            Case "th1"
                If th1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th1.Text)
                End If
            Case "th2"
                If th2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th2.Text)
                End If
            Case "th3"
                If th3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th3.Text)
                End If
            Case "th4"
                If th4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th4.Text)
                End If
            Case "th5"
                If th5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th5.Text)
                End If
            Case "th6"
                If th6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th6.Text)
                End If




            Case "f1"
                If f1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f1.Text)
                End If
            Case "f2"
                If f2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f2.Text)
                End If
            Case "f3"
                If f3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f3.Text)
                End If
            Case "f4"
                If f4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f4.Text)
                End If
            Case "f5"
                If f5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f5.Text)
                End If
            Case "f6"
                If f6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f6.Text)
                End If




            Case "sa1"
                If sa1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa1.Text)
                End If
            Case "sa2"
                If sa2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa2.Text)
                End If
            Case "sa3"
                If sa3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa3.Text)
                End If
            Case "sa4"
                If sa4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa4.Text)
                End If
            Case "sa5"
                If sa5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa5.Text)
                End If
            Case "sa6"
                If sa6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa6.Text)
                End If

        End Select
    End Function


    'Caters to time from database to program
    Public Function Time_Database_To_Program(ByVal DatabaseTime As String)
        Select Case DatabaseTime
            Case "N/A"
                ComboBoxTime.SelectedItem = "N/A"
                RadioButtonAM.Checked = False
                RadioButtonPM.Checked = False

            Case "1 AM"
                ComboBoxTime.SelectedIndex = 1
                RadioButtonAM.Checked = True
            Case "2 AM"
                ComboBoxTime.SelectedIndex = 2
                RadioButtonAM.Checked = True
            Case "3 AM"
                ComboBoxTime.SelectedIndex = 3
                RadioButtonAM.Checked = True
            Case "4 AM"
                ComboBoxTime.SelectedIndex = 4
                RadioButtonAM.Checked = True
            Case "5 AM"
                ComboBoxTime.SelectedIndex = 5
                RadioButtonAM.Checked = True
            Case "6 AM"
                ComboBoxTime.SelectedIndex = 6
                RadioButtonAM.Checked = True
            Case "7 AM"
                ComboBoxTime.SelectedIndex = 7
                RadioButtonAM.Checked = True
            Case "8 AM"
                ComboBoxTime.SelectedIndex = 8
                RadioButtonAM.Checked = True
            Case "9 AM"
                ComboBoxTime.SelectedIndex = 9
                RadioButtonAM.Checked = True
            Case "10 AM"
                ComboBoxTime.SelectedIndex = 10
                RadioButtonAM.Checked = True
            Case "11 AM"
                ComboBoxTime.SelectedIndex = 11
                RadioButtonAM.Checked = True
            Case "12 AM"
                ComboBoxTime.SelectedIndex = 12
                RadioButtonAM.Checked = True



            Case "1 PM"
                ComboBoxTime.SelectedIndex = 1
                RadioButtonPM.Checked = True
            Case "2 PM"
                ComboBoxTime.SelectedIndex = 2
                RadioButtonPM.Checked = True
            Case "3 PM"
                ComboBoxTime.SelectedIndex = 3
                RadioButtonPM.Checked = True
            Case "4 PM"
                ComboBoxTime.SelectedIndex = 4
                RadioButtonPM.Checked = True
            Case "5 PM"
                ComboBoxTime.SelectedIndex = 5
                RadioButtonPM.Checked = True
            Case "6 PM"
                ComboBoxTime.SelectedIndex = 6
                RadioButtonPM.Checked = True
            Case "7 PM"
                ComboBoxTime.SelectedIndex = 7
                RadioButtonPM.Checked = True
            Case "8 PM"
                ComboBoxTime.SelectedIndex = 8
                RadioButtonPM.Checked = True
            Case "9 PM"
                ComboBoxTime.SelectedIndex = 9
                RadioButtonPM.Checked = True
            Case "10 PM"
                ComboBoxTime.SelectedIndex = 10
                RadioButtonPM.Checked = True
            Case "11 PM"
                ComboBoxTime.SelectedIndex = 11
                RadioButtonPM.Checked = True
            Case "12 PM"
                ComboBoxTime.SelectedIndex = 12
                RadioButtonPM.Checked = True

        End Select
    End Function
    'Caters to time from program to database
    Public Function Time_Program_To_Database()
        If ComboBoxTime.SelectedItem = "N/A" Then
            Return "N/A"

        ElseIf RadioButtonAM.Checked = True Then
            Return CStr(ComboBoxTime.SelectedItem) + " AM"

        ElseIf RadioButtonPM.Checked = True Then
            Return CStr(ComboBoxTime.SelectedItem) + " PM"

        End If

    End Function
    Private Sub ComboBoxTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTime.SelectedIndexChanged
        If ComboBoxTime.SelectedItem = "N/A" Then
            RadioButtonAM.Enabled = False
            RadioButtonPM.Enabled = False
        Else
            RadioButtonAM.Enabled = True
            RadioButtonPM.Enabled = True

        End If
    End Sub



    'This sub gets details from the database and then displays the info onto the panel only
    'For displaying of info onto virtual calendar, refer to Populate_Table
    Dim Row As DataRow
    Public Function Fill_In_Information_Tables(ByVal DatabaseDate As Date)          'Fills in the details for the panel

        Key(0) = dataset.Tables("Calendar").Columns("EventDate")
        dataset.Tables("Calendar").PrimaryKey = Key
        Row = dataset.Tables("Calendar").Rows.Find(DatabaseDate)

        TexEventName.Text = Row.Item(1)
        Time_Database_To_Program(Row.Item(4))
        TexVenue.Text = Row.Item(5)


        If Row.Item(6) = "No Weapon" Then
            ComboWeapon.SelectedIndex = 0
        ElseIf Row.Item(6) = "Foil" Then
            ComboWeapon.SelectedIndex = 1
        ElseIf Row.Item(6) = "Sabre" Then
            ComboWeapon.SelectedIndex = 2
        ElseIf Row.Item(6) = "Epee" Then
            ComboWeapon.SelectedIndex = 3
        End If

        TexGroup.Text = Row.Item(7)

    End Function




    'This sub gets details from the database and then displays the information using the sub fill_in_info
    Public Sub Get_Database_Details_For_Specified_Date(ByVal DatabaseDate As Date)

        LabClickToBegin.Visible = False

        If BlankDate = True Then        'Completely Blank Box

            LabelDetails.Text = "No Date"

            PanInput.Visible = False

            Hide_Buttons(False, False, False, False, False, False, False, False)

            LabNoEventScheduled.Visible = False

            BlankDate = False

        Else : BlankDate = False        'Box with a date, but not necessarily an entry in the database

            Try                         'Box with a date, and has an entry in the database
                Fill_In_Information_Tables(DatabaseDate)

                LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

                PanInput.Visible = True

                Hide_Buttons(False, False, False, False, False, True, True, True)

                LabNoEventScheduled.Visible = False

            Catch ex As Exception       'Box with a date, but has no entry in the database

                LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

                PanInput.Visible = False

                Hide_Buttons(True, False, False, False, False, False, False, False)

                LabNoEventScheduled.Visible = True

            End Try

        End If

    End Sub








    'Most of the buttons and important update function
    Dim updating As Boolean = False
    Dim adding As Boolean = False
    'EXTREMELY IMPORTANT SUB FOR UPDATING TO DATABASE which has fallen into disuse
    'For some reason, the update function is no longer needed for this program
    Private Function Update_to_Database()
        Dim cb As New OleDb.OleDbCommandBuilder(data_adapter)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        Try
            data_adapter.Update(dataset, "Calendar")
        Catch ex As Exception
            MsgBox("Change failed to save")
        End Try

    End Function




    'Below four subs are hardcode that perform some basic hiding/clearing/showing actions
    'Hides buttons
    Public Function Hide_Buttons(ByVal addnew As Boolean, commit As Boolean, cancel As Boolean, update As Boolean, clear As Boolean, delete As Boolean, print As Boolean, edit As Boolean)
        ButAddNew.Visible = addnew
        ButCommit.Visible = commit
        ButCancel.Visible = cancel
        ButUpdate.Visible = update
        ButClear.Visible = clear
        ButDelete.Visible = delete
        ButPrint.Visible = print
        ButEdit.Visible = edit
    End Function
    'Disables textboxes
    Public Function Disabling_Textboxes(ByVal Hiding As Boolean)
        If Hiding = True Then
            ComboWeapon.Enabled = False
            ComboBoxTime.Enabled = False
            RadioButtonAM.Enabled = False
            RadioButtonPM.Enabled = False
            TexEventName.ReadOnly = Hiding
            TexVenue.ReadOnly = Hiding
            TexGroup.ReadOnly = Hiding
        ElseIf Hiding = False Then
            ComboWeapon.Enabled = True
            ComboBoxTime.Enabled = True
            RadioButtonAM.Enabled = True
            RadioButtonPM.Enabled = True
            TexEventName.ReadOnly = Hiding
            TexVenue.ReadOnly = Hiding
            TexGroup.ReadOnly = Hiding
        End If

    End Function
    'Clear textboxes
    Public Function Clear_Text()
        TexEventName.Text = ""
        ComboBoxTime.SelectedIndex = 0
        RadioButtonAM.Checked = True
        TexVenue.Text = ""
        ComboWeapon.Text = ""
        ComboWeapon.SelectedItem = Nothing
        TexGroup.Text = ""
    End Function
    'Hide the warning exclamation marks
    Public Function Hide_Warnings()
        WarningEventName.Visible = False
        WarningTime.Visible = False
        WarningVenue.Visible = False
        WarningWeapon.Visible = False
        WarningGroup.Visible = False
    End Function





    'Most of the buttons
    Private Sub ButEdit_Click(sender As Object, e As EventArgs) Handles ButEdit.Click
        updating = True
        adding = False

        LabelDetails.Text = "Editing event on " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

        PanInput.Visible = True

        Hide_Buttons(False, False, True, True, True, False, False, False)

        LabNoEventScheduled.Visible = False

        TexEventName.ReadOnly = False
        ComboBoxTime.Enabled = True
        If ComboBoxTime.SelectedItem = "N/A" Then
            RadioButtonAM.Enabled = False
            RadioButtonPM.Enabled = False
        Else
            RadioButtonAM.Enabled = True
            RadioButtonPM.Enabled = True
        End If
        RadioButtonAM.Checked = True
        TexVenue.ReadOnly = False
        ComboWeapon.Enabled = True
        TexGroup.ReadOnly = False

    End Sub
    Private Sub ButUpdate_Click(sender As Object, e As EventArgs) Handles ButUpdate.Click            'For editing existing dates
        If ComboBoxTime.SelectedItem = Nothing Or TexEventName.Text = "" Or TexVenue.Text = "" Or ComboWeapon.SelectedItem = Nothing Or TexGroup.Text = "" Then

            If TexEventName.Text = "" Then
                WarningEventName.Visible = True
            Else
                WarningEventName.Visible = False
            End If
            If ComboBoxTime.SelectedItem = Nothing Then
                WarningTime.Visible = True
            Else
                WarningTime.Visible = False
            End If
            If TexVenue.Text = "" Then
                WarningVenue.Visible = True
            Else
                WarningVenue.Visible = False
            End If
            If ComboWeapon.SelectedItem = Nothing Then
                WarningWeapon.Visible = True
            Else
                WarningWeapon.Visible = False
            End If
            If TexGroup.Text = "" Then
                WarningGroup.Visible = True
            Else
                WarningGroup.Visible = False
            End If

            MsgBox("Please fill out required fields")

        Else        'All required fields with info

            Hide_Warnings()

            Row.Item(1) = TexEventName.Text
            Row.Item(2) = DatabaseDate
            Row.Item(3) = DatabaseDate.Day
            Row.Item(4) = Time_Program_To_Database()
            Row.Item(5) = TexVenue.Text

            If ComboWeapon.SelectedIndex = 0 Then
                Row.Item(6) = "No Weapon"
            ElseIf ComboWeapon.SelectedIndex = 1 Then
                Row.Item(6) = "Foil"
            ElseIf ComboWeapon.SelectedIndex = 2 Then
                Row.Item(6) = "Sabre"
            ElseIf ComboWeapon.SelectedIndex = 3 Then
                Row.Item(6) = "Epee"
            Else
                Row.Item(6) = "No Weapon"
            End If

            Row.Item(7) = TexGroup.Text

            If Volume = True Then
                My.Computer.Audio.Play("ding.wav")
            End If

            MsgBox("Information Updated")


            updating = False


            LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year
            PanInput.Visible = True
            Hide_Buttons(False, False, False, False, False, True, True, True)
            LabNoEventScheduled.Visible = False
            Disabling_Textboxes(True)


            Fill_In_Information_Tables(DatabaseDate)

            Populate_Table(currentmonth)

            Update_to_Database()
            data_adapter.Fill(dataset, "Calendar")

        End If




    End Sub
    Private Sub ButAddNew_Click(sender As Object, e As EventArgs) Handles ButAddNew.Click
        adding = True
        updating = False
        LabelDetails.Text = "Adding new event for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

        PanInput.Visible = True
        Hide_Warnings()
        Hide_Buttons(False, True, True, False, True, False, False, False)
        LabNoEventScheduled.Visible = False
        Disabling_Textboxes(False)
        Clear_Text()




    End Sub
    Private Sub ButCommit_Click(sender As Object, e As EventArgs) Handles ButCommit.Click          'For adding new dates
        If ComboBoxTime.SelectedItem = Nothing Or TexEventName.Text = "" Or TexVenue.Text = "" Or ComboWeapon.SelectedItem = Nothing Or TexGroup.Text = "" Then

            If TexEventName.Text = "" Then
                WarningEventName.Visible = True
            Else
                WarningEventName.Visible = False
            End If
            If ComboBoxTime.SelectedItem = Nothing Then
                WarningTime.Visible = True
            Else
                WarningTime.Visible = False
            End If
            If TexVenue.Text = "" Then
                WarningVenue.Visible = True
            Else
                WarningVenue.Visible = False
            End If
            If ComboWeapon.SelectedItem = Nothing Then
                WarningWeapon.Visible = True
            Else
                WarningWeapon.Visible = False
            End If
            If TexGroup.Text = "" Then
                WarningGroup.Visible = True
            Else
                WarningGroup.Visible = False
            End If

            MsgBox("Please fill out required fields")

        Else        'All required fields with info

            Hide_Warnings()

            Dim datasetNewRow As DataRow

            datasetNewRow = dataset.Tables("Calendar").NewRow()

            datasetNewRow.Item(1) = TexEventName.Text
            datasetNewRow.Item(2) = DatabaseDate
            datasetNewRow.Item(3) = DatabaseDate.Day
            datasetNewRow.Item(4) = Time_Program_To_Database()
            datasetNewRow.Item(5) = TexVenue.Text

            If ComboWeapon.SelectedIndex = 0 Then
                datasetNewRow.Item(6) = "No Weapon"
            ElseIf ComboWeapon.SelectedIndex = 1 Then
                datasetNewRow.Item(6) = "Foil"
            ElseIf ComboWeapon.SelectedIndex = 2 Then
                datasetNewRow.Item(6) = "Sabre"
            ElseIf ComboWeapon.SelectedIndex = 3 Then
                datasetNewRow.Item(6) = "Epee"
            Else
                datasetNewRow.Item(6) = "No Weapon"
            End If

            datasetNewRow.Item(7) = TexGroup.Text


            dataset.Tables("Calendar").Rows.Add(datasetNewRow)
            If Volume = True Then
                My.Computer.Audio.Play("ding.wav")
            End If
            MsgBox("New event added for the date: " & CStr(DatabaseDate))


            adding = False


            LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year
            PanInput.Visible = True
            Hide_Buttons(False, False, False, False, False, True, True, True)
            LabNoEventScheduled.Visible = False
            Disabling_Textboxes(True)


            Fill_In_Information_Tables(DatabaseDate)

            Populate_Table(currentmonth)


            Update_to_Database()
            data_adapter.Fill(dataset, "Calendar")

        End If




    End Sub
    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        Clear_Text()
    End Sub
    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Hide_Warnings()
        If updating = True Then
            LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

            PanInput.Visible = True
            Hide_Buttons(False, False, False, False, False, True, True, True)
            LabNoEventScheduled.Visible = False
            Disabling_Textboxes(True)
            updating = False
        ElseIf adding = True Then
            LabelDetails.Text = "Viewing details for " & CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & " " & DatabaseDate.Year

            PanInput.Visible = False
            Hide_Buttons(True, False, False, False, False, False, False, False)
            LabNoEventScheduled.Visible = True
            Disabling_Textboxes(True)
            adding = False
        End If



    End Sub
    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click

        If MessageBox.Show("Do you really want to delete this event?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            MsgBox("Delete cancelled")
            Exit Sub
        End If


        Row.Delete()

        PanInput.Visible = False

        Hide_Buttons(True, False, False, False, False, False, False, False)

        LabNoEventScheduled.Visible = True

        Populate_Table(currentmonth)


        Update_to_Database()



    End Sub



    Private Sub ButPrint_Click(sender As Object, e As EventArgs) Handles ButPrint.Click
        PrintEventName = TexEventName.Text
        PrintDate = CStr(DatabaseDate.Day) & " " & Format(DatabaseDate, "MMMM") & "/" & CStr(DatabaseDate.Month) & " " & CStr(DatabaseDate.Year)
        PrintVenue = TexVenue.Text
        PrintGroup = TexGroup.Text
        If ComboWeapon.SelectedIndex = 0 Then
            PrintWeapon = "No Weapon"
        ElseIf ComboWeapon.SelectedIndex = 1 Then
            PrintWeapon = "Foil"
        ElseIf ComboWeapon.SelectedIndex = 2 Then
            PrintWeapon = "Sabre"
        ElseIf ComboWeapon.SelectedIndex = 3 Then
            PrintWeapon = "Epee"
        Else
            PrintWeapon = "No Weapon"
        End If
        PrintTime = ComboBoxTime.SelectedItem
        PrintForm.Show()
    End Sub




    'Following code caters to graphics for viewdetails panel
    'allows moving of position and hide/show functions
    Dim MouseX = Cursor.Position.X
    Dim MouseY = Cursor.Position.Y
    Dim SearchHeld As Boolean = False
    Private Sub PicSearchSlider_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicSearchSlider.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SearchHeld = True
        End If
    End Sub
    Private Sub PicSearchSlider_MouseUp(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicSearchSlider.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SearchHeld = False
        End If
    End Sub

    Dim ScreenPos As Point
    Private Sub SlideTimer_Tick(sender As Object, e As EventArgs) Handles SlideTimer.Tick
        MouseX = Cursor.Position.X
        MouseY = Cursor.Position.Y

        ScreenPos = Me.PointToScreen(New Point(0, 0))           ''Gets x/y location of the panel instead of just mouse

        If SearchHeld = True Then
            PanelImportedCalendar.Left = MouseX - ScreenPos.X - Sliding_Constant - 35
            PanelImportedCalendar.Top = MouseY - ScreenPos.Y - 120
        End If
    End Sub

    'Caters to graphics for moving the calendar in the "Calendar" panel
    Dim Sliding_Constant As Integer = 92
    Private Sub ButExpandedView_Click(sender As Object, e As EventArgs) Handles ButExpandedView.Click
        PanelImportedCalendar.Left = 400
        PanelImportedCalendar.Top = 100

        PanelImportedCalendar.Width = 485
        PanelImportedCalendar.Height = 380

        MonthCalendar1.Width = 458
        MonthCalendar1.Height = 311

        PicSearchSlider.Left = 212

        Sliding_Constant = 212
    End Sub
    Private Sub ButMinimisedView_Click(sender As Object, e As EventArgs) Handles ButMinimisedView.Click
        PanelImportedCalendar.Left = 864
        PanelImportedCalendar.Top = 422

        PanelImportedCalendar.Width = 256
        PanelImportedCalendar.Height = 227

        MonthCalendar1.Width = 227
        MonthCalendar1.Height = 162

        PicSearchSlider.Left = 92

        Sliding_Constant = 92
    End Sub















    'Pressing the search button
    Private Sub ButSearch_Click(sender As Object, e As EventArgs) Handles ButSearch.Click
        If RadAdvSearchWeapon.Checked = True Then           'Searching in Weapon, four choices provided therefore wont require user input
            Advanced_Search()
        Else
            If TexSearch.Text = "" Then
                MsgBox("Please enter an event name")
            Else
                Advanced_Search()
            End If
        End If
    End Sub


    'Search Query Subroutine
    Dim SearchResults As New DataSet()
    Dim Mode_String As String           'used to check what search mode has been chosen

    'Buidls the command depending on what options are chosen
    Public Function Command_Builder() As String
        Dim command As String
        If CheckBoxAll.Checked = True Then
            If False Then 'CheckBoxEventName.Checked = False And CheckBoxGroup.Checked = False And CheckBoxVenue.Checked = False And CheckBoxWeapon.Checked = False Then
                MsgBox("Please select at least one field")
            Else
                command =
                "SELECT EventName, EventDate, Time, Venue, Weapon, Group " +
                "FROM Calendar " +
                "WHERE EventName LIKE @Search1 + '%' OR Venue LIKE @Search2 + '%' OR [Group] LIKE @Search3 + '%' OR Weapon LIKE @Search4 + '%' " +
                "ORDER BY EventName, Group, Weapon, Venue"
                Mode_String = "All"
                Return command

            End If
        Else
            If RadAdvSearchEventName.Checked = True Then
                command = "SELECT EventName, EventDate, Time, Venue, Weapon, Group " +
            "FROM Calendar " + "WHERE EventName LIKE @Search1 + '%'"
                Mode_String = "EventName"
                Return command
            ElseIf RadAdvSearchVenue.Checked = True Then
                command = "SELECT EventName, EventDate, Time, Venue, Weapon, Group " +
            "FROM Calendar " + "WHERE Venue LIKE @Search1 + '%'"
                Mode_String = "Venue"
                Return command
            ElseIf RadAdvSearchWeapon.Checked = True Then
                command = "SELECT EventName, EventDate, Time, Venue, Weapon, Group " +
            "FROM Calendar " + "WHERE Weapon LIKE @Search1 + '%'"
                Mode_String = "Weapon"
                Return command
            ElseIf RadAdvSearchGroup.Checked = True Then
                command = "SELECT EventName, EventDate, Time, Venue, Weapon, Group " +
            "FROM Calendar " + "WHERE [Group] LIKE @Search1 + '%'"      'note that for some reason group requires the square brackets. this is maybe because in the database it apparently doesnt require translation into unicode or something
                Mode_String = "Group"
                Return command
            End If
        End If



    End Function
    'Function that searches in database and then populates the table
    Private Sub Advanced_Search()
        Dim tempcommand = Command_Builder()
        Dim FoundResults As Integer = 0
        Dim SearchString As String = TexSearch.Text
        'Sets data adapter
        data_adapter = New OleDb.OleDbDataAdapter
        data_adapter.SelectCommand = New OleDb.OleDbCommand()


        If Mode_String = "All" Then             'Searching in all fields

            With data_adapter.SelectCommand
                .Connection = RootForm.connection
                .CommandText = tempcommand
                .Parameters.AddWithValue("@Search1", SearchString)
                .Parameters.AddWithValue("@Search2", SearchString)
                .Parameters.AddWithValue("@Search3", SearchString)
                .Parameters.AddWithValue("@Search4", SearchString)
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            data_adapter.Fill(SearchResults, "Calendar")

            'Populates the table with found items
            ListView1.Items.Clear()
            Dim A_Row As DataRow
            For Each A_Row In SearchResults.Tables("Calendar").Rows
                If A_Row.RowState <> DataRowState.Deleted Then
                    Dim rowItem = New ListViewItem(A_Row("EventName").ToString())
                    rowItem.SubItems.Add(A_Row("EventDate").ToString())
                    rowItem.SubItems.Add(A_Row("Time").ToString())
                    rowItem.SubItems.Add(A_Row("Venue").ToString())
                    rowItem.SubItems.Add(A_Row("Weapon").ToString())
                    rowItem.SubItems.Add(A_Row("Group").ToString())
                    ListView1.Items.Add(rowItem)
                    FoundResults += 1
                End If
            Next
            SearchResults.Clear()

            If FoundResults = 0 Then
                LabNoResultsFound.Visible = True
                LabNoResultsFound.Text = "No events found in any field called " & "'" & SearchString & "'"
            Else
                LabNoResultsFound.Visible = False
            End If


        ElseIf Mode_String = "Weapon" Then          'Searching only in weapon field, which is special as only four choices are provided

            Dim TempSearchString As String          'essentially searches the database with a string of one of the four choices
            If RadChoiceNoWeapon.Checked = True Then
                TempSearchString = "No Weapon"
            ElseIf RadChoiceFoil.Checked = True Then
                TempSearchString = "Foil"
            ElseIf RadChoiceSabre.Checked = True Then
                TempSearchString = "Sabre"
            ElseIf RadChoiceEpee.Checked = True Then
                TempSearchString = "Epee"
            Else
                TempSearchString = "No Weapon"
            End If



            With data_adapter.SelectCommand
                .Connection = RootForm.connection
                .CommandText = tempcommand
                .Parameters.AddWithValue("@Search1", TempSearchString)
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            data_adapter.Fill(SearchResults, "Calendar")

            'Populates table with found items
            ListView1.Items.Clear()
            Dim A_Row As DataRow
            For Each A_Row In SearchResults.Tables("Calendar").Rows
                If A_Row.RowState <> DataRowState.Deleted Then
                    Dim rowItem = New ListViewItem(A_Row("EventName").ToString())
                    rowItem.SubItems.Add(A_Row("EventDate").ToString())
                    rowItem.SubItems.Add(A_Row("Time").ToString())
                    rowItem.SubItems.Add(A_Row("Venue").ToString())
                    rowItem.SubItems.Add(A_Row("Weapon").ToString())
                    rowItem.SubItems.Add(A_Row("Group").ToString())
                    ListView1.Items.Add(rowItem)
                    FoundResults += 1
                End If
            Next
            SearchResults.Clear()

            If FoundResults = 0 Then
                LabNoResultsFound.Visible = True
                LabNoResultsFound.Text = "No events with " & TempSearchString
            Else
                LabNoResultsFound.Visible = False
            End If


        Else            'Searching in eventname/venue/group
            
            With data_adapter.SelectCommand
                .Connection = RootForm.connection
                .CommandText = tempcommand
                .Parameters.AddWithValue("@Search1", SearchString)
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            data_adapter.Fill(SearchResults, "Calendar")

            'Populates the table with found items
            ListView1.Items.Clear()
            Dim A_Row As DataRow
            For Each A_Row In SearchResults.Tables("Calendar").Rows
                If A_Row.RowState <> DataRowState.Deleted Then
                    Dim rowItem = New ListViewItem(A_Row("EventName").ToString())
                    rowItem.SubItems.Add(A_Row("EventDate").ToString())
                    rowItem.SubItems.Add(A_Row("Time").ToString())
                    rowItem.SubItems.Add(A_Row("Venue").ToString())
                    rowItem.SubItems.Add(A_Row("Weapon").ToString())
                    rowItem.SubItems.Add(A_Row("Group").ToString())
                    ListView1.Items.Add(rowItem)
                    FoundResults += 1
                End If
            Next
            SearchResults.Clear()

            If FoundResults = 0 Then
                LabNoResultsFound.Visible = True
                Select Case Mode_String
                    Case "Group"
                        LabNoResultsFound.Text = "No events for the group " & "'" & SearchString & "' found"
                    Case "Venue"
                        LabNoResultsFound.Text = "No events at the venue " & "'" & SearchString & "' found"
                    Case "EventName"
                        LabNoResultsFound.Text = "No events called " & "'" & SearchString & "' found"
                End Select
            Else
                LabNoResultsFound.Visible = False
            End If
        End If



    End Sub
    'Mostly monitors graphics and disables choices when the "All" check box is selected
    Private Sub CheckBoxAll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAll.CheckedChanged
        If CheckBoxAll.Checked = True Then
            RadAdvSearchEventName.Checked = False
            RadAdvSearchGroup.Checked = False
            RadAdvSearchVenue.Checked = False
            RadAdvSearchWeapon.Checked = False

            RadAdvSearchEventName.Enabled = False
            RadAdvSearchGroup.Enabled = False
            RadAdvSearchWeapon.Enabled = False
            RadAdvSearchVenue.Enabled = False
        Else
            RadAdvSearchEventName.Checked = True
            RadAdvSearchGroup.Checked = False
            RadAdvSearchVenue.Checked = False
            RadAdvSearchWeapon.Checked = False

            RadAdvSearchEventName.Enabled = True
            RadAdvSearchGroup.Enabled = True
            RadAdvSearchWeapon.Enabled = True
            RadAdvSearchVenue.Enabled = True
        End If


    End Sub
    'Only four choices for weapon, so there is a special function for it
    Private Sub RadAdvSearchWeapon_CheckedChanged(sender As Object, e As EventArgs) Handles RadAdvSearchWeapon.CheckedChanged
        If RadAdvSearchWeapon.Checked = True Then
            TexSearch.Enabled = False
            PanelWeaponChoices.Left += 150
        Else
            TexSearch.Enabled = True
            PanelWeaponChoices.Left -= 150
        End If
    End Sub






    'The two additional functions
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim DatabaseSearchDate As Date = MonthCalendar1.SelectionRange.Start.ToString()

        currentmonth = DatabaseSearchDate
        ReloadCal(currentmonth, currentmonth.Day)
        'CalendarGroupbox.text = Format(currentmonth, "MMMM") & " " & currentmonth.Year
        tu4.Visible = False
        Populate_Table(currentmonth)
        tu4.Visible = True

        Get_Database_Details_For_Specified_Date(DatabaseSearchDate)

        DatabaseDate = DatabaseSearchDate
    End Sub
    Private Sub ButViewDatabase_Click(sender As Object, e As EventArgs)
        CalendarTableView.Show()
    End Sub









    'For settings
    'Monitoring sound
    Dim Volume As Boolean = True
    Private Sub ButSaveVolume_Click(sender As Object, e As EventArgs) Handles ButSaveVolume.Click
        If RadVolumeOn.Checked = True Then
            Volume = True
            MsgBox("Volume is turned on")
        Else
            Volume = False
            MsgBox("Volume is turned off")
        End If
    End Sub


    'Resets position of either the panel for calendar or for the quicksearch function and then goes to the calendar panel
    Private Sub ButResetPosition_Click(sender As Object, e As EventArgs) Handles ButResetPosition.Click

        PanelImportedCalendar.Left = 864
        PanelImportedCalendar.Top = 422

        PanelImportedCalendar.Width = 256
        PanelImportedCalendar.Height = 227

        MonthCalendar1.Width = 227
        MonthCalendar1.Height = 162

        PicSearchSlider.Left = 92

        Sliding_Constant = 92

        MsgBox("Position reset")

        ControlPanelCalendar.Left = 0
        ControlPanelCalendar.Top = 110
        ControlPanelCalendar.Width = 1281
        ControlPanelCalendar.Height = 658

        ControlPanelCalendar.Show()

        ControlPanelCalendar.BringToFront()


    End Sub

    'Currently completely unused code
    'May be useful in future, for additional functions
    Private Sub CheckBoxResetPositionBoth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxResetPositionBoth.CheckedChanged
        If CheckBoxResetPositionBoth.Checked = True Then
            RadResetPositionCalendar.Enabled = False
            RadResetPositionSearch.Enabled = False
        Else
            RadResetPositionCalendar.Enabled = True
            RadResetPositionSearch.Enabled = True
        End If
    End Sub







    'buttons that open up the default panels
    Private Sub ButControlDatabaseView_Click(sender As Object, e As EventArgs) Handles ButControlDatabaseView.Click
        ControlPanelDatabaseView.Left = 0
        ControlPanelDatabaseView.Top = 110
        ControlPanelDatabaseView.Width = 1281
        ControlPanelDatabaseView.Height = 658

        ControlPanelDatabaseView.Show()

        ControlPanelDatabaseView.BringToFront()
    End Sub
    Private Sub ButControlSearch_Click(sender As Object, e As EventArgs) Handles ButControlSearch.Click


        ControlPanelSearch.Left = 0
        ControlPanelSearch.Top = 110
        ControlPanelSearch.Width = 1281
        ControlPanelSearch.Height = 658

        ControlPanelSearch.Show()

        ControlPanelSearch.BringToFront()
    End Sub
    Private Sub ButControlCalendar_Click(sender As Object, e As EventArgs) Handles ButControlCalendar.Click

        ControlPanelCalendar.Left = 0
        ControlPanelCalendar.Top = 110
        ControlPanelCalendar.Width = 1281
        ControlPanelCalendar.Height = 658

        ControlPanelCalendar.Show()

        ControlPanelCalendar.BringToFront()

    End Sub
    Private Sub ButSettings_Click(sender As Object, e As EventArgs) Handles ButSettings.Click

        ControlPanelSettings.Left = 0
        ControlPanelSettings.Top = 110
        ControlPanelSettings.Width = 1281
        ControlPanelSettings.Height = 658

        ControlPanelSettings.Show()

        ControlPanelSettings.BringToFront()
    End Sub



    'Simple graphics
    'Makes buttons seem to popup when hovered over
    Dim CalendarMovedUp As Boolean = False
    Dim SearchMovedUp As Boolean = False
    Dim DatabaseMovedUp As Boolean = False
    Private Sub ButControlCalendar_MouseHover(sender As Object, e As EventArgs) Handles ButControlCalendar.MouseHover
        If CalendarMovedUp = False Then
            ButControlCalendar.Top -= 20
            ButControlCalendar.Height += 20
            CalendarMovedUp = True
        End If
    End Sub
    Private Sub ButControlDatabaseView_MouseHover(sender As Object, e As EventArgs) Handles ButControlDatabaseView.MouseHover
        If DatabaseMovedUp = False Then
            ButControlDatabaseView.Top -= 20
            ButControlDatabaseView.Height += 20
            DatabaseMovedUp = True
        End If
    End Sub
    Private Sub ButControlSearch_MouseHover(sender As Object, e As EventArgs) Handles ButControlSearch.MouseHover
        If SearchMovedUp = False Then
            ButControlSearch.Top -= 20
            ButControlSearch.Height += 20
            SearchMovedUp = True
        End If
    End Sub

    Private Sub ButControlCalendar_MouseLeave(sender As Object, e As EventArgs) Handles ButControlCalendar.MouseLeave
        If CalendarMovedUp = True Then
            CalendarMovedUp = False
            ButControlCalendar.Top += 20
            ButControlCalendar.Height -= 20
        End If
    End Sub
    Private Sub ButControlDatabaseView_MouseLeave(sender As Object, e As EventArgs) Handles ButControlDatabaseView.MouseLeave
        If DatabaseMovedUp = True Then
            DatabaseMovedUp = False
            ButControlDatabaseView.Top += 20
            ButControlDatabaseView.Height -= 20
        End If
    End Sub
    Private Sub ButControlSearch_MouseLeave(sender As Object, e As EventArgs) Handles ButControlSearch.MouseLeave
        If SearchMovedUp = True Then
            SearchMovedUp = False
            ButControlSearch.Top += 20
            ButControlSearch.Height -= 20
        End If
    End Sub


















    'Hardcode that monitors keypresses
    Dim BlankDate As Boolean = False
    Dim DatabaseDate As Date
    Private Sub su1_Click(sender As Object, e As EventArgs) Handles Textsu1.Click, su1.Click, pansu1.Click
        If su1.Text = "" Then
            BlankDate = True
        End If

        DatabaseDate = Date_Clicked("su1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)

        'su1.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

        updating = False
        adding = False

    End Sub
    Private Sub su2_Click(sender As Object, e As EventArgs) Handles Textsu2.Click, su2.Click, pansu2.Click
        If su2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub su3_Click(sender As Object, e As EventArgs) Handles Textsu3.Click, su3.Click, pansu3.Click
        If su3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub su4_Click(sender As Object, e As EventArgs) Handles Textsu4.Click, su4.Click, pansu4.Click
        If su4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub su5_Click(sender As Object, e As EventArgs) Handles Textsu5.Click, su5.Click, pansu5.Click
        If su5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("su5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub su6_Click(sender As Object, e As EventArgs) Handles Textsu6.Click, su6.Click, pansu6.Click
        If su6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("su6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub m1_Click(sender As Object, e As EventArgs) Handles Textm1.Click, panm1.Click, m1.Click
        If m1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("m1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub m2_Click(sender As Object, e As EventArgs) Handles Textm2.Click, panm2.Click, m2.Click
        If m2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("m2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub m3_Click(sender As Object, e As EventArgs) Handles Textm3.Click, panm3.Click, m3.Click
        If m3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("m3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub m4_Click(sender As Object, e As EventArgs) Handles Textm4.Click, panm4.Click, m4.Click
        If m4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("m4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub m5_Click(sender As Object, e As EventArgs) Handles Textm5.Click, panm5.Click, m5.Click
        If m5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("m5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub m6_Click(sender As Object, e As EventArgs) Handles Textm6.Click, panm6.Click, m6.Click
        If m6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("m6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub tu1_Click(sender As Object, e As EventArgs) Handles tu1.Click, Texttu1.Click, pantu1.Click
        If tu1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("tu1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub tu2_Click(sender As Object, e As EventArgs) Handles tu2.Click, Texttu2.Click, pantu2.Click
        If tu2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("tu2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub tu3_Click(sender As Object, e As EventArgs) Handles tu3.Click, Texttu3.Click, pantu3.Click
        If tu3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("tu3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub tu4_Click(sender As Object, e As EventArgs) Handles Texttu4.Click, pantu4.Click
        If tu4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("tu4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub tu5_Click(sender As Object, e As EventArgs) Handles tu5.Click, Texttu5.Click, pantu5.Click
        If tu5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("tu5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub tu6_Click(sender As Object, e As EventArgs) Handles tu6.Click, Texttu6.Click, pantu6.Click
        If tu6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("tu6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub w1_Click(sender As Object, e As EventArgs) Handles w1.Click, Textw1.Click, panw1.Click
        If w1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("w1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub w2_Click(sender As Object, e As EventArgs) Handles w2.Click, Textw2.Click, panw2.Click
        If w2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("w2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub w3_Click(sender As Object, e As EventArgs) Handles w3.Click, Textw3.Click, panw3.Click
        If w3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("w3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub w4_Click(sender As Object, e As EventArgs) Handles w4.Click, Textw4.Click, panw4.Click
        If w4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("w4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub w5_Click(sender As Object, e As EventArgs) Handles w5.Click, Textw5.Click, panw5.Click
        If w5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("w5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub w6_Click(sender As Object, e As EventArgs) Handles w6.Click, Textw6.Click, panw6.Click
        If w6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("w6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub th1_Click(sender As Object, e As EventArgs) Handles th1.Click, Textth1.Click, panth1.Click
        If th1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("th1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub th2_Click(sender As Object, e As EventArgs) Handles th2.Click, Textth2.Click, panth2.Click
        If th2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("th2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub th3_Click(sender As Object, e As EventArgs) Handles th3.Click, Textth3.Click, panth3.Click
        If th3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("th3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub th4_Click(sender As Object, e As EventArgs) Handles th4.Click, Textth4.Click, panth4.Click
        If th4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("th4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub th5_Click(sender As Object, e As EventArgs) Handles th5.Click, Textth5.Click, panth5.Click
        If th5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("th5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub th6_Click(sender As Object, e As EventArgs) Handles th6.Click, Textth6.Click, panth6.Click
        If th6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("th6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub f1_Click(sender As Object, e As EventArgs) Handles Textf1.Click, panf1.Click, f1.Click
        If f1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("f1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub f2_Click(sender As Object, e As EventArgs) Handles Textf2.Click, panf2.Click, f2.Click
        If f2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("f2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub f3_Click(sender As Object, e As EventArgs) Handles Textf3.Click, panf3.Click, f3.Click
        If f3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("f3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub f4_Click(sender As Object, e As EventArgs) Handles Textf4.Click, panf4.Click, f4.Click
        If f4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("f4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub f5_Click(sender As Object, e As EventArgs) Handles Textf5.Click, panf5.Click, f5.Click
        If f5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("f5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub f6_Click(sender As Object, e As EventArgs) Handles Textf6.Click, panf6.Click, f6.Click
        If f6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("f6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub sa1_Click(sender As Object, e As EventArgs) Handles Textsa1.Click, sa1.Click, pansa1.Click
        If sa1.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("sa1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub sa2_Click(sender As Object, e As EventArgs) Handles Textsa2.Click, sa2.Click, pansa2.Click
        If sa2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("sa2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub sa3_Click(sender As Object, e As EventArgs) Handles Textsa3.Click, sa3.Click, pansa3.Click
        If sa3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("sa3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub sa4_Click(sender As Object, e As EventArgs) Handles Textsa4.Click, sa4.Click, pansa4.Click
        If sa4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("sa4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
        updating = False
        adding = False
    End Sub
    Private Sub sa5_Click(sender As Object, e As EventArgs) Handles Textsa5.Click, sa5.Click, pansa5.Click
        If sa5.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("sa5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub sa6_Click(sender As Object, e As EventArgs) Handles Textsa6.Click, sa6.Click, pansa6.Click
        If sa6.Text = "" Then
            BlankDate = True

        End If
        updating = False
        adding = False
        DatabaseDate = Date_Clicked("sa6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub

End Class
Public Module GlobalVariablesModule
    Public PrintEventName As String
    Public PrintGroup As String
    Public PrintDate As String
    Public PrintVenue As String
    Public PrintWeapon As String
    Public PrintTime As String
End Module
