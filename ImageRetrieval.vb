Public Class ImageRetrieval
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Celing")
        ComboBox1.Items.Add("Bulb")
        ComboBox1.Items.Add("Floor")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = 0) Then
            PictureBox1.Image = Image.FromFile("C:\Users\personal\Pictures\lectureHalls\LR.jpg")
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            PictureBox1.Image = Image.FromFile("C:\Users\personal\Pictures\lectureHalls\namadiSambo.jpg")
        Else
            PictureBox1.Image = Image.FromFile("C:\Users\personal\Pictures\lectureHalls\etiosa.jpg")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class