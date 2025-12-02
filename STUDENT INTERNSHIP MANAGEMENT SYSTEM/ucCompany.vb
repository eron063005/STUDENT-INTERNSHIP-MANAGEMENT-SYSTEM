Public Class ucCompany
    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        Dim addForm As New frmAddCompany()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub btnEditCompany_Click(sender As Object, e As EventArgs) Handles btnEditCompany.Click
        Dim addForm As New frmEditCompany()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
    Private Sub ucCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub btnarchCompany_Click(sender As Object, e As EventArgs) Handles btnarchCompany.Click
        Dim addForm As New archCompany()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
End Class
