Imports MySql.Data.MySqlClient

Public Class ucDashboard
    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblActiveIntern.Text = GetOngoingCountByFaculty()
        lblPendingIntern.Text = GetPendingCountByFaculty()
        lblPartnerComp.Text = GetCompaniesCount()
        LoadRecentPlacements()
        LoadUpcomingVisits(panelUV)

    End Sub

    Private Sub LoadRecentPlacements()
        Dim query As String = "
        SELECT i.InternshipId, s.FirstName, s.LastName, c.CompanyName, i.Status
            FROM internship i
            JOIN student s ON i.StudentId = s.StudentId
            JOIN assessment a ON s.StudentId = a.StudentId
            JOIN company_contact cc ON a.CompanyContactId = cc.CompanyContactId
            JOIN company c ON cc.CompanyId = c.CompanyId
            WHERE s.FacultyId = @FacultyId
            ORDER BY i.StartDate DESC
            LIMIT 3;

    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FacultyId", LoggedFacultyID)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim panels() As RoundedPanel = {rp1, rp2, rp3}
                    Dim lblNames() As Label = {lblRPName1, lblRPName2, lblRPName3}
                    Dim lblCompanies() As Label = {lblRPCompany1, lblRPCompany2, lblRPCompany3}
                    Dim lblStatuses() As Label = {lblRPStatus1, lblRPStatus2, lblRPStatus3}

                    Dim index As Integer = 0
                    While reader.Read() AndAlso index < 3
                        lblNames(index).Text = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                        lblCompanies(index).Text = reader("CompanyName").ToString()
                        lblStatuses(index).Text = reader("Status").ToString()

                        ' Set color based on status
                        Select Case reader("Status").ToString().ToLower()
                            Case "ongoing"
                                panels(index).ForeColor = Color.DodgerBlue
                            Case "completed"
                                panels(index).ForeColor = Color.LimeGreen
                            Case "pending"
                                panels(index).ForeColor = Color.Gold
                            Case Else
                                panels(index).ForeColor = Color.Black
                        End Select
                        lblNames(index).ForeColor = Color.Black
                        lblCompanies(index).ForeColor = Color.Black

                        index += 1
                    End While

                    ' Clear unused panels if less than 3 results
                    For i As Integer = index To 2
                        panels(i).BackColor = Color.Transparent
                        lblNames(i).Text = ""
                        lblCompanies(i).Text = ""
                        lblStatuses(i).Text = ""
                    Next
                End Using
            End Using
        End Using
    End Sub

End Class
