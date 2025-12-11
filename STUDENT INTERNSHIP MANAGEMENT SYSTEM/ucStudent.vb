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

        ' Assign a callback to refresh the grid after adding
        addForm.OnStudentAdded = Sub()
                                     LoadDataStudent(dgvStudent, LoggedFacultyID)
                                 End Sub

        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
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
        Dim ofd As New OpenFileDialog() With {
            .Filter = "Excel Files|*.xlsx;*.xls",
            .Title = "Select Excel file (only .xls/.xlsx allowed)",
            .Multiselect = False
        }

        If ofd.ShowDialog() <> DialogResult.OK Then Return

        Dim filePath As String = ofd.FileName
        Dim ext As String = Path.GetExtension(filePath).ToLower()

        ' Reject non-excel explicitly: if user tries PDF (or other) show message
        If ext <> ".xlsx" AndAlso ext <> ".xls" Then
            MessageBox.Show("Only Excel files (.xlsx, .xls) are supported for import. If you selected a PDF, convert it to Excel first.", "Unsupported File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Read Excel into DataTable (ExcelDataReader)
        Dim dt As DataTable = Nothing
        Try
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
            Using stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                Using reader = ExcelReaderFactory.CreateReader(stream)
                    Dim conf = New ExcelDataSetConfiguration() With {
                        .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {.UseHeaderRow = True}
                    }
                    Dim ds As DataSet = reader.AsDataSet(conf)
                    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                        dt = ds.Tables(0)
                    Else
                        MessageBox.Show("No sheets found in the Excel file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading Excel file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Show the required double-check message (NO auto-mapping as requested)
        Dim checkMsg As String = "Please DOUBLE-CHECK the column names in your Excel file." & vbCrLf & vbCrLf &
                                 "Expected column names (exact):" & vbCrLf &
                                 "- StudentId" & vbCrLf &
                                 "- FirstName" & vbCrLf &
                                 "- MiddleName" & vbCrLf &
                                 "- LastName" & vbCrLf &
                                 "- Suffix" & vbCrLf &
                                 "- Birthday" & vbCrLf &
                                 "- Sex" & vbCrLf &
                                 "- ContactNo" & vbCrLf &
                                 "- Email" & vbCrLf &
                                 "- CourseId" & vbCrLf &
                                 "- Section" & vbCrLf &
                                 "- FacultyId" & vbCrLf &
                                 "If column names are different, the program will still try to save but may produce empty values or errors." & vbCrLf & vbCrLf &
                                 "Continue to preview?"
        Dim resp = MessageBox.Show(checkMsg, "Double-check columns", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.No Then Return

        ' Show preview form (modal) via Dashboard helper so it centers nicely
        Try
            Dim preview As New frmPreviewStudent(dt)
            Dim parentForm As Dashboard = Me.FindForm()
            parentForm.ShowFormWithPadding(preview, leftPadding:=470, topPadding:=150, rightPadding:=416, bottomPadding:=150)
            ' After preview closed, refresh student grid (in case they saved)
            LoadDataStudent(dgvStudent, LoggedFacultyID)
        Catch ex As Exception
            MessageBox.Show("Error showing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
