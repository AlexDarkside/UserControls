Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

<DefaultEvent("_TextChanged")>
Partial Public Class RJTextBox
    Inherits UserControl

    Private _borderColor As Color = Color.MediumSlateBlue
    Private _borderFocusColor As Color = Color.DarkSlateBlue
    Private _borderSize As Integer = 2
    Private _underlinedStyle As Boolean = False
    Private isFocused As Boolean = False
    Private _borderRadius As Integer = 5
    Private _placeholderColor As Color = Color.DarkGray
    Private _placeholderText As String = ""
    Private isPlaceholder As Boolean = False
    Private isPasswordChar As Boolean = False
    Public Event _TextChanged As EventHandler

    Public Sub New()
        InitializeComponent()
        PlaceholderText = ""
    End Sub

    <Category("RJ Code Advance")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(ByVal value As Color)
            _borderFocusColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)

            If value >= 1 Then
                If BorderRadius > 0 And value >= BorderRadius Then value = BorderRadius - 1
                _borderSize = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property UnderlinedStyle As Boolean
        Get
            Return _UnderlinedStyle
        End Get
        Set(ByVal value As Boolean)
            _underlinedStyle = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PasswordChar As Boolean
        Get
            Return isPasswordChar
        End Get
        Set(ByVal value As Boolean)
            isPasswordChar = value
            If Not isPlaceholder Then textBox1.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Multiline As Boolean
        Get
            Return textBox1.Multiline
        End Get
        Set(ByVal value As Boolean)
            textBox1.Multiline = value
            If value = True Then
                textBox1.ScrollBars = ScrollBars.Vertical
            Else
                textBox1.ScrollBars = ScrollBars.None
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            textBox1.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            textBox1.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            textBox1.Font = value
            If Me.DesignMode Then UpdateControlHeight()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Texts As String
        Get

            If isPlaceholder Then
                Return ""
            Else
                Return textBox1.Text
            End If
        End Get
        Set(ByVal value As String)
            textBox1.Text = value
            SetPlaceholder()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderRadius As Integer
        Get
            Return _BorderRadius
        End Get
        Set(ByVal value As Integer)

            If value >= 0 Then
                If value > 0 And value < 5 Then value = 5
                _borderRadius = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderColor As Color
        Get
            Return _PlaceholderColor
        End Get
        Set(ByVal value As Color)
            _placeholderColor = value
            If isPlaceholder Then Label1.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderText As String
        Get
            Return _PlaceholderText
        End Get
        Set(ByVal value As String)
            _placeholderText = value.Trim
            Label1.Text = ""
            SetPlaceholder()
        End Set
    End Property

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then UpdateControlHeight()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        UpdateControlHeight()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        If borderRadius > 1 Then
            Dim rectBorderSmooth = Me.ClientRectangle
            Dim rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize)
            Dim smoothSize As Integer = If(borderSize > 0, borderSize, 1)

            Using pathBorderSmooth As GraphicsPath = GetFigurePath(rectBorderSmooth, borderRadius)

                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, borderRadius - borderSize)

                    Using penBorderSmooth As Pen = New Pen(Me.Parent.BackColor, smoothSize)

                        Using penBorder As Pen = New Pen(_borderColor, borderSize)
                            Me.Region = New Region(pathBorderSmooth)
                            If borderRadius > 15 Then SetTextBoxRoundedRegion()
                            graph.SmoothingMode = SmoothingMode.AntiAlias
                            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center
                            If isFocused Then penBorder.Color = borderFocusColor

                            If underlinedStyle Then
                                graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                                graph.SmoothingMode = SmoothingMode.None
                                graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                            Else
                                graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                                graph.DrawPath(penBorder, pathBorder)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Else

            Using penBorder As Pen = New Pen(_borderColor, borderSize)
                Me.Region = New Region(Me.ClientRectangle)
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset
                If isFocused Then penBorder.Color = borderFocusColor

                If underlinedStyle Then
                    graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                Else
                    graph.DrawRectangle(penBorder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                End If
            End Using
        End If
    End Sub
    Private topLabel As Integer = 7, fontSizeLabel As Integer = 12
    Private Sub SetPlaceholder()
        If String.IsNullOrWhiteSpace(textBox1.Text) AndAlso placeholderText <> "" Then
            isPlaceholder = True
            Label1.Text = PlaceholderText
            Label1.ForeColor = PlaceholderColor
            If isFocused = False Then
                Label1.Top = topLabel
                Label1.Font = New Font(Label1.Font.FontFamily, fontSizeLabel, Label1.Font.Style)
            End If
          
            ' If isPasswordChar Then textBox1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub RemovePlaceholder()
        If isPlaceholder AndAlso placeholderText <> "" Then
            isPlaceholder = False
            textBox1.Text = ""
            textBox1.ForeColor = Me.ForeColor
            If isPasswordChar Then textBox1.UseSystemPasswordChar = True
            topLabel = Label1.Top
            fontSizeLabel = Label1.Font.Size
            Label1.Top = -3
            Label1.Font = New Font(Label1.Font.FontFamily, Label1.Font.Size - 4, Label1.Font.Style)
        End If
    End Sub

    Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub SetTextBoxRoundedRegion()
        Dim pathTxt As GraphicsPath

        If Multiline Then
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize)
            textBox1.Region = New Region(pathTxt)
        Else
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2)
            textBox1.Region = New Region(pathTxt)
        End If

        pathTxt.Dispose()
    End Sub

    Private Sub UpdateControlHeight()
        If textBox1.Multiline = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            textBox1.Multiline = True
            textBox1.MinimumSize = New Size(0, txtHeight)
            textBox1.Multiline = False
            Me.Height = textBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me._TextChanged, textBox1.TextChanged
        '  If _TextChanged IsNot Nothing Then _TextChanged.Invoke(sender, e)

    End Sub

    Private Sub textBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.Click
        Me.OnClick(e)
    End Sub

    Private Sub textBox1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.MouseEnter
        Me.OnMouseEnter(e)
    End Sub

    Private Sub textBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.MouseLeave
        Me.OnMouseLeave(e)
    End Sub

    Private Sub textBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textBox1.KeyPress
        Me.OnKeyPress(e)
    End Sub

    Private Sub textBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.Enter, Label1.Enter
        isFocused = True
        Me.Invalidate()
        RemovePlaceholder()
    End Sub

    Private Sub textBox1_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.Leave
        isFocused = False
        Me.Invalidate()
        SetPlaceholder()
    End Sub
End Class

