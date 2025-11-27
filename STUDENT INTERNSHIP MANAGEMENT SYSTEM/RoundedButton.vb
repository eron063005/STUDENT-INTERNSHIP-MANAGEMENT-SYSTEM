Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<DefaultProperty("CornerRadius")>
Public Class RoundedButton
    Inherits Button

    ' --- Fields (default values) ---
    Private _cornerRadius As Integer = 18
    Private _borderColor As Color = Color.FromArgb(49, 119, 180)
    Private _borderSize As Integer = 2
    Private _fillColor As Color = Color.White
    Private _hoverColor As Color = Color.Yellow
    Private _pressedColor As Color = Color.Red

    ' state flags
    Private isHovered As Boolean = False
    Private isPressed As Boolean = False

    ' --- Constructor ---
    Public Sub New()
        MyBase.New()
        ' make painting smoother
        Me.DoubleBuffered = True
        ' default style: no standard background draw
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        ' sensible defaults
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.Black
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    ' --- Properties (Browsable so they appear in Designer) ---
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

    <Browsable(True), Category("Appearance"), Description("Button fill color (normal)")>
    Public Property FillColor As Color
        Get
            Return _fillColor
        End Get
        Set(value As Color)
            _fillColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Color when mouse is over")>
    Public Property HoverColor As Color
        Get
            Return _hoverColor
        End Get
        Set(value As Color)
            _hoverColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Color when pressed")>
    Public Property PressedColor As Color
        Get
            Return _pressedColor
        End Get
        Set(value As Color)
            _pressedColor = value
            Me.Invalidate()
        End Set
    End Property

    ' --- Mouse events update state flags ---
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        isHovered = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        isHovered = False
        isPressed = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        If mevent.Button = MouseButtons.Left Then
            isPressed = True
            Me.Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        If mevent.Button = MouseButtons.Left Then
            isPressed = False
            Me.Invalidate()
        End If
    End Sub

    ' --- Core painting ---
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim g = pevent.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' fill outside area with BackColor (useful when control placed on non-default form bg)
        Using backBrush As New SolidBrush(Me.BackColor)
            g.FillRectangle(backBrush, 0, 0, Me.Width, Me.Height)
        End Using

        ' decide current fill depending on state
        Dim currentFill As Color = _fillColor
        If Not Me.Enabled Then
            ' disabled look: desaturate a bit
            currentFill = ControlPaint.Light(currentFill)
        ElseIf isPressed Then
            currentFill = _pressedColor
        ElseIf isHovered Then
            currentFill = _hoverColor
        End If

        ' rounded path
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedPath(rect, _cornerRadius)

        ' draw fill
        Using fillBrush As New SolidBrush(currentFill)
            g.FillPath(fillBrush, path)
        End Using

        ' draw border if needed
        If _borderSize > 0 Then
            Using pen As New Pen(_borderColor, _borderSize)
                pen.Alignment = PenAlignment.Inset
                g.DrawPath(pen, path)
            End Using
        End If

        ' clip to rounded area for image/text drawing
        g.SetClip(path)

        ' draw image (if any)
        If Me.Image IsNot Nothing Then
            Dim imgRect As Rectangle = GetImageRectangle()
            ' maintain aspect? current draws at image native size
            g.DrawImage(Me.Image, imgRect)
        End If

        ' draw text
        Using txtBrush As New SolidBrush(Me.ForeColor)
            Dim textRect As Rectangle = GetTextRectangle()
            Dim sf As New StringFormat()
            sf.Alignment = ConvertToStringAlignment(Me.TextAlign)
            sf.LineAlignment = StringAlignment.Center
            g.DrawString(Me.Text, Me.Font, txtBrush, textRect, sf)
        End Using

        g.ResetClip()

        ' dispose path
        path.Dispose()
    End Sub

    ' --- Helper: image rectangle based on ImageAlign ---
    Private Function GetImageRectangle() As Rectangle
        If Me.Image Is Nothing Then
            Return New Rectangle(0, 0, 0, 0)
        End If

        Dim w = Me.Image.Width
        Dim h = Me.Image.Height
        Dim rect As New Rectangle(0, 0, w, h)

        Select Case Me.ImageAlign
            Case ContentAlignment.MiddleLeft
                rect.X = 6
                rect.Y = (Me.Height - h) \ 2
            Case ContentAlignment.MiddleRight
                rect.X = Me.Width - w - 6
                rect.Y = (Me.Height - h) \ 2
            Case ContentAlignment.MiddleCenter
                rect.X = (Me.Width - w) \ 2
                rect.Y = (Me.Height - h) \ 2
            Case Else
                rect.X = 6
                rect.Y = (Me.Height - h) \ 2
        End Select

        Return rect
    End Function

    ' --- Helper: text rectangle adjusted if image present to left/right ---
    Private Function GetTextRectangle() As Rectangle
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        If Me.Image IsNot Nothing AndAlso (Me.ImageAlign = ContentAlignment.MiddleLeft Or Me.ImageAlign = ContentAlignment.MiddleRight) Then
            If Me.ImageAlign = ContentAlignment.MiddleLeft Then
                rect.X = Me.Image.Width + 10
                rect.Width -= rect.X
            ElseIf Me.ImageAlign = ContentAlignment.MiddleRight Then
                rect.Width -= Me.Image.Width + 10
            End If
        End If

        ' small padding
        rect.Inflate(-6, 0)
        Return rect
    End Function

    ' --- Helper: text alignment conversion ---
    Private Function ConvertToStringAlignment(align As ContentAlignment) As StringAlignment
        Select Case align
            Case ContentAlignment.TopLeft, ContentAlignment.MiddleLeft, ContentAlignment.BottomLeft
                Return StringAlignment.Near
            Case ContentAlignment.TopCenter, ContentAlignment.MiddleCenter, ContentAlignment.BottomCenter
                Return StringAlignment.Center
            Case ContentAlignment.TopRight, ContentAlignment.MiddleRight, ContentAlignment.BottomRight
                Return StringAlignment.Far
            Case Else
                Return StringAlignment.Center
        End Select
    End Function

    ' --- Helper: rounded path generator ---
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
