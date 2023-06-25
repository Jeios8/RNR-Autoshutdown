<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(form_Main))
        timer_Countdown = New Timer(components)
        gb_CountdownTimer = New GroupBox()
        lbl_Timer = New Label()
        btn_ForceShutdown = New Button()
        timer_COMListener = New Timer(components)
        lbl_Announcement = New Label()
        lbl_PCName = New Label()
        timer_Announcement = New Timer(components)
        pb_Logo = New PictureBox()
        lbl_Watermark = New Label()
        gb_UserLogin = New GroupBox()
        btn_CancelLogin = New Button()
        btn_Register = New Button()
        txt_Password = New TextBox()
        btn_Login = New Button()
        txt_Username = New TextBox()
        lbl_Password = New Label()
        lbl_Username = New Label()
        btn_LoginForm = New Button()
        gb_UserInfo = New GroupBox()
        lbl_Points = New Label()
        lbl_Type = New Label()
        lbl_Name = New Label()
        gb_CountdownTimer.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
        gb_UserLogin.SuspendLayout()
        gb_UserInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' timer_Countdown
        ' 
        timer_Countdown.Interval = 1000
        ' 
        ' gb_CountdownTimer
        ' 
        resources.ApplyResources(gb_CountdownTimer, "gb_CountdownTimer")
        gb_CountdownTimer.BackColor = Color.Transparent
        gb_CountdownTimer.Controls.Add(lbl_Timer)
        gb_CountdownTimer.ForeColor = SystemColors.ActiveCaption
        gb_CountdownTimer.Name = "gb_CountdownTimer"
        gb_CountdownTimer.TabStop = False
        ' 
        ' lbl_Timer
        ' 
        resources.ApplyResources(lbl_Timer, "lbl_Timer")
        lbl_Timer.Name = "lbl_Timer"
        ' 
        ' btn_ForceShutdown
        ' 
        resources.ApplyResources(btn_ForceShutdown, "btn_ForceShutdown")
        btn_ForceShutdown.BackColor = Color.SteelBlue
        btn_ForceShutdown.ForeColor = SystemColors.Control
        btn_ForceShutdown.Name = "btn_ForceShutdown"
        btn_ForceShutdown.UseVisualStyleBackColor = False
        ' 
        ' timer_COMListener
        ' 
        ' 
        ' lbl_Announcement
        ' 
        resources.ApplyResources(lbl_Announcement, "lbl_Announcement")
        lbl_Announcement.BackColor = Color.Transparent
        lbl_Announcement.ForeColor = SystemColors.ActiveCaption
        lbl_Announcement.Name = "lbl_Announcement"
        ' 
        ' lbl_PCName
        ' 
        resources.ApplyResources(lbl_PCName, "lbl_PCName")
        lbl_PCName.BackColor = Color.Transparent
        lbl_PCName.ForeColor = SystemColors.ActiveCaption
        lbl_PCName.Name = "lbl_PCName"
        ' 
        ' timer_Announcement
        ' 
        timer_Announcement.Interval = 250
        ' 
        ' pb_Logo
        ' 
        resources.ApplyResources(pb_Logo, "pb_Logo")
        pb_Logo.BackColor = Color.Transparent
        pb_Logo.Image = My.Resources.Resources.logo
        pb_Logo.Name = "pb_Logo"
        pb_Logo.TabStop = False
        ' 
        ' lbl_Watermark
        ' 
        resources.ApplyResources(lbl_Watermark, "lbl_Watermark")
        lbl_Watermark.BackColor = Color.Transparent
        lbl_Watermark.ForeColor = SystemColors.ActiveCaption
        lbl_Watermark.Name = "lbl_Watermark"
        ' 
        ' gb_UserLogin
        ' 
        resources.ApplyResources(gb_UserLogin, "gb_UserLogin")
        gb_UserLogin.BackColor = Color.Transparent
        gb_UserLogin.Controls.Add(btn_CancelLogin)
        gb_UserLogin.Controls.Add(btn_Register)
        gb_UserLogin.Controls.Add(txt_Password)
        gb_UserLogin.Controls.Add(btn_Login)
        gb_UserLogin.Controls.Add(txt_Username)
        gb_UserLogin.Controls.Add(lbl_Password)
        gb_UserLogin.Controls.Add(lbl_Username)
        gb_UserLogin.ForeColor = SystemColors.ActiveCaption
        gb_UserLogin.Name = "gb_UserLogin"
        gb_UserLogin.TabStop = False
        ' 
        ' btn_CancelLogin
        ' 
        resources.ApplyResources(btn_CancelLogin, "btn_CancelLogin")
        btn_CancelLogin.BackColor = Color.Firebrick
        btn_CancelLogin.ForeColor = SystemColors.Control
        btn_CancelLogin.Name = "btn_CancelLogin"
        btn_CancelLogin.UseVisualStyleBackColor = False
        ' 
        ' btn_Register
        ' 
        resources.ApplyResources(btn_Register, "btn_Register")
        btn_Register.BackColor = Color.ForestGreen
        btn_Register.ForeColor = SystemColors.Control
        btn_Register.Name = "btn_Register"
        btn_Register.UseVisualStyleBackColor = False
        ' 
        ' txt_Password
        ' 
        resources.ApplyResources(txt_Password, "txt_Password")
        txt_Password.Name = "txt_Password"
        ' 
        ' btn_Login
        ' 
        resources.ApplyResources(btn_Login, "btn_Login")
        btn_Login.BackColor = Color.SteelBlue
        btn_Login.ForeColor = SystemColors.Control
        btn_Login.Name = "btn_Login"
        btn_Login.UseVisualStyleBackColor = False
        ' 
        ' txt_Username
        ' 
        resources.ApplyResources(txt_Username, "txt_Username")
        txt_Username.Name = "txt_Username"
        ' 
        ' lbl_Password
        ' 
        resources.ApplyResources(lbl_Password, "lbl_Password")
        lbl_Password.Name = "lbl_Password"
        ' 
        ' lbl_Username
        ' 
        resources.ApplyResources(lbl_Username, "lbl_Username")
        lbl_Username.Name = "lbl_Username"
        ' 
        ' btn_LoginForm
        ' 
        resources.ApplyResources(btn_LoginForm, "btn_LoginForm")
        btn_LoginForm.BackColor = Color.SteelBlue
        btn_LoginForm.ForeColor = SystemColors.Control
        btn_LoginForm.Name = "btn_LoginForm"
        btn_LoginForm.UseVisualStyleBackColor = False
        ' 
        ' gb_UserInfo
        ' 
        resources.ApplyResources(gb_UserInfo, "gb_UserInfo")
        gb_UserInfo.BackColor = Color.Transparent
        gb_UserInfo.Controls.Add(lbl_Points)
        gb_UserInfo.Controls.Add(lbl_Type)
        gb_UserInfo.Controls.Add(lbl_Name)
        gb_UserInfo.ForeColor = SystemColors.ActiveCaption
        gb_UserInfo.Name = "gb_UserInfo"
        gb_UserInfo.TabStop = False
        ' 
        ' lbl_Points
        ' 
        resources.ApplyResources(lbl_Points, "lbl_Points")
        lbl_Points.Name = "lbl_Points"
        ' 
        ' lbl_Type
        ' 
        resources.ApplyResources(lbl_Type, "lbl_Type")
        lbl_Type.Name = "lbl_Type"
        ' 
        ' lbl_Name
        ' 
        resources.ApplyResources(lbl_Name, "lbl_Name")
        lbl_Name.Name = "lbl_Name"
        ' 
        ' form_Main
        ' 
        AcceptButton = btn_Login
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        CancelButton = btn_CancelLogin
        ControlBox = False
        Controls.Add(gb_UserInfo)
        Controls.Add(btn_LoginForm)
        Controls.Add(lbl_Watermark)
        Controls.Add(gb_UserLogin)
        Controls.Add(btn_ForceShutdown)
        Controls.Add(gb_CountdownTimer)
        Controls.Add(pb_Logo)
        Controls.Add(lbl_PCName)
        Controls.Add(lbl_Announcement)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "form_Main"
        ShowIcon = False
        ShowInTaskbar = False
        WindowState = FormWindowState.Maximized
        gb_CountdownTimer.ResumeLayout(False)
        CType(pb_Logo, ComponentModel.ISupportInitialize).EndInit()
        gb_UserLogin.ResumeLayout(False)
        gb_UserLogin.PerformLayout()
        gb_UserInfo.ResumeLayout(False)
        gb_UserInfo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timer_Countdown As Timer
    Friend WithEvents gb_CountdownTimer As GroupBox
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents btn_ForceShutdown As Button
    Friend WithEvents timer_COMListener As Timer
    Friend WithEvents lbl_Announcement As Label
    Friend WithEvents lbl_PCName As Label
    Friend WithEvents timer_Announcement As Timer
    Friend WithEvents pb_Logo As PictureBox
    Friend WithEvents lbl_Watermark As Label
    Friend WithEvents gb_UserLogin As GroupBox
    Friend WithEvents btn_Register As Button
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents btn_Login As Button
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_CancelLogin As Button
    Friend WithEvents btn_LoginForm As Button
    Friend WithEvents gb_UserInfo As GroupBox
    Friend WithEvents lbl_Points As Label
    Friend WithEvents lbl_Type As Label
    Friend WithEvents lbl_Name As Label
End Class
