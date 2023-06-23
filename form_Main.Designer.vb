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
        GroupBox1 = New GroupBox()
        lbl_Timer = New Label()
        btn_ForceShutdown = New Button()
        timer_COMListener = New Timer(components)
        lbl_Announcement = New Label()
        lbl_PCName = New Label()
        timer_Announcement = New Timer(components)
        pb_Logo = New PictureBox()
        lbl_Watermark = New Label()
        gp_UserLogin = New GroupBox()
        btn_Register = New Button()
        txt_Password = New TextBox()
        btn_LoginMenu = New Button()
        txt_Username = New TextBox()
        lbl_Password = New Label()
        lbl_Username = New Label()
        GroupBox1.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
        gp_UserLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' timer_Countdown
        ' 
        timer_Countdown.Interval = 1000
        ' 
        ' GroupBox1
        ' 
        resources.ApplyResources(GroupBox1, "GroupBox1")
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(lbl_Timer)
        GroupBox1.ForeColor = SystemColors.ActiveCaption
        GroupBox1.Name = "GroupBox1"
        GroupBox1.TabStop = False
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
        btn_ForceShutdown.ForeColor = Color.Black
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
        ' gp_UserLogin
        ' 
        resources.ApplyResources(gp_UserLogin, "gp_UserLogin")
        gp_UserLogin.BackColor = Color.Transparent
        gp_UserLogin.Controls.Add(btn_Register)
        gp_UserLogin.Controls.Add(txt_Password)
        gp_UserLogin.Controls.Add(btn_LoginMenu)
        gp_UserLogin.Controls.Add(txt_Username)
        gp_UserLogin.Controls.Add(lbl_Password)
        gp_UserLogin.Controls.Add(lbl_Username)
        gp_UserLogin.ForeColor = SystemColors.ActiveCaption
        gp_UserLogin.Name = "gp_UserLogin"
        gp_UserLogin.TabStop = False
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
        ' btn_LoginMenu
        ' 
        resources.ApplyResources(btn_LoginMenu, "btn_LoginMenu")
        btn_LoginMenu.BackColor = Color.SteelBlue
        btn_LoginMenu.ForeColor = SystemColors.Control
        btn_LoginMenu.Name = "btn_LoginMenu"
        btn_LoginMenu.UseVisualStyleBackColor = False
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
        ' form_Main
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        ControlBox = False
        Controls.Add(lbl_Watermark)
        Controls.Add(gp_UserLogin)
        Controls.Add(btn_ForceShutdown)
        Controls.Add(GroupBox1)
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
        GroupBox1.ResumeLayout(False)
        CType(pb_Logo, ComponentModel.ISupportInitialize).EndInit()
        gp_UserLogin.ResumeLayout(False)
        gp_UserLogin.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timer_Countdown As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents btn_ForceShutdown As Button
    Friend WithEvents timer_COMListener As Timer
    Friend WithEvents lbl_Announcement As Label
    Friend WithEvents lbl_PCName As Label
    Friend WithEvents timer_Announcement As Timer
    Friend WithEvents pb_Logo As PictureBox
    Friend WithEvents lbl_Watermark As Label
    Friend WithEvents gp_UserLogin As GroupBox
    Friend WithEvents btn_Register As Button
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents btn_LoginMenu As Button
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
End Class
