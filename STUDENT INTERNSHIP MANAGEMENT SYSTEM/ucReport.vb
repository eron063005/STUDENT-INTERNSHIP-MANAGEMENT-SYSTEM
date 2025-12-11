Imports System.IO
Imports System.Text
Imports ExcelDataReader
Imports Microsoft.Web.WebView2.Core

Public Class ucReport

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click
        Dim ofd As New OpenFileDialog With {
    .Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv",
    .Title = "Select Excel or CSV file",
    .Multiselect = False
}

        If ofd.ShowDialog <> DialogResult.OK Then Return

        Dim filePath = ofd.FileName
        Dim ext = Path.GetExtension(filePath).ToLower

        ' Accept Excel or CSV; reject anything else
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
                ' =============== CSV LOADING ===============
                dt = New DataTable

                Using sr As New StreamReader(filePath)
                    Dim header = True
                    While Not sr.EndOfStream
                        Dim line = sr.ReadLine
                        Dim cols = line.Split(","c)

                        If header Then
                            ' Create table columns
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
                ' =============== EXCEL LOADING ===============
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

        Try
            Dim preview As New frmPreviewPythonvb(dt, filePath)
            Dim parentForm As Dashboard = FindForm()
            parentForm.ShowFormWithPadding(preview, leftPadding:=470, topPadding:=150, rightPadding:=416, bottomPadding:=150)
        Catch ex As Exception
            MessageBox.Show("Error showing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

