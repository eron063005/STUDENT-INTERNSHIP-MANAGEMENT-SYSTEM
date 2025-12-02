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
        RoundedButton1 = New RoundedButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(315, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 27)
        Label1.TabIndex = 0
        Label1.Text = "FacultyID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(315, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 27)
        Label2.TabIndex = 1
        Label2.Text = "FirstName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(639, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 27)
        Label3.TabIndex = 2
        Label3.Text = "LastName"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(65, 184)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(177, 171)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(315, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 27)
        Label4.TabIndex = 4
        Label4.Text = "Department Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(315, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 27)
        Label5.TabIndex = 5
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(639, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 27)
        Label6.TabIndex = 7
        Label6.Text = "DeptID"
        ' 
        ' txtFacultyID
        ' 
        txtFacultyID.BorderStyle = BorderStyle.FixedSingle
        txtFacultyID.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFacultyID.ForeColor = SystemColors.WindowText
        txtFacultyID.Location = New Point(315, 95)
        txtFacultyID.Name = "txtFacultyID"
        txtFacultyID.Size = New Size(286, 44)
        txtFacultyID.TabIndex = 8
        ' 
        ' txtDeptID
        ' 
        txtDeptID.BorderStyle = BorderStyle.FixedSingle
        txtDeptID.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeptID.ForeColor = SystemColors.WindowText
        txtDeptID.Location = New Point(639, 95)
        txtDeptID.Name = "txtDeptID"
        txtDeptID.Size = New Size(286, 44)
        txtDeptID.TabIndex = 9
        ' 
        ' txtDeptName
        ' 
        txtDeptName.BorderStyle = BorderStyle.FixedSingle
        txtDeptName.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeptName.ForeColor = SystemColors.WindowText
        txtDeptName.Location = New Point(315, 271)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.Size = New Size(610, 44)
        txtDeptName.TabIndex = 10
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = SystemColors.WindowText
        txtLastName.Location = New Point(639, 182)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(286, 44)
        txtLastName.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = SystemColors.WindowText
        txtFirstName.Location = New Point(315, 182)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(286, 44)
        txtFirstName.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = SystemColors.WindowText
        txtEmail.Location = New Point(315, 359)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(610, 44)
        txtEmail.TabIndex = 13
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        lblFullName.Location = New Point(93, 370)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(118, 27)
        lblFullName.TabIndex = 14
        lblFullName.Text = "FullName"
        ' 
        ' txtContactNum
        ' 
        txtContactNum.BorderStyle = BorderStyle.FixedSingle
        txtContactNum.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactNum.Location = New Point(315, 446)
        txtContactNum.Name = "txtContactNum"
        txtContactNum.Size = New Size(610, 44)
        txtContactNum.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(315, 416)
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
        RoundedPanel1.Controls.Add(RoundedButton1)
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
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedButton1.BorderColor = Color.Red
        RoundedButton1.BorderSize = 4
        RoundedButton1.CornerRadius = 18
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FillColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.HoverColor = Color.FromArgb(CByte(240), CByte(180), CByte(180))
        RoundedButton1.Location = New Point(795, 524)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.PressedColor = Color.FromArgb(CByte(220), CByte(150), CByte(150))
        RoundedButton1.Size = New Size(130, 50)
        RoundedButton1.TabIndex = 6
        RoundedButton1.Text = "LogOut"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' frmFacProfile
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
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
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmFacProfile"
        Text = "frmFacProfile"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
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
    Friend WithEvents RoundedButton1 As RoundedButton
End Class
