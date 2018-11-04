'=================================================
' Class : frmSplash
' Project : Assignment 2 Phase 2 EDP
' Version : 1.0
' Date : 10/05/2016
' Author : Matthew de Leeuwe
' Description : This is the splash screen and it is the first screen the user sees when the program is booted up.
' This form will display the Game logo and a progress bar and the form will hide after 5 seconds due to a timer. It will then display the about form.
'=================================================
Public Class frmSplash
    '----------------------------------------------------------------------------------------
    ' Module: tmrSplash_Tick
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : This is the timer tick event so this is what happens when the timer ticks.
    ' This is the timer that controls how long the splash screen is visible for.
    '----------------------------------------------------------------------------------------
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        Me.Hide()
        frmAbout.Show()
        tmrSplash.Stop()
        tmrProgressBar.Stop()
    End Sub
    '----------------------------------------------------------------------------------------
    ' Module: tmrProgressBar_Tick
    ' Date : 10/05/2016
    ' Author : Matthew de Leeuwe
    ' Parameters : Object, EventArgs
    ' Description : This is the timer that controls the progress bar.
    '----------------------------------------------------------------------------------------
    Private Sub tmrProgressBar_Tick(sender As Object, e As EventArgs) Handles tmrProgressBar.Tick
        'Upon each tick of the timer this code fills the progress bar until full.
        If pbSplash.Value < pbSplash.Maximum Then
            pbSplash.PerformStep()
        End If
    End Sub

End Class
