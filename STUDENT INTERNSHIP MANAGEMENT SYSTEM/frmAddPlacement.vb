Imports MySql.Data.MySqlClient

Public Class frmAddPlacement
    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAddPlace.Click
        Close()
    End Sub

    Private Sub btnAddPlaceCancel_Click(sender As Object, e As EventArgs) Handles btnAddPlaceCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddPlaceAdd_Click(sender As Object, e As EventArgs) Handles btnAddPlaceAdd.Click

        Dim query As String = "
        INSERT INTO internship 
            (InternshipId, StudentId, Status, StartDate, EndDate, FGrade)
        VALUES 
            (@InternshipID, @StudentID, @Status, @StartDate, @EndDate, @FGrade);
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@InternshipID", GenerateInternshipID())
                cmd.Parameters.AddWithValue("@StudentID", cbAddPlaceStdID.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@Status", cbAddPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpAddPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpAddPlaceEndDate.Value)
                cmd.Parameters.AddWithValue("@FGrade", nudAddPlaceGrade.Value)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Internship record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using
        End Using

        clearAll()

    End Sub




    Private Sub frmAddPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAddPlaceStatus.SelectedIndex = 0
        mtxtAddPlaceInternID.Text = GenerateInternshipID()
        LoadStudentsToComboBox()
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
                cbAddPlaceStdID.DisplayMember = "DisplayName" ' what the user sees
                cbAddPlaceStdID.ValueMember = "StudentId"     ' stored value
            End Using
        End Using
    End Sub


    Private Sub clearAll()
        mtxtAddPlaceInternID.Text = GenerateInternshipID()  ' Optional: display new ID

        ' Clear other controls
        cbAddPlaceStatus.SelectedIndex = 1
        dtpAddPlaceStartDate.Value = DateTime.Now
        dtpAddPlaceEndDate.Value = DateTime.Now
        nudAddPlaceGrade.Text = "0"
    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub
End Class