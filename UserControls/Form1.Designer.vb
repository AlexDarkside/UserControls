<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RjTextBox1 = New UserControls.RJTextBox()
        Me.RjButton3 = New UserControls.CustomControls.RJControls.RJButton()
        Me.RjButton2 = New UserControls.CustomControls.RJControls.RJButton()
        Me.RjButton1 = New UserControls.CustomControls.RJControls.RJButton()
        Me.RjTextBox2 = New UserControls.RJTextBox()
        Me.SuspendLayout()
        '
        'RjTextBox1
        '
        Me.RjTextBox1.BackColor = System.Drawing.Color.White
        Me.RjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink
        Me.RjTextBox1.BorderRadius = 5
        Me.RjTextBox1.BorderSize = 2
        Me.RjTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox1.Location = New System.Drawing.Point(45, 58)
        Me.RjTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox1.Multiline = False
        Me.RjTextBox1.Name = "RjTextBox1"
        Me.RjTextBox1.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox1.PasswordChar = False
        Me.RjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox1.PlaceholderText = "PlaseHolder"
        Me.RjTextBox1.Size = New System.Drawing.Size(250, 34)
        Me.RjTextBox1.TabIndex = 3
        Me.RjTextBox1.Texts = ""
        Me.RjTextBox1.UnderlinedStyle = False
        '
        'RjButton3
        '
        Me.RjButton3.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjButton3.BorderRadius = 0
        Me.RjButton3.BorderSize = -1
        Me.RjButton3.EffectMousehover = False
        Me.RjButton3.FlatAppearance.BorderSize = 0
        Me.RjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RjButton3.ForeColor = System.Drawing.Color.White
        Me.RjButton3.Location = New System.Drawing.Point(448, 104)
        Me.RjButton3.Name = "RjButton3"
        Me.RjButton3.Size = New System.Drawing.Size(150, 40)
        Me.RjButton3.TabIndex = 2
        Me.RjButton3.Text = "RjButton3"
        Me.RjButton3.TextColor = System.Drawing.Color.White
        Me.RjButton3.UseVisualStyleBackColor = False
        '
        'RjButton2
        '
        Me.RjButton2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjButton2.BorderRadius = 5
        Me.RjButton2.BorderSize = 4
        Me.RjButton2.EffectMousehover = True
        Me.RjButton2.FlatAppearance.BorderSize = 0
        Me.RjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RjButton2.ForeColor = System.Drawing.Color.White
        Me.RjButton2.Location = New System.Drawing.Point(448, 12)
        Me.RjButton2.Name = "RjButton2"
        Me.RjButton2.Size = New System.Drawing.Size(150, 40)
        Me.RjButton2.TabIndex = 1
        Me.RjButton2.Text = "RjButton2"
        Me.RjButton2.TextColor = System.Drawing.Color.White
        Me.RjButton2.UseVisualStyleBackColor = False
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjButton1.BorderRadius = 5
        Me.RjButton1.BorderSize = 4
        Me.RjButton1.EffectMousehover = False
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(448, 58)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(150, 40)
        Me.RjButton1.TabIndex = 0
        Me.RjButton1.Text = "RjButton1"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'RjTextBox2
        '
        Me.RjTextBox2.BackColor = System.Drawing.Color.White
        Me.RjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink
        Me.RjTextBox2.BorderRadius = 5
        Me.RjTextBox2.BorderSize = 2
        Me.RjTextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox2.Location = New System.Drawing.Point(45, 104)
        Me.RjTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox2.Multiline = False
        Me.RjTextBox2.Name = "RjTextBox2"
        Me.RjTextBox2.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox2.PasswordChar = False
        Me.RjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox2.PlaceholderText = "PlaseHolder"
        Me.RjTextBox2.Size = New System.Drawing.Size(250, 34)
        Me.RjTextBox2.TabIndex = 4
        Me.RjTextBox2.Texts = ""
        Me.RjTextBox2.UnderlinedStyle = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(610, 397)
        Me.Controls.Add(Me.RjTextBox2)
        Me.Controls.Add(Me.RjTextBox1)
        Me.Controls.Add(Me.RjButton3)
        Me.Controls.Add(Me.RjButton2)
        Me.Controls.Add(Me.RjButton1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RjButton1 As UserControls.CustomControls.RJControls.RJButton
    Friend WithEvents RjButton2 As UserControls.CustomControls.RJControls.RJButton
    Friend WithEvents RjButton3 As UserControls.CustomControls.RJControls.RJButton
    Friend WithEvents RjTextBox1 As UserControls.RJTextBox
    Friend WithEvents RjTextBox2 As UserControls.RJTextBox
   

End Class
