<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVisitReportCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RoundedPanel1 = New RoundedPanel()
        Panel1 = New Panel()
        lblVisitID = New Label()
        Label11 = New Label()
        lblVisitScore = New Label()
        Label9 = New Label()
        lblVisitSummary = New Label()
        lblVisitStudentName = New Label()
        Label6 = New Label()
        lblVisitFacultyName = New Label()
        Label4 = New Label()
        lblVisitCompName = New Label()
        lblMonthVisit = New Label()
        lblDayVisit = New Label()
        RoundedPanel2 = New RoundedPanel()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BorderColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(lblVisitID)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(lblVisitScore)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(lblVisitSummary)
        RoundedPanel1.Controls.Add(lblVisitStudentName)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(lblVisitFacultyName)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(lblVisitCompName)
        RoundedPanel1.Controls.Add(lblMonthVisit)
        RoundedPanel1.Controls.Add(lblDayVisit)
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(3, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1335, 232)
        RoundedPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        Panel1.Location = New Point(58, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 67)
        Panel1.TabIndex = 13
        ' 
        ' lblVisitID
        ' 
        lblVisitID.AutoSize = True
        lblVisitID.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitID.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        lblVisitID.Location = New Point(1245, 174)
        lblVisitID.Name = "lblVisitID"
        lblVisitID.Size = New Size(61, 19)
        lblVisitID.TabIndex = 11
        lblVisitID.Text = "V1001"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label11.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label11.Location = New Point(1174, 174)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 19)
        Label11.TabIndex = 10
        Label11.Text = "Visit ID:"
        ' 
        ' lblVisitScore
        ' 
        lblVisitScore.AutoSize = True
        lblVisitScore.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitScore.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVisitScore.Location = New Point(1226, 38)
        lblVisitScore.Name = "lblVisitScore"
        lblVisitScore.Size = New Size(76, 56)
        lblVisitScore.TabIndex = 9
        lblVisitScore.Text = "92"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label9.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(1237, 94)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 18)
        Label9.TabIndex = 8
        Label9.Text = "Score"
        ' 
        ' lblVisitSummary
        ' 
        lblVisitSummary.AutoSize = True
        lblVisitSummary.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitSummary.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVisitSummary.Location = New Point(105, 174)
        lblVisitSummary.Name = "lblVisitSummary"
        lblVisitSummary.Size = New Size(661, 38)
        lblVisitSummary.TabIndex = 7
        lblVisitSummary.Text = "Excellent progress. Student demonstrates strong technical skills and professional" & vbCrLf & " attitude."
        ' 
        ' lblVisitStudentName
        ' 
        lblVisitStudentName.AutoSize = True
        lblVisitStudentName.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitStudentName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblVisitStudentName.Location = New Point(209, 113)
        lblVisitStudentName.Name = "lblVisitStudentName"
        lblVisitStudentName.Size = New Size(212, 23)
        lblVisitStudentName.TabIndex = 6
        lblVisitStudentName.Text = "Sam Aidan Gonzaga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.Location = New Point(115, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 23)
        Label6.TabIndex = 5
        Label6.Text = "Student:"
        ' 
        ' lblVisitFacultyName
        ' 
        lblVisitFacultyName.AutoSize = True
        lblVisitFacultyName.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitFacultyName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblVisitFacultyName.Location = New Point(209, 82)
        lblVisitFacultyName.Name = "lblVisitFacultyName"
        lblVisitFacultyName.Size = New Size(108, 23)
        lblVisitFacultyName.TabIndex = 4
        lblVisitFacultyName.Text = "Rose Dela"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.Location = New Point(116, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 23)
        Label4.TabIndex = 3
        Label4.Text = "Faculty:"
        ' 
        ' lblVisitCompName
        ' 
        lblVisitCompName.AutoSize = True
        lblVisitCompName.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblVisitCompName.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVisitCompName.Location = New Point(105, 26)
        lblVisitCompName.Name = "lblVisitCompName"
        lblVisitCompName.Size = New Size(561, 56)
        lblVisitCompName.TabIndex = 2
        lblVisitCompName.Text = "TechNova Solutions Inc."
        ' 
        ' lblMonthVisit
        ' 
        lblMonthVisit.AutoSize = True
        lblMonthVisit.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblMonthVisit.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthVisit.Location = New Point(42, 113)
        lblMonthVisit.Name = "lblMonthVisit"
        lblMonthVisit.Size = New Size(40, 19)
        lblMonthVisit.TabIndex = 1
        lblMonthVisit.Text = "Mar"
        ' 
        ' lblDayVisit
        ' 
        lblDayVisit.AutoSize = True
        lblDayVisit.BackColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        lblDayVisit.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDayVisit.ForeColor = Color.White
        lblDayVisit.Location = New Point(35, 57)
        lblDayVisit.Name = "lblDayVisit"
        lblDayVisit.Size = New Size(51, 37)
        lblDayVisit.TabIndex = 0
        lblDayVisit.Text = "10"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel2.BorderColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        RoundedPanel2.BorderSize = 5
        RoundedPanel2.CornerRadius = 100
        RoundedPanel2.FillColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        RoundedPanel2.Location = New Point(21, 39)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(78, 73)
        RoundedPanel2.TabIndex = 12
        ' 
        ' ucVisitReportCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(RoundedPanel1)
        Name = "ucVisitReportCard"
        Size = New Size(1347, 242)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblVisitID As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblVisitScore As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVisitSummary As Label
    Friend WithEvents lblVisitStudentName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblVisitFacultyName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVisitCompName As Label
    Friend WithEvents lblMonthVisit As Label
    Friend WithEvents lblDayVisit As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Panel1 As Panel

End Class
