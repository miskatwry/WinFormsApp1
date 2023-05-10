Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(0.5) * Val(alas.Text) * Val(tinggi.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        alas.Text = ""
        tinggi.Text = ""
        luas.Text = ""
    End Sub
End Class
