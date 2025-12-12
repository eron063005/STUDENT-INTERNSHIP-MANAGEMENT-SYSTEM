Imports System.IO
Imports System.Text
Imports ClosedXML.Excel

Public Class frmPreviewPythonvb
    Private sourceTable As DataTable
    Private filePath As String

    ' Constructor: pass imported DataTable
    Public Sub New(dt As DataTable, filePath As String)
        InitializeComponent()
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        sourceTable = dt
        Me.filePath = filePath
    End Sub

    Private Sub btnGenGraph_Click(sender As Object, e As EventArgs) Handles btnGenGraph.Click

        ' Save edited DGV to the original file
        If filePath.ToLower().EndsWith(".csv") Then
            SaveDgvToCsv(dgvPreview, filePath)
        ElseIf filePath.ToLower().EndsWith(".xlsx") Or filePath.ToLower().EndsWith(".xls") Then
            SaveDgvToExcel(dgvPreview, filePath)
        End If

        ' Run Python with the original file
        ModulePY.RunPythonScript(filePath)

    End Sub

    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        Me.Close()
    End Sub

    Private Sub frmPreviewPythonvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Trim column headers
            For i As Integer = 0 To sourceTable.Columns.Count - 1
                sourceTable.Columns(i).ColumnName = sourceTable.Columns(i).ColumnName.Trim()
            Next

            ' Bind table
            dgvPreview.DataSource = sourceTable

            ' Enable scrollbars
            dgvPreview.ScrollBars = ScrollBars.Both

            ' Prevent automatic stretching of all columns
            dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            ' Adjust each column based on content, with max width
            For Each col As DataGridViewColumn In dgvPreview.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                col.MinimumWidth = 80
                col.Width = Math.Min(col.Width, 250) ' limit max width
            Next

            ' Auto-size rows for text wrap
            dgvPreview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvPreview.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            ' Allow edits
            dgvPreview.AllowUserToAddRows = True
            dgvPreview.ReadOnly = False

        Catch ex As Exception
            MessageBox.Show("Error preparing preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try


    End Sub

    ' Function to save DataGridView to CSV
    Sub SaveDgvToCsv(dgv As DataGridView, filePath As String)

        Dim sb As New Text.StringBuilder()

        ' Write headers
        For i As Integer = 0 To dgv.Columns.Count - 1
            sb.Append(dgv.Columns(i).HeaderText)
            If i < dgv.Columns.Count - 1 Then sb.Append(",")
        Next
        sb.AppendLine()

        ' Write rows
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then

                For i As Integer = 0 To dgv.Columns.Count - 1
                    Dim value = row.Cells(i).Value?.ToString()

                    '' Only wrap in quotes IF needed
                    'If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(vbCr) OrElse value.Contains(vbLf) Then
                    '    ' Escape any double-quotes
                    '    value = value.Replace("""", """""")
                    '    value = $"""{value}"""
                    'End If

                    sb.Append(value)

                    If i < dgv.Columns.Count - 1 Then sb.Append(",")
                Next

                sb.AppendLine()
            End If
        Next

        IO.File.WriteAllText(filePath, sb.ToString())

    End Sub



    Sub SaveDgvToExcel(dgv As DataGridView, filePath As String)
        Dim wb As New XLWorkbook()
        Dim ws = wb.Worksheets.Add("Sheet1")

        ' Headers
        For c As Integer = 0 To dgv.Columns.Count - 1
            ws.Cell(1, c + 1).Value = dgv.Columns(c).HeaderText
        Next

        ' Data
        For r As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(r).IsNewRow Then
                For c As Integer = 0 To dgv.Columns.Count - 1
                    ws.Cell(r + 2, c + 1).Value = dgv.Rows(r).Cells(c).Value
                Next
            End If
        Next

        wb.SaveAs(filePath)
    End Sub




End Class