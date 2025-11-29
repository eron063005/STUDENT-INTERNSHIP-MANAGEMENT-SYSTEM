Imports MySql.Data.MySqlClient

Public Class frmAddSupervisor

    Dim CompanyID As String
    Public Sub New(CompanyID As String)
        InitializeComponent()
        Me.CompanyID = CompanyID

    End Sub
    Private Sub btnExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAddSpv.Click
        Me.Close()
    End Sub

    Private Sub btnAddSpvCancel_Click(sender As Object, e As EventArgs) Handles btnAddSpvCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtAddSupervisorCCID.Text = GenerateCompanyContactID()

    End Sub

    Private Sub btnAddSpvAdd_Click(sender As Object, e As EventArgs) Handles btnAddSpvAdd.Click
        ' Generate a new CompanyContactId


        ' Get values from the form controls
        Dim firstName As String = txtAddSpvFirstname.Text.Trim()
        Dim middleName As String = txtAddSpvMiddlename.Text.Trim()
        Dim lastName As String = txtAddSpvLastname.Text.Trim()
        Dim contactNo As String = mtxtAddSpvContactNo.Text.Trim()
        Dim email As String = txtAddSpvEmail.Text.Trim()

        ' Validate required fields
        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(contactNo) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim query As String = "INSERT INTO Company_Contact 
                                   (CompanyContactId, CompanyId, CFirstName, CLastName, ContactNo, Email) 
                                   VALUES (@CompanyContactId, @CompanyId, @CFirstName, @CLastName, @ContactNo, @Email)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CompanyContactId", GenerateCompanyContactID)
                    cmd.Parameters.AddWithValue("@CompanyId", CompanyID)
                    cmd.Parameters.AddWithValue("@CFirstName", firstName)
                    cmd.Parameters.AddWithValue("@CLastName", lastName)
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                    cmd.Parameters.AddWithValue("@Email", email)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Supervisor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optional: Clear form controls after insert
            txtAddSpvFirstname.Clear()
            txtAddSpvMiddlename.Clear()
            txtAddSpvLastname.Clear()
            mtxtAddSpvContactNo.Clear()
            txtAddSpvEmail.Clear()

        Catch ex As Exception
            MessageBox.Show("Error inserting supervisor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        mtxtAddSupervisorCCID.Text = GenerateCompanyContactID()
    End Sub


    Sub clearAll()
        txtAddSpvFirstname.Clear()
        txtAddSpvMiddlename.Clear()
        txtAddSpvLastname.Clear()
        mtxtAddSpvContactNo.Clear()
        txtAddSpvEmail.Clear()
    End Sub
End Class