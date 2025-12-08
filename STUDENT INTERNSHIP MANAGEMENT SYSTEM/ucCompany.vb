Imports MySql.Data.MySqlClient

Public Class ucCompany
    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        Dim addForm As New frmAddCompany()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub btnEditCompany_Click(sender As Object, e As EventArgs) Handles btnEditCompany.Click
        Dim addForm As New frmEditCompany()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub btnDelCompany_Click(sender As Object, e As EventArgs) Handles btnDelCompany.Click
        Dim addForm As New frmDelCompany()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub ucCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyCards(CompanyContainer)
    End Sub

    Private Sub btnarchCompany_Click(sender As Object, e As EventArgs) Handles btnarchCompany.Click
        Dim archForm As New archCompany()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(archForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadCompanyCards(CompanyContainer)
    End Sub

    ' Helper function to load company cards
    Public Sub LoadCompanyCards(container As FlowLayoutPanel)
        container.Controls.Clear()
        Using con As New MySqlConnection(connString)
            Dim query As String = "SELECT CompanyId, CompanyName, Address, CompanyContactNo, CompanyEmail 
                                   FROM company WHERE Archived = 0 ORDER BY CompanyName"
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim card As New ucCompanyCard(dr("CompanyId").ToString,
                                                      dr("CompanyName").ToString(),
                                                      dr("Address").ToString(),
                                                      dr("CompanyContactNo").ToString(),
                                                      dr("CompanyEmail").ToString())
                        container.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class
