<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaOfATriangle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label1.Location = New System.Drawing.Point(223, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area Of A Triangle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(141, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input the following"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(231, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(231, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Base"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(357, 155)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(360, 213)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label5.Location = New System.Drawing.Point(166, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "The area of the triangle is"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(476, 268)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Button1.Location = New System.Drawing.Point(340, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Button2.Location = New System.Drawing.Point(531, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AreaOfATriangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AreaOfATriangle"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
