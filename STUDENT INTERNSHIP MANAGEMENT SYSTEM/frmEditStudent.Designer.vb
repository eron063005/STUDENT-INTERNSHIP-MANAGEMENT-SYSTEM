<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditStudent
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
        btnExitEditStd = New Button()
        mtxtEditStudentID = New MaskedTextBox()
        btnSaveStd = New RoundedButton()
        btnEditStdCancel = New RoundedButton()
        cmbEditStdCourse = New ComboBox()
        cmbEditStdSex = New ComboBox()
        txtEditStdEmail = New TextBox()
        mtxtEditStdConNo = New MaskedTextBox()
        txtEditStdLastname = New TextBox()
        txtEditStdMiddlename = New TextBox()
        txtEditStdFirstname = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        dtpEditBirthday = New DateTimePicker()
        cmbEditStdProf = New ComboBox()
        Label12 = New Label()
        Label11 = New Label()
        txtEditStdSection = New TextBox()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExitEditStd
        ' 
        btnExitEditStd.BackColor = Color.Transparent
        btnExitEditStd.Cursor = Cursors.Hand
        btnExitEditStd.FlatAppearance.BorderSize = 0
        btnExitEditStd.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditStd.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditStd.FlatStyle = FlatStyle.Flat
        btnExitEditStd.Image = My.Resources.Resources.Exitbtn27
        btnExitEditStd.Location = New Point(976, 54)
        btnExitEditStd.Name = "btnExitEditStd"
        btnExitEditStd.Size = New Size(55, 57)
        btnExitEditStd.TabIndex = 9
        btnExitEditStd.UseVisualStyleBackColor = False
        ' 
        ' mtxtEditStudentID
        ' 
        mtxtEditStudentID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditStudentID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditStudentID.Location = New Point(27, 184)
        mtxtEditStudentID.Name = "mtxtEditStudentID"
        mtxtEditStudentID.ReadOnly = True
        mtxtEditStudentID.Size = New Size(326, 44)
        mtxtEditStudentID.TabIndex = 21
        ' 
        ' btnSaveStd
        ' 
        btnSaveStd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSaveStd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveStd.BorderSize = 5
        btnSaveStd.CornerRadius = 10
        btnSaveStd.Cursor = Cursors.Hand
        btnSaveStd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveStd.FlatStyle = FlatStyle.Flat
        btnSaveStd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSaveStd.ForeColor = Color.Black
        btnSaveStd.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveStd.Location = New Point(891, 618)
        btnSaveStd.Name = "btnSaveStd"
        btnSaveStd.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveStd.Size = New Size(171, 63)
        btnSaveStd.TabIndex = 53
        btnSaveStd.Text = "Save"
        btnSaveStd.UseVisualStyleBackColor = False
        ' 
        ' btnEditStdCancel
        ' 
        btnEditStdCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditStdCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditStdCancel.BorderSize = 5
        btnEditStdCancel.CornerRadius = 10
        btnEditStdCancel.Cursor = Cursors.Hand
        btnEditStdCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditStdCancel.FlatStyle = FlatStyle.Flat
        btnEditStdCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditStdCancel.ForeColor = Color.Black
        btnEditStdCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditStdCancel.Location = New Point(697, 618)
        btnEditStdCancel.Name = "btnEditStdCancel"
        btnEditStdCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditStdCancel.Size = New Size(171, 63)
        btnEditStdCancel.TabIndex = 52
        btnEditStdCancel.Text = "Cancel "
        btnEditStdCancel.UseVisualStyleBackColor = False
        ' 
        ' cmbEditStdCourse
        ' 
        cmbEditStdCourse.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbEditStdCourse.FormattingEnabled = True
        cmbEditStdCourse.Location = New Point(421, 356)
        cmbEditStdCourse.Name = "cmbEditStdCourse"
        cmbEditStdCourse.Size = New Size(640, 45)
        cmbEditStdCourse.TabIndex = 51
        ' 
        ' cmbEditStdSex
        ' 
        cmbEditStdSex.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbEditStdSex.FormattingEnabled = True
        cmbEditStdSex.Location = New Point(309, 554)
        cmbEditStdSex.Name = "cmbEditStdSex"
        cmbEditStdSex.Size = New Size(218, 45)
        cmbEditStdSex.TabIndex = 50
        ' 
        ' txtEditStdEmail
        ' 
        txtEditStdEmail.BorderStyle = BorderStyle.FixedSingle
        txtEditStdEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditStdEmail.Location = New Point(457, 457)
        txtEditStdEmail.Name = "txtEditStdEmail"
        txtEditStdEmail.Size = New Size(605, 44)
        txtEditStdEmail.TabIndex = 48
        ' 
        ' mtxtEditStdConNo
        ' 
        mtxtEditStdConNo.BorderStyle = BorderStyle.FixedSingle
        mtxtEditStdConNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditStdConNo.Location = New Point(27, 457)
        mtxtEditStdConNo.Name = "mtxtEditStdConNo"
        mtxtEditStdConNo.Size = New Size(424, 44)
        mtxtEditStdConNo.TabIndex = 47
        ' 
        ' txtEditStdLastname
        ' 
        txtEditStdLastname.BorderStyle = BorderStyle.FixedSingle
        txtEditStdLastname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditStdLastname.Location = New Point(739, 279)
        txtEditStdLastname.Name = "txtEditStdLastname"
        txtEditStdLastname.Size = New Size(323, 44)
        txtEditStdLastname.TabIndex = 46
        ' 
        ' txtEditStdMiddlename
        ' 
        txtEditStdMiddlename.BorderStyle = BorderStyle.FixedSingle
        txtEditStdMiddlename.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditStdMiddlename.Location = New Point(364, 279)
        txtEditStdMiddlename.Name = "txtEditStdMiddlename"
        txtEditStdMiddlename.Size = New Size(365, 44)
        txtEditStdMiddlename.TabIndex = 45
        ' 
        ' txtEditStdFirstname
        ' 
        txtEditStdFirstname.BorderStyle = BorderStyle.FixedSingle
        txtEditStdFirstname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditStdFirstname.Location = New Point(27, 279)
        txtEditStdFirstname.Name = "txtEditStdFirstname"
        txtEditStdFirstname.Size = New Size(326, 44)
        txtEditStdFirstname.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label10.Location = New Point(421, 326)
        Label10.Name = "Label10"
        Label10.Size = New Size(166, 27)
        Label10.TabIndex = 43
        Label10.Text = "Course Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(301, 524)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 27)
        Label9.TabIndex = 42
        Label9.Text = "Sex"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(27, 525)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 27)
        Label8.TabIndex = 41
        Label8.Text = "Birthday"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(454, 427)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 40
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 427)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 27)
        Label6.TabIndex = 39
        Label6.Text = "Contact No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(736, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 27)
        Label5.TabIndex = 38
        Label5.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(371, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 27)
        Label4.TabIndex = 37
        Label4.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 27)
        Label3.TabIndex = 36
        Label3.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 27)
        Label2.TabIndex = 35
        Label2.Text = "Student ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(410, 80)
        Label1.TabIndex = 34
        Label1.Text = "Edit Student"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(dtpEditBirthday)
        RoundedPanel1.Controls.Add(cmbEditStdProf)
        RoundedPanel1.Controls.Add(Label12)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(txtEditStdSection)
        RoundedPanel1.Controls.Add(btnSaveStd)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(btnEditStdCancel)
        RoundedPanel1.Controls.Add(mtxtEditStudentID)
        RoundedPanel1.Controls.Add(cmbEditStdCourse)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(cmbEditStdSex)
        RoundedPanel1.Controls.Add(btnExitEditStd)
        RoundedPanel1.Controls.Add(txtEditStdEmail)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(mtxtEditStdConNo)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 699)
        RoundedPanel1.TabIndex = 77
        ' 
        ' dtpEditBirthday
        ' 
        dtpEditBirthday.Location = New Point(27, 555)
        dtpEditBirthday.Name = "dtpEditBirthday"
        dtpEditBirthday.Size = New Size(250, 27)
        dtpEditBirthday.TabIndex = 58
        ' 
        ' cmbEditStdProf
        ' 
        cmbEditStdProf.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cmbEditStdProf.FormattingEnabled = True
        cmbEditStdProf.Location = New Point(549, 554)
        cmbEditStdProf.Name = "cmbEditStdProf"
        cmbEditStdProf.Size = New Size(512, 45)
        cmbEditStdProf.TabIndex = 57
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label12.Location = New Point(549, 524)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 27)
        Label12.TabIndex = 56
        Label12.Text = "Professor"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label11.Location = New Point(27, 327)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 27)
        Label11.TabIndex = 54
        Label11.Text = "Section"
        ' 
        ' txtEditStdSection
        ' 
        txtEditStdSection.BorderStyle = BorderStyle.FixedSingle
        txtEditStdSection.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditStdSection.Location = New Point(27, 357)
        txtEditStdSection.Name = "txtEditStdSection"
        txtEditStdSection.Size = New Size(389, 44)
        txtEditStdSection.TabIndex = 55
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 40
        ' 
        ' frmEditStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 697)
        Controls.Add(txtEditStdLastname)
        Controls.Add(txtEditStdMiddlename)
        Controls.Add(txtEditStdFirstname)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEditStudent"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExitEditStd As Button
    Friend WithEvents mtxtEditStudentID As MaskedTextBox
    Friend WithEvents btnSaveStd As RoundedButton
    Friend WithEvents btnEditStdCancel As RoundedButton
    Friend WithEvents cmbEditStdCourse As ComboBox
    Friend WithEvents cmbEditStdSex As ComboBox
    Friend WithEvents txtEditStdEmail As TextBox
    Friend WithEvents mtxtEditStdConNo As MaskedTextBox
    Friend WithEvents txtEditStdLastname As TextBox
    Friend WithEvents txtEditStdMiddlename As TextBox
    Friend WithEvents txtEditStdFirstname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEditStdSection As TextBox
    Friend WithEvents cmbEditStdProf As ComboBox
    Friend WithEvents dtpEditBirthday As DateTimePicker
End Class
