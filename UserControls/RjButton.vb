Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Namespace CustomControls.RJControls
    Public Class RJButton
        Inherits Button

        Private _borderSize As Integer = 0
        Private _borderRadius As Integer = 0
        Private _borderColor As Color = Color.PaleVioletRed
        Private _effect As Boolean = False

        <Category("RJ Code Advance")>
        Public Property BorderSize As Integer
            Get
                Return _borderSize
            End Get
            Set(ByVal value As Integer)
                If value >= _borderRadius And _borderRadius > 0 Then
                    value = _borderRadius - 1
                    _borderSize = _borderRadius - 1
                Else
                    _borderSize = value
                End If

                Me.Invalidate()
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property BorderRadius As Integer
            Get
                Return _borderRadius
            End Get
            Set(ByVal value As Integer)
                _borderRadius = value
                Me.Invalidate()
            End Set
        End Property

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
        Public Property BackgroundColor As Color
            Get
                Return Me.BackColor
            End Get
            Set(ByVal value As Color)
                Me.BackColor = value
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property TextColor As Color
            Get
                Return Me.ForeColor
            End Get
            Set(ByVal value As Color)
                Me.ForeColor = value
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property EffectMousehover As Boolean
            Get
                Return _effect
            End Get
            Set(value As Boolean)
                _effect = value
            End Set
        End Property

        Public Sub New()
            Me.FlatStyle = FlatStyle.Flat
            Me.FlatAppearance.BorderSize = 0
            Me.Size = New Size(150, 40)
            Me.BackColor = Color.MediumSlateBlue
            Me.ForeColor = Color.White
            Me.Font = New Font("Times New Roman", 12, FontStyle.Bold)
            AddHandler Me.Resize, New EventHandler(AddressOf Button_Resize)
            AddHandler Me.MouseHover, New EventHandler(AddressOf Button_MouseHover)
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

        Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
            MyBase.OnPaint(pevent)
            Dim rectSurface As Rectangle = Me.ClientRectangle
            Dim rectBorder As Rectangle = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize)
            Dim smoothSize As Integer = 2
            If _borderSize >= _borderRadius And _borderRadius > 0 Then BorderSize = _borderRadius - 1
            If _borderSize > 0 Then smoothSize = _borderSize

            If _borderRadius > 2 Then

                Using pathSurface As GraphicsPath = GetFigurePath(rectSurface, _borderRadius)

                    Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, _borderRadius - _borderSize)

                        Using penSurface As Pen = New Pen(Me.Parent.BackColor, smoothSize)

                            Using penBorder As Pen = New Pen(_borderColor, _borderSize)
                                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                Me.Region = New Region(pathSurface)
                                pevent.Graphics.DrawPath(penSurface, pathSurface)
                                If _borderSize >= 1 Then pevent.Graphics.DrawPath(penBorder, pathBorder)
                            End Using
                        End Using
                    End Using
                End Using
            Else
                pevent.Graphics.SmoothingMode = SmoothingMode.None
                Me.Region = New Region(rectSurface)

                If _borderSize >= 1 Then

                    Using penBorder As Pen = New Pen(_borderColor, _borderSize)
                        penBorder.Alignment = PenAlignment.Inset
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                    End Using
                End If
            End If
            _h = Me.Width
            _l = Me.Width
            _t = Me.Top
            l = Me.Left
        End Sub


        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            AddHandler Me.Parent.BackColorChanged, New EventHandler(AddressOf Container_BackColorChanged)
        End Sub

        Private Sub Container_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Invalidate()
        End Sub

        Private Sub Button_Resize(ByVal sender As Object, ByVal e As EventArgs)
            If _borderRadius > Me.Height Then _borderRadius = Me.Height
        End Sub
        Private _h = Me.Width, _l = Me.Width, _t = Me.Top, l = Me.Left
        Private Async Sub Button_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
            BorderSize = 0
            BorderColor = Color.Black
            For i = 0 To 5
                'Await Task.Delay(1)
                'If Me.Width <= _l + 5 Then Me.Width += 1
                'If Me.Height <= _h + 5 Then Me.Height += 1
                'If Me.Top >= _t - 5 Then Me.Top -= 1
                'If Me.Left >= l - 5 Then Me.Left -= 1


                BorderSize += 1
                'Me.Width += 1
                'Me.Height += 1
                'Me.Top -= 1
                'Me.Left -= 1
                Await Task.Delay(100)
            Next
            'Me.Width = _l + 5
            'Me.Height = _h + 5
            'Me.Top = _t - 5
            'Me.Left = l - 5
        End Sub

        Private Async Sub Button_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.MouseLeave
            For i = 0 To 5
                'Await Task.Delay(1)
                'If Me.Width > _l Then Me.Width -= 1
                'If Me.Height > _h Then Me.Height -= 1
                'If Me.Top < _t Then Me.Top += 1
                'If Me.Left < l Then Me.Left += 1

                'Me.Width -= 1
                'Me.Height -= 1
                'Me.Top += 1
                'Me.Left += 1
                If BorderSize > 0 Then BorderSize -= 1
                Await Task.Delay(100)

            Next
            'Me.Width = _l
            'Me.Height = _h
            'Me.Top = _t
            'Me.Left = l
        End Sub

        Private Const CS_DROPSHADOW As Integer = &H20000

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            End Get
        End Property

    End Class
End Namespace
