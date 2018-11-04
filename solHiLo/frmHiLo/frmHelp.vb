'=================================================
' Class : FrmHelp
' Project : Assignment 2 Phase 2 EDP
' Version : 1.0
' Date : 10/05/2016
' Author : Matthew de Leeuwe
' Description : This is the help screen. this Allows users to find out how to play the game.
'=================================================
Public Class frmHelp
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
    ' Module: comHelp_SelectedIndexChanged
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Event handler for comHelp. This allows the user to pick an object from the dropdown list and for it to display text in a label.
    '----------------------------------------------------------------------------------------
    Private Sub comHelp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comHelp.SelectedIndexChanged
        'User selects option from combo box and text is then displayed in a label.
        If comHelp.Text = "How do I play the Game?" Then
            lblHelpText.Text = "When you load up the game screen for the first time you will be displayed with a card. This card is your current card. You have to guess whether the next card is going to be higher or lower. You do so by clicking on the Higher! or Lower! buttons. If you are correct you will get a point added to your score and the new card shown will be your current card and you can then guess again to continue playing. If you guess incorrectly your score will be reset."
        ElseIf comHelp.Text = "What are the cards ranked Lowest to Highest?" Then
            lblHelpText.Text = "Ace = 1, The numbers stand for their number Joker = 11, Queen = 12, King = 13"
        ElseIf comHelp.Text = "How do I turn off the sound?" Then
            lblHelpText.Text = "If you would like to turn off the sound in the application you are able to do so by unchecking the Sound checkbox located on the Settings and Game Screens. Once either of these boxes are unchecked the sound for the entire application is turned off."
        ElseIf comHelp.Text = "Is there a way to change the Background Colour?" Then
            lblHelpText.Text = "Yes you are able to choose from three different colours Blue, Green and Red. The colours can be selected on the Settings screen. This screen is accessible through the menu system."
        Else : lblHelpText.Text = ""
        End If
    End Sub


End Class