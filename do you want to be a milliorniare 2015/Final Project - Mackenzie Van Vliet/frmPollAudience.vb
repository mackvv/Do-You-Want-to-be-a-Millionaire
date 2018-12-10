Public Class frmPollAudience

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'hides current form, opens game form 
        frmGame.Show()
        Me.Hide()
    End Sub

    Private Sub frmPollAudience_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gets the options of the question from the current text on the buttons on the game form 
        lblA.Text = frmGame.btnA.Text
        lblB.Text = frmGame.btnB.Text
        lblC.Text = frmGame.btnC.Text
        lblD.Text = frmGame.btnD.Text

    End Sub

    Private Sub btnPoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoll.Click
        lblA.Visible = True
        lblB.Visible = True
        lblC.Visible = True
        lblD.Visible = True
        pbA.Visible = True
        pbB.Visible = True
        pbC.Visible = True
        pbD.Visible = True
        lblAP.Visible = True
        lblBP.Visible = True
        lblCP.Visible = True
        lblDP.Visible = True

        btnBack.Visible = True

        btnPoll.Enabled = False

        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer

        'generates randome number
        Dim randomInt As Integer = Int(4 * Rnd() + 1)

        'if the random number is 1 then choice A will be mostly picked by the audience 
        If randomInt = 1 Then
            Do
                A = Int(100 * Rnd() + 1)
                B = Int(100 * Rnd() + 1)
                C = Int(100 * Rnd() + 1)
                D = Int(100 * Rnd() + 1)

            Loop Until A + B + C + D = 100 And A > 40 And B > 15 And C > 15 And D > 15
        End If

        'if the random number is 2 then choice A will be mostly picked by the audience 
        If randomInt = 2 Then
            Do
                A = Int(100 * Rnd() + 1)
                B = Int(100 * Rnd() + 1)
                C = Int(100 * Rnd() + 1)
                D = Int(100 * Rnd() + 1)

            Loop Until A + B + C + D = 100 And B > 40 And A > 15 And C > 15 And D > 15
        End If

        'if the random number is 3 then choice A will be mostly picked by the audience 
        If randomInt = 3 Then
            Do
                A = Int(100 * Rnd() + 1)
                B = Int(100 * Rnd() + 1)
                C = Int(100 * Rnd() + 1)
                D = Int(100 * Rnd() + 1)

            Loop Until A + B + C + D = 100 And C > 40 And A > 15 And B > 15 And D > 15
        End If

        'if the random number is 4 then choice A will be mostly picked by the audience 
        If randomInt = 4 Then
            Do
                A = Int(100 * Rnd() + 1)
                B = Int(100 * Rnd() + 1)
                C = Int(100 * Rnd() + 1)
                D = Int(100 * Rnd() + 1)

            Loop Until A + B + C + D = 100 And D > 40 And A > 15 And B > 15 And C > 15
        End If

        'displays the audience responses in a percentbar and a label 
        pbA.Value = A
        pbB.Value = B
        pbC.Value = C
        pbD.Value = D

        lblAP.Text = A & "%"
        lblBP.Text = B & "%"
        lblCP.Text = C & "%"
        lblDP.Text = D & "%"

    End Sub
End Class