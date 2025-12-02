Public Class frmFacProfile
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to Log Out?",
                                 "Log Out Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New LogIn ' Create a new instance
            loginForm.Show()
            Close() ' Optionally close the current form
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFacBack.Click
        Me.Close()
    End Sub

    Private Sub frmFacProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFacultyDetails()
    End Sub
    Private Sub LoadFacultyDetails()
        ' Make sure you have a connection object
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(connString)

        Try
            conn.Open()
            ' Join DEPARTMENTS to get DeptName
            Dim query As String = "SELECT f.FacultyId, f.DeptId, f.Fname, f.Lname, f.Contact, f.Email, d.DepartmentName " &
                                  "FROM FACULTY f " &
                                  "JOIN DEPARTMENTS d ON f.DeptId = d.DeptId " &
                                  "WHERE f.FacultyId = @FacultyID"

            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FacultyID", LoggedFacultyID)

            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Fill the controls
                txtFacultyID.Text = reader("FacultyId").ToString()
                txtDeptID.Text = reader("DeptId").ToString()
                txtDeptName.Text = reader("DepartmentName").ToString()
                txtFirstName.Text = reader("Fname").ToString()
                txtLastName.Text = reader("Lname").ToString()
                lblFullName.Text = reader("Fname").ToString() & " " & reader("Lname").ToString()
                txtContactNum.Text = reader("Contact").ToString()
                txtEmail.Text = reader("Email").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading faculty details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class