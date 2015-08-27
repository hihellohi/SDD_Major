Imports System.Windows.Forms

Public Class StudentProfilesAddScores
    Public newScore As FencingDataSet.ScoresRow

    Public Sub New(scoreRow As FencingDataSet.ScoresRow)
        InitializeComponent()
        newScore = scoreRow
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        newScore.MatchDate = dateSelector.Value
        newScore.Kills = txtKills.Text
        newScore.Deaths = txtDeaths.Text
        newScore.Opponent = txtOpponent.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DataValidate(sender As Object, e As EventArgs) Handles txtOpponent.TextChanged, txtKills.TextChanged, txtDeaths.TextChanged
        If txtOpponent.Text <> "" And IsNumeric(txtKills.Text) And IsNumeric(txtDeaths.Text) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
End Class
