﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        GroupBox1.SuspendLayout()
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
        ' form_Main
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.bg
        Controls.Add(lbl_PCName)
        Controls.Add(lbl_Announcement)
        Controls.Add(btn_ForceShutdown)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "form_Main"
        ShowInTaskbar = False
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
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
End Class
