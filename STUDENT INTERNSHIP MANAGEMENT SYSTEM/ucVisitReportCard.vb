Public Class ucVisitReportCard
    Dim intershipId As String
    Dim visitDate As String
    Dim evaluation As String
    Public Sub New(visitId As String, intershipId As String, VisitDate As String, Evaluation As String, score As Integer, FirstName As String, MiddleName As String, LastName As String, companyName As String, FName As String, LName As String)
        InitializeComponent()

        lblVisitID.Text = visitId.ToString()
        Me.intershipId = intershipId
        Me.visitDate = VisitDate
        Dim d As Date = Date.Parse(VisitDate)
        lblDayVisit.Text = d.Day
        lblMonthVisit.Text = d.ToString("MMM")
        lblVisitSummary.Text = Evaluation
        lblVisitScore.Text = score
        lblVisitStudentName.Text = FirstName + " " + MiddleName + " " + LastName
        lblVisitCompName.Text = companyName
        lblVisitFacultyName.Text = FName + " " + LName
    End Sub

End Class