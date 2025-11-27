<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSupervisor
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
        RoundedPanel1 = New RoundedPanel()
        mtxtAddSupervisorCCID = New MaskedTextBox()
        Panel2 = New Panel()
        txtAddSpvEmail = New TextBox()
        mtxtAddSpvContactNo = New MaskedTextBox()
        txtAddSpvLastname = New TextBox()
        txtAddSpvMiddlename = New TextBox()
        txtAddSpvFirstname = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnExitAddSpv = New Button()
        btnAddSpvAdd = New RoundedButton()
        btnAddSpvCancel = New RoundedButton()
        Label1 = New Label()
        Label2 = New Label()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(mtxtAddSupervisorCCID)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(txtAddSpvEmail)
        RoundedPanel1.Controls.Add(mtxtAddSpvContactNo)
        RoundedPanel1.Controls.Add(txtAddSpvLastname)
        RoundedPanel1.Controls.Add(txtAddSpvMiddlename)
        RoundedPanel1.Controls.Add(txtAddSpvFirstname)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(btnExitAddSpv)
        RoundedPanel1.Controls.Add(btnAddSpvAdd)
        RoundedPanel1.Controls.Add(btnAddSpvCancel)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.ForeColor = SystemColors.ControlText
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 90
        ' 
        ' mtxtAddSupervisorCCID
        ' 
        mtxtAddSupervisorCCID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddSupervisorCCID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddSupervisorCCID.Location = New Point(30, 212)
        mtxtAddSupervisorCCID.Name = "mtxtAddSupervisorCCID"
        mtxtAddSupervisorCCID.Size = New Size(244, 44)
        mtxtAddSupervisorCCID.TabIndex = 22
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 94
        ' 
        ' txtAddSpvEmail
        ' 
        txtAddSpvEmail.BorderStyle = BorderStyle.FixedSingle
        txtAddSpvEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddSpvEmail.Location = New Point(457, 384)
        txtAddSpvEmail.Name = "txtAddSpvEmail"
        txtAddSpvEmail.Size = New Size(605, 44)
        txtAddSpvEmail.TabIndex = 93
        ' 
        ' mtxtAddSpvContactNo
        ' 
        mtxtAddSpvContactNo.BorderStyle = BorderStyle.FixedSingle
        mtxtAddSpvContactNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddSpvContactNo.Location = New Point(27, 384)
        mtxtAddSpvContactNo.Name = "mtxtAddSpvContactNo"
        mtxtAddSpvContactNo.Size = New Size(424, 44)
        mtxtAddSpvContactNo.TabIndex = 92
        ' 
        ' txtAddSpvLastname
        ' 
        txtAddSpvLastname.BorderStyle = BorderStyle.FixedSingle
        txtAddSpvLastname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddSpvLastname.Location = New Point(739, 294)
        txtAddSpvLastname.Name = "txtAddSpvLastname"
        txtAddSpvLastname.Size = New Size(323, 44)
        txtAddSpvLastname.TabIndex = 91
        ' 
        ' txtAddSpvMiddlename
        ' 
        txtAddSpvMiddlename.BorderStyle = BorderStyle.FixedSingle
        txtAddSpvMiddlename.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddSpvMiddlename.Location = New Point(364, 294)
        txtAddSpvMiddlename.Name = "txtAddSpvMiddlename"
        txtAddSpvMiddlename.Size = New Size(365, 44)
        txtAddSpvMiddlename.TabIndex = 90
        ' 
        ' txtAddSpvFirstname
        ' 
        txtAddSpvFirstname.BorderStyle = BorderStyle.FixedSingle
        txtAddSpvFirstname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddSpvFirstname.Location = New Point(27, 294)
        txtAddSpvFirstname.Name = "txtAddSpvFirstname"
        txtAddSpvFirstname.Size = New Size(326, 44)
        txtAddSpvFirstname.TabIndex = 89
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(454, 354)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 88
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(27, 354)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 27)
        Label6.TabIndex = 87
        Label6.Text = "Contact No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(736, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 27)
        Label5.TabIndex = 86
        Label5.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(371, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 27)
        Label4.TabIndex = 85
        Label4.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(27, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 27)
        Label3.TabIndex = 84
        Label3.Text = "Firstname"
        ' 
        ' btnExitAddSpv
        ' 
        btnExitAddSpv.BackColor = Color.Transparent
        btnExitAddSpv.FlatAppearance.BorderSize = 0
        btnExitAddSpv.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddSpv.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddSpv.FlatStyle = FlatStyle.Flat
        btnExitAddSpv.Image = My.Resources.Resources.Exitbtn28
        btnExitAddSpv.Location = New Point(976, 54)
        btnExitAddSpv.Name = "btnExitAddSpv"
        btnExitAddSpv.Size = New Size(55, 57)
        btnExitAddSpv.TabIndex = 74
        btnExitAddSpv.UseVisualStyleBackColor = False
        ' 
        ' btnAddSpvAdd
        ' 
        btnAddSpvAdd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddSpvAdd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddSpvAdd.BorderSize = 5
        btnAddSpvAdd.CornerRadius = 10
        btnAddSpvAdd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddSpvAdd.FlatStyle = FlatStyle.Flat
        btnAddSpvAdd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddSpvAdd.ForeColor = SystemColors.ControlText
        btnAddSpvAdd.HoverColor = Color.Yellow
        btnAddSpvAdd.Location = New Point(891, 519)
        btnAddSpvAdd.Name = "btnAddSpvAdd"
        btnAddSpvAdd.PressedColor = Color.Red
        btnAddSpvAdd.Size = New Size(171, 63)
        btnAddSpvAdd.TabIndex = 82
        btnAddSpvAdd.Text = "Add"
        btnAddSpvAdd.UseVisualStyleBackColor = False
        ' 
        ' btnAddSpvCancel
        ' 
        btnAddSpvCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddSpvCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddSpvCancel.BorderSize = 5
        btnAddSpvCancel.CornerRadius = 10
        btnAddSpvCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddSpvCancel.FlatStyle = FlatStyle.Flat
        btnAddSpvCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddSpvCancel.ForeColor = SystemColors.ControlText
        btnAddSpvCancel.HoverColor = Color.Yellow
        btnAddSpvCancel.Location = New Point(700, 519)
        btnAddSpvCancel.Name = "btnAddSpvCancel"
        btnAddSpvCancel.PressedColor = Color.Red
        btnAddSpvCancel.Size = New Size(171, 63)
        btnAddSpvCancel.TabIndex = 81
        btnAddSpvCancel.Text = "Cancel "
        btnAddSpvCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 80)
        Label1.TabIndex = 75
        Label1.Text = "Add Supervisor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(25, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(249, 27)
        Label2.TabIndex = 76
        Label2.Text = "Company Contact ID"
        ' 
        ' frmAddSupervisor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddSupervisor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddSupervisor"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents txtAddSpvEmail As TextBox
    Friend WithEvents mtxtAddSpvContactNo As MaskedTextBox
    Friend WithEvents txtAddSpvLastname As TextBox
    Friend WithEvents txtAddSpvMiddlename As TextBox
    Friend WithEvents txtAddSpvFirstname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExitAddSpv As Button
    Friend WithEvents btnAddSpvAdd As RoundedButton
    Friend WithEvents btnAddSpvCancel As RoundedButton
    Friend WithEvents mtxtAddSupervisorCCID As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
