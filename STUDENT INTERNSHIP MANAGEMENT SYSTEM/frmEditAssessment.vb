Imports MySql.Data.MySqlClient

Public Class frmEditAssessment
Private _assessmentId As String


    ' Constructor to receive the selected AssessmentId
    Public Sub New(assessmentId As String)
    InitializeComponent()
    _assessmentId = assessmentId
End Sub

' Property alternative (if you prefer setting instead of constructor)
Public Property AssessmentIdToEdit As String

Private Sub frmEditAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Load the assessment data
    LoadAssessmentData()
End Sub

Private Sub LoadAssessmentData()
    Dim idToLoad As String = If(String.IsNullOrEmpty(_assessmentId), AssessmentIdToEdit, _assessmentId)

    If String.IsNullOrWhiteSpace(idToLoad) Then
        MessageBox.Show("No assessment selected.")
        Me.Close()
        Return
    End If

    Using con As New MySqlConnection(connString)
        con.Open()
        ' Get Assessment info (StudentId, InternshipId, CompanyContactId)
        Dim cmd As New MySqlCommand("
            SELECT a.InternshipId, a.StudentId, ss.CompanyContactId
            FROM assessment a
            LEFT JOIN StudentSupervisor ss ON a.StudentId = ss.StudentId
            WHERE a.AssessmentId = @id", con)
        cmd.Parameters.AddWithValue("@id", idToLoad)

        Using rdr As MySqlDataReader = cmd.ExecuteReader()
            If rdr.Read() Then
                ' Fill combos
                cmbEditInternID.Items.Clear()
                cmbEditInternID.Items.Add(rdr("InternshipId").ToString())
                cmbEditInternID.SelectedIndex = 0
                cmbEditInternID.Enabled = False ' read-only

                cmbEditStudentId.Items.Clear()
                cmbEditStudentId.Items.Add(rdr("StudentId").ToString())
                cmbEditStudentId.SelectedIndex = 0
                cmbEditStudentId.Enabled = False ' read-only

                Dim studentId As String = rdr("StudentId").ToString()
                Dim selectedSupervisorId As String = If(IsDBNull(rdr("CompanyContactId")), Nothing, rdr("CompanyContactId").ToString())

                LoadCompanyContactsForAssessment(studentId, selectedSupervisorId)
            Else
                MessageBox.Show("Assessment not found.")
                Me.Close()
            End If
        End Using
    End Using
End Sub

' Load supervisor/company contacts into combo
Private Sub LoadCompanyContactsForAssessment(studentId As String, Optional selectedContactId As String = Nothing)
    Using con As New MySqlConnection(connString)
        con.Open()
        ' Get the company of the student
        Dim cmd As New MySqlCommand("
            SELECT cc.CompanyId, cc.CompanyContactId, CONCAT(cc.CFirstName,' ',cc.CLastName) AS FullName
            FROM StudentSupervisor ss
            JOIN Company_Contact cc ON ss.CompanyContactId = cc.CompanyContactId
            WHERE ss.StudentId = @sid", con)
        cmd.Parameters.AddWithValue("@sid", studentId)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbEditCCId.DataSource = dt
        cmbEditCCId.DisplayMember = "FullName"
        cmbEditCCId.ValueMember = "CompanyContactId"

        If Not String.IsNullOrEmpty(selectedContactId) Then
            cmbEditCCId.SelectedValue = selectedContactId
        Else
            cmbEditCCId.SelectedIndex = -1
        End If
    End Using
End Sub

Private Sub btnSaveAssess_Click(sender As Object, e As EventArgs) Handles btnSaveAssess.Click
    Dim idToSave As String = If(String.IsNullOrEmpty(_assessmentId), AssessmentIdToEdit, _assessmentId)
    If String.IsNullOrWhiteSpace(idToSave) Then
        MessageBox.Show("No assessment to save.")
        Return
    End If

    ' Update StudentSupervisor (assign new supervisor if changed)
    If cmbEditCCId.SelectedValue IsNot Nothing AndAlso Not TypeOf cmbEditCCId.SelectedValue Is DataRowView Then
        Dim studentId As String = cmbEditStudentId.SelectedItem.ToString()
        Using con As New MySqlConnection(connString)
            con.Open()
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM StudentSupervisor WHERE StudentId=@id", con)
            checkCmd.Parameters.AddWithValue("@id", studentId)
            Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                Dim updateCmd As New MySqlCommand("UPDATE StudentSupervisor SET CompanyContactId=@contact WHERE StudentId=@id", con)
                updateCmd.Parameters.AddWithValue("@id", studentId)
                updateCmd.Parameters.AddWithValue("@contact", cmbEditCCId.SelectedValue)
                updateCmd.ExecuteNonQuery()
            Else
                Dim insertCmd As New MySqlCommand("INSERT INTO StudentSupervisor (StudentSupervisorId, StudentId, CompanyContactId) VALUES (@ssid,@id,@contact)", con)
                insertCmd.Parameters.AddWithValue("@ssid", GenerateSupervisorID())
                insertCmd.Parameters.AddWithValue("@id", studentId)
                insertCmd.Parameters.AddWithValue("@contact", cmbEditCCId.SelectedValue)
                insertCmd.ExecuteNonQuery()
            End If
        End Using
    End If

    ' Refresh parent grid
    Try
            Dim parentForm = FindForm()
            Dim uc = FindUCAssessment(parentForm)
            If uc IsNot Nothing Then uc.LoadAssessmentData()
        Catch
    End Try

    Close()
End Sub

Private Function GenerateSupervisorID() As String
    Dim newId As String = "SS001"
    Using con As New MySqlConnection(connString)
        con.Open()
        Dim sql As String = "SELECT StudentSupervisorId FROM StudentSupervisor ORDER BY StudentSupervisorId DESC LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            Dim lastId As String = result.ToString()
            Dim number As Integer = Integer.Parse(lastId.Substring(2)) + 1
            newId = "SS" & number.ToString("000")
        End If
    End Using
    Return newId
End Function

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
