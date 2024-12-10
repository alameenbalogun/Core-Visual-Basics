Public Class AreaOfATriangle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim height, base, area As Double
        height = TextBox1.Text
        base = TextBox2.Text



        area = (1 / 2) * base * height
        TextBox3.Text = area



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Closes As New LayoutOfAssignment
        Closes.Show()
        Me.hide()
    End Sub
End Class