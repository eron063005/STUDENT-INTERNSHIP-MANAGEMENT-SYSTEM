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
<<<<<<< HEAD
        Dim currentFacultyId As String = LoggedFacultyID

        ' Updated query to include InternshipId by joining Internship table
        Dim sql As String = "SELECT a.AssessmentId, a.StudentId, i.InternshipId, a.CompanyContactId, a.AssessmentGrade, a.Archived
                     FROM assessment a
                     JOIN student s ON a.StudentId = s.StudentId
                     LEFT JOIN internship i ON a.StudentId = i.StudentId AND i.Status = 'Ongoing'
                     WHERE s.FacultyId = @facultyId"
=======

        Dim currentFacultyId As String = LoggedFacultyID

        'a.InternshipID,
        Dim sql As String = "
        SELECT 
            a.AssessmentId,
            CONCAT(s.FirstName, ' ', s.LastName) AS StudentName,
            CONCAT(cc.CFirstName, ' ', cc.CLastName) AS CompanyContactName,
            c.CompanyName,
            a.AssessmentGrade
        FROM assessment a
        JOIN student s ON a.StudentId = s.StudentId
        JOIN company_contact cc ON a.CompanyContactId = cc.CompanyContactId
        JOIN company c ON cc.CompanyId = c.CompanyId
        WHERE s.FacultyId = @facultyId
    "
>>>>>>> dea32a5cf1a64c29cd82b59e299d6336c1b9a405

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@facultyId", currentFacultyId)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        DataGridView1.DataSource = dt

                        ' Auto formatting
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView1.ReadOnly = True
                        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        DataGridView1.AllowUserToResizeColumns = False
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assessment data: " & ex.Message)
        End Try

<<<<<<< HEAD

=======
>>>>>>> dea32a5cf1a64c29cd82b59e299d6336c1b9a405
    End Sub


    Private Sub ucAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssessmentData()
    End Sub


End Class
