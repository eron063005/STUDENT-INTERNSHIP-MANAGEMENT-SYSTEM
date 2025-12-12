Imports MySql.Data.MySqlClient

Public Class archPlacement
    Private Sub archPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArchivedInternships()
    End Sub

    ' ==========================
    ' LOAD ARCHIVED INTERNSHIPS
    ' ==========================
    Private Sub LoadArchivedInternships()
        Using con As New MySqlConnection(connString)
            Dim query As String =
                "SELECT 
                    i.InternshipID,
                    i.StudentID,
                    CONCAT_WS(' ', s.FirstName, s.MiddleName, s.LastName) AS StudentName,
                    s.Section,
                    CONCAT(IFNULL(cc.CFirstName,''), ' ', IFNULL(cc.CLastName,'')) AS Supervisor,
                    i.Status,
                    i.StartDate,
                    i.EndDate,
                    i.FGrade
                FROM internship i
                INNER JOIN student s ON i.StudentID = s.StudentID
                LEFT JOIN company_contact cc ON i.CompanyContactID = cc.CompanyContactID
                WHERE i.Archived = 1 AND s.FacultyID = @facultyID
                ORDER BY i.InternshipID"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvarchPlacement.DataSource = dt
            End Using
        End Using

        dgvarchPlacement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvarchPlacement.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvarchPlacement.ReadOnly = True
    End Sub

    ' ==========================
    ' RESTORE BUTTON
    ' ==========================
    Private Sub btnPlaceRestore_Click(sender As Object, e As EventArgs) Handles btnPlaceRestore.Click
        If dgvarchPlacement.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to restore.")
            Return
        End If

        Dim internshipID As String = dgvarchPlacement.SelectedRows(0).Cells("InternshipID").Value.ToString()

        Dim result = MessageBox.Show("Restore this placement back to Active list?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Dim query As String = "UPDATE internship SET Archived = 0 WHERE InternshipID = @id"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", internshipID)
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Placement restored successfully.")
                        ' Refresh both archive grid and parent main grid
                        LoadArchivedInternships()
                        RefreshParentUCPlacement()
                    Else
                        MessageBox.Show("No record restored. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error restoring placement: " & ex.Message)
            Return
        End Try

        ' Refresh grids
        LoadArchivedInternships()
        RefreshParentUCPlacement()
    End Sub

    ' ==========================
    ' PERMANENT DELETE BUTTON
    ' ==========================
    Private Sub btnPlacePermaDel_Click(sender As Object, e As EventArgs) Handles btnPlacePermaDel.Click
        If dgvarchPlacement.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to permanently delete.")
            Return
        End If

        Dim internshipID As String = dgvarchPlacement.SelectedRows(0).Cells("InternshipID").Value.ToString()

        Dim result = MessageBox.Show("Permanently delete this placement? This action cannot be undone.", "Confirm Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Return

        Dim query As String = "DELETE FROM internship WHERE InternshipID = @id"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", internshipID)
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Placement permanently deleted.")
                    Else
                        MessageBox.Show("No record deleted. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting placement: " & ex.Message)
            Return
        End Try

        ' Refresh grids
        LoadArchivedInternships()
        RefreshParentUCPlacement()
    End Sub

    Private Sub btnPlaceBack_Click(sender As Object, e As EventArgs) Handles btnPlaceBack.Click
        Me.Close()
    End Sub

    Private Sub btnPlaceExit_Click(sender As Object, e As EventArgs) Handles btnPlaceExit.Click
        Me.Close()
    End Sub

    ' Helper to refresh ucPlacement in parent form so main active list updates
    Private Sub RefreshParentUCPlacement()
        Try
            Dim parentForm = FindForm()
            If parentForm IsNot Nothing Then
                Dim uc = FindUCPlacement(parentForm)
                If uc IsNot Nothing Then
                    uc.LoadDataInternship(uc.dgvPlacement)
                End If
            End If
        Catch
            ' ignore refresh errors
        End Try
    End Sub

    ' Recursive search helper to find ucPlacement in form
    Private Function FindUCPlacement(ctrl As Control) As ucPlacement
        If ctrl Is Nothing Then Return Nothing
        For Each c As Control In ctrl.Controls
            If TypeOf c Is ucPlacement Then
                Return DirectCast(c, ucPlacement)
            Else
                Dim f = FindUCPlacement(c)
                If f IsNot Nothing Then Return f
            End If
        Next
        Return Nothing
    End Function
End Class
