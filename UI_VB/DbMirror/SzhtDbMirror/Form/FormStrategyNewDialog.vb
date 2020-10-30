Public Class FormStrategyNewDialog



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Dim fs As FormStrategy = Me.Owner
        fs.Guna2DataGridView1.Rows.Add(New String() {Guna2TextBox_desc.Text, "", "", "", ""})
        Guna2TextBox_desc.Text = ""
        Me.Close()
    End Sub
End Class