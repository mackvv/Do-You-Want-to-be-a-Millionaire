Public Class frmPhoneFriend
    Dim caller As String

    Public name As String = frmStartUp.name

    

    Dim answer As String
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmGame.Show()
        Me.Hide()
    End Sub

   
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'dims the choices as the current text in the buttons on the game form 
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text

        'dims the question as the current question on the game form
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Jessica Lange"

        'makes caller say the answer is choice A
        answer = choiceA

        'displays output in phone call format 
        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question: " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer

        ''''''''''REPEATS FOR ALL CALLERS WITH THE EXCEPTION OF ANSWERS CHANGING''''''''''
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        ''''''''FOR COMMENTS LOOK AT btn1_click''''''''
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Misty Day"

        answer = choiceB

        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question: " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        ''''''''FOR COMMENTS LOOK AT btn1_click''''''''
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Mark Wahlberg"

        answer = choiceC

        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question: " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        ''''''''FOR COMMENTS LOOK AT btn1_click''''''''
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Helen Bates"

        answer = choiceD

        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question: " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        ''''''''FOR COMMENTS LOOK AT btn1_click''''''''
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Suzy McGee"

        answer = choiceA

        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question: " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        ''''''''FOR COMMENTS LOOK AT btn1_click''''''''
        Dim choiceA As String = frmGame.btnA.Text
        Dim choiceB As String = frmGame.btnB.Text
        Dim choiceC As String = frmGame.btnC.Text
        Dim choiceD As String = frmGame.btnD.Text
        Dim question As String = frmGame.lblQuestion.Text

        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
        lblP.Visible = False

        lblCallerAnswer.Visible = True
        lblCalling.Visible = True
        lblHostQuestion.Visible = True

        caller = "Larry McQueen"

        answer = choiceC

        lblCalling.Text = "Calling " & caller
        lblHostQuestion.Text = "Host: Help " & name & " out in their journey to win one million dollars and answer this question " & question
        lblCallerAnswer.Text = caller & ": I think the answer is " & answer
    End Sub

    Private Sub lblHostQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHostQuestion.Click

    End Sub
End Class