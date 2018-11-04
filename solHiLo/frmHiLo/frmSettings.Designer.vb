<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.MainGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblSound = New System.Windows.Forms.Label()
        Me.comBckColour = New System.Windows.Forms.ComboBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.lblBackground = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
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
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.MainGameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainGameToolStripMenuItem
        '
        Me.MainGameToolStripMenuItem.Name = "MainGameToolStripMenuItem"
        Me.MainGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.MainGameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MainGameToolStripMenuItem.Text = "Main Game"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(315, 53)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(76, 18)
        Me.lblSettings.TabIndex = 1
        Me.lblSettings.Text = "Settings"
        '
        'lblSound
        '
        Me.lblSound.AutoSize = True
        Me.lblSound.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSound.ForeColor = System.Drawing.Color.White
        Me.lblSound.Location = New System.Drawing.Point(275, 139)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(55, 18)
        Me.lblSound.TabIndex = 2
        Me.lblSound.Text = "Sound"
        '
        'comBckColour
        '
        Me.comBckColour.FormattingEnabled = True
        Me.comBckColour.Items.AddRange(New Object() {"Green", "Blue", "Red"})
        Me.comBckColour.Location = New System.Drawing.Point(278, 275)
        Me.comBckColour.Name = "comBckColour"
        Me.comBckColour.Size = New System.Drawing.Size(147, 21)
        Me.comBckColour.TabIndex = 4
        Me.comBckColour.Text = "Green"
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Checked = True
        Me.chkSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSound.Location = New System.Drawing.Point(410, 143)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(15, 14)
        Me.chkSound.TabIndex = 5
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'lblBackground
        '
        Me.lblBackground.AutoSize = True
        Me.lblBackground.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackground.ForeColor = System.Drawing.Color.White
        Me.lblBackground.Location = New System.Drawing.Point(275, 229)
        Me.lblBackground.Name = "lblBackground"
        Me.lblBackground.Size = New System.Drawing.Size(150, 18)
        Me.lblBackground.TabIndex = 6
        Me.lblBackground.Text = "Background Colour"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.lblBackground)
        Me.Controls.Add(Me.chkSound)
        Me.Controls.Add(Me.comBckColour)
        Me.Controls.Add(Me.lblSound)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblSound As Label
    Friend WithEvents comBckColour As ComboBox
    Friend WithEvents chkSound As CheckBox
    Friend WithEvents lblBackground As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
