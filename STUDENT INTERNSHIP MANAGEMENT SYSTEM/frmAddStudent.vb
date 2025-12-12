Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmAddStudent

    Public OnStudentAdded As Action
    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseToComboBox(cmbAddStdCourse)
        mtxtAddStudentID.Text = GenerateStudentID()

        ' Initialize professor combo
        cmbAddStdProf.DataSource = Nothing
        cmbAddStdProf.Items.Clear()
        cmbAddStdProf.Items.Add("-- Select Professor --")
        cmbAddStdProf.SelectedIndex = 0
    End Sub

    Private Sub btnAddStdClick(sender As Object, e As EventArgs) Handles btnAddStd.Click
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

        Using conn As New MySqlConnection(connString)
            conn.Open()

            ' 1. Get DeptID of selected course
            Dim deptQuery As String = "SELECT DeptID FROM Course WHERE courseID = @id"
            Using deptCmd As New MySqlCommand(deptQuery, conn)
                deptCmd.Parameters.AddWithValue("@id", courseID)
                Dim result = deptCmd.ExecuteScalar()

                If result Is Nothing OrElse IsDBNull(result) Then
                    MessageBox.Show("No DeptID found for this course.")
                    Exit Sub
                End If

                Dim deptID As String = result

                ' 2. Load Professors with same DeptID
                Dim profQuery As String = "SELECT FacultyID, CONCAT(Fname, ' ', Lname) AS FullName 
                                          FROM Faculty WHERE DeptID = @dept"
                Using profCmd As New MySqlCommand(profQuery, conn)
                    profCmd.Parameters.AddWithValue("@dept", deptID)
                    Dim da As New MySqlDataAdapter(profCmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cmbAddStdProf.DataSource = dt
                    cmbAddStdProf.DisplayMember = "FullName"
                    cmbAddStdProf.ValueMember = "FacultyID"
                End Using
            End Using
        End Using
    End Sub

    Private Sub AddStudent()
        Using con As New MySqlConnection(connString)

            ' Auto-generate StudentID
            Dim studentID As String = GenerateStudentID()

            ' Insert into student table
            Dim query As String = "INSERT INTO student (StudentId, FirstName, LastName, 
                MiddleName, Birthday, Sex, ContactNo, Email, CourseId, Section, FacultyId) 
                VALUES (@id, @fname, @lname, @mname, @bday, @sex, @contactNum, @email, @course, @section, @fId);"

            Using cmd As New MySqlCommand(query, con)
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
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student Added Successfully!")
                    clearAll()

                    ' Trigger callback if assigned
                    OnStudentAdded?.Invoke()

                Catch ex As Exception
                    MessageBox.Show("Error adding student: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
