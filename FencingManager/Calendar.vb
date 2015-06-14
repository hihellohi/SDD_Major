Public Class Calendar
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


    'For intialising Calendar
    Public Sub ReloadCal(ByVal ldate As Date, ByVal Selected As Integer)
2:
        On Error Resume Next
3:
        Me.clearall()
4:
        'MonthName.Text = monthstr(ldate.Month)

5:
        Dim fdate As DayOfWeek = GetFirstOfMonthDay(ldate)
6:
        Dim idate As Integer = 1
7:
        Dim row As Integer = 1
8:
        Do
9:
            getlabel(fdate, row).Text = idate
10:
            getlabel(fdate, row).ForeColor = MonthName.ForeColor
11:
            If idate = Selected Then
12:
                getlabel(fdate, row).ForeColor = Color.Black
13:
            End If
14:
            If fdate = DayOfWeek.Saturday Then
15:
                row += 1
16:
            End If
17:
            fdate = tdate(fdate)
18:
            idate += 1
19:
            If idate = Date.DaysInMonth(ldate.Year, ldate.Month) + 1 Then
20:
                Exit Do
21:
            End If
22:
        Loop
23:
    End Sub
    Sub clearall()
2:
        su1.Text = ""
3:
        su2.Text = ""
4:
        su3.Text = ""
5:
        su4.Text = ""
6:
        su5.Text = ""
7:
        su6.Text = ""
8:

9:
        m1.Text = ""
10:
        m2.Text = ""
11:
        m3.Text = ""
12:
        m4.Text = ""
13:
        m5.Text = ""
14:
        m6.Text = ""
15:

16:
        tu1.Text = ""
17:
        tu2.Text = ""
18:
        tu3.Text = ""
19:
        pansa3.Text = ""
20:
        tu5.Text = ""
21:
        tu6.Text = ""
22:

23:
        w1.Text = ""
24:
        w2.Text = ""
25:
        w3.Text = ""
26:
        w4.Text = ""
27:
        w5.Text = ""
28:
        w6.Text = ""
29:

30:
        th1.Text = ""
31:
        th2.Text = ""
32:
        th3.Text = ""
33:
        th4.Text = ""
34:
        th5.Text = ""
35:
        th6.Text = ""
36:

37:
        f1.Text = ""
38:
        f2.Text = ""
39:
        f3.Text = ""
40:
        f4.Text = ""
41:
        f5.Text = ""
42:
        f6.Text = ""
43:

44:
        sa1.Text = ""
45:
        sa2.Text = ""
46:
        sa3.Text = ""
47:
        sa4.Text = ""
48:
        sa5.Text = ""
49:
        sa6.Text = ""
50:
    End Sub
    Function getlabel(ByVal day As DayOfWeek, ByVal row As Integer) As System.Windows.Forms.Label
2:
        Select Case day

            Case DayOfWeek.Sunday
4:
                Select Case row

                    Case 1
6:
                        Return su1
7:
                    Case 2
8:
                        Return su2
9:
                    Case 3
10:
                        Return su3
11:
                    Case 4
12:
                        Return su4
13:
                    Case 5
14:
                        Return su5
15:
                    Case 6
16:
                        Return su6
17:
                End Select
18:
            Case DayOfWeek.Monday
                Select Case row

                    Case 1
21:
                        Return m1
22:
                    Case 2
23:
                        Return m2
24:
                    Case 3
25:
                        Return m3
26:
                    Case 4
27:
                        Return m4
28:
                    Case 5
29:
                        Return m5
30:
                    Case 6
31:
                        Return m6
32:
                End Select
33:
            Case DayOfWeek.Tuesday
34:
                Select Case row

                    Case 1
36:
                        Return tu1
37:
                    Case 2
38:
                        Return tu2
39:
                    Case 3
40:
                        Return tu3
41:
                    Case 4
42:
                        Return tu4
43:
                    Case 5
44:
                        Return tu5
45:
                    Case 6
46:
                        Return tu6
47:
                End Select
48:
            Case DayOfWeek.Wednesday
49:
                Select Case row

                    Case 1
51:
                        Return w1
52:
                    Case 2
53:
                        Return w2
54:
                    Case 3
55:
                        Return w3
56:
                    Case 4
57:
                        Return w4
58:
                    Case 5
59:
                        Return w5
60:
                    Case 6
61:
                        Return w6
62:
                End Select
63:
            Case DayOfWeek.Thursday
64:
                Select Case row

                    Case 1
66:
                        Return th1
67:
                    Case 2
68:
                        Return th2
69:
                    Case 3
