Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_Main
    Private WithEvents serialPort As New SerialPort
    Private TICKER As TimeSpan
    Private WAIT_TIME = 180
    Private SUPER_USER = False
    Private LOGGED_IN = False

    ' User Variables
    Private USERNAME = ""
    Private ADMIN = 0
    Private LEVEL = 0
    Private POINTS = 0

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

        gb_UserLogin.Hide()
        gb_UserInfo.Hide()
        gb_RegistrationForm.Hide()
        btn_LoginForm.Hide()

        dbconnection.Open()
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

    Private Sub btn_LoginForm_Click(sender As Object, e As EventArgs) Handles btn_LoginForm.Click
        If LOGGED_IN = False Then
            btn_LoginForm.Hide()
            gb_UserLogin.Show()
        End If
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Dim user = txt_Username.Text
        Dim pass = txt_Password.Text

        If user = "" Then
            MsgBox("Please enter your username.", 0, "Invalid Username")
            txt_Username.Select()
            Exit Sub
        ElseIf pass = "" Then
            MsgBox("Please enter your password.", 0, "Invalid Password")
            txt_Password.Select()
            Exit Sub
        End If

        dbcommand = New OleDbCommand("SELECT * FROM members WHERE Username='" & user & "'", dbconnection)

        Dim dbreader As OleDbDataReader
        Dim dbuser, dbpass As String
        Dim dbid, dbadmin, dblevel, dbpoints As Integer

        dbreader = dbcommand.ExecuteReader()

        If dbreader.HasRows Then
            dbreader.Read()

            dbid = dbreader.Item("ID")
            dbuser = dbreader.Item("Username")
            dbpass = dbreader.Item("Password")
            dbadmin = dbreader.Item("Admin")
            dblevel = dbreader.Item("Level")
            dbpoints = dbreader.Item("Points")

            If (dbpass = pass) Then
                gb_UserInfo.Show()

                lbl_Name.Text = "Name: " & dbuser & " (ID: " & dbid & ")"
                lbl_Level.Text = "Level: " & dblevel
                lbl_Points.Text = "Points: " & dbpoints

                USERNAME = dbuser
                ADMIN = dbadmin
                LEVEL = dblevel
                POINTS = dbpoints

                If ADMIN = 1 Then
                    timer_COMListener.Enabled = False
                    timer_Announcement.Enabled = False
                    timer_Countdown.Enabled = False

                    TICKER = TimeSpan.FromSeconds(WAIT_TIME)
                    lbl_Timer.Text = TICKER.ToString("mm\:ss")
                    lbl_Announcement.Hide()
                End If

                LOGGED_IN = True
                gb_UserLogin.Hide()
                btn_LoginForm.Hide()
            End If
        Else
            txt_Username.Text = ""
            txt_Password.Text = ""
            MsgBox("User does not exists, please try again or register to continue.", 0, "Invalid Credentials")
        End If
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        gb_UserLogin.Hide()
        gb_RegistrationForm.Show()
        btn_LoginForm.Hide()
    End Sub

    Private Sub btn_CancelLogin_Click(sender As Object, e As EventArgs) Handles btn_CancelLogin.Click
        gb_UserLogin.Hide()
        btn_LoginForm.Show()
    End Sub

    Private Sub gp_UserLogin_Visible(sender As Object, e As EventArgs) Handles gb_UserLogin.VisibleChanged
        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_Username.Select()
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        gb_UserLogin.Show()
        gb_UserInfo.Hide()
        txt_RegUsername.Select()
        LOGGED_IN = False

        If ADMIN = 1 Then
            TICKER = TimeSpan.FromSeconds(WAIT_TIME)
            lbl_Announcement.Show()
            timer_COMListener.Enabled = True
        End If
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Dim new_username = txt_RegUsername
        Dim new_password = txt_Password1
        Dim confirm_password = txt_Password2

        ' Check username if valid
        If new_username.TextLength() < 4 Or new_username.TextLength() > 30 Then
            MsgBox("Must be between 4 and 30 characters long.", 0, "Invalid Username")
            new_username.SelectionStart = 0
            new_username.SelectionLength = new_username.Text.Length
            new_username.Select()
            Exit Sub
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(new_username.Text, “^[a-zA-Z0-9]+$”) = False Then
            MsgBox("Can contain any letters from a to z and any numbers from 0 through 9.", 0, "Invalid Username")
            new_username.SelectionStart = 0
            new_username.SelectionLength = new_username.Text.Length
            new_username.Select()
            Exit Sub
        ElseIf new_password.TextLength() < 4 Or new_password.TextLength() > 30 Then
            MsgBox("Must be between 4 and 30 characters long.", 0, "Invalid Password")
            new_password.SelectionStart = 0
            new_password.SelectionLength = new_password.Text.Length
            new_password.Select()
            Exit Sub
        ElseIf new_password.Text <> confirm_password.Text Then
            MsgBox("Password does not match.", 0, "Invalid Password")
            confirm_password.SelectionStart = 0
            confirm_password.SelectionLength = confirm_password.Text.Length
            confirm_password.Select()
            Exit Sub
        End If

        dbcommand = New OleDbCommand("SELECT * FROM members WHERE Username='" & new_username.Text & "'", dbconnection)

        Dim dbreader As OleDbDataReader
        Dim dbitem As String

        dbreader = dbcommand.ExecuteReader()

        If dbreader.HasRows Then
            While dbreader.Read
                dbitem = dbreader.Item("Username")
                If dbitem = new_username.Text Then
                    MsgBox("Username: '" & dbitem & "' already exists, please try again. Thank you!", 0, "Invalid Username")
                    Exit While
                End If
            End While

            new_username.SelectionStart = 0
            new_username.SelectionLength = new_username.Text.Length
            new_username.Select()
            Exit Sub
        End If


        dbcommand = New OleDbCommand("INSERT INTO members([Username],[Password]) values('" & new_username.Text & "','" & new_password.Text & "')", dbconnection)

        Dim i
        i = dbcommand.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Successful")
        Else
            MsgBox("Failed")
        End If

        gb_RegistrationForm.Hide()
    End Sub

    Private Sub btn_CancelRegistration_Click(sender As Object, e As EventArgs) Handles btn_CancelRegistration.Click
        gb_RegistrationForm.Hide()
        gb_UserLogin.Show()
    End Sub

    Private Sub gb_RegistrationForm_Visible(sender As Object, e As EventArgs) Handles gb_RegistrationForm.VisibleChanged
        If gb_RegistrationForm.Visible = True Then
            txt_RegUsername.Text = ""
            txt_Password1.Text = ""
            txt_RegUsername.Select()
            gb_UserLogin.Hide()
            Me.AcceptButton = btn_Submit
            Me.CancelButton = btn_CancelRegistration
        Else
            gb_UserLogin.Show()
            Me.AcceptButton = btn_Login
            Me.CancelButton = btn_CancelLogin
        End If
    End Sub

    Private Sub FormStudents_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        dbconnection.Close()
    End Sub

    Private Sub btn_Usepoints_Click(sender As Object, e As EventArgs) Handles btn_Usepoints.Click

    End Sub
End Class