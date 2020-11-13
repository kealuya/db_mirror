
Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq
Imports System.Threading

Public Class FormStrategy
    Public dbString_dic_key As Dictionary(Of String, String)
    Public dbString_dic_val As Dictionary(Of String, String)
    Public strategy_dic_key As Dictionary(Of String, String)
    Public strategy_dic_val As Dictionary(Of String, String)
    Private Sub FormStrategy_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '获取dbString
        Dim dbString_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_info", "")
        Dim dbString_js = JObject.Parse(dbString_resp)
        Dim dbString_data = dbString_js.SelectToken("data")
        dbString_dic_key = New Dictionary(Of String, String)
        dbString_dic_val = New Dictionary(Of String, String)
        dbString_dic_key.Add("", "")
        For Each i In dbString_data.Children
            dbString_dic_key.Add(i.SelectToken("db_id"), i.SelectToken("name"))
            dbString_dic_val.Add(i.SelectToken("name"), i.SelectToken("db_id"))
        Next
        '获取db备份策略
        Dim dbStrategy_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_backup_info", "")
        Dim dbStrategy_js = JObject.Parse(dbStrategy_resp)
        Dim dbStrategy_data = dbStrategy_js.SelectToken("data")
        Me.Guna2DataGridView1.Rows.Clear()

        For Each i In dbStrategy_data.Children

            Dim backup_id = i.SelectToken("backup_id")
            Dim db_id_from = i.SelectToken("db_id_from")
            Dim db_id_to = i.SelectToken("db_id_to")
            Dim desc = i.SelectToken("desc")
            Dim strategy_schedule = i.SelectToken("strategy_schedule")

            Me.Guna2DataGridView1.Rows.Add(New String() {desc, backup_id, db_id_from, db_id_to, strategy_schedule})

        Next

        'Guna2ComboBox_db_id_from init
        Me.Guna2ComboBox_db_id_from.Items.Clear()
        Me.Guna2ComboBox_db_id_from.Items.AddRange(dbString_dic_key.Values.ToArray)

        'Guna2ComboBox_db_id_to init 
        Me.Guna2ComboBox_db_id_to.Items.Clear()
        Me.Guna2ComboBox_db_id_to.Items.AddRange(dbString_dic_key.Values.ToArray)

        'Guna2ComboBox_strategy_schedule init 
        Dim strategy_keys = New String() {"0 0 */1 * * ?", "0 0 */2 * * ?", "0 0 */3 * * ?", "0 0 */4 * * ?", "0 0 */8 * * ?", "0 0 */12 * * ?", "0 0 */24 * * ?"}
        Dim strategy_vals = New String() {"每一小时", "每两小时", "每三小时", "每四小时", "每八小时", "每十二小时", "每二十四小时"}
        strategy_dic_key = New Dictionary(Of String, String)
        strategy_dic_val = New Dictionary(Of String, String)
        strategy_dic_key.Add("", "")
        For i = 0 To strategy_keys.Length - 1
            strategy_dic_key.Add(strategy_keys(i), strategy_vals(i))
            strategy_dic_val.Add(strategy_vals(i), strategy_keys(i))
        Next
        Me.Guna2ComboBox_strategy_schedule.Items.Clear()
        Me.Guna2ComboBox_strategy_schedule.Items.AddRange(strategy_dic_key.Values.ToArray)

    End Sub


    Private Sub Guna2DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.RowEnter

        Dim g2dgv As Guna2DataGridView = CType(sender, Guna2DataGridView)
        Dim sr = g2dgv.SelectedRows()
        If sr.Count = 1 Then
            Guna2TextBox_desc.Text = sr.Item(0).Cells.Item(0).Value
            Guna2TextBox_backup_id.Text = sr.Item(0).Cells.Item(1).Value
            Guna2ComboBox_db_id_from.SelectedItem = DicNVL(dbString_dic_key, sr.Item(0).Cells.Item(2).Value)
            Guna2ComboBox_db_id_to.SelectedItem = DicNVL(dbString_dic_key, sr.Item(0).Cells.Item(3).Value)
            Guna2ComboBox_strategy_schedule.SelectedItem = DicNVL(strategy_dic_key, sr.Item(0).Cells.Item(4).Value)
        End If
    End Sub

    Private Sub Guna2Button_new_strategy_Click(sender As Object, e As EventArgs) Handles Guna2Button_new_strategy.Click
        ' FormStrategyNewDialog.ShowDialog()

        'Me.Guna2DataGridView1.Rows.Add(New String() {"33333", "", "", "", ""})
        Dim fsnd = New FormStrategyNewDialog()
        fsnd.Owner = Me
        fsnd.ShowDialog()
    End Sub

    Private Sub Guna2Button_to_save_Click(sender As Object, e As EventArgs) Handles Guna2Button_to_save.Click
        If Guna2TextBox_desc.Text = "" Or
          Guna2ComboBox_db_id_from.Text = "" Or
          Guna2ComboBox_db_id_to.Text = "" Or
          Guna2ComboBox_strategy_schedule.Text = "" Then
            MsgBox(Prompt:="请填写全部配置信息", Title:="提示")
            Exit Sub
        End If

        Dim js As JObject = New JObject From {
            New JProperty("desc", Guna2TextBox_desc.Text),
            New JProperty("db_id_from", CInt(dbString_dic_val.Item(Guna2ComboBox_db_id_from.Text))),
            New JProperty("db_id_to", CInt(dbString_dic_val.Item(Guna2ComboBox_db_id_to.Text))),
            New JProperty("strategy_schedule", strategy_dic_val.Item(Guna2ComboBox_strategy_schedule.Text))
        }
        Console.WriteLine(js.ToString)
        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/save_backup_db_setting", js.ToString)
        Dim jo = JObject.Parse(resp)
        Dim s = jo.SelectToken("success")
        If s = "True" Then
            MsgBox(jo.SelectToken("msg"), Title:="提示")
            FormStrategy_Load(Nothing, Nothing)
        Else
            MsgBox(jo.SelectToken("msg"), Title:="提示")
        End If

    End Sub

    Private Sub Guna2DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2DataGridView1.KeyDown
        If e.KeyValue = 46 Then 'del按键
            Dim g2dgv As Guna2DataGridView = CType(sender, Guna2DataGridView)
            Dim sr = g2dgv.SelectedRows()
            If sr.Count = 1 Then
                Dim backup_id As String = sr.Item(0).Cells.Item(1).Value
                Dim desc As String = sr.Item(0).Cells.Item(0).Value

                Dim result = MsgBox("请确认是否删除[" + desc + "]", vbOKCancel, "提示")
                If result = MsgBoxResult.Ok Then

                    Dim js As JObject = New JObject From {New JProperty("backup_id", CInt(backup_id))}
                    Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/del_db_backup", js.ToString)
                    Dim jo = JObject.Parse(resp)
                    Dim s = jo.SelectToken("success")
                    If s = "True" Then
                        MsgBox(jo.SelectToken("msg"), Title:="提示")
                    Else
                        MsgBox(jo.SelectToken("msg"), Title:="提示")
                    End If

                    FormStrategy_Load(Nothing, Nothing)
                End If

            End If
        End If
    End Sub


    Private Sub Guna2Button_table_copy_Click(sender As Object, e As EventArgs) Handles Guna2Button_table_copy.Click

        If Guna2TextBox_desc.Text = "" Or
            Guna2TextBox_backup_id.Text = "" Or
            Guna2ComboBox_db_id_from.Text = "" Or
            Guna2ComboBox_db_id_to.Text = "" Or
            Guna2ComboBox_strategy_schedule.Text = "" Then
            MsgBox(Prompt:="请核实db备份策略信息", Title:="提示")
            Exit Sub
        End If


        Me.Guna2WinProgressIndicator1.Show()
        Me.Guna2WinProgressIndicator1.Start()
        Dim t As Thread
        t = New Thread(AddressOf RunsOnWorkerThread)
        t.Start()

        FormProgressIndicator.ShowDialog()
    End Sub
    '关于vb的线程
    '在A线程的方法，New一个新线程B，并start它。
    '在B中进行业务操作，因为B中不能操作A线程内的对象，所以需要委托方法。
    '委托方法是A中定义的，在B中实例化，并Invoke它，与A线程交互。
    Public Delegate Sub ToThread(resp As String)
    Private Sub RunsOnWorkerThread()

        Dim js As JObject = New JObject From {
            New JProperty("backup_id", CInt(Guna2TextBox_backup_id.Text)）
        }
        Console.WriteLine(js.ToString)

        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/backup/copy_ddl", js.ToString)

        Dim ivo As New ToThread(AddressOf Table_copy_Click)  '实例化委托，并指向被委托的方法
        Invoke(ivo, resp)  '用 Invoke 调用委托，并传递参数       
    End Sub

    Private Sub Table_copy_Click(resp As String)

        FormProgressIndicator.Close()
        Try

            Dim jo = JObject.Parse(resp)
            Dim s = jo.SelectToken("success")
            If s = "True" Then
                MsgBox(CStr(jo.SelectToken("msg")), Title:="提示")
                Dim mm = ""
                For Each m In jo.SelectToken("data").Children
                    mm = mm + CStr(m) + vbCrLf
                Next m

                Dim fms = New FormMsgShow()
                fms.ShowMe(mm)
            Else
                MsgBox(jo.SelectToken("msg"), Title:="提示")
            End If

        Catch ex As Exception
            MsgBox("发生错误：" + ex.ToString, Title:="提示")
        End Try

        Me.Guna2WinProgressIndicator1.Stop()
        Me.Guna2WinProgressIndicator1.Hide()

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If "" = Guna2TextBox_backup_id.Text Then
            MsgBox("请选择一条备份策略")
            Exit Sub
        End If
        Dim ftsd As FormTableStrategyDetail = New FormTableStrategyDetail()
        ftsd.ShowMe(Guna2TextBox_backup_id.Text)
    End Sub
End Class