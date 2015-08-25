Imports System.Data.OleDb

Public Class Returns
    Dim old As String
    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim found As Boolean = True
            'find item
            For i = 0 To RootForm.GearDataS.Tables("Gear").Rows.Count - 1
                If RootForm.GearDataS.Tables("Gear").Rows(i)("GearID").ToString = txtInput.Text Then
                    If RootForm.GearDataS.Tables("Gear").Rows(i).Item(3) = 0 Then
                        lblOutput.Text = "Item not loaned"
                    Else
                        'remove loan on item
                        lblOutput.Text = RootForm.GearDataS.Tables("Gear").Rows(i).Item(1)
                        RootForm.GearDataS.Tables("Gear").Rows(i).Item(3) = 0
                        RootForm.GearDataS.Tables("Gear").Rows(i).Item(4) = 0
                        RootForm.GearDataS.Tables("Gear").Rows(i).Item(5) = 0
                        RootForm.GearDataS.Tables("Gear").Rows(i).Item(6) = 0
                        RootForm.GearAdapter.Update(RootForm.GearDataS, "Gear")
                    End If
                    found = False
                End If
            Next
            If found = True Then
                lblOutput.Text = "item not found"
            End If
            txtInput.Text = ""
        End If
    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Text = ""
        Dim cb As New OleDb.OleDbCommandBuilder(RootForm.GearAdapter)

    End Sub


    Private Sub btnbarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        'Begin Scanning
        txtInput.Focus()
        old = txtInput.Text
        txtInput.Text = ""
        btnBarcode.BackColor = Color.Green
        btnBarcode.Text = "Scanning..."
    End Sub


    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        btnManual.Visible = False
        txtInput.Focus()
    End Sub

    Private Sub txtInput_LostFocus(sender As Object, e As EventArgs) Handles txtInput.LostFocus
        'when textbox is clicked away
        If btnManual.Visible Then
            txtInput.Text = old
        End If
        btnManual.Visible = True
        btnBarcode.BackColor = btnManual.BackColor
        btnBarcode.Text = "Use Barcode Scanner"
    End Sub


End Class