'=================================================
' Class : FrmGame
' Project : Assignment 2 Phase 2 EDP
' Version : 1.0
' Date : 10/05/2016
' Author : Matthew de Leeuwe
' Description : This is the game screen this is the screen where the user plays the high low game.
'=================================================
Public Class frmGame
    Dim intbox1, intbox2, intScore As Integer
    'This is a random number generator.
    Public Function GetRandom()
        Randomize()
        Dim intRandomNumber = (Int(Rnd() * 13 + 1))
        Return intRandomNumber
    End Function
    '----------------------------------------------------------------------------------------
    ' Module: frmGame_Load
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : This code is what the form does when it loads.
    ' This assigns picbox1 a random card using the random number generator public function.
    ' When the form loads there will be a card in picbox1 because of this.
    '----------------------------------------------------------------------------------------
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intbox1 = GetRandom()
        picbox1.Image = My.Resources.ResourceManager.GetObject("card" & intbox1)
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
    '----------------------------------------------------------------------------------------
    ' Module: btnHigh_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for btnHigh. This is the button the user clicks when the guess the next card will be higher than the current card.
    '----------------------------------------------------------------------------------------
    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        intbox2 = GetRandom()
        picbox2.Image = My.Resources.ResourceManager.GetObject("card" & intbox2)
        'Checks if card two is higher than card one, an output message is then displayed, the score is updated and picture box two then displays a card back.
        If intbox2 > intbox1 Then
            MsgBox("Congratulations You Win!")
            intScore += 1
            lblScore.Text = intScore.ToString

        Else
            MsgBox("Sorry You Lose!")
            intScore = 0
            lblScore.Text = intScore.ToString
            intbox1 = intbox2
        End If
        intbox1 = intbox2
        picbox1.Image = My.Resources.ResourceManager.GetObject("card" & intbox2)
        picbox2.Image = My.Resources.Back
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: btnLow_Click
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : Click event handler for btnLow. This is the button the user clicks when the guess the next card will be Lower than the current card.
    '----------------------------------------------------------------------------------------
    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        intbox2 = GetRandom()
        picbox2.Image = My.Resources.ResourceManager.GetObject("card" & intbox2)
        'Checks if card two is higher than card one, an output message is then displayed, the score is updated and picture box two then displays a card back.
        If intbox2 < intbox1 Then
            MsgBox("Congratulations You Win!")
            intScore += 1
            lblScore.Text = intScore.ToString
            intbox1 = intbox2
        Else
            MsgBox("Sorry You Lose!")
            intScore = 0
            lblScore.Text = intScore.ToString
            intbox1 = intbox2
        End If
        intbox1 = intbox2
        picbox1.Image = My.Resources.ResourceManager.GetObject("card" & intbox2)
        picbox2.Image = My.Resources.Back
    End Sub
End Class