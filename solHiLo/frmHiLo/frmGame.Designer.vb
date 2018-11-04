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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picbox1 = New System.Windows.Forms.PictureBox()
        Me.picbox2 = New System.Windows.Forms.PictureBox()
        Me.lblScoreLabel = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavigationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(684, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(228, 352)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(75, 23)
        Me.btnHigh.TabIndex = 6
        Me.btnHigh.Text = "Higher!"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(361, 352)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(75, 23)
        Me.btnLow.TabIndex = 7
        Me.btnLow.Text = "Lower!"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(309, 415)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 18)
        Me.lblScore.TabIndex = 8
        '
        'picbox1
        '
        Me.picbox1.Location = New System.Drawing.Point(133, 95)
        Me.picbox1.Name = "picbox1"
        Me.picbox1.Size = New System.Drawing.Size(170, 213)
        Me.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox1.TabIndex = 5
        Me.picbox1.TabStop = False
        '
        'picbox2
        '
        Me.picbox2.Location = New System.Drawing.Point(361, 95)
        Me.picbox2.Name = "picbox2"
        Me.picbox2.Size = New System.Drawing.Size(170, 213)
        Me.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox2.TabIndex = 4
        Me.picbox2.TabStop = False
        '
        'lblScoreLabel
        '
        Me.lblScoreLabel.AutoSize = True
        Me.lblScoreLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreLabel.ForeColor = System.Drawing.Color.White
        Me.lblScoreLabel.Location = New System.Drawing.Point(245, 415)
        Me.lblScoreLabel.Name = "lblScoreLabel"
        Me.lblScoreLabel.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreLabel.TabIndex = 9
        Me.lblScoreLabel.Text = "Score:"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.lblScoreLabel)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.picbox1)
        Me.Controls.Add(Me.picbox2)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hi Lo"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picbox2 As PictureBox
    Friend WithEvents picbox1 As PictureBox
    Friend WithEvents btnHigh As Button
    Friend WithEvents btnLow As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblScoreLabel As Label
End Class
