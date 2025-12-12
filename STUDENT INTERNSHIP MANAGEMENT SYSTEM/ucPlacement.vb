Imports MySql.Data.MySqlClient

Public Class ucPlacement
    Private Sub ucPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInternship(dgvPlacement)

    End Sub

    Private Sub btnDelPlacement_Click(sender As Object, e As EventArgs) Handles btnDelPlacement.Click
        If dgvPlacement.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an internship record to archive.")
            Return
        End If

        Dim internshipID As String = dgvPlacement.SelectedRows(0).Cells("InternshipID").Value.ToString()

        Dim result = MessageBox.Show("Are you sure you want to archive Internship ID " & internshipID & "?" & vbCrLf &
                                     "You can restore it later from Archive.",
                                     "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Dim query As String = "UPDATE internship SET Archived = 1 WHERE InternshipID = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", internshipID)
                Try
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Placement archived successfully.")
                    Else
                        MessageBox.Show("No record archived. Please try again.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error archiving placement: " & ex.Message)
                End Try
            End Using
        End Using

        ' Refresh the DataGridView
        LoadDataInternship(dgvPlacement)
    End Sub

    Private Sub btnAddPlacement_Click(sender As Object, e As EventArgs) Handles btnAddPlacement.Click
        Dim addForm As New frmAddPlacement()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadDataInternship(dgvPlacement)
    End Sub

    Private Sub btnEditPlacement_Click(sender As Object, e As EventArgs) Handles btnEditPlacement.Click
        ' Make sure a row is selected
        If dgvPlacement.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Get the selected row
        Dim row As DataGridViewRow = dgvPlacement.SelectedRows(0)

        ' Create the edit form
        Dim editForm As New frmEditPlacement()

        ' Fill the edit form controls from the selected row
        editForm.mtxtEditPlaceInternID.Text = If(row.Cells("InternshipID").Value, "").ToString()

        ' Combine FullName and Section for the Student TextBox
        Dim fullNameSection As String = $"{row.Cells("StudentName").Value} - {row.Cells("Section").Value}"
        editForm.txtEditPlaceStdID.Text = fullNameSection
        editForm.cbEditPlaceStatus.Text = If(row.Cells("Status").Value, "").ToString()
        editForm.dtpEditPlaceStartDate.Value = If(row.Cells("StartDate").Value IsNot Nothing, Convert.ToDateTime(row.Cells("StartDate").Value), DateTime.Now)
        editForm.dtpEditPlaceEndDate.Value = If(row.Cells("EndDate").Value IsNot Nothing, Convert.ToDateTime(row.Cells("EndDate").Value), DateTime.Now)
        editForm.nudEditPlaceGrade.Text = If(row.Cells("FGrade").Value, "").ToString()

        ' Show the edit form
        'editForm.ShowDialog()

        ' Get parent form (Dashboard) and call helper to show edit form
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(editForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)

        LoadDataInternship(dgvPlacement)
    End Sub

    Private Sub btnarchPlacement_Click(sender As Object, e As EventArgs) Handles btnarchPlacement.Click
        Dim addForm As New archPlacement()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadDataInternship(dgvPlacement)
    End Sub

    Private Sub dgvPlacement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlacement.CellContentClick

    End Sub

    Sub LoadDataInternship(targetGrid As DataGridView)
        Using con As New MySqlConnection(connString)
            Dim query As String =
                "SELECT
                i.InternshipID,
                i.StudentID,
                CONCAT_WS(' ', s.FirstName, s.MiddleName, s.LastName) AS StudentName,
                s.Section,
                cc.CompanyContactId,
                CONCAT(IFNULL(cc.CFirstName,''), ' ', IFNULL(cc.CLastName,'')) AS Supervisor,
                i.Status,
                i.StartDate,
                i.EndDate,
                i.FGrade
            FROM internship i
            INNER JOIN student s ON i.StudentID = s.StudentID
            LEFT JOIN company_contact cc ON i.CompanyContactID = cc.CompanyContactID
            WHERE s.FacultyID = @facultyID
              AND (i.Archived = 0 OR i.Archived IS NULL)
            ORDER BY i.StudentID, i.InternshipID;"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Force refresh
                targetGrid.DataSource = Nothing
                targetGrid.DataSource = table
            End Using
        End Using

        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        targetGrid.ReadOnly = True
        targetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class