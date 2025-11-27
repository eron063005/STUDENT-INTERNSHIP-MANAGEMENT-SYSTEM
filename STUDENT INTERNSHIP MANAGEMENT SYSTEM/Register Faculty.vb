Imports ExcelDataReader.Log

Public Class Register_Faculty
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New LogIn
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExitFaculRegis.Click
        Me.Close()
    End Sub
End Class