
Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq

Public Class FormStrategy
    Public dbString_dic As Dictionary(Of String, String)
    Public strategy_dic As Dictionary(Of String, String)
    Private Sub FormStrategy_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '获取dbString
        Dim dbString_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_info", "")
        Dim dbString_js = JObject.Parse(dbString_resp)
        Dim dbString_data = dbString_js.SelectToken("data")
        dbString_dic = New Dictionary(Of String, String)
        For Each i In dbString_data.Children
            dbString_dic.Add(i.SelectToken("db_id"), i.SelectToken("name"))
        Next
        '获取db备份策略
        Dim dbStrategy_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_backup_info", "")
        Dim dbStrategy_js = JObject.Parse(dbStrategy_resp)
        Dim dbStrategy_data = dbStrategy_js.SelectToken("data")
        Guna2DataGridView1.Rows.Clear()

        For Each i In dbStrategy_data.Children

            Dim backup_id = i.SelectToken("backup_id")
            Dim db_id_from = i.SelectToken("db_id_from")
            Dim db_id_to = i.SelectToken("db_id_to")
            Dim desc = i.SelectToken("desc")
            Dim strategy_schedule = i.SelectToken("strategy_schedule")

            Guna2DataGridView1.Rows.Add(New String() {desc, backup_id, db_id_from, db_id_to, strategy_schedule})

        Next

        'Guna2ComboBox_db_id_from init
        Guna2ComboBox_db_id_from.Items.AddRange(dbString_dic.Values.ToArray)

        'Guna2ComboBox_db_id_to init 
        Guna2ComboBox_db_id_to.Items.AddRange(dbString_dic.Values.ToArray)

        'Guna2ComboBox_strategy_schedule init 
        strategy_dic = New Dictionary(Of String, String)
        strategy_dic.Add("0 0 */1 * * ?", "每一小时")
        strategy_dic.Add("0 0 */2 * * ?", "每两小时")
        strategy_dic.Add("0 0 */3 * * ?", "每三小时")
        strategy_dic.Add("0 0 */4 * * ?", "每四小时")
        strategy_dic.Add("0 0 */8 * * ?", "每八小时")
        strategy_dic.Add("0 0 */12 * * ?", "每十二小时")
        strategy_dic.Add("0 0 */24 * * ?", "每二十四小时")
        Guna2ComboBox_strategy_schedule.Items.AddRange(strategy_dic.Values.ToArray)



    End Sub


    Private Sub Guna2DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.RowEnter

        Dim g2dgv As Guna2DataGridView = CType(sender, Guna2DataGridView)
        Dim sr = g2dgv.SelectedRows()
        If sr.Count = 1 Then
            Guna2TextBox_desc.Text = sr.Item(0).Cells.Item(0).Value
            Guna2TextBox_backup_id.Text = sr.Item(0).Cells.Item(1).Value
            Guna2ComboBox_db_id_from.SelectedItem = dbString_dic.Item(sr.Item(0).Cells.Item(2).Value)
            Guna2ComboBox_db_id_to.SelectedItem = dbString_dic.Item(sr.Item(0).Cells.Item(3).Value)
            Guna2ComboBox_strategy_schedule.SelectedItem = strategy_dic.Item(sr.Item(0).Cells.Item(4).Value)
        End If

    End Sub

End Class