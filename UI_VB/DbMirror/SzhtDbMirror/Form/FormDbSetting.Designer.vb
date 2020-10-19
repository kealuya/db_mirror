<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDbSetting
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Button_test = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_dbname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_ip = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_port = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_servicename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column_dbname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_servicename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button_test
        '
        Me.Guna2Button_test.Animated = True
        Me.Guna2Button_test.BorderRadius = 8
        Me.Guna2Button_test.CheckedState.Parent = Me.Guna2Button_test
        Me.Guna2Button_test.CustomImages.Parent = Me.Guna2Button_test
        Me.Guna2Button_test.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Button_test.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button_test.ForeColor = System.Drawing.Color.White
        Me.Guna2Button_test.HoverState.Parent = Me.Guna2Button_test
        Me.Guna2Button_test.Location = New System.Drawing.Point(423, 399)
        Me.Guna2Button_test.Name = "Guna2Button_test"
        Me.Guna2Button_test.ShadowDecoration.Parent = Me.Guna2Button_test
        Me.Guna2Button_test.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button_test.TabIndex = 0
        Me.Guna2Button_test.Text = "测试"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(27, 231)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(102, 21)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "数据库名称:"
        '
        'Guna2TextBox_dbname
        '
        Me.Guna2TextBox_dbname.Animated = True
        Me.Guna2TextBox_dbname.BorderRadius = 8
        Me.Guna2TextBox_dbname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_dbname.DefaultText = ""
        Me.Guna2TextBox_dbname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_dbname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_dbname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_dbname.DisabledState.Parent = Me.Guna2TextBox_dbname
        Me.Guna2TextBox_dbname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_dbname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_dbname.FocusedState.Parent = Me.Guna2TextBox_dbname
        Me.Guna2TextBox_dbname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_dbname.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_dbname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_dbname.HoverState.Parent = Me.Guna2TextBox_dbname
        Me.Guna2TextBox_dbname.Location = New System.Drawing.Point(148, 223)
        Me.Guna2TextBox_dbname.Name = "Guna2TextBox_dbname"
        Me.Guna2TextBox_dbname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_dbname.PlaceholderText = ""
        Me.Guna2TextBox_dbname.SelectedText = ""
        Me.Guna2TextBox_dbname.ShadowDecoration.Parent = Me.Guna2TextBox_dbname
        Me.Guna2TextBox_dbname.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox_dbname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_dbname.TabIndex = 2
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(27, 285)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(30, 21)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "IP:"
        '
        'Guna2TextBox_ip
        '
        Me.Guna2TextBox_ip.Animated = True
        Me.Guna2TextBox_ip.BorderRadius = 8
        Me.Guna2TextBox_ip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_ip.DefaultText = ""
        Me.Guna2TextBox_ip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_ip.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_ip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_ip.DisabledState.Parent = Me.Guna2TextBox_ip
        Me.Guna2TextBox_ip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_ip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_ip.FocusedState.Parent = Me.Guna2TextBox_ip
        Me.Guna2TextBox_ip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_ip.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_ip.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_ip.HoverState.Parent = Me.Guna2TextBox_ip
        Me.Guna2TextBox_ip.Location = New System.Drawing.Point(148, 277)
        Me.Guna2TextBox_ip.Name = "Guna2TextBox_ip"
        Me.Guna2TextBox_ip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_ip.PlaceholderText = ""
        Me.Guna2TextBox_ip.SelectedText = ""
        Me.Guna2TextBox_ip.ShadowDecoration.Parent = Me.Guna2TextBox_ip
        Me.Guna2TextBox_ip.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox_ip.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_ip.TabIndex = 2
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(27, 340)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(48, 21)
        Me.Guna2HtmlLabel3.TabIndex = 1
        Me.Guna2HtmlLabel3.Text = "端口:"
        '
        'Guna2TextBox_port
        '
        Me.Guna2TextBox_port.Animated = True
        Me.Guna2TextBox_port.BorderRadius = 8
        Me.Guna2TextBox_port.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_port.DefaultText = ""
        Me.Guna2TextBox_port.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_port.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_port.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_port.DisabledState.Parent = Me.Guna2TextBox_port
        Me.Guna2TextBox_port.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_port.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_port.FocusedState.Parent = Me.Guna2TextBox_port
        Me.Guna2TextBox_port.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_port.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_port.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_port.HoverState.Parent = Me.Guna2TextBox_port
        Me.Guna2TextBox_port.Location = New System.Drawing.Point(148, 332)
        Me.Guna2TextBox_port.Name = "Guna2TextBox_port"
        Me.Guna2TextBox_port.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_port.PlaceholderText = ""
        Me.Guna2TextBox_port.SelectedText = ""
        Me.Guna2TextBox_port.ShadowDecoration.Parent = Me.Guna2TextBox_port
        Me.Guna2TextBox_port.Size = New System.Drawing.Size(51, 36)
        Me.Guna2TextBox_port.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_port.TabIndex = 2
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(399, 340)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(84, 21)
        Me.Guna2HtmlLabel4.TabIndex = 1
        Me.Guna2HtmlLabel4.Text = "服务名称:"
        '
        'Guna2TextBox_servicename
        '
        Me.Guna2TextBox_servicename.Animated = True
        Me.Guna2TextBox_servicename.BorderRadius = 8
        Me.Guna2TextBox_servicename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_servicename.DefaultText = ""
        Me.Guna2TextBox_servicename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_servicename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_servicename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_servicename.DisabledState.Parent = Me.Guna2TextBox_servicename
        Me.Guna2TextBox_servicename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_servicename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_servicename.FocusedState.Parent = Me.Guna2TextBox_servicename
        Me.Guna2TextBox_servicename.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_servicename.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_servicename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_servicename.HoverState.Parent = Me.Guna2TextBox_servicename
        Me.Guna2TextBox_servicename.Location = New System.Drawing.Point(520, 332)
        Me.Guna2TextBox_servicename.Name = "Guna2TextBox_servicename"
        Me.Guna2TextBox_servicename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_servicename.PlaceholderText = ""
        Me.Guna2TextBox_servicename.SelectedText = ""
        Me.Guna2TextBox_servicename.ShadowDecoration.Parent = Me.Guna2TextBox_servicename
        Me.Guna2TextBox_servicename.Size = New System.Drawing.Size(51, 36)
        Me.Guna2TextBox_servicename.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_servicename.TabIndex = 2
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(398, 231)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(66, 21)
        Me.Guna2HtmlLabel5.TabIndex = 1
        Me.Guna2HtmlLabel5.Text = "用户名:"
        '
        'Guna2TextBox_username
        '
        Me.Guna2TextBox_username.Animated = True
        Me.Guna2TextBox_username.BorderRadius = 8
        Me.Guna2TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_username.DefaultText = ""
        Me.Guna2TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_username.DisabledState.Parent = Me.Guna2TextBox_username
        Me.Guna2TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_username.FocusedState.Parent = Me.Guna2TextBox_username
        Me.Guna2TextBox_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_username.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_username.HoverState.Parent = Me.Guna2TextBox_username
        Me.Guna2TextBox_username.Location = New System.Drawing.Point(519, 223)
        Me.Guna2TextBox_username.Name = "Guna2TextBox_username"
        Me.Guna2TextBox_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_username.PlaceholderText = ""
        Me.Guna2TextBox_username.SelectedText = ""
        Me.Guna2TextBox_username.ShadowDecoration.Parent = Me.Guna2TextBox_username
        Me.Guna2TextBox_username.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_username.TabIndex = 2
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(398, 285)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(48, 21)
        Me.Guna2HtmlLabel6.TabIndex = 1
        Me.Guna2HtmlLabel6.Text = "密码:"
        '
        'Guna2TextBox_password
        '
        Me.Guna2TextBox_password.Animated = True
        Me.Guna2TextBox_password.BorderRadius = 8
        Me.Guna2TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_password.DefaultText = ""
        Me.Guna2TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_password.DisabledState.Parent = Me.Guna2TextBox_password
        Me.Guna2TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_password.FocusedState.Parent = Me.Guna2TextBox_password
        Me.Guna2TextBox_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_password.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_password.HoverState.Parent = Me.Guna2TextBox_password
        Me.Guna2TextBox_password.Location = New System.Drawing.Point(520, 277)
        Me.Guna2TextBox_password.Name = "Guna2TextBox_password"
        Me.Guna2TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Guna2TextBox_password.PlaceholderText = ""
        Me.Guna2TextBox_password.SelectedText = ""
        Me.Guna2TextBox_password.ShadowDecoration.Parent = Me.Guna2TextBox_password
        Me.Guna2TextBox_password.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox_password.TabIndex = 2
        '
        'Guna2Button_save
        '
        Me.Guna2Button_save.Animated = True
        Me.Guna2Button_save.BorderRadius = 8
        Me.Guna2Button_save.CheckedState.Parent = Me.Guna2Button_save
        Me.Guna2Button_save.CustomImages.Parent = Me.Guna2Button_save
        Me.Guna2Button_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Button_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button_save.ForeColor = System.Drawing.Color.White
        Me.Guna2Button_save.HoverState.Parent = Me.Guna2Button_save
        Me.Guna2Button_save.Location = New System.Drawing.Point(584, 400)
        Me.Guna2Button_save.Name = "Guna2Button_save"
        Me.Guna2Button_save.ShadowDecoration.Parent = Me.Guna2Button_save
        Me.Guna2Button_save.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button_save.TabIndex = 0
        Me.Guna2Button_save.Text = "保存"
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        Me.Guna2DataGridView1.AllowUserToResizeColumns = False
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DataGridView1.ColumnHeadersHeight = 21
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_dbname, Me.Column_ip, Me.Column_port, Me.Column_servicename, Me.Column_username, Me.db_id})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2DataGridView1.MultiSelect = False
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 23
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(721, 189)
        Me.Guna2DataGridView1.TabIndex = 3
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 23
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column_dbname
        '
        Me.Column_dbname.FillWeight = 200.0!
        Me.Column_dbname.HeaderText = "名称"
        Me.Column_dbname.Name = "Column_dbname"
        Me.Column_dbname.ReadOnly = True
        '
        'Column_ip
        '
        Me.Column_ip.HeaderText = "IP"
        Me.Column_ip.Name = "Column_ip"
        Me.Column_ip.ReadOnly = True
        '
        'Column_port
        '
        Me.Column_port.FillWeight = 50.0!
        Me.Column_port.HeaderText = "端口"
        Me.Column_port.Name = "Column_port"
        Me.Column_port.ReadOnly = True
        '
        'Column_servicename
        '
        Me.Column_servicename.FillWeight = 50.0!
        Me.Column_servicename.HeaderText = "服务名称"
        Me.Column_servicename.Name = "Column_servicename"
        Me.Column_servicename.ReadOnly = True
        '
        'Column_username
        '
        Me.Column_username.HeaderText = "用户名"
        Me.Column_username.Name = "Column_username"
        Me.Column_username.ReadOnly = True
        '
        'db_id
        '
        Me.db_id.HeaderText = "db_id"
        Me.db_id.Name = "db_id"
        Me.db_id.ReadOnly = True
        Me.db_id.Visible = False
        '
        'FormDbSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 450)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.Guna2TextBox_port)
        Me.Controls.Add(Me.Guna2TextBox_password)
        Me.Controls.Add(Me.Guna2TextBox_username)
        Me.Controls.Add(Me.Guna2TextBox_servicename)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2TextBox_ip)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2TextBox_dbname)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Button_save)
        Me.Controls.Add(Me.Guna2Button_test)
        Me.Name = "FormDbSetting"
        Me.Text = "数据库"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button_test As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_dbname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_ip As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_port As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_servicename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column_dbname As DataGridViewTextBoxColumn
    Friend WithEvents Column_ip As DataGridViewTextBoxColumn
    Friend WithEvents Column_port As DataGridViewTextBoxColumn
    Friend WithEvents Column_servicename As DataGridViewTextBoxColumn
    Friend WithEvents Column_username As DataGridViewTextBoxColumn
    Friend WithEvents db_id As DataGridViewTextBoxColumn
End Class
