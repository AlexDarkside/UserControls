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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RjProgressBar1 = New UserControls.RJProgressBar()
        Me.RjRadioButton3 = New UserControls.RJRadioButton()
        Me.RjRadioButton2 = New UserControls.RJRadioButton()
        Me.RjRadioButton1 = New UserControls.RJRadioButton()
        Me.RjComboBox2 = New UserControls.RJComboBox()
        Me.RjComboBox1 = New UserControls.RJComboBox()
        Me.RjTextBox4 = New UserControls.RJTextBox()
        Me.RjTextBox3 = New UserControls.RJTextBox()
        Me.RjTextBox2 = New UserControls.RJTextBox()
        Me.RjTextBox1 = New UserControls.RJTextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.RjTextBox3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 189)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(852, 208)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'RjProgressBar1
        '
        Me.RjProgressBar1.ChannelColor = System.Drawing.Color.LightGray
        Me.RjProgressBar1.ChannelHeight = 10
        Me.RjProgressBar1.ForeBackColor = System.Drawing.Color.RoyalBlue
        Me.RjProgressBar1.ForeColor = System.Drawing.Color.White
        Me.RjProgressBar1.Location = New System.Drawing.Point(498, 149)
        Me.RjProgressBar1.Name = "RjProgressBar1"
        Me.RjProgressBar1.ShowMaximun = False
        Me.RjProgressBar1.ShowValue = UserControls.TextPosition.Sliding
        Me.RjProgressBar1.Size = New System.Drawing.Size(314, 30)
        Me.RjProgressBar1.SliderColor = System.Drawing.Color.SpringGreen
        Me.RjProgressBar1.SliderHeight = 10
        Me.RjProgressBar1.SymbolAfter = ""
        Me.RjProgressBar1.SymbolBefore = ""
        Me.RjProgressBar1.TabIndex = 14
        Me.RjProgressBar1.Value = 30
        '
        'RjRadioButton3
        '
        Me.RjRadioButton3.AutoSize = True
        Me.RjRadioButton3.CheckedColor = System.Drawing.Color.MediumSlateBlue
        Me.RjRadioButton3.Location = New System.Drawing.Point(690, 68)
        Me.RjRadioButton3.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RjRadioButton3.Name = "RjRadioButton3"
        Me.RjRadioButton3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RjRadioButton3.Size = New System.Drawing.Size(135, 23)
        Me.RjRadioButton3.TabIndex = 13
        Me.RjRadioButton3.TabStop = True
        Me.RjRadioButton3.Text = "RjRadioButton3"
        Me.RjRadioButton3.UnCheckedColor = System.Drawing.Color.Gray
        Me.RjRadioButton3.UseVisualStyleBackColor = True
        '
        'RjRadioButton2
        '
        Me.RjRadioButton2.AutoSize = True
        Me.RjRadioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue
        Me.RjRadioButton2.Location = New System.Drawing.Point(690, 39)
        Me.RjRadioButton2.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RjRadioButton2.Name = "RjRadioButton2"
        Me.RjRadioButton2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RjRadioButton2.Size = New System.Drawing.Size(135, 23)
        Me.RjRadioButton2.TabIndex = 12
        Me.RjRadioButton2.TabStop = True
        Me.RjRadioButton2.Text = "RjRadioButton2"
        Me.RjRadioButton2.UnCheckedColor = System.Drawing.Color.Gray
        Me.RjRadioButton2.UseVisualStyleBackColor = True
        '
        'RjRadioButton1
        '
        Me.RjRadioButton1.AutoSize = True
        Me.RjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue
        Me.RjRadioButton1.Location = New System.Drawing.Point(690, 11)
        Me.RjRadioButton1.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RjRadioButton1.Name = "RjRadioButton1"
        Me.RjRadioButton1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RjRadioButton1.Size = New System.Drawing.Size(135, 23)
        Me.RjRadioButton1.TabIndex = 11
        Me.RjRadioButton1.TabStop = True
        Me.RjRadioButton1.Text = "RjRadioButton1"
        Me.RjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray
        Me.RjRadioButton1.UseVisualStyleBackColor = True
        '
        'RjComboBox2
        '
        Me.RjComboBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RjComboBox2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjComboBox2.BorderSize = 1
        Me.RjComboBox2.DataSource = Nothing
        Me.RjComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.RjComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RjComboBox2.ForeColor = System.Drawing.Color.Black
        Me.RjComboBox2.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.RjComboBox2.Items.AddRange(New Object() {"sjnfkjns knfksnfs", "fse", "fse", "f", "se", "fse", "fs"})
        Me.RjComboBox2.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.RjComboBox2.ListTextColor = System.Drawing.Color.Empty
        Me.RjComboBox2.Location = New System.Drawing.Point(460, 84)
        Me.RjComboBox2.MinimumSize = New System.Drawing.Size(200, 30)
        Me.RjComboBox2.Name = "RjComboBox2"
        Me.RjComboBox2.Padding = New System.Windows.Forms.Padding(1)
        Me.RjComboBox2.Size = New System.Drawing.Size(200, 30)
        Me.RjComboBox2.TabIndex = 10
        Me.RjComboBox2.Texts = ""
        '
        'RjComboBox1
        '
        Me.RjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjComboBox1.BorderSize = 1
        Me.RjComboBox1.DataSource = Nothing
        Me.RjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.RjComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RjComboBox1.ForeColor = System.Drawing.Color.DimGray
        Me.RjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.RjComboBox1.Items.AddRange(New Object() {"kjbjfs", "f", "s", "f", "sf", "s", "fs", "f"})
        Me.RjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.RjComboBox1.ListTextColor = System.Drawing.Color.Empty
        Me.RjComboBox1.Location = New System.Drawing.Point(460, 39)
        Me.RjComboBox1.MinimumSize = New System.Drawing.Size(200, 30)
        Me.RjComboBox1.Name = "RjComboBox1"
        Me.RjComboBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.RjComboBox1.Size = New System.Drawing.Size(200, 30)
        Me.RjComboBox1.TabIndex = 9
        Me.RjComboBox1.Texts = ""
        '
        'RjTextBox4
        '
        Me.RjTextBox4.BackColor = System.Drawing.Color.White
        Me.RjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox4.BorderFocusColor = System.Drawing.Color.Blue
        Me.RjTextBox4.BorderRadius = 5
        Me.RjTextBox4.BorderSize = 2
        Me.RjTextBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox4.Location = New System.Drawing.Point(0, 18)
        Me.RjTextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox4.Multiline = False
        Me.RjTextBox4.Name = "RjTextBox4"
        Me.RjTextBox4.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox4.PasswordChar = False
        Me.RjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox4.PlaceholderText = ""
        Me.RjTextBox4.Size = New System.Drawing.Size(250, 34)
        Me.RjTextBox4.TabIndex = 8
        Me.RjTextBox4.Texts = ""
        Me.RjTextBox4.UnderlinedStyle = False
        '
        'RjTextBox3
        '
        Me.RjTextBox3.BackColor = System.Drawing.Color.White
        Me.RjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox3.BorderFocusColor = System.Drawing.Color.Blue
        Me.RjTextBox3.BorderRadius = 0
        Me.RjTextBox3.BorderSize = 2
        Me.RjTextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox3.Location = New System.Drawing.Point(4, 4)
        Me.RjTextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox3.Multiline = False
        Me.RjTextBox3.Name = "RjTextBox3"
        Me.RjTextBox3.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox3.PasswordChar = False
        Me.RjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox3.PlaceholderText = ""
        Me.RjTextBox3.Size = New System.Drawing.Size(250, 34)
        Me.RjTextBox3.TabIndex = 8
        Me.RjTextBox3.Texts = ""
        Me.RjTextBox3.UnderlinedStyle = False
        '
        'RjTextBox2
        '
        Me.RjTextBox2.BackColor = System.Drawing.Color.White
        Me.RjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink
        Me.RjTextBox2.BorderRadius = 5
        Me.RjTextBox2.BorderSize = 2
        Me.RjTextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox2.Location = New System.Drawing.Point(258, 11)
        Me.RjTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox2.Multiline = True
        Me.RjTextBox2.Name = "RjTextBox2"
        Me.RjTextBox2.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox2.PasswordChar = False
        Me.RjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox2.PlaceholderText = "PlaseHolder"
        Me.RjTextBox2.Size = New System.Drawing.Size(183, 143)
        Me.RjTextBox2.TabIndex = 4
        Me.RjTextBox2.Texts = ""
        Me.RjTextBox2.UnderlinedStyle = False
        '
        'RjTextBox1
        '
        Me.RjTextBox1.BackColor = System.Drawing.Color.White
        Me.RjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.RjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink
        Me.RjTextBox1.BorderRadius = 5
        Me.RjTextBox1.BorderSize = 2
        Me.RjTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RjTextBox1.Location = New System.Drawing.Point(0, 60)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 397)
        Me.Controls.Add(Me.RjProgressBar1)
        Me.Controls.Add(Me.RjRadioButton3)
        Me.Controls.Add(Me.RjRadioButton2)
        Me.Controls.Add(Me.RjRadioButton1)
        Me.Controls.Add(Me.RjComboBox2)
        Me.Controls.Add(Me.RjComboBox1)
        Me.Controls.Add(Me.RjTextBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.RjTextBox2)
        Me.Controls.Add(Me.RjTextBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents RjButton2 As RJButton
    Friend WithEvents RjButton3 As RJButton
    Friend WithEvents RjTextBox1 As UserControls.RJTextBox
    Friend WithEvents RjTextBox2 As UserControls.RJTextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RjTextBox3 As UserControls.RJTextBox
    Friend WithEvents RjTextBox4 As UserControls.RJTextBox
    Friend WithEvents RjComboBox1 As UserControls.RJComboBox
    Friend WithEvents RjComboBox2 As UserControls.RJComboBox
    Friend WithEvents RjRadioButton1 As UserControls.RJRadioButton
    Friend WithEvents RjRadioButton2 As UserControls.RJRadioButton
    Friend WithEvents RjRadioButton3 As UserControls.RJRadioButton
    Friend WithEvents RjProgressBar1 As UserControls.RJProgressBar
   

End Class
