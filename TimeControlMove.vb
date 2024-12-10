Public Class TimeControlMove
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile("C:\Users\personal\Pictures\lectureHalls\etiosa.jpg")
        Timer1.Start()

    End Sub

    Private directionX As Integer = 5 ' Horizontal movement
    Private directionY As Integer = 5 ' Vertical movement

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update position
        PictureBox1.Left += directionX
        PictureBox1.Top += directionY

        ' Check for boundaries (bounce back)
        If PictureBox1.Right >= Me.ClientSize.Width Or PictureBox1.Left <= 0 Then
            directionX = -directionX ' Reverse direction
        End If
        If PictureBox1.Bottom >= Me.ClientSize.Height Or PictureBox1.Top <= 0 Then
            directionY = -directionY ' Reverse direction
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub
End Class