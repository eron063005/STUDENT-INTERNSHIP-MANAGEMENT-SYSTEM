Imports MySql.Data.MySqlClient

Public Class frmEditStudent
    Private _studentID As String
    Public OnStudentUpdated As Action ' callback for parent to refresh grid

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

        ' Load student data
        LoadStudentData()
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
                        If Not String.IsNullOrEmpty(rdr("CourseId").ToString()) Then cmbEditStdCourse.SelectedValue = rdr("CourseId").ToString()
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

            Dim deptIDCmd As New MySqlCommand("SELECT DeptID FROM Course WHERE CourseID=@id", con)
            deptIDCmd.Parameters.AddWithValue("@id", courseId)
            Dim deptResult = deptIDCmd.ExecuteScalar()

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

    Private Sub btnSaveStd_Click(sender As Object, e As EventArgs) Handles btnSaveStd.Click
        If String.IsNullOrWhiteSpace(txtEditStdFirstname.Text) OrElse String.IsNullOrWhiteSpace(txtEditStdLastname.Text) Then
            MessageBox.Show("Please fill required fields.")
            Return
        End If

        ' Update student
        Using con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(
                "UPDATE student SET FirstName=@fn, MiddleName=@mn, LastName=@ln, Birthday=@bday, Sex=@sex, ContactNo=@cn, Email=@em, CourseId=@course, Section=@section, FacultyId=@fid WHERE StudentId=@id", con)
            cmd.Parameters.AddWithValue("@fn", txtEditStdFirstname.Text.Trim)
            cmd.Parameters.AddWithValue("@mn", txtEditStdMiddlename.Text.Trim)
            cmd.Parameters.AddWithValue("@ln", txtEditStdLastname.Text.Trim)
            cmd.Parameters.AddWithValue("@bday", dtpEditBirthday.Value.Date)
            cmd.Parameters.AddWithValue("@sex", If(cmbEditStdSex.SelectedItem IsNot Nothing, cmbEditStdSex.SelectedItem.ToString(), ""))
            cmd.Parameters.AddWithValue("@cn", mtxtEditStdConNo.Text.Trim)
            cmd.Parameters.AddWithValue("@em", txtEditStdEmail.Text.Trim)
            cmd.Parameters.AddWithValue("@course", If(cmbEditStdCourse.SelectedValue IsNot Nothing, cmbEditStdCourse.SelectedValue.ToString(), ""))
            cmd.Parameters.AddWithValue("@section", txtEditStdSection.Text.Trim)
            cmd.Parameters.AddWithValue("@fid", cmbEditStdProf.SelectedValue)
            cmd.Parameters.AddWithValue("@id", _studentID)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using

        ' Trigger callback to refresh parent grid
        OnStudentUpdated?.Invoke()

        Me.Close()
    End Sub

    Private Sub btnEditStdCancel_Click(sender As Object, e As EventArgs) Handles btnEditStdCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitEditStd_Click(sender As Object, e As EventArgs) Handles btnExitEditStd.Click
        Me.Close()
    End Sub

    ' Event handler: when course selection changes
    Private Sub cmbEditStdCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditStdCourse.SelectedIndexChanged
        If cmbEditStdCourse.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbEditStdCourse.SelectedValue Is DataRowView Then Exit Sub

        Dim courseID As String = cmbEditStdCourse.SelectedValue.ToString()

        Using con As New MySqlConnection(connString)
            con.Open()

            ' 1. Get DeptID of the selected course
            Dim deptQuery As String = "SELECT DeptID FROM Course WHERE CourseID = @id"
            Using deptCmd As New MySqlCommand(deptQuery, con)
                deptCmd.Parameters.AddWithValue("@id", courseID)
                Dim deptID = deptCmd.ExecuteScalar()
                If deptID Is Nothing OrElse IsDBNull(deptID) Then
                    ' No professors
                    cmbEditStdProf.DataSource = Nothing
                    cmbEditStdProf.Items.Clear()
                    cmbEditStdProf.Items.Add("-- No Professors --")
                    cmbEditStdProf.SelectedIndex = 0
                    Exit Sub
                End If

                ' 2. Load professors with same DeptID (no Archived column)
                Dim profQuery As String = "SELECT FacultyID, CONCAT(Fname,' ',Lname) AS FullName FROM Faculty WHERE DeptID=@dept ORDER BY Lname, Fname"
                Using profCmd As New MySqlCommand(profQuery, con)
                    profCmd.Parameters.AddWithValue("@dept", deptID)
                    Dim da As New MySqlDataAdapter(profCmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        cmbEditStdProf.DataSource = dt
                        cmbEditStdProf.DisplayMember = "FullName"
                        cmbEditStdProf.ValueMember = "FacultyID"
                        cmbEditStdProf.SelectedIndex = 0
                    Else
                        cmbEditStdProf.DataSource = Nothing
                        cmbEditStdProf.Items.Clear()
                        cmbEditStdProf.Items.Add("-- No Professors --")
                        cmbEditStdProf.SelectedIndex = 0
                    End If
                End Using
            End Using
        End Using
    End Sub


End Class
