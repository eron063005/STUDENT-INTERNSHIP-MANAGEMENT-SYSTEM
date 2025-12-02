Imports MySql.Data.MySqlClient

Public Class Register_Faculty

    Private Sub Register_Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBackLog.Font = New Font("Century Gothic", 12, FontStyle.Underline)
        LoadDepartments()
        txtFacID.Text = GetNextFacultyID() 'Auto increment ID
    End Sub

    Private Sub RegisterFaculty_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TransparencyHelper.ApplyTransparency(Me, PictureBox2, PictureBox1, Label3, btnExitFaculRegis, RoundedPanel1)
    End Sub

    Private Sub lblBackLog_Click(sender As Object, e As EventArgs) Handles lblBackLog.Click
        Dim frm As New LogIn
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnExitFaculRegis_Click(sender As Object, e As EventArgs) Handles btnExitFaculRegis.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnShowConfirm_Click(sender As Object, e As EventArgs) Handles btnShowConfirm.Click
        If txtConfirmPass.PasswordChar = "*"c Then
            txtConfirmPass.PasswordChar = ControlChars.NullChar
        Else
            txtConfirmPass.PasswordChar = "*"c
        End If
    End Sub

    ' Register Faculty Button
    Private Sub btnRegisFaculty_Click(sender As Object, e As EventArgs) Handles btnRegisFaculty.Click
        Dim facID As String = txtFacID.Text.Trim()
        Dim fname As String = txtFirstName.Text.Trim()
        Dim lname As String = txtLastName.Text.Trim()
        Dim dept As String = cmbFacDept.Text
        Dim contact As String = mtbContactNo.Text.Trim()
        Dim email As String = txtFacEmailAdd.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPass.Text.Trim()

        '--- VALIDATION ---
        If facID = "" Or fname = "" Or lname = "" Or dept = "" Or contact = "" Or email = "" Or pass = "" Or confirmPass = "" Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Contact Number max 11
        If contact.Length > 11 Then
            MessageBox.Show("Contact number cannot exceed 11 digits.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtbContactNo.Focus()
            Exit Sub
        End If

        If Not email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Email must end with '@gmail.com'.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacEmailAdd.Focus()
            Exit Sub
        End If

        If pass <> confirmPass Then
            MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        ' Save to database
        Using con As New MySqlConnection(connString)
                con.Open()

                ' Get DeptId from department name
                Dim deptId As String = ""
                Dim deptQuery As String = "SELECT DeptId FROM departments WHERE DepartmentName=@dept"
                Using cmdDept As New MySqlCommand(deptQuery, con)
                    cmdDept.Parameters.AddWithValue("@dept", dept)
                    Dim result = cmdDept.ExecuteScalar()
                    If result IsNot Nothing Then deptId = result.ToString()
                End Using

                ' Insert faculty
                Dim insertQuery As String = "INSERT INTO faculty (FacultyId, DeptId, Fname, Lname, Contact, Email, IsEvaluator, Password) " &
                                            "VALUES (@fid, @did, @fname, @lname, @contact, @email, 0, @pass)"
                Using cmd As New MySqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@fid", facID)
                    cmd.Parameters.AddWithValue("@did", deptId)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@lname", lname)
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@pass", pass)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Faculty registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear form & generate next ID
                txtFirstName.Clear()
                txtLastName.Clear()
                mtbContactNo.Clear()
                txtFacEmailAdd.Clear()
                txtPassword.Clear()
                txtConfirmPass.Clear()
                cmbFacDept.SelectedIndex = -1

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub
End Class
