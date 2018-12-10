<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.btnCurrentEarnings = New System.Windows.Forms.Button()
        Me.btnPollAudience = New System.Windows.Forms.Button()
        Me.btn5050 = New System.Windows.Forms.Button()
        Me.btnPhoneFriend = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltimer = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(196, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(666, 86)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(108, 42)
        Me.btnAbout.TabIndex = 8
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(14, 70)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(108, 42)
        Me.btnHelp.TabIndex = 9
        Me.btnHelp.Text = "HELP"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuestion.Location = New System.Drawing.Point(47, 216)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(693, 55)
        Me.lblQuestion.TabIndex = 10
        Me.lblQuestion.Text = "What is the first season of American Horror Story called?"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.ForeColor = System.Drawing.Color.Teal
        Me.lblP.Location = New System.Drawing.Point(803, 37)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(160, 32)
        Me.lblP.TabIndex = 16
        Me.lblP.Text = "EARNINGS"
        '
        'btnCurrentEarnings
        '
        Me.btnCurrentEarnings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCurrentEarnings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnCurrentEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurrentEarnings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentEarnings.Location = New System.Drawing.Point(831, 474)
        Me.btnCurrentEarnings.Name = "btnCurrentEarnings"
        Me.btnCurrentEarnings.Size = New System.Drawing.Size(157, 42)
        Me.btnCurrentEarnings.TabIndex = 17
        Me.btnCurrentEarnings.Text = "CURRENT EARNINGS"
        Me.btnCurrentEarnings.UseVisualStyleBackColor = False
        Me.btnCurrentEarnings.Visible = False
        '
        'btnPollAudience
        '
        Me.btnPollAudience.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPollAudience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnPollAudience.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPollAudience.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPollAudience.Location = New System.Drawing.Point(528, 474)
        Me.btnPollAudience.Name = "btnPollAudience"
        Me.btnPollAudience.Size = New System.Drawing.Size(108, 42)
        Me.btnPollAudience.TabIndex = 18
        Me.btnPollAudience.Text = "POLL AUDIENCE"
        Me.btnPollAudience.UseVisualStyleBackColor = False
        '
        'btn5050
        '
        Me.btn5050.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn5050.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btn5050.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5050.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5050.Location = New System.Drawing.Point(343, 474)
        Me.btn5050.Name = "btn5050"
        Me.btn5050.Size = New System.Drawing.Size(108, 42)
        Me.btn5050.TabIndex = 19
        Me.btn5050.Text = "50/50"
        Me.btn5050.UseVisualStyleBackColor = False
        '
        'btnPhoneFriend
        '
        Me.btnPhoneFriend.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPhoneFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnPhoneFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhoneFriend.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhoneFriend.Location = New System.Drawing.Point(157, 474)
        Me.btnPhoneFriend.Name = "btnPhoneFriend"
        Me.btnPhoneFriend.Size = New System.Drawing.Size(108, 42)
        Me.btnPhoneFriend.TabIndex = 20
        Me.btnPhoneFriend.Text = "PHONE FRIEND"
        Me.btnPhoneFriend.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(314, 307)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(108, 42)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.LightGray
        Me.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.Location = New System.Drawing.Point(217, 274)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(108, 42)
        Me.btnA.TabIndex = 23
        Me.btnA.Text = "Coven"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.LightGray
        Me.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(428, 274)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(108, 42)
        Me.btnB.TabIndex = 24
        Me.btnB.Text = "Murder House"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.LightGray
        Me.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(217, 363)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(108, 42)
        Me.btnC.TabIndex = 25
        Me.btnC.Text = "Asylum "
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.LightGray
        Me.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.Location = New System.Drawing.Point(428, 363)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(108, 42)
        Me.btnD.TabIndex = 26
        Me.btnD.Text = "Freak Show"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbltimer
        '
        Me.lbltimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltimer.Location = New System.Drawing.Point(338, 423)
        Me.lbltimer.Name = "lbltimer"
        Me.lbltimer.Size = New System.Drawing.Size(97, 23)
        Me.lbltimer.TabIndex = 27
        Me.lbltimer.Text = "Label1"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Yellow
        Me.lbl1.Location = New System.Drawing.Point(891, 419)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(69, 29)
        Me.lbl1.TabIndex = 28
        Me.lbl1.Text = "$100"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl2.Location = New System.Drawing.Point(891, 392)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(69, 29)
        Me.lbl2.TabIndex = 29
        Me.lbl2.Text = "$200"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl3.Location = New System.Drawing.Point(891, 366)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(69, 29)
        Me.lbl3.TabIndex = 30
        Me.lbl3.Text = "$500"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl4.Location = New System.Drawing.Point(875, 339)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(83, 29)
        Me.lbl4.TabIndex = 31
        Me.lbl4.Text = "$1000"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl5.Location = New System.Drawing.Point(875, 312)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(83, 29)
        Me.lbl5.TabIndex = 32
        Me.lbl5.Text = "$2000"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl6.Location = New System.Drawing.Point(875, 289)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(83, 29)
        Me.lbl6.TabIndex = 33
        Me.lbl6.Text = "$4000"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl7.Location = New System.Drawing.Point(875, 262)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(83, 29)
        Me.lbl7.TabIndex = 34
        Me.lbl7.Text = "$8000"
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl8.Location = New System.Drawing.Point(859, 235)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(97, 29)
        Me.lbl8.TabIndex = 35
        Me.lbl8.Text = "$16000"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl9.Location = New System.Drawing.Point(859, 209)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(97, 29)
        Me.lbl9.TabIndex = 36
        Me.lbl9.Text = "$32000"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl10.Location = New System.Drawing.Point(859, 182)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(97, 29)
        Me.lbl10.TabIndex = 37
        Me.lbl10.Text = "$64000"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl11.Location = New System.Drawing.Point(842, 155)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(111, 29)
        Me.lbl11.TabIndex = 38
        Me.lbl11.Text = "$125000"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl12.Location = New System.Drawing.Point(842, 128)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(111, 29)
        Me.lbl12.TabIndex = 39
        Me.lbl12.Text = "$250000"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl13.Location = New System.Drawing.Point(842, 102)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(111, 29)
        Me.lbl13.TabIndex = 40
        Me.lbl13.Text = "$500000"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl14.Location = New System.Drawing.Point(826, 75)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(125, 29)
        Me.lbl14.TabIndex = 41
        Me.lbl14.Text = "$1000000"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblA.Location = New System.Drawing.Point(170, 282)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(34, 25)
        Me.lblA.TabIndex = 42
        Me.lblA.Text = "A."
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblB.Location = New System.Drawing.Point(383, 282)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(34, 25)
        Me.lblB.TabIndex = 43
        Me.lblB.Text = "B."
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblC.Location = New System.Drawing.Point(169, 368)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(35, 25)
        Me.lblC.TabIndex = 44
        Me.lblC.Text = "C."
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblD.Location = New System.Drawing.Point(381, 370)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(35, 25)
        Me.lblD.TabIndex = 45
        Me.lblD.Text = "D."
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.LightGray
        Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(245, 322)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(108, 42)
        Me.btnYes.TabIndex = 46
        Me.btnYes.Text = "GO HOME"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.LightGray
        Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(406, 325)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(108, 42)
        Me.btnNo.TabIndex = 47
        Me.btnNo.Text = "CONTINUE"
        Me.btnNo.UseVisualStyleBackColor = False
        Me.btnNo.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1032, 24)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1032, 537)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbltimer)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPhoneFriend)
        Me.Controls.Add(Me.btn5050)
        Me.Controls.Add(Me.btnPollAudience)
        Me.Controls.Add(Me.btnCurrentEarnings)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents btnCurrentEarnings As System.Windows.Forms.Button
    Friend WithEvents btnPollAudience As System.Windows.Forms.Button
    Friend WithEvents btn5050 As System.Windows.Forms.Button
    Friend WithEvents btnPhoneFriend As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltimer As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
