Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq
Public Class FormDbSetting
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim a As Integer
        'a = Shell("x:\\test.exe",, True)
        'ProgressBar1.Maximum = 100
        'ProgressBar1.Value = 40
        'My.Application.DoEvents()
        'Debug.Print(222)
        'MsgBox("gggg")

        Dim js As JObject
        Dim dd As String = HttpModule.PostData(BASE_URL + "v1/setting/is_running", "")
        Debug.Print(dd)
        js = JObject.Parse(dd)


        Debug.Print(js.SelectToken("success"))
        ModuleTool.WriteLog("1111111111")

    End Sub

    Private Sub Guna2Button_test_Click(sender As Object, e As EventArgs) Handles Guna2Button_test.Click
        '{
        '    "name":"000.000.000.000_正式DB",
        '    "ip":"000.000.000.000",
        '    "port":"1521",
        '    "service_name":"orcl",
        '    "username":"XXXXX",
        '    "password":"XXXXX"
        '}
        If Guna2TextBox_dbname.Text = "" Or
            Guna2TextBox_ip.Text = "" Or
            Guna2TextBox_port.Text = "" Or
            Guna2TextBox_servicename.Text = "" Or
            Guna2TextBox_username.Text = "" Or
            Guna2TextBox_password.Text = "" Then

            MsgBox(Prompt:="请填写全部配置信息", Title:="提示")

            Exit Sub

        End If

        Dim js As JObject = New JObject From {
            New JProperty("name", Guna2TextBox_dbname.Text),
            New JProperty("ip", Guna2TextBox_ip.Text),
            New JProperty("port", Guna2TextBox_port.Text),
            New JProperty("service_name", Guna2TextBox_servicename.Text),
            New JProperty("username", Guna2TextBox_username.Text),
            New JProperty("password", Guna2TextBox_password.Text)
        }
        Console.WriteLine(js.ToString)
        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/test_db", js.ToString)
        Dim jo = JObject.Parse(resp)
        Dim s = jo.SelectToken("success")
        If s = "true" Then
            MsgBox(jo.SelectToken("msg"), Title:="提示")
        Else
            MsgBox(jo.SelectToken("msg"), Title:="提示")
        End If


    End Sub

    Private Sub FormDbSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_info", "")
        Dim js = JObject.Parse(resp)
        Dim data = js.SelectToken("data")
        Guna2DataGridView1.Rows.Clear()
        For Each i In data.Children
            Guna2DataGridView1.Rows.Add(New String() {i.SelectToken("name"), i.SelectToken("ip"), i.SelectToken("port"),
                                        i.SelectToken("service_name"), i.SelectToken("username")， i.SelectToken("db_id")})
        Next


    End Sub

    Private Sub Guna2DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.RowEnter

        Dim g2dgv As Guna2DataGridView = CType(sender, Guna2DataGridView)
        Dim sr = g2dgv.SelectedRows()
        If sr.Count = 1 Then
            Guna2TextBox_dbname.Text = sr.Item(0).Cells.Item(0).Value
            Guna2TextBox_ip.Text = sr.Item(0).Cells.Item(1).Value
            Guna2TextBox_port.Text = sr.Item(0).Cells.Item(2).Value
            Guna2TextBox_servicename.Text = sr.Item(0).Cells.Item(3).Value
            Guna2TextBox_username.Text = sr.Item(0).Cells.Item(4).Value
            Guna2TextBox_password.Text = ""
        End If

    End Sub

    Private Sub Guna2Button_save_Click(sender As Object, e As EventArgs) Handles Guna2Button_save.Click
        If Guna2TextBox_dbname.Text = "" Or
            Guna2TextBox_ip.Text = "" Or
            Guna2TextBox_port.Text = "" Or
            Guna2TextBox_servicename.Text = "" Or
            Guna2TextBox_username.Text = "" Or
            Guna2TextBox_password.Text = "" Then

            MsgBox(Prompt:="请填写全部配置信息", Title:="提示")

            Exit Sub

        End If

        Dim js As JObject = New JObject From {
            New JProperty("name", Guna2TextBox_dbname.Text),
            New JProperty("ip", Guna2TextBox_ip.Text),
            New JProperty("port", Guna2TextBox_port.Text),
            New JProperty("service_name", Guna2TextBox_servicename.Text),
            New JProperty("username", Guna2TextBox_username.Text),
            New JProperty("password", Guna2TextBox_password.Text)
        }
        Console.WriteLine(js.ToString)
        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/save_db_setting", js.ToString)
        Dim jo = JObject.Parse(resp)
        Dim s = jo.SelectToken("success")
        If s = "True" Then
            MsgBox(jo.SelectToken("msg"), Title:="提示")
        Else
            MsgBox(jo.SelectToken("msg"), Title:="提示")
        End If

        FormDbSetting_Load(Nothing, Nothing)

    End Sub



    Private Sub Guna2DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2DataGridView1.KeyDown
        If e.KeyValue = 46 Then 'del按键
            Dim g2dgv As Guna2DataGridView = CType(sender, Guna2DataGridView)
            Dim sr = g2dgv.SelectedRows()
            If sr.Count = 1 Then
                Dim db_id As String = sr.Item(0).Cells.Item(5).Value
                Dim dbname As String = sr.Item(0).Cells.Item(0).Value

                Dim result = MsgBox("请确认是否删除[" + dbname + "]", vbOKCancel, "提示")
                If result = MsgBoxResult.Ok Then


                    Dim js As JObject = New JObject From {New JProperty("db_id", CInt(db_id))}

                    Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/del_db_setting", js.ToString)
                    Dim jo = JObject.Parse(resp)
                    Dim s = jo.SelectToken("success")
                    If s = "true" Then
                        MsgBox(jo.SelectToken("msg"), Title:="提示")
                    Else
                        MsgBox(jo.SelectToken("msg"), Title:="提示")
                    End If

                    FormDbSetting_Load(Nothing, Nothing)
                End If

            End If
        End If
    End Sub
End Class