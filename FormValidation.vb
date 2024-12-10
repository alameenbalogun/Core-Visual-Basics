Public Class FormValidation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Double
        Dim number As Double
        Dim name As String

        ' Validate ID (TextBox1 should contain only numbers)
        If Not Double.TryParse(TextBox1.Text, id) Then
            MessageBox.Show("Please enter a valid numeric ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Exit Sub
        End If

        ' Validate Name (TextBox2 should contain only text)
        name = TextBox2.Text.Trim()
        If String.IsNullOrEmpty(name) OrElse Not name.All(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)) Then
            MessageBox.Show("Please enter a valid name (letters only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Exit Sub
        End If

        ' Validate Number (TextBox3 should contain only numbers)
        If Not Double.TryParse(TextBox3.Text, number) Then
            MessageBox.Show("Please enter a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            Exit Sub
        End If

        ' If all validations pass
        MessageBox.Show($"Validation Successful!{Environment.NewLine}" &
                        $"ID: {id}{Environment.NewLine}" &
                        $"Name: {name}{Environment.NewLine}" &
                        $"Number: {number}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub
End Class
