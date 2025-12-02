<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddStudent
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
        btnExitAddStd = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        mtxtAddStudentID = New MaskedTextBox()
        txtAddStdFirstname = New TextBox()
        txtAddStdMiddlename = New TextBox()
        txtAddStdLastname = New TextBox()
        mtxtAddStdContactNo = New MaskedTextBox()
        txtAddStdEmail = New TextBox()
        cmbAddStdSex = New ComboBox()
        cmbAddStdCourse = New ComboBox()
        btnAddStdCancel = New RoundedButton()
        btnAddStd = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        cmbAddCCId = New ComboBox()
        cmbAddCompName = New ComboBox()
        Label13 = New Label()
        Label14 = New Label()
        dtpAddBirthday = New DateTimePicker()
        cmbAddStdProf = New ComboBox()
        Label12 = New Label()
        Label11 = New Label()
        txtAddStdSection = New TextBox()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExitAddStd
        ' 
        btnExitAddStd.BackColor = Color.Transparent
        btnExitAddStd.Cursor = Cursors.Hand
        btnExitAddStd.FlatAppearance.BorderSize = 0
        btnExitAddStd.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddStd.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddStd.FlatStyle = FlatStyle.Flat
        btnExitAddStd.Image = My.Resources.Resources.Exitbtn26
        btnExitAddStd.Location = New Point(976, 54)
        btnExitAddStd.Name = "btnExitAddStd"
        btnExitAddStd.Size = New Size(55, 57)
        btnExitAddStd.TabIndex = 10
        btnExitAddStd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(433, 80)
        Label1.TabIndex = 11
        Label1.Text = "Add Student"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 27)
        Label2.TabIndex = 12
        Label2.Text = "Student ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 27)
        Label3.TabIndex = 13
        Label3.Text = "Firstname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(371, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 27)
        Label4.TabIndex = 14
        Label4.Text = "Middlename"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(736, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 27)
        Label5.TabIndex = 15
        Label5.Text = "Lastname"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 427)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 27)
        Label6.TabIndex = 16
        Label6.Text = "Contact No."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(454, 427)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 17
        Label7.Text = "Email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(27, 525)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 27)
        Label8.TabIndex = 18
        Label8.Text = "Birthday"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(301, 524)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 27)
        Label9.TabIndex = 19
        Label9.Text = "Sex"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label10.Location = New Point(421, 326)
        Label10.Name = "Label10"
        Label10.Size = New Size(166, 27)
        Label10.TabIndex = 20
        Label10.Text = "Course Name"
        ' 
        ' mtxtAddStudentID
        ' 
        mtxtAddStudentID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddStudentID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddStudentID.Location = New Point(27, 184)
        mtxtAddStudentID.Name = "mtxtAddStudentID"
        mtxtAddStudentID.ReadOnly = True
        mtxtAddStudentID.Size = New Size(326, 44)
        mtxtAddStudentID.TabIndex = 21
        ' 
        ' txtAddStdFirstname
        ' 
        txtAddStdFirstname.BorderStyle = BorderStyle.FixedSingle
        txtAddStdFirstname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddStdFirstname.Location = New Point(27, 279)
        txtAddStdFirstname.Name = "txtAddStdFirstname"
        txtAddStdFirstname.Size = New Size(326, 44)
        txtAddStdFirstname.TabIndex = 22
        ' 
        ' txtAddStdMiddlename
        ' 
        txtAddStdMiddlename.BorderStyle = BorderStyle.FixedSingle
        txtAddStdMiddlename.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddStdMiddlename.Location = New Point(364, 279)
        txtAddStdMiddlename.Name = "txtAddStdMiddlename"
        txtAddStdMiddlename.Size = New Size(365, 44)
        txtAddStdMiddlename.TabIndex = 23
        ' 
        ' txtAddStdLastname
        ' 
        txtAddStdLastname.BorderStyle = BorderStyle.FixedSingle
        txtAddStdLastname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddStdLastname.Location = New Point(739, 279)
        txtAddStdLastname.Name = "txtAddStdLastname"
        txtAddStdLastname.Size = New Size(323, 44)
        txtAddStdLastname.TabIndex = 24
        ' 
        ' mtxtAddStdContactNo
        ' 
        mtxtAddStdContactNo.BorderStyle = BorderStyle.FixedSingle
        mtxtAddStdContactNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddStdContactNo.Location = New Point(27, 457)
        mtxtAddStdContactNo.Name = "mtxtAddStdContactNo"
        mtxtAddStdContactNo.Size = New Size(424, 44)
        mtxtAddStdContactNo.TabIndex = 25
        ' 
        ' txtAddStdEmail
        ' 
        txtAddStdEmail.BorderStyle = BorderStyle.FixedSingle
        txtAddStdEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddStdEmail.Location = New Point(457, 457)
        txtAddStdEmail.Name = "txtAddStdEmail"
        txtAddStdEmail.Size = New Size(605, 44)
        txtAddStdEmail.TabIndex = 26
        ' 
        ' cmbAddStdSex
        ' 
        cmbAddStdSex.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbAddStdSex.FormattingEnabled = True
        cmbAddStdSex.Items.AddRange(New Object() {"Male ", "Female"})
        cmbAddStdSex.Location = New Point(309, 554)
        cmbAddStdSex.Name = "cmbAddStdSex"
        cmbAddStdSex.Size = New Size(218, 45)
        cmbAddStdSex.TabIndex = 28
        ' 
        ' cmbAddStdCourse
        ' 
        cmbAddStdCourse.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbAddStdCourse.FormattingEnabled = True
        cmbAddStdCourse.Location = New Point(421, 356)
        cmbAddStdCourse.Name = "cmbAddStdCourse"
        cmbAddStdCourse.Size = New Size(640, 45)
        cmbAddStdCourse.TabIndex = 29
        ' 
        ' btnAddStdCancel
        ' 
        btnAddStdCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStdCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStdCancel.BorderSize = 5
        btnAddStdCancel.CornerRadius = 10
        btnAddStdCancel.Cursor = Cursors.Hand
        btnAddStdCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStdCancel.FlatStyle = FlatStyle.Flat
        btnAddStdCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStdCancel.ForeColor = Color.Black
        btnAddStdCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddStdCancel.Location = New Point(697, 618)
        btnAddStdCancel.Name = "btnAddStdCancel"
        btnAddStdCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddStdCancel.Size = New Size(171, 63)
        btnAddStdCancel.TabIndex = 30
        btnAddStdCancel.Text = "Cancel "
        btnAddStdCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAddStd
        ' 
        btnAddStd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStd.BorderSize = 5
        btnAddStd.CornerRadius = 10
        btnAddStd.Cursor = Cursors.Hand
        btnAddStd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStd.FlatStyle = FlatStyle.Flat
        btnAddStd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStd.ForeColor = Color.Black
        btnAddStd.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddStd.Location = New Point(891, 618)
        btnAddStd.Name = "btnAddStd"
        btnAddStd.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddStd.Size = New Size(171, 63)
        btnAddStd.TabIndex = 31
        btnAddStd.Text = "Add"
        btnAddStd.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(cmbAddCCId)
        RoundedPanel1.Controls.Add(cmbAddCompName)
        RoundedPanel1.Controls.Add(Label13)
        RoundedPanel1.Controls.Add(Label14)
        RoundedPanel1.Controls.Add(dtpAddBirthday)
        RoundedPanel1.Controls.Add(cmbAddStdProf)
        RoundedPanel1.Controls.Add(Label12)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(txtAddStdSection)
        RoundedPanel1.Controls.Add(cmbAddStdCourse)
        RoundedPanel1.Controls.Add(cmbAddStdSex)
        RoundedPanel1.Controls.Add(btnAddStdCancel)
        RoundedPanel1.Controls.Add(btnAddStd)
        RoundedPanel1.Controls.Add(txtAddStdEmail)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(mtxtAddStdContactNo)
        RoundedPanel1.Controls.Add(mtxtAddStudentID)
        RoundedPanel1.Controls.Add(txtAddStdLastname)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(txtAddStdMiddlename)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(txtAddStdFirstname)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(-1, -1)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1087, 700)
        RoundedPanel1.TabIndex = 77
        ' 
        ' cmbAddCCId
        ' 
        cmbAddCCId.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbAddCCId.FormattingEnabled = True
        cmbAddCCId.Location = New Point(739, 184)
        cmbAddCCId.Name = "cmbAddCCId"
        cmbAddCCId.Size = New Size(326, 45)
        cmbAddCCId.TabIndex = 68
        ' 
        ' cmbAddCompName
        ' 
        cmbAddCompName.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbAddCompName.FormattingEnabled = True
        cmbAddCompName.Location = New Point(367, 183)
        cmbAddCompName.Name = "cmbAddCompName"
        cmbAddCompName.Size = New Size(362, 45)
        cmbAddCompName.TabIndex = 67
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label13.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(367, 153)
        Label13.Name = "Label13"
        Label13.Size = New Size(205, 27)
        Label13.TabIndex = 65
        Label13.Text = "Company Name "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label14.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(739, 154)
        Label14.Name = "Label14"
        Label14.Size = New Size(249, 27)
        Label14.TabIndex = 66
        Label14.Text = "Company Contact ID"
        ' 
        ' dtpAddBirthday
        ' 
        dtpAddBirthday.Location = New Point(27, 555)
        dtpAddBirthday.Name = "dtpAddBirthday"
        dtpAddBirthday.Size = New Size(250, 27)
        dtpAddBirthday.TabIndex = 44
        ' 
        ' cmbAddStdProf
        ' 
        cmbAddStdProf.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbAddStdProf.FormattingEnabled = True
        cmbAddStdProf.Location = New Point(549, 554)
        cmbAddStdProf.Name = "cmbAddStdProf"
        cmbAddStdProf.Size = New Size(512, 45)
        cmbAddStdProf.TabIndex = 43
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label12.Location = New Point(549, 524)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 27)
        Label12.TabIndex = 42
        Label12.Text = "Professor"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label11.Location = New Point(27, 327)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 27)
        Label11.TabIndex = 40
        Label11.Text = "Section"
        ' 
        ' txtAddStdSection
        ' 
        txtAddStdSection.BorderStyle = BorderStyle.FixedSingle
        txtAddStdSection.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddStdSection.Location = New Point(27, 357)
        txtAddStdSection.Name = "txtAddStdSection"
        txtAddStdSection.Size = New Size(389, 44)
        txtAddStdSection.TabIndex = 41
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 39
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 697)
        Controls.Add(Label2)
        Controls.Add(btnExitAddStd)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddStudent"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExitAddStd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mtxtAddStudentID As MaskedTextBox
    Friend WithEvents txtAddStdFirstname As TextBox
    Friend WithEvents txtAddStdMiddlename As TextBox
    Friend WithEvents txtAddStdLastname As TextBox
    Friend WithEvents mtxtAddStdContactNo As MaskedTextBox
    Friend WithEvents txtAddStdEmail As TextBox
    Friend WithEvents cmbAddStdSex As ComboBox
    Friend WithEvents cmbAddStdCourse As ComboBox
    Friend WithEvents btnAddStdCancel As RoundedButton
    Friend WithEvents btnAddStd As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAddStdSection As TextBox
    Friend WithEvents cmbAddStdProf As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpAddBirthday As DateTimePicker
    Friend WithEvents cmbAddCCId As ComboBox
    Friend WithEvents cmbAddCompName As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
