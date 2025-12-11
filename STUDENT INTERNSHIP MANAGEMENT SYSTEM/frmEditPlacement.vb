Imports MySql.Data.MySqlClient

Public Class frmEditPlacement
    Private Sub btnEditPlaceCancel_Click(sender As Object, e As EventArgs) Handles btnEditPlaceCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitEditPlace_Click(sender As Object, e As EventArgs) Handles btnExitEditPlace.Click
        Me.Close()
    End Sub

    Private Sub frmEditPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all company contacts into combo box
        LoadCompanyContactsToComboBox()
    End Sub

    Private Sub LoadCompanyContactsToComboBox()
        Dim query As String = "
            SELECT CompanyContactID,
                   CONCAT(CFirstName, ' ', CLastName) AS FullName
            FROM company_contact
            ORDER BY CFirstName, CLastName;
        "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                cbEditPlaceComCon.DataSource = dt
                cbEditPlaceComCon.DisplayMember = "FullName"
                cbEditPlaceComCon.ValueMember = "CompanyContactID"
                cbEditPlaceComCon.SelectedIndex = -1 ' optional: no selection by default
            End Using
        End Using
    End Sub

    Private Sub btnSavePlace_Click(sender As Object, e As EventArgs) Handles btnSavePlace.Click
        ' SQL UPDATE query
        Dim query As String = "
            UPDATE internship
            SET 
                CompanyContactID = @CompanyContactID,
                Status = @Status,
                StartDate = @StartDate,
                EndDate = @EndDate,
                FGrade = @FGrade
            WHERE InternshipId = @InternshipId
        "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Assign parameters from form controls
                cmd.Parameters.AddWithValue("@InternshipId", mtxtEditPlaceInternID.Text.Trim())
                cmd.Parameters.AddWithValue("@CompanyContactID", If(cbEditPlaceComCon.SelectedValue IsNot Nothing, cbEditPlaceComCon.SelectedValue, DBNull.Value))
                cmd.Parameters.AddWithValue("@Status", cbEditPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpEditPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpEditPlaceEndDate.Value)
                cmd.Parameters.AddWithValue("@FGrade", nudEditPlaceGrade.Value)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
