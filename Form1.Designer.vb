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
        btn_InsertCoin = New Button()
        timer_COMListener = New Timer(components)
        TextBox1 = New TextBox()
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
        GroupBox1.BackColor = SystemColors.ActiveCaptionText
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
        ' btn_InsertCoin
        ' 
        resources.ApplyResources(btn_InsertCoin, "btn_InsertCoin")
        btn_InsertCoin.Name = "btn_InsertCoin"
        btn_InsertCoin.UseVisualStyleBackColor = True
        ' 
        ' timer_COMListener
        ' 
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.BackColor = SystemColors.WindowFrame
        TextBox1.ForeColor = SystemColors.HighlightText
        TextBox1.Name = "TextBox1"
        ' 
        ' form_Main
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TextBox1)
        Controls.Add(btn_InsertCoin)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "form_Main"
        ShowInTaskbar = False
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timer_Countdown As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents btn_InsertCoin As Button
    Friend WithEvents timer_COMListener As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
