Imports System.Data.OleDb
Public Class Returns

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GearLoaning.dataS.Tables("Gear").Rows(1).Item(3) = 2
        GearLoaning.adapter.Update(GearLoaning.dataS, "Gear")

    End Sub
End Class