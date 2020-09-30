
Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq
Public Class FormStrategy
    Private Sub FormStrategy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '获取dbString
        Dim dbString_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_info", "")
        Dim dbString_js = JObject.Parse(dbString_resp)
        Dim dbString_data = dbString_js.SelectToken("data")
        Dim dbString_dic = New Dictionary(Of String, String)
        For Each i In dbString_data.Children
            dbString_dic.Add(i.SelectToken("name"), i.SelectToken("db_id"))
        Next
        '获取db备份策略
        Dim dbStrategy_resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_all_db_backup_info", "")
        Dim dbStrategy_js = JObject.Parse(dbStrategy_resp)
        Dim dbStrategy_data = dbStrategy_js.SelectToken("data")
        For Each i In dbStrategy_data.Children

            Dim ggb As Guna2GroupBox = New Guna2GroupBox()
            ggb.Location = New Point(120, 120)

            Guna2Panel1.Controls.Add(ggb)


        Next









    End Sub

End Class