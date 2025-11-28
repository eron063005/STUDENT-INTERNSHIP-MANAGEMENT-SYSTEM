<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset_Password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        btnExitResetPass = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        btnConfirmNew = New Button()
        btnShowNew = New Button()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtEmail = New TextBox()
        txtFacultyID = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label9 = New Label()
        ResetPassbtn = New RoundedButton()
        Label10 = New Label()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel1.Location = New Point(912, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(16, 923)
        Panel1.TabIndex = 10
        ' 
        ' btnExitResetPass
        ' 
        btnExitResetPass.BackColor = Color.Transparent
        btnExitResetPass.Cursor = Cursors.Hand
        btnExitResetPass.FlatAppearance.BorderSize = 0
        btnExitResetPass.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitResetPass.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitResetPass.FlatStyle = FlatStyle.Flat
        btnExitResetPass.Image = My.Resources.Resources.Exit23
        btnExitResetPass.Location = New Point(1887, 0)
        btnExitResetPass.Name = "btnExitResetPass"
        btnExitResetPass.Size = New Size(33, 32)
        btnExitResetPass.TabIndex = 11
        btnExitResetPass.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(222), CByte(237), CByte(238))
        Label3.Location = New Point(100, 791)
        Label3.Name = "Label3"
        Label3.Size = New Size(723, 160)
        Label3.TabIndex = 19
        Label3.Text = "   Student Internship " & vbCrLf & "Management System" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.VAIA_MAIN
        PictureBox1.Location = New Point(105, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(725, 750)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BorderColor = Color.FromArgb(CByte(80), CByte(118), CByte(133))
        RoundedPanel1.BorderSize = 8
        RoundedPanel1.Controls.Add(btnConfirmNew)
        RoundedPanel1.Controls.Add(btnShowNew)
        RoundedPanel1.Controls.Add(txtConfirmPassword)
        RoundedPanel1.Controls.Add(txtNewPassword)
        RoundedPanel1.Controls.Add(txtEmail)
        RoundedPanel1.Controls.Add(txtFacultyID)
        RoundedPanel1.Controls.Add(Label14)
        RoundedPanel1.Controls.Add(Label13)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(ResetPassbtn)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(TextBox2)
        RoundedPanel1.CornerRadius = 50
        RoundedPanel1.FillColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        RoundedPanel1.Location = New Point(1035, 200)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(747, 661)
        RoundedPanel1.TabIndex = 20
        ' 
        ' btnConfirmNew
        ' 
        btnConfirmNew.BackColor = Color.White
        btnConfirmNew.Cursor = Cursors.Hand
        btnConfirmNew.FlatAppearance.BorderSize = 0
        btnConfirmNew.FlatStyle = FlatStyle.Flat
        btnConfirmNew.Image = My.Resources.Resources.Show_Password
        btnConfirmNew.Location = New Point(616, 351)
        btnConfirmNew.Name = "btnConfirmNew"
        btnConfirmNew.Size = New Size(63, 61)
        btnConfirmNew.TabIndex = 25
        btnConfirmNew.UseVisualStyleBackColor = False
        ' 
        ' btnShowNew
        ' 
        btnShowNew.BackColor = Color.White
        btnShowNew.Cursor = Cursors.Hand
        btnShowNew.FlatAppearance.BorderSize = 0
        btnShowNew.FlatStyle = FlatStyle.Flat
        btnShowNew.Image = My.Resources.Resources.Show_Password
        btnShowNew.Location = New Point(301, 351)
        btnShowNew.Name = "btnShowNew"
        btnShowNew.Size = New Size(63, 61)
        btnShowNew.TabIndex = 24
        btnShowNew.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtConfirmPassword.Location = New Point(382, 349)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(299, 65)
        txtConfirmPassword.TabIndex = 23
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtNewPassword.Location = New Point(67, 349)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(299, 65)
        txtNewPassword.TabIndex = 22
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtEmail.Location = New Point(382, 243)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(299, 65)
        txtEmail.TabIndex = 19
        ' 
        ' txtFacultyID
        ' 
        txtFacultyID.BorderStyle = BorderStyle.FixedSingle
        txtFacultyID.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtFacultyID.Location = New Point(67, 243)
        txtFacultyID.Name = "txtFacultyID"
        txtFacultyID.Size = New Size(299, 65)
        txtFacultyID.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label14.Font = New Font("Century Gothic", 13.8F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(382, 318)
        Label14.Name = "Label14"
        Label14.Size = New Size(272, 27)
        Label14.TabIndex = 17
        Label14.Text = "Confirm New Password"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label13.Font = New Font("Century Gothic", 13.8F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(67, 318)
        Label13.Name = "Label13"
        Label13.Size = New Size(176, 27)
        Label13.TabIndex = 16
        Label13.Text = "New Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label2.Font = New Font("Century Gothic", 13.8F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(382, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 27)
        Label2.TabIndex = 13
        Label2.Text = "Email Address"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label1.Font = New Font("Century Gothic", 13.8F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(67, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 27)
        Label1.TabIndex = 12
        Label1.Text = "Faculty ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(388, 584)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 23)
        Label7.TabIndex = 10
        Label7.Text = "Back to Log In"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(154), CByte(166), CByte(178))
        Label6.Location = New Point(169, 584)
        Label6.Name = "Label6"
        Label6.Size = New Size(218, 23)
        Label6.TabIndex = 9
        Label6.Text = "Changed your mind?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Panel2.Location = New Point(69, 546)
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
        Label9.Location = New Point(140, 57)
        Label9.Name = "Label9"
        Label9.Size = New Size(473, 70)
        Label9.TabIndex = 6
        Label9.Text = "Reset Password"
        ' 
        ' ResetPassbtn
        ' 
        ResetPassbtn.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ResetPassbtn.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        ResetPassbtn.BorderSize = 5
        ResetPassbtn.CornerRadius = 10
        ResetPassbtn.Cursor = Cursors.Hand
        ResetPassbtn.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        ResetPassbtn.FlatStyle = FlatStyle.Flat
        ResetPassbtn.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetPassbtn.ForeColor = Color.Black
        ResetPassbtn.HoverColor = Color.Yellow
        ResetPassbtn.Location = New Point(69, 439)
        ResetPassbtn.Name = "ResetPassbtn"
        ResetPassbtn.PressedColor = Color.Red
        ResetPassbtn.Size = New Size(612, 82)
        ResetPassbtn.TabIndex = 5
        ResetPassbtn.Text = "Reset Password"
        ResetPassbtn.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label10.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(101, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(563, 27)
        Label10.TabIndex = 3
        Label10.Text = "Enter your credentials and type a new password."
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
        ' Reset_Password
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        ClientSize = New Size(1920, 1080)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(btnExitResetPass)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reset_Password"
        Text = "Reset_Password"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitResetPass As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFacultyID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ResetPassbtn As RoundedButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnConfirmNew As Button
    Friend WithEvents btnShowNew As Button
End Class
