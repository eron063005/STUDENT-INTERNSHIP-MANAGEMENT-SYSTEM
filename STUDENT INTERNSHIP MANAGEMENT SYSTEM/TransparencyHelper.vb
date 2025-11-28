Imports System.Windows.Forms
Imports System.Drawing

Public Class TransparencyHelper

    Public Shared Sub ApplyTransparency(frm As Form, background As Control, ParamArray targets() As Control)
        If frm Is Nothing Or background Is Nothing Or targets Is Nothing Then Return
        ' Ensure background covers form
        background.Location = New Point(0, 0)
        background.Size = frm.ClientSize
        background.SendToBack()
        ' Apply transparency
        For Each ctrl In targets
            If ctrl IsNot Nothing Then MakeTransparent(ctrl, background)
        Next
    End Sub

    Public Shared Sub MakeTransparent(ctrl As Control, background As Control)
        If ctrl Is Nothing OrElse background Is Nothing Then Return
        If ctrl Is background Then Return

        ' If already parented to the background, just set BackColor and return
        If ctrl.Parent Is background Then
            Try
                ctrl.BackColor = Color.Transparent
            Catch
            End Try
            ctrl.BringToFront()
            Return
        End If

        Dim parent As Control = ctrl.Parent
        If parent Is Nothing Then Return

        ' Convert current control location to screen, then to background client coords
        Dim screenPt As Point = parent.PointToScreen(ctrl.Location)
        Dim newLocation As Point = background.PointToClient(screenPt)

        ' Reparent
        parent.Controls.Remove(ctrl)
        background.Controls.Add(ctrl)

        ' Set new location relative to background
        ctrl.Location = newLocation

        ' Try set transparent backcolor
        Try
            ctrl.BackColor = Color.Transparent
        Catch
            ' ignore
        End Try

        ctrl.BringToFront()
    End Sub

    Public Shared Sub MakeTransparent(controls As IEnumerable(Of Control), background As Control)
        If controls Is Nothing OrElse background Is Nothing Then Return
        For Each c In controls
            MakeTransparent(c, background)
        Next
    End Sub
End Class
