<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtFacultyID = New TextBox()
        Label3 = New Label()
        RoundedPanel1 = New RoundedPanel()
        btnShowPass = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        ResetPassword = New Label()
        Label4 = New Label()
        btnLogIn = New RoundedButton()
        Button1 = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.VAIA_MAIN
        PictureBox1.Location = New Point(105, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(725, 750)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label2.Font = New Font("Century Gothic", 19.8000011F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(93, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 40)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label1.Font = New Font("Century Gothic", 19.8000011F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(93, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 40)
        Label1.TabIndex = 3
        Label1.Text = "Faculty ID"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtPassword.Location = New Point(93, 361)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(564, 65)
        txtPassword.TabIndex = 2
        ' 
        ' txtFacultyID
        ' 
        txtFacultyID.BorderStyle = BorderStyle.FixedSingle
        txtFacultyID.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold)
        txtFacultyID.Location = New Point(93, 215)
        txtFacultyID.Name = "txtFacultyID"
        txtFacultyID.Size = New Size(564, 65)
        txtFacultyID.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(222), CByte(237), CByte(238))
        Label3.Location = New Point(100, 791)
        Label3.Name = "Label3"
        Label3.Size = New Size(723, 160)
        Label3.TabIndex = 5
        Label3.Text = "   Student Internship " & vbCrLf & "Management System" & vbCrLf
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BorderColor = Color.FromArgb(CByte(80), CByte(118), CByte(133))
        RoundedPanel1.BorderSize = 8
        RoundedPanel1.Controls.Add(btnShowPass)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(ResetPassword)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(btnLogIn)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(txtPassword)
        RoundedPanel1.Controls.Add(txtFacultyID)
        RoundedPanel1.CornerRadius = 50
        RoundedPanel1.FillColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        RoundedPanel1.Location = New Point(1035, 150)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(747, 767)
        RoundedPanel1.TabIndex = 6
        ' 
        ' btnShowPass
        ' 
        btnShowPass.BackColor = Color.White
        btnShowPass.Cursor = Cursors.Hand
        btnShowPass.FlatAppearance.BorderSize = 0
        btnShowPass.FlatStyle = FlatStyle.Flat
        btnShowPass.Image = My.Resources.Resources.Show_Password
        btnShowPass.Location = New Point(592, 363)
        btnShowPass.Name = "btnShowPass"
        btnShowPass.Size = New Size(63, 61)
        btnShowPass.TabIndex = 12
        btnShowPass.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(171), CByte(37))
        Label8.Location = New Point(276, 688)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 23)
        Label8.TabIndex = 11
        Label8.Text = "Register for Student"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(104), CByte(203), CByte(248))
        Label7.Location = New Point(277, 650)
        Label7.Name = "Label7"
        Label7.Size = New Size(200, 23)
        Label7.TabIndex = 10
        Label7.Text = "Register for Faculty "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(154), CByte(166), CByte(178))
        Label6.Location = New Point(255, 610)
        Label6.Name = "Label6"
        Label6.Size = New Size(253, 23)
        Label6.TabIndex = 9
        Label6.Text = "Don't have an account?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(203), CByte(203), CByte(203))
        Panel2.Location = New Point(75, 587)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 3)
        Panel2.TabIndex = 8
        ' 
        ' ResetPassword
        ' 
        ResetPassword.AutoSize = True
        ResetPassword.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ResetPassword.Cursor = Cursors.Hand
        ResetPassword.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResetPassword.ForeColor = Color.Black
        ResetPassword.Location = New Point(474, 430)
        ResetPassword.Name = "ResetPassword"
        ResetPassword.Size = New Size(183, 23)
        ResetPassword.TabIndex = 7
        ResetPassword.Text = "Forgot Password?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        Label4.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(171, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(411, 70)
        Label4.TabIndex = 6
        Label4.Text = "Faculty Login"
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        btnLogIn.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnLogIn.BorderSize = 5
        btnLogIn.CornerRadius = 10
        btnLogIn.Cursor = Cursors.Hand
        btnLogIn.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogIn.ForeColor = Color.Black
        btnLogIn.HoverColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnLogIn.Location = New Point(93, 475)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.PressedColor = Color.Empty
        btnLogIn.Size = New Size(564, 82)
        btnLogIn.TabIndex = 5
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.Exit21
        Button1.Location = New Point(1887, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(33, 32)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel1.Location = New Point(912, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(16, 923)
        Panel1.TabIndex = 9
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(31), CByte(38))
        ClientSize = New Size(1920, 1080)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogIn Form"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtFacultyID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnLogIn As RoundedButton

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?",
                                 "Exit Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles ResetPassword.Click
        Dim frm As New Reset_Password
        frm.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New Register_Faculty
        frm.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim frm As New frmAddStudent
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = Screen.PrimaryScreen.Bounds.Size
        frm.StartPosition = FormStartPosition.CenterScreen
        'frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
End Class
