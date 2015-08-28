Imports System.Text.RegularExpressions

Public Class StudentProfilesCreate
    Public newRow As FencingDataSet.StudentProfilesRow
    Dim emailRegex As Regex
    Dim studentDataTable As New FencingDataSet.StudentProfilesDataTable
    Dim studentAdapter As New FencingDataSetTableAdapters.StudentProfilesTableAdapter
    Dim usedIDs As List(Of Integer)

    Public Sub New(row As FencingDataSet.StudentProfilesRow)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        newRow = row
        usedIDs = New List(Of Integer)()
        studentAdapter.Fill(studentDataTable)
        For Each studentRow As FencingDataSet.StudentProfilesRow In studentDataTable
            usedIDs.Add(studentRow.StudentID)
        Next
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailRegex = New Regex("^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        cbbYear.SelectedIndex = 0
        cbbWeapon.SelectedIndex = 0
    End Sub

    Private Sub GenerateTitle()
        If txtFirstName.Text = "" Then
            Me.Text = "Create New Profile"
        Else
            Me.Text = "Create New Profile: " + txtFirstName.Text + " " + txtSurname.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msg = MessageBox.Show("Are you sure you want to cancel?", "Create New Profile", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2)
        If msg = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Validate data
        Dim valid = True
        If txtFirstName.Text = "" Then
            valid = False
            errFirstName.Show()
        End If
        If txtSurname.Text = "" Then
            valid = False
            errSurname.Show()
        End If
        If txtID.TextLength < 9 Then
            valid = False
            errStudentID.Show()
            errorToolTip.SetToolTip(Me.errStudentID, "Please enter a valid student number")
        ElseIf usedIDs.Contains(CInt(txtID.Text)) Then
            valid = False
            errStudentID.Show()
            errorToolTip.SetToolTip(Me.errStudentID, "That student number is already taken by another student")
        End If
        If Not emailRegex.Match(txtEmail.Text).Success Then 'Check if valid email address
            valid = False
            errEmail.Show()
        End If
        If txtPhone.Text = "" Then
            valid = False
            errPhone.Show()
        End If
        If valid = True Then 'Create Student Profile record
            newRow.FirstName = txtFirstName.Text
            newRow.Surname = txtSurname.Text
            newRow.StudentID = CInt(txtID.Text)
            newRow.SchoolYear = CShort(cbbYear.Text)
            newRow.Weapon = CByte(cbbWeapon.SelectedIndex + 1)
            newRow.Email = txtEmail.Text
            newRow.PhoneNum = txtPhone.Text

            If newRow.SchoolYear < 10 Then
                newRow.YearGroup = 0 ' Junior
            Else
                newRow.YearGroup = 1 ' Senior
            End If

            'Default values - empty scores
            newRow.totalAbsences = 0
            newRow.unexplainedAbsences = 0
            newRow.totalPresences = 0
            newRow.Wins = 0
            newRow.Losses = 0
            newRow.Kills = 0
            newRow.Deaths = 0
            newRow.YearJoined = Now.Year
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        GenerateTitle()
        errFirstName.Hide()
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        GenerateTitle()
        errSurname.Hide()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        'Check digits using ASCII Values
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            'Check for backspaces
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        'Check digits using ASCII Values
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            'Check for backspaces, spaces or +
            If Asc(e.KeyChar) <> 8 And e.KeyChar <> " " And e.KeyChar <> "+" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.TextLength = 9 Then
            errStudentID.Hide()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        errEmail.Hide()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        errPhone.Hide()
    End Sub
End Class