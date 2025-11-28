Imports MySql.Data.MySqlClient

Public Class LogIn
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
<<<<<<< Updated upstream
        If txtFacultyID.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter both Faculty ID and Password.")
            Return
        End If

        Dim query As String = "SELECT COUNT(*) FROM faculty WHERE FacultyID = @id AND Password = @pass"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", txtFacultyID.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())

                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Login Successful!")

                    '🔹 Open next form (dashboard)
                    LoggedFacultyID = txtFacultyID.Text
                    Dim f As New Dashboard()
                    f.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Invalid Faculty ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
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
