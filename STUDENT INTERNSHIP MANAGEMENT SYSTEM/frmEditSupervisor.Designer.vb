<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSupervisor
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
        mtxtEditSupervisorCCID = New MaskedTextBox()
        Panel2 = New Panel()
        txtEditSpvEmail = New TextBox()
        mtxtEditSpvContactNo = New MaskedTextBox()
        txtEditSpvLastname = New TextBox()
        txtEditSpvMiddlename = New TextBox()
        txtEditSpvFirstname = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnExitEditSpv = New Button()
        btnSaveSpv = New RoundedButton()
        btnEditSpvCancel = New RoundedButton()
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
        RoundedPanel1.Controls.Add(mtxtEditSupervisorCCID)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(txtEditSpvEmail)
        RoundedPanel1.Controls.Add(mtxtEditSpvContactNo)
        RoundedPanel1.Controls.Add(txtEditSpvLastname)
        RoundedPanel1.Controls.Add(txtEditSpvMiddlename)
        RoundedPanel1.Controls.Add(txtEditSpvFirstname)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(btnExitEditSpv)
        RoundedPanel1.Controls.Add(btnSaveSpv)
        RoundedPanel1.Controls.Add(btnEditSpvCancel)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 89
        ' 
        ' mtxtEditSupervisorCCID
        ' 
        mtxtEditSupervisorCCID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditSupervisorCCID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditSupervisorCCID.Location = New Point(30, 212)
        mtxtEditSupervisorCCID.Name = "mtxtEditSupervisorCCID"
        mtxtEditSupervisorCCID.Size = New Size(244, 44)
        mtxtEditSupervisorCCID.TabIndex = 22
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 94
        ' 
        ' txtEditSpvEmail
        ' 
        txtEditSpvEmail.BorderStyle = BorderStyle.FixedSingle
        txtEditSpvEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditSpvEmail.Location = New Point(457, 384)
        txtEditSpvEmail.Name = "txtEditSpvEmail"
        txtEditSpvEmail.Size = New Size(605, 44)
        txtEditSpvEmail.TabIndex = 93
        ' 
        ' mtxtEditSpvContactNo
        ' 
        mtxtEditSpvContactNo.BorderStyle = BorderStyle.FixedSingle
        mtxtEditSpvContactNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditSpvContactNo.Location = New Point(27, 384)
        mtxtEditSpvContactNo.Name = "mtxtEditSpvContactNo"
        mtxtEditSpvContactNo.Size = New Size(424, 44)
        mtxtEditSpvContactNo.TabIndex = 92
        ' 
        ' txtEditSpvLastname
        ' 
        txtEditSpvLastname.BorderStyle = BorderStyle.FixedSingle
        txtEditSpvLastname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditSpvLastname.Location = New Point(739, 294)
        txtEditSpvLastname.Name = "txtEditSpvLastname"
        txtEditSpvLastname.Size = New Size(323, 44)
        txtEditSpvLastname.TabIndex = 91
        ' 
        ' txtEditSpvMiddlename
        ' 
        txtEditSpvMiddlename.BorderStyle = BorderStyle.FixedSingle
        txtEditSpvMiddlename.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditSpvMiddlename.Location = New Point(364, 294)
        txtEditSpvMiddlename.Name = "txtEditSpvMiddlename"
        txtEditSpvMiddlename.Size = New Size(365, 44)
        txtEditSpvMiddlename.TabIndex = 90
        ' 
        ' txtEditSpvFirstname
        ' 
        txtEditSpvFirstname.BorderStyle = BorderStyle.FixedSingle
        txtEditSpvFirstname.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditSpvFirstname.Location = New Point(27, 294)
        txtEditSpvFirstname.Name = "txtEditSpvFirstname"
        txtEditSpvFirstname.Size = New Size(326, 44)
        txtEditSpvFirstname.TabIndex = 89
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
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
        Label3.Location = New Point(27, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 27)
        Label3.TabIndex = 84
        Label3.Text = "Firstname"
        ' 
        ' btnExitEditSpv
        ' 
        btnExitEditSpv.BackColor = Color.Transparent
        btnExitEditSpv.Cursor = Cursors.Hand
        btnExitEditSpv.FlatAppearance.BorderSize = 0
        btnExitEditSpv.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditSpv.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditSpv.FlatStyle = FlatStyle.Flat
        btnExitEditSpv.Image = My.Resources.Resources.Exitbtn29
        btnExitEditSpv.Location = New Point(976, 54)
        btnExitEditSpv.Name = "btnExitEditSpv"
        btnExitEditSpv.Size = New Size(55, 57)
        btnExitEditSpv.TabIndex = 74
        btnExitEditSpv.UseVisualStyleBackColor = False
        ' 
        ' btnSaveSpv
        ' 
        btnSaveSpv.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSaveSpv.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveSpv.BorderSize = 5
        btnSaveSpv.CornerRadius = 10
        btnSaveSpv.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveSpv.FlatStyle = FlatStyle.Flat
        btnSaveSpv.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSaveSpv.ForeColor = Color.Black
        btnSaveSpv.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveSpv.Location = New Point(891, 519)
        btnSaveSpv.Name = "btnSaveSpv"
        btnSaveSpv.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveSpv.Size = New Size(171, 63)
        btnSaveSpv.TabIndex = 82
        btnSaveSpv.Text = "Save"
        btnSaveSpv.UseVisualStyleBackColor = False
        ' 
        ' btnEditSpvCancel
        ' 
        btnEditSpvCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditSpvCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditSpvCancel.BorderSize = 5
        btnEditSpvCancel.CornerRadius = 10
        btnEditSpvCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditSpvCancel.FlatStyle = FlatStyle.Flat
        btnEditSpvCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditSpvCancel.ForeColor = Color.Black
        btnEditSpvCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditSpvCancel.Location = New Point(700, 519)
        btnEditSpvCancel.Name = "btnEditSpvCancel"
        btnEditSpvCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditSpvCancel.Size = New Size(171, 63)
        btnEditSpvCancel.TabIndex = 81
        btnEditSpvCancel.Text = "Cancel "
        btnEditSpvCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(498, 80)
        Label1.TabIndex = 75
        Label1.Text = "Edit Supervisor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(249, 27)
        Label2.TabIndex = 76
        Label2.Text = "Company Contact ID"
        ' 
        ' frmEditSupervisor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditSupervisor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEditSupervisor"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnExitEditSpv As Button
    Friend WithEvents btnSaveSpv As RoundedButton
    Friend WithEvents btnEditSpvCancel As RoundedButton
    Friend WithEvents mtxtEditSupervisorCCID As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEditSpvEmail As TextBox
    Friend WithEvents mtxtEditSpvContactNo As MaskedTextBox
    Friend WithEvents txtEditSpvLastname As TextBox
    Friend WithEvents txtEditSpvMiddlename As TextBox
    Friend WithEvents txtEditSpvFirstname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
End Class
