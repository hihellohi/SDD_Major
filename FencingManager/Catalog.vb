Public Class Catalog

    Structure item
        Public student As Integer
        Public due As Date
        Public gearID As Integer
        Public gearType As String
    End Structure

    Dim things As New List(Of item)()
    Dim sort As Integer

    Public Sub reload()
        things.Clear()
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            Dim valid As Boolean = False
            If rdbType.Checked Then
                If row("GearType").ToString.ToLower.StartsWith(TextBox1.Text.ToLower) Then
                    valid = True
                End If
            Else
                If row("StudentLoaned").ToString.ToLower.StartsWith(TextBox1.Text.ToLower) Then
                    valid = True
                End If
            End If
            If valid Then
                Dim rowItem = New item
                rowItem.gearID = row("GearID")
                rowItem.gearType = row("GearType")
                'rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
                rowItem.student = row("StudentLoaned")
                If row("StudentLoaned") <> 0 Then
                    rowItem.due = New Date(row("DueYear"), row("DueMonth"), row("DueDay"))
                Else
                    rowItem.due = New Date(1, 1, 1)
                End If
                things.Add(rowItem)
            End If
        Next
        sort_things()
        loadTable()
    End Sub

    Private Sub sort_things()
     
    End Sub

    Private Sub loadTable()
        ListView1.Items.Clear()
        Dim row As item
        For Each row In things
            Dim rowItem = New ListViewItem(row.gearID)
            rowItem.SubItems.Add(row.gearType)
            'rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
            If row.student <> 0 Then
                rowItem.SubItems.Add(row.student)
                Dim due As Date = row.due
                rowItem.SubItems.Add(due)
                If due < Date.Today Then
                    rowItem.BackColor = Color.Red
                ElseIf due = Date.Today Then
                    rowItem.BackColor = Color.Yellow
                End If
            Else
                rowItem.SubItems.Add("Available")
                rowItem.SubItems.Add("N/A")
            End If
            ListView1.Items.Add(rowItem)
        Next
    End Sub

    Private Sub quickReload()
        Dim tmp As New List(Of item)()
        For i = 0 To things.Count - 1
            Dim comp As String
            If rdbType.Checked Then
                comp = things(i).gearType.ToLower
            Else
                comp = things(i).student.ToString.ToLower
            End If
            If comp.StartsWith(TextBox1.Text.ToLower) Then
                tmp.Add(things(i))
            End If
        Next
        things = tmp
        loadTable()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Static old As String = ""
        If TextBox1.Text.StartsWith(old) Then
            quickReload()
        Else
            reload()
        End If
        old = TextBox1.Text

    End Sub

End Class