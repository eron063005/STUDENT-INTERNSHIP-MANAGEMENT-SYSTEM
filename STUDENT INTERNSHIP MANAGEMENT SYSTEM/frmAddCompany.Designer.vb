<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCompany
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
        mtxtAddCompanyID = New MaskedTextBox()
        btnAddCompAdd = New RoundedButton()
        btnAddCompCancel = New RoundedButton()
        txtAddCompEmail = New TextBox()
        mtxtAddCompConNo = New MaskedTextBox()
        txtAddCompAddress = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnExitAddComp = New Button()
        RoundedPanel1 = New RoundedPanel()
        txtAddCompName = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' mtxtAddCompanyID
        ' 
        mtxtAddCompanyID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddCompanyID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddCompanyID.Location = New Point(27, 205)
        mtxtAddCompanyID.Name = "mtxtAddCompanyID"
        mtxtAddCompanyID.ReadOnly = True
        mtxtAddCompanyID.Size = New Size(244, 44)
        mtxtAddCompanyID.TabIndex = 21
        ' 
        ' btnAddCompAdd
        ' 
        btnAddCompAdd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddCompAdd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddCompAdd.BorderSize = 5
        btnAddCompAdd.CornerRadius = 10
        btnAddCompAdd.Cursor = Cursors.Hand
        btnAddCompAdd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddCompAdd.FlatStyle = FlatStyle.Flat
        btnAddCompAdd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddCompAdd.ForeColor = Color.Black
        btnAddCompAdd.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddCompAdd.Location = New Point(891, 519)
        btnAddCompAdd.Name = "btnAddCompAdd"
        btnAddCompAdd.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddCompAdd.Size = New Size(171, 63)
        btnAddCompAdd.TabIndex = 43
        btnAddCompAdd.Text = "Add"
        btnAddCompAdd.UseVisualStyleBackColor = False
        ' 
        ' btnAddCompCancel
        ' 
        btnAddCompCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddCompCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddCompCancel.BorderSize = 5
        btnAddCompCancel.CornerRadius = 10
        btnAddCompCancel.Cursor = Cursors.Hand
        btnAddCompCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddCompCancel.FlatStyle = FlatStyle.Flat
        btnAddCompCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddCompCancel.ForeColor = Color.Black
        btnAddCompCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddCompCancel.Location = New Point(700, 519)
        btnAddCompCancel.Name = "btnAddCompCancel"
        btnAddCompCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddCompCancel.Size = New Size(171, 63)
        btnAddCompCancel.TabIndex = 42
        btnAddCompCancel.Text = "Cancel "
        btnAddCompCancel.UseVisualStyleBackColor = False
        ' 
        ' txtAddCompEmail
        ' 
        txtAddCompEmail.BorderStyle = BorderStyle.FixedSingle
        txtAddCompEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddCompEmail.Location = New Point(457, 397)
        txtAddCompEmail.Name = "txtAddCompEmail"
        txtAddCompEmail.Size = New Size(605, 44)
        txtAddCompEmail.TabIndex = 41
        ' 
        ' mtxtAddCompConNo
        ' 
        mtxtAddCompConNo.BorderStyle = BorderStyle.FixedSingle
        mtxtAddCompConNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddCompConNo.Location = New Point(27, 397)
        mtxtAddCompConNo.Name = "mtxtAddCompConNo"
        mtxtAddCompConNo.Size = New Size(424, 44)
        mtxtAddCompConNo.TabIndex = 40
        ' 
        ' txtAddCompAddress
        ' 
        txtAddCompAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddCompAddress.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddCompAddress.Location = New Point(27, 307)
        txtAddCompAddress.Name = "txtAddCompAddress"
        txtAddCompAddress.Size = New Size(1035, 44)
        txtAddCompAddress.TabIndex = 39
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(454, 367)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 38
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 367)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 27)
        Label6.TabIndex = 37
        Label6.Text = "Contact No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 27)
        Label3.TabIndex = 36
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 27)
        Label2.TabIndex = 35
        Label2.Text = "Company ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(535, 80)
        Label1.TabIndex = 34
        Label1.Text = "Add Company "
        ' 
        ' btnExitAddComp
        ' 
        btnExitAddComp.BackColor = Color.Transparent
        btnExitAddComp.Cursor = Cursors.Hand
        btnExitAddComp.FlatAppearance.BorderSize = 0
        btnExitAddComp.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddComp.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddComp.FlatStyle = FlatStyle.Flat
        btnExitAddComp.Image = My.Resources.Resources.Exitbtn22
        btnExitAddComp.Location = New Point(976, 54)
        btnExitAddComp.Name = "btnExitAddComp"
        btnExitAddComp.Size = New Size(55, 57)
        btnExitAddComp.TabIndex = 33
        btnExitAddComp.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(txtAddCompName)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(mtxtAddCompanyID)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnExitAddComp)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 76
        ' 
        ' txtAddCompName
        ' 
        txtAddCompName.BorderStyle = BorderStyle.FixedSingle
        txtAddCompName.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddCompName.Location = New Point(291, 205)
        txtAddCompName.Name = "txtAddCompName"
        txtAddCompName.Size = New Size(771, 44)
        txtAddCompName.TabIndex = 77
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(291, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 27)
        Label4.TabIndex = 78
        Label4.Text = "Company Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 39
        ' 
        ' frmAddCompany
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(btnAddCompAdd)
        Controls.Add(btnAddCompCancel)
        Controls.Add(txtAddCompEmail)
        Controls.Add(mtxtAddCompConNo)
        Controls.Add(txtAddCompAddress)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddCompany"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddCompany"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents mtxtAddCompanyID As MaskedTextBox
    Friend WithEvents btnAddCompAdd As RoundedButton
    Friend WithEvents btnAddCompCancel As RoundedButton
    Friend WithEvents txtAddCompEmail As TextBox
    Friend WithEvents mtxtAddCompConNo As MaskedTextBox
    Friend WithEvents txtAddCompAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExitAddComp As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddCompName As TextBox
End Class
