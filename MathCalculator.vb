'Public Class MathCalculator
'    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

'    End Sub

'    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

'    End Sub

'    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

'    End Sub

'    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        Dim input, input2, output As Double
'        input = TextBox1.Text
'        input2 = TextBox2.Text

'        TextBox3.Text = input & "+" & input2



'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Dim input, input2, output As Double
'        input = TextBox1.Text
'        input2 = TextBox2.Text

'        If (Button1.Text = "+") Then
'            output = input + input2
'            TextBox9.Text = output
'        ElseIf (Button5.Text = "-") Then
'            input2 = -TextBox2.Text
'            output = input + input2
'            TextBox9.Text = output
'        ElseIf (Button4.Text = "X") Then
'            output = (input * input2)
'            TextBox9.Text = output
'        ElseIf (Button4.Text = "/") Then
'            output = (input / input2)
'            TextBox9.Text = output
'        End If

'    End Sub

'    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
'        Dim input, input2 As Double
'        input = TextBox1.Text
'        input2 = TextBox2.Text

'        TextBox3.Text = input & "-" & input2
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'        Dim input, input2 As Double
'        input = TextBox1.Text
'        input2 = TextBox2.Text

'        TextBox3.Text = input & "X" & input2
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        Dim input, input2, output As Double
'        input = TextBox1.Text
'        input2 = TextBox2.Text

'        TextBox3.Text = input & "/" & input2
'    End Sub

'    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
'        Dim close As New LayoutOfAssignment
'        close.Show()
'        Me.Hide()
'    End Sub
'End Class

Public Class MathCalculator
    ' Variables to store operands and operator
    Dim firstOperand As Double
    Dim secondOperand As Double
    Dim currentOperator As String

    ' Handle "+" button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        firstOperand = Double.Parse(TextBox1.Text)
        currentOperator = "+" ' Set the operator
        TextBox3.Text = TextBox1.Text & " + " ' Display the operation
    End Sub

    ' Handle "-" button click
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        firstOperand = Double.Parse(TextBox1.Text)
        currentOperator = "-" ' Set the operator
        TextBox3.Text = TextBox1.Text & " - " ' Display the operation
    End Sub

    ' Handle "X" button click
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        firstOperand = Double.Parse(TextBox1.Text)
        currentOperator = "*" ' Set the operator
        TextBox3.Text = TextBox1.Text & " X " ' Display the operation
    End Sub

    ' Handle "/" button click
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        firstOperand = Double.Parse(TextBox1.Text)
        currentOperator = "/" ' Set the operator
        TextBox3.Text = TextBox1.Text & " / " ' Display the operation
    End Sub

    ' Handle "=" button click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Parse the second operand
        secondOperand = Double.Parse(TextBox2.Text)

        Dim result As Double
        ' Perform the operation
        Select Case currentOperator
            Case "+"
                result = firstOperand + secondOperand
            Case "-"
                result = firstOperand - secondOperand
            Case "*"
                result = firstOperand * secondOperand
            Case "/"
                If secondOperand = 0 Then
                    MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                result = firstOperand / secondOperand
            Case Else
                MessageBox.Show("No valid operator selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        ' Display the result in TextBox9
        TextBox9.Text = result.ToString()
        ' Update TextBox3 to show the full calculation
        TextBox3.Text &= TextBox2.Text & " = " & result
    End Sub

    ' Handle "Clear" button click (Optional)
    'Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
    '    TextBox1.Text = ""
    '    TextBox2.Text = ""
    '    TextBox3.Text = ""
    '    TextBox9.Text = ""
    '    firstOperand = 0
    '    secondOperand = 0
    '    currentOperator = ""
    'End Sub

    ' Handle "Close" button click
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim close As New LayoutOfAssignment
        close.Show()
        Me.Hide()
    End Sub
End Class
