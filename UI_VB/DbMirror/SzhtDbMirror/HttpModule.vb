Imports System.IO
Imports System.Net
Imports System.Text

Module HttpModule

    Public Function GetData(ByVal url As String, ByVal data As String) As String

        Dim request As HttpWebRequest = WebRequest.Create(url + "?" + data)
        request.Method = "GET"
        Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
        Return sr.ReadToEnd
    End Function

    Public Function PostData(ByVal url As String, ByVal data As String) As String

        ServicePointManager.Expect100Continue = False
        Dim request As HttpWebRequest = WebRequest.Create(url)
        '//Post请求方式
        request.Method = "POST"

        '内容类型
        request.ContentType = "application/json; charset=utf-8"
        request.Accept = "application/json; charset=UTF-8"
        '将URL编码后的字符串转化为字节
        Dim encoding As New UTF8Encoding()
        Dim bys As Byte() = encoding.GetBytes(data)
        '设置请求的 ContentLength 
        request.ContentLength = bys.Length

        Dim returnString As String
        Try
            '获得请 求流
            Dim newStream As Stream = request.GetRequestStream()
            newStream.Write(bys, 0, bys.Length)
            newStream.Close()

            Dim sr As StreamReader
            '获得响应流

            sr = New StreamReader(request.GetResponse().GetResponseStream)
            returnString = sr.ReadToEnd
        Catch ex As Exception
            returnString = "{""success"":false,""msg"":"""",""data"":null}"
        End Try

        Dim r As String = Replace(returnString, "\", "")
        r = Replace(r, """{", "{")
        r = Replace(r, "}""", "}")
        Debug.Print(r)

        Return r
    End Function

End Module
