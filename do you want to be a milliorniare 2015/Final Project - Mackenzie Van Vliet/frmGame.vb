Public Class frmGame
    'sets timer amount
    Dim timerCount As Integer = 30

    'total earnings is the amount the player has won 
    Public totalEarnings As Integer = 0
    'cheque amount is how much the player will win if the get an answer wrong (ex will win 1000 if the get question 2000 wrong)
    Public chequeAmount As Integer = 0

    'Questions
    Dim questions(13, 1) As String
    Public qStart As String = "What is the first season of American Horror Story called?"

    Public q1 As String = "How many kids did Constance have? (season 1)"
    Public q2 As String = "How many kids died during the Westfield High shooting? (season 1)"
    Public q3 As String = "What is the American Horror Story font?"
    Public q4 As String = "Which singer apeared in season 2?"
    Public q5 As String = "What does Grace keep drawing? (season 3)"
    Public q6 As String = "How many kids does Kit have? (season 2)"
    Public q7 As String = "What does Sister Jude call Lana? (season 2)"
    Public q8 As String = "What was Madison before she found out she was a witch? (season 3)"
    Public q9 As String = "Who was Misty's idol? (season 3)"
    Public q10 As String = "Where is the Freak Show located? (season 4)"
    Public q11 As String = "Who is the new Supreme? (season 3)"
    Public q12 As String = "Which love interests are enganged in real life"
    Public q13 As String = "Which singer is set to appear in upcoming season 5?"
    Public q14 As String = "What song does lead Jessia Lange end her AHS career with? (season 4)?"

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts timer on form load
        Timer1.Enabled = True

        'puts timer count down in label
        lbltimer.Text = timerCount

        'if timer count is 0 then say times up, if not decrease time
        If timerCount = 0 Then
            Timer1.Enabled = False
            timerCount = 30
            MessageBox.Show("Times up")
            If totalEarnings < 1000 Then
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If
            Me.Hide()
        Else
            timerCount = timerCount - 1
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'puts timer count down in label
        lbltimer.Text = timerCount

        'if timer count is 0 then say times up, if not decrease time
        If timerCount = 0 Then
            Timer1.Enabled = False
            timerCount = 30
            MessageBox.Show("Times up")
            If totalEarnings < 1000 Then
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If
            Me.Hide()
        Else
            timerCount = timerCount - 1
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'displays help form 
        frmHelp.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'displays about form
        frmAbout.Show()
        Me.Hide()
    End Sub

    Private Sub btnPhoneFriend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoneFriend.Click
        'displays Phone a Friend form and disables the other hint options
        btnPhoneFriend.Visible = False
        btn5050.Enabled = False
        btnPollAudience.Enabled = False
        frmPhoneFriend.Show()

    End Sub

    Private Sub btnPollAudience_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPollAudience.Click
        'displays poll audience form and disables other hint options
        btnPollAudience.Visible = False
        btnPhoneFriend.Enabled = False
        btn5050.Enabled = False
        frmPollAudience.Show()
    End Sub

    Private Sub btnCurrentEarnings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentEarnings.Click
        'Displays check winnings form
        frmCheckWinnings.Show()
        Me.Hide()
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        'the following questions answer is A so if button a is clicked
        If lblQuestion.Text = q1 Or lblQuestion.Text = q3 Or lblQuestion.Text = q7 Or lblQuestion.Text = q8 Then
            MessageBox.Show("Correct")
            'calculates how much the player has won 
            If lbl1.ForeColor = Color.Yellow Then
                totalEarnings = 100
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 200
            ElseIf lbl3.ForeColor = Color.Yellow Then
                totalEarnings = 500
            ElseIf lbl4.ForeColor = Color.Yellow Then
                totalEarnings = 1000
                chequeAmount = 1000
                'calculates how much the player will win if they get the next question wrong 
                frmWinnings.lblCash.Text = "One Thousand Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl5.ForeColor = Color.Yellow Then
                totalEarnings = 2000
            ElseIf lbl6.ForeColor = Color.Yellow Then
                totalEarnings = 4000
            ElseIf lbl7.ForeColor = Color.Yellow Then
                totalEarnings = 8000
            ElseIf lbl8.ForeColor = Color.Yellow Then
                totalEarnings = 16000
            ElseIf lbl9.ForeColor = Color.Yellow Then
                totalEarnings = 32000
                chequeAmount = 32000
                frmWinnings.lblCash.Text = "Thirty-Two Thousand"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl10.ForeColor = Color.Yellow Then
                totalEarnings = 64000
            ElseIf lbl11.ForeColor = Color.Yellow Then
                totalEarnings = 125000
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 250000
            ElseIf lbl13.ForeColor = Color.Yellow Then
                totalEarnings = 500000
            ElseIf lbl14.ForeColor = Color.Yellow Then
                totalEarnings = 1000000
                chequeAmount = 100000
                'Opens the winnings form because million dollar question was answered
                frmWinnings.lblCash.Text = "One Million Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
                lbl14.ForeColor = Color.Yellow
                lbl13.ForeColor = Color.White
                Me.Hide()
                frmWinnings.Show()
            End If
            'The rest is if the question is a question that answer is not A, the message box will appear saying the correct answer and 
            'either the cheque form will show up or form loser is you won nothing
        ElseIf lblQuestion.Text = q10 Or lblQuestion.Text = qStart Then
            MessageBox.Show("Incorrect, the correct answer was " & btnB.Text)

            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q2 Or lblQuestion.Text = q4 Or lblQuestion.Text = q6 Or lblQuestion.Text = q11 Or lblQuestion.Text = q14 Then
            MessageBox.Show("Incorrect, the correct answer was C " & btnC.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q5 Or lblQuestion.Text = q9 Or lblQuestion.Text = q12 Or lblQuestion.Text = q13 Then
            MessageBox.Show("Incorrect, the correct answer was D " & btnD.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        End If

        'makes the check winnings page display how much the player has won 
        frmCheckWinnings.lblCurrentWinnings.Text = totalEarnings


        'disables a bunch of buttons and compents, makes certain labels non visible 
        Timer1.Enabled = False

        lbltimer.Text = 30
        lbltimer.Visible = False

        timerCount = 30

        btnCurrentEarnings.Visible = True

        btn5050.Visible = False
        btnPollAudience.Visible = False
        btnPhoneFriend.Visible = False

        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False

        lblA.Visible = False
        lblB.Visible = False
        lblC.Visible = False
        lblD.Visible = False

        btnNext.Visible = False

        'hides help forms (if they were opened) 
        frmPhoneFriend.Hide()
        frmPollAudience.Hide()

        'displays button yes and no asking if the player wants to continue playing or take the money and run
        btnYes.Visible = True
        btnNo.Visible = True
        lblQuestion.Text = "Go Home With " & "$" & totalEarnings & "? Or Continue?"



        ''''''''''THE CODE IS REPEATED FOR BUTTONS B - D WITH THE ONLY THING CHANGING IS IF THE ANSWER IS CORRECT ANSWER'''''''''

        

    End Sub
    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        '''''''COMMENTS FOUND ON btnA_Click'''''''''''

        If lblQuestion.Text = q1 Or lblQuestion.Text = q3 Or lblQuestion.Text = q7 Or lblQuestion.Text = q8 Then
            MessageBox.Show("Incorrect, the correct answer was A " & btnA.Text)

            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q10 Or lblQuestion.Text = qStart Then
            MessageBox.Show("Correct")

            If lbl1.ForeColor = Color.Yellow Then
                totalEarnings = 100
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 200
            ElseIf lbl3.ForeColor = Color.Yellow Then
                totalEarnings = 500
            ElseIf lbl4.ForeColor = Color.Yellow Then
                totalEarnings = 1000
                chequeAmount = 1000
                frmWinnings.lblCash.Text = "One Thousand Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl5.ForeColor = Color.Yellow Then
                totalEarnings = 2000
            ElseIf lbl6.ForeColor = Color.Yellow Then
                totalEarnings = 4000
            ElseIf lbl7.ForeColor = Color.Yellow Then
                totalEarnings = 8000
            ElseIf lbl8.ForeColor = Color.Yellow Then
                totalEarnings = 16000
            ElseIf lbl9.ForeColor = Color.Yellow Then
                totalEarnings = 32000
                chequeAmount = 32000
                frmWinnings.lblCash.Text = "Thirty-Two Thousand"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl10.ForeColor = Color.Yellow Then
                totalEarnings = 64000
            ElseIf lbl11.ForeColor = Color.Yellow Then
                totalEarnings = 125000
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 250000
            ElseIf lbl13.ForeColor = Color.Yellow Then
                totalEarnings = 500000
            ElseIf lbl14.ForeColor = Color.Yellow Then
                totalEarnings = 1000000
                chequeAmount = 100000
                frmWinnings.lblCash.Text = "One Million Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
                lbl14.ForeColor = Color.Yellow
                lbl13.ForeColor = Color.Teal
                Me.Hide()
                frmWinnings.Show()
            End If
        ElseIf lblQuestion.Text = q2 Or lblQuestion.Text = q4 Or lblQuestion.Text = q6 Or lblQuestion.Text = q11 Or lblQuestion.Text = q14 Then
            MessageBox.Show("Incorrect, the correct answer was C " & btnC.Text)

            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q5 Or lblQuestion.Text = q9 Or lblQuestion.Text = q12 Or lblQuestion.Text = q13 Then
            MessageBox.Show("Incorrect, the correct answer was D " & btnD.Text)

            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        End If


        frmCheckWinnings.lblCurrentWinnings.Text = totalEarnings

        Timer1.Enabled = False

        lbltimer.Text = 30
        lbltimer.Visible = False

        timerCount = 30

        btnCurrentEarnings.Visible = True

        btn5050.Visible = False
        btnPollAudience.Visible = False
        btnPhoneFriend.Visible = False

        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False

        lblA.Visible = False
        lblB.Visible = False
        lblC.Visible = False
        lblD.Visible = False

        btnNext.Visible = False


        btnYes.Visible = True
        btnNo.Visible = True
        lblQuestion.Text = "Go Home With " & "$" & totalEarnings & "? Or Continue?"


        frmPhoneFriend.Hide()
        frmPollAudience.Hide()
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        '''''''COMMENTS FOUND ON btnA_Click'''''''''''

        If lblQuestion.Text = q1 Or lblQuestion.Text = q3 Or lblQuestion.Text = q7 Or lblQuestion.Text = q8 Then
            MessageBox.Show("Incorrect, the correct answer was A " & btnA.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q10 Or lblQuestion.Text = qStart Then
            MessageBox.Show("Incorrect, the correct answer was B " & btnB.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q2 Or lblQuestion.Text = q4 Or lblQuestion.Text = q6 Or lblQuestion.Text = q11 Or lblQuestion.Text = q14 Then
            MessageBox.Show("Correct")

            If lbl1.ForeColor = Color.Yellow Then
                totalEarnings = 100
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 200
            ElseIf lbl3.ForeColor = Color.Yellow Then
                totalEarnings = 500
            ElseIf lbl4.ForeColor = Color.Yellow Then
                totalEarnings = 1000
                chequeAmount = 1000
                frmWinnings.lblCash.Text = "One Thousand Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl5.ForeColor = Color.Yellow Then
                totalEarnings = 2000
            ElseIf lbl6.ForeColor = Color.Yellow Then
                totalEarnings = 4000
            ElseIf lbl7.ForeColor = Color.Yellow Then
                totalEarnings = 8000
            ElseIf lbl8.ForeColor = Color.Yellow Then
                totalEarnings = 16000
            ElseIf lbl9.ForeColor = Color.Yellow Then
                totalEarnings = 32000
                chequeAmount = 32000
                frmWinnings.lblCash.Text = "Thirty-Two Thousand"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl10.ForeColor = Color.Yellow Then
                totalEarnings = 64000
            ElseIf lbl11.ForeColor = Color.Yellow Then
                totalEarnings = 125000
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 250000
            ElseIf lbl13.ForeColor = Color.Yellow Then
                totalEarnings = 500000
            ElseIf lbl14.ForeColor = Color.Yellow Then
                totalEarnings = 1000000
                chequeAmount = 100000
                frmWinnings.lblCash.Text = "One Million Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
                lbl14.ForeColor = Color.Yellow
                lbl13.ForeColor = Color.Teal
                Me.Hide()
                frmWinnings.Show()
            End If
        ElseIf lblQuestion.Text = q5 Or lblQuestion.Text = q9 Or lblQuestion.Text = q12 Or lblQuestion.Text = q13 Then
            MessageBox.Show("Incorrect, the correct answer was D " & btnD.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        End If

        frmCheckWinnings.lblCurrentWinnings.Text = totalEarnings

        Timer1.Enabled = False

        lbltimer.Text = 30
        lbltimer.Visible = False

        timerCount = 30

        btnCurrentEarnings.Visible = True

        btn5050.Visible = False
        btnPollAudience.Visible = False
        btnPhoneFriend.Visible = False

        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False

        lblA.Visible = False
        lblB.Visible = False
        lblC.Visible = False
        lblD.Visible = False

        btnNext.Visible = False


        btnYes.Visible = True
        btnNo.Visible = True
        lblQuestion.Text = "Go Home With " & "$" & totalEarnings & "? Or Continue?"

        frmPhoneFriend.Hide()
        frmPollAudience.Hide()
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        '''''''COMMENTS FOUND ON btnA_Click'''''''''''

        If lblQuestion.Text = q1 Or lblQuestion.Text = q3 Or lblQuestion.Text = q7 Or lblQuestion.Text = q8 Then
            MessageBox.Show("Incorrect, the correct answer was A " & btnA.Text)
            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q10 Or lblQuestion.Text = qStart Then
            MessageBox.Show("Incorrect, the correct answer was B " & btnB.Text)


            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q2 Or lblQuestion.Text = q4 Or lblQuestion.Text = q6 Or lblQuestion.Text = q11 Or lblQuestion.Text = q14 Then
            MessageBox.Show("Incorrect, the correct answer was C " & btnC.Text)
            If totalEarnings < 1000 Then
                MessageBox.Show("Nice Try")
                frmLoser.Show()
            Else
                frmWinnings.Show()
            End If

            Me.Hide()
        ElseIf lblQuestion.Text = q5 Or lblQuestion.Text = q9 Or lblQuestion.Text = q12 Or lblQuestion.Text = q13 Then
            MessageBox.Show("Correct")

            If lbl1.ForeColor = Color.Yellow Then
                totalEarnings = 100
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 200
            ElseIf lbl3.ForeColor = Color.Yellow Then
                totalEarnings = 500
            ElseIf lbl4.ForeColor = Color.Yellow Then
                totalEarnings = 1000
                chequeAmount = 1000
                frmWinnings.lblCash.Text = "One Thousand Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl5.ForeColor = Color.Yellow Then
                totalEarnings = 2000
            ElseIf lbl6.ForeColor = Color.Yellow Then
                totalEarnings = 4000
            ElseIf lbl7.ForeColor = Color.Yellow Then
                totalEarnings = 8000
            ElseIf lbl8.ForeColor = Color.Yellow Then
                totalEarnings = 16000
            ElseIf lbl9.ForeColor = Color.Yellow Then
                totalEarnings = 32000
                chequeAmount = 32000
                frmWinnings.lblCash.Text = "Thirty-Two Thousand"
                frmWinnings.lblDollars.Text = chequeAmount
            ElseIf lbl10.ForeColor = Color.Yellow Then
                totalEarnings = 64000
            ElseIf lbl11.ForeColor = Color.Yellow Then
                totalEarnings = 125000
            ElseIf lbl2.ForeColor = Color.Yellow Then
                totalEarnings = 250000
            ElseIf lbl13.ForeColor = Color.Yellow Then
                totalEarnings = 500000
            ElseIf lbl14.ForeColor = Color.Yellow Then
                totalEarnings = 1000000
                chequeAmount = 100000
                frmWinnings.lblCash.Text = "One Million Dollars"
                frmWinnings.lblDollars.Text = chequeAmount
                lbl14.ForeColor = Color.Yellow
                lbl13.ForeColor = Color.Teal
                Me.Hide()
                frmWinnings.Show()
            End If
        End If

        frmCheckWinnings.lblCurrentWinnings.Text = totalEarnings

        Timer1.Enabled = False

        lbltimer.Text = 30
        lbltimer.Visible = False

        timerCount = 30

        btnCurrentEarnings.Visible = True

        btn5050.Visible = False
        btnPollAudience.Visible = False
        btnPhoneFriend.Visible = False

        btnA.Visible = False
        btnB.Visible = False
        btnC.Visible = False
        btnD.Visible = False

        lblA.Visible = False
        lblB.Visible = False
        lblC.Visible = False
        lblD.Visible = False

        btnNext.Visible = False


        btnYes.Visible = True
        btnNo.Visible = True
        lblQuestion.Text = "Go Home With " & "$" & totalEarnings & "? Or continue?"


        frmPhoneFriend.Hide()
        frmPollAudience.Hide()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        
        'enables and makes componets visible 
        btnPollAudience.Enabled = True
        btnPhoneFriend.Enabled = True
        btn5050.Enabled = True

        btnPollAudience.Visible = True
        btnPhoneFriend.Visible = True
        btn5050.Visible = True

        btnCurrentEarnings.Visible = False

        lblA.Visible = True
        lblB.Visible = True
        lblC.Visible = True
        lblD.Visible = True

        btnA.Visible = True
        btnB.Visible = True
        btnC.Visible = True
        btnD.Visible = True

        Timer1.Enabled = True
        lbltimer.Visible = True
        timerCount = 30

        lblQuestion.Visible = True

        With btnA
            .Enabled = True
            .Visible = True
            .BackColor = Color.DarkGray
        End With
        With btnB
            .Enabled = True
            .Visible = True
            .BackColor = Color.DarkGray
        End With
        With btnC
            .Enabled = True
            .Visible = True
            .BackColor = Color.DarkGray
        End With
        With btnD
            .Enabled = True
            .Visible = True
            .BackColor = Color.DarkGray
        End With

        btnNext.Visible = False


        Dim randomNumber As Integer
        'Sets questions up in an array 
        questions(0, 0) = q1
        questions(1, 0) = q2
        questions(2, 0) = q3
        questions(3, 0) = q4
        questions(4, 0) = q5
        questions(5, 0) = q6
        questions(6, 0) = q7
        questions(7, 0) = q8
        questions(8, 0) = q9
        questions(9, 0) = q10
        questions(10, 0) = q11
        questions(11, 0) = q12
        questions(12, 0) = q13
        questions(13, 0) = q14

        'randomizes a number until it comes up with a number that has not been used in #,2
        Do
            Randomize()
            randomNumber = Rnd() * 13
        Loop Until questions(randomNumber, 1) <> "Used"
        'makes the random number used in #,2 so the question cannot be repeated
        questions(randomNumber, 1) = "Used"
        'displays question
        lblQuestion.Text = (questions(randomNumber, 0))

        'sets up choices in the buttons 

        If lblQuestion.Text = q1 Then
            btnA.Text = "4"
            btnB.Text = "2"
            btnC.Text = "3"
            btnD.Text = "5"
        End If

        If lblQuestion.Text = q2 Then
            btnA.Text = "5"
            btnB.Text = "10"
            btnC.Text = "15"
            btnD.Text = "20"
        End If

        If lblQuestion.Text = q3 Then
            btnA.Text = "Willow Typeface"
            btnB.Text = "Comic Sans"
            btnC.Text = "AHS Font"
            btnD.Text = "New Times Roman"
        End If

        If lblQuestion.Text = q4 Then
            btnA.Text = "Mackenzie Van Vliet"
            btnB.Text = "Miley Cyrus"
            btnC.Text = "Adam Levine"
            btnD.Text = "Hilary Duff"
        End If

        If lblQuestion.Text = q5 Then
            btnA.Text = "Circles"
            btnB.Text = "Triangles"
            btnC.Text = "Paintings of her home"
            btnD.Text = "Ailens"
        End If

        If lblQuestion.Text = q6 Then
            btnA.Text = "5"
            btnB.Text = "1"
            btnC.Text = "2"
            btnD.Text = "0"
        End If

        If lblQuestion.Text = q7 Then
            btnA.Text = "Lana Bananas"
            btnB.Text = "Lazy"
            btnC.Text = "Crazy"
            btnD.Text = "Sweetie Pie"
        End If

        If lblQuestion.Text = q8 Then
            btnA.Text = "Superstar"
            btnB.Text = "Gardener"
            btnC.Text = "Teacher"
            btnD.Text = "College Student"
        End If

        If lblQuestion.Text = q9 Then
            btnA.Text = "Britney Spears"
            btnB.Text = "Elvis"
            btnC.Text = "Mackenzie Van Vliet"
            btnD.Text = "Stevie Nicks"
        End If

        If lblQuestion.Text = q10 Then
            btnA.Text = "Salt Lake City,UT"
            btnB.Text = "Jupiter,FL"
            btnC.Text = "Brampton,ON"
            btnD.Text = "Welland,ON"
        End If

        If lblQuestion.Text = q11 Then
            btnA.Text = "Fiona Goode"
            btnB.Text = "Zoe Benson"
            btnC.Text = "Cordelia Foxx"
            btnD.Text = "Madison Montgomery"
        End If

        If lblQuestion.Text = q12 Then
            btnA.Text = "Alma and Kit"
            btnB.Text = "Tate and Violet"
            btnC.Text = "Kyle and Misty"
            btnD.Text = "Jimmy and Maggie"
        End If

        If lblQuestion.Text = q13 Then
            btnA.Text = "Stevie Nicks"
            btnB.Text = "Rihanna"
            btnC.Text = "Kanye West"
            btnD.Text = "Lady Gaga"
        End If

        If lblQuestion.Text = q14 Then
            btnA.Text = "Fix You"
            btnB.Text = "Blue Velvet"
            btnC.Text = "Heroes"
            btnD.Text = "Believe"
        End If

        'makes the value of the question graphic on the left side move up displaying the value of the question 

        If lbl1.ForeColor = Color.Yellow Then
            lbl2.ForeColor = Color.Yellow
            lbl1.ForeColor = Color.Teal

        ElseIf lbl2.ForeColor = Color.Yellow Then
            lbl3.ForeColor = Color.Yellow
            lbl2.ForeColor = Color.Teal

        ElseIf lbl3.ForeColor = Color.Yellow Then
            lbl4.ForeColor = Color.Yellow
            lbl3.ForeColor = Color.Teal

        ElseIf lbl4.ForeColor = Color.Yellow Then
            lbl5.ForeColor = Color.Yellow
            lbl4.ForeColor = Color.Teal

        ElseIf lbl5.ForeColor = Color.Yellow Then
            lbl6.ForeColor = Color.Yellow
            lbl5.ForeColor = Color.Teal

        ElseIf lbl6.ForeColor = Color.Yellow Then
            lbl7.ForeColor = Color.Yellow
            lbl6.ForeColor = Color.Teal

        ElseIf lbl7.ForeColor = Color.Yellow Then
            lbl8.ForeColor = Color.Yellow
            lbl7.ForeColor = Color.Teal

        ElseIf lbl8.ForeColor = Color.Yellow Then
            lbl9.ForeColor = Color.Yellow
            lbl8.ForeColor = Color.Teal

        ElseIf lbl9.ForeColor = Color.Yellow Then
            lbl10.ForeColor = Color.Yellow
            lbl9.ForeColor = Color.Teal

        ElseIf lbl10.ForeColor = Color.Yellow Then
            lbl11.ForeColor = Color.Yellow
            lbl10.ForeColor = Color.Teal

        ElseIf lbl11.ForeColor = Color.Yellow Then
            lbl12.ForeColor = Color.Yellow
            lbl11.ForeColor = Color.Teal

        ElseIf lbl12.ForeColor = Color.Yellow Then
            lbl13.ForeColor = Color.Yellow
            lbl12.ForeColor = Color.Teal

        ElseIf lbl13.ForeColor = Color.Yellow Then
            lbl14.ForeColor = Color.Yellow
            lbl13.ForeColor = Color.Teal
        End If




    End Sub

    Private Sub btn5050_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5050.Click
        'disables other help options
        btn5050.Visible = False
        btnPollAudience.Enabled = False
        btnPhoneFriend.Enabled = False

        Dim A As Integer = 1
        Dim B As Integer = 2
        Dim C As Integer = 3
        Dim D As Integer = 4
        Dim answer As Integer
        Dim hide1 As Integer
        Dim hide2 As Integer

        If lblQuestion.Text = q1 Or lblQuestion.Text = q3 Or lblQuestion.Text = q7 Or lblQuestion.Text = q8 Then
            'becasue it is above questions the answer cannot be removed
            answer = A

            'comes up with 2 different numbers, which equal buttons, to hide that is not the answer 
            Do
                hide1 = Int(4 * Rnd() + 1)
                hide2 = Int(4 * Rnd() + 1)
            Loop Until hide1 <> answer And hide2 <> answer And hide1 <> hide2
            If hide1 = A Or hide2 = A Then
                btnA.Visible = False
                lblA.Visible = False

            End If
            If hide1 = B Or hide2 = B Then
                btnB.Visible = False
                lblB.Visible = False
            End If
            If hide1 = C Or hide2 = C Then
                btnC.Visible = False
                btnC.Visible = False
            End If
            If hide1 = D Or hide2 = D Then
                btnD.Visible = False
                lblD.Visible = False
            End If
        End If

        '''''''''LOOK AT ABOVE COMMENTS FOR FOLLOW'''''''''''

        If lblQuestion.Text = q10 Or lblQuestion.Text = qStart Then
            answer = B
            Do
                hide1 = Int(4 * Rnd() + 1)
                hide2 = Int(4 * Rnd() + 1)
            Loop Until hide1 <> answer And hide2 <> answer And hide1 <> hide2
            If hide1 = A Or hide2 = A Then
                btnA.Visible = False
                lblA.Visible = False
            End If
            If hide1 = B Or hide2 = B Then
                btnB.Visible = False
                lblB.Visible = False
            End If
            If hide1 = C Or hide2 = C Then
                btnC.Visible = False
                lblC.Visible = False
            End If
            If hide1 = D Or hide2 = D Then
                btnD.Visible = False
                lblD.Visible = False
            End If
        End If

        If lblQuestion.Text = q2 Or lblQuestion.Text = q4 Or lblQuestion.Text = q6 Or lblQuestion.Text = q11 Or lblQuestion.Text = q14 Then
            answer = C
            Do
                hide1 = Int(4 * Rnd() + 1)
                hide2 = Int(4 * Rnd() + 1)
            Loop Until hide1 <> answer And hide2 <> answer And hide1 <> hide2
            If hide1 = A Or hide2 = A Then
                btnA.Visible = False
                lblA.Visible = False
            End If
            If hide1 = B Or hide2 = B Then
                btnB.Visible = False
                lblB.Visible = False
            End If
            If hide1 = C Or hide2 = C Then
                btnC.Visible = False
                lblC.Visible = False
            End If
            If hide1 = D Or hide2 = D Then
                btnD.Visible = False
                lblD.Visible = False
            End If
        End If

        If lblQuestion.Text = q5 Or lblQuestion.Text = q9 Or lblQuestion.Text = q12 Or lblQuestion.Text = q13 Then
            answer = D
            Do
                hide1 = Int(4 * Rnd() + 1)
                hide2 = Int(4 * Rnd() + 1)
            Loop Until hide1 <> D And hide2 <> D And hide1 <> hide2
            If hide1 = A Or hide2 = A Then
                btnA.Visible = False
                lblA.Visible = False
            End If
            If hide1 = B Or hide2 = B Then
                btnB.Visible = False
                lblB.Visible = False
            End If
            If hide1 = C Or hide2 = C Then
                btnC.Visible = False
                lblC.Visible = False
            End If
            If hide1 = D Or hide2 = D Then
                btnD.Visible = False
                lblD.Visible = False
            End If
        End If
    End Sub


    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        'makes componets visible and not visible
        btnNext.Visible = True
        btnCurrentEarnings.Visible = True
        btnNo.Visible = False
        btnYes.Visible = False
        lblQuestion.Visible = False
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        'if button yes is clicked the player goes home with their winnings

        Dim winningsWritten As String

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

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class