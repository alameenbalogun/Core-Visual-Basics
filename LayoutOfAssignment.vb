Public Class LayoutOfAssignment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim area As New AreaOfATriangle
        area.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim converter As New CurrencyConverter
        converter.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim salary As New SalaryCalculator
        salary.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim retrieval As New ImageRetrieval
        retrieval.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim paint As New PaintBrush
        paint.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim time As New TimeControlMove
        time.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim math As New MathCalculator
        math.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim formReg As New FormRegistration
        formReg.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim validate As New FormValidation
        validate.Show()
        Me.Hide()
    End Sub
End Class