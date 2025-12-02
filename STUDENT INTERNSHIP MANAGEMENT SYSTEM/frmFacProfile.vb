Public Class frmFacProfile
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to Log Out?",
                                 "Log Out Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New LogIn() ' Create a new instance
            loginForm.Show()
            Me.Close() ' Optionally close the current form
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFacBack.Click
        Me.Close() 
    End Sub
End Class