Imports MySql.Data.MySqlClient

Public Class frmAddAssessment


    '----------------------------
    ' Form Load
    '----------------------------
    Private Sub frmAddAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNextAssessmentId()
        LoadStudentComboBox()
        cmbAddCCId.Enabled = False ' Disable until student is selected
    End Sub

    '----------------------------
    ' Generate next Assessment ID
    '----------------------------
    Private Sub LoadNextAssessmentId()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT MAX(CAST(SUBSTRING(AssessmentId, 2) AS UNSIGNED)) FROM assessment"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    Dim nextId As Integer = 1
                    If Not IsDBNull(result) Then
                        nextId = CInt(result) + 1
                    End If
                    mtxtAddAssessID.Text = "A" & nextId.ToString("D3") ' e.g., A001, A002
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Assessment ID: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Load Students into ComboBox
    '----------------------------
    Private Sub LoadStudentComboBox()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT StudentId, CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS FullName
                                   FROM student
                                   WHERE FacultyId = @facultyID
                                   ORDER BY LastName, FirstName"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)
                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                    cmbAddStudentId.DisplayMember = "FullName"
                    cmbAddStudentId.ValueMember = "StudentId"
                    cmbAddStudentId.DataSource = dt
                    cmbAddStudentId.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Student selection changes Company Contact ComboBox
    '----------------------------
    Private Sub cmbStudentId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddStudentId.SelectedIndexChanged
        If cmbAddStudentId.SelectedIndex = -1 Then
            cmbAddCCId.DataSource = Nothing
            cmbAddCCId.Enabled = False
            Return
        End If

        LoadCompanyContactComboBox(cmbAddStudentId.SelectedValue.ToString())
    End Sub

    '----------------------------
    ' Load Company Contacts linked to Student
    '----------------------------
    Private Sub LoadCompanyContactComboBox(studentId As String)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                ' Fetch company contacts that have assessments with this student
                Dim query As String = "SELECT DISTINCT cc.CompanyContactId, CONCAT(cc.CFirstName, ' ', cc.CLastName) AS FullName
                                   FROM company_contact cc
                                   INNER JOIN assessment a ON cc.CompanyContactId = a.CompanyContactId
                                   WHERE a.StudentId = @studentId
                                   ORDER BY cc.CLastName, cc.CFirstName"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentId", studentId)
                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                    cmbAddCCId.DisplayMember = "FullName"
                    cmbAddCCId.ValueMember = "CompanyContactId"
                    cmbAddCCId.DataSource = dt
                    cmbAddCCId.SelectedIndex = -1
                    cmbAddCCId.Enabled = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading company contacts: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Add Assessment
    '----------------------------
    Private Sub btnAddAssess_Click(sender As Object, e As EventArgs) Handles btnAddAssess.Click
        If cmbAddStudentId.SelectedIndex = -1 Or cmbAddCCId.SelectedIndex = -1 Then
            MessageBox.Show("Please select both a student and a company contact.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim insertQuery As String = "INSERT INTO assessment (AssessmentId, StudentId, CompanyContactId, AssessmentGrade, Archived) " &
                                            "VALUES (@aid, @sid, @ccid, @grade, 0)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@aid", mtxtAddAssessID.Text)
                    cmd.Parameters.AddWithValue("@sid", cmbAddStudentId.SelectedValue)
                    cmd.Parameters.AddWithValue("@ccid", cmbAddCCId.SelectedValue)
                    cmd.Parameters.AddWithValue("@grade", 0)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Assessment added successfully.")

            ' Clear fields for next entry
            cmbAddStudentId.SelectedIndex = -1
            cmbAddCCId.DataSource = Nothing
            cmbAddCCId.Enabled = False
            LoadNextAssessmentId()

        Catch ex As Exception
            MessageBox.Show("Error adding assessment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExitAddAssessment_Click(sender As Object, e As EventArgs) Handles btnExitAddAssessment.Click
        Me.Close()

    End Sub

    Private Sub btnAddAssessCancel_Click(sender As Object, e As EventArgs) Handles btnAddAssessCancel.Click
        Me.Close()

    End Sub
End Class
