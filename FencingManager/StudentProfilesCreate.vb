Public Class StudentProfilesCreate
        Public newRow As FencingDataSet.StudentProfilesRow

        Public Sub New(row As FencingDataSet.StudentProfilesRow)
            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            newRow = row
        End Sub

        Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            End If
            If txtSurname.Text = "" Then
                valid = False
            End If
            If txtID.TextLength < 9 Then
                valid = False
            End If
            If cbbYear.Text = "" Then
                valid = False
            End If
            If cbbWeapon.Text = "" Then
                valid = False
            End If
            If txtEmail.Text = "" Then
                valid = False
            End If
            If txtPhone.Text = "" Then
                valid = False
            End If
            If valid = True Then
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

                'Defaults
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
        End Sub

        Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        GenerateTitle()
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
End Class