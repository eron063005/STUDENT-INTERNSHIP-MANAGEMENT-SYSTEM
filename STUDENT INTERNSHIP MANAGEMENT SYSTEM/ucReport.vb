Imports System.IO
Imports System.Text
Imports ExcelDataReader
Imports Microsoft.Web.WebView2.Core

Public Class ucReport
    Private Sub btnGenerateGraph_Click(sender As Object, e As EventArgs)
        'RunPythonScript()
        'picCounterPlot.Image = Image.FromFile("resources\countplot.png")
        'picConfusionMatrix.Image = Image.FromFile("resources\confusion_matrix.png")
    End Sub

    Private Async Sub btnViewCountPlot_Click(sender As Object, e As EventArgs) Handles btnViewCountPlot.Click
        Dim htmlPath As String = "C:\Users\User\Documents\VBNET\STUDENT INTERNSHIP MANAGEMENT SYSTEM\STUDENT INTERNSHIP MANAGEMENT SYSTEM\python\Count Plot.html"
        If Not IO.File.Exists(htmlPath) Then Return
        Await WebView21Report.EnsureCoreWebView2Async()
        WebView21Report.CoreWebView2.Navigate(New Uri(htmlPath).AbsoluteUri)
    End Sub

    Private Async Sub btnViewConfuseMatriz_Click(sender As Object, e As EventArgs) Handles btnViewConfuseMatriz.Click
        Dim htmlPath As String = "C:\Users\User\Documents\VBNET\STUDENT INTERNSHIP MANAGEMENT SYSTEM\STUDENT INTERNSHIP MANAGEMENT SYSTEM\python\Confusion Matrix.html"
        If Not IO.File.Exists(htmlPath) Then Return
        Await WebView22Report.EnsureCoreWebView2Async()
        WebView22Report.CoreWebView2.Navigate(New Uri(htmlPath).AbsoluteUri)
    End Sub

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click
        Dim ofd As New OpenFileDialog() With {
    .Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv",
    .Title = "Select Excel or CSV file",
    .Multiselect = False
}

        If ofd.ShowDialog() <> DialogResult.OK Then Return

        Dim filePath As String = ofd.FileName
        Dim ext As String = Path.GetExtension(filePath).ToLower()

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
                dt = New DataTable()

                Using sr As New StreamReader(filePath)
                    Dim header As Boolean = True
                    While Not sr.EndOfStream
                        Dim line As String = sr.ReadLine()
                        Dim cols = line.Split(","c)

                        If header Then
                            ' Create table columns
                            For Each col As String In cols
                                dt.Columns.Add(col.Trim())
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
                        Dim conf = New ExcelDataSetConfiguration() With {
                    .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {.UseHeaderRow = True}
                }
                        Dim ds As DataSet = reader.AsDataSet(conf)
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
            Dim parentForm As Dashboard = Me.FindForm()
            parentForm.ShowFormWithPadding(preview, leftPadding:=470, topPadding:=150, rightPadding:=416, bottomPadding:=150)
        Catch ex As Exception
            MessageBox.Show("Error showing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

