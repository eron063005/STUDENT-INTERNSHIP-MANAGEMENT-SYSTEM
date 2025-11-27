Imports MySql.Data.MySqlClient

Public Class frmAddCompany
    Private Sub btnAddCompCancel_Click(sender As Object, e As EventArgs) Handles btnAddCompCancel.Click
        Me.Close()
    End Sub

    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAddComp.Click
        Me.Close()
    End Sub

    Private Sub btnAddCompAdd_Click(sender As Object, e As EventArgs) Handles btnAddCompAdd.Click
        ' SQL insert command
        Dim query As String = "INSERT INTO company (companyID, companyName, address, companyContactNo, companyEmail) 
                               VALUES (@id, @name, @address, @contact, @email)"

        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters
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

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        clearAll()
    End Sub

    Private Sub clearAll()
        mtxtAddCompanyID.Text = GenerateCompanyID()
        txtAddCompName.Clear()
        txtAddCompAddress.Clear()
        mtxtAddCompConNo.Clear()
        txtAddCompEmail.Clear()
    End Sub
    Private Sub frmAddCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtAddCompanyID.Text = GenerateCompanyID()
    End Sub
End Class