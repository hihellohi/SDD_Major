Imports System.Runtime.InteropServices

Public Class Catalog

    Structure item
        Public id As Integer
        Public student As Integer
        Public due As Date
        Public gearID As String
        Public gearType As String
    End Structure

    Dim items As New List(Of item)()
    Dim sort As Integer = -1
    Public selected As Integer = -1
    Dim check As Boolean = False
    Dim opened As Boolean = False
    Const HEAD_FONT As String = "trebuchet MS"
    Const BODY_FONT As String = "helvetica"

    Public Sub reload()
        'refresh the page
        items.Clear()
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows

            'apply filter
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

            'load item into array of item
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
                items.Add(rowItem)
            End If
        Next
        sort_items()
        loadTable()
        btnReload_Click()
    End Sub

    Private Sub sort_items()
        'Heapsort master race (O(nlogn))
        Dim heap(1 + (items.Count * 2)) As item
        Dim count As Integer = 1
        Dim tmp As item
        For i = 0 To (1 + (items.Count * 2))
            heap(i).gearID = -1
            heap(i).gearType = ""
        Next
        'construct heap
        For Each tmp In items
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
        items.Clear()

        'construct sorted list
        For i = 1 To count - 1
            items.Add(heap(1))

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
        'load array of item into table
        Dim count As Integer = 0
        tablelist.Items.Clear()
        Dim row As item
        For Each row In items
            count += 1
            Dim rowItem = New ListViewItem(row.gearID)
            rowItem.SubItems.Add(row.gearType)
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
        'if the filter is increases in length, we can assume that all items that pass the filter will already be in the existing 
        'table in sorted order, thus we can increase efficiency by only filtering out the invalid items in the existing table
        Dim tmp As New List(Of item)()
        For i = 0 To items.Count - 1
            Dim comp As String
            If rdbType.Checked Then
                comp = items(i).gearType.ToLower
            ElseIf rdbStudent.Checked Then
                comp = items(i).student.ToString.ToLower
            Else
                comp = items(i).gearID.ToLower
            End If
            If comp.StartsWith(txtSearchCriteria.Text.ToLower) Then
                tmp.Add(items(i))
            End If
        Next
        items = tmp
        loadTable()
    End Sub

    Private Sub txtSearchCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCriteria.TextChanged
        'search
        Static old As String = ""
        If txtSearchCriteria.Text.StartsWith(old) Then
            quickReload()
        Else
            reload()
        End If
        old = txtSearchCriteria.Text
    End Sub

    Private Sub tablelist_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles tablelist.ColumnClick
        'updates the variable sort which determines the method of comparison when sorting then refreshes
        If sort <> -(e.Column + 1) Then
            sort = -(e.Column + 1)
            sort_items()
            For i = 0 To 3
                tablelist.Columns(i).Text = tablelist.Columns(i).Text.Trim(ChrW(&H25B2))
                tablelist.Columns(i).Text = tablelist.Columns(i).Text.Trim(ChrW(&H25BC))
            Next
            tablelist.Columns(e.Column).Text += ChrW(&H25BC)
        Else
            sort = (e.Column + 1)
            items.Reverse()
            tablelist.Columns(e.Column).Text = tablelist.Columns(e.Column).Text.Trim(ChrW(&H25BC))
            tablelist.Columns(e.Column).Text += ChrW(&H25B2)
        End If
        loadTable()
    End Sub

    Private Sub tablelist_DoubleClick(sender As Object, e As EventArgs) Handles tablelist.ItemSelectionChanged
        'loads record information to the textboxes
        If tablelist.SelectedIndices.Count = 1 Then
            selected = items(tablelist.SelectedIndices(0)).id - 1
            txtSelAN.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("Notes").ToString
            txtSelDesc.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearType")
            txtSelID.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID").ToString
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

        End If
    End Sub

    Private Sub Catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialisation
        tablelist.Columns(0).Text += ChrW(&H25BC)
        SetCueText(txtSearchCriteria, "Filter")
        lblHide.Top = 27
        lblHide.Left = 10
        opened = True
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Data validation
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

        'check if item id is taken
        Dim row As DataRow
        For Each row In RootForm.GearDataS.Tables("Gear").Rows
            If row("GearID").ToString = txtNewID.Text Then
                valid = False
                txtNewID.BackColor = Color.Red
                lblNewError.Text = "ID number already exists"
            End If
        Next

        'save the new record
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
            RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] Item " + x("GearID").ToString() + " was created by " + GlobalVariables.Username)
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
        'data validation
        txtNewID.Text = System.Text.RegularExpressions.Regex.Replace(txtNewID.Text, "[^0-9]", "")
        txtNewID.Select(txtNewID.Text.Length, 0)
    End Sub

    Private Sub txtseliitemid_TextChanged(sender As Object, e As EventArgs) Handles txtSelID.TextChanged
        'data validation
        txtSelID.Text = System.Text.RegularExpressions.Regex.Replace(txtSelID.Text, "[^0-9]", "")
        txtSelID.Select(txtSelID.Text.Length, 0)
    End Sub

    Private Sub btnReload_Click() Handles btnReload.Click
        'refreshes the selected section
        If selected <> -1 Then
            txtSelAN.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("Notes").ToString
            txtSelDesc.Text = RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearType").ToString
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

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'removes the selected record
        RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] Item " + RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID") + " was deleted by " + GlobalVariables.Username)
        RootForm.GearDataS.Tables("Gear").Rows(selected).Delete()
        RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")

        'update the other record's ID numbers
        For count = selected To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
            RootForm.GearDataS.Tables("Gear").Rows(count).Item("ID") -= 1

        Next
        RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")

        selected = -1
        reload()
        lblHide.Visible = True

    End Sub

    Private Function datevalid()
        'checks if the input date exists
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'validate the input
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
        'check if the id number is taken
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
        'save changes
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
            RootForm.writeEditLog("[" + DateString + " " + TimeOfDay + "] Item " + RootForm.GearDataS.Tables("Gear").Rows(selected).Item("GearID") + " was edited by " + GlobalVariables.Username)
            reload()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        check = True
        animationTimer.Enabled = True
    End Sub

    Private Sub btnDelete_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        check = True
        'Button3.Text = "Are you sure?"
    End Sub

    Private Sub btnDelete_LostFocus(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        check = False

        animationTimer.Enabled = True

    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        'move left
        If check = True Then
            btnConfirm.Left = Math.Max(btnConfirm.Left - 10, 191)
            btnDelete.Left = Math.Max(btnDelete.Left - 5, 235)
            btnDelete.Width = Math.Min(btnDelete.Width + 5, 110)
            If btnDelete.Left = 235 Then
                btnDelete.Text = "Are you sure?"
                animationTimer.Enabled = False
            End If
        Else
            'move right
            btnConfirm.Left = Math.Min(btnConfirm.Left + 10, 271)
            btnDelete.Left = Math.Min(btnDelete.Left + 5, 271)
            btnDelete.Width = Math.Max(btnDelete.Width - 5, 74)
            If btnDelete.Left = 271 Then
                animationTimer.Enabled = False
                btnDelete.Text = "Delete"
            End If
        End If
    End Sub

    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        check = True
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        check = False

        animationTimer.Enabled = True
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        'data validation
        txtYear.Text = System.Text.RegularExpressions.Regex.Replace(txtYear.Text, "[^0-9]", "")
        txtYear.Select(txtYear.Text.Length, 0)
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            'write head
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            'write title
            out += "<font face=""" + HEAD_FONT + """ size = 6>C</font><font face=""" + HEAD_FONT + """ size = 5>ATALOG" + "</font></p>"
            'write table
            out += "<font face=""" + BODY_FONT + """ size = 4><p><table width=""500"" align=""center""><tr><th>Gear ID</th><th>Gear Type</th><th>Student Loaned</th><th>Due Date</th></tr>"
            For Each item In tablelist.Items
                out += "<tr align=""center""><td>" + item.SubItems(0).Text.ToString + "</td><td>" + item.SubItems(1).Text.ToString + "</td><td>" + item.SubItems(2).Text.ToString + "</td><td>" + item.SubItems(3).Text.ToString + "</td></tr>"
            Next
            out += "</table></p></font></body></html>"
            tmp.Document.Write(out)

            tmp.Print()
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim tmp As New WebBrowser
        tmp.Navigate("about:blank")
        If (tmp.Document <> Nothing) Then

            Dim item As ListViewItem
            'write head
            Dim out = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><p align=""center"">"
            'write title
            out += "<font face=""" + HEAD_FONT + """ size = 6>C</font><font face=""" + HEAD_FONT + """ size = 5>ATALOG" + "</font></p>"
            'write table
            out += "<font face=""" + BODY_FONT + """ size = 4><p><table width=""500"" align=""center""><tr><th>Gear ID</th><th>Gear Type</th><th>Student Loaned</th><th>Due Date</th></tr>"
            For Each item In tablelist.Items
                out += "<tr align=""center""><td>" + item.SubItems(0).Text.ToString + "</td><td>" + item.SubItems(1).Text.ToString + "</td><td>" + item.SubItems(2).Text.ToString + "</td><td>" + item.SubItems(3).Text.ToString + "</td></tr>"
            Next
            out += "</table></p></font></body></html>"
            tmp.Document.Write(out)
            tmp.ShowPrintPreviewDialog()
        End If
    End Sub

    Private Sub rdbType_CheckedChanged(sender As Object, e As EventArgs) Handles rdbType.CheckedChanged
        If opened Then
            reload()
        End If
    End Sub

    Private Sub rdbStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rdbStudent.CheckedChanged
        If opened Then
            reload()
        End If
    End Sub


End Class

Public Module CueBannerText
    'Credit Mark Hall from stackoverflow
    'http://stackoverflow.com/questions/18563522/implementing-a-cue-banner-to-a-textbox-in-vb-net
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