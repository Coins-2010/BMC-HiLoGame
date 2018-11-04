<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.comHelp = New System.Windows.Forms.ComboBox()
        Me.lblHelpText = New System.Windows.Forms.Label()
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
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.MainGameToolStripMenuItem, Me.SettingsToolStripMenuItem})
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
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.White
        Me.lblHelp.Location = New System.Drawing.Point(313, 46)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(44, 18)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = "Help"
        '
        'comHelp
        '
        Me.comHelp.FormattingEnabled = True
        Me.comHelp.Items.AddRange(New Object() {"How do I play the Game?", "What are the cards ranked Lowest to Highest?", "How do I turn off the sound?", "Is there a way to change the Background Colour?"})
        Me.comHelp.Location = New System.Drawing.Point(130, 95)
        Me.comHelp.Name = "comHelp"
        Me.comHelp.Size = New System.Drawing.Size(410, 21)
        Me.comHelp.TabIndex = 3
        '
        'lblHelpText
        '
        Me.lblHelpText.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpText.ForeColor = System.Drawing.Color.White
        Me.lblHelpText.Location = New System.Drawing.Point(127, 166)
        Me.lblHelpText.Name = "lblHelpText"
        Me.lblHelpText.Size = New System.Drawing.Size(410, 233)
        Me.lblHelpText.TabIndex = 4
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.lblHelpText)
        Me.Controls.Add(Me.comHelp)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHelp As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents comHelp As ComboBox
    Friend WithEvents lblHelpText As Label
End Class
