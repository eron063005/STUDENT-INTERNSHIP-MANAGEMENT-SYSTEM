Imports ExcelDataReader.Log

Public Class Register_Faculty
    Private Sub RegisterFaculty_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TransparencyHelper.ApplyTransparency(Me, PictureBox2, PictureBox1, Label3, btnExitFaculRegis, RoundedPanel1)
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New LogIn
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExitFaculRegis.Click
        Me.Close()
    End Sub
End Class