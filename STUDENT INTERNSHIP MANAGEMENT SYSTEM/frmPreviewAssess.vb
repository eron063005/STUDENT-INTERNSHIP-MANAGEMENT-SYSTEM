Imports System.IO
Imports System.Text
Imports ExcelDataReader
Imports System.Data
Public Class frmPreviewAssess

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
    End Sub
End Class