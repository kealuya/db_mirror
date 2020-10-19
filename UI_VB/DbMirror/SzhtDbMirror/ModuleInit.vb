Imports Newtonsoft.Json.Linq


Module ModuleInit

    Public Const BASE_URL As String = "http://localhost:8080/"

    Public Function RunSzhtDbBak() As Boolean

        Dim count As Integer = 0

        If getSuccess() Then
            Return True
        Else
            Dim path As String = "C:\Users\Administrator\go\src\szht_db_bak\main.exe"
            Shell(path,, False)
            Do
                If getSuccess() Then
                    Return True
                Else
                    Threading.Thread.Sleep(2000)
                    count += 1
                End If

                If count = 5 Then
                    Return False
                End If
            Loop
        End If
    End Function

    Private Function getSuccess() As Boolean
        Dim isRunningString As String = HttpModule.PostData("http://localhost:8080/v1/setting/is_running", "")


        Dim isRunningJson As JObject = JObject.Parse(isRunningString)

        Dim isRunning As Boolean = isRunningJson.SelectToken("success")
        Return isRunning
    End Function


End Module
