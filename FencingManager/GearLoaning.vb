Public Class GearLoaning

    Private Sub GearLoaning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmReturn As New returns()
        frmReturn.toplevel = False
        Panel1.Controls.Add(frmReturn)
        Dim frmloans As New Loans()
        frmloans.TopLevel = False
        Panel1.Controls.Add(frmloans)
        Dim frmCatalog As New Catalog()
        frmCatalog.TopLevel = False
        Panel1.Controls.Add(frmCatalog)
    End Sub
End Class