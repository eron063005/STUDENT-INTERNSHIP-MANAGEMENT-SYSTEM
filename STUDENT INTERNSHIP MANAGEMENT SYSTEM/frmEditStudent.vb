Imports MySql.Data.MySqlClient

Public Class frmEditStudent
Private _studentID As String


    Public Sub New(studentID As String)
    InitializeComponent()
    _studentID = studentID
End Sub

Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Populate sex combo
    If cmbEditStdSex.Items.Count = 0 Then
        cmbEditStdSex.Items.AddRange(New String() {"Male", "Female"})
    End If

    ' Load courses into combo
    LoadCourseToComboBox(cmbEditStdCourse)

    ' Student ID read-only
    mtxtEditStudentID.ReadOnly = True

    ' Load student data and supervisor info
    LoadStudentData()
    LoadCompanyToCombo(cmbEditCompName)
    LoadStudentSupervisor(_studentID)
End Sub

Private Sub LoadStudentData()
    If String.IsNullOrWhiteSpace(_studentID) Then
        MessageBox.Show("No Student ID provided.")
        Me.Close()
        Return
    End If

    Dim query As String = "SELECT StudentId, FirstName, MiddleName, LastName, Birthday, Sex, ContactNo, Email, CourseId, Section, FacultyId 
                           FROM student WHERE StudentId = @id"

    Using con As New MySqlConnection(connString)
        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", _studentID)
            con.Open()
            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    mtxtEditStudentID.Text = rdr("StudentId").ToString()
                    txtEditStdFirstname.Text = rdr("FirstName").ToString()
                    txtEditStdMiddlename.Text = rdr("MiddleName").ToString()
                    txtEditStdLastname.Text = rdr("LastName").ToString()

                    If Not IsDBNull(rdr("Birthday")) Then dtpEditBirthday.Value = Convert.ToDateTime(rdr("Birthday"))
                    cmbEditStdSex.SelectedItem = rdr("Sex").ToString()
                    mtxtEditStdConNo.Text = rdr("ContactNo").ToString()
                    txtEditStdEmail.Text = rdr("Email").ToString()

                    If Not String.IsNullOrEmpty(rdr("CourseId").ToString()) Then
                        cmbEditStdCourse.SelectedValue = rdr("CourseId").ToString()
                    End If

                    txtEditStdSection.Text = rdr("Section").ToString()
                    LoadProfessorsForEdit(rdr("CourseId").ToString(), rdr("FacultyId"))
                Else
                    MessageBox.Show("Student not found.")
                    Me.Close()
                End If
            End Using
        End Using
    End Using
End Sub

Private Sub LoadProfessorsForEdit(courseId As String, currentFacultyId As Object)
    If String.IsNullOrEmpty(courseId) Then Exit Sub

    Using con As New MySqlConnection(connString)
        con.Open()
        Dim deptID = New MySqlCommand("SELECT DeptID FROM Course WHERE CourseID=@id", con)
        deptID.Parameters.AddWithValue("@id", courseId)
        Dim deptResult = deptID.ExecuteScalar()
        If deptResult Is Nothing OrElse IsDBNull(deptResult) Then
            cmbEditStdProf.DataSource = Nothing
            cmbEditStdProf.Items.Clear()
            cmbEditStdProf.Items.Add("-- Select Professor --")
            cmbEditStdProf.SelectedIndex = 0
            Exit Sub
        End If

        Dim profCmd As New MySqlCommand("SELECT FacultyID, CONCAT(Fname,' ',Lname) AS FullName FROM Faculty WHERE DeptID=@dept", con)
        profCmd.Parameters.AddWithValue("@dept", deptResult.ToString())
        Dim da As New MySqlDataAdapter(profCmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        Dim placeholder As DataRow = dt.NewRow()
        placeholder("FullName") = "-- Select Professor --"
        placeholder("FacultyID") = DBNull.Value
        dt.Rows.InsertAt(placeholder, 0)

        cmbEditStdProf.DataSource = dt
        cmbEditStdProf.DisplayMember = "FullName"
        cmbEditStdProf.ValueMember = "FacultyID"

        If currentFacultyId IsNot Nothing AndAlso Not IsDBNull(currentFacultyId) Then
            cmbEditStdProf.SelectedValue = currentFacultyId
        Else
            cmbEditStdProf.SelectedIndex = 0
        End If
    End Using
End Sub

Private Sub LoadCompanyToCombo(cmb As ComboBox)
    Using con As New MySqlConnection(connString)
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("SELECT CompanyId, CompanyName FROM Company ORDER BY CompanyName", con)
        da.Fill(dt)
        cmb.DataSource = dt
        cmb.DisplayMember = "CompanyName"
        cmb.ValueMember = "CompanyId"
    End Using
End Sub

Private Sub LoadCompanyContacts(companyId As String, Optional selectedContactId As String = Nothing)
    Using con As New MySqlConnection(connString)
        Dim dt As New DataTable()
        Dim cmd As New MySqlCommand("SELECT CompanyContactId, CONCAT(CFirstName,' ',CLastName) AS FullName FROM Company_Contact WHERE CompanyId=@cid AND Archived=0", con)
        cmd.Parameters.AddWithValue("@cid", companyId)
        Dim da As New MySqlDataAdapter(cmd)
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

Private Sub LoadStudentSupervisor(studentId As String)
    Using con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT ss.CompanyContactId, cc.CompanyId FROM StudentSupervisor ss JOIN Company_Contact cc ON ss.CompanyContactId=cc.CompanyContactId WHERE ss.StudentId=@id", con)
        cmd.Parameters.AddWithValue("@id", studentId)
        con.Open()
        Using rdr As MySqlDataReader = cmd.ExecuteReader()
            If rdr.Read() Then
                Dim companyId = rdr("CompanyId").ToString()
                Dim contactId = rdr("CompanyContactId").ToString()
                cmbEditCompName.SelectedValue = companyId
                LoadCompanyContacts(companyId, contactId)
            End If
        End Using
    End Using
End Sub

Private Sub btnEditStd_Click(sender As Object, e As EventArgs) Handles btnSaveStd.Click
    If String.IsNullOrWhiteSpace(txtEditStdFirstname.Text) OrElse String.IsNullOrWhiteSpace(txtEditStdLastname.Text) Then
        MessageBox.Show("Please fill required fields.")
        Return
    End If

    ' Update student
    Using con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("UPDATE student SET FirstName=@fn, MiddleName=@mn, LastName=@ln, Birthday=@bday, Sex=@sex, ContactNo=@cn, Email=@em, CourseId=@course WHERE StudentId=@id", con)
        cmd.Parameters.AddWithValue("@fn", txtEditStdFirstname.Text.Trim)
        cmd.Parameters.AddWithValue("@mn", txtEditStdMiddlename.Text.Trim)
        cmd.Parameters.AddWithValue("@ln", txtEditStdLastname.Text.Trim)
        cmd.Parameters.AddWithValue("@bday", dtpEditBirthday.Value.Date)
        cmd.Parameters.AddWithValue("@sex", If(cmbEditStdSex.SelectedItem IsNot Nothing, cmbEditStdSex.SelectedItem.ToString(), ""))
        cmd.Parameters.AddWithValue("@cn", mtxtEditStdConNo.Text.Trim)
        cmd.Parameters.AddWithValue("@em", txtEditStdEmail.Text.Trim)
        cmd.Parameters.AddWithValue("@course", If(cmbEditStdCourse.SelectedValue IsNot Nothing, cmbEditStdCourse.SelectedValue.ToString(), ""))
        cmd.Parameters.AddWithValue("@id", _studentID)
        con.Open()
        cmd.ExecuteNonQuery()
    End Using

    ' Update/Insert supervisor
    If cmbEditCCId.SelectedValue IsNot Nothing AndAlso Not TypeOf cmbEditCCId.SelectedValue Is DataRowView Then
        Using con As New MySqlConnection(connString)
            con.Open()
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM StudentSupervisor WHERE StudentId=@id", con)
            checkCmd.Parameters.AddWithValue("@id", _studentID)
            Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                Dim updateCmd As New MySqlCommand("UPDATE StudentSupervisor SET CompanyContactId=@contact WHERE StudentId=@id", con)
                updateCmd.Parameters.AddWithValue("@id", _studentID)
                updateCmd.Parameters.AddWithValue("@contact", cmbEditCCId.SelectedValue)
                updateCmd.ExecuteNonQuery()
            Else
                Dim insertCmd As New MySqlCommand("INSERT INTO StudentSupervisor (StudentSupervisorId, StudentId, CompanyContactId) VALUES (@ssid,@id,@contact)", con)
                insertCmd.Parameters.AddWithValue("@ssid", GenerateSupervisorID())
                insertCmd.Parameters.AddWithValue("@id", _studentID)
                insertCmd.Parameters.AddWithValue("@contact", cmbEditCCId.SelectedValue)
                insertCmd.ExecuteNonQuery()
            End If
        End Using
    End If

    ' Refresh parent grid
    Try
        Dim parentForm = FindForm()
        Dim uc = FindUCStudent(parentForm)
        If uc IsNot Nothing Then uc.RefreshData()
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

Private Function FindUCStudent(ctrl As Control) As ucStudent
    If ctrl Is Nothing Then Return Nothing
    For Each c As Control In ctrl.Controls
        If TypeOf c Is ucStudent Then Return DirectCast(c, ucStudent)
        Dim f = FindUCStudent(c)
        If f IsNot Nothing Then Return f
    Next
    Return Nothing
End Function

Private Sub cmbEditCompName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditCompName.SelectedIndexChanged
    If cmbEditCompName.SelectedValue Is Nothing OrElse TypeOf cmbEditCompName.SelectedValue Is DataRowView Then Exit Sub
    LoadCompanyContacts(cmbEditCompName.SelectedValue.ToString())
End Sub

Private Sub btnEditStdCancel_Click(sender As Object, e As EventArgs) Handles btnEditStdCancel.Click
    Me.Close()
End Sub

Private Sub btnExitEditStd_Click(sender As Object, e As EventArgs) Handles btnExitEditStd.Click
    Me.Close()
End Sub


End Class
