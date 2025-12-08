Imports MySql.Data.MySqlClient

Public Class frmDelCompany
    Private Sub frmDelCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyListComboBox(cbDelCompany)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cbDelCompany.SelectedIndex = -1 Then
            MessageBox.Show("Please select a company to delete.")
            Return
        End If

        Dim compId As String = cbDelCompany.SelectedValue.ToString

        ' Soft delete: set Archived=1
        Using con As New MySqlConnection(connString)
            Dim query As String = "UPDATE company SET Archived=1 WHERE CompanyId=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", compId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Company deleted successfully!")
        Me.Close()  ' close this form first


    End Sub
    '' THEN open archCompany
    'Dim addForm As New archCompany()
    'Dim parentForm As Dashboard = Me.FindForm()
    '    parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
End Class
