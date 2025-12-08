Imports MySql.Data.MySqlClient

Public Class frmAddCompany
    Private Sub btnAddCompCancel_Click(sender As Object, e As EventArgs) Handles btnAddCompCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitAddComp_Click(sender As Object, e As EventArgs) Handles btnExitAddComp.Click
        Me.Close()
    End Sub

    Private Sub frmAddCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtAddCompanyID.Text = GenerateCompanyID()
    End Sub

    Private Sub btnAddCompAdd_Click(sender As Object, e As EventArgs) Handles btnAddCompAdd.Click
        Dim query As String = "INSERT INTO company (CompanyID, CompanyName, Address, CompanyContactNo, CompanyEmail, Archived) 
                               VALUES (@id, @name, @address, @contact, @email, 0)"
        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", GenerateCompanyID())
                    cmd.Parameters.AddWithValue("@name", txtAddCompName.Text)
                    cmd.Parameters.AddWithValue("@address", txtAddCompAddress.Text)
                    cmd.Parameters.AddWithValue("@contact", mtxtAddCompConNo.Text)
                    cmd.Parameters.AddWithValue("@email", txtAddCompEmail.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Company inserted successfully!")
            clearAll()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub clearAll()
        mtxtAddCompanyID.Text = GenerateCompanyID()
        txtAddCompName.Clear()
        txtAddCompAddress.Clear()
        mtxtAddCompConNo.Clear()
        txtAddCompEmail.Clear()
    End Sub
End Class
