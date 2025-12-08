Imports MySql.Data.MySqlClient

Public Class frmEditCompany
    Private Sub frmEditCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyListComboBox(cbEditCompID)
    End Sub

    Private Sub cbEditCompID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEditCompID.SelectedIndexChanged
        If cbEditCompID.SelectedIndex = -1 Then Exit Sub
        Dim compId As String = cbEditCompID.SelectedValue.ToString
        Using con As New MySqlConnection(connString)
            Dim query As String = "SELECT CompanyName, Address, CompanyContactNo, CompanyEmail FROM company WHERE CompanyId = @id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", compId)
                con.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtEditCompName.Text = dr("CompanyName").ToString()
                        txtEditCompAddress.Text = dr("Address").ToString()
                        mtxtEditCompConNo.Text = dr("CompanyContactNo").ToString()
                        txtEditCompEmail.Text = dr("CompanyEmail").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSaveComp_Click(sender As Object, e As EventArgs) Handles btnSaveComp.Click
        UpdateCompany()
        Me.Close()
    End Sub

    Private Sub UpdateCompany()
        If cbEditCompID.SelectedIndex = -1 Then
            MessageBox.Show("Please select a company to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim compId As String = cbEditCompID.SelectedValue.ToString
        Dim compName As String = txtEditCompName.Text.Trim()
        Dim compAddress As String = txtEditCompAddress.Text.Trim()
        Dim compConNo As String = mtxtEditCompConNo.Text.Trim()
        Dim compEmail As String = txtEditCompEmail.Text.Trim()

        If String.IsNullOrEmpty(compName) Then
            MessageBox.Show("Company Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using con As New MySqlConnection(connString)
            Dim query As String = "UPDATE company SET CompanyName=@name, Address=@address, CompanyContactNo=@conNo, CompanyEmail=@email WHERE CompanyId=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", compName)
                cmd.Parameters.AddWithValue("@address", compAddress)
                cmd.Parameters.AddWithValue("@conNo", compConNo)
                cmd.Parameters.AddWithValue("@email", compEmail)
                cmd.Parameters.AddWithValue("@id", compId)
                con.Open()
                Dim rows = cmd.ExecuteNonQuery()
                If rows > 0 Then
                    MessageBox.Show("Company updated successfully!")
                Else
                    MessageBox.Show("Update failed!")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnEditCompCancel_Click(sender As Object, e As EventArgs) Handles btnEditCompCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitEditComp_Click(sender As Object, e As EventArgs) Handles btnExitEditComp.Click
        Me.Close()
    End Sub
End Class
