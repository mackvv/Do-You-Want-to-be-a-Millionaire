Public Class frmAbout

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'if no name has been inputted, go back to the start screen 
        'if name has been inputted go back to game screen
        If frmStartUp.lastname = Nothing Then
            frmStartUp.Show()
        Else
            frmGame.Show()
        End If

        Me.Hide()
    End Sub

End Class