Public Class GearLoaning
    Dim frmReturn As New Returns()
    Dim frmloans As New Loans()
    Dim frmCatalog As New Catalog()
    Dim topForm = frmReturn

    Private Sub GearLoaning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmReturn.toplevel = False
        Panel1.Controls.Add(frmReturn)

        frmloans.TopLevel = False
        Panel1.Controls.Add(frmloans)

        frmCatalog.TopLevel = False
        Panel1.Controls.Add(frmCatalog)

        topForm.show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        topForm.hide()
        topForm = frmReturn
        topForm.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        topForm.hide()
        topForm = frmloans
        topForm.show()
    End Sub

    Private Sub btnCatalog_Click(sender As Object, e As EventArgs) Handles btnCatalog.Click
        topForm.hide()
        topForm = frmCatalog
        topForm.show()
    End Sub
End Class