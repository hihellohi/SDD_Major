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
        btnLoan.Top = 79
        btnLoan.Height = 31
        btnCatalog.Top = 79
        btnCatalog.Height = 31
        btnHelp.Top = 79
        btnHelp.Height = 31
        btnReturn.Top = 71
        btnReturn.Height = 39
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
        btnReturn.Top = 79
        btnReturn.Height = 31
        btnCatalog.Top = 79
        btnCatalog.Height = 31
        btnHelp.Top = 79
        btnHelp.Height = 31
        btnLoan.Top = 71
        btnLoan.Height = 39
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
        btnLoan.Top = 79
        btnLoan.Height = 31
        btnReturn.Top = 79
        btnReturn.Height = 31
        btnHelp.Top = 79
        btnHelp.Height = 31
        btnCatalog.Top = 71
        btnCatalog.Height = 39
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
        btnLoan.Top = 79
        btnLoan.Height = 31
        btnCatalog.Top = 79
        btnCatalog.Height = 31
        btnReturn.Top = 79
        btnReturn.Height = 31
        btnHelp.Top = 71
        btnHelp.Height = 39
    End Sub

    Private Sub btnReturn_Mouseenter(sender As Object, e As EventArgs) Handles btnReturn.MouseEnter
        btnReturn.Top = 71
        btnReturn.Height = 39
    End Sub

    Private Sub btnLoan_Mouseenter(sender As Object, e As EventArgs) Handles btnLoan.MouseEnter
        btnLoan.Top = 71
        btnLoan.Height = 39
    End Sub

    Private Sub btnCatalog_Mouseenter(sender As Object, e As EventArgs) Handles btnCatalog.MouseEnter
        btnCatalog.Top = 71
        btnCatalog.Height = 39
    End Sub


    Private Sub btnHelp_Mouseenter(sender As Object, e As EventArgs) Handles btnHelp.MouseEnter
        btnHelp.Top = 71
        btnHelp.Height = 39
    End Sub

    Private Sub btnReturn_Mouseleave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave
        If Not intform = RETURNS Then
            btnReturn.Top = 79
            btnReturn.Height = 31
        End If

    End Sub

    Private Sub btnLoan_Mouseleave(sender As Object, e As EventArgs) Handles btnLoan.MouseLeave
        If Not intform = LOANS Then
            btnLoan.Top = 79
            btnLoan.Height = 31
        End If
    End Sub

    Private Sub btnCatalog_Mouseleave(sender As Object, e As EventArgs) Handles btnCatalog.MouseLeave
        If Not intform = CATALOG Then
            btnCatalog.Top = 79
            btnCatalog.Height = 31
        End If
    End Sub


    Private Sub btnHelp_Mouseleave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        If Not intform = HELP Then
            btnHelp.Top = 79
            btnHelp.Height = 31
        End If
    End Sub
End Class