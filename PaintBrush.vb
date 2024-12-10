Public Class PaintBrush
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        isPainting = True
        startPoint = e.Location


    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isPainting Then
            Using g As Graphics = Panel1.CreateGraphics()
                Dim pen As New Pen(brushColor, brushSize)
                g.DrawLine(pen, startPoint, e.Location)
                startPoint = e.Location
            End Using
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isPainting = False
    End Sub


    Private isPainting As Boolean
    Private startPoint As Point
    Private brushColor As Color = Color.Black
    Private brushSize As Integer = 5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub
End Class