Imports System.IO
Imports System.Text
Imports ExcelDataReader
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmPreviewAssess
    Private _data As DataTable
    Private _filePath As String

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor that accepts DataTable and file path
    Public Sub New(data As DataTable, filePath As String)
        InitializeComponent()

        _data = data
        _filePath = filePath

        ' Initialize DataGridView
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        ' Add a DataGridView to the form
        Dim dgv As New DataGridView With {
            .Dock = DockStyle.Fill,
            .DataSource = _data,
            .ReadOnly = True,
            .AllowUserToAddRows = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        }
    End Sub

    Private Sub btnCancelPreviewAssess_Click(sender As Object, e As EventArgs) Handles btnCancelPreviewAssess.Click
        Me.Close()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim ofd As New OpenFileDialog With {
        .Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv",
        .Title = "Select Excel or CSV file",
        .Multiselect = False
    }

        If ofd.ShowDialog() <> DialogResult.OK Then Return

        Dim filePath = ofd.FileName
        Dim ext = Path.GetExtension(filePath).ToLower()

        If ext <> ".xlsx" AndAlso ext <> ".xls" AndAlso ext <> ".csv" Then
            MessageBox.Show("Only Excel (.xlsx, .xls) or CSV (.csv) files are allowed.",
                        "Unsupported File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return
        End If

        Dim dt As DataTable = Nothing

        Try
            If ext = ".csv" Then
                dt = New DataTable()
                Using sr As New StreamReader(filePath)
                    Dim header = True
                    While Not sr.EndOfStream
                        Dim line = sr.ReadLine()
                        Dim cols = line.Split(","c)

                        If header Then
                            For Each col In cols
                                dt.Columns.Add(col.Trim())
                            Next
                            header = False
                        Else
                            If cols.Length <> dt.Columns.Count Then
                                Dim rowValues(dt.Columns.Count - 1) As Object
                                For i = 0 To dt.Columns.Count - 1
                                    If i < cols.Length Then rowValues(i) = cols(i).Trim() Else rowValues(i) = String.Empty
                                Next
                                dt.Rows.Add(rowValues)
                            Else
                                dt.Rows.Add(cols)
                            End If
                        End If
                    End While
                End Using
            Else
                ' Excel
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

        ' ==============================
        ' Bind to DataGridView
        ' ==============================
        Try
            dgvPreviewAssess.DataSource = dt

            Try
                SaveToAssessmentCriteria(dt)
                MessageBox.Show("Data successfully saved to AssessmentCriteria!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving to database: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            dgvPreviewAssess.AutoGenerateColumns = True

            ' Column settings
            dgvPreviewAssess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvPreviewAssess.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvPreviewAssess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvPreviewAssess.ScrollBars = ScrollBars.Both

            ' Adjust row heights to fill dgv if few rows
            If dt.Rows.Count > 0 Then
                Dim totalRowHeight = dt.Rows.Count * dgvPreviewAssess.RowTemplate.Height
                Dim availableHeight = dgvPreviewAssess.ClientSize.Height - dgvPreviewAssess.ColumnHeadersHeight
                Dim newRowHeight As Integer = dgvPreviewAssess.RowTemplate.Height

                If totalRowHeight < availableHeight Then
                    newRowHeight = Math.Floor(availableHeight / dt.Rows.Count)
                End If

                For Each row As DataGridViewRow In dgvPreviewAssess.Rows
                    row.Height = newRowHeight
                Next
            End If

            ' Optional: make headers fully visible
            dgvPreviewAssess.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Dim parent As Dashboard = Me.FindForm()
            If parent IsNot Nothing Then
                ' Assuming your ucAssessment control is named "ucAssessment1"
                Dim assessControl = parent.Controls.OfType(Of ucAssessment)().FirstOrDefault()
                If assessControl IsNot Nothing Then
                    assessControl.LoadAssessmentData()
                End If
            End If
        Catch
        End Try

    End Sub

    Private Sub SaveToAssessmentCriteria(dt As DataTable)
        Using conn As New MySqlConnection(connString)
            conn.Open()

            For Each row As DataRow In dt.Rows
                Dim query As String = "
                INSERT INTO AssessmentCriteria
                (AssessmentId, Criteria1, Criteria2, Criteria3, Criteria4, Criteria5,
                 Criteria6, Criteria7, Criteria8, Criteria9, Criteria10,
                 Criteria11, Criteria12, Criteria13, Criteria14, Criteria15,
                 Criteria16, Criteria17, Criteria18, Criteria19, Criteria20, Remarks)
                VALUES
                (@AssessmentId, @C1, @C2, @C3, @C4, @C5,
                 @C6, @C7, @C8, @C9, @C10,
                 @C11, @C12, @C13, @C14, @C15,
                 @C16, @C17, @C18, @C19, @C20, @Remarks)
                ON DUPLICATE KEY UPDATE
                    Criteria1=@C1, Criteria2=@C2, Criteria3=@C3, Criteria4=@C4, Criteria5=@C5,
                    Criteria6=@C6, Criteria7=@C7, Criteria8=@C8, Criteria9=@C9, Criteria10=@C10,
                    Criteria11=@C11, Criteria12=@C12, Criteria13=@C13, Criteria14=@C14, Criteria15=@C15,
                    Criteria16=@C16, Criteria17=@C17, Criteria18=@C18, Criteria19=@C19, Criteria20=@C20,
                    Remarks=@Remarks
            "

                Using cmd As New MySqlCommand(query, conn)

                    ' REQUIRED
                    cmd.Parameters.AddWithValue("@AssessmentId", row("AssessmentId"))

                    ' Handle Criteria1–20
                    For i As Integer = 1 To 20
                        If dt.Columns.Contains("Criteria" & i) Then
                            cmd.Parameters.AddWithValue("@C" & i, row("Criteria" & i))
                        Else
                            cmd.Parameters.AddWithValue("@C" & i, DBNull.Value)
                        End If
                    Next

                    ' Remarks
                    If dt.Columns.Contains("Remarks") Then
                        cmd.Parameters.AddWithValue("@Remarks", row("Remarks"))
                    Else
                        cmd.Parameters.AddWithValue("@Remarks", DBNull.Value)
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub



End Class