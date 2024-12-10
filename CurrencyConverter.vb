Public Class CurrencyConverter
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("USD")
        ComboBox1.Items.Add("NGN")
        ComboBox1.Items.Add("EUR")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Add("USD")
        ComboBox2.Items.Add("NGN")
        ComboBox2.Items.Add("EUR")
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value, output As Double
        value = TextBox1.Text

        If (ComboBox1.SelectedItem = "USD" And ComboBox2.SelectedItem = "NGN") Then
            output = 1700 * value
            MsgBox(output)
        ElseIf (ComboBox1.SelectedItem = "NGN" And ComboBox2.SelectedItem = "USD") Then
            output = 1700 / value
            MsgBox(output)
        ElseIf (ComboBox1.SelectedItem = "EUR" And ComboBox2.SelectedItem = "NGN") Then
            output = 1648 * value
            MsgBox(output)
        ElseIf (ComboBox1.SelectedItem = "NGN" And ComboBox2.SelectedItem = "EUR") Then
            output = 1648 / value
        ElseIf (ComboBox1.SelectedItem = "EUR" And ComboBox2.SelectedItem = "USD") Then
            output = 1.06 * value
            MsgBox(output)
        ElseIf (ComboBox1.SelectedItem = "USD" And ComboBox2.SelectedItem = "EUR") Then
            output = 1.06 / value
            MsgBox(output)
        Else
            MsgBox(value)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub
End Class