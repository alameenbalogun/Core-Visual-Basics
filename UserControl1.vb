Public Class UserControl1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim form1 As New AreaOfATriangle
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim layout As New LayoutOfAssignment
        layout.Show()
        Me.Hide()
    End Sub
End Class
