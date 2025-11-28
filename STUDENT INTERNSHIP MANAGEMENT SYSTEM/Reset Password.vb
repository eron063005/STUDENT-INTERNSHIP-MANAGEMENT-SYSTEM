Imports MySql.Data.MySqlClient

Public Class Reset_Password
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New LogIn
        frm.Show()
    End Sub

    Private Sub btnExitResetPass_Click(sender As Object, e As EventArgs) Handles btnExitResetPass.Click
        Me.Close()
    End Sub

    Private Sub ResetPassbtn_Click(sender As Object, e As EventArgs) Handles ResetPassbtn.Click
        Dim facultyID As String = txtFacultyID.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPassword.Text.Trim()

        '--- VALIDATION ---
        If facultyID = "" Or email = "" Or newPass = "" Or confirmPass = "" Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using con As New MySqlConnection(connString)
            con.Open()

            ' Check if facultyID + email exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM faculty WHERE FacultyID = @id AND Email = @mail"
            Using checkCmd As New MySqlCommand(checkQuery, con)
                checkCmd.Parameters.AddWithValue("@id", facultyID)
                checkCmd.Parameters.AddWithValue("@mail", email)

                Dim count As Integer = CInt(checkCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("Faculty ID and email do not match any records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            ' Update password
            Dim updateQuery As String = "UPDATE faculty SET Password = @pass WHERE FacultyID = @id"
            Using updateCmd As New MySqlCommand(updateQuery, con)
                updateCmd.Parameters.AddWithValue("@pass", newPass)
                updateCmd.Parameters.AddWithValue("@id", facultyID)
                updateCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Password successfully reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Using
    End Sub
End Class