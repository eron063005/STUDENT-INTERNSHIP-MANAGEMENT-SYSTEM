Imports MySql.Data.MySqlClient

Public Class frmEditAssessment
    Private _assessmentId As String

    Public Sub New(assessmentId As String)
        InitializeComponent()
        _assessmentId = assessmentId
    End Sub

    Public Property AssessmentIdToEdit As String

    Private Sub frmEditAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display AssessmentId (read-only)
        mtxtEditAssessID.Text = If(String.IsNullOrEmpty(_assessmentId), AssessmentIdToEdit, _assessmentId)
        mtxtEditAssessID.ReadOnly = True  ' <-- make it read-only

        ' Load the combo boxes
        LoadComboBoxes()
    End Sub

    '----------------------------
    ' Load Internship, Student, and Company Contact combos
    '----------------------------
    Private Sub LoadComboBoxes()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Load all internships
                Dim cmdIntern As New MySqlCommand("
                    SELECT i.InternshipId, CONCAT(i.InternshipId, ' - ', s.FirstName, ' ', s.LastName) AS DisplayName
                    FROM internship i
                    INNER JOIN student s ON i.StudentId = s.StudentId
                    ORDER BY i.InternshipId", conn)
                Dim dtIntern As New DataTable()
                dtIntern.Load(cmdIntern.ExecuteReader())
                cmbEditInternID.DisplayMember = "DisplayName"
                cmbEditInternID.ValueMember = "InternshipId"
                cmbEditInternID.DataSource = dtIntern
                cmbEditInternID.SelectedIndex = -1

                ' Get current assessment record
                Dim cmdAssess As New MySqlCommand("
                    SELECT StudentId, CompanyContactId, InternshipId
                    FROM assessment
                    WHERE AssessmentId = @id", conn)
                cmdAssess.Parameters.AddWithValue("@id", mtxtEditAssessID.Text)
                Dim dtAssess As New DataTable()
                dtAssess.Load(cmdAssess.ExecuteReader())

                If dtAssess.Rows.Count = 0 Then
                    MessageBox.Show("Assessment not found.")
                    Me.Close()
                    Return
                End If

                Dim selectedInternId = dtAssess.Rows(0)("InternshipId").ToString()
                Dim selectedStudentId = dtAssess.Rows(0)("StudentId").ToString()
                Dim selectedCCId = dtAssess.Rows(0)("CompanyContactId").ToString()

                cmbEditInternID.SelectedValue = selectedInternId

                ' Load Students for selected internship
                LoadStudentsForInternship(selectedInternId, selectedStudentId)

                ' Load CompanyContacts for selected internship
                LoadCompanyContactsForInternship(selectedInternId, selectedCCId)

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading combos: " & ex.Message)
        End Try
    End Sub

    ' Load Students for given Internship
    Private Sub LoadStudentsForInternship(internshipId As String, Optional selectedStudentId As String = Nothing)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("
                    SELECT s.StudentId, CONCAT(s.FirstName,' ',s.MiddleName,' ',s.LastName) AS FullName
                    FROM internship i
                    INNER JOIN student s ON i.StudentId = s.StudentId
                    WHERE i.InternshipId = @iid", conn)
                cmd.Parameters.AddWithValue("@iid", internshipId)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                cmbEditStudentId.DisplayMember = "FullName"
                cmbEditStudentId.ValueMember = "StudentId"
                cmbEditStudentId.DataSource = dt
                If Not String.IsNullOrEmpty(selectedStudentId) Then cmbEditStudentId.SelectedValue = selectedStudentId
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub

    ' Load CompanyContacts for given Internship
    Private Sub LoadCompanyContactsForInternship(internshipId As String, Optional selectedCCId As String = Nothing)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("
                    SELECT cc.CompanyContactId, CONCAT(cc.CFirstName,' ',cc.CLastName) AS FullName
                    FROM internship i
                    INNER JOIN company_contact cc ON i.CompanyContactId = cc.CompanyContactId
                    WHERE i.InternshipId = @iid", conn)
                cmd.Parameters.AddWithValue("@iid", internshipId)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                cmbEditCCId.DisplayMember = "FullName"
                cmbEditCCId.ValueMember = "CompanyContactId"
                cmbEditCCId.DataSource = dt
                If Not String.IsNullOrEmpty(selectedCCId) Then cmbEditCCId.SelectedValue = selectedCCId
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading company contacts: " & ex.Message)
        End Try
    End Sub

    ' When Internship selection changes, reload student & company contact
    Private Sub cmbEditInternID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditInternID.SelectedIndexChanged
        If cmbEditInternID.SelectedIndex = -1 Then Return
        Dim selectedIntern = cmbEditInternID.SelectedValue.ToString()
        LoadStudentsForInternship(selectedIntern)
        LoadCompanyContactsForInternship(selectedIntern)
    End Sub

    '----------------------------
    ' Save changes
    '----------------------------
    Private Sub btnSaveAssess_Click(sender As Object, e As EventArgs) Handles btnSaveAssess.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("
                    UPDATE assessment
                    SET InternshipId=@iid, StudentId=@sid, CompanyContactId=@ccid
                    WHERE AssessmentId=@aid", conn)
                cmd.Parameters.AddWithValue("@aid", mtxtEditAssessID.Text)
                cmd.Parameters.AddWithValue("@iid", cmbEditInternID.SelectedValue)
                cmd.Parameters.AddWithValue("@sid", cmbEditStudentId.SelectedValue)
                cmd.Parameters.AddWithValue("@ccid", cmbEditCCId.SelectedValue)
                cmd.ExecuteNonQuery()
            End Using

            ' Refresh parent
            Try
                Dim parentForm = FindForm()
                Dim uc = FindUCAssessment(parentForm)
                If uc IsNot Nothing Then uc.LoadAssessmentData()
            Catch
            End Try

            MessageBox.Show("Assessment updated successfully.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating assessment: " & ex.Message)
        End Try
    End Sub

    Private Function FindUCAssessment(ctrl As Control) As ucAssessment
        If ctrl Is Nothing Then Return Nothing
        For Each c As Control In ctrl.Controls
            If TypeOf c Is ucAssessment Then Return DirectCast(c, ucAssessment)
            Dim f = FindUCAssessment(c)
            If f IsNot Nothing Then Return f
        Next
        Return Nothing
    End Function

    Private Sub btnEditAssessCancel_Click(sender As Object, e As EventArgs) Handles btnEditAssessCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitEditAssessment_Click(sender As Object, e As EventArgs) Handles btnExitEditAssessment.Click
        Me.Close()
    End Sub

End Class
