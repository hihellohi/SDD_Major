Imports System.Data.OleDb
Imports System.IO

Public Class Admin
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim eventDataTable As New FencingDataSet.CalendarDataTable
    Dim DS As New DataSet
    Dim DS1 As New DataSet
    'DS = events dataset, DS1 = absences dataset



    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If RootForm.access_level = 3 Then
            lbAcc.Text = "MIC ACCOUNT"
        Else : lbAcc.Text = GlobalVariables.Username
        End If

        If RootForm.access_level = 2 Or 3 Then
            ' Connection
            Dim conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=Fencing.accdb")
            'Query, Parameters
            Dim sql As String = "SELECT * FROM Calendar"
            Dim cmd As New OleDbCommand(sql, RootForm.connection)
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(DS)
            lvEvents.Clear()
            conn.Open()

            For i = 1 To (DS.Tables(0).Rows.Count - 1)
                Dim str1 As String = DS.Tables(0).Rows(i)("EventDate").ToString
                Dim str2 As String = DS.Tables(0).Rows(i)("Time").ToString
                Dim str3 As String = DS.Tables(0).Rows(i)("Venue").ToString
                Dim str4 As String = DS.Tables(0).Rows(i)("Group").ToString

                Dim lvi As New ListViewItem 'create new listview item
                lvi.Text = str1 'Put text in column 1
                lvi.SubItems.AddRange(New String() {str2, str3, str4}) 'Put text in columns 2,3,4
                lvEvents.Items.Add(lvi) 'Add the new row to listview
            Next

            conn.Close()

            With lvEvents
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True

                lvEvents.Columns.Add("EventDate", 270, HorizontalAlignment.Center)
                lvEvents.Columns.Add("Time", 100, HorizontalAlignment.Center)
                lvEvents.Columns.Add("Venue", 100, HorizontalAlignment.Center)
                lvEvents.Columns.Add("Group", 100, HorizontalAlignment.Center)

            End With

            Dim sql1 As String = "SELECT * FROM Absences"
            Dim cmd1 As New OleDbCommand(sql1, RootForm.connection)
            adapter = New OleDbDataAdapter(cmd1)
            adapter.Fill(DS1)
            lvAbsences.Items.Clear()
            DS1.Clear()
            For i = 1 To (DS1.Tables(0).Rows.Count - 1)
                Dim str10 As String = DS.Tables(0).Rows(i)("AbsenceDate").ToString
                Dim str11 As String = DS.Tables(0).Rows(i)("StudentID").ToString

                Dim lvii As New ListViewItem
                lvii.Text = str10
                lvii.SubItems.AddRange(New String() {str11})
                lvAbsences.Items.Add(lvii)
            Next

            With lvAbsences
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True

                lvAbsences.Columns.Add("AbsenceDate", 270, HorizontalAlignment.Center)
                lvAbsences.Columns.Add("StudentID", 200, HorizontalAlignment.Center)
            End With

            Try
                RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                Dim newfile As FileStream = File.Create("edits.txt")
                MsgBox("Log file not found. Creating a new file.")
                newfile.Close()
            End Try

        Else : MsgBox("An access level of MIC or Captain/Coach is required to view this")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        lvEvents.Items.Clear()
        DS.Clear()

        Dim sql As String = "SELECT * FROM Calendar"
        Dim cmd As New OleDbCommand(sql, RootForm.connection)
        adapter = New OleDbDataAdapter(cmd)
        adapter.Fill(DS)

        ' events
        lvEvents.Items.Clear()
        For i = 1 To (DS.Tables(0).Rows.Count - 1)
            Dim str1 As String = DS.Tables(0).Rows(i)("EventDate").ToString
            Dim str2 As String = DS.Tables(0).Rows(i)("Time").ToString
            Dim str3 As String = DS.Tables(0).Rows(i)("Venue").ToString
            Dim str4 As String = DS.Tables(0).Rows(i)("Group").ToString

            Dim lvi As New ListViewItem 'create new listview item
            lvi.Text = str1 'Put text in column 1
            lvi.SubItems.AddRange(New String() {str2, str3, str4}) 'Put text in columns 2,3,4
            lvEvents.Items.Add(lvi) 'Add the new row to listview
        Next

        ' absences
        lvAbsences.Items.Clear()
        DS1.Clear()
        Dim sql1 As String = "SELECT * FROM Absences"
        Dim cmd1 As New OleDbCommand(sql1, RootForm.connection)
        adapter = New OleDbDataAdapter(cmd1)
        adapter.Fill(DS1)
        For i = 1 To (DS1.Tables(0).Rows.Count - 1)
            Dim str10 As String = DS1.Tables(0).Rows(i)("AbsenceDate").ToString
            Dim str11 As String = DS1.Tables(0).Rows(i)("StudentID").ToString

            Dim lvii As New ListViewItem
            lvii.Text = str10
            lvii.SubItems.AddRange(New String() {str11})
            lvAbsences.Items.Add(lvii)
            'MsgBox(i)
        Next

        ' log
        RichTextBox1.LoadFile("edits.txt", RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            RichTextBox1.SaveFile("edits.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btCLog_Click(sender As Object, e As EventArgs) Handles btCLog.Click
        RichTextBox1.Text = ("")
        RichTextBox1.SaveFile("edits.txt", RichTextBoxStreamType.PlainText)
    End Sub
End Class