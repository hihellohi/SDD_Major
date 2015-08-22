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
            'getlabel(fdate, row).ForeColor = MonthName.ForeColor
11:
            If idate = Selected Then
12:
                getlabel(fdate, row).ForeColor = Color.Blue
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



    'Note: Calendar/Fencing is the name of the database
    'Note: tblCalendar/Calendar is the name of the actual record



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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCal(Now, Now.Day)

        ViewDetailsGroupBox.Text = "Viewing " & CStr(MonthName(Now.Month)) & " of " & CStr(Now.Year)

        CalendarGroupBox.Text = Format(Now, "MMMM") & " " & Now.Year

        'con.ConnectionString = dbProvider & dbSource


        'con.Open()

        sql = "Select * FROM Calendar"           'In here goes the NAME OF THE TABLE
        data_adapter = New OleDb.OleDbDataAdapter(sql, RootForm.connection)
        data_adapter.Fill(dataset, "Calendar")      'In here goes the NAME OF THE DATABASE

        'con.Close()

        Populate_Table(Now)


        'Admin section: restriction/access levels
        'In this calendar module, one may (essentially) view and update the database
        'One solution for difference in admin levels is to simply hide the update controls


        If Admin = True Then
            PanelControls.Visible = True
        Else : Admin = False
            PanelControls.Visible = False
        End If


    End Sub





    'For going to next month/previous month
    Dim currentmonth As Date = Now
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click

        currentmonth = DateAdd(DateInterval.Month, 1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)

        Clear_The_Slate()

        CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year

        tu4.Visible = False                 'just a little bug

        Populate_Table(currentmonth)

        tu4.Visible = True

    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click

        currentmonth = DateAdd(DateInterval.Month, -1, currentmonth)

        ReloadCal(currentmonth, currentmonth.Day)

        Clear_The_Slate()

        CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year

        tu4.Visible = False

        Populate_Table(currentmonth)

        tu4.Visible = True

    End Sub

    Public Sub Clear_The_Slate()

        LabClickToBegin.Visible = True

        WarningEventName.Visible = False
        WarningTime.Visible = False
        WarningVenue.Visible = False
        WarningWeapon.Visible = False
        WarningGroup.Visible = False

        ButUpdate.Visible = False

        ViewDetailsGroupBox.Text = "Viewing " & CStr(MonthName(currentmonth.Month)) & " of " & CStr(currentmonth.Year)

        PanInput.Visible = False

        ButCommit.Visible = False
        ButAddNew.Visible = False
        ButCancel.Visible = False
        ButUpdate.Visible = False
        ButClear.Visible = False
        ButDelete.Visible = False
        ButEdit.Visible = False

        LabNoEventScheduled.Visible = False
    End Sub

    'Public Function GetFirstDayOfCurrentMonth(ByVal CurrentMonth As Date) As String

    '    If su1.Text <> "" Then
    '        Return "su1"
    '        Exit Function
    '    ElseIf m1.Text <> "" Then
    '        Return "m1"
    '        Exit Function
    '    ElseIf tu1.Text <> "" Then
    '        Return "tu1"
    '        Exit Function
    '    ElseIf w1.Text <> "" Then
    '        Return "w1"
    '        Exit Function
    '    ElseIf th1.Text <> "" Then
    '        Return "th1"
    '        Exit Function
    '    ElseIf f1.Text <> "" Then
    '        Return "f1"
    '        Exit Function
    '    ElseIf sa1.Text <> "" Then
    '        Return "sa1"
    '        Exit Function

    '    ElseIf su2.Text <> "'" Then
    '        Return "su2"
    '        Exit Function
    '    ElseIf m2.Text <> "" Then
    '        Return "m2"
    '        Exit Function
    '    ElseIf tu2.Text <> "" Then
    '        Return "tu2"
    '        Exit Function
    '    ElseIf w2.Text <> "" Then
    '        Return "w2"
    '        Exit Function
    '    ElseIf th2.Text <> "" Then
    '        Return "th2"
    '        Exit Function
    '    ElseIf f2.Text <> "" Then
    '        Return "f2"
    '        Exit Function
    '    ElseIf sa2.Text <> "" Then
    '        Return "sa2"
    '        Exit Function
    '    End If



    'End Function 'Unnecessary
    'Public Function GetLastDayOfCurrentMonth(ByVal CurrentMonth As Date) As String

    '    If sa6.Text <> "" Then
    '        Return "sa6"
    '        Exit Function
    '    ElseIf f6.Text <> "" Then
    '        Return "f6"
    '        Exit Function
    '    ElseIf th6.Text <> "" Then
    '        Return "th6"
    '        Exit Function
    '    ElseIf w6.Text <> "" Then
    '        Return "w6"
    '        Exit Function
    '    ElseIf tu6.Text <> "" Then
    '        Return "tu6"
    '        Exit Function
    '    ElseIf m6.Text <> "" Then
    '        Return "m6"
    '        Exit Function
    '    ElseIf su6.Text <> "" Then
    '        Return "su6"
    '        Exit Function

    '    ElseIf sa5.Text <> "" Then
    '        Return "sa5"
    '        Exit Function
    '    ElseIf f5.Text <> "" Then
    '        Return "f5"
    '        Exit Function
    '    ElseIf th5.Text <> "" Then
    '        Return "th5"
    '        Exit Function
    '    ElseIf w5.Text <> "" Then
    '        Return "w5"
    '        Exit Function
    '    ElseIf tu5.Text <> "" Then
    '        Return "tu5"
    '        Exit Function
    '    ElseIf m5.Text <> "" Then
    '        Return "m5"
    '        Exit Function
    '    ElseIf su5.Text <> "" Then
    '        Return "su5"
    '        Exit Function
    '    End If


    'End Function 'Unnecessary


    'Populate table populates the table no shit
    'accesses the database and gets dates
    Dim DateArray() As String = {"su1", "su2", "su3", "su4", "su5", "su6", "m1", "m2", "m3", "m4", "m5", "m6", "tu1", "tu2", "tu3", "tu4", "tu5", "tu6", "w1", "w2", "w3", "w4", "w5", "w6", "th1", "th2", "th3", "th4", "th5", "th6", "f1", "f2", "f3", "f4", "f5", "f6", "sa1", "sa2", "sa3", "sa4", "sa5", "sa6"}



    Public Sub Populate_Table(ByVal currentmonth As Date)


        Dim TemporaryDataRow As DataRow


        For LabelDate = 0 To 41


            Dim NameOfLabel = DateArray(LabelDate)                                                      'This part gets the name as a control of the label


            'Dim JoinedStringNameOfLabel = NameOfLabel
            'Dim ControlNameForLabel As Control = Nothing
            'Dim SearchedLabelControls = Me.Controls.Find(key:=JoinedStringNameOfLabel, searchAllChildren:=True)
            'If SearchedLabelControls.Count = 1 Then
            '    ControlNameForLabel = SearchedLabelControls(0)
            'End If


            Dim ControlNameForTextBox As Control = Nothing

            Dim JoinedStringNameOfTextBox = "Text" & NameOfLabel
            Dim SearchedTextBoxControls = Me.Controls.Find(key:=JoinedStringNameOfTextBox, searchAllChildren:=True)
            If SearchedTextBoxControls.Count = 1 Then
                ControlNameForTextBox = SearchedTextBoxControls(0)
            End If

            Try
                Dim TemporaryDatabaseDate As Date = Date_Clicked(NameOfLabel)                                        'Gets Date of the label to be used to index in database

                Dim Key(0) As DataColumn                                                                    'This part caters to the indexing ^
                Key(0) = dataset.Tables("Calendar").Columns("EventDate")
                dataset.Tables("Calendar").PrimaryKey = Key
                TemporaryDataRow = dataset.Tables("Calendar").Rows.Find(TemporaryDatabaseDate)

                ControlNameForTextBox.Text = TemporaryDataRow(1) & " at " & TemporaryDataRow(4)

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


    'This sub fills in the details of the textboxes on the panel
    Dim Row As DataRow
    Public Function Inhabit_Database(ByVal DatabaseDate As Date)

        Dim Key(0) As DataColumn
        Key(0) = dataset.Tables("Calendar").Columns("EventDate")
        dataset.Tables("Calendar").PrimaryKey = Key
        Row = dataset.Tables("Calendar").Rows.Find(DatabaseDate)

        TexEventName.Text = Row.Item(1)
        TexTime.Text = Row.Item(4)
        TexVenue.Text = Row.Item(5)

        If Row.Item(6) = 0 Then
            ComboWeapon.Text = "No Weapon"
        ElseIf Row.Item(6) = 1 Then
            ComboWeapon.Text = "Foil"
        ElseIf Row.Item(6) = 2 Then
            ComboWeapon.Text = "Sabre"
        ElseIf Row.Item(6) = 3 Then
            ComboWeapon.Text = "Epee"
        End If

        TexGroup.Text = Row.Item(7)

    End Function

    'Below four subs are hardcode that perform some basic hiding/clearing/showing actions

    'Hides buttons
    Public Function Hide_Buttons(ByVal addnew As Boolean, commit As Boolean, cancel As Boolean, update As Boolean, clear As Boolean, delete As Boolean, edit As Boolean)
        ButAddNew.Visible = addnew
        ButCommit.Visible = commit
        ButCancel.Visible = cancel
        ButUpdate.Visible = update
        ButClear.Visible = clear
        ButDelete.Visible = delete
        ButEdit.Visible = edit
    End Function
    'Disables textboxes
    Public Function Disabling_Textboxes(ByVal YayOrNay As Boolean)
        TexEventName.ReadOnly = YayOrNay
        TexTime.ReadOnly = YayOrNay
        TexVenue.ReadOnly = YayOrNay
        TexGroup.ReadOnly = YayOrNay
    End Function
    'Clear textboxes
    Public Function Clear_Text()
        TexEventName.Text = ""
        TexTime.Text = ""
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


    'This sub gets details from the database
    Public Sub Get_Database_Details_For_Specified_Date(ByVal DatabaseDate As Date)

        LabClickToBegin.Visible = False

        If BlankDate = True Then        'Completely Blank Box

            ViewDetailsGroupBox.Text = "No Date"

            PanInput.Visible = False

            Hide_Buttons(False, False, False, False, False, False, False)

            LabNoEventScheduled.Visible = False

            BlankDate = False

        Else : BlankDate = False        'Box with a date, but not necessarily an entry in the database

            Try                         'Box with a date, and has an entry in the database
                Inhabit_Database(DatabaseDate)

                ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

                PanInput.Visible = True

                Hide_Buttons(False, False, False, False, False, True, True)

                LabNoEventScheduled.Visible = False

            Catch ex As Exception       'Box with a date, but has no entry in the database

                ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

                PanInput.Visible = False

                Hide_Buttons(True, False, False, False, False, False, False)

                LabNoEventScheduled.Visible = True

            End Try

        End If

    End Sub


    'Most of the buttons and important update function
    Dim updating As Boolean = False
    Dim adding As Boolean = False
    'EXTREMELY IMPORTANT SUB FOR UPDATING TO DATABASE
    Private Function Update_to_Database(ByVal Message As String)
        Dim cb As New OleDb.OleDbCommandBuilder(data_adapter)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        'Try
        data_adapter.Update(dataset, "Calendar")
        MsgBox(Message)
        'Catch ex As Exception
        '    MsgBox(Message)
        'End Try

    End Function


    'Most of the buttons
    Private Sub ButEdit_Click(sender As Object, e As EventArgs) Handles ButEdit.Click
        updating = True
        ViewDetailsGroupBox.Text = "Editing event on " & CStr(DatabaseDate)

        PanInput.Visible = True

        Hide_Buttons(False, False, True, True, True, False, False)

        LabNoEventScheduled.Visible = False

        TexEventName.ReadOnly = False
        TexTime.ReadOnly = False
        TexVenue.ReadOnly = False
        ComboWeapon.Enabled = True
        TexGroup.ReadOnly = False

        'TexEventName.Text = ""
        'TexTime.Text = ""
        'TexVenue.Text = ""
        'ComboWeapon.Text = ""
        'ComboWeapon.SelectedItem = Nothing
        'TexGroup.Text = ""

    End Sub

    Private Sub ButUpdate_Click(sender As Object, e As EventArgs) Handles ButUpdate.Click
        updating = False
        If TexTime.Text = "" Or TexEventName.Text = "" Or TexVenue.Text = "" Or ComboWeapon.SelectedItem = Nothing Or TexGroup.Text = "" Then

            If TexEventName.Text = "" Then
                WarningEventName.Visible = True
            Else
                WarningEventName.Visible = False
            End If
            If TexTime.Text = "" Then
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
            Row.Item(4) = TexTime.Text
            Row.Item(5) = TexVenue.Text

            If ComboWeapon.SelectedItem = "No Weapon" Then
                Row.Item(6) = 0
            ElseIf ComboWeapon.SelectedItem = "Foil" Then
                Row.Item(6) = 1
            ElseIf ComboWeapon.SelectedItem = "Sabre" Then
                Row.Item(6) = 2
            ElseIf ComboWeapon.SelectedItem = "Epee" Then
                Row.Item(6) = 3
            Else
                Row.Item(6) = 0
            End If

            Row.Item(7) = TexGroup.Text



            My.Computer.Audio.Play("ding.wav")
            Update_to_Database("Data Updated")



            'Inhabit_Database(DatabaseDate)

            ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

            PanInput.Visible = True

            Hide_Buttons(False, False, False, False, False, True, True)

            LabNoEventScheduled.Visible = False

            ComboWeapon.Enabled = False
            Disabling_Textboxes(True)



        End If

        Populate_Table(currentmonth)

    End Sub

    Private Sub ButAddNew_Click(sender As Object, e As EventArgs) Handles ButAddNew.Click
        adding = True
        ViewDetailsGroupBox.Text = "Adding new event for " & CStr(DatabaseDate)

        PanInput.Visible = True

        Hide_Buttons(False, True, True, False, True, False, False)

        LabNoEventScheduled.Visible = False

        ComboWeapon.Enabled = True
        Disabling_Textboxes(False)

        Clear_Text()

    End Sub

    Private Sub ButCommit_Click(sender As Object, e As EventArgs) Handles ButCommit.Click
        adding = False
        If TexTime.Text = "" Or TexEventName.Text = "" Or TexVenue.Text = "" Or ComboWeapon.SelectedItem = Nothing Or TexGroup.Text = "" Then

            If TexEventName.Text = "" Then
                WarningEventName.Visible = True
            Else
                WarningEventName.Visible = False
            End If
            If TexTime.Text = "" Then
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
            datasetNewRow.Item(4) = TexTime.Text
            datasetNewRow.Item(5) = TexVenue.Text

            If ComboWeapon.SelectedItem = "No Weapon" Then
                datasetNewRow.Item(6) = 0
            ElseIf ComboWeapon.SelectedItem = "Foil" Then
                datasetNewRow.Item(6) = 1
            ElseIf ComboWeapon.SelectedItem = "Sabre" Then
                datasetNewRow.Item(6) = 2
            ElseIf ComboWeapon.SelectedItem = "Epee" Then
                datasetNewRow.Item(6) = 3
            Else
                'datasetNewRow.Item(6) = 0
            End If

            datasetNewRow.Item(7) = TexGroup.Text

            dataset.Tables("Calendar").Rows.Add(datasetNewRow)


            'My.Computer.Audio.Play("ding.wav")
            Update_to_Database("New event added for the date: " & CStr(DatabaseDate))


            'Inhabit_Database(DatabaseDate)


            ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

            PanInput.Visible = True

            Hide_Buttons(False, False, False, False, False, True, True)

            LabNoEventScheduled.Visible = False

            Disabling_Textboxes(True)
            ComboWeapon.Enabled = False

        End If

        Populate_Table(currentmonth)
    End Sub

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        Clear_Text()
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click

        Hide_Warnings()

        If updating = True Then

            ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

            PanInput.Visible = True

            Hide_Buttons(False, False, False, False, False, True, True)

            LabNoEventScheduled.Visible = False

            ComboWeapon.Enabled = False
            Disabling_Textboxes(True)

            updating = False
        ElseIf adding = True Then

            ViewDetailsGroupBox.Text = "Viewing details for " & CStr(DatabaseDate)

            PanInput.Visible = False

            Hide_Buttons(False, True, False, False, False, False, False)

            LabNoEventScheduled.Visible = True

            ComboWeapon.Enabled = False
            Disabling_Textboxes(True)

            adding = False
        End If
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click

        'Get_Database_Details_For_Specified_Date(DatabaseDate)

        If MessageBox.Show("Do you really want to delete this event?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            MsgBox("Delete cancelled")
            Exit Sub
        End If

        'con.Open()

        sql = "Select * FROM Calendar"
        data_adapter = New OleDb.OleDbDataAdapter(sql, RootForm.connection)
        data_adapter.Fill(dataset, "Calendar")

        'con.Close()

        Inhabit_Database(DatabaseDate)

        Row.Delete()

        Update_to_Database("Event deleted for the date: " & CStr(DatabaseDate))

        PanInput.Visible = False

        Hide_Buttons(True, False, False, False, False, False, False)

        LabNoEventScheduled.Visible = True

        Populate_Table(currentmonth)

    End Sub




    'Displays/hides help
    Private Sub ButHelp_Click(sender As Object, e As EventArgs) Handles ButHelp.Click
        If PanelHelp.Visible = True Then
            PanelHelp.Visible = False
        ElseIf PanelHelp.Visible = False Then
            PanelHelp.Visible = True
        End If


    End Sub



    'Following code caters to graphics for viewdetails panel
    'allows moving of position and hide/show functions
    Dim MouseX = Cursor.Position.X
    Dim MouseY = Cursor.Position.Y
    Dim ViewDetailsHeld As Boolean = False
    Dim SearchHeld As Boolean = False
    Private Sub PicViewDetailsSlider_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicViewDetailsSlider.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ViewDetailsHeld = True
        End If
    End Sub
    Private Sub PicViewDetailsSlider_MouseUp(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicViewDetailsSlider.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ViewDetailsHeld = False
        End If
    End Sub

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



    Private Sub ButSearchHide_Click(sender As Object, e As EventArgs) Handles ButSearchHide.Click
        Dim MousePosX As Integer = 0
        While MousePosX < 500
            SearchGroupBox.Left = SearchGroupBox.Left + 1
            MousePosX = MousePosX + 1
        End While

        If SearchGroupBox.Top < 20 Then
            PicSearchShow.Top = 12
        Else
            PicSearchShow.Top = SearchGroupBox.Top + 50
        End If

        PicSearchShow.Visible = True
    End Sub
    Private Sub ButViewDetailsHide_Click(sender As Object, e As EventArgs) Handles ButViewDetailsHide.Click
        Dim MousePosX As Integer = 0
        While MousePosX < 500
            ViewDetailsGroupBox.Left = ViewDetailsGroupBox.Left + 1
            MousePosX = MousePosX + 1
        End While

        If ViewDetailsGroupBox.Top < -140 Then
            PicViewDetailsShow.Top = 12
        Else
            PicViewDetailsShow.Top = ViewDetailsGroupBox.Top + 140
        End If

        PicViewDetailsShow.Visible = True
    End Sub


    Private Sub PicSearchShow_Click(sender As Object, e As EventArgs) Handles PicSearchShow.Click
        Dim mouseposx As Integer = 0
        While mouseposx < 500
            SearchGroupBox.Left = SearchGroupBox.Left - 1
            mouseposx = mouseposx + 1
        End While
        PicSearchShow.Visible = False
    End Sub
    Private Sub PicViewDetailsShow_Click(sender As Object, e As EventArgs) Handles PicViewDetailsShow.Click
        Dim mouseposx As Integer = 0
        While mouseposx < 500
            ViewDetailsGroupBox.Left = ViewDetailsGroupBox.Left - 1
            mouseposx = mouseposx + 1
        End While
        PicViewDetailsShow.Visible = False
    End Sub



    Dim ScreenPos As Point
    Private Sub SlideTimer_Tick(sender As Object, e As EventArgs) Handles SlideTimer.Tick
        MouseX = Cursor.Position.X
        MouseY = Cursor.Position.Y

        ScreenPos = Me.PointToScreen(New Point(0, 0))           ''Gets x/y location of the panel instead of just mouse


        Label8.Text = ScreenPos.X
        Label9.Text = ScreenPos.Y

        If ViewDetailsHeld = True Then
            ViewDetailsGroupBox.Left = MouseX - ScreenPos.X - 185
            ViewDetailsGroupBox.Top = MouseY - ScreenPos.Y - 305
        End If

        If SearchHeld = True Then
            SearchGroupBox.Left = MouseX - ScreenPos.X - 185
            SearchGroupBox.Top = MouseY - ScreenPos.Y - 125
        End If
    End Sub




    'following code caters to the searching function
    Dim EventNameChecked As Boolean = True
    Dim DateChecked As Boolean = False
    Private Sub RadEventName_CheckedChanged(sender As Object, e As EventArgs) Handles RadEventName.CheckedChanged
        TexSearch.Text = ""

        DateTimePickerSearch.Visible = False
        TexSearch.Visible = True

        EventNameChecked = True
        DateChecked = False
    End Sub

    Private Sub RadDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadDate.CheckedChanged
        DateTimePickerSearch.Visible = True
        TexSearch.Visible = False

        EventNameChecked = False
        DateChecked = True

    End Sub

    'Private Function Generate_Textbox_Name(ByVal DatabaseDate As Date) As Control
    '    Dim Label_Date As Integer = DatabaseDate.Day



    '    For LabelDate = 0 To 41
    '        Dim NameOfLabel = DateArray(LabelDate)                                                      'This part gets the name as a control of the label

    '        Dim ControlNameForTextBox As Control = Nothing

    '        Dim JoinedStringNameOfTextBox = NameOfLabel
    '        Dim SearchedTextBoxControls = Me.Controls.Find(key:=JoinedStringNameOfTextBox, searchAllChildren:=True)
    '        If SearchedTextBoxControls.Count = 1 Then
    '            ControlNameForTextBox = SearchedTextBoxControls(0)
    '        End If


    '        If ControlNameForTextBox.Text = CStr(Label_Date) Then
    '            Return ControlNameForTextBox
    '        End If
    '    Next

    'End Function

    Private Sub ButSearch_Click(sender As Object, e As EventArgs) Handles ButSearch.Click
        Dim DatabaseSearchDate As Date = DateTimePickerSearch.Value.Date
        Dim SearchString As String = TexSearch.Text
        Dim Textbox_Name As Control

        If EventNameChecked = True Then
            If TexSearch.Text = "" Then
                MsgBox("Please enter an event name")
            Else
                Dim TempDate As Date
                Try
                    Dim TempKey(0) As DataColumn
                    TempKey(0) = dataset.Tables("Calendar").Columns("EventName")
                    dataset.Tables("Calendar").PrimaryKey = TempKey
                    Row = dataset.Tables("Calendar").Rows.Find(SearchString)

                    TempDate = Row.Item(2)

                    Get_Database_Details_For_Specified_Date(TempDate)

                    currentmonth = TempDate
                    ReloadCal(currentmonth, currentmonth.Day)
                    CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year
                    tu4.Visible = False
                    Populate_Table(currentmonth)
                    tu4.Visible = True

                    'Textbox_Name = Generate_Textbox_Name(TempDate)
                    'Textbox_Name.ForeColor = Color.Red

                Catch ex As Exception
                    ViewDetailsGroupBox.Text = "No event called '" & SearchString & "'"

                    PanInput.Visible = False

                    Hide_Buttons(False, False, False, False, False, False, False)

                    LabNoEventScheduled.Visible = True
                End Try
            End If

        ElseIf DateChecked = True Then
            currentmonth = DatabaseSearchDate
            ReloadCal(currentmonth, currentmonth.Day)
            CalendarGroupBox.Text = Format(currentmonth, "MMMM") & " " & currentmonth.Year
            tu4.Visible = False
            Populate_Table(currentmonth)
            tu4.Visible = True

            Get_Database_Details_For_Specified_Date(DatabaseSearchDate)

            'Textbox_Name = Generate_Textbox_Name(DatabaseDate)
            'Textbox_Name.ForeColor = Color.Red
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

    End Sub
    Private Sub su2_Click(sender As Object, e As EventArgs) Handles Textsu2.Click, su2.Click, pansu2.Click
        If su2.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su2")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If

    End Sub
    Private Sub su3_Click(sender As Object, e As EventArgs) Handles Textsu3.Click, su3.Click, pansu3.Click
        If su3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If

    End Sub
    Private Sub su4_Click(sender As Object, e As EventArgs) Handles Textsu4.Click, su4.Click, pansu4.Click
        If su4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("su4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub su5_Click(sender As Object, e As EventArgs) Handles Textsu5.Click, su5.Click, pansu5.Click
        If su5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("su5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub su6_Click(sender As Object, e As EventArgs) Handles Textsu6.Click, su6.Click, pansu6.Click
        If su6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("su6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub m1_Click(sender As Object, e As EventArgs) Handles Textm1.Click, panm1.Click, m1.Click
        If m1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub m3_Click(sender As Object, e As EventArgs) Handles Textm3.Click, panm3.Click, m3.Click
        If m3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("m3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub m4_Click(sender As Object, e As EventArgs) Handles Textm4.Click, panm4.Click, m4.Click
        If m4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("m4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub m5_Click(sender As Object, e As EventArgs) Handles Textm5.Click, panm5.Click, m5.Click
        If m5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("m5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub m6_Click(sender As Object, e As EventArgs) Handles Textm6.Click, panm6.Click, m6.Click
        If m6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("m6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub tu1_Click(sender As Object, e As EventArgs) Handles tu1.Click, Texttu1.Click, pantu1.Click
        If tu1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub tu3_Click(sender As Object, e As EventArgs) Handles tu3.Click, Texttu3.Click, pantu3.Click
        If tu3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("tu3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub tu4_Click(sender As Object, e As EventArgs) Handles Texttu4.Click, pantu4.Click
        If tu4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("tu4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub tu5_Click(sender As Object, e As EventArgs) Handles tu5.Click, Texttu5.Click, pantu5.Click
        If tu5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("tu5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub tu6_Click(sender As Object, e As EventArgs) Handles tu6.Click, Texttu6.Click, pantu6.Click
        If tu6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("tu6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub w1_Click(sender As Object, e As EventArgs) Handles w1.Click, Textw1.Click, panw1.Click
        If w1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub w3_Click(sender As Object, e As EventArgs) Handles w3.Click, Textw3.Click, panw3.Click
        If w3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("w3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub w4_Click(sender As Object, e As EventArgs) Handles w4.Click, Textw4.Click, panw4.Click
        If w4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("w4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub w5_Click(sender As Object, e As EventArgs) Handles w5.Click, Textw5.Click, panw5.Click
        If w5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("w5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub w6_Click(sender As Object, e As EventArgs) Handles w6.Click, Textw6.Click, panw6.Click
        If w6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("w6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub th1_Click(sender As Object, e As EventArgs) Handles th1.Click, Textth1.Click, panth1.Click
        If th1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub th3_Click(sender As Object, e As EventArgs) Handles th3.Click, Textth3.Click, panth3.Click
        If th3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("th3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub th4_Click(sender As Object, e As EventArgs) Handles th4.Click, Textth4.Click, panth4.Click
        If th4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("th4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub th5_Click(sender As Object, e As EventArgs) Handles th5.Click, Textth5.Click, panth5.Click
        If th5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("th5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub th6_Click(sender As Object, e As EventArgs) Handles th6.Click, Textth6.Click, panth6.Click
        If th6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("th6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub f1_Click(sender As Object, e As EventArgs) Handles Textf1.Click, panf1.Click, f1.Click
        If f1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub f3_Click(sender As Object, e As EventArgs) Handles Textf3.Click, panf3.Click, f3.Click
        If f3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("f3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub f4_Click(sender As Object, e As EventArgs) Handles Textf4.Click, panf4.Click, f4.Click
        If f4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("f4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
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

        DatabaseDate = Date_Clicked("f6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub


    Private Sub sa1_Click(sender As Object, e As EventArgs) Handles Textsa1.Click, sa1.Click, pansa1.Click
        If sa1.Text = "" Then
            BlankDate = True

        End If

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
    End Sub
    Private Sub sa3_Click(sender As Object, e As EventArgs) Handles Textsa3.Click, sa3.Click, pansa3.Click
        If sa3.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("sa3")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub sa4_Click(sender As Object, e As EventArgs) Handles Textsa4.Click, sa4.Click, pansa4.Click
        If sa4.Text = "" Then
            BlankDate = True
        Else
            DatabaseDate = Date_Clicked("sa4")  'gets date
            Get_Database_Details_For_Specified_Date(DatabaseDate)
        End If
    End Sub
    Private Sub sa5_Click(sender As Object, e As EventArgs) Handles Textsa5.Click, sa5.Click, pansa5.Click
        If sa5.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("sa5")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub
    Private Sub sa6_Click(sender As Object, e As EventArgs) Handles Textsa6.Click, sa6.Click, pansa6.Click
        If sa6.Text = "" Then
            BlankDate = True

        End If

        DatabaseDate = Date_Clicked("sa6")  'gets date
        Get_Database_Details_For_Specified_Date(DatabaseDate)
    End Sub

End Class
