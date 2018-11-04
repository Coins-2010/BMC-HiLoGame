'=================================================
' Class : frmSettings
' Project : Assignment 2 Phase 2 EDP
' Version : 1.0
' Date : 10/05/2016
' Author : Matthew de Leeuwe
' Description : This is the main menu for the application this form shows the program version and allows the user to continue onto the game.
'=================================================
Public Class frmSettings
    '----------------------------------------------------------------------------------------
    ' Module: chkSound_CheckedChanged
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : This is the code that links the checkbox to the games sound so when the sound checkbox isnt checked the sound is off and when the checkbox is ticked the sound is on.
    '----------------------------------------------------------------------------------------
    Private Sub cbSound_CheckedChanged(sender As Object, e As EventArgs) Handles chkSound.CheckedChanged
        If chkSound.Checked = True Then
            MyGlobals.myPlayer.PlayLooping()
        Else
            MyGlobals.myPlayer.Stop()
        End If
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
    ' Module: AboutToolStripMenuItem_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for AboutToolStripMenuItem. This allows the user to navigate to the About Screen.
    '----------------------------------------------------------------------------------------
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        frmAbout.Show()
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
    '----------------------------------------------------------------------------------------
    ' Module: comBckColour_SelectedIndexChanged
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Event handler for comBckColour. This allows the user to chnage the colour of all the forms depending on what option they pick.
    '----------------------------------------------------------------------------------------
    Private Sub comBckColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBckColour.SelectedIndexChanged
        'When an option is selected from the combobox for example blue all of the forms change their back colour to blue.
        If comBckColour.Text = "Blue" Then
            Me.BackColor = Color.Blue
            frmGame.BackColor = Color.Blue
            frmAbout.BackColor = Color.Blue
            frmHelp.BackColor = Color.Blue
        ElseIf comBckColour.Text = "Red" Then
            Me.BackColor = Color.DarkRed
            frmGame.BackColor = Color.DarkRed
            frmAbout.BackColor = Color.DarkRed
            frmHelp.BackColor = Color.DarkRed
        Else
            comBckColour.Text = "Green"
            Me.BackColor = Color.Green
            frmGame.BackColor = Color.Green
            frmAbout.BackColor = Color.Green
            frmHelp.BackColor = Color.Green
        End If
    End Sub
End Class