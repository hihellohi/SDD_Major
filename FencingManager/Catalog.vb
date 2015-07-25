Public Class Catalog

    Structure item
        Public id As Integer
        Public student As Integer
        Public due As Date
        Public gearID As Integer
        Public gearType As String
    End Structure

    Dim things As New List(Of item)()
    Dim sort As Integer = -1

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
                rowItem.id = row("ID")
                rowItem.gearID = row("GearID")
                rowItem.gearType = row("GearType")
                'rowItem.SubItems.Add(row("DueDay").ToString() + "/" + row("DueMonth").ToString() + "/" + row("DueYear").ToString())
                rowItem.student = row("StudentLoaned")
                If row("StudentLoaned") <> 0 Then
                    rowItem.due = New Date(row("DueYear"), row("DueMonth"), row("DueDay"))
                Else
                    rowItem.due = New Date(9999, 12, 31)
                End If
                things.Add(rowItem)
            End If
        Next
        sort_things()
        loadTable()
    End Sub

    Private Sub sort_things()
        'Heapsort master race
        Dim heap(1 + (things.Count * 2)) As item
        Dim count As Integer = 1
        Dim tmp As item
        For i = 0 To (1 + (things.Count * 2))
            heap(i).gearID = -1
            heap(i).gearType = ""
        Next
        'construct heap
        For Each tmp In things
            heap(count) = tmp

            'bubble up
            Dim bubble As Integer = count
            While comp(heap(bubble), heap(Math.Floor(bubble / 2))) And bubble <> 1
                Dim temp As item = heap(Math.Floor(bubble / 2))
                heap(Math.Floor(bubble / 2)) = heap(bubble)
                heap(bubble) = temp
                bubble = Math.Floor(bubble / 2)
            End While
            count += 1
        Next
        things.Clear()

        'construct sorted list
        For i = 1 To count - 1
            things.Add(heap(1))

            'bubble up
            Dim bubble As Integer = 1
            While heap(bubble * 2).gearID <> -1 Or heap((bubble * 2) + 1).gearID <> -1
                If (comp(heap(bubble * 2), heap((bubble * 2) + 1)) Or heap((bubble * 2) + 1).gearID = -1) And heap(bubble * 2).gearID <> -1 Then
                    heap(bubble) = heap(bubble * 2)
                    bubble *= 2
                Else
                    heap(bubble) = heap((bubble * 2) + 1)
                    bubble = (bubble * 2) + 1
                End If
            End While
            heap(bubble).gearID = -1
        Next
    End Sub

    Private Function comp(ByVal a As item, ByVal b As item)
        Select Case sort
            Case -4
                Return a.due <= b.due
            Case -3
                Return a.student <= b.student
            Case -2
                Return a.gearType.ToLower().Trim(" ") <= b.gearType.ToLower().Trim(" ")
            Case -1
                Return a.gearID <= b.gearID
            Case 4
                Return a.due > b.due
            Case 3
                Return a.student > b.student
            Case 2
                Return a.gearType.ToLower().Trim(" ") > b.gearType.ToLower.Trim(" ")
            Case Else
                Return a.gearID > b.gearID
        End Select

    End Function

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

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If sort <> -(e.Column + 1) Then
            sort = -(e.Column + 1)
            sort_things()
            For i = 0 To 3
                ListView1.Columns(i).Text = ListView1.Columns(i).Text.Trim("^")
                ListView1.Columns(i).Text = ListView1.Columns(i).Text.Trim("v")
            Next
            ListView1.Columns(e.Column).Text += "v"
        Else
            sort = (e.Column + 1)
            things.Reverse()
            ListView1.Columns(e.Column).Text = ListView1.Columns(e.Column).Text.Trim("v")
            ListView1.Columns(e.Column).Text += "^"
        End If
        loadTable()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedIndices.Count = 1 Then
            MsgBox(things(ListView1.SelectedIndices(0)).id)
            'Do things
        End If
    End Sub

End Class