Imports DocumentFormat.OpenXml.Office2010.PowerPoint
Imports MySql.Data.MySqlClient
Imports Xceed.Words.NET

Public Class frmPrintSummary
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        Me.Close()
    End Sub

    Private Sub frmPrintSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssessmentData(dgvPreview)
    End Sub

    Private Sub btnPrintSummary_Click(sender As Object, e As EventArgs) Handles btnPrintSummary.Click
        If dgvPreview.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record.")
            Return
        End If

        PrintSummary(dgvPreview.CurrentRow.Cells("AssessmentId").Value.ToString())
    End Sub


    Sub GenerateSummary(studentName As String,
                    company As String,
                    section As String,
                    supervisor As String,
                    grade As String,
                    teacher As String,
                    startDate As Date,
                    endDate As Date,
                    remarks As String,
                    q() As Integer)

        Dim templatePath As String = "C:\Users\HP\source\repos\eron063005\STUDENT-INTERNSHIP-MANAGEMENT-SYSTEM\STUDENT INTERNSHIP MANAGEMENT SYSTEM\Resources\STUDENT-SUMMARY.docx"
        Dim outputPath As String = "C:\Users\HP\Desktop\Summary - " & studentName & ".docx"

        Dim doc As DocX = DocX.Load(templatePath)

        doc.ReplaceText("{Name}", studentName)
        doc.ReplaceText("{Company}", company)
        doc.ReplaceText("{CourseNYear}", section)
        doc.ReplaceText("{NameSuperviser}", supervisor)
        doc.ReplaceText("{TotalPoints}", grade)
        doc.ReplaceText("{NameStd}", studentName)
        doc.ReplaceText("{NameFac}", teacher)
        Dim startMonth As String = startDate.ToString("MMMM yyyy")
        Dim endMonth As String = endDate.ToString("MMMM yyyy")
        doc.ReplaceText("{Month}", startMonth & " – " & endMonth)
        doc.ReplaceText("{Rating}", remarks)
        ' Criteria replacements Q1..Q20
        For i As Integer = 1 To 20
            doc.ReplaceText("{Q" & i & "}", q(i).ToString())
        Next

        Try
            doc.SaveAs(outputPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        ' Open the generated file automatically
        Try
            Process.Start(New ProcessStartInfo(outputPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Could not open the file automatically: " & ex.Message)
        End Try

        MessageBox.Show("Summary generated: " & outputPath)

    End Sub
    Private Sub PrintSummary(assessmentId As String)

        Dim query As String = "
        SELECT 
            s.FirstName, s.MiddleName, s.LastName, s.Section,
            f.FName, f.LName,
            i.StartDate, i.EndDate,
            c.CompanyName,
            cc.CFirstName, cc.CMiddleInitial, cc.CLastName,
            a.AssessmentGrade,
            ac.Criteria1, ac.Criteria2, ac.Criteria3, ac.Criteria4, ac.Criteria5,
            ac.Criteria6, ac.Criteria7, ac.Criteria8, ac.Criteria9, ac.Criteria10,
            ac.Criteria11, ac.Criteria12, ac.Criteria13, ac.Criteria14, ac.Criteria15,
            ac.Criteria16, ac.Criteria17, ac.Criteria18, ac.Criteria19, ac.Criteria20, ac.Remarks
        FROM assessment a
        INNER JOIN student s ON a.StudentId = s.StudentId
        INNER JOIN internship i ON a.InternshipId = i.InternshipId
        INNER JOIN company_contact cc ON a.CompanyContactId = cc.CompanyContactId
        INNER JOIN company c ON cc.CompanyId = c.CompanyId
        INNER JOIN assessmentcriteria ac ON ac.AssessmentId = a.AssessmentId
        INNER JOIN faculty f ON s.FacultyId = f.FacultyId
        WHERE a.AssessmentId = @AssessmentId;
    "

        Dim table As New DataTable()

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@AssessmentId", assessmentId)

            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(table)
        End Using

        If table.Rows.Count = 0 Then
            MessageBox.Show("No data found.")
            Exit Sub
        End If

        Dim row = table.Rows(0)

        Dim middleName As String = row("MiddleName").ToString().Trim()
        Dim middleInitial As String = ""

        If middleName.Length > 0 Then
            middleInitial = middleName.Substring(0, 1).ToUpper() & ". "
        End If
        Dim studentName As String = row("FirstName") & " " & middleInitial & " " & row("LastName")
        Dim company As String = row("CompanyName")
        Dim section As String = row("Section")
        Dim supervisor As String = row("CFirstName") & " " & row("CMiddleInitial") & " " & row("CLastName")
        Dim grade As String = row("AssessmentGrade").ToString()
        Dim teacher As String = row("Fname") & " " & row("LName")
        Dim startDate As String = CDate(row("StartDate"))
        Dim endDate As String = CDate(row("EndDate"))
        Dim remark As String = row("Remarks")
        ' Load Criteria 1-20
        Dim q(20) As Integer
        For i As Integer = 1 To 20
            q(i) = Convert.ToInt32(row("Criteria" & i))
        Next

        GenerateSummary(studentName, company, section, supervisor, grade, teacher, startDate, endDate, remark, q)

    End Sub




End Class