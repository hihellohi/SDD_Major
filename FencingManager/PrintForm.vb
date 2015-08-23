Public Class PrintForm

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabDate.Text = PrintDate
        LabEventName.Text = PrintEventName
        LabDatePrinted.Text = "Printed on the date: " & CStr(Now)
        LabGroup.Text = PrintGroup
        LabVenue.Text = PrintVenue
        LabTime.Text = PrintTime
        LabWeapon.Text = PrintWeapon
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Print this event?", "Print", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            MsgBox("Print cancelled")
            Exit Sub
        End If

        Button1.Visible = False
        ButCancel.Visible = False
        If TexAdditionalInfo.Text = "" Then
            LabNoAdditionalInfo.Visible = True
            TexAdditionalInfo.Visible = False
        Else
            LabNoAdditionalInfo.Visible = False
            TexAdditionalInfo.Visible = True
        End If

        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)

        Me.Close()
    End Sub

    Private Sub TexAdditionalInfo_Click(sender As Object, e As EventArgs) Handles TexAdditionalInfo.Click
        TexAdditionalInfo.Text = ""
    End Sub
End Class