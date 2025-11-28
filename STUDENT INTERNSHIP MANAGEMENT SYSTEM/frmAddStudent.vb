Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmAddStudent
    Private Sub btdExitEdit_Click(sender As Object, e As EventArgs) Handles btnExitAddStd.Click
        Me.Close()
    End Sub

    Private Sub btnAddStdCancel_Click(sender As Object, e As EventArgs) Handles btnAddStdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseToComboBox(cmbAddStdCourse)
        mtxtAddStudentID.Text = GenerateStudentID()

        cmbAddStdProf.DataSource = Nothing
        cmbAddStdProf.Items.Clear()
        cmbAddStdProf.Items.Add("-- Select Professor --")
        cmbAddStdProf.SelectedIndex = 0
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
    End Sub

    Private Sub AddStudent()
        Dim con As New MySqlConnection(connString)

        ' Auto-generate StudentID
        Dim studentID As String = GenerateStudentID()

        ' Example query
        'DITO YA INIBA NA SYA NG BDAY KESA SA AGE
        Dim query As String = "INSERT INTO `student` (`StudentId`, `FirstName`, `LastName`, 
        `MiddleName`, `Birthday`, `Sex`, `ContactNo`, `Email`, `CourseId`, `Section`, `FacultyId`) 
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
        cmd.Parameters.AddWithValue("@course", cmbAddStdCourse.SelectedValue) ' from combobox
        cmd.Parameters.AddWithValue("@section", txtAddStdSection.Text.Trim())
        cmd.Parameters.AddWithValue("@fId", cmbAddStdProf.SelectedValue)


        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Student Added Successfully!")

        clearAll()
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
End Class