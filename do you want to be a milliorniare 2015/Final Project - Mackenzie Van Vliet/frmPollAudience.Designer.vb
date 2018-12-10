<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPollAudience
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
        Me.P1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pbA = New System.Windows.Forms.ProgressBar()
        Me.pbB = New System.Windows.Forms.ProgressBar()
        Me.pbC = New System.Windows.Forms.ProgressBar()
        Me.pbD = New System.Windows.Forms.ProgressBar()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.btnPoll = New System.Windows.Forms.Button()
        Me.lblAP = New System.Windows.Forms.Label()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblDP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.AutoSize = True
        Me.P1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.P1.Location = New System.Drawing.Point(118, 17)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(307, 40)
        Me.P1.TabIndex = 0
        Me.P1.Text = "POLL AUDIENCE"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(339, 401)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 46)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'pbA
        '
        Me.pbA.ForeColor = System.Drawing.Color.Teal
        Me.pbA.Location = New System.Drawing.Point(224, 140)
        Me.pbA.Name = "pbA"
        Me.pbA.Size = New System.Drawing.Size(100, 23)
        Me.pbA.TabIndex = 23
        Me.pbA.Visible = False
        '
        'pbB
        '
        Me.pbB.ForeColor = System.Drawing.Color.Teal
        Me.pbB.Location = New System.Drawing.Point(224, 193)
        Me.pbB.Name = "pbB"
        Me.pbB.Size = New System.Drawing.Size(100, 23)
        Me.pbB.TabIndex = 24
        Me.pbB.Visible = False
        '
        'pbC
        '
        Me.pbC.ForeColor = System.Drawing.Color.Teal
        Me.pbC.Location = New System.Drawing.Point(224, 245)
        Me.pbC.Name = "pbC"
        Me.pbC.Size = New System.Drawing.Size(100, 23)
        Me.pbC.TabIndex = 25
        Me.pbC.Visible = False
        '
        'pbD
        '
        Me.pbD.ForeColor = System.Drawing.Color.Teal
        Me.pbD.Location = New System.Drawing.Point(224, 292)
        Me.pbD.Name = "pbD"
        Me.pbD.Size = New System.Drawing.Size(100, 23)
        Me.pbD.TabIndex = 26
        Me.pbD.Visible = False
        '
        'lblB
        '
        Me.lblB.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblB.Location = New System.Drawing.Point(92, 196)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(131, 26)
        Me.lblB.TabIndex = 27
        Me.lblB.Text = "btnB text"
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblB.Visible = False
        '
        'lblC
        '
        Me.lblC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblC.Location = New System.Drawing.Point(92, 248)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(131, 29)
        Me.lblC.TabIndex = 28
        Me.lblC.Text = "btnC text"
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblC.Visible = False
        '
        'lblD
        '
        Me.lblD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblD.Location = New System.Drawing.Point(92, 295)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(132, 24)
        Me.lblD.TabIndex = 29
        Me.lblD.Text = "btnD text"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblD.Visible = False
        '
        'lblA
        '
        Me.lblA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblA.Location = New System.Drawing.Point(92, 143)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(131, 31)
        Me.lblA.TabIndex = 30
        Me.lblA.Text = "btnA text"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblA.Visible = False
        '
        'btnPoll
        '
        Me.btnPoll.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPoll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPoll.Location = New System.Drawing.Point(194, 60)
        Me.btnPoll.Name = "btnPoll"
        Me.btnPoll.Size = New System.Drawing.Size(93, 46)
        Me.btnPoll.TabIndex = 31
        Me.btnPoll.Text = "POLL"
        Me.btnPoll.UseVisualStyleBackColor = False
        '
        'lblAP
        '
        Me.lblAP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAP.Location = New System.Drawing.Point(336, 140)
        Me.lblAP.Name = "lblAP"
        Me.lblAP.Size = New System.Drawing.Size(174, 34)
        Me.lblAP.TabIndex = 32
        Me.lblAP.Text = "btnA %"
        Me.lblAP.Visible = False
        '
        'lblBP
        '
        Me.lblBP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBP.Location = New System.Drawing.Point(336, 203)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Size = New System.Drawing.Size(160, 31)
        Me.lblBP.TabIndex = 33
        Me.lblBP.Text = "btnB %"
        Me.lblBP.Visible = False
        '
        'lblCP
        '
        Me.lblCP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCP.Location = New System.Drawing.Point(336, 255)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(160, 13)
        Me.lblCP.TabIndex = 34
        Me.lblCP.Text = "btnC %"
        Me.lblCP.Visible = False
        '
        'lblDP
        '
        Me.lblDP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDP.Location = New System.Drawing.Point(336, 302)
        Me.lblDP.Name = "lblDP"
        Me.lblDP.Size = New System.Drawing.Size(152, 17)
        Me.lblDP.TabIndex = 35
        Me.lblDP.Text = "btnD %"
        Me.lblDP.Visible = False
        '
        'frmPollAudience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(553, 485)
        Me.Controls.Add(Me.lblDP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblBP)
        Me.Controls.Add(Me.lblAP)
        Me.Controls.Add(Me.btnPoll)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.pbD)
        Me.Controls.Add(Me.pbC)
        Me.Controls.Add(Me.pbB)
        Me.Controls.Add(Me.pbA)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.P1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPollAudience"
        Me.Text = "frmPollAudience"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pbA As System.Windows.Forms.ProgressBar
    Friend WithEvents pbB As System.Windows.Forms.ProgressBar
    Friend WithEvents pbC As System.Windows.Forms.ProgressBar
    Friend WithEvents pbD As System.Windows.Forms.ProgressBar
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents btnPoll As System.Windows.Forms.Button
    Friend WithEvents lblAP As System.Windows.Forms.Label
    Friend WithEvents lblBP As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblDP As System.Windows.Forms.Label
End Class
