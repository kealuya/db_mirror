Public Class FormMsgShow

    Public Sub ShowMe(c As String)
        TextBox1.Text = c
        Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TextBox1.Text = ""
        Me.Hide()
    End Sub
End Class