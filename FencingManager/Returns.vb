Imports System.Data.OleDb

Public Class Returns

    Dim input As String

    Public Sub kbHook(ByVal key As System.Windows.Forms.Keys)
        If key = Keys.Enter Then
            Dim tmp As Boolean = True
            For i = 0 To GearLoaning.dataS.Tables("Gear").Rows.Count - 1
                MsgBox(input)
                If GearLoaning.dataS.Tables("Gear").Rows(i).Item(0).ToString = input Then
                    Label1.Text = GearLoaning.dataS.Tables("Gear").Rows(i).Item(1)
                    tmp = False
                End If
            Next
            If tmp = True Then
                Label1.Text = "item not found"
            End If
            input = ""
        Else
            input += Mid(key.ToString(), 2)
        End If
    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input = ""
        Dim cb As New OleDb.OleDbCommandBuilder(GearLoaning.adapter)
        MsgBox(GearLoaning.dataS.Tables("Gear").Rows(0).Item(0))
        GearLoaning.adapter.Update(GearLoaning.dataS, "Gear")
    End Sub

End Class