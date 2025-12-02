Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class archStudent

    Private Sub archStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArchivedStudents()
    End Sub

    Private Sub LoadArchivedStudents()
        Dim query As String = "SELECT s.StudentId, s.FirstName, s.MiddleName, s.LastName, s.Birthday, s.Sex, s.ContactNo, s.Email, c.CourseName, s.Section, s.FacultyId
                               FROM student s
                               LEFT JOIN course c ON s.CourseId = c.CourseId
                               WHERE (s.Archived = 1) AND s.FacultyId = @facultyId"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@facultyId", LoggedFacultyID)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvarchStudent.DataSource = dt

                    ' Optional: show count
                    If Controls.ContainsKey("lblCount") Then
                        Dim lbl As Label = DirectCast(Controls("lblCount"), Label)
                        lbl.Text = $"Archived: {dt.Rows.Count}"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading archived students: " & ex.Message)
        End Try
    End Sub

    Private Sub btnStdBack_Click(sender As Object, e As EventArgs) Handles btnStdBack.Click
        Me.Close()
    End Sub

    Private Sub btnStdExit_Click(sender As Object, e As EventArgs) Handles btnStdExit.Click
        Me.Close()
    End Sub

    ' Restore selected archived student (Archived = 0)
    Private Sub btnStdRestore_Click(sender As Object, e As EventArgs) Handles btnStdRestore.Click
        If dgvarchStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to restore.")
            Return
        End If

        Dim studentID As String = dgvarchStudent.SelectedRows(0).Cells("StudentId").Value.ToString()

        Dim result = MessageBox.Show("Restore this student back to Active list?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Dim query As String = "UPDATE student SET Archived = 0 WHERE StudentId = @id"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studentID)
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Student restored successfully.")
                    Else
                        MessageBox.Show("No record restored. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error restoring student: " & ex.Message)
            Return
        End Try

        ' Refresh grids
        LoadArchivedStudents()
        RefreshParentUCStudent()
    End Sub

    ' Permanently delete selected archived student
    Private Sub btnStdDelPerma_Click(sender As Object, e As EventArgs) Handles btnStdDelPerma.Click
        If dgvarchStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to permanently delete.")
            Return
        End If

        Dim studentID As String = dgvarchStudent.SelectedRows(0).Cells("StudentId").Value.ToString()

        Dim result = MessageBox.Show("Permanently delete this student? This action cannot be undone.", "Confirm Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Return

        Dim query As String = "DELETE FROM student WHERE StudentId = @id"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studentID)
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Student permanently deleted.")
                    Else
                        MessageBox.Show("No record deleted. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message)
            Return
        End Try

        ' Refresh grids
        LoadArchivedStudents()
        RefreshParentUCStudent()
    End Sub

    ' Helper to refresh ucStudent in the parent Dashboard so active list updates immediately
    Private Sub RefreshParentUCStudent()
        Try
            Dim parentForm = FindForm()
            If parentForm IsNot Nothing Then
                Dim uc = FindUCStudent(parentForm)
                If uc IsNot Nothing Then
                    uc.RefreshData()
                End If
            End If
        Catch
            ' ignore refresh errors
        End Try
    End Sub

    ' Recursive search helper to find ucStudent in form (same as in frmEditStudent for consistency)
    Private Function FindUCStudent(ctrl As Control) As ucStudent
        If ctrl Is Nothing Then Return Nothing
        For Each c As Control In ctrl.Controls
            If TypeOf c Is ucStudent Then
                Return DirectCast(c, ucStudent)
            Else
                Dim f = FindUCStudent(c)
                If f IsNot Nothing Then Return f
            End If
        Next
        Return Nothing
    End Function

End Class
