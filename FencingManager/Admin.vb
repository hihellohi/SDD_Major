Imports System.Data.OleDb
Public Class Admin
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim eventDataTable As New FencingDataSet.CalendarDataTable
    Dim DS As New DataSet



    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PWChange.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        lvEvents.Items.Clear()
        ' Connection
        Dim conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=Fencing.accdb")
        'Query, Parameters
        Dim sql As String = "SELECT * FROM Calendar"
        Dim cmd As New OleDbCommand(sql, RootForm.connection)
        adapter = New OleDbDataAdapter(cmd)
        adapter.Fill(DS)

        conn.Open()
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
    End Sub
End Class