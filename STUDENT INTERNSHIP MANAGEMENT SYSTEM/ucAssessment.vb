Imports MySql.Data.MySqlClient

Public Class ucAssessment

    Private Sub btnAddAssessment_Click(sender As Object, e As EventArgs) Handles btnAddAssessment.Click
        Dim addForm As New frmAddAssessment()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadAssessmentData()
    End Sub

    Private Sub btnEditAssessment_Click(sender As Object, e As EventArgs) Handles btnEditAssessment.Click
        Dim editForm As New frmEditAssessment()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(editForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadAssessmentData()
    End Sub

    Private Sub LoadAssessmentData()
        Dim currentFacultyId As String = LoggedFacultyID

        ' Updated query to include InternshipId by joining Internship table
        Dim sql As String = "SELECT a.AssessmentId, a.StudentId, i.InternshipId, a.CompanyContactId, a.AssessmentGrade, a.Archived
                     FROM assessment a
                     JOIN student s ON a.StudentId = s.StudentId
                     LEFT JOIN internship i ON a.StudentId = i.StudentId AND i.Status = 'Ongoing'
                     WHERE s.FacultyId = @facultyId"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@facultyId", currentFacultyId)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        ' Bind the DataTable to the DataGridView
                        DataGridView1.DataSource = dt

                        ' Hide the Archived column safely
                        If DataGridView1.Columns.Contains("Archived") Then
                            DataGridView1.Columns("Archived").Visible = False
                        End If

                        ' Stretch all columns to fill the DataGridView width
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        ' Optional: make rows adjust height automatically
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                        ' Make it read-only and select full rows
                        DataGridView1.ReadOnly = True
                        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                        ' Optional: prevent user from resizing columns manually
                        DataGridView1.AllowUserToResizeColumns = False
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assessment data: " & ex.Message)
        End Try


    End Sub

    Private Sub ucAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssessmentData()
    End Sub


End Class
