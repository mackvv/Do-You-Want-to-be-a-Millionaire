<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckWinnings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrentWinnings = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GOHOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(48, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(576, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Winnings"
        '
        'lblCurrentWinnings
        '
        Me.lblCurrentWinnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWinnings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCurrentWinnings.Location = New System.Drawing.Point(0, 141)
        Me.lblCurrentWinnings.Name = "lblCurrentWinnings"
        Me.lblCurrentWinnings.Size = New System.Drawing.Size(671, 108)
        Me.lblCurrentWinnings.TabIndex = 1
        Me.lblCurrentWinnings.Text = "$0"
        Me.lblCurrentWinnings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(551, 214)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 42)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GOHOMEToolStripMenuItem, Me.BACKToolStripMenuItem})
        Me.ProgramToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'GOHOMEToolStripMenuItem
        '
        Me.GOHOMEToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.GOHOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GOHOMEToolStripMenuItem.Name = "GOHOMEToolStripMenuItem"
        Me.GOHOMEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GOHOMEToolStripMenuItem.Text = "Go Home"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.BACKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BACKToolStripMenuItem.Text = "Back"
        '
        'frmCheckWinnings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(671, 268)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCurrentWinnings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCheckWinnings"
        Me.Text = "Check Winnings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentWinnings As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GOHOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
