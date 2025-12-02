Public Class ucUpcomingVisitItem
    Public Sub New(visitId As String, VisitDate As String, FName As String, LName As String, CompanyName As String)
        InitializeComponent()
        lblUVDate.Text = VisitDate
        lblUVName.Text = FName + LName
        lblUVCompany.Text = CompanyName

    End Sub
    Private Sub ucUpcomingVisitItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
