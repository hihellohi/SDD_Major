﻿Public Class Loans
    Dim input As String
    Dim mode As Integer
    Const loggedIn = 1
    Const loggedOut = 0

    Public Sub kbHook(ByVal key As System.Windows.Forms.Keys)
        If key = Keys.Enter Then
            Dim tmp As Boolean = True
            For i = 0 To GearLoaning.dataS.Tables("Gear").Rows.Count - 1
                If GearLoaning.dataS.Tables("Gear").Rows(i).Item(0).ToString = input Then
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
            input = ""
        Else
            input += Mid(key.ToString(), key.ToString().Length)
        End If
    End Sub


    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        input = ""
        mode = 0
    End Sub
End Class