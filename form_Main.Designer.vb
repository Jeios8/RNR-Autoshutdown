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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Main))
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
        Label1 = New Label()
        gb_CountdownTimer.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
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
        btn_ForceShutdown.BackColor = Color.DarkRed
        btn_ForceShutdown.ForeColor = SystemColors.Control
        btn_ForceShutdown.Name = "btn_ForceShutdown"
        btn_ForceShutdown.TabStop = False
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
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Name = "Label1"
        ' 
        ' form_Main
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(lbl_Watermark)
        Controls.Add(btn_ForceShutdown)
        Controls.Add(gb_CountdownTimer)
        Controls.Add(pb_Logo)
        Controls.Add(lbl_PCName)
        Controls.Add(lbl_Announcement)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "form_Main"
        ShowIcon = False
        ShowInTaskbar = False
        WindowState = FormWindowState.Maximized
        gb_CountdownTimer.ResumeLayout(False)
        CType(pb_Logo, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
