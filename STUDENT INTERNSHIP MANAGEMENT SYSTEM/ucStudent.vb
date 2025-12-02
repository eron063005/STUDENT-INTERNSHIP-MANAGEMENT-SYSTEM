Imports MySql.Data.MySqlClient
Imports System.IO
Imports ExcelDataReader
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Public Class ucStudent
    Public Sub RefreshData()
        ' Ensure your ModuleDB.LoadDataStudent() fetches only Archived = 0 rows.
        ModuleDB.LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    ' Helper that calls ModuleDB (keeps your previous way of loading)
    Private Sub LoadDataStudent(grid As DataGridView, facultyId As String)
        ModuleDB.LoadDataStudent(grid, facultyId)
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim addForm As New frmAddStudent()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    ' --- ARCHIVE (instead of permanent delete) ---
    Private Sub btnDelStudent_Click(sender As Object, e As EventArgs) Handles btnDelStudent.Click
        If dgvStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to archive.")
            Return
        End If

        Dim studentID As String = dgvStudent.SelectedRows(0).Cells("StudentId").Value.ToString()

        Dim result = MessageBox.Show("Are you sure you want to archive this student? You can restore it later from Archive.",
                                     "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then Return

        Dim query As String = "UPDATE student SET Archived = 1 WHERE StudentId = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", studentID)
                Try
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Student archived successfully.")
                    Else
                        MessageBox.Show("No record archived. Please try again.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error archiving student: " & ex.Message)
                End Try
            End Using
        End Using

        ' Refresh the DataGridView
        LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        If dgvStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.")
            Return
        End If

        Dim studentID As String = dgvStudent.SelectedRows(0).Cells("StudentId").Value.ToString()
        Dim editForm As New frmEditStudent(studentID)

        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(editForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click
        ' keep your import logic as before (unchanged)
        '... (existing code)
    End Sub

    ' --- Open Archive form ---
    Private Sub btnarchStudents_Click(sender As Object, e As EventArgs) Handles btnarchStudents.Click
        Dim archForm As New archStudent()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(archForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)

        ' After archive form closed, refresh student list in case of restores/deletes
        LoadDataStudent(dgvStudent, LoggedFacultyID)
    End Sub

    Private Sub SearchStudents(searchText As String)
        Try
            Dim query As String = $"SELECT 
                        s.StudentId,
                        c.CourseName,
                        s.FirstName,
                        s.LastName,
                        s.MiddleName,
                        s.Birthday,
                        s.Sex,
                        s.ContactNo,
                        s.Email,
                        s.Section
                      FROM STUDENT s
                      LEFT JOIN COURSE c ON s.CourseId = c.CourseId
                      WHERE s.facultyID = @facultyID AND (s.Archived = 0 OR s.Archived IS NULL)
                        AND (s.StudentId LIKE @search OR s.FirstName LIKE @search OR s.LastName LIKE @search OR c.CourseName LIKE @search)"
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    cmd.Parameters.AddWithValue("@facultyId", LoggedFacultyID)

                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    dgvStudent.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub txtStdSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtStdSearchBox.TextChanged
        SearchStudents(txtStdSearchBox.Text)
    End Sub
End Class
