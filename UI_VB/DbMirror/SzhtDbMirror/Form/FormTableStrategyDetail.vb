Imports Newtonsoft.Json.Linq

Public Class FormTableStrategyDetail

    Private id As String

    Public Sub ShowMe(id As String)

        Me.id = id
        Me.Show()
    End Sub

    Private Sub FormTableStrategyDetail_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sid = CInt(id)

        Dim js As JObject = New JObject From {
            New JProperty("backup_id", sid)
        }
        Console.WriteLine(js.ToString)
        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/supply/supply_tbl_info", js.ToString)
        Console.WriteLine(resp)
        Dim jo = JObject.Parse(resp)
        Dim s = jo.SelectToken("success")
        If Not s = "True" Then
            MsgBox(jo.SelectToken("msg"), Title:="提示")
            Exit Sub
        End If

        Dim data = jo.SelectToken("data")

        For Each i In data.Children
            Dim table_name = i.SelectToken("table_name")
            Dim key = i.SelectToken("key")

            Dim strategy = i.SelectToken("strategy")

            Dim isCopy = strategy.SelectToken("isCopy")
            Dim smartCopy = strategy.SelectToken("smartCopy")
            Dim hasPkForIncrement = strategy.SelectToken("hasPkForIncrement")
            Dim cleanCopy = strategy.SelectToken("cleanCopy")
            Me.Guna2DataGridView1.Rows.Add(New String() {table_name, CBool(isCopy), CBool(smartCopy), CBool(hasPkForIncrement), CBool(cleanCopy), key})

        Next

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'id，表名称 更新 {"isCopy":true,"hasPkForIncrement":true,"cleanCopy":false,"smartCopy":true}
        Dim ja = New JArray
        For Each r In Me.Guna2DataGridView1.Rows

            Dim jo2 = New JObject From {
                New JProperty("table_name", r.Cells.Item(0).Value),
                New JProperty("strategy",
                              New JObject From {
                                    New JProperty("isCopy", CBool(r.Cells.Item(1).Value)),
                                    New JProperty("smartCopy", CBool(r.Cells.Item(2).Value)),
                                    New JProperty("hasPkForIncrement", CBool(r.Cells.Item(3).Value)),
                                    New JProperty("cleanCopy", CBool(r.Cells.Item(4).Value))
                               })
            }
            ja.Add(jo2)
        Next

        Dim jj = New JObject From {
                New JProperty("backup_id", CInt(id)),
                New JProperty("data", ja)
        }

        'Console.WriteLine(jj.ToString)
        Dim resp As String = HttpModule.PostData(BASE_URL + "v1/setting/update_backup_table_setting", jj.ToString)
        Console.WriteLine(resp)
        Dim jo = JObject.Parse(resp)
        Dim s = jo.SelectToken("success")
        If Not s = "True" Then
            MsgBox(jo.SelectToken("msg"), Title:="提示")
            Exit Sub
        End If

        MsgBox("更新成功", Title:="提示")


    End Sub

    Private Sub Guna2Button_close_Click(sender As Object, e As EventArgs) Handles Guna2Button_close.Click
        Me.Close()
    End Sub
End Class