Imports MySql.Data.MySqlClient


Public Class frmEditVisit
    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitEditVisit.Click
        Me.Close()
    End Sub

    Private Sub btnEditVisitCancel_Click(sender As Object, e As EventArgs) Handles btnEditVisitCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSaveVisit_Click(sender As Object, e As EventArgs) Handles btnSaveVisit.Click
        If cbEditVisitID.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Visit ID first.")
            Exit Sub
        End If

        ' Extract VisitId again
        Dim selectedText As String = cbEditVisitID.SelectedItem.ToString()
        Dim visitId As String = selectedText.Split("-"c)(0).Trim()

        Dim query As String = "
        UPDATE visit_log
        SET 
            VisitDate = @VisitDate,
            Evaluation = @Evaluation,
            Score = @Score
        WHERE VisitId = @VisitId
    "

        Using conn As New MySqlConnection(connString),
              cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@VisitDate", dtpEditVisitDate.Value)
            cmd.Parameters.AddWithValue("@Evaluation", txtEditVisitEval.Text)
            cmd.Parameters.AddWithValue("@Score", Convert.ToInt32(nudEditVisitScore.Text))
            cmd.Parameters.AddWithValue("@VisitId", visitId)

            conn.Open()
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Visit details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub LoadVisitID()
        cbEditVisitID.Items.Clear()

        Dim query As String = "
        SELECT v.VisitId, s.FirstName, s.LastName, s.Section
        FROM visit_log v
        JOIN student s ON v.StudentId = s.StudentId
        WHERE v.FacultyId = @FacultyId
        ORDER BY v.VisitDate DESC
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FacultyId", LoggedFacultyID)
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Combine VisitID + FullName + Section as display
                        Dim displayText As String = $"{reader("VisitId")} - {reader("FirstName")} {reader("LastName")} ({reader("Section")})"
                        ' Add the display text to ComboBox
                        cbEditVisitID.Items.Add(displayText)
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub frmEditVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVisitID()
    End Sub

    Private Sub cbEditVisitID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEditVisitID.SelectedIndexChanged
            If cbEditVisitID.SelectedIndex = -1 Then Return

        ' The VisitID is before the first " - "
        Dim selectedText As String = cbEditVisitID.SelectedItem.ToString()
        Dim visitID As String = selectedText.Split(New String() {" - "}, StringSplitOptions.None)(0)

        MessageBox.Show("Selected VisitID: " & visitID)
            ' SQL to get the visit data
        Dim query As String = "
        SELECT v.VisitDate, v.Evaluation, v.Score, v.InternshipId
        FROM visit_log v
        WHERE v.VisitId = @VisitId
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@VisitId", visitID)
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Fill the controls
                        dtpEditVisitDate.Value = Convert.ToDateTime(reader("VisitDate"))
                        txtEditVisitEval.Text = reader("Evaluation").ToString()
                        mtxtEditVisitInternID.Text = reader("InternshipId").ToString()
                        nudEditVisitScore.Value = Convert.ToDecimal(reader("Score"))
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class