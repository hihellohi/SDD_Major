Public Class GearLoaning
    Const RETURNS = 0
    Const LOANS = 1
    Const CATALOG = 2
    Const HELP = 3
    Dim frmReturn As New Returns()
    Dim frmloans As New Loans()
    Dim frmCatalog As New Catalog()
    Dim frmlhelp As New loanshelp()
    Dim frmrhelp As New returnhelp()
    Dim frmchelp As New cataloghelp()
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
        frmlhelp.TopLevel = False
        formPanel.Controls.Add(frmlhelp)

        frmchelp.TopLevel = False
        formPanel.Controls.Add(frmchelp)

        frmrhelp.TopLevel = False
        formPanel.Controls.Add(frmrhelp)

        frmReturn.TopLevel = False
        formPanel.Controls.Add(frmReturn)

        frmloans.TopLevel = False
        formPanel.Controls.Add(frmloans)

        frmCatalog.TopLevel = False
        formPanel.Controls.Add(frmCatalog)

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
        btnHelp.BackColor = Color.Green
    End Sub

    Private Sub btnloan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        topForm.hide()
        topForm = frmloans
        intform = LOANS
        topForm.show()
        frmloans.reload()
        btnReturn.BackColor = Color.Green
        btnLoan.BackColor = Color.White
        btnCatalog.BackColor = Color.Green
        btnHelp.BackColor = Color.Green
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
        btnHelp.BackColor = Color.Green
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        topForm.hide()
        If intform = RETURNS Then
            topForm = frmrhelp
        ElseIf intform = LOANS Then
            topForm = frmlhelp
        ElseIf intform = CATALOG Then
            topForm = frmchelp
        End If
        topForm.show()
        intform = HELP
        btnReturn.BackColor = Color.Green
        btnLoan.BackColor = Color.Green
        btnCatalog.BackColor = Color.Green
        btnHelp.BackColor = Color.White
    End Sub

End Class