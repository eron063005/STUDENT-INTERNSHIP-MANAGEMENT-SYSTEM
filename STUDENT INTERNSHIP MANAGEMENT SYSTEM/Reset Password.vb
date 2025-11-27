Public Class Reset_Password
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New LogIn
        frm.Show()
    End Sub

    Private Sub btnExitResetPass_Click(sender As Object, e As EventArgs) Handles btnExitResetPass.Click
        Me.Close()
    End Sub
End Class