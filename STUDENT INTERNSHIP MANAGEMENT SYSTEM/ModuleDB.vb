Imports MySql.Data.MySqlClient

Module ModuleDB
    Public connString As String =
        "server=localhost; port=3307; user=root; password=; database=OJTDB_VAIA;"
    Public LoggedFacultyID As String

    'Dashboard Part
    Public Function GetOngoingCountByFaculty() As Integer
        Dim count As Integer = 0

        Dim query As String = "
     SELECT COUNT(DISTINCT i.InternshipId, v.StudentId) AS Total
        FROM internship i
        JOIN visit_log v ON i.InternshipId = v.InternshipId
        WHERE i.Status = 'Ongoing'
        AND v.FacultyId = @facultyID;
        "

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                    ' ExecuteScalar returns ONE value → COUNT(*)
                    count = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return count
    End Function

    Public Function GetPendingCountByFaculty() As Integer
        Dim count As Integer = 0

        Dim query As String = "
     SELECT COUNT(DISTINCT i.InternshipId, v.StudentId) AS Total
        FROM internship i
        JOIN visit_log v ON i.InternshipId = v.InternshipId
        WHERE i.Status = 'Pending'
        AND v.FacultyId = @facultyID;
        "

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                    ' ExecuteScalar returns ONE value → COUNT(*)
                    count = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return count
    End Function

    Public Function GetCompaniesCount() As Integer
        Dim count As Integer = 0

        Dim query As String = "SELECT COUNT(*) FROM company"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                    ' ExecuteScalar returns ONE value → COUNT(*)
                    count = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return count
    End Function

    'Student Part
    Function GenerateStudentID() As String
        Dim newID As String = "S001"
        Dim con As New MySqlConnection(connString)

        Dim query As String = "SELECT MAX(StudentId) FROM student"

        Dim cmd As New MySqlCommand(query, con)
        Try
            con.Open()
            Dim result As Object = cmd.ExecuteScalar()

            ' If the table has existing IDs
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Dim lastID As String = result.ToString()               ' Example: S015
                ' handle if lastID shorter than expected
                If lastID.Length >= 2 Then
                    Dim numberPart As Integer
                    If Integer.TryParse(lastID.Substring(1), numberPart) Then
                        numberPart += 1
                        newID = "S" & numberPart.ToString("D3")       ' → S016
                    End If
                End If
            End If
        Catch ex As Exception
            ' optional: log error
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        Return newID
    End Function

    Sub LoadCourseToComboBox(cb As ComboBox)
        Dim con As New MySqlConnection(connString)
        Dim query As String = "SELECT CourseId, CourseName FROM Course"

        Try
            Dim da As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            cb.DisplayMember = "CourseName"   ' what is displayed (match case to column)
            cb.ValueMember = "CourseId"       ' actual value behind
            cb.DataSource = dt
            cb.SelectedIndex = -1
        Catch ex As Exception
            ' optional: MessageBox.Show("Error loading courses: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Sub LoadDataStudent(targetGrid As DataGridView, facultyID As String)
        Using con As New MySqlConnection(connString)
            Dim query As String = $"SELECT 
                                    s.StudentId,
                                    c.CourseName,
                                    s.FirstName,
                                    s.LastName,
                                    s.MiddleName,
                                    s.Birthday,
                                    s.Sex,
                                    s.ContactNo,
                                    s.Email,
                                    s.Section
                                FROM STUDENT s
                                JOIN COURSE c ON s.CourseId = c.CourseId
                                WHERE facultyID = @facultyID"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@facultyID", facultyID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                targetGrid.DataSource = table
            End Using
        End Using

        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        targetGrid.ReadOnly = True
        targetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    '

    '---------------


    Sub LoadData(targetGrid As DataGridView, tableName As String)
        Using con As New MySqlConnection(connString)
            Dim query As String = $"SELECT * FROM {tableName}"
            Using cmd As New MySqlCommand(query, con)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                targetGrid.DataSource = table
            End Using
        End Using

        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        targetGrid.ReadOnly = True
        targetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub


    ' Internship Part
    Public Function GenerateInternshipID() As String
        Dim newId As String = "I0001"

        Dim sql As String = "
        SELECT IFNULL(MAX(CAST(SUBSTRING(InternshipID, 2) AS UNSIGNED)), 0) AS maxnum
        FROM internship;
    "

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(sql, conn)
                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    Dim maxNum As Integer = 0
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Integer.TryParse(result.ToString(), maxNum)
                    End If

                    Dim nextNum As Integer = maxNum + 1
                    newId = "I" & nextNum.ToString("D4") ' D4 -> zero-pad to 4 digits
                Catch ex As Exception
                    ' Handle/log error as needed
                    Throw
                End Try
            End Using
        End Using

        Return newId
    End Function

    Sub LoadDataInternship(targetGrid As DataGridView)
        Using con As New MySqlConnection(connString)
            Dim query As String =
                            "SELECT
                                i.InternshipID,
                                i.StudentID,
                                CONCAT_WS(' ', s.FirstName, s.MiddleName, s.LastName) AS StudentName,
                                s.Section,
                                CASE
                                    WHEN i.InternshipID = (
                                        SELECT MIN(i2.InternshipID)
                                        FROM internship i2
                                        WHERE i2.StudentID = i.StudentID
                                    )
                                    THEN (
                                        SELECT c.CompanyName
                                        FROM assessment a
                                        INNER JOIN Company_Contact cc ON a.CompanyContactID = cc.CompanyContactID
                                        INNER JOIN Company c ON cc.CompanyID = c.CompanyID
                                        WHERE a.StudentID = i.StudentID
                                        ORDER BY a.AssessmentId ASC
                                        LIMIT 1
                                    )
                                    ELSE NULL
                                END AS CompanyName,
                                i.Status,
                                i.StartDate,
                                i.EndDate,
                                i.FGrade
                            FROM internship i
                            INNER JOIN student s ON i.StudentID = s.StudentID
                            WHERE s.FacultyID = @facultyID
                            ORDER BY i.StudentID, i.InternshipID;

"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                targetGrid.DataSource = table
            End Using
        End Using

        ' Optional DGV settings
        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        targetGrid.ReadOnly = True
        targetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    '---------------
    'Company Part
    Sub LoadCompanyCards(CompanyContainer As FlowLayoutPanel)
        CompanyContainer.Controls.Clear()

        Dim query As String = "SELECT * FROM company"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim companyId As String = reader("CompanyId").ToString()
                        Dim CompanyName As String = reader("CompanyName").ToString()
                        Dim companyAddress As String = reader("Address").ToString()
                        Dim companyConNum As String = reader("CompanyContactNo").ToString()
                        Dim companyEmail As String = reader("CompanyEmail").ToString()

                        ' Create with constructor
                        Dim card As New ucCompanyCard(companyId, CompanyName, companyAddress, companyConNum, companyEmail)

                        ' Add to FlowLayoutPanel
                        CompanyContainer.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Function GenerateCompanyID() As String
        Dim newID As String = "CO001"

        Using conn As New MySqlConnection(connString)
            conn.Open()

            Dim query As String = "SELECT companyID FROM company ORDER BY companyID DESC LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Dim lastID As String = result.ToString()     ' e.g. "CO015"
                    Dim numberPart As Integer = CInt(lastID.Substring(2)) ' → 15

                    numberPart += 1

                    newID = "CO" & numberPart.ToString("000") ' → CO016
                End If
            End Using
        End Using

        Return newID
    End Function

    Sub LoadCompanyListComboBox(ComboBoxCompany As ComboBox)
        Using con As New MySqlConnection(connString)
            Dim query As String = "SELECT CompanyId, CompanyName FROM company ORDER BY CompanyName"

            Using cmd As New MySqlCommand(query, con)
                Dim dt As New DataTable()

                con.Open()
                dt.Load(cmd.ExecuteReader())

                ' Add placeholder row at the top
                Dim placeholder As DataRow = dt.NewRow()
                placeholder("CompanyId") = 0
                placeholder("CompanyName") = "-- Select Company ID --"
                dt.Rows.InsertAt(placeholder, 0)

                ComboBoxCompany.DataSource = dt
                ComboBoxCompany.DisplayMember = "CompanyName"
                ComboBoxCompany.ValueMember = "CompanyId"
                ComboBoxCompany.SelectedIndex = 0  ' Show the placeholder
            End Using
        End Using
    End Sub

    ' Supervisor Part
    Sub LoadCompanyContacts(targetGrid As DataGridView, companyId As String)
        Using con As New MySqlConnection(connString)
            Dim query As String = "SELECT CompanyContactId, CFirstName, CLastName, ContactNo, Email 
                               FROM Company_Contact 
                               WHERE CompanyId = @CompanyId"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CompanyId", companyId)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                targetGrid.DataSource = table
            End Using
        End Using

        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        targetGrid.ReadOnly = True
        targetGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Public Function GenerateCompanyContactID() As String
        Dim newID As String = ""
        Dim lastID As String = ""
        Dim numberPart As Integer

        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                ' Get the last CompanyContactId from the table
                Dim query As String = "SELECT CompanyContactId FROM Company_Contact ORDER BY CompanyContactId DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, con)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        lastID = result.ToString()
                        ' Extract the numeric part
                        numberPart = Convert.ToInt32(lastID.Substring(2))
                        ' Increment by 1
                        numberPart += 1
                    Else
                        numberPart = 1 ' First entry if table is empty
                    End If
                End Using
            End Using

            ' Format as CC + 3-digit number (e.g., CC001)
            newID = "CC" & numberPart.ToString("D3")

        Catch ex As Exception
            MessageBox.Show("Error generating CompanyContactId: " & ex.Message)
        End Try

        Return newID
    End Function

    Public Sub DeleteCompanyContact(ID As String)
        Dim query As String = "DELETE FROM assessment WHERE CompanyContactID = @id;
                                DELETE FROM company_contact WHERE CompanyContactID = @id;
                               "

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", ID)

                con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.")
                Else
                    MessageBox.Show("No record found to delete.")
                End If
            End Using
        End Using
    End Sub




    'Visit Part
    Function GenerateVisitID() As String
        Dim newID As String = "V0001"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT VisitId FROM visit_log ORDER BY VisitId DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim lastID As String = result.ToString()   ' e.g., "V0043"
                        Dim numberPart As Integer = Integer.Parse(lastID.Substring(1)) ' remove the "V"

                        numberPart += 1
                        newID = "V" & numberPart.ToString("D4") ' Format with 4 digits
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error generating VisitID: " & ex.Message)
        End Try

        Return newID
    End Function

    Sub LoadVisitCards(panelVisit As Panel)
        panelVisit.Controls.Clear()

        Dim query As String = "
             SELECT v.*, s.FirstName, s.MiddleName, s.LastName, c.CompanyName, f.Fname, f.Lname FROM visit_log v 
                 INNER JOIN internship i ON v.InternshipID = i.InternshipID 
                 INNER JOIN student s ON v.StudentID = s.StudentID 
                 INNER JOIN faculty f ON v.FacultyID = f.FacultyId
                 INNER JOIN assessment a ON i.StudentID = a.StudentID
                 INNER JOIN company_contact cc ON a.companycontactID = cc.companycontactID
                 INNER JOIN company c ON cc.CompanyId = c.CompanyId
                 WHERE f.FacultyID = @facultyID"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@facultyID", LoggedFacultyID)
                con.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim yOffset As Integer = 10

                    While reader.Read()
                        Dim visitId As String = reader("VisitID").ToString()
                        Dim intershipId As String = reader("InternshipID").ToString()
                        Dim VisitDate As String = reader("VisitDate").ToString()
                        Dim Evaluation As String = reader("Evaluation").ToString()
                        Dim score As Integer = If(Integer.TryParse(reader("Score").ToString(), Nothing), Convert.ToInt32(reader("Score")), 0)
                        Dim FirstName As String = reader("FirstName").ToString()
                        Dim MiddleName As String = reader("MiddleName").ToString()
                        Dim LastName As String = reader("LastName").ToString()
                        Dim companyName As String = reader("companyName").ToString()
                        Dim FName As String = reader("FName").ToString()
                        Dim LName As String = reader("LName").ToString()

                        ' Create UserControl using your constructor
                        Dim card As New ucVisitReportCard(
                            visitId, intershipId, VisitDate, Evaluation, score,
                            FirstName, MiddleName, LastName, companyName, FName, LName)

                        ' Position inside panel
                        card.Location = New Point(10, yOffset)
                        card.Width = panelVisit.Width - 40
                        card.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

                        panelVisit.Controls.Add(card)
                        yOffset += card.Height + 10
                    End While
                End Using
            End Using
        End Using
    End Sub
End Module