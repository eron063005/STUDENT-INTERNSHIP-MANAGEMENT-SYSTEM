Imports MySql.Data.MySqlClient

Public Class frmAddVisit
    Private Sub btnEditVisitCancel_Click(sender As Object, e As EventArgs) Handles btnAddVisitCancel.Click
        Me.Close()
    End Sub

    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAddVisit.Click
        Close()
    End Sub

    Private Sub mtxtAddVisitID_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtAddVisitID.MaskInputRejected

    End Sub

    Private Sub frmAddVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtAddVisitID.Text = GenerateVisitID()
        LoadInternshipsForVisit()
    End Sub
    Private Sub LoadInternshipsForVisit()
        cbAddVisitInternID.Items.Clear()

        Dim query As String =
            "SELECT i.InternshipId, 
                CONCAT(s.FirstName, ' ', s.LastName, ' (', s.Section, ')') AS StudentInfo
         FROM internship i
         JOIN student s ON i.StudentId = s.StudentId
         WHERE s.FacultyId = @FacultyId"

        Using conn As New MySqlConnection(connString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FacultyId", LoggedFacultyID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim displayText As String = reader("InternshipId").ToString() &
                                                " - " &
                                                reader("StudentInfo").ToString()

                    cbAddVisitInternID.Items.Add(displayText)
                End While
            End Using
        End Using
    End Sub

    Private Sub btnAddVisitAdd_Click(sender As Object, e As EventArgs) Handles btnAddVisitAdd.Click
        ' Validate Internship combo selection
        If cbAddVisitInternID.SelectedIndex = -1 Then
            Return
        End If

        ' Extract InternshipId from ComboBox (format: I0001 - John Cruz (BSIT-2A))
        Dim selectedText As String = cbAddVisitInternID.SelectedItem.ToString()
        Dim internshipId As String = selectedText.Split("-"c)(0).Trim()

        Dim visitId As String = mtxtAddVisitID.Text.Trim()
        Dim evaluation As String = txtAddVisitEval.Text.Trim()
        Dim visitDate As Date = dtpAddVisitDate.Value
        Dim score As Integer = nudAddVisitScore.Value

        Dim query As String =
            "INSERT INTO visit_log (VisitId, StudentId, InternshipId, FacultyId, VisitDate, Evaluation, Score)
         SELECT @VisitId, s.StudentId, i.InternshipId, @FacultyId, @VisitDate, @Evaluation, @Score
         FROM internship i
         JOIN student s ON i.StudentId = s.StudentId
         WHERE i.InternshipId = @InternshipId;"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@VisitId", visitId)
                    cmd.Parameters.AddWithValue("@InternshipId", internshipId)
                    cmd.Parameters.AddWithValue("@FacultyId", LoggedFacultyID)
                    cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                    cmd.Parameters.AddWithValue("@Evaluation", evaluation)
                    cmd.Parameters.AddWithValue("@Score", score)

                    Dim rows As Integer = cmd.ExecuteNonQuery()

                    If rows > 0 Then
                        MessageBox.Show("Visit Log successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to insert visit log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ClearAll()
    End Sub
    Private Sub ClearAll()
        mtxtAddVisitID.Clear()
        txtAddVisitEval.Clear()
        dtpAddVisitDate.Value = DateTime.Now
        cbAddVisitInternID.SelectedIndex = -1
        nudAddVisitScore.Value = nudAddVisitScore.Minimum
    End Sub

End Class