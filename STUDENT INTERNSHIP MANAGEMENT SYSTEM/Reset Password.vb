
Imports MySql.Data.MySqlClient

Public Class Reset_Password
    Private Sub Reset_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBackLog.Font = New Font("Century Gothic", 12, FontStyle.Underline)
    End Sub
    Private Sub ResetPassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TransparencyHelper.ApplyTransparency(Me, PictureBox2, PictureBox1, Label3, btnExitResetPass, RoundedPanel1)
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblBackLog.Click
        Dim frm As New LogIn
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnExitResetPass_Click(sender As Object, e As EventArgs) Handles btnExitResetPass.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?",
                          "Exit Confirmation",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
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

        ' Validate email ends with @gmail.com
        If Not email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Email must end with '@gmail.com'.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using con As New MySqlConnection(connString)
            Try
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

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnShowNew_Click(sender As Object, e As EventArgs) Handles btnShowNew.Click
        ' If password is currently hidden, show it
        If txtNewPassword.PasswordChar = "*"c Then
            txtNewPassword.PasswordChar = ControlChars.NullChar   ' Show password
        Else
            ' If password is visible, hide it again
            txtNewPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnConfirmNew_Click(sender As Object, e As EventArgs) Handles btnConfirmNew.Click
        ' If password is currently hidden, show it
        If txtConfirmPassword.PasswordChar = "*"c Then
            txtConfirmPassword.PasswordChar = ControlChars.NullChar   ' Show password
        Else
            ' If password is visible, hide it again
            txtConfirmPassword.PasswordChar = "*"c
        End If
    End Sub
End Class