Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class Form2

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)



    End Sub
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '启动go程序，并检测是否可以沟通
        If Not ModuleInit.RunSzhtDbBak() Then
            MsgBox("系统无法启动，发生故障")
        End If


        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem("88")
        Me.NotifyIcon1.ContextMenuStrip = New ContextMenuStrip
        ' Me.NotifyIcon1.ContextMenu.MenuItems = New Menu.MenuItemCollection
        Me.NotifyIcon1.ContextMenuStrip.Items.Add(Me.ToolStripMenuItem1)


        'Me.NotifyIcon1.ShowBalloonTip(2000, "tt", "xx", ToolTipIcon.Info)
        '设定程序不应该显示在任务栏
        Me.ShowInTaskbar = False
        '设定程序运行后最小化
        ' Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        DisableButton()

        If senderBtn IsNot Nothing Then
            currentBtn = CType(senderBtn, IconButton)
            With currentBtn
                .BackColor = Color.FromArgb(37, 36, 81)
                .ForeColor = customColor
                .IconColor = customColor
                .TextAlign = ContentAlignment.MiddleCenter
                .ImageAlign = ContentAlignment.MiddleRight
                .TextImageRelation = TextImageRelation.TextBeforeImage
            End With

            With leftBorderBtn
                .BackColor = customColor
                .Location = New Point(0, currentBtn.Location.Y)
                .Visible = True
                .BringToFront()
            End With
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If

    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            With currentBtn
                .BackColor = Color.FromArgb(31, 30, 68)
                .ForeColor = Color.Gainsboro
                .IconColor = Color.Gainsboro
                .TextAlign = ContentAlignment.MiddleLeft
                .ImageAlign = ContentAlignment.MiddleLeft
                .TextImageRelation = TextImageRelation.ImageBeforeText

            End With
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childForm.TopLevel = False
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text

    End Sub










    Private Sub dbSetting_Click(sender As Object, e As EventArgs) Handles dbSetting.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormDbSetting)
    End Sub


    Private Sub strategy_Click(sender As Object, e As EventArgs) Handles strategy.Click
        ActivateButton(sender, RGBColors.color2)
    End Sub

    Private Sub backup_Click(sender As Object, e As EventArgs) Handles backup.Click
        ActivateButton(sender, RGBColors.color3)
    End Sub

    Private Sub state_Click(sender As Object, e As EventArgs) Handles state.Click
        ActivateButton(sender, RGBColors.color6)
    End Sub

    Dim x1, x2, y1, y2 As Integer

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub




    '鼠标左键按下后将x1,y1赋值
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            x1 = e.X
            y1 = e.Y
        End If
    End Sub


    '拖动过程中不断对x2,y2赋值
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            x2 = e.X
            y2 = e.Y
            Me.Left = Me.Location.X + (x2 - x1)
            Me.Top = Me.Location.Y + (y2 - y1)
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipShown(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipShown

    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Debug.Print("sdfsd")

    End Sub


    Private Sub Form2_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub
End Class

