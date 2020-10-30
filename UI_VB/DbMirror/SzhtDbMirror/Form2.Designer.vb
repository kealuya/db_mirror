<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.state = New FontAwesome.Sharp.IconButton()
        Me.backup = New FontAwesome.Sharp.IconButton()
        Me.strategy = New FontAwesome.Sharp.IconButton()
        Me.dbSetting = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.state)
        Me.PanelMenu.Controls.Add(Me.backup)
        Me.PanelMenu.Controls.Add(Me.strategy)
        Me.PanelMenu.Controls.Add(Me.dbSetting)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 523)
        Me.PanelMenu.TabIndex = 0
        '
        'state
        '
        Me.state.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.state.Dock = System.Windows.Forms.DockStyle.Top
        Me.state.FlatAppearance.BorderSize = 0
        Me.state.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.state.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.state.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.state.ForeColor = System.Drawing.Color.Gainsboro
        Me.state.IconChar = FontAwesome.Sharp.IconChar.BatteryThreeQuarters
        Me.state.IconColor = System.Drawing.Color.Gainsboro
        Me.state.IconSize = 32
        Me.state.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.state.Location = New System.Drawing.Point(0, 320)
        Me.state.Name = "state"
        Me.state.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.state.Rotation = 0R
        Me.state.Size = New System.Drawing.Size(200, 60)
        Me.state.TabIndex = 5
        Me.state.Text = "状态"
        Me.state.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.state.UseVisualStyleBackColor = True
        '
        'backup
        '
        Me.backup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backup.Dock = System.Windows.Forms.DockStyle.Top
        Me.backup.FlatAppearance.BorderSize = 0
        Me.backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backup.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.backup.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.backup.ForeColor = System.Drawing.Color.Gainsboro
        Me.backup.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt
        Me.backup.IconColor = System.Drawing.Color.Gainsboro
        Me.backup.IconSize = 32
        Me.backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backup.Location = New System.Drawing.Point(0, 260)
        Me.backup.Name = "backup"
        Me.backup.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.backup.Rotation = 0R
        Me.backup.Size = New System.Drawing.Size(200, 60)
        Me.backup.TabIndex = 4
        Me.backup.Text = "备份执行"
        Me.backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.backup.UseVisualStyleBackColor = True
        '
        'strategy
        '
        Me.strategy.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.strategy.Dock = System.Windows.Forms.DockStyle.Top
        Me.strategy.FlatAppearance.BorderSize = 0
        Me.strategy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strategy.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.strategy.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.strategy.ForeColor = System.Drawing.Color.Gainsboro
        Me.strategy.IconChar = FontAwesome.Sharp.IconChar.ChessQueen
        Me.strategy.IconColor = System.Drawing.Color.Gainsboro
        Me.strategy.IconSize = 32
        Me.strategy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strategy.Location = New System.Drawing.Point(0, 200)
        Me.strategy.Name = "strategy"
        Me.strategy.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.strategy.Rotation = 0R
        Me.strategy.Size = New System.Drawing.Size(200, 60)
        Me.strategy.TabIndex = 3
        Me.strategy.Text = "备份策略"
        Me.strategy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.strategy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.strategy.UseVisualStyleBackColor = True
        '
        'dbSetting
        '
        Me.dbSetting.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.dbSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbSetting.FlatAppearance.BorderSize = 0
        Me.dbSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dbSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.dbSetting.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dbSetting.ForeColor = System.Drawing.Color.Gainsboro
        Me.dbSetting.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.dbSetting.IconColor = System.Drawing.Color.Gainsboro
        Me.dbSetting.IconSize = 32
        Me.dbSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dbSetting.Location = New System.Drawing.Point(0, 140)
        Me.dbSetting.Name = "dbSetting"
        Me.dbSetting.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.dbSetting.Rotation = 0R
        Me.dbSetting.Size = New System.Drawing.Size(200, 60)
        Me.dbSetting.TabIndex = 2
        Me.dbSetting.Text = "数据库"
        Me.dbSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dbSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dbSetting.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(3, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(191, 134)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblFormTitle)
        Me.Panel1.Controls.Add(Me.IconCurrentForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 70)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(713, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(75, 33)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(35, 14)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "主页"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.Location = New System.Drawing.Point(26, 24)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(43, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(200, 70)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(740, 453)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(740, 453)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "浩天数据备份"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(940, 523)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB镜像工具"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents dbSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents state As FontAwesome.Sharp.IconButton
    Friend WithEvents backup As FontAwesome.Sharp.IconButton
    Friend WithEvents strategy As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
