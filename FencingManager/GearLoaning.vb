Public Class GearLoaning
    Const RETURNS = 0
    Const LOANS = 1
    Const CATALOG = 2
    Dim frmReturn As New Returns()
    Dim frmloans As New Loans()
    Dim frmCatalog As New Catalog()
    Dim topForm = frmReturn
    Dim intform = RETURNS
    

    Public Sub reload()
        If intform = LOANS Then
            frmloans.reload()
        End If
    End Sub

    'Public Sub kbhook(ByVal key As System.Windows.Forms.Keys)
    '    If intform = RETURNS Then
    '        frmReturn.kbHook(key)
    '    ElseIf intform = LOANS Then
    '        frmloans.kbHook(key)
    '    End If
    'End Sub

    Private Sub GearLoaning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmReturn.TopLevel = False
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
        intform = RETURNS
        topForm.show()
        btnReturn.BackColor = Color.White
        btnLoan.BackColor = Color.Green
        btnCatalog.BackColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        topForm.hide()
        topForm = frmloans
        intform = LOANS
        topForm.show()
        frmloans.reload()
        btnReturn.BackColor = Color.Green
        btnLoan.BackColor = Color.White
        btnCatalog.BackColor = Color.Green
    End Sub

    Private Sub btnCatalog_Click(sender As Object, e As EventArgs) Handles btnCatalog.Click
        topForm.hide()
        topForm = frmCatalog
        intform = CATALOG
        topForm.show()
        frmCatalog.reload()
        btnReturn.BackColor = Color.Green
        btnLoan.BackColor = Color.Green
        btnCatalog.BackColor = Color.White
    End Sub
End Class