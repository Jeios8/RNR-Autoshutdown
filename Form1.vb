﻿Public Class form_Main
    Private TICKER As TimeSpan
    Private WAIT_TIME = 120
    Private NO_SIGNAL = True

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TICKER = TimeSpan.FromSeconds(WAIT_TIME)
        lbl_PCName.Text = System.Net.Dns.GetHostName
        timer_COMListener.Enabled = True
    End Sub

    Private Sub Timer_Countdown_Tick(sender As Object, e As EventArgs) Handles timer_Countdown.Tick
        TICKER -= TimeSpan.FromSeconds(1)
        lbl_Timer.Text = TICKER.ToString("mm\:ss")

        If TICKER <= TimeSpan.Zero Then
            timer_Countdown.Enabled = False
            MsgBox("Countdown timer is over! Initiating shutdown.")
            'Shell("shutdown /s /f /t 0")
        End If
    End Sub

    Private Sub btn_InsertCoin_Click(sender As Object, e As EventArgs) Handles btn_ForceShutdown.Click
        If NO_SIGNAL = True Then
            MsgBox("Force Shutdown Initiated")
            'Shell("shutdown /s /f /t 0")
        End If
    End Sub

    Private Sub timer_COMListener_Tick(sender As Object, e As EventArgs) Handles timer_COMListener.Tick
        If NO_SIGNAL = True Then
            If timer_Countdown.Enabled = False Then
                TICKER = TimeSpan.FromSeconds(WAIT_TIME)
                timer_Countdown.Enabled = True
                timer_Announcement.Enabled = True
            End If
        Else
            If timer_Countdown.Enabled = True Then
                timer_Countdown.Enabled = False
                timer_Announcement.Enabled = False
            End If
        End If
    End Sub

    Private Sub timer_Announcement_Tick(sender As Object, e As EventArgs) Handles timer_Announcement.Tick
        Dim rand As New Random
        lbl_Announcement.ForeColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
    End Sub
End Class