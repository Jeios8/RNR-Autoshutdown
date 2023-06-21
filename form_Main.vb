﻿Public Class form_Main
    Private WithEvents serialPort As New SerialPort("COM1")
    Private dsrReady As Boolean
    Private dtrReady As Boolean
    Private TICKER As TimeSpan
    Private WAIT_TIME = 180

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open the serial port
            serialPort.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ' Launch the serial port listener
        TICKER = TimeSpan.FromSeconds(WAIT_TIME)
        lbl_PCName.Text = System.Net.Dns.GetHostName
        timer_COMListener.Enabled = True
    End Sub

    Private Sub btn_ForceShutdown_Click(sender As Object, e As EventArgs) Handles btn_ForceShutdown.Click
        ' Check if the DSR and DTR signals are ready
        If (dsrReady And dtrReady) = False Then
            ' Disable timers and close the serial port
            timer_Countdown.Enabled = False
            timer_COMListener.Enabled = False
            serialPort.Close()

            Console.WriteLine("Initiating shutdown...")
            Shell("shutdown /s /f /t 0") ' Execute system shutdown command
        End If
    End Sub

    Private Sub Timer_Countdown_Tick(sender As Object, e As EventArgs) Handles timer_Countdown.Tick
        TICKER -= TimeSpan.FromSeconds(1)
        lbl_Timer.Text = TICKER.ToString("mm\:ss")

        If TICKER <= TimeSpan.Zero Then
            ' Disable timers and close the serial port
            timer_Countdown.Enabled = False
            timer_COMListener.Enabled = False
            serialPort.Close()

            Console.WriteLine("Timer expired! Initiating shutdown...")
            Shell("shutdown /s /f /t 0") ' Execute system shutdown command
        End If
    End Sub

    Private Sub timer_COMListener_Tick(sender As Object, e As EventArgs) Handles timer_COMListener.Tick
        ' Check the serial port signal
        dsrReady = serialPort.DsrHolding

        ' Check if the DSR and DTR signals are not ready
        If dsrReady = False Then
            ' Check if the countdown timer is already disabled
            If timer_Countdown.Enabled = False Then
                TICKER = TimeSpan.FromSeconds(WAIT_TIME)
                timer_Countdown.Enabled = True
                timer_Announcement.Enabled = True
            End If
        Else ' DSR and DTR signals are ready
            ' Check if the countdown timer is already enabled
            If timer_Countdown.Enabled = True Then
                timer_Countdown.Enabled = False
                timer_Announcement.Enabled = False
            End If
        End If
    End Sub

    Private Sub timer_Announcement_Tick(sender As Object, e As EventArgs) Handles timer_Announcement.Tick
        Dim rand As New Random

        ' Set the font color of Announcement label randomly
        lbl_Announcement.ForeColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
    End Sub
End Class