70:
                        Return th3
71:
                    Case 4
72:
                        Return th4
73:
                    Case 5
74:
                        Return th5
75:
                    Case 6
76:
                        Return th6
77:
                End Select
78:
            Case DayOfWeek.Friday
79:
                Select Case row

                    Case 1
81:
                        Return f1
82:
                    Case 2
83:
                        Return f2
84:
                    Case 3
85:
                        Return f3
86:
                    Case 4
87:
                        Return f4
88:
                    Case 5
89:
                        Return f5
90:
                    Case 6
91:
                        Return f6
92:
                End Select
93:
            Case Else 'DayOfWeek.Saturday
94:
                Select Case row

                    Case 1
96:
                        Return sa1
97:
                    Case 2
98:
                        Return sa2
99:
                    Case 3
100:
                        Return sa3
101:
                    Case 4
102:
                        Return sa4
103:
                    Case 5
104:
                        Return sa5
105:
                    Case Else
106:
                        Return sa6
107:
                End Select
108:
        End Select
109:
    End Function
    Private Function GetFirstOfMonthDay(ByVal ThisDay As Date) As DayOfWeek
112:
        Dim tday As DayOfWeek = ThisDay.DayOfWeek
113:
        Dim tint As Integer = ThisDay.Day
114:
        If tint = 1 Then
115:
            Return tday
116:
            Exit Function
117:
        End If
118:
        Do
119:
            tint -= 1
120:
            tday = ydate(tday)
121:
            If tint = 1 Then Exit Do
122:
        Loop
123:
        Return tday
124:
    End Function
    Private Function ydate(ByVal tday As DayOfWeek) As DayOfWeek
127:
        Dim rday As DayOfWeek
128:
        Select Case tday

            Case DayOfWeek.Sunday
130:
                rday = DayOfWeek.Saturday
131:
            Case DayOfWeek.Monday
132:
                rday = DayOfWeek.Sunday
133:
            Case DayOfWeek.Tuesday
134:
                rday = DayOfWeek.Monday
135:
            Case DayOfWeek.Wednesday
136:
                rday = DayOfWeek.Tuesday
137:
            Case DayOfWeek.Thursday
138:
                rday = DayOfWeek.Wednesday
139:
            Case DayOfWeek.Friday
140:
                rday = DayOfWeek.Thursday
141:
            Case DayOfWeek.Saturday
142:
                rday = DayOfWeek.Friday
143:
        End Select
144:
        Return rday
145:
    End Function
    Private Function tdate(ByVal tday As DayOfWeek) As DayOfWeek
148:
        Dim rday As DayOfWeek
149:
        Select Case tday

            Case DayOfWeek.Sunday
151:
                rday = DayOfWeek.Monday
152:
            Case DayOfWeek.Monday
153:
                rday = DayOfWeek.Tuesday
154:
            Case DayOfWeek.Tuesday
155:
                rday = DayOfWeek.Wednesday
156:
            Case DayOfWeek.Wednesday
157:
                rday = DayOfWeek.Thursday
158:
            Case DayOfWeek.Thursday
159:
                rday = DayOfWeek.Friday
160:
            Case DayOfWeek.Friday
161:
                rday = DayOfWeek.Saturday
162:
            Case DayOfWeek.Saturday
163:
                rday = DayOfWeek.Sunday
164:
        End Select
165:
        Return rday
166:
    End Function
    Public Function monthstr(ByVal month As Integer) As String
169:
        Select Case month

            Case 1
171:
                Return "January"
172:
            Case 2
173:
                Return "Febuary"
174:
            Case 3
175:
                Return "March"
176:
            Case 4
177:
                Return "April"
178:
            Case 5
179:
                Return "May"
180:
            Case 6
181:
                Return "June"
182:
            Case 7
183:
                Return "July"
184:
            Case 8
185:
                Return "August"
186:
            Case 9
187:
                Return "September"
188:
            Case 10
189:
                Return "October"
190:
            Case 11
191:
                Return "November"
192:
            Case Else
                Return "December"
194:
        End Select
195:
    End Function



    'Loads database and starts intialisation of Calendar
    'Dim dbProvider As String = "PROVIDER=Microsoft.Ace.OLEDB.12.0;"

    'Dim dbSource As String = My.Settings.con
    'For School: "Data Source = \\SR8137CF01-FS02\StudentUsers\2015\431538393\Desktop\Calendar.accdb"
    'For Laptop: "Data Source = C:\Users\Mystearica\Documents\Visual Studio 2012\Projects\WindowsApplication3\WindowsApplication3\Calendar.accdb"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCal(Now, Now.Day)
        MonthName.Text = FormatDateTime(Now, DateFormat.LongDate)

        'con.ConnectionString = dbProvider & dbSource

        'con.Open()

        sql = "Select * FROM Calendar"
        da = New OleDb.OleDbDataAdapter(sql, RootForm.connection)
        da.Fill(ds, "Calendar")

        con.Close()

        CalendarGroupBox.Text = Format(Now, "MMMM") & " " & Now.Year


    End Sub




    'For going to next month/previous month
    Dim currentmonth As Date = Now
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click

        currentmonth = DateAdd(DateInterval.Month, 1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)
        MonthName.Text = FormatDateTime(currentmonth, DateFormat.LongDate)
        CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year
    End Sub
    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click

        currentmonth = DateAdd(DateInterval.Month, -1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)
        MonthName.Text = FormatDateTime(currentmonth, DateFormat.LongDate)
        CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year
    End Sub





    'Clicking on all those effing txtboxes omfg the hard code
    Public Function Date_Clicked(ByVal TextboxClicked As String) As Date

        Select Case TextboxClicked
            Case "Textsu1"
                If su1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su1.Text)
                End If
            Case "Textsu2"
                If su2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su2.Text)
                End If
            Case "Textsu3"
                If su3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su3.Text)
                End If
            Case "Textsu4"
                If su4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su4.Text)
                End If
            Case "Textsu5"
                If su5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su5.Text)
                End If
            Case "Textsu6"
                If su6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, su6.Text)
                End If





            Case "Textm1"
                If m1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m1.Text)
                End If
            Case "Textm2"
                If m2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m2.Text)
                End If
            Case "Textm3"
                If m3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m3.Text)
                End If
            Case "Textm4"
                If m4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m4.Text)
                End If
            Case "Textm5"
                If m5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m5.Text)
                End If
            Case "Textm6"
                If m6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, m6.Text)
                End If




            Case "Texttu1"
                If tu1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu1.Text)
                End If
            Case "Texttu2"
                If tu2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu2.Text)
                End If
            Case "Texttu3"
                If tu3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu3.Text)
                End If
            Case "Texttu4"
                If tu4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu4.Text)
                End If
            Case "Texttu5"
                If tu5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu5.Text)
                End If
            Case "Texttu6"
                If tu6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, tu6.Text)
                End If




            Case "Textw1"
                If w1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w1.Text)
                End If
            Case "Textw2"
                If w2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w2.Text)
                End If
            Case "Textw3"
                If w3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w3.Text)
                End If
            Case "Textw4"
                If w4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w4.Text)
                End If
            Case "Textw5"
                If w5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w5.Text)
                End If
            Case "Textw6"
                If w6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, w6.Text)
                End If




            Case "Textth1"
                If th1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th1.Text)
                End If
            Case "Textth2"
                If th2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th2.Text)
                End If
            Case "Textth3"
                If th3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th3.Text)
                End If
            Case "Textth4"
                If th4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th4.Text)
                End If
            Case "Textth5"
                If th5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th5.Text)
                End If
            Case "Textth6"
                If th6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, th6.Text)
                End If




            Case "Textf1"
                If f1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f1.Text)
                End If
            Case "Textf2"
                If f2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f2.Text)
                End If
            Case "Textf3"
                If f3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f3.Text)
                End If
            Case "Textf4"
                If f4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f4.Text)
                End If
            Case "Textf5"
                If f5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f5.Text)
                End If
            Case "Textf6"
                If f6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, f6.Text)
                End If




            Case "Textsa1"
                If sa1.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa1.Text)
                End If
            Case "Textsa2"
                If sa2.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa2.Text)
                End If
            Case "Textsa3"
                If sa3.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa3.Text)
                End If
            Case "Textsa4"
                If sa4.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa4.Text)
                End If
            Case "Textsa5"
                If sa5.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa5.Text)
                End If
            Case "Textsa6"
                If sa6.Text = "" Then

                Else
                    Return New Date(currentmonth.Year, currentmonth.Month, sa6.Text)
                End If

        End Select
    End Function





    'Some comments
    'Thought Process:
    'Clicking on a richtextbox (eg. Textsu1)
    'This accesses one of the click subroutines (eg. su1_Click)
    'The subroutine will access the function Date_clicked 
    '   The function Date_Clicked will return either Invalid (in which case nothing is done)
    '   Or it will return NewDate which is a Date
    'The subroutine has the variable
    'It will set a new variable DatabaseDate as the old variable
    'This new variable will be used to access the Database

    'Now, a new function Create_inc will create a variable which:
    '   effectively converts a date to an integer
    '   in the form of an index for the database
    '   ie. 29/01/2015 will become 29012015
    'inc will now be used to access and load forms which display information 'Need to use ID eg. 01112015
    'Search in Database for that ID
    'Get row of said ID
    'set inc to that row

    'ID = Create_ID(DatabaseDate)            'makes date into ID value
    'Row = Find_Row(ID)                      'gets the data row which contains the ID value
    'NavigateRecords(Row)                    'Displays relevant information 

    'Public Function Create_ID(ByVal DatabaseDate As Date) As String

    '    Dim DDay As String
    '    Dim DMonth As String


    '    If DatabaseDate.Day <= 9 Then
    '        DDay = "0" & CStr(DatabaseDate.Day)
    '    Else
    '        DDay = CStr(DatabaseDate.Day)
    '    End If
    '    If DatabaseDate.Month <= 9 Then
    '        DMonth = "0" & CStr(DatabaseDate.Month)
    '    Else
    '        DMonth = CStr(DatabaseDate.Month)
    '    End If

    '    ' textlabel.Text = DDay & DMonth & CStr(DatabaseDate.Year)

    '    'textlabel.Text = CStr(DatabaseDate.Day) & CStr(DatabaseDate.Month) & CStr(DatabaseDate.Year)
    '    ID = DDay & DMonth & CStr(DatabaseDate.Year)
    '    Return ID
    'End Function


    'Public Function Find_Row(ByVal ID As String) As DataRow
    '    Dim Key(0) As DataColumn
    '    Key(0) = ds.Tables("Calendar").Columns("ID")
    '    ds.Tables("Calendar").PrimaryKey = Key


    '    randomrow = ds.Tables("Calendar").Rows.Find(ID)
    '    Return randomrow
    'End Function

    'Private Sub NavigateRecords(ByVal Row As DataRow)
    '    If Row Is Nothing Then
    '        Me.BackColor = Color.Blue
    '    Else
    '        labEventname.Text = Row.Item(1)
    '        labEventDate.Text = Row.Item(2)
    '        labTime.Text = Row.Item(4)
    '        labVenue.Text = Row.Item(5)
    '        labGroup.Text = Row.Item(7)

    '        'For weapon
    '        If Row.Item(6) = 1 Then
    '            labWeapon.Text = "Foil"
    '        ElseIf Row.Item(6) = 2 Then
    '            labWeapon.Text = "Sabre"
    '        ElseIf Row.Item(6) = 3 Then
    '            labWeapon.Text = "Epee"
    '        Else
    '            labWeapon.Text = "Unspecified"
    '        End If
    '    End If
    'End Sub



    'Initialisation of Database Variables

    'Database Code
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim DatabaseDate As Date
    Dim ID As String


    Dim Row As DataRow



    'Dis be the massive sub filled with hardcode
    'nah jks
    Public Sub Get_Database_Details_For_Specified_Date(ByVal DatabaseDate As Date)
        Dim DDay As String
        Dim DMonth As String



        ''Resetting labels and crap
        'labEventDate.Visible = True
        'labEventname.Visible = True
        'labGroup.Visible = True
        'labTime.Visible = True
        'labWeapon.Visible = True
        'labVenue.Visible = True

        'ButAddNewEvent.Visible = False
        'ButAddNewEvent.Enabled = False

        'NamEventDate.Visible = True
        'NamEventName.Visible = True
        'NamGroup.Visible = True
        'NamTime.Visible = True
        'NamWeapon.Visible = True
        'NamVenue.Visible = True


        If I <> "01011" Then      'Index not invalid
            'Making reference ID
            If DatabaseDate.Day <= 9 Then
                DDay = "0" & CStr(DatabaseDate.Day)
            Else
                DDay = CStr(DatabaseDate.Day)
            End If
            If DatabaseDate.Month <= 9 Then
                DMonth = "0" & CStr(DatabaseDate.Month)
            Else
                DMonth = CStr(DatabaseDate.Month)
            End If
            ID = DDay & DMonth & CStr(DatabaseDate.Year)
        Else
            ID = "01011"

        End If






        'Finding Row of Information which has reference ID
        Dim Key(0) As DataColumn
        Key(0) = ds.Tables("Calendar").Columns("ID")
        ds.Tables("Calendar").PrimaryKey = Key
        Row = ds.Tables("Calendar").Rows.Find(ID)


        'Returns values for testing
        'testlabel.Text = ID
        'testlabel1.Text = I


        'Displaying relevant Information

        If ID = "01011" Then   'No Date available for date clicked 

            LabInformOfNoEvent.Visible = False


            EditDate.Visible = False


            NamEventDate.Visible = False
            NamEventName.Visible = False
            NamGroup.Visible = False
            NamTime.Visible = False
            NamWeapon.Visible = False
            NamVenue.Visible = False

            ButEdit.Visible = False                 'Can't edit an empty date
            ButAddNewEvent.Visible = False          'Can't add event to an empty date

            labEventDate.Visible = False
            labEventname.Visible = False
            labGroup.Visible = False
            labTime.Visible = False
            labWeapon.Visible = False
            labVenue.Visible = False

            MonthName.Text = ""
            ViewDetails.Text = "No date available"

        Else                    'For valid dates, but not necessarily having a location in the database


            Try                 'event on that day
                LabInformOfNoEvent.Visible = False


                If EditDate.Text = "Editing event on " & FormatDateTime(DatabaseDate, DateFormat.LongDate) Then
                    EditDate.Visible = True         'same day selected so editing panel should not be hidden
                Else
                    EditDate.Visible = False        'different day selected
                End If


                'For most of the fields except weapon, which is below
                labEventname.Text = Row.Item(1)
                labEventDate.Text = Row.Item(2)
                labTime.Text = Row.Item(4)
                labVenue.Text = Row.Item(5)
                labGroup.Text = Row.Item(7)

                'For weapon
                If Row.Item(6) = 1 Then
                    labWeapon.Text = "Foil"
                ElseIf Row.Item(6) = 2 Then
                    labWeapon.Text = "Sabre"
                ElseIf Row.Item(6) = 3 Then
                    labWeapon.Text = "Epee"
                Else
                    labWeapon.Text = "Unspecified"
                End If


                'This part beneath caters to the hiding of fields
                'So people cant just randomly enter shit
                labEventDate.Visible = True
                labEventname.Visible = True
                labGroup.Visible = True
                labTime.Visible = True
                labWeapon.Visible = True
                labVenue.Visible = True

                ButAddNewEvent.Visible = False      'For Add New Event button
                ButEdit.Visible = True              'For Edit button

                NamEventDate.Visible = True
                NamEventName.Visible = True
                NamGroup.Visible = True
                NamTime.Visible = True
                NamWeapon.Visible = True
                NamVenue.Visible = True

                MonthName.Text = FormatDateTime(DatabaseDate, DateFormat.LongDate)      'setting label to date (simply info). may be removed
                ViewDetails.Text = FormatDateTime(DatabaseDate, DateFormat.LongDate)    'setting the text of the panel to date



            Catch ex As Exception           'no event on that day

                If EditDate.Text = "Adding new event for " & FormatDateTime(DatabaseDate, DateFormat.LongDate) Then
                    EditDate.Visible = True         'same day selected so editing panel should not be hidden
                Else
                    EditDate.Visible = False        'different day selected
                End If


                'setting to date
                MonthName.Text = FormatDateTime(DatabaseDate, DateFormat.LongDate)
                ViewDetails.Text = FormatDateTime(DatabaseDate, DateFormat.LongDate)

                'A non-changing label to inform that there is no event on that day
                LabInformOfNoEvent.Visible = True

                'This part beneath caters to the hiding of fields
                'So people cant just randomly enter shit
                NamEventDate.Visible = False
                NamEventName.Visible = False
                NamGroup.Visible = False
                NamTime.Visible = False
                NamWeapon.Visible = False
                NamVenue.Visible = False

                ButAddNewEvent.Visible = True
                ButEdit.Visible = False

                labEventDate.Visible = False
                labEventname.Visible = False
                labGroup.Visible = False
                labTime.Visible = False
                labWeapon.Visible = False
                labVenue.Visible = False
            End Try

        End If


        'Resetting variables
        I = ""
        ID = ""

        '            On Error GoTo Handler   'this is for valid dates that have nothing registered on that day

        '            labEventname.Text = Row.Item(1)
        '            labEventDate.Text = Row.Item(2)
        '            labTime.Text = Row.Item(4)
        '            labVenue.Text = Row.Item(5)
        '            labGroup.Text = Row.Item(7)

        '            'For weapon
        '            If Row.Item(6) = 1 Then
        '                labWeapon.Text = "Foil"
        '            ElseIf Row.Item(6) = 2 Then
        '                labWeapon.Text = "Sabre"
        '            ElseIf Row.Item(6) = 3 Then
        '                labWeapon.Text = "Epee"
        '            Else
        '                labWeapon.Text = "Unspecified"
        '            End If

        '            labEventDate.Visible = True
        '            labEventname.Visible = True
        '            labGroup.Visible = True
        '            labTime.Visible = True
        '            labWeapon.Visible = True
        '            labVenue.Visible = True

        '            ButAddNewEvent.Visible = False
        '            ButEdit.Visible = True

        '            NamEventDate.Visible = True
        '            NamEventName.Visible = True
        '            NamGroup.Visible = True
        '            NamTime.Visible = True
        '            NamWeapon.Visible = True
        '            NamVenue.Visible = True


        '            Exit Sub


        'Handler:    NamEventDate.Visible = False
        '            NamEventName.Visible = False
        '            NamGroup.Visible = False
        '            NamTime.Visible = False
        '            NamWeapon.Visible = False
        '            NamVenue.Visible = False

        '            ButAddNewEvent.Visible = True
        '            ButEdit.Visible = False

        '            labEventDate.Visible = False
        '            labEventname.Visible = False
        '            labGroup.Visible = False
        '            labTime.Visible = False
        '            labWeapon.Visible = False
        '            labVenue.Visible = False

        '            Resume Next



    End Sub




    'Gets index of Row
    Dim counter As Integer = -1
    Public Function Find_Row_Index(ByVal Row As DataRow) As Integer

        Do
            counter = counter + 1
        Loop Until ds.Tables("Calendar").Rows(counter).Item(0) = Row.Item(0)

        Return counter
        counter = -1
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Find_Row_Index(Row)

    End Sub





    'This part caters to the two buttons on the display details panel
    'This will need a lot of work
    Private Sub ButEdit_Click(sender As Object, e As EventArgs) Handles ButEdit.Click
        EditDate.Visible = True
        EditDate.Text = "Editing event on " & MonthName.Text

    End Sub

    Private Sub ButAddNewEvent_Click(sender As Object, e As EventArgs) Handles ButAddNewEvent.Click
        EditDate.Visible = True
        EditDate.Text = "Adding new event for " & MonthName.Text

    End Sub




    'This part caters to the three buttons on the editing/adding new event panel

    'Update is the hardest

    Dim UpdateConfirmed As Boolean = False
    Dim Index_Of_Row As Integer
    Private Sub butUpdate_Click(sender As Object, e As EventArgs) Handles butUpdate.Click

        con.Open()

        Index_Of_Row = Find_Row_Index(Row)

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If txtEventName.Text = "" Or txtGroup.Text = "" Or txtTime.Text = "" Or txtVenue.Text = "" Then
            'WarningPanel.Visible = True
            'ButOK.Visible = True
            'ButNo.Visible = False
            'ButYes.Visible = False
            'WarningPanelLabel.Text = "Please fill out details"
            MsgBox("Please fill out details")
        Else
            ds.Tables("calendar").Rows(Index_Of_Row).Item("EventName") = txtEventName.Text
            'Dont need to edit date, cos date has been chosen
            'ds.Tables("calendar").Rows(Index_Of_Row).Item("Time") = txtTime.Text
            ds.Tables("calendar").Rows(Index_Of_Row).Item("Venue") = txtVenue.Text
            ds.Tables("calendar").Rows(Index_Of_Row).Item("Group") = txtGroup.Text

            If WeaponComboBox.SelectedItem = "Foil" Then
                ds.Tables("calendar").Rows(Index_Of_Row).Item("Weapon") = 1
            ElseIf WeaponComboBox.SelectedItem = "Sabre" Then
                ds.Tables("calendar").Rows(Index_Of_Row).Item("Weapon") = 2
            ElseIf WeaponComboBox.SelectedItem = "Epee" Then
                ds.Tables("calendar").Rows(Index_Of_Row).Item("Weapon") = 3
            ElseIf WeaponComboBox.SelectedItem = "No Weapon" Then
                ds.Tables("calendar").Rows(Index_Of_Row).Item("Weapon") = 0
            Else

            End If
            da.Update(ds, "Calendar")

        End If

        con.Close()

        'Row.Item(1) = txtEventName.Text
        ''Dont need to edit date, cos date has been chosen
        'Row.Item(4) = txtTime.Text
        'Row.Item(5) = txtVenue.Text
        'Row.Item(7) = txtGroup.Text

        'If WeaponComboBox.SelectedItem = "Foil" Then
        '    Row.Item(6) = 1
        'ElseIf WeaponComboBox.SelectedItem = "Sabre" Then
        '    Row.Item(6) = 2
        'ElseIf WeaponComboBox.SelectedItem = "Epee" Then
        '    Row.Item(6) = 3
        'ElseIf WeaponComboBox.SelectedItem = "No Weapon" Then
        '    Row.Item(6) = 0
        'Else

        'End If


        'If UpdateConfirmed = True Then

        'ElseIf UpdateConfirmed = False Then

        'End If


        'ElseIf txtEventName.Text = IsNumeric(True) Then
        '    WarningPanel.Visible = True
        '    ButOK.Visible = False
        '    ButYes.Visible = True
        '    ButNo.Visible = True
        '    WarningPanelLabel.Text = "Confirm Number for an event name?"


        '    If ButYesClicked = True Then

        '        ButYesClicked = False
        '        WarningPanel.Visible = False

        '        UpdateConfirmed = True

        '    ElseIf ButNoClicked = True Then

        '        ButNoClicked = False
        '        WarningPanel.Visible = False

        '        txtEventName.Text = ""

        '        UpdateConfirmed = False

        '    End If


    End Sub

    'Simply monitors clicks for the warning label
    Dim ButNoClicked As Boolean = False
    Dim ButYesClicked As Boolean = False
    Dim ButOkClicked As Boolean = False
    Private Sub ButNo_Click(sender As Object, e As EventArgs) Handles ButNo.Click

        If WarningPanelLabel.Text = "Confirm Number for an event name?" Then


        End If
        ButNoClicked = True
        WarningPanel.Visible = False
    End Sub

    Private Sub ButYes_Click(sender As Object, e As EventArgs) Handles ButYes.Click
        ButYesClicked = True
        WarningPanel.Visible = False
    End Sub

    Private Sub ButOK_Click(sender As Object, e As EventArgs) Handles ButOK.Click
        ButOkClicked = True
        WarningPanel.Visible = False
    End Sub



    'Simply sets text boxes to blank
    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click

        txtEventName.Text = ""
        txtGroup.Text = ""
        txtVenue.Text = ""
        txtTime.Text = ""

        WeaponComboBox.Text = "Choose a Weapon"
    End Sub

    'This should close/hide the panel
    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        EditDate.Visible = False
    End Sub











    'Hard code follows
    'Note that su1, su6, m1, m6... etc have different lines of code
    'This is because they sometimes have null values thus requiring to execute but with different parameters
    'i cbs fully explaining bc it will take me like 50000 words
    Dim I As String 'Catch

    Private Sub su1_Click(sender As Object, e As EventArgs) Handles Textsu1.Click, su1.Click, pansu1.Click
        If su1.Text = "" Then
            I = "01011"
        End If

        DatabaseDate = Date_Clicked("Textsu1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)

        'su1.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

    End Sub
    Private Sub su2_Click(sender As Object, e As EventArgs) Handles Textsu2.Click, su2.Click, pansu2.Click
        If su2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsu2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If

    End Sub
    Private Sub su3_Click(sender As Object, e As EventArgs) Handles Textsu3.Click, su3.Click, pansu3.Click
        If su3.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsu3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If

    End Sub
    Private Sub su4_Click(sender As Object, e As EventArgs) Handles Textsu4.Click, su4.Click, pansu4.Click
        If su4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsu4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub su5_Click(sender As Object, e As EventArgs) Handles Textsu5.Click, su5.Click, pansu5.Click
        If su5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textsu5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub su6_Click(sender As Object, e As EventArgs) Handles Textsu6.Click, su6.Click, pansu6.Click
        If su6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textsu6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub




    Private Sub m1_Click(sender As Object, e As EventArgs) Handles Textm1.Click, panm1.Click, m1.Click
        If m1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textm1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub m2_Click(sender As Object, e As EventArgs) Handles Textm2.Click, panm2.Click, m2.Click
        If m2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textm2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub m3_Click(sender As Object, e As EventArgs) Handles Textm3.Click, panm3.Click, m3.Click
        If m3.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textm3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub m4_Click(sender As Object, e As EventArgs) Handles Textm4.Click, panm4.Click, m4.Click
        If m4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textm4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub m5_Click(sender As Object, e As EventArgs) Handles Textm5.Click, panm5.Click, m5.Click
        If m5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textm5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub m6_Click(sender As Object, e As EventArgs) Handles Textm6.Click, panm6.Click, m6.Click
        If m6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textm6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub




    Private Sub tu1_Click(sender As Object, e As EventArgs) Handles tu1.Click, Texttu1.Click, pantu1.Click
        If tu1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Texttu1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub tu2_Click(sender As Object, e As EventArgs) Handles tu2.Click, Texttu2.Click, pantu2.Click
        If tu2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Texttu2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub tu3_Click(sender As Object, e As EventArgs) Handles tu3.Click, Texttu3.Click, pantu3.Click
        If tu3.Text = "" Then
            ID = "01011"
        Else
            DatabaseDate = Date_Clicked("Texttu3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub tu4_Click(sender As Object, e As EventArgs) Handles tu4.Click, Texttu4.Click, pantu4.Click
        If tu4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Texttu4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub tu5_Click(sender As Object, e As EventArgs) Handles tu5.Click, Texttu5.Click, pantu5.Click
        If tu5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Texttu5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub tu6_Click(sender As Object, e As EventArgs) Handles tu6.Click, Texttu6.Click, pantu6.Click
        If tu6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Texttu6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub





    Private Sub w1_Click(sender As Object, e As EventArgs) Handles w1.Click, Textw1.Click, panw1.Click
        If w1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textw1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub w2_Click(sender As Object, e As EventArgs) Handles w2.Click, Textw2.Click, panw2.Click
        If w2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textw2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub w3_Click(sender As Object, e As EventArgs) Handles w3.Click, Textw3.Click, panw3.Click
        If w3.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textw3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub w4_Click(sender As Object, e As EventArgs) Handles w4.Click, Textw4.Click, panw4.Click
        If w4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textw4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub w5_Click(sender As Object, e As EventArgs) Handles w5.Click, Textw5.Click, panw5.Click
        If w5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textw5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub w6_Click(sender As Object, e As EventArgs) Handles w6.Click, Textw6.Click, panw6.Click
        If w6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textw6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub






    Private Sub th1_Click(sender As Object, e As EventArgs) Handles th1.Click, Textth1.Click, panth1.Click
        If th1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textth1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub th2_Click(sender As Object, e As EventArgs) Handles th2.Click, Textth2.Click, panth2.Click
        If th2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textth2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub th3_Click(sender As Object, e As EventArgs) Handles th3.Click, Textth3.Click, panth3.Click
        If th3.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textth3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub th4_Click(sender As Object, e As EventArgs) Handles th4.Click, Textth4.Click, panth4.Click
        If th4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textth4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub th5_Click(sender As Object, e As EventArgs) Handles th5.Click, Textth5.Click, panth5.Click
        If th5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textth5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub th6_Click(sender As Object, e As EventArgs) Handles th6.Click, Textth6.Click, panth6.Click
        If th6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textth6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub






    Private Sub f1_Click(sender As Object, e As EventArgs) Handles Textf1.Click, panf1.Click, f1.Click
        If f1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textf1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub f2_Click(sender As Object, e As EventArgs) Handles Textf2.Click, panf2.Click, f2.Click
        If f2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textf2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub f3_Click(sender As Object, e As EventArgs) Handles Textf3.Click, panf3.Click, f3.Click
        If f3.Text = "" Then
            ID = "01011"
        Else
            DatabaseDate = Date_Clicked("Textf3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub f4_Click(sender As Object, e As EventArgs) Handles Textf4.Click, panf4.Click, f4.Click
        If f4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textf4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub f5_Click(sender As Object, e As EventArgs) Handles Textf5.Click, panf5.Click, f5.Click
        If f5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textf5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub f6_Click(sender As Object, e As EventArgs) Handles Textf6.Click, panf6.Click, f6.Click
        If f6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textf6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub




    Private Sub sa1_Click(sender As Object, e As EventArgs) Handles Textsa1.Click, sa1.Click, pansa1.Click
        If sa1.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textsa1")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub sa2_Click(sender As Object, e As EventArgs) Handles Textsa2.Click, sa2.Click, pansa2.Click
        If sa2.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsa2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub sa3_Click(sender As Object, e As EventArgs) Handles Textsa3.Click, sa3.Click, pansa3.Click
        If sa3.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsa3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub sa4_Click(sender As Object, e As EventArgs) Handles Textsa4.Click, sa4.Click, pansa4.Click
        If sa4.Text = "" Then
            I = "01011"
        Else
            DatabaseDate = Date_Clicked("Textsa4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub sa5_Click(sender As Object, e As EventArgs) Handles Textsa5.Click, sa5.Click, pansa5.Click
        If sa5.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textsa5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub sa6_Click(sender As Object, e As EventArgs) Handles Textsa6.Click, sa6.Click, pansa6.Click
        If sa6.Text = "" Then
            I = "01011"

        End If

        DatabaseDate = Date_Clicked("Textsa6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub









End Class
