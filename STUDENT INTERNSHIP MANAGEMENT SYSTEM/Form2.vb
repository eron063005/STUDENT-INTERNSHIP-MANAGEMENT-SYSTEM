Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports ExcelDataReader.Log

Public Class Dashboard
    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'ITO YA TRANSPARENT NA DIN SYA
        TransparencyHelper.MakeTransparent(Label1, PictureBox2)
        TransparencyHelper.MakeTransparent(Label2, PictureBox2)
        TransparencyHelper.MakeTransparent(PictureBox1, PictureBox2)
    End Sub

    ' Dashboard.vb
    Public Sub ShowFormWithPadding(frm As Form, leftPadding As Integer, topPadding As Integer,
                               rightPadding As Integer, bottomPadding As Integer)
        ' Fixed size, hindi affected ng padding
        frm.StartPosition = FormStartPosition.Manual

        ' Compute location to center relative sa Dashboard
        ' Center X = leftPadding + (Dashboard.Width - leftPadding - rightPadding - frm.Width) / 2
        Dim x As Integer = leftPadding + ((Me.Width - leftPadding - rightPadding - frm.Width) \ 2)
        Dim y As Integer = topPadding + ((Me.Height - topPadding - bottomPadding - frm.Height) \ 2)

        frm.Location = New Point(x, y)

        ' Show as modal
        frm.ShowDialog()
    End Sub

    ' 🔹 Declare UserControls
    Private ucDash As ucDashboard
    Private ucStudent As ucStudent
    Private ucCompany As ucCompany
    Private ucPlacement As ucPlacement
    Private ucVisit As ucVisit
    Private ucAssessment As ucAssessment
    Private ucReport As ucReport

    ' 🔹 Track current active nav button
    Private activeNavButton As Button = Nothing

    ' 🔹 Colors
    Private ReadOnly DefaultColor As Color = Color.FromArgb(80, 111, 138)
    Private ReadOnly ActiveColor As Color = Color.FromArgb(140, 201, 255)

    ' 🔹 Load default UserControl when form opens
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucDash = New ucDashboard()
        ShowControl(ucDash)
        lblTitleNav.Text = "Dashboard"
        lblSubTxt.Text = "Overview of internship management system"


        ' Set initial button states (assume btnDashboard is the default)
        InitializeNavButtons()
        SetActiveNavButton(btnDashboard)
    End Sub

    ' 🔹 Initialize nav buttons' default appearance
    Private Sub InitializeNavButtons()
        ' Add here lahat ng nav buttons para siguradong naka-default ang color
        Dim navButtons As Button() = {btnDashboard, btnStudent, btnCompany, btnPlacement, btnVisit, btnAssessment, btnReport}

        For Each b As Button In navButtons
            If b Is Nothing Then Continue For

            ' set default BackColor
            b.BackColor = DefaultColor

            ' if this is our RoundedButton with FillColor, set that too (silently try)
            Try
                If TypeOf b Is RoundedButton Then
                    DirectCast(b, RoundedButton).FillColor = DefaultColor
                End If
            Catch ex As Exception
                ' ignore - only best-effort
            End Try

            ' Optional: set ForeColor so it contrasts (adjust if needed)
            b.ForeColor = Color.White
        Next
    End Sub

    ' 🔹 Set a button as active (highlight) and reset previous one
    Private Sub SetActiveNavButton(btn As Button)
        If btn Is Nothing Then Return

        ' If same button clicked again, do nothing (or keep it active)
        If activeNavButton Is btn Then Return

        ' Reset previous
        If activeNavButton IsNot Nothing Then
            activeNavButton.BackColor = DefaultColor
            Try
                If TypeOf activeNavButton Is RoundedButton Then
                    DirectCast(activeNavButton, RoundedButton).FillColor = DefaultColor
                End If
            Catch ex As Exception
            End Try
        End If

        ' Set new active
        btn.BackColor = ActiveColor
        Try
            If TypeOf btn Is RoundedButton Then
                DirectCast(btn, RoundedButton).FillColor = ActiveColor
            End If
        Catch ex As Exception
        End Try

        activeNavButton = btn
    End Sub

    ' 🔹 Function to load UserControl inside the panel
    Private Sub ShowControl(ctrl As UserControl)
        If panelMain Is Nothing Then
            MessageBox.Show("panelMain not found on the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        panelMain.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        panelMain.Controls.Add(ctrl)
        ctrl.BringToFront()
    End Sub

    ' 🔹 Button click events — bawat handler nagse-set din ng active button
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If ucDash Is Nothing Then ucDash = New ucDashboard()
        ShowControl(ucDash)
        lblTitleNav.Text = "Dashboard"
        lblSubTxt.Text = "Overview of internship management system"
        SetActiveNavButton(DirectCast(sender, Button))
        LoadUpcomingVisits(ucDash.panelUV)
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        If ucStudent Is Nothing Then ucStudent = New ucStudent()
        ShowControl(ucStudent)
        lblTitleNav.Text = "Student"
        lblSubTxt.Text = "Manage student records and internship"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub

    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        If ucCompany Is Nothing Then ucCompany = New ucCompany()
        ShowControl(ucCompany)
        lblTitleNav.Text = "Company"
        lblSubTxt.Text = "Manage partner companies and contacts"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub

    Private Sub btnPlacement_Click(sender As Object, e As EventArgs) Handles btnPlacement.Click
        If ucPlacement Is Nothing Then ucPlacement = New ucPlacement()
        ShowControl(ucPlacement)
        lblTitleNav.Text = "Placement"
        lblSubTxt.Text = "Track and manage student internship placements"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub

    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        If ucVisit Is Nothing Then ucVisit = New ucVisit
        ShowControl(ucVisit)
        lblTitleNav.Text = "Visit"
        lblSubTxt.Text = "Track faculty visits and student evaluations"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub
    Private Sub btnAssessment_Click(sender As Object, e As EventArgs) Handles btnAssessment.Click
        If ucAssessment Is Nothing Then ucAssessment = New ucAssessment()
        ShowControl(ucAssessment)
        lblTitleNav.Text = "Assessment"
        lblSubTxt.Text = "Finalize the intern's performance and program requirements"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If ucReport Is Nothing Then ucReport = New ucReport()
        ShowControl(ucReport)
        lblTitleNav.Text = "Report"
        lblSubTxt.Text = "Generate and export system reports"
        SetActiveNavButton(DirectCast(sender, Button))
    End Sub

    ' 🔹 Exit button (not part of nav highlighting)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?",
                                 "Exit Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to Log Out?",
                                 "Log Out Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New LogIn ' Create a new instance
            loginForm.Show()
            Close() ' Optionally close the current form
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addForm As New frmFacProfile()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
End Class
