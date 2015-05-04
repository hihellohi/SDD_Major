Public Class GearLoaning

    Private Sub GearLoaning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmReturn As New returns()
        frmReturn.toplevel = False
        Panel1.Controls.Add(frmReturn)
        Dim frmloans As New Loans()
        frmReturn.toplevel = False
        Panel1.Controls.Add(frmReturn)
        Dim frmCatalog As New Catalog()
        frmReturn.toplevel = False
        Panel1.Controls.Add(frmReturn)
    End Sub
End Class