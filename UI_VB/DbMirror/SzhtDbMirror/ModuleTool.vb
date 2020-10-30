Module ModuleTool
    Public Sub WriteLog(ByVal Msg As String)

        Dim varAppPath As String
        varAppPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "log"
        System.IO.Directory.CreateDirectory(varAppPath)

        Dim head As String
        head = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString()
        head = head + ":" + System.DateTime.Now.Second.ToString() + ":" + System.DateTime.Now.Millisecond.ToString()
        Msg = head + System.Environment.NewLine + Msg + System.Environment.NewLine

        Dim strDate As String
        strDate = System.DateTime.Now.ToString("yyyyMMdd")
        Dim strFile As String
        strFile = varAppPath + "\" + strDate + ".log"
        Dim SW As System.IO.StreamWriter
        SW = New System.IO.StreamWriter(strFile, True)

        SW.WriteLine(Msg)
        SW.Flush()
        SW.Close()

    End Sub

    Public Function RunCmd(ByVal strCMD As String) As String
        Dim p As New Process
        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + strCMD
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()
        Dim result As String = p.StandardOutput.ReadToEnd()
        p.Close()
        Return result
    End Function

    Public Function NVL(ob As String) As String
        If IsNothing(ob) Or ob = "" Then
            Return ""
        End If
        Return CStr(ob)
    End Function
    Public Function DicNVL(dic As Dictionary(Of String, String), key As String) As String
        If dic.ContainsKey(key) Then
            Return dic.Item(key)
        Else
            Return ""
        End If
    End Function
End Module

