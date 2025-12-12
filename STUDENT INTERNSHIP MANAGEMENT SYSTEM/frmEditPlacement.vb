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
        ' SQL UPDATE query for internship
        Dim query As String = "
        UPDATE internship
        SET 
            CompanyContactID = @CompanyContactID,
            Status = @Status,
            StartDate = @StartDate,
            EndDate = @EndDate
        WHERE InternshipId = @InternshipId
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Validate InternshipId
                If String.IsNullOrWhiteSpace(mtxtEditPlaceInternID.Text) Then
                    MessageBox.Show("Internship ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Assign parameters safely
                cmd.Parameters.AddWithValue("@InternshipId", mtxtEditPlaceInternID.Text.Trim())
                cmd.Parameters.AddWithValue("@Status", cbEditPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpEditPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpEditPlaceEndDate.Value)

                Dim selectedCC = If(cbEditPlaceComCon.SelectedValue IsNot Nothing AndAlso Not TypeOf cbEditPlaceComCon.SelectedValue Is DataRowView,
                                 cbEditPlaceComCon.SelectedValue, DBNull.Value)
                cmd.Parameters.AddWithValue("@CompanyContactID", selectedCC)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    '--- ALSO UPDATE ASSESSMENT ---
                    If rowsAffected > 0 AndAlso selectedCC IsNot DBNull.Value Then
                        Dim updateAssessmentQuery As String = "
                        UPDATE assessment
                        SET CompanyContactId = @CompanyContactId
                        WHERE InternshipId = @InternshipId
                    "
                        Using cmd2 As New MySqlCommand(updateAssessmentQuery, conn)
                            cmd2.Parameters.AddWithValue("@CompanyContactId", selectedCC)
                            cmd2.Parameters.AddWithValue("@InternshipId", mtxtEditPlaceInternID.Text.Trim())
                            cmd2.ExecuteNonQuery()
                        End Using
                    End If

                    MessageBox.Show("Record and linked assessments updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
