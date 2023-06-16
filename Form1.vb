
Public Class form_Main
    Private ticker As TimeSpan

    Private Sub form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ticker = TimeSpan.FromSeconds(15)
    End Sub

    Private Sub timer_Countdown_Tick(sender As Object, e As EventArgs) Handles timer_Countdown.Tick
        ticker = ticker - TimeSpan.FromSeconds(1)

        If ticker <= TimeSpan.Zero Then
            MsgBox("Countdown timer is over! Initiating shutdown.")
            Shell("shutdown /s /f /t 0")
        End If
    End Sub
End Class
