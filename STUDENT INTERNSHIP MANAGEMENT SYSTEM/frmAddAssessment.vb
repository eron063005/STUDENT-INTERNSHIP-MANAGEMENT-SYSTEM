Imports MySql.Data.MySqlClient

Public Class frmAddAssessment

    '----------------------------
    ' Form Load
    '----------------------------
    Private Sub frmAddAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNextAssessmentId()
        LoadInternshipComboBox()

        cmbAddStudentId.Enabled = False
        cmbAddCCId.Enabled = False
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
                    Dim nextId As Integer = If(IsDBNull(result), 1, CInt(result) + 1)

                    mtxtAddAssessID.Text = "A" & nextId.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Assessment ID: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Load internships without existing assessment
    '----------------------------
    Private Sub LoadInternshipComboBox()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT i.InternshipId,
                           CONCAT(i.InternshipId, ' - ', s.FirstName, ' ', s.LastName) AS DisplayName
                    FROM internship i
                    INNER JOIN student s ON i.StudentId = s.StudentId
                    LEFT JOIN assessment a ON i.InternshipId = a.InternshipId
                    WHERE a.AssessmentId IS NULL
                    ORDER BY i.InternshipId
                "

                Using cmd As New MySqlCommand(query, conn)
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    cmbAddInternID.DisplayMember = "DisplayName"
                    cmbAddInternID.ValueMember = "InternshipId"
                    cmbAddInternID.DataSource = dt
                    cmbAddInternID.SelectedIndex = -1
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading internships: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Load Student + Company Contact once internship selected
    '----------------------------
    Private Sub cmbAddInternID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddInternID.SelectedIndexChanged

        If cmbAddInternID.SelectedIndex = -1 Then
            cmbAddStudentId.DataSource = Nothing
            cmbAddCCId.DataSource = Nothing
            Return
        End If

        Dim internshipId As String = cmbAddInternID.SelectedValue.ToString()
        LoadStudentAndCompanyContact(internshipId)

    End Sub

    '----------------------------
    ' Load corresponding Student & Company Contact from internship table
    '----------------------------
    Private Sub LoadStudentAndCompanyContact(internshipId As String)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT i.StudentId,
                           s.FirstName, s.MiddleName, s.LastName,
                           i.CompanyContactId,
                           cc.CFirstName, cc.CLastName
                    FROM internship i
                    INNER JOIN student s ON i.StudentId = s.StudentId
                    INNER JOIN company_contact cc ON i.CompanyContactId = cc.CompanyContactId
                    WHERE i.InternshipId = @InternshipId
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@InternshipId", internshipId)

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    If dt.Rows.Count > 0 Then

                        Dim fullStudentName As String =
                            $"{dt.Rows(0)("FirstName")} {dt.Rows(0)("MiddleName")} {dt.Rows(0)("LastName")}"

                        Dim fullCCName As String =
                            $"{dt.Rows(0)("CFirstName")} {dt.Rows(0)("CLastName")}"

                        '--- Student Combo ---
                        Dim dtStudent As New DataTable()
                        dtStudent.Columns.Add("StudentId")
                        dtStudent.Columns.Add("FullName")
                        dtStudent.Rows.Add(dt.Rows(0)("StudentId"), fullStudentName)

                        cmbAddStudentId.DisplayMember = "FullName"
                        cmbAddStudentId.ValueMember = "StudentId"
                        cmbAddStudentId.DataSource = dtStudent
                        cmbAddStudentId.Enabled = False

                        '--- Company Contact Combo ---
                        Dim dtCC As New DataTable()
                        dtCC.Columns.Add("CompanyContactId")
                        dtCC.Columns.Add("ContactName")
                        dtCC.Rows.Add(dt.Rows(0)("CompanyContactId"), fullCCName)

                        cmbAddCCId.DisplayMember = "ContactName"
                        cmbAddCCId.ValueMember = "CompanyContactId"
                        cmbAddCCId.DataSource = dtCC
                        cmbAddCCId.Enabled = False
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student and company contact: " & ex.Message)
        End Try
    End Sub

    '----------------------------
    ' Add Assessment
    '----------------------------
    Private Sub btnAddAssess_Click(sender As Object, e As EventArgs) Handles btnAddAssess.Click

        If cmbAddInternID.SelectedIndex = -1 Then
            MessageBox.Show("Please select an internship.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim insertQuery As String = "
                    INSERT INTO assessment (AssessmentId, StudentId, CompanyContactId, InternshipId, AssessmentGrade, Archived)
                    VALUES (@aid, @sid, @ccid, @iid, @grade, 0)
                "

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@aid", mtxtAddAssessID.Text)
                    cmd.Parameters.AddWithValue("@sid", cmbAddStudentId.SelectedValue)
                    cmd.Parameters.AddWithValue("@ccid", cmbAddCCId.SelectedValue)
                    cmd.Parameters.AddWithValue("@iid", cmbAddInternID.SelectedValue)
                    cmd.Parameters.AddWithValue("@grade", 0)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Assessment added successfully.")

            LoadNextAssessmentId()
            LoadInternshipComboBox()

            cmbAddStudentId.DataSource = Nothing
            cmbAddCCId.DataSource = Nothing

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
