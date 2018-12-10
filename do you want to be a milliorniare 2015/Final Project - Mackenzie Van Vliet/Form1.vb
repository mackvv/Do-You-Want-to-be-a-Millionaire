Public Class frmStartUp
    Public firstname As String
    Public lastname As String
    Public name As String
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        firstname = txtFirstName.Text
        lastname = txtLastName.Text
        name = ""

        'gets users name and prompts for their name via an message box if they do not answer
        If txtFirstName.Text = "" Then
            MessageBox.Show("Enter first name")
        Else
            firstname = txtFirstName.Text
        End If

        If txtLastName.Text = "" Then
            MessageBox.Show("Enter last name")
        Else
            lastname = txtLastName.Text
        End If

        If firstname = "" Or lastname = "" Then
            name = ""
        Else
            name = firstname & " " & lastname
            frmGame.Show()
            Me.Hide()
        End If

        'displays name on cheque and phoneaFriend form
        frmWinnings.lblName.Text = name
        frmPhoneFriend.name = name




    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'opens about form, hides current form
        frmAbout.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'opens help form, hides current form
        frmHelp.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'exits application
        MessageBox.Show("Goodbye")
        Application.Exit()

    End Sub

    Private Sub StartGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGameToolStripMenuItem.Click
        firstname = txtFirstName.Text
        lastname = txtLastName.Text
        name = ""

        'gets users name and prompts for their name via an message box if they do not answer
        If txtFirstName.Text = "" Then
            MessageBox.Show("Enter first name")
        Else
            firstname = txtFirstName.Text
        End If

        If txtLastName.Text = "" Then
            MessageBox.Show("Enter last name")
        Else
            lastname = txtLastName.Text
        End If

        If firstname = "" Or lastname = "" Then
            name = ""
        Else
            name = firstname & " " & lastname
            frmGame.Show()
            Me.Hide()
        End If

        'displays name on cheque and phoneaFriend form
        frmWinnings.lblName.Text = name
        frmPhoneFriend.name = name
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frmStartUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.American_Horror_Story, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
