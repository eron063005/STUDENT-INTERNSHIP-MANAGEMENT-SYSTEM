Public Class ucCompanyCard

    Public Sub New(companyID As String, companyName As String, companyAddress As String, companyConNum As String, companyEmail As String)
        InitializeComponent()

        lblCompanyID.Text = companyID
        lblCompanyName.Text = companyName
        lblCompanyAddr.Text = companyAddress
        lblCompanyConNum.Text = companyConNum
        lblCompanyEmail.Text = companyEmail
    End Sub

    Private Sub panelCard_Paint(sender As Object, e As PaintEventArgs) Handles panelCard.Paint

    End Sub

    Private Sub btnViewSupervisor_Click(sender As Object, e As EventArgs) Handles btnViewSupervisor.Click
        Dim parentForm As Dashboard = Me.FindForm() ' Dashboard
        Dim viewForm As New frmViewSupervisor(lblCompanyID.Text)

        ' Set owner para puwede mag-refer sa Dashboard sa loob ng frmViewSupervisor
        viewForm.Owner = parentForm

        ' Tawagin helper function sa Dashboard
        parentForm.ShowFormWithPadding(viewForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
End Class