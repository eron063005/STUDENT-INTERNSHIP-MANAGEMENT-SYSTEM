Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Linq
Public Class frmPreviewStudent
    'DITO YA LAHAT NG CODE DITO COPY PASTE LANG MASKI YANG IMPORT
    Private sourceTable As DataTable

    ' Constructor: pass imported DataTable
    Public Sub New(dt As DataTable)
        InitializeComponent()
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        sourceTable = dt
    End Sub

    Private Sub frmPreviewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Trim column headers to remove leading/trailing spaces
            For i As Integer = 0 To sourceTable.Columns.Count - 1
                sourceTable.Columns(i).ColumnName = sourceTable.Columns(i).ColumnName.Trim()
            Next

            ' Display the imported table directly (NO auto-mapping)
            dgvPreview.DataSource = sourceTable
            dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPreview.AllowUserToAddRows = False
            dgvPreview.ReadOnly = False ' allow user corrections before saving
        Catch ex As Exception
            MessageBox.Show("Error preparing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    ' Cancel button -> just close preview
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        Me.Close()
    End Sub

    ' Save button -> attempt to save rows to DB
    Private Sub btnSaveDB_Click(sender As Object, e As EventArgs) Handles btnSaveDB.Click
        If sourceTable Is Nothing OrElse sourceTable.Rows.Count = 0 Then
            MessageBox.Show("No data to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirm = MessageBox.Show("Save all rows to database? (Will use exact column names: StudentId, FirstName, MiddleName, LastName, Birthday, Sex, CourseId, ContactNo, Email, Section, FacultyId)", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Dim errors As New List(Of String)

        Try
            Using con As New MySqlConnection(ModuleDB.connString)
                con.Open()

                ' Define DB columns list (all required fields)
                Dim dbCols As New List(Of String) From {"StudentId", "FirstName", "MiddleName", "LastName", "Birthday", "Sex", "CourseId", "ContactNo", "Email", "Section", "FacultyId"}
                Dim colList As String = String.Join(", ", dbCols.Select(Function(c) $"`{c}`"))
                Dim paramList As String = String.Join(", ", dbCols.Select(Function(c) $"@{c}"))
                Dim updateList As String = String.Join(", ", dbCols.Select(Function(c) $"`{c}` = VALUES(`{c}`)"))
                Dim sql As String = $"INSERT INTO `student` ({colList}) VALUES ({paramList}) ON DUPLICATE KEY UPDATE {updateList};"

                ' We'll handle row-by-row to avoid aborting entire batch on single bad row
                For rowIndex As Integer = 0 To sourceTable.Rows.Count - 1
                    Dim r As DataRow = sourceTable.Rows(rowIndex)
                    Try
                        ' Extract values (use exact column names if present, else empty)
                        Dim studentIdVal As String = If(sourceTable.Columns.Contains("StudentId"), r("StudentId").ToString().Trim(), "")
                        Dim fnameVal As String = If(sourceTable.Columns.Contains("FirstName"), r("FirstName").ToString().Trim(), "")
                        Dim mnameVal As String = If(sourceTable.Columns.Contains("MiddleName"), r("MiddleName").ToString().Trim(), "")
                        Dim lnameVal As String = If(sourceTable.Columns.Contains("LastName"), r("LastName").ToString().Trim(), "")
                        Dim sexVal As String = If(sourceTable.Columns.Contains("Sex"), r("Sex").ToString().Trim(), "")
                        Dim contactVal As String = If(sourceTable.Columns.Contains("ContactNo"), r("ContactNo").ToString().Trim(), "")
                        Dim emailVal As String = If(sourceTable.Columns.Contains("Email"), r("Email").ToString().Trim(), "")
                        Dim sectionVal As String = If(sourceTable.Columns.Contains("Section"), r("Section").ToString().Trim(), "")
                        Dim facultyVal As String = If(sourceTable.Columns.Contains("FacultyId"), r("FacultyId").ToString().Trim(), "")

                        ' Birthday handling
                        Dim birthdayValObj As Object = DBNull.Value
                        If sourceTable.Columns.Contains("Birthday") Then
                            Dim rawB = r("Birthday").ToString().Trim()
                            If Not String.IsNullOrEmpty(rawB) Then
                                Dim parsedDate As Date
                                If Date.TryParse(rawB, parsedDate) Then
                                    birthdayValObj = parsedDate.Date
                                Else
                                    Dim dbl As Double
                                    If Double.TryParse(rawB, dbl) Then
                                        Try
                                            parsedDate = Date.FromOADate(dbl)
                                            birthdayValObj = parsedDate.Date
                                        Catch
                                            birthdayValObj = DBNull.Value
                                        End Try
                                    Else
                                        birthdayValObj = DBNull.Value
                                        errors.Add($"Row {rowIndex + 1}: Invalid Birthday '{rawB}'. Saved as NULL.")
                                    End If
                                End If
                            End If
                        End If

                        ' Course resolution
                        Dim courseIdResolved As String = Nothing
                        If sourceTable.Columns.Contains("CourseId") Then
                            Dim rawCid = r("CourseId").ToString().Trim()
                            If Not String.IsNullOrEmpty(rawCid) Then
                                Using cmdCheck As New MySqlCommand("SELECT CourseId FROM Course WHERE CourseId = @c LIMIT 1", con)
                                    cmdCheck.Parameters.AddWithValue("@c", rawCid)
                                    Dim res = cmdCheck.ExecuteScalar()
                                    If res IsNot Nothing Then courseIdResolved = res.ToString()
                                End Using
                            End If
                        End If

                        ' Generate StudentId if missing
                        If String.IsNullOrEmpty(studentIdVal) Then studentIdVal = GenerateStudentID()

                        ' Insert/update row
                        Using cmd As New MySqlCommand(sql, con)
                            cmd.Parameters.Add("@StudentId", MySqlDbType.VarChar).Value = studentIdVal
                            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = fnameVal
                            cmd.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = mnameVal
                            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = lnameVal
                            cmd.Parameters.Add("@Birthday", MySqlDbType.Date).Value = If(birthdayValObj Is DBNull.Value, DBNull.Value, CType(birthdayValObj, Date))
                            cmd.Parameters.Add("@Sex", MySqlDbType.VarChar).Value = sexVal
                            cmd.Parameters.Add("@CourseId", MySqlDbType.VarChar).Value = If(String.IsNullOrEmpty(courseIdResolved), DBNull.Value, courseIdResolved)
                            cmd.Parameters.Add("@ContactNo", MySqlDbType.VarChar).Value = contactVal
                            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = emailVal
                            cmd.Parameters.Add("@Section", MySqlDbType.VarChar).Value = sectionVal
                            cmd.Parameters.Add("@FacultyId", MySqlDbType.VarChar).Value = facultyVal

                            cmd.ExecuteNonQuery()
                        End Using

                    Catch exRow As Exception
                        errors.Add($"Row {rowIndex + 1}: {exRow.Message}")
                    End Try
                Next
            End Using

        Catch ex As Exception
            MessageBox.Show("Fatal saving error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Show summary
        If errors.Count = 0 Then
            MessageBox.Show("Save complete. Database updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim summary = $"Finished with {errors.Count} issue(s). First 20 shown:" & vbCrLf & vbCrLf &
                          String.Join(vbCrLf, errors.Take(20))
            MessageBox.Show(summary, "Completed with issues", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Me.Close()
    End Sub

    ' Dummy GenerateStudentID function - replace with your own logic
    Private Function GenerateStudentID() As String
        Return "S" & (New Random().Next(100, 999)).ToString("D3")
    End Function
End Class
