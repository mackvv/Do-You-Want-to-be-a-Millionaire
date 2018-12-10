Public Class frmCheckWinnings


    
    Private Sub btnBack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'goes back to game
        frmGame.Show()
        Me.Hide()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKToolStripMenuItem.Click
        'goes back to game
        frmGame.Show()
        Me.Hide()
    End Sub

    Private Sub GOHOMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GOHOMEToolStripMenuItem.Click
        'if button yes is clicked the player goes home with their winnings

        Dim winningsWritten As String
        Dim totalearnings As String = lblCurrentWinnings.Text

        'Puts whatever the players winnings are into text form for the cheque
        If totalEarnings = 100 Then
            winningsWritten = "One Hundred"
        ElseIf totalEarnings = 200 Then
            winningsWritten = "Two Hundred"
        ElseIf totalEarnings = 500 Then
            winningsWritten = "Five Hundred"
        ElseIf totalEarnings = 1000 Then
            winningsWritten = "One Thousand"
        ElseIf totalEarnings = 2000 Then
            winningsWritten = "Two Thousand"
        ElseIf totalEarnings = 4000 Then
            winningsWritten = "Four Thousand"
        ElseIf totalEarnings = 8000 Then
            winningsWritten = "Eight Thousand"
        ElseIf totalEarnings = 16000 Then
            winningsWritten = "Sixteen Thousand "
        ElseIf totalEarnings = 32000 Then
            winningsWritten = "Thirty-Two Thousand"
        ElseIf totalEarnings = 64000 Then
            winningsWritten = "Sixty-Four Thousand"
        ElseIf totalEarnings = 125000 Then
            winningsWritten = "One Hundred Twenty-Five Thousand"
        ElseIf totalEarnings = 250000 Then
            winningsWritten = "Two Hundred and Fifty Thousand"
        ElseIf totalEarnings = 500000 Then
            winningsWritten = "Five Hundred Thousand"
        ElseIf totalEarnings = 1000000 Then
            winningsWritten = "One Million"
        End If

        'puts the written winnings and numerical written winnings on the cheque
        frmWinnings.lblCash.Text = winningsWritten
        frmWinnings.lblDollars.Text = totalEarnings

        Me.Hide()
        frmWinnings.Show()
    End Sub
End Class