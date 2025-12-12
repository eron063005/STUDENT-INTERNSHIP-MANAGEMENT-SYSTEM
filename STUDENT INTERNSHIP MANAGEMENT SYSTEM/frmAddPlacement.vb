Imports MySql.Data.MySqlClient

Public Class frmAddPlacement
    Private Sub btnExitAddPlace_Click(sender As Object, e As EventArgs) Handles btnExitAddPlace.Click
        Me.Close()
    End Sub

    Private Sub btnAddPlaceCancel_Click(sender As Object, e As EventArgs) Handles btnAddPlaceCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddPlaceAdd_Click(sender As Object, e As EventArgs) Handles btnAddPlaceAdd.Click
        Dim newInternshipID As String = GenerateInternshipID()
        Dim studentID As String = cbAddPlaceStdID.SelectedValue.ToString()

        ' Insert internship
        Dim insertQuery As String = "
            INSERT INTO internship 
                (InternshipId, StudentId, CompanyContactID, Status, StartDate, EndDate, FGrade)
            VALUES 
                (@InternshipID, @StudentID, @CompanyContactID, @Status, @StartDate, @EndDate, @FGrade);
        "

        Using conn As New MySqlConnection(connString)
            conn.Open()
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@InternshipID", newInternshipID)
                cmd.Parameters.AddWithValue("@StudentID", studentID)
                cmd.Parameters.AddWithValue("@CompanyContactID", If(cbAddPlaceComCon.SelectedValue IsNot Nothing, cbAddPlaceComCon.SelectedValue, DBNull.Value))
                cmd.Parameters.AddWithValue("@Status", cbAddPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpAddPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpAddPlaceEndDate.Value)
                cmd.Parameters.AddWithValue("@FGrade", nudAddPlaceGrade.Value)


                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Internship record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearAll()
    End Sub

    Private Sub frmAddPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAddPlaceStatus.SelectedIndex = 0
        mtxtAddPlaceInternID.Text = GenerateInternshipID()
        LoadStudentsToComboBox()
        LoadCompanyContactsToComboBox()
    End Sub

    Private Sub LoadStudentsToComboBox()
        Dim query As String = "
            SELECT StudentId,
                   CONCAT(StudentId, ' - ', FirstName, ' ', LastName, ' - ', Section) AS DisplayName
            FROM student
            WHERE FacultyId = @FacultyId
            ORDER BY StudentId;
        "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FacultyId", LoggedFacultyID)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                cbAddPlaceStdID.DataSource = dt
                cbAddPlaceStdID.DisplayMember = "DisplayName"
                cbAddPlaceStdID.ValueMember = "StudentId"
            End Using
        End Using
    End Sub

    Private Sub LoadCompanyContactsToComboBox()
        Dim query As String = "
            SELECT CompanyContactID,
                   CONCAT(CFirstName, ' ', CLastName) AS FullName
            FROM company_contact
            ORDER BY CFirstName, CLastName;
        "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                cbAddPlaceComCon.DataSource = dt
                cbAddPlaceComCon.DisplayMember = "FullName"
                cbAddPlaceComCon.ValueMember = "CompanyContactID"
                cbAddPlaceComCon.SelectedIndex = -1
            End Using
        End Using
    End Sub

    Private Sub ClearAll()
        mtxtAddPlaceInternID.Text = GenerateInternshipID()
        cbAddPlaceStatus.SelectedIndex = 0
        dtpAddPlaceStartDate.Value = DateTime.Now
        dtpAddPlaceEndDate.Value = DateTime.Now
        nudAddPlaceGrade.Value = 0
        cbAddPlaceComCon.SelectedIndex = -1
        cbAddPlaceStdID.SelectedIndex = -1
    End Sub
End Class
