<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_Faculty
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
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        btnShowConfirm = New Button()
        btnShowPass = New Button()
        Label5 = New Label()
        txtLastName = New TextBox()
        txtConfirmPass = New TextBox()
        txtPassword = New TextBox()
        mtbContactNo = New MaskedTextBox()
        cmbFacDept = New ComboBox()
        txtFacEmailAdd = New TextBox()
        txtFacID = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblBackLog = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label9 = New Label()
        btnRegisFaculty = New RoundedButton()
        Label10 = New Label()
        Label11 = New Label()
        txtFirstName = New TextBox()
        TextBox2 = New TextBox()
        btnExitFaculRegis = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(100, 791)
        Label3.Name = "Label3"
        Label3.Size = New Size(723, 160)
        Label3.TabIndex = 16
        Label3.Text = "   Student Internship " & vbCrLf & "Management System" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.VAIA_MAIN
        PictureBox1.Location = New Point(105, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(725, 750)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.FromArgb(CByte(80), CByte(118), CByte(133))
        RoundedPanel1.BorderSize = 8
        RoundedPanel1.Controls.Add(btnShowConfirm)
        RoundedPanel1.Controls.Add(btnShowPass)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(txtLastName)
        RoundedPanel1.Controls.Add(txtConfirmPass)
        RoundedPanel1.Controls.Add(txtPassword)
        RoundedPanel1.Controls.Add(mtbContactNo)
        RoundedPanel1.Controls.Add(cmbFacDept)
        RoundedPanel1.Controls.Add(txtFacEmailAdd)
        RoundedPanel1.Controls.Add(txtFacID)
        RoundedPanel1.Controls.Add(Label14)
        RoundedPanel1.Controls.Add(Label13)
        RoundedPanel1.Controls.Add(Label12)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(lblBackLog)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(btnRegisFaculty)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(txtFirstName)
        RoundedPanel1.Controls.Add(TextBox2)
        RoundedPanel1.CornerRadius = 50
        RoundedPanel1.FillColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        RoundedPanel1.Location = New Point(1035, 66)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(747, 920)
        RoundedPanel1.TabIndex = 19
        ' 
        ' btnShowConfirm
        ' 
        btnShowConfirm.BackColor = Color.White
        btnShowConfirm.Cursor = Cursors.Hand
        btnShowConfirm.FlatAppearance.BorderSize = 0
        btnShowConfirm.FlatStyle = FlatStyle.Flat
        btnShowConfirm.Image = My.Resources.Resources.Show_Password
        btnShowConfirm.Location = New Point(624, 575)
        btnShowConfirm.Name = "btnShowConfirm"
        btnShowConfirm.Size = New Size(63, 61)
        btnShowConfirm.TabIndex = 27
        btnShowConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnShowPass
        ' 
        btnShowPass.BackColor = Color.White
        btnShowPass.Cursor = Cursors.Hand
        btnShowPass.FlatAppearance.BorderSize = 0
        btnShowPass.FlatStyle = FlatStyle.Flat
        btnShowPass.Image = My.Resources.Resources.Show_Password
        btnShowPass.Location = New Point(309, 575)
        btnShowPass.Name = "btnShowPass"
        btnShowPass.Size = New Size(63, 61)
        btnShowPass.TabIndex = 26
        btnShowPass.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label5.Font = New Font("Century Gothic", 16.2F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(390, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 34)
        Label5.TabIndex = 25
        Label5.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtLastName.Location = New Point(392, 251)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(299, 65)
        txtLastName.TabIndex = 24
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPass.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtConfirmPass.Location = New Point(390, 573)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PasswordChar = "*"c
        txtConfirmPass.Size = New Size(299, 65)
        txtConfirmPass.TabIndex = 23
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtPassword.Location = New Point(75, 573)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(299, 65)
        txtPassword.TabIndex = 22
        ' 
        ' mtbContactNo
        ' 
        mtbContactNo.BorderStyle = BorderStyle.FixedSingle
        mtbContactNo.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtbContactNo.Location = New Point(392, 466)
        mtbContactNo.Name = "mtbContactNo"
        mtbContactNo.Size = New Size(299, 65)
        mtbContactNo.TabIndex = 21
        ' 
        ' cmbFacDept
        ' 
        cmbFacDept.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbFacDept.FormattingEnabled = True
        cmbFacDept.Location = New Point(77, 466)
        cmbFacDept.Name = "cmbFacDept"
        cmbFacDept.Size = New Size(299, 67)
        cmbFacDept.TabIndex = 20
        ' 
        ' txtFacEmailAdd
        ' 
        txtFacEmailAdd.BorderStyle = BorderStyle.FixedSingle
        txtFacEmailAdd.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtFacEmailAdd.Location = New Point(392, 358)
        txtFacEmailAdd.Name = "txtFacEmailAdd"
        txtFacEmailAdd.Size = New Size(299, 65)
        txtFacEmailAdd.TabIndex = 19
        ' 
        ' txtFacID
        ' 
        txtFacID.BorderStyle = BorderStyle.FixedSingle
        txtFacID.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtFacID.Location = New Point(77, 358)
        txtFacID.Name = "txtFacID"
        txtFacID.Size = New Size(299, 65)
        txtFacID.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label14.Font = New Font("Century Gothic", 16.2F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(392, 536)
        Label14.Name = "Label14"
        Label14.Size = New Size(258, 34)
        Label14.TabIndex = 17
        Label14.Text = "Confirm Password"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label13.Font = New Font("Century Gothic", 16.2F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(77, 536)
        Label13.Name = "Label13"
        Label13.Size = New Size(142, 34)
        Label13.TabIndex = 16
        Label13.Text = "Password"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label12.Font = New Font("Century Gothic", 16.2F)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(392, 429)
        Label12.Name = "Label12"
        Label12.Size = New Size(247, 34)
        Label12.TabIndex = 15
        Label12.Text = "Contact Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label4.Font = New Font("Century Gothic", 16.2F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(77, 429)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 34)
        Label4.TabIndex = 14
        Label4.Text = "Department"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label2.Font = New Font("Century Gothic", 16.2F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(392, 323)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 34)
        Label2.TabIndex = 13
        Label2.Text = "Email Address"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label1.Font = New Font("Century Gothic", 16.2F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(75, 323)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 34)
        Label1.TabIndex = 12
        Label1.Text = "Faculty ID"
        ' 
        ' lblBackLog
        ' 
        lblBackLog.AutoSize = True
        lblBackLog.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        lblBackLog.Cursor = Cursors.Hand
        lblBackLog.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBackLog.ForeColor = Color.Black
        lblBackLog.Location = New Point(433, 808)
        lblBackLog.Name = "lblBackLog"
        lblBackLog.Size = New Size(148, 23)
        lblBackLog.TabIndex = 10
        lblBackLog.Text = "Back to Log In"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(154), CByte(166), CByte(178))
        Label6.Location = New Point(152, 808)
        Label6.Name = "Label6"
        Label6.Size = New Size(280, 23)
        Label6.TabIndex = 9
        Label6.Text = "Already have an account?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Panel2.Location = New Point(77, 770)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 3)
        Panel2.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label9.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(77, 50)
        Label9.Name = "Label9"
        Label9.Size = New Size(593, 70)
        Label9.TabIndex = 6
        Label9.Text = "Faculty Registration"
        ' 
        ' btnRegisFaculty
        ' 
        btnRegisFaculty.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        btnRegisFaculty.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnRegisFaculty.BorderSize = 5
        btnRegisFaculty.CornerRadius = 10
        btnRegisFaculty.Cursor = Cursors.Hand
        btnRegisFaculty.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnRegisFaculty.FlatStyle = FlatStyle.Flat
        btnRegisFaculty.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegisFaculty.ForeColor = Color.Black
        btnRegisFaculty.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnRegisFaculty.Location = New Point(77, 663)
        btnRegisFaculty.Name = "btnRegisFaculty"
        btnRegisFaculty.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnRegisFaculty.Size = New Size(612, 82)
        btnRegisFaculty.TabIndex = 5
        btnRegisFaculty.Text = "Register"
        btnRegisFaculty.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label10.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(173, 134)
        Label10.Name = "Label10"
        Label10.Size = New Size(404, 27)
        Label10.TabIndex = 3
        Label10.Text = "Please fill in your details to register."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label11.Font = New Font("Century Gothic", 16.2F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(75, 213)
        Label11.Name = "Label11"
        Label11.Size = New Size(157, 34)
        Label11.TabIndex = 4
        Label11.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtFirstName.Location = New Point(77, 251)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(299, 65)
        txtFirstName.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        TextBox2.Location = New Point(1045, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(564, 65)
        TextBox2.TabIndex = 1
        ' 
        ' btnExitFaculRegis
        ' 
        btnExitFaculRegis.BackColor = Color.Transparent
        btnExitFaculRegis.Cursor = Cursors.Hand
        btnExitFaculRegis.FlatAppearance.BorderSize = 0
        btnExitFaculRegis.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitFaculRegis.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitFaculRegis.FlatStyle = FlatStyle.Flat
        btnExitFaculRegis.Image = My.Resources.Resources.Exit22
        btnExitFaculRegis.Location = New Point(1887, 0)
        btnExitFaculRegis.Name = "btnExitFaculRegis"
        btnExitFaculRegis.Size = New Size(33, 32)
        btnExitFaculRegis.TabIndex = 20
        btnExitFaculRegis.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.VAIA_SCHOOL_DIFF
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1920, 1080)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Register_Faculty
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnExitFaculRegis)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register_Faculty"
        Text = "Register_Faculty"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblBackLog As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRegisFaculty As RoundedButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnExitFaculRegis As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbContactNo As MaskedTextBox
    Friend WithEvents cmbFacDept As ComboBox
    Friend WithEvents txtFacEmailAdd As TextBox
    Friend WithEvents txtFacID As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnShowConfirm As Button
    Friend WithEvents btnShowPass As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
