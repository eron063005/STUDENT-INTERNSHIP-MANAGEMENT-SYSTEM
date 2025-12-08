Imports MySql.Data.MySqlClient

Public Class archCompany
    Private Sub archCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArchivedCompanies()
    End Sub

    Private Sub LoadArchivedCompanies()
        Using con As New MySqlConnection(connString)
            Dim query As String = "
            SELECT 
                CompanyId,
                CompanyName,
                Address,
                CompanyContactNo,
                CompanyEmail
            FROM company
            WHERE Archived = 1
            ORDER BY CompanyName
        "

            Using cmd As New MySqlCommand(query, con)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()

                da.Fill(dt)

                dgvarchCompany.DataSource = dt
            End Using
        End Using

        ' UI Settings
        dgvarchCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvarchCompany.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvarchCompany.ReadOnly = True
    End Sub


    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If dgvarchCompany.SelectedRows.Count = 0 Then Exit Sub
        Dim compId As String = dgvarchCompany.SelectedRows(0).Cells(0).Value.ToString
        Using con As New MySqlConnection(connString)
            Dim query As String = "UPDATE company SET Archived=0 WHERE CompanyId=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", compId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadArchivedCompanies()
        MessageBox.Show("Company restored successfully!")
    End Sub

    Private Sub btnDeletePermanent_Click(sender As Object, e As EventArgs) Handles btnDeletePermanent.Click
        If dgvarchCompany.SelectedRows.Count = 0 Then Exit Sub
        Dim compId As String = dgvarchCompany.SelectedRows(0).Cells(0).Value.ToString
        Using con As New MySqlConnection(connString)
            Dim query As String = "DELETE FROM company WHERE CompanyId=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", compId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadArchivedCompanies()
        MessageBox.Show("Company permanently deleted!")
    End Sub

    Private Sub btnCompBack_Click(sender As Object, e As EventArgs) Handles btnCompBack.Click
        Me.Close()
    End Sub

    Private Sub btnCompExit_Click(sender As Object, e As EventArgs) Handles btnCompExit.Click
        Me.Close()
    End Sub
End Class
