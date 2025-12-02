Imports MySql.Data.MySqlClient

Public Class Register_Faculty

    Private Sub Register_Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBackLog.Font = New Font("Century Gothic", 12, FontStyle.Underline)
        LoadDepartments()
        GenerateFacultyID()
    End Sub

    Private Sub RegisterFaculty_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TransparencyHelper.ApplyTransparency(Me, PictureBox2, PictureBox1, Label3, btnExitFaculRegis, RoundedPanel1)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblBackLog.Click
        Dim frm As New LogIn
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnExitFaculRegis_Click(sender As Object, e As EventArgs) Handles btnExitFaculRegis.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        TogglePasswordVisibility(txtPassword)
    End Sub

    Private Sub btnShowConfirm_Click(sender As Object, e As EventArgs) Handles btnShowConfirm.Click
        TogglePasswordVisibility(txtConfirmPass)
    End Sub

    Private Sub TogglePasswordVisibility(txtBox As TextBox)
        If txtBox.PasswordChar = "*"c Then
            txtBox.PasswordChar = ControlChars.NullChar
        Else
            txtBox.PasswordChar = "*"c
        End If
    End Sub

    '--- Load Departments into ComboBox ---
    Private Sub LoadDepartments()
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim query As String = "SELECT DepartmentName FROM DEPARTMENTS"
                Using cmd As New MySqlCommand(query, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    cmbFacDept.Items.Clear()
                    While reader.Read()
                        cmbFacDept.Items.Add(reader("DepartmentName").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Generate next FacultyID ---
    Private Sub GenerateFacultyID()
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim query As String = "SELECT FacultyID FROM FACULTY ORDER BY FacultyID DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, con)
                    Dim lastID As Object = cmd.ExecuteScalar()
                    Dim newID As String = "F001"
                    If lastID IsNot Nothing Then
                        Dim numPart As Integer
                        If Integer.TryParse(lastID.ToString().Substring(1), numPart) Then
                            numPart += 1
                            newID = "F" & numPart.ToString("D3")
                        End If
                    End If
                    txtFacID.Text = newID
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Faculty ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Register Button Click ---
    Private Sub btnRegisFaculty_Click(sender As Object, e As EventArgs) Handles btnRegisFaculty.Click
        Dim facID As String = txtFacID.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim dept As String = cmbFacDept.Text.Trim()
        Dim contactNo As String = mtbContactNo.Text.Trim()
        Dim email As String = txtFacEmailAdd.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPass.Text.Trim()

        '--- VALIDATIONS ---
        If facID = "" Or firstName = "" Or lastName = "" Or dept = "" Or contactNo = "" Or email = "" Or password = "" Or confirmPass = "" Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' FacultyID format check
        If facID.Length > 4 OrElse Not System.Text.RegularExpressions.Regex.IsMatch(facID, "^[Ff]\d{3}$") Then
            MessageBox.Show("Faculty ID must be in format F001 (max 4 characters).", "Invalid Faculty ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacID.Focus()
            Exit Sub
        End If

        ' ContactNo check (11 digits)
        If Not System.Text.RegularExpressions.Regex.IsMatch(contactNo, "^\d{11}$") Then
            MessageBox.Show("Contact Number must be exactly 11 digits.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtbContactNo.Focus()
            Exit Sub
        End If

        ' Email check
        If Not email.EndsWith("@vaia.edu.ph", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Email must end with '@vaia.edu.ph'.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacEmailAdd.Focus()
            Exit Sub
        End If

        ' Password match
        If password <> confirmPass Then
            MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        '--- Insert into DB ---
        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                ' Get DeptId from DEPARTMENTS table
                Dim deptQuery As String = "SELECT DeptId FROM DEPARTMENTS WHERE DepartmentName=@dept"
                Dim deptId As Object = Nothing
                Using cmdDept As New MySqlCommand(deptQuery, con)
                    cmdDept.Parameters.AddWithValue("@dept", dept)
                    deptId = cmdDept.ExecuteScalar()
                End Using

                If deptId Is Nothing Then
                    MessageBox.Show("Selected department does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Insert into FACULTY
                Dim insertQuery As String = "INSERT INTO FACULTY(FacultyID, DeptId, Fname, Lname, Contact, Email, Password) " &
                                            "VALUES(@id, @deptId, @fname, @lname, @contact, @mail, @pass)"
                Using cmd As New MySqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@id", facID.ToUpper())
                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    cmd.Parameters.AddWithValue("@fname", firstName)
                    cmd.Parameters.AddWithValue("@lname", lastName)
                    cmd.Parameters.AddWithValue("@contact", contactNo)
                    cmd.Parameters.AddWithValue("@mail", email.ToLower())
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Faculty registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Generate next FacultyID for convenience
                GenerateFacultyID()
                txtFirstName.Clear()
                txtLastName.Clear()
                mtbContactNo.Clear()
                txtFacEmailAdd.Clear()
                txtPassword.Clear()
                txtConfirmPass.Clear()
                cmbFacDept.SelectedIndex = -1

            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
