Public Class ucDashboard
    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblActiveIntern.Text = GetOngoingCountByFaculty()
        lblPendingIntern.Text = GetPendingCountByFaculty()
        lblPartnerComp.Text = GetCompaniesCount()
    End Sub
End Class
