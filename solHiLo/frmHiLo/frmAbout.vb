'=================================================
' Class : frmAbout
' Project : Assignment 2 Phase 2 EDP
' Version : 1.0
' Date : 10/05/2016
' Author : Matthew de Leeuwe
' Description : This is the main menu for the application this form shows the program version and allows the user to continue onto the game.
'=================================================
Public Class frmAbout
    '----------------------------------------------------------------------------------------
    ' Module: btnPlay_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for btnPlay button, This takes the user to the Main game screen.
    '----------------------------------------------------------------------------------------
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        frmGame.Show()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: ExitToolStripMenuItem_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for ExitToolStripMenuItem. This allows the user to exit the application.
    '----------------------------------------------------------------------------------------
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmSplash.Close()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: frmAbout_Load
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : On the form load this is the code that loads the game sound.
    '----------------------------------------------------------------------------------------
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyGlobals.myPlayer.PlayLooping()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: MainGameToolStripMenuItem_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for MainGameToolStripMenuItem. This allows the user to navigate to the Game Screen.
    '----------------------------------------------------------------------------------------
    Private Sub MainGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainGameToolStripMenuItem.Click
        Me.Hide()
        frmGame.Show()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: SettingsToolStripMenuItem_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for SettingsToolStripMenuItem. This allows the user to navigate to the Settings Screen.
    '----------------------------------------------------------------------------------------
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Hide()
        frmSettings.Show()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: HelpToolStripMenuItem_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for HelpToolStripMenuItem. This allows the user to navigate to the Help Screen.
    '----------------------------------------------------------------------------------------
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmHelp.Show()
    End Sub
End Class