Public Class ucDashboard
    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblActiveIntern.Text = GetOngoingCountByFaculty()
    End Sub
End Class
