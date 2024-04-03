Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_Main
    Private WithEvents serialPort As New SerialPort
    Private TICKER As TimeSpan
    Private VOUCHER_TICKER As TimeSpan
    Private VOUCHER_TIME = 0
    Private WAIT_TIME = 180
    Private ADMIN_ACCOUNT = False

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

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
        timer_Countdown.Enabled = True
        timer_COMListener.Enabled = True
        timer_Announcement.Enabled = True
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
                    Me.TopMost = True
                End If
            End If
            Me.TopMost = True
            Me.WindowState = FormWindowState.Maximized
        Else ' DSR and DTR signals are ready
            ' Check if the countdown timer is already enabled
            If timer_Countdown.Enabled = True Then
                TICKER = TimeSpan.FromSeconds(WAIT_TIME)
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

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = False
        End If
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If (gb_FormOption.Visible = True) Then
            gb_FormOption.Visible = False
            btn_Login.Text = "Show Form"
        Else
            gb_FormOption.Visible = True
            btn_Login.Text = "Hide Form"
        End If
    End Sub

    Private Sub btn_UseVoucher_Click(sender As Object, e As EventArgs) Handles btn_UseVoucher.Click
        If txt_Voucher.Text = "040810174817302243519278" Then
            ADMIN_ACCOUNT = True
            VOUCHER_TIME = 1800
            VOUCHER_TICKER = TimeSpan.FromSeconds(VOUCHER_TIME)
            timer_COMListener.Enabled = False
            timer_Countdown.Enabled = False
            timer_Announcement.Enabled = False
            timer_Voucher.Enabled = True
            If Me.Visible = True Then
                Me.Hide()
            End If
        Else
            txt_Voucher.Text = ""
            MsgBox("Voucher does not exist, please try again.", 0, "Voucher Error")
        End If
    End Sub

    Private Sub timer_Voucher_Tick(sender As Object, e As EventArgs) Handles timer_Voucher.Tick
        VOUCHER_TICKER -= TimeSpan.FromSeconds(1)

        If VOUCHER_TICKER <= TimeSpan.Zero Then
            ' Disable timers and close the serial port

            timer_COMListener.Enabled = True
            timer_Countdown.Enabled = True
            timer_Announcement.Enabled = True
            timer_Voucher.Enabled = False

            If Me.Visible = False Then
                Me.Show()
            End If
        End If
    End Sub
End Class