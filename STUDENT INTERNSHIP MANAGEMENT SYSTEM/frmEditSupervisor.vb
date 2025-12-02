Imports MySql.Data.MySqlClient

Public Class frmEditSupervisor

    Dim CompanyContactID As String
    Dim CompanyID As String

    Public Sub New(CompanyContactID As String)
        InitializeComponent()
        Me.CompanyContactID = CompanyContactID

    End Sub
    Private Sub LoadCompanyContactData()
        If String.IsNullOrWhiteSpace(CompanyContactID) Then
            MessageBox.Show("No Company Contact ID provided.")
            Me.Close()
            Return
        End If

        Dim query As String =
        "SELECT CompanyContactId, CompanyId, CFirstName, CLastName, ContactNo, Email
         FROM company_contact
         WHERE CompanyContactId = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", CompanyContactID)

                Try
                    con.Open()
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then

                            ' ---------------- BASIC DETAILS ----------------
                            mtxtEditSupervisorCCID.Text = rdr("CompanyContactId").ToString()
                            txtEditSpvFirstname.Text = rdr("CFirstName").ToString()
                            txtEditSpvLastname.Text = rdr("CLastName").ToString()
                            mtxtEditSpvContactNo.Text = rdr("ContactNo").ToString()
                            txtEditSpvEmail.Text = rdr("Email").ToString()

                            ' ---------------- COMPANY (FK) ----------------
                            CompanyID = rdr("CompanyId").ToString()
                        Else
                            MessageBox.Show("Company contact not found.")
                            Me.Close()
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error loading company contact: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Sub btnEditSpvCancel_Click(sender As Object, e As EventArgs) Handles btnEditSpvCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitEditSpv.Click
        Me.Close()
    End Sub

    Private Sub btnSaveSpv_Click(sender As Object, e As EventArgs) Handles btnSaveSpv.Click
        Dim query As String =
        "UPDATE company_contact SET 
            CFirstName = @fn,
            CLastName = @ln,
            ContactNo = @contact,
            Email = @email
         WHERE CompanyContactId = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)

                ' --- PARAMETERS FROM TEXTBOXES ---
                cmd.Parameters.AddWithValue("@id", mtxtEditSupervisorCCID.Text.Trim())
                cmd.Parameters.AddWithValue("@fn", txtEditSpvFirstname.Text.Trim())
                cmd.Parameters.AddWithValue("@ln", txtEditSpvLastname.Text.Trim())
                cmd.Parameters.AddWithValue("@contact", mtxtEditSpvContactNo.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txtEditSpvEmail.Text.Trim())

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Company contact updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show("Error updating company contact: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
        Me.Close()
    End Sub

    Private Sub frmEditSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyContactData()
    End Sub
End Class