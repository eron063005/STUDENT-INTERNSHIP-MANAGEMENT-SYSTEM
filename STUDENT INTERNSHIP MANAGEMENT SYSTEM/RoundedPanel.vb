Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<DefaultProperty("CornerRadius")>
Public Class RoundedPanel
    Inherits Panel
    Public Sub New()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Private _cornerRadius As Integer = 20
    Private _borderColor As Color = Color.FromArgb(80, 118, 133)
    Private _borderSize As Integer = 5
    Private _fillColor As Color = Color.White

    <Browsable(True), Category("Appearance"), Description("Corner radius in pixels")>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Border color")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Border thickness in pixels")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Panel fill color")>
    Public Property FillColor As Color
        Get
            Return _fillColor
        End Get
        Set(value As Color)
            _fillColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim r As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedPath(r, _cornerRadius)

        ' Fill
        Using brush As New SolidBrush(_fillColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Border
        If _borderSize > 0 Then
            Using pen As New Pen(_borderColor, _borderSize)
                pen.Alignment = PenAlignment.Inset
                e.Graphics.DrawPath(pen, path)
            End Using
        End If
    End Sub

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = Math.Min(radius, Math.Min(rect.Width, rect.Height) \ 2)

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, d * 2, d * 2, 180, 90)
        path.AddArc(rect.Right - d * 2, rect.Y, d * 2, d * 2, 270, 90)
        path.AddArc(rect.Right - d * 2, rect.Bottom - d * 2, d * 2, d * 2, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d * 2, d * 2, d * 2, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub
End Class
