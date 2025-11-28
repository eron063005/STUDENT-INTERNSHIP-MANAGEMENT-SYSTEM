Imports MySql.Data.MySqlClient

Public Class frmEditStudent
    Private _studentID As String

    ' Constructor na tumatanggap ng StudentId
    Public Sub New(studentID As String)
        InitializeComponent()
        _studentID = studentID
    End Sub

    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' populate sex combo
        If cmbEditStdSex.Items.Count = 0 Then
            cmbEditStdSex.Items.AddRange(New String() {"Male", "Female"})
        End If

        ' load courses into combo
        LoadCourseToComboBox(cmbEditStdCourse)

        ' Make StudentID read-only
        mtxtEditStudentID.ReadOnly = True 'ITO SHA PAR

        ' Load student data
        LoadStudentData()
    End Sub

    Private Sub LoadStudentData()
        If String.IsNullOrWhiteSpace(_studentID) Then
            MessageBox.Show("No Student ID provided.")
            Me.Close()
            Return
        End If
        'BDAY NA KESA AGE UNG IFFETCH
        Dim query As String = "SELECT StudentId, FirstName, MiddleName, LastName, Birthday, Sex, ContactNo, Email, CourseId, Section, FacultyId 
                       FROM student WHERE StudentId = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", _studentID)

                Try
                    con.Open()
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then

                            ' BASIC DETAILS
                            mtxtEditStudentID.Text = rdr("StudentId").ToString()
                            txtEditStdFirstname.Text = rdr("FirstName").ToString()
                            txtEditStdMiddlename.Text = rdr("MiddleName").ToString()
                            txtEditStdLastname.Text = rdr("LastName").ToString()

                            'AIAH DITO ITO DAGDAG KO KASI GINAWANG BDAY UNG AGE SA DB
                            If Not IsDBNull(rdr("Birthday")) Then
                                Dim bday As Date = Convert.ToDateTime(rdr("Birthday"))
                                dtpEditBirthday.Value = bday
                            End If
                            cmbEditStdSex.SelectedItem = rdr("Sex").ToString()
                            mtxtEditStdConNo.Text = rdr("ContactNo").ToString()
                            txtEditStdEmail.Text = rdr("Email").ToString()
                            'GANG DITO PRE

                            ' COURSE + PROFESSOR
                            Dim courseId As String = rdr("CourseId").ToString()
                            Dim currentFacultyId As Object = rdr("FacultyId")

                            ' Set Course first
                            If Not String.IsNullOrEmpty(courseId) Then
                                Try
                                    cmbEditStdCourse.SelectedValue = courseId
                                Catch ex As Exception
                                    ' If combobox not ready yet, ignore
                                End Try
                            End If

                            ' SECTION
                            txtEditStdSection.Text = rdr("Section").ToString()

                            ' Load professors for this course + select saved professor
                            LoadProfessorsForEdit(courseId, currentFacultyId)

                        Else
                            MessageBox.Show("Student not found.")
                            Me.Close()
                        End If

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading student: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub
    Private Sub LoadProfessorsForEdit(courseId As String, currentFacultyId As Object)

        If String.IsNullOrEmpty(courseId) Then Exit Sub

        Using con As New MySqlConnection(connString)
            con.Open()

            ' 1. Retrieve Department ID of the Course
            Dim deptQuery As String = "SELECT DeptID FROM Course WHERE CourseID = @id"
            Dim deptCmd As New MySqlCommand(deptQuery, con)
            deptCmd.Parameters.AddWithValue("@id", courseId)

            Dim result = deptCmd.ExecuteScalar()

            ' If no department → show placeholder only
            If result Is Nothing OrElse IsDBNull(result) Then
                cmbEditStdProf.DataSource = Nothing
                cmbEditStdProf.Items.Clear()
                cmbEditStdProf.Items.Add("-- Select Professor --")
                cmbEditStdProf.SelectedIndex = 0
                Exit Sub
            End If

            Dim deptID As String = result.ToString()

            ' 2. Retrieve professors under the same department
            Dim profQuery As String = "SELECT FacultyID, CONCAT(Fname, ' ', Lname) AS FullName 
                                   FROM Faculty WHERE DeptID = @dept"
            Dim profCmd As New MySqlCommand(profQuery, con)
            profCmd.Parameters.AddWithValue("@dept", deptID)

            Dim da As New MySqlDataAdapter(profCmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' 3. Add placeholder ("-- Select Professor --")
            Dim placeholder As DataRow = dt.NewRow()
            placeholder("FullName") = "-- Select Professor --"
            placeholder("FacultyID") = DBNull.Value
            dt.Rows.InsertAt(placeholder, 0)

            ' 4. Bind to ComboBox
            cmbEditStdProf.DataSource = dt
            cmbEditStdProf.DisplayMember = "FullName"
            cmbEditStdProf.ValueMember = "FacultyID"

            ' 5. Select the saved professor OR default to placeholder
            If currentFacultyId IsNot Nothing AndAlso Not IsDBNull(currentFacultyId) Then
                cmbEditStdProf.SelectedValue = currentFacultyId
            Else
                cmbEditStdProf.SelectedIndex = 0
            End If

        End Using

    End Sub


    Private Sub btnEditStdCancel_Click(sender As Object, e As EventArgs) Handles btnEditStdCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitEditStd_Click(sender As Object, e As EventArgs) Handles btnExitEditStd.Click
        Me.Close()
    End Sub

    Private Sub btnEditStd_Click(sender As Object, e As EventArgs) Handles btnSaveStd.Click
        ' validation
        If String.IsNullOrWhiteSpace(txtEditStdFirstname.Text) OrElse String.IsNullOrWhiteSpace(txtEditStdLastname.Text) Then
            MessageBox.Show("Please fill required fields.")
            Return
        End If

        Dim query = "UPDATE student SET FirstName=@fn, MiddleName=@mn, LastName=@ln, Birthday=@bday, Sex=@sex, ContactNo=@cn, Email=@em, CourseId=@course WHERE StudentId=@id"
        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@fn", txtEditStdFirstname.Text.Trim)
                cmd.Parameters.AddWithValue("@mn", txtEditStdMiddlename.Text.Trim)
                cmd.Parameters.AddWithValue("@ln", txtEditStdLastname.Text.Trim)
                cmd.Parameters.AddWithValue("@bday", dtpEditBirthday.Value.Date)
                cmd.Parameters.AddWithValue("@sex", If(cmbEditStdSex.SelectedItem IsNot Nothing, cmbEditStdSex.SelectedItem.ToString, ""))
                cmd.Parameters.AddWithValue("@cn", mtxtEditStdConNo.Text.Trim)
                cmd.Parameters.AddWithValue("@em", txtEditStdEmail.Text.Trim)
                Dim courseVal = If(cmbEditStdCourse.SelectedValue IsNot Nothing, cmbEditStdCourse.SelectedValue.ToString, "")
                cmd.Parameters.AddWithValue("@course", courseVal)
                cmd.Parameters.AddWithValue("@id", _studentID)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student updated successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error updating student: " & ex.Message)
                    Return
                End Try
            End Using
        End Using

        ' --- Refresh ucStudent grid sa parent form ---
        Try
            Dim parentForm = FindForm()

            If parentForm IsNot Nothing Then
                Dim uc = FindUCStudent(parentForm)
                If uc IsNot Nothing Then
                    uc.RefreshData() ' call your sub to reload dgvStudent
                End If
            End If
        Catch
            ' ignore refresh errors
        End Try

        Close()
    End Sub

    ' Recursive search helper to find ucStudent in form
    Private Function FindUCStudent(ctrl As Control) As ucStudent
        If ctrl Is Nothing Then Return Nothing
        For Each c As Control In ctrl.Controls
            If TypeOf c Is ucStudent Then
                Return DirectCast(c, ucStudent)
            Else
                Dim f = FindUCStudent(c)
                If f IsNot Nothing Then Return f
            End If
        Next
        Return Nothing
    End Function

    Private Sub cmbEditStdCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditStdCourse.SelectedIndexChanged
        If cmbEditStdCourse.SelectedValue Is Nothing Then Exit Sub

        If TypeOf cmbEditStdCourse.SelectedValue Is DataRowView Then Exit Sub

        Dim courseID As String = cmbEditStdCourse.SelectedValue

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

        cmbEditStdProf.DataSource = dt
        cmbEditStdProf.DisplayMember = "FullName"
        cmbEditStdProf.ValueMember = "FacultyID"


        conn.Close()
    End Sub
End Class
