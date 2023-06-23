Public Class form_Main
    Private WithEvents serialPort As New SerialPort
    Private TICKER As TimeSpan
    Private WAIT_TIME = 180
    Public SUDO_USER = False

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports As Array
        ports = SerialPort.GetPortNames

        serialPort.PortName = ports(1) ' Set value to the first detected port
        serialPort.BaudRate = 9600
        serialPort.ReadTimeout = 2000
        serialPort.DtrEnable = True

        Try
            ' Open the serial port
            If serialPort.IsOpen Then serialPort.Close()
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
        If serialPort.DsrHolding = False Then
            ' Disable timers and close the serial port
            timer_Countdown.Enabled = False
            timer_COMListener.Enabled = False
            If serialPort.IsOpen Then serialPort.Close()

            Console.WriteLine("Force Shutdown Initiated")
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
            If serialPort.IsOpen Then serialPort.Close()

            Console.WriteLine("Timer expired! Shutdown Initiated")
            Shell("shutdown /s /f /t 0") ' Execute system shutdown command
        End If
    End Sub

    Private Sub timer_COMListener_Tick(sender As Object, e As EventArgs) Handles timer_COMListener.Tick
        ' Check the serial port signal
        If serialPort.DsrHolding = False Then
            ' Check if the countdown timer is already disabled
            If timer_Countdown.Enabled = False Then
                TICKER = TimeSpan.FromSeconds(WAIT_TIME)
                timer_Countdown.Enabled = True
                timer_Announcement.Enabled = True
                If Me.Visible = False Then
                    Me.Show()
                End If
                Me.TopMost = True
            End If
        ElseIf serialPort.DsrHolding = True Then ' DSR and DTR signals are ready
            ' Check if the countdown timer is already enabled
            If timer_Countdown.Enabled = True Then
                timer_Countdown.Enabled = False
                timer_Announcement.Enabled = False
                Me.TopMost = False
                If Me.Visible = True Then
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub timer_Announcement_Tick(sender As Object, e As EventArgs) Handles timer_Announcement.Tick
        Dim rand As New Random

        ' Set the font color of Announcement label randomly
        lbl_Announcement.ForeColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs)

    End Sub
End Class
