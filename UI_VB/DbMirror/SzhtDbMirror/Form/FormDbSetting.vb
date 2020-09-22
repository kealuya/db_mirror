Imports Newtonsoft.Json.Linq
Public Class FormDbSetting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim a As Integer
        'a = Shell("x:\\test.exe",, True)
        'ProgressBar1.Maximum = 100
        'ProgressBar1.Value = 40
        'My.Application.DoEvents()
        'Debug.Print(222)
        'MsgBox("gggg")

        Dim js As JObject
        Dim dd As String = HttpModule.PostData("http://localhost:8080/v1/setting/is_running", "")
        Debug.Print(dd)
        js = JObject.Parse(dd)


        Debug.Print(js.SelectToken("success"))
        ModuleTool.WriteLog("1111111111")

    End Sub
End Class