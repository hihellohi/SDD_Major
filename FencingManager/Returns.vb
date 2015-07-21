Imports System.Data.OleDb

Public Class Returns

    Public Sub kbHook(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim tmp As Boolean = True
            For i = 0 To GearLoaning.dataS.Tables("Gear").Rows.Count - 1
                If GearLoaning.dataS.Tables("Gear").Rows(i).Item(0).ToString = TextBox2.Text Then
                    If GearLoaning.dataS.Tables("Gear").Rows(i).Item(3) = 0 Then
                        Label1.Text = "Item not loaned"
                    Else
                        Label1.Text = GearLoaning.dataS.Tables("Gear").Rows(i).Item(1)
                        GearLoaning.dataS.Tables("Gear").Rows(i).Item(3) = 0
                        GearLoaning.dataS.Tables("Gear").Rows(i).Item(4) = 0
                        GearLoaning.dataS.Tables("Gear").Rows(i).Item(5) = 0
                        GearLoaning.dataS.Tables("Gear").Rows(i).Item(6) = 0
                        GearLoaning.adapter.Update(GearLoaning.dataS, "Gear")

                    End If
                    tmp = False
                End If
            Next
            If tmp = True Then
                Label1.Text = "item not found"
            End If
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = ""
        Dim cb As New OleDb.OleDbCommandBuilder(GearLoaning.adapter)
        
    End Sub


End Class