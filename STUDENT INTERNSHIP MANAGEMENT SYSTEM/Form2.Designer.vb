<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        frmFacProfile = New Button()
        lblSubTxt = New Label()
        btnExit = New Button()
        lblTitleNav = New Label()
        btnDashboard = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        btnAssessment = New Button()
        Panel3 = New Panel()
        btnReport = New Button()
        btnVisit = New Button()
        btnPlacement = New Button()
        btnCompany = New Button()
        btnStudent = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        panelMain = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(122), CByte(141), CByte(158))
        Panel1.Controls.Add(frmFacProfile)
        Panel1.Controls.Add(lblSubTxt)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(lblTitleNav)
        Panel1.Location = New Point(400, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1520, 196)
        Panel1.TabIndex = 1
        ' 
        ' frmFacProfile
        ' 
        frmFacProfile.Cursor = Cursors.Hand
        frmFacProfile.FlatAppearance.BorderSize = 0
        frmFacProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(122), CByte(141), CByte(158))
        frmFacProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(122), CByte(141), CByte(158))
        frmFacProfile.FlatStyle = FlatStyle.Flat
        frmFacProfile.Image = CType(resources.GetObject("frmFacProfile.Image"), Image)
        frmFacProfile.Location = New Point(1293, 23)
        frmFacProfile.Name = "frmFacProfile"
        frmFacProfile.Size = New Size(146, 143)
        frmFacProfile.TabIndex = 11
        frmFacProfile.UseVisualStyleBackColor = True
        ' 
        ' lblSubTxt
        ' 
        lblSubTxt.AutoSize = True
        lblSubTxt.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubTxt.Location = New Point(52, 153)
        lblSubTxt.Name = "lblSubTxt"
        lblSubTxt.Size = New Size(104, 34)
        lblSubTxt.TabIndex = 10
        lblSubTxt.Text = "Label3"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.Exit2
        btnExit.Location = New Point(1485, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(33, 32)
        btnExit.TabIndex = 8
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblTitleNav
        ' 
        lblTitleNav.AutoSize = True
        lblTitleNav.Font = New Font("Century Gothic", 75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleNav.ForeColor = Color.White
        lblTitleNav.Location = New Point(17, 19)
        lblTitleNav.Name = "lblTitleNav"
        lblTitleNav.Size = New Size(732, 147)
        lblTitleNav.TabIndex = 0
        lblTitleNav.Text = "Dashboard"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Century Gothic", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Image = My.Resources.Resources.Dashboard
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(1, 449)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(403, 85)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleRight
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnAssessment)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnReport)
        Panel2.Controls.Add(btnVisit)
        Panel2.Controls.Add(btnPlacement)
        Panel2.Controls.Add(btnCompany)
        Panel2.Controls.Add(btnStudent)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(406, 1080)
        Panel2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(92, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 28)
        Label2.TabIndex = 9
        Label2.Text = "Management System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(63, 328)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 41)
        Label1.TabIndex = 3
        Label1.Text = "Student Internship"
        ' 
        ' btnAssessment
        ' 
        btnAssessment.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnAssessment.Cursor = Cursors.Hand
        btnAssessment.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnAssessment.FlatStyle = FlatStyle.Flat
        btnAssessment.Font = New Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAssessment.ForeColor = Color.White
        btnAssessment.Image = My.Resources.Resources.Assessment
        btnAssessment.ImageAlign = ContentAlignment.MiddleLeft
        btnAssessment.Location = New Point(1, 874)
        btnAssessment.Name = "btnAssessment"
        btnAssessment.Size = New Size(403, 85)
        btnAssessment.TabIndex = 11
        btnAssessment.Text = "Assessment "
        btnAssessment.TextAlign = ContentAlignment.MiddleRight
        btnAssessment.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(43, 416)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(318, 7)
        Panel3.TabIndex = 10
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnReport.Cursor = Cursors.Hand
        btnReport.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReport.ForeColor = Color.White
        btnReport.Image = My.Resources.Resources.Report1
        btnReport.ImageAlign = ContentAlignment.MiddleLeft
        btnReport.Location = New Point(1, 959)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(403, 85)
        btnReport.TabIndex = 8
        btnReport.Text = "      Report"
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' btnVisit
        ' 
        btnVisit.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnVisit.Cursor = Cursors.Hand
        btnVisit.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnVisit.FlatStyle = FlatStyle.Flat
        btnVisit.Font = New Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisit.ForeColor = Color.White
        btnVisit.Image = My.Resources.Resources.Visit1
        btnVisit.ImageAlign = ContentAlignment.MiddleLeft
        btnVisit.Location = New Point(1, 789)
        btnVisit.Name = "btnVisit"
        btnVisit.Size = New Size(403, 85)
        btnVisit.TabIndex = 7
        btnVisit.Text = "       Visit"
        btnVisit.UseVisualStyleBackColor = False
        ' 
        ' btnPlacement
        ' 
        btnPlacement.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnPlacement.Cursor = Cursors.Hand
        btnPlacement.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnPlacement.FlatStyle = FlatStyle.Flat
        btnPlacement.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        btnPlacement.ForeColor = Color.White
        btnPlacement.Image = My.Resources.Resources.Placement
        btnPlacement.ImageAlign = ContentAlignment.MiddleLeft
        btnPlacement.Location = New Point(1, 704)
        btnPlacement.Name = "btnPlacement"
        btnPlacement.Size = New Size(403, 85)
        btnPlacement.TabIndex = 6
        btnPlacement.Text = "Placement "
        btnPlacement.TextAlign = ContentAlignment.MiddleRight
        btnPlacement.UseVisualStyleBackColor = False
        ' 
        ' btnCompany
        ' 
        btnCompany.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnCompany.Cursor = Cursors.Hand
        btnCompany.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnCompany.FlatStyle = FlatStyle.Flat
        btnCompany.Font = New Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompany.ForeColor = Color.White
        btnCompany.Image = My.Resources.Resources.Company
        btnCompany.ImageAlign = ContentAlignment.MiddleLeft
        btnCompany.Location = New Point(1, 619)
        btnCompany.Name = "btnCompany"
        btnCompany.Size = New Size(403, 85)
        btnCompany.TabIndex = 5
        btnCompany.Text = "Company"
        btnCompany.TextAlign = ContentAlignment.MiddleRight
        btnCompany.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(80), CByte(111), CByte(138))
        btnStudent.Cursor = Cursors.Hand
        btnStudent.FlatAppearance.BorderColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Image = My.Resources.Resources.Students
        btnStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnStudent.Location = New Point(1, 534)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(403, 85)
        btnStudent.TabIndex = 4
        btnStudent.Text = "Student "
        btnStudent.TextAlign = ContentAlignment.MiddleRight
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.Vaia_Logo__Custom_1
        PictureBox1.Location = New Point(53, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 288)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.VAIA_SCHOOL_DIFF
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(406, 1080)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' panelMain
        ' 
        panelMain.Location = New Point(407, 196)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1513, 884)
        panelMain.TabIndex = 3
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        ClientSize = New Size(1920, 1080)
        Controls.Add(panelMain)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnVisit As Button
    Friend WithEvents btnPlacement As Button
    Friend WithEvents btnCompany As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents lblTitleNav As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAssessment As Button
    Friend WithEvents lblSubTxt As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents frmFacProfile As Button
End Class
