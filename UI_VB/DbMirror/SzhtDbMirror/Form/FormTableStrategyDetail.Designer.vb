<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTableStrategyDetail
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Column_tableName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_isCopy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column_smartCopy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column_hasPkForIncrement = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column_cleanCopy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column_pk = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_tableName, Me.Column_isCopy, Me.Column_smartCopy, Me.Column_hasPkForIncrement, Me.Column_cleanCopy, Me.Column_pk})
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
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 23
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(916, 543)
        Me.Guna2DataGridView1.TabIndex = 1
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
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 23
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2Button1.Location = New System.Drawing.Point(594, 654)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "确认"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 588)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(426, 21)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "备注2：from表数据量少于to表，不进行全表覆盖备份"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 561)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(597, 21)
        Me.Guna2HtmlLabel2.TabIndex = 10
        Me.Guna2HtmlLabel2.Text = "备注1：智能判断备份根据数据库操作log分析，仅数据变动的表，进行备份"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 615)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(534, 21)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "备注3：主键PK备份只针对有主键的表，无主键默认为全表覆盖备份"
        '
        'Column_tableName
        '
        Me.Column_tableName.FillWeight = 350.0!
        Me.Column_tableName.HeaderText = "表名称"
        Me.Column_tableName.Name = "Column_tableName"
        Me.Column_tableName.ReadOnly = True
        Me.Column_tableName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_tableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_isCopy
        '
        Me.Column_isCopy.HeaderText = "是否备份"
        Me.Column_isCopy.Name = "Column_isCopy"
        Me.Column_isCopy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column_smartCopy
        '
        Me.Column_smartCopy.HeaderText = "智能判断备份"
        Me.Column_smartCopy.Name = "Column_smartCopy"
        Me.Column_smartCopy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_smartCopy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column_hasPkForIncrement
        '
        Me.Column_hasPkForIncrement.HeaderText = "根据主键PK备份"
        Me.Column_hasPkForIncrement.Name = "Column_hasPkForIncrement"
        Me.Column_hasPkForIncrement.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column_cleanCopy
        '
        Me.Column_cleanCopy.HeaderText = "全表覆盖备份"
        Me.Column_cleanCopy.Name = "Column_cleanCopy"
        Me.Column_cleanCopy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_cleanCopy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column_pk
        '
        Me.Column_pk.FillWeight = 150.0!
        Me.Column_pk.HeaderText = "主键"
        Me.Column_pk.Name = "Column_pk"
        Me.Column_pk.ReadOnly = True
        '
        'FormTableStrategyDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(940, 703)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTableStrategyDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTableStrategyDetail"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column_tableName As DataGridViewTextBoxColumn
    Friend WithEvents Column_isCopy As DataGridViewCheckBoxColumn
    Friend WithEvents Column_smartCopy As DataGridViewCheckBoxColumn
    Friend WithEvents Column_hasPkForIncrement As DataGridViewCheckBoxColumn
    Friend WithEvents Column_cleanCopy As DataGridViewCheckBoxColumn
    Friend WithEvents Column_pk As DataGridViewTextBoxColumn
End Class
