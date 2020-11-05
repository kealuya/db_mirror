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
            'Me.Guna2DataGridView1.Rows.Add(New String() {table_name, CBool(isCopy), CBool(smartCopy), CBool(hasPkForIncrement), CBool(cleanCopy), key})

        Next

    End Sub

End Class