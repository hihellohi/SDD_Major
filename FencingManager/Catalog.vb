Imports System.Runtime.InteropServices

Public Class Catalog

    Structure item
        Public id As Integer
        Public student As Integer
        Public due As Date
        Public gearID As String
        Public gearType As String
    End Structure

    Dim things As New List(Of item)()
    Dim sort As Integer = -1
    Public selected As Integer = -1
    Dim check As Boolean = False

    Public Sub reload()
        things.Clear()
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            Dim valid As Boolean = False
            If rdbType.Checked Then
                If row("GearType").ToString.ToLower.StartsWith(txtSearchCriteria.Text.ToLower) Then
                    valid = True
                End If
            ElseIf rdbStudent.Checked Then
                If row("StudentLoaned").ToString.ToLower.StartsWith(txtSearchCriteria.Text.ToLower) Then
                    valid = True
                End If
            Else
                If row("GearID").ToString.ToLower.StartsWith(txtSearchCriteria.Text.ToLower) Then
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
        Button4_Click()
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
        Dim count As Integer = 0
        tablelist.Items.Clear()
        Dim row As item
        For Each row In things
            count += 1
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
            tablelist.Items.Add(rowItem)
        Next
        lblTableCount.Text = count
    End Sub

    Private Sub quickReload()
        Dim tmp As New List(Of item)()
        For i = 0 To things.Count - 1
            Dim comp As String
            If rdbType.Checked Then
                comp = things(i).gearType.ToLower
            ElseIf rdbStudent.Checked Then
                comp = things(i).student.ToString.ToLower
            Else
                comp = things(i).gearID.ToLower
            End If
            If comp.StartsWith(txtSearchCriteria.Text.ToLower) Then
                tmp.Add(things(i))
            End If
        Next
        things = tmp
        loadTable()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCriteria.TextChanged
        Static old As String = ""
        If txtSearchCriteria.Text.StartsWith(old) Then
            quickReload()
        Else
            reload()
        End If
        old = txtSearchCriteria.Text
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles tablelist.ColumnClick
        If sort <> -(e.Column + 1) Then
            sort = -(e.Column + 1)
            sort_things()
            For i = 0 To 3
                tablelist.Columns(i).Text = tablelist.Columns(i).Text.Trim(ChrW(&H25B2))
                tablelist.Columns(i).Text = tablelist.Columns(i).Text.Trim(ChrW(&H25BC))
            Next
            tablelist.Columns(e.Column).Text += ChrW(&H25BC)
        Else
            sort = (e.Column + 1)
            things.Reverse()
            tablelist.Columns(e.Column).Text = tablelist.Columns(e.Column).Text.Trim(ChrW(&H25BC))
            tablelist.Columns(e.Column).Text += ChrW(&H25B2)
        End If
        loadTable()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles tablelist.ItemSelectionChanged
        If tablelist.SelectedIndices.Count = 1 Then
            'MsgBox(things(ListView1.SelectedIndices(0)).id)
            selected = things(tablelist.SelectedIndices(0)).id - 1
            'Dim row As DataRow
            'For Each row In RootForm.GearDataS.Tables("Gear").Rows
            '    If things(ListView1.SelectedIndices(0)).id = row("ID") Then
            txtSelAN.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("Notes").ToString
            txtSelDesc.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearType")
            '        txtSelIItemID.Text = row("GearID")
            lblHide.Visible = False
            If RootForm.GearDataS.Tables("Gear").Rows(selected).Item("StudentLoaned").ToString <> 0 Then
                txtSL.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("StudentLoaned").ToString
                txtYear.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueYear").ToString
                cmbMonth.SelectedIndex = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueMonth") - 1
                cmbDay.SelectedIndex = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueDay") - 1
                txtYear.Enabled = True
                cmbMonth.Enabled = True
                cmbDay.Enabled = True
            Else
                txtSL.Text = ""
                txtYear.Text = ""
                cmbMonth.SelectedIndex = -1
                cmbDay.SelectedIndex = -1
                txtYear.Enabled = False
                cmbMonth.Enabled = False
                cmbDay.Enabled = False
            End If
            txtSelID.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID").ToString
        End If
    End Sub

    Private Sub Catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablelist.Columns(0).Text += ChrW(&H25BC)
        SetCueText(txtSearchCriteria, "Filter")
        lblHide.Top = 27
        lblHide.Left = 10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim valid As Boolean = True
        If txtNewID.Text = "" Then
            txtNewID.BackColor = Color.Red
            valid = False
            lblNewError.Text = "Fields marked red must be filled"
        Else
            txtNewID.BackColor = Color.White
        End If
        If txtNewDesc.Text = "" Then
            txtNewDesc.BackColor = Color.Red
            valid = False
            lblNewError.Text = "Fields marked red must be filled"
        Else
            txtNewDesc.BackColor = Color.White
        End If
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            If row("GearID").ToString = txtNewID.Text Then
                valid = False
                txtNewID.BackColor = Color.Red
                lblNewError.Text = "ID number already exists"
            End If
        Next
        If valid Then
            lblNewError.Visible = False
            Dim x As DataRow = RootForm.GearDataS.Tables("Gear").NewRow()
            x("GearID") = txtNewID.Text
            x("GearType") = txtNewDesc.Text
            x("Notes") = txtNewAN.Text
            x("ID") = RootForm.GearDataS.Tables("Gear").Rows.Count + 1
            x("StudentLoaned") = 0
            x("DueYear") = 0
            x("DueMonth") = 0
            x("DueDay") = 0
            RootForm.GearDataS.Tables("Gear").Rows.Add(x)
            RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")

            reload()
            txtNewDesc.Text = ""
            txtNewID.Text = ""
            txtNewAN.Text = ""
        Else
            lblNewError.Visible = True
        End If
    End Sub

    Private Sub txtitemid_TextChanged(sender As Object, e As EventArgs) Handles txtNewID.TextChanged
        txtNewID.Text = System.Text.RegularExpressions.Regex.Replace(txtNewID.Text, "[^0-9]", "")
        txtNewID.Select(txtNewID.Text.Length, 0)
    End Sub

    Private Sub txtseliitemid_TextChanged(sender As Object, e As EventArgs) Handles txtSelID.TextChanged
        txtSelID.Text = System.Text.RegularExpressions.Regex.Replace(txtSelID.Text, "[^0-9]", "")
        txtSelID.Select(txtSelID.Text.Length, 0)
    End Sub

    Private Sub Button4_Click() Handles btnReload.Click
        If selected <> -1 Then
            txtSelAN.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("Notes").ToString
            txtSelDesc.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearType").ToString
            '        txtSelIItemID.Text = row("GearID")
            lblHide.Visible = False
            If RootForm.GearDataS.Tables("Gear").Rows(selected).Item("StudentLoaned").ToString <> 0 Then
                txtSL.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("StudentLoaned").ToString
                txtYear.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueYear").ToString
                cmbMonth.SelectedIndex = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueMonth") - 1
                cmbDay.SelectedIndex = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueDay") - 1
                txtYear.Enabled = True
                cmbMonth.Enabled = True
                cmbDay.Enabled = True
            Else
                txtSL.Text = ""
                txtYear.Text = ""
                cmbMonth.SelectedIndex = -1
                cmbDay.SelectedIndex = -1
                txtYear.Enabled = False
                cmbMonth.Enabled = False
                cmbDay.Enabled = False
            End If
            txtSelID.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID").ToString
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        RootForm.GearDataS.Tables("Gear").Rows(selected).Delete()
        RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")


        'For count = selected + 1 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
        '    'RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("ID") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("ID")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("GearID") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("GearID")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("Notes") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("Notes").ToString
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("GearType") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("GearType")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("StudentLoaned") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("StudentLoaned")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("DueDay") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("DueDay")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("DueMonth") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("DueMonth")
        '    RootForm.GearDataS.Tables("Gear").Rows(count - 1).Item("DueYear") = RootForm.GearDataS.Tables("Gear").Rows(count).Item("DueYear")
        'Next


        For count = selected To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
            RootForm.GearDataS.Tables("Gear").Rows(count).Item("ID") -= 1

        Next
        RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")

        selected = -1
        reload()
        lblHide.Visible = True

    End Sub

    Private Function datevalid()
        If txtSL.Text = "" Then
            Return True
        End If
        If cmbDay.SelectedIndex = -1 Or cmbMonth.SelectedIndex = -1 Or txtYear.Text < 1000 Or txtYear.Text > 9999 Then
            Return False
        End If
        If cmbDay.SelectedIndex > 30 Then
            Return False
        End If
        Dim thirty() = {3, 5, 8, 10}
        For i = 0 To 3
            If cmbMonth.SelectedIndex = thirty(i) And cmbDay.SelectedIndex = 30 Then
                Return False
            End If
        Next
        If cmbMonth.SelectedIndex = 1 Then
            If (txtYear.Text Mod 400 = 0 Or (txtYear.Text Mod 4 = 0 And (Not txtYear.Text Mod 100 = 0))) Then
                If cmbDay.SelectedIndex = 29 Then
                    Return False
                End If
            ElseIf cmbDay.SelectedIndex > 27 Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'tbc do save stuff
        Dim valid As Boolean = True
        If txtSelID.Text = "" Then
            txtSelID.BackColor = Color.Red
            valid = False
            lblSelError.Text = "Fields marked red must be filled"
        Else
            txtSelID.BackColor = Color.White
        End If
        If txtSelDesc.Text = "" Then
            txtSelDesc.BackColor = Color.Red
            valid = False
            lblSelError.Text = "Fields marked red must be filled"
        Else
            txtSelDesc.BackColor = Color.White
        End If
        If txtYear.Text = "" And txtSL.Text <> "" Then
            txtYear.BackColor = Color.Red
            valid = False
            lblSelError.Text = "Fields marked red must be filled"
            Label15.Visible = False

        ElseIf Not datevalid() Then
            txtYear.BackColor = Color.White
            Label15.Visible = True
            Label15.Text = "Enter a valid date between 1000 and 9999 CE"
        Else
            txtYear.BackColor = Color.White
            Label15.Visible = False
        End If
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            If row("GearID").ToString = txtSelID.Text And Not row("ID") = selected + 1 Then
                valid = False
                txtSelID.BackColor = Color.Red
                lblSelError.Text = "ID number already exists"
            End If
        Next
        If valid Then
            lblSelError.Visible = False
        Else
            lblSelError.Visible = True
        End If

        If valid And Label15.Visible = False Then

            RootForm.GearDataS.Tables("Gear").Rows(selected).Item("Notes") = txtSelAN.Text
            RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearType") = txtSelDesc.Text
            RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID") = txtSelID.Text
            If txtSL.Text <> "" Then

                RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueDay") = cmbDay.SelectedIndex + 1
                RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueMonth") = cmbMonth.SelectedIndex + 1
                RootForm.GearDataS.Tables("Gear").Rows(selected).Item("dueYear") = txtYear.Text
            End If

            RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")

            reload()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        check = True
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        check = True
        'Button3.Text = "Are you sure?"
    End Sub

    Private Sub Button3_LostFocus(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        check = False

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If check = True Then
            btnConfirm.Left = Math.Max(btnConfirm.Left - 10, 191)
            btnDelete.Left = Math.Max(btnDelete.Left - 5, 235)
            btnDelete.Width = Math.Min(btnDelete.Width + 5, 110)
            If btnDelete.Left = 235 Then
                btnDelete.Text = "Are you sure?"
                Timer1.Enabled = False
            End If
        Else
            btnConfirm.Left = Math.Min(btnConfirm.Left + 10, 271)
            btnDelete.Left = Math.Min(btnDelete.Left + 5, 271)
            btnDelete.Width = Math.Max(btnDelete.Width - 5, 74)
            If btnDelete.Left = 271 Then
                Timer1.Enabled = False
                btnDelete.Text = "Delete"
            End If
        End If
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        check = True
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        check = False

        Timer1.Enabled = True
    End Sub

    Private Sub txtDD_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        txtYear.Text = System.Text.RegularExpressions.Regex.Replace(txtYear.Text, "[^0-9]", "")
        txtYear.Select(txtYear.Text.Length, 0)
    End Sub


End Class

Public Module CueBannerText
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501


    Public Sub SetCueText(cntrl As Control, text As String)
        If TypeOf cntrl Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(cntrl.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf cntrl Is TextBox Then
            SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
End Module