Imports MySql.Data.MySqlClient

Public Class frmEditPlacement
    Private Sub btnEditPlaceCancel_Click(sender As Object, e As EventArgs) Handles btnEditPlaceCancel.Click
        Me.Close()
    End Sub

    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitEditPlace.Click
        Close()
    End Sub

    Private Sub btnEditPlaceAdd_Click(sender As Object, e As EventArgs) Handles btnSavePlace.Click
        ' SQL UPDATE query
        Dim query As String = "
            UPDATE internship i
                SET 
                    i.Status = @Status,          
                    i.StartDate = @StartDate,    
                    i.EndDate = @EndDate,        
                    i.FGrade = @FGrade    
                WHERE i.InternshipId = @InternshipId
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Assign parameters from form controls
                cmd.Parameters.AddWithValue("@InternshipID", mtxtEditPlaceInternID.Text.Trim())
                cmd.Parameters.AddWithValue("@StudentID", txtEditPlaceStdID.Text.Trim())
                cmd.Parameters.AddWithValue("@Status", cbEditPlaceStatus.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpEditPlaceStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpEditPlaceEndDate.Value)
                cmd.Parameters.AddWithValue("@FGrade", nudEditPlaceGrade.Value)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close() ' Close the edit form after updating
                    Else
                        MessageBox.Show("No record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub frmEditPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class