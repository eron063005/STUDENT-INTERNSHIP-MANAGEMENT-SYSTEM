Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmAddStudent


    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseToComboBox(cmbAddStdCourse)
        mtxtAddStudentID.Text = GenerateStudentID()

        ' Initialize professor combo
        cmbAddStdProf.DataSource = Nothing
        cmbAddStdProf.Items.Clear()
        cmbAddStdProf.Items.Add("-- Select Professor --")
        cmbAddStdProf.SelectedIndex = 0

        ' Load companies
        LoadCompanies()
    End Sub

    Private Sub LoadCompanies()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT CompanyId, CompanyName FROM Company WHERE Archived = 0"
                Using cmd As New MySqlCommand(sql, conn)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cmbAddCompName.DataSource = dt
                    cmbAddCompName.DisplayMember = "CompanyName"
                    cmbAddCompName.ValueMember = "CompanyId"
                    cmbAddCompName.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbAddCompName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddCompName.SelectedIndexChanged
        If cmbAddCompName.SelectedValue Is Nothing Or TypeOf cmbAddCompName.SelectedValue Is DataRowView Then Exit Sub

        Dim companyId As String = cmbAddCompName.SelectedValue
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim sql As String = "SELECT CompanyContactId, CONCAT(CFirstName, ' ', CLastName) AS FullName 
                                 FROM Company_Contact 
                                 WHERE CompanyId = @cid AND Archived = 0"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cid", companyId)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cmbAddCCId.DataSource = dt
                    cmbAddCCId.DisplayMember = "FullName"
                    cmbAddCCId.ValueMember = "CompanyContactId"
                    cmbAddCCId.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading company contacts: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddStd_Click(sender As Object, e As EventArgs) Handles btnAddStd.Click
        AddStudent()
    End Sub

    Private Sub clearAll()
        mtxtAddStudentID.Clear()
        txtAddStdFirstname.Clear()
        txtAddStdLastname.Clear()
        txtAddStdMiddlename.Clear()
        cmbAddStdSex.SelectedIndex = -1
        mtxtAddStdContactNo.Clear()
        txtAddStdEmail.Clear()
        cmbAddStdCourse.SelectedIndex = -1
        cmbAddStdProf.DataSource = Nothing
        cmbAddStdProf.Items.Clear()
        cmbAddStdProf.Items.Add("-- Select Professor --")
        cmbAddStdProf.SelectedIndex = 0
        txtAddStdSection.Clear()
        cmbAddCompName.SelectedIndex = -1
        cmbAddCCId.DataSource = Nothing
        cmbAddCCId.Items.Clear()
    End Sub
    Private Sub LoadProfessorsByCourse(courseID As String)
        Try
            Using con As New MySqlConnection(connString)
                con.Open()


                ' Get DeptId of the selected course
                Dim deptQuery As String = "SELECT DeptId FROM course WHERE CourseId = @courseID"
                Dim deptId As Object
                Using deptCmd As New MySqlCommand(deptQuery, con)
                    deptCmd.Parameters.AddWithValue("@courseID", courseID)
                    deptId = deptCmd.ExecuteScalar()
                End Using

                If deptId Is Nothing Then
                    cmbAddStdProf.DataSource = Nothing
                    cmbAddStdProf.Items.Clear()
                    cmbAddStdProf.Items.Add("-- No Professors --")
                    cmbAddStdProf.SelectedIndex = 0
                    Return
                End If

                ' Load professors from that department
                Dim sql As String = "SELECT FacultyId, CONCAT(Fname, ' ', Lname) AS FullName
                             FROM faculty
                             WHERE DeptId = @deptID AND Archived = 0
                             ORDER BY Lname, Fname"
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@deptID", deptId)
                    Dim dt As New DataTable()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        cmbAddStdProf.DataSource = dt
                        cmbAddStdProf.DisplayMember = "FullName"
                        cmbAddStdProf.ValueMember = "FacultyId"
                        cmbAddStdProf.SelectedIndex = -1
                    Else
                        cmbAddStdProf.DataSource = Nothing
                        cmbAddStdProf.Items.Clear()
                        cmbAddStdProf.Items.Add("-- No Professors --")
                        cmbAddStdProf.SelectedIndex = 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading professors: " & ex.Message)
        End Try


    End Sub


    Private Sub btnExitAddStd_Click(sender As Object, e As EventArgs) Handles btnExitAddStd.Click
        Me.Close()
    End Sub

    Private Sub btnAddStdCancel_Click(sender As Object, e As EventArgs) Handles btnAddStdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbAddStdCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddStdCourse.SelectedIndexChanged
        If cmbAddStdCourse.SelectedValue Is Nothing Then Exit Sub

        If TypeOf cmbAddStdCourse.SelectedValue Is DataRowView Then Exit Sub

        Dim courseID As String = cmbAddStdCourse.SelectedValue

        Dim conn As New MySqlConnection(connString)
        conn.Open()

        ' 1. Get DeptID of selected course
        Dim deptQuery As String = "SELECT DeptID FROM Course WHERE courseID = @id"
        Dim deptCmd As New MySqlCommand(deptQuery, conn)
        deptCmd.Parameters.AddWithValue("@id", courseID)

        Dim result = deptCmd.ExecuteScalar()

        If result Is Nothing OrElse IsDBNull(result) Then
            MessageBox.Show("No DeptID found for this course.")
            conn.Close()
            Exit Sub
        End If

        Dim deptID As String = result

        ' 2. Load Professors with same DeptID
        Dim profQuery As String = "SELECT FacultyID, CONCAT(Fname, ' ', Lname) AS FullName 
                   FROM Faculty WHERE DeptID = @dept"
        Dim profCmd As New MySqlCommand(profQuery, conn)
        profCmd.Parameters.AddWithValue("@dept", deptID)
        Dim da As New MySqlDataAdapter(profCmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cmbAddStdProf.DataSource = dt
        cmbAddStdProf.DisplayMember = "FullName"
        cmbAddStdProf.ValueMember = "FacultyID"
        conn.Close()
    End Sub

    Private Sub AddStudent()
        Dim con As New MySqlConnection(connString)

        ' Auto-generate StudentID
        Dim studentID As String = GenerateStudentID()

        ' Insert into student table
        Dim query As String = "INSERT INTO student (StudentId, FirstName, LastName, 
    MiddleName, Birthday, Sex, ContactNo, Email, CourseId, Section, FacultyId) 
    VALUES (@id, @fname, @lname, @mname, @bday, @sex, @contactNum, @email, @course, @section, @fId);"

        Dim cmd As New MySqlCommand(query, con)

        cmd.Parameters.AddWithValue("@id", studentID)
        cmd.Parameters.AddWithValue("@fname", txtAddStdFirstname.Text.Trim())
        cmd.Parameters.AddWithValue("@lname", txtAddStdLastname.Text.Trim())
        cmd.Parameters.AddWithValue("@mname", txtAddStdMiddlename.Text.Trim())
        cmd.Parameters.AddWithValue("@bday", dtpAddBirthday.Value.Date)
        cmd.Parameters.AddWithValue("@sex", cmbAddStdSex.Text.Trim())
        cmd.Parameters.AddWithValue("@contactNum", mtxtAddStdContactNo.Text.Trim())
        cmd.Parameters.AddWithValue("@email", txtAddStdEmail.Text.Trim())
        cmd.Parameters.AddWithValue("@course", cmbAddStdCourse.SelectedValue)
        cmd.Parameters.AddWithValue("@section", txtAddStdSection.Text.Trim())
        cmd.Parameters.AddWithValue("@fId", cmbAddStdProf.SelectedValue)

        Try
            con.Open()

            ' Execute student insertion
            cmd.ExecuteNonQuery()

            ' Now insert into StudentSupervisor table if company contact is selected
            If cmbAddCCId.SelectedValue IsNot Nothing AndAlso Not TypeOf cmbAddCCId.SelectedValue Is DataRowView Then

                Dim supervisorID As String = GenerateSupervisorID()

                Dim supervisorQuery As String = "
        INSERT INTO StudentSupervisor (StudentSupervisorId, StudentId, CompanyContactId)
        VALUES (@ssId, @studentId, @contactId)
    "

                Dim supervisorCmd As New MySqlCommand(supervisorQuery, con)
                supervisorCmd.Parameters.AddWithValue("@ssId", supervisorID)
                supervisorCmd.Parameters.AddWithValue("@studentId", studentID)
                supervisorCmd.Parameters.AddWithValue("@contactId", cmbAddCCId.SelectedValue)

                supervisorCmd.ExecuteNonQuery()
            End If


            con.Close()

            MessageBox.Show("Student Added Successfully!")
            clearAll()

        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Function GenerateSupervisorID() As String
        Dim nextId As String = "SS001"

        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                Dim query As String = "SELECT MAX(CAST(SUBSTRING(StudentSupervisorId, 3) AS UNSIGNED)) 
                                   FROM StudentSupervisor"

                Using cmd As New MySqlCommand(query, con)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim num As Integer = Convert.ToInt32(result) + 1
                        nextId = "SS" & num.ToString("D3")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error generating Supervisor ID: " & ex.Message)
        End Try

        Return nextId
    End Function


End Class
