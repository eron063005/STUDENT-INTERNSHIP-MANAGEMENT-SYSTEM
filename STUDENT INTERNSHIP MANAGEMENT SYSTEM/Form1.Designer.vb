Imports MySql.Data.MySqlClient

Public Class LogIn
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim facultyID As String = txtFacultyID.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Check if empty
        If facultyID = "" Or password = "" Then
            MessageBox.Show("Please enter both Faculty ID and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Limit FacultyID to 4 characters
        If facultyID.Length > 4 Then
            MessageBox.Show("Faculty ID cannot exceed 4 characters. Example: F001 or f001.", "Invalid Faculty ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacultyID.Clear()
            txtFacultyID.Focus()
            Return
        End If

        ' Validate format: F/f + 3 digits
        If Not System.Text.RegularExpressions.Regex.IsMatch(facultyID, "^[Ff]\d{3}$") Then
            MessageBox.Show("Invalid Faculty ID format. It should be F001 or f001.", "Invalid Faculty ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacultyID.Clear()
            txtFacultyID.Focus()
            Return
        End If

        ' Proceed with login
        Dim query As String = "SELECT COUNT(*) FROM faculty WHERE FacultyID = @id AND Password = @pass"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", facultyID)
                    cmd.Parameters.AddWithValue("@pass", password)

                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        '🔹 Open next form (dashboard)
                        LoggedFacultyID = facultyID
                        Dim f As New Dashboard()
                        f.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Faculty ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend WithEvents btnLogInExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetPassword As Label
    Friend WithEvents RegisStd As Label
    Friend WithEvents RegisFaculty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnShowPass As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
