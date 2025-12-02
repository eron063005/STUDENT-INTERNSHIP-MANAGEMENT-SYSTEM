Imports MySql.Data.MySqlClient

Public Class ucPlacement
    Private Sub ucPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInternship(dgvPlacement)

    End Sub

    Private Sub btnDelPlacement_Click(sender As Object, e As EventArgs) Handles btnDelPlacement.Click
        If dgvPlacement.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an internship record to delete.")
            Return
        End If

        ' Get the InternshipID from the selected row
        Dim internshipID As String = dgvPlacement.SelectedRows(0).Cells("InternshipID").Value

        If MessageBox.Show("Are you sure you want to delete Internship ID " & internshipID & "?",
                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                Dim query As String = "DELETE FROM internship WHERE InternshipID = @id"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", internshipID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Internship record deleted successfully!")

            LoadDataInternship(dgvPlacement) ' reload table after delete

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
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

End Class