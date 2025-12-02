<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacProfile))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtFacultyID = New TextBox()
        txtDeptID = New TextBox()
        txtDeptName = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        txtEmail = New TextBox()
        lblFullName = New Label()
        txtContactNum = New MaskedTextBox()
        Label8 = New Label()
        RoundedPanel1 = New RoundedPanel()
        btnFacBack = New Button()
        btnLogOut = New RoundedButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(327, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 27)
        Label1.TabIndex = 0
        Label1.Text = "FacultyID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(327, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 27)
        Label2.TabIndex = 1
        Label2.Text = "FirstName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(651, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 27)
        Label3.TabIndex = 2
        Label3.Text = "LastName"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 168)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(196, 198)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(327, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 27)
        Label4.TabIndex = 4
        Label4.Text = "Department Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(327, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 27)
        Label5.TabIndex = 5
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(651, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 27)
        Label6.TabIndex = 7
        Label6.Text = "DeptID"
        ' 
        ' txtFacultyID
        ' 
        txtFacultyID.BackColor = SystemColors.Control
        txtFacultyID.BorderStyle = BorderStyle.FixedSingle
        txtFacultyID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFacultyID.ForeColor = SystemColors.WindowText
        txtFacultyID.Location = New Point(327, 95)
        txtFacultyID.Name = "txtFacultyID"
        txtFacultyID.ReadOnly = True
        txtFacultyID.Size = New Size(286, 44)
        txtFacultyID.TabIndex = 8
        ' 
        ' txtDeptID
        ' 
        txtDeptID.BackColor = SystemColors.Control
        txtDeptID.BorderStyle = BorderStyle.FixedSingle
        txtDeptID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeptID.ForeColor = SystemColors.WindowText
        txtDeptID.Location = New Point(651, 95)
        txtDeptID.Name = "txtDeptID"
        txtDeptID.ReadOnly = True
        txtDeptID.Size = New Size(286, 44)
        txtDeptID.TabIndex = 9
        ' 
        ' txtDeptName
        ' 
        txtDeptName.BackColor = SystemColors.Control
        txtDeptName.BorderStyle = BorderStyle.FixedSingle
        txtDeptName.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeptName.ForeColor = SystemColors.WindowText
        txtDeptName.Location = New Point(327, 271)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.ReadOnly = True
        txtDeptName.Size = New Size(610, 44)
        txtDeptName.TabIndex = 10
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.Control
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = SystemColors.WindowText
        txtLastName.Location = New Point(651, 182)
        txtLastName.Name = "txtLastName"
        txtLastName.ReadOnly = True
        txtLastName.Size = New Size(286, 44)
        txtLastName.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = SystemColors.Control
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = SystemColors.WindowText
        txtFirstName.Location = New Point(327, 182)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.ReadOnly = True
        txtFirstName.Size = New Size(286, 44)
        txtFirstName.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Control
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = SystemColors.WindowText
        txtEmail.Location = New Point(327, 359)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(610, 44)
        txtEmail.TabIndex = 13
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        lblFullName.Location = New Point(110, 370)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(118, 27)
        lblFullName.TabIndex = 14
        lblFullName.Text = "FullName"
        ' 
        ' txtContactNum
        ' 
        txtContactNum.BackColor = SystemColors.Control
        txtContactNum.BorderStyle = BorderStyle.FixedSingle
        txtContactNum.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactNum.Location = New Point(327, 446)
        txtContactNum.Name = "txtContactNum"
        txtContactNum.ReadOnly = True
        txtContactNum.Size = New Size(610, 44)
        txtContactNum.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(327, 416)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 27)
        Label8.TabIndex = 16
        Label8.Text = "Contact No."
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(btnFacBack)
        RoundedPanel1.Controls.Add(btnLogOut)
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 19
        ' 
        ' btnFacBack
        ' 
        btnFacBack.Cursor = Cursors.Hand
        btnFacBack.FlatAppearance.BorderSize = 0
        btnFacBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnFacBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnFacBack.FlatStyle = FlatStyle.Flat
        btnFacBack.Image = CType(resources.GetObject("btnFacBack.Image"), Image)
        btnFacBack.Location = New Point(11, 12)
        btnFacBack.Name = "btnFacBack"
        btnFacBack.Size = New Size(54, 55)
        btnFacBack.TabIndex = 7
        btnFacBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnLogOut.BorderColor = Color.Red
        btnLogOut.BorderSize = 4
        btnLogOut.CornerRadius = 18
        btnLogOut.Cursor = Cursors.Hand
        btnLogOut.FillColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnLogOut.ForeColor = Color.Black
        btnLogOut.HoverColor = Color.FromArgb(CByte(240), CByte(180), CByte(180))
        btnLogOut.Location = New Point(795, 524)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.PressedColor = Color.FromArgb(CByte(220), CByte(150), CByte(150))
        btnLogOut.Size = New Size(130, 50)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "LogOut"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' frmFacProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(965, 601)
        Controls.Add(Label8)
        Controls.Add(txtContactNum)
        Controls.Add(lblFullName)
        Controls.Add(txtEmail)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(txtDeptName)
        Controls.Add(txtDeptID)
        Controls.Add(txtFacultyID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmFacProfile"
        Text = "frmFacProfile"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFacultyID As TextBox
    Friend WithEvents txtDeptID As TextBox
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtContactNum As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnFacBack As Button
    Friend WithEvents btnLogOut As RoundedButton
End Class
