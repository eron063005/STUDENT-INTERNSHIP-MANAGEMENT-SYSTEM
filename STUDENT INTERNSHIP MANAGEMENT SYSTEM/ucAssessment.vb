Imports System.IO
Imports System.Text
Imports ExcelDataReader
Imports MySql.Data.MySqlClient

Public Class ucAssessment

    Private Sub btnAddAssessment_Click(sender As Object, e As EventArgs) Handles btnAddAssessment.Click
        Dim addForm As New frmAddAssessment()
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadAssessmentData()
    End Sub

    Private Sub btnEditAssessment_Click(sender As Object, e As EventArgs) Handles btnEditAssessment.Click
        ' Make sure a row is selected
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an assessment to edit.")
            Return
        End If

        Dim selectedRow = DataGridView1.SelectedRows(0)
        Dim assessmentId As String = selectedRow.Cells("AssessmentId").Value.ToString()

        ' Open edit form
        Dim editForm As New frmEditAssessment(assessmentId)


        ' Use your parent form ShowFormWithPadding
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(editForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)

        ' Refresh after editing
        LoadAssessmentData()
    End Sub


    Public Sub LoadAssessmentData()
        Dim currentFacultyId As String = LoggedFacultyID

        Dim sql As String = "
    SELECT 
        a.AssessmentId,
        CONCAT(s.FirstName, ' ', s.LastName) AS StudentName,
        CONCAT(cc.CFirstName, ' ', cc.CLastName) AS CompanyContactName,
        c.CompanyName,
        a.AssessmentGrade
    FROM assessment a
    JOIN student s ON a.StudentId = s.StudentId
    JOIN company_contact cc ON a.CompanyContactId = cc.CompanyContactId
    JOIN company c ON cc.CompanyId = c.CompanyId
    WHERE s.FacultyId = @facultyId
"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@facultyId", currentFacultyId)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        DataGridView1.DataSource = dt

                        ' Auto formatting
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView1.ReadOnly = True
                        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        DataGridView1.AllowUserToResizeColumns = False
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assessment data: " & ex.Message)
        End Try
    End Sub


    Private Sub ucAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssessmentData()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Ensure a valid row is clicked
        If e.RowIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)

            ' Get the AssessmentId of the clicked row
            Dim assessmentId As String = selectedRow.Cells("AssessmentId").Value.ToString()

            ' Open edit form and pass the selected AssessmentId
            Dim editForm As New frmEditAssessment(assessmentId)
            editForm.AssessmentIdToEdit = assessmentId
            editForm.ShowDialog()

            ' Refresh DataGridView after editing
            LoadAssessmentData() ' <-- use the correct method from this UserControl
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv",
            .Title = "Select Excel or CSV file",
            .Multiselect = False
        }

        If ofd.ShowDialog() <> DialogResult.OK Then Return

        Dim filePath = ofd.FileName
        Dim ext = Path.GetExtension(filePath).ToLower()

        ' Validate file type
        If ext <> ".csv" AndAlso ext <> ".xls" AndAlso ext <> ".xlsx" Then
            MessageBox.Show("Only Excel (.xlsx, .xls) or CSV (.csv) files are allowed.",
                            "Unsupported File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dt As DataTable = Nothing

        Try
            If ext = ".csv" Then
                ' Load CSV
                dt = New DataTable()
                Using sr As New StreamReader(filePath)
                    Dim header = True
                    While Not sr.EndOfStream
                        Dim line = sr.ReadLine()
                        Dim cols = line.Split(","c)

                        If header Then
                            For Each col In cols
                                dt.Columns.Add(col.Trim)
                            Next
                            header = False
                        Else
                            dt.Rows.Add(cols)
                        End If
                    End While
                End Using
            Else
                ' Load Excel
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
                Using stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using reader = ExcelReaderFactory.CreateReader(stream)
                        Dim conf = New ExcelDataSetConfiguration With {
                            .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration With {.UseHeaderRow = True}
                        }
                        Dim ds = reader.AsDataSet(conf)
                        dt = ds.Tables(0)
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Show preview in frmPreviewAssess (no StudentSupervisor logic needed)
        Try
            Dim preview As New frmPreviewAssess(dt, filePath)
            Dim parentForm As Dashboard = Me.FindForm()
            parentForm.ShowFormWithPadding(preview, leftPadding:=470, topPadding:=150, rightPadding:=416, bottomPadding:=150)
        Catch ex As Exception
            MessageBox.Show("Error showing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

