Public Class Returns

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(GearLoaning.dataS.Tables("Gear").Rows(0)("StudentLoaned"))
    End Sub
End Class