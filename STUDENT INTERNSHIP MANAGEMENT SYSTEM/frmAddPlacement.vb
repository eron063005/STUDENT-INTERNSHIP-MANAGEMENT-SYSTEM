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
        INSERT INTO internship i
                JOIN final_grade fg ON i.FinalGradeId = fg.FinalGradeId
                JOIN assessment a ON fg.AssessmentId = a.AssessmentId
                JOIN company_contact cc ON a.CompanyContactId = cc.CompanyContactId
                JOIN company c ON cc.CompanyId = c.CompanyId
                JOIN student s ON a.StudentId = s.StudentId
        VALUES (@InternshipID, @StudentID, @Status, @StartDate, @EndDate, @FGrade);
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)

                ' Parameters
                cmd.Parameters.AddWithValue("@InternshipID", GenerateInternshipID())
                cmd.Parameters.AddWithValue("@StudentID", txtAddPlaceStdID.Text.Trim())
                cmd.Parameters.AddWithValue("@Status", txtAddPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpAddPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpAddPlaceEndDate.Value)
                cmd.Parameters.AddWithValue("@FGrade", nudAddPlaceGrade.Text.Trim())

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Internship record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using

        clearAll()
    End Sub

    Private Sub frmAddPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtAddPlaceInternID.Text = GenerateInternshipID()
    End Sub

    Private Sub clearAll()
        mtxtAddPlaceInternID.Text = GenerateInternshipID()  ' Optional: display new ID

        ' Clear other controls
        txtAddPlaceStdID.Clear()
        txtAddPlaceStatus.Clear()
        dtpAddPlaceStartDate.Value = DateTime.Now
        dtpAddPlaceEndDate.Value = DateTime.Now
        nudAddPlaceGrade.Text = "0"
    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub
End Class