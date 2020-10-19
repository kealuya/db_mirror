<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStrategy
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column_strategy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_backup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_db_id_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_db_id_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_strategy_schedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2TextBox_desc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ComboBox_db_id_from = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ComboBox_db_id_to = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox_strategy_schedule = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button_test = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox_backup_id = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 21
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_strategy, Me.Column_backup_id, Me.Column_db_id_from, Me.Column_db_id_to, Me.Column_strategy_schedule})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 23
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(254, 426)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
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
        'Column_strategy
        '
        Me.Column_strategy.HeaderText = "备份策略"
        Me.Column_strategy.Name = "Column_strategy"
        Me.Column_strategy.ReadOnly = True
        Me.Column_strategy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_strategy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_backup_id
        '
        Me.Column_backup_id.HeaderText = "Column_backup_id"
        Me.Column_backup_id.Name = "Column_backup_id"
        Me.Column_backup_id.ReadOnly = True
        Me.Column_backup_id.Visible = False
        '
        'Column_db_id_from
        '
        Me.Column_db_id_from.HeaderText = "Column_db_id_from"
        Me.Column_db_id_from.Name = "Column_db_id_from"
        Me.Column_db_id_from.ReadOnly = True
        Me.Column_db_id_from.Visible = False
        '
        'Column_db_id_to
        '
        Me.Column_db_id_to.HeaderText = "Column_db_id_to"
        Me.Column_db_id_to.Name = "Column_db_id_to"
        Me.Column_db_id_to.ReadOnly = True
        Me.Column_db_id_to.Visible = False
        '
        'Column_strategy_schedule
        '
        Me.Column_strategy_schedule.HeaderText = "Column_strategy_schedule"
        Me.Column_strategy_schedule.Name = "Column_strategy_schedule"
        Me.Column_strategy_schedule.ReadOnly = True
        Me.Column_strategy_schedule.Visible = False
        '
        'Guna2TextBox_desc
        '
        Me.Guna2TextBox_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_desc.DefaultText = ""
        Me.Guna2TextBox_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_desc.DisabledState.Parent = Me.Guna2TextBox_desc
        Me.Guna2TextBox_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_desc.FocusedState.Parent = Me.Guna2TextBox_desc
        Me.Guna2TextBox_desc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_desc.HoverState.Parent = Me.Guna2TextBox_desc
        Me.Guna2TextBox_desc.Location = New System.Drawing.Point(281, 39)
        Me.Guna2TextBox_desc.Name = "Guna2TextBox_desc"
        Me.Guna2TextBox_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_desc.PlaceholderText = ""
        Me.Guna2TextBox_desc.SelectedText = ""
        Me.Guna2TextBox_desc.ShadowDecoration.Parent = Me.Guna2TextBox_desc
        Me.Guna2TextBox_desc.Size = New System.Drawing.Size(452, 36)
        Me.Guna2TextBox_desc.TabIndex = 1
        '
        'Guna2ComboBox_db_id_from
        '
        Me.Guna2ComboBox_db_id_from.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox_db_id_from.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox_db_id_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox_db_id_from.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_db_id_from.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_db_id_from.FocusedState.Parent = Me.Guna2ComboBox_db_id_from
        Me.Guna2ComboBox_db_id_from.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox_db_id_from.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox_db_id_from.HoverState.Parent = Me.Guna2ComboBox_db_id_from
        Me.Guna2ComboBox_db_id_from.ItemHeight = 30
        Me.Guna2ComboBox_db_id_from.ItemsAppearance.Parent = Me.Guna2ComboBox_db_id_from
        Me.Guna2ComboBox_db_id_from.Location = New System.Drawing.Point(281, 120)
        Me.Guna2ComboBox_db_id_from.Name = "Guna2ComboBox_db_id_from"
        Me.Guna2ComboBox_db_id_from.ShadowDecoration.Parent = Me.Guna2ComboBox_db_id_from
        Me.Guna2ComboBox_db_id_from.Size = New System.Drawing.Size(451, 36)
        Me.Guna2ComboBox_db_id_from.TabIndex = 3
        '
        'Guna2ComboBox_db_id_to
        '
        Me.Guna2ComboBox_db_id_to.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox_db_id_to.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox_db_id_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox_db_id_to.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_db_id_to.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_db_id_to.FocusedState.Parent = Me.Guna2ComboBox_db_id_to
        Me.Guna2ComboBox_db_id_to.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox_db_id_to.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox_db_id_to.HoverState.Parent = Me.Guna2ComboBox_db_id_to
        Me.Guna2ComboBox_db_id_to.ItemHeight = 30
        Me.Guna2ComboBox_db_id_to.ItemsAppearance.Parent = Me.Guna2ComboBox_db_id_to
        Me.Guna2ComboBox_db_id_to.Location = New System.Drawing.Point(281, 203)
        Me.Guna2ComboBox_db_id_to.Name = "Guna2ComboBox_db_id_to"
        Me.Guna2ComboBox_db_id_to.ShadowDecoration.Parent = Me.Guna2ComboBox_db_id_to
        Me.Guna2ComboBox_db_id_to.Size = New System.Drawing.Size(451, 36)
        Me.Guna2ComboBox_db_id_to.TabIndex = 3
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(281, 12)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(111, 21)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "备份策略描述"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(281, 93)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(165, 21)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "来源数据库（from）"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(281, 256)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(75, 21)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "备份频率"
        '
        'Guna2ComboBox_strategy_schedule
        '
        Me.Guna2ComboBox_strategy_schedule.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox_strategy_schedule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox_strategy_schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox_strategy_schedule.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_strategy_schedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox_strategy_schedule.FocusedState.Parent = Me.Guna2ComboBox_strategy_schedule
        Me.Guna2ComboBox_strategy_schedule.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox_strategy_schedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox_strategy_schedule.HoverState.Parent = Me.Guna2ComboBox_strategy_schedule
        Me.Guna2ComboBox_strategy_schedule.ItemHeight = 30
        Me.Guna2ComboBox_strategy_schedule.ItemsAppearance.Parent = Me.Guna2ComboBox_strategy_schedule
        Me.Guna2ComboBox_strategy_schedule.Location = New System.Drawing.Point(281, 283)
        Me.Guna2ComboBox_strategy_schedule.Name = "Guna2ComboBox_strategy_schedule"
        Me.Guna2ComboBox_strategy_schedule.ShadowDecoration.Parent = Me.Guna2ComboBox_strategy_schedule
        Me.Guna2ComboBox_strategy_schedule.Size = New System.Drawing.Size(210, 36)
        Me.Guna2ComboBox_strategy_schedule.TabIndex = 3
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(281, 176)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(147, 21)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "目标数据库（to）"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(575, 245)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(157, 17)
        Me.Guna2HtmlLabel5.TabIndex = 5
        Me.Guna2HtmlLabel5.Text = "请准确确认数据备份走向"
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
        Me.Guna2Button_save.Location = New System.Drawing.Point(445, 348)
        Me.Guna2Button_save.Name = "Guna2Button_save"
        Me.Guna2Button_save.ShadowDecoration.Parent = Me.Guna2Button_save
        Me.Guna2Button_save.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button_save.TabIndex = 6
        Me.Guna2Button_save.Text = "表结构拷贝"
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
        Me.Guna2Button_test.Location = New System.Drawing.Point(281, 348)
        Me.Guna2Button_test.Name = "Guna2Button_test"
        Me.Guna2Button_test.ShadowDecoration.Parent = Me.Guna2Button_test
        Me.Guna2Button_test.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button_test.TabIndex = 7
        Me.Guna2Button_test.Text = "新建备份策略"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 8
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(609, 348)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "表策略详情"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderRadius = 8
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(609, 402)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button2.TabIndex = 6
        Me.Guna2Button2.Text = "保存"
        '
        'Guna2TextBox_backup_id
        '
        Me.Guna2TextBox_backup_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox_backup_id.DefaultText = ""
        Me.Guna2TextBox_backup_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox_backup_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox_backup_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_backup_id.DisabledState.Parent = Me.Guna2TextBox_backup_id
        Me.Guna2TextBox_backup_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox_backup_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_backup_id.FocusedState.Parent = Me.Guna2TextBox_backup_id
        Me.Guna2TextBox_backup_id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox_backup_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox_backup_id.HoverState.Parent = Me.Guna2TextBox_backup_id
        Me.Guna2TextBox_backup_id.Location = New System.Drawing.Point(281, 402)
        Me.Guna2TextBox_backup_id.Name = "Guna2TextBox_backup_id"
        Me.Guna2TextBox_backup_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox_backup_id.PlaceholderText = ""
        Me.Guna2TextBox_backup_id.SelectedText = ""
        Me.Guna2TextBox_backup_id.ShadowDecoration.Parent = Me.Guna2TextBox_backup_id
        Me.Guna2TextBox_backup_id.Size = New System.Drawing.Size(10, 36)
        Me.Guna2TextBox_backup_id.TabIndex = 1
        Me.Guna2TextBox_backup_id.Visible = False
        '
        'FormStrategy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 450)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button_save)
        Me.Controls.Add(Me.Guna2Button_test)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2ComboBox_strategy_schedule)
        Me.Controls.Add(Me.Guna2ComboBox_db_id_to)
        Me.Controls.Add(Me.Guna2ComboBox_db_id_from)
        Me.Controls.Add(Me.Guna2TextBox_backup_id)
        Me.Controls.Add(Me.Guna2TextBox_desc)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStrategy"
        Me.Text = "备份策略"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TextBox_desc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox_db_id_from As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ComboBox_db_id_to As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Column_strategy As DataGridViewTextBoxColumn
    Friend WithEvents Column_backup_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_db_id_from As DataGridViewTextBoxColumn
    Friend WithEvents Column_db_id_to As DataGridViewTextBoxColumn
    Friend WithEvents Column_strategy_schedule As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox_strategy_schedule As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button_test As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox_backup_id As Guna.UI2.WinForms.Guna2TextBox
End Class
