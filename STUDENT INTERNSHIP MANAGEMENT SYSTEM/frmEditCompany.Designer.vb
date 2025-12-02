<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCompany
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
        btnExitEditComp = New Button()
        mtxtEditCompanyID = New MaskedTextBox()
        btnSaveComp = New RoundedButton()
        btnEditCompCancel = New RoundedButton()
        txtEditCompEmail = New TextBox()
        mtxtEditCompConNo = New MaskedTextBox()
        txtEditCompAddress = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        txtEditCompName = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExitEditComp
        ' 
        btnExitEditComp.BackColor = Color.Transparent
        btnExitEditComp.Cursor = Cursors.Hand
        btnExitEditComp.FlatAppearance.BorderSize = 0
        btnExitEditComp.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditComp.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditComp.FlatStyle = FlatStyle.Flat
        btnExitEditComp.Image = My.Resources.Resources.Exitbtn23
        btnExitEditComp.Location = New Point(976, 54)
        btnExitEditComp.Name = "btnExitEditComp"
        btnExitEditComp.Size = New Size(55, 57)
        btnExitEditComp.TabIndex = 33
        btnExitEditComp.UseVisualStyleBackColor = False
        ' 
        ' mtxtEditCompanyID
        ' 
        mtxtEditCompanyID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditCompanyID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditCompanyID.Location = New Point(27, 205)
        mtxtEditCompanyID.Name = "mtxtEditCompanyID"
        mtxtEditCompanyID.Size = New Size(244, 44)
        mtxtEditCompanyID.TabIndex = 21
        ' 
        ' btnSaveComp
        ' 
        btnSaveComp.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSaveComp.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveComp.BorderSize = 5
        btnSaveComp.CornerRadius = 10
        btnSaveComp.Cursor = Cursors.Hand
        btnSaveComp.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveComp.FlatStyle = FlatStyle.Flat
        btnSaveComp.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSaveComp.ForeColor = Color.Black
        btnSaveComp.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveComp.Location = New Point(891, 519)
        btnSaveComp.Name = "btnSaveComp"
        btnSaveComp.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveComp.Size = New Size(171, 63)
        btnSaveComp.TabIndex = 54
        btnSaveComp.Text = "Save"
        btnSaveComp.UseVisualStyleBackColor = False
        ' 
        ' btnEditCompCancel
        ' 
        btnEditCompCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditCompCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditCompCancel.BorderSize = 5
        btnEditCompCancel.CornerRadius = 10
        btnEditCompCancel.Cursor = Cursors.Hand
        btnEditCompCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditCompCancel.FlatStyle = FlatStyle.Flat
        btnEditCompCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditCompCancel.ForeColor = Color.Black
        btnEditCompCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditCompCancel.Location = New Point(700, 519)
        btnEditCompCancel.Name = "btnEditCompCancel"
        btnEditCompCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditCompCancel.Size = New Size(171, 63)
        btnEditCompCancel.TabIndex = 53
        btnEditCompCancel.Text = "Cancel "
        btnEditCompCancel.UseVisualStyleBackColor = False
        ' 
        ' txtEditCompEmail
        ' 
        txtEditCompEmail.BorderStyle = BorderStyle.FixedSingle
        txtEditCompEmail.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditCompEmail.Location = New Point(457, 397)
        txtEditCompEmail.Name = "txtEditCompEmail"
        txtEditCompEmail.Size = New Size(605, 44)
        txtEditCompEmail.TabIndex = 52
        ' 
        ' mtxtEditCompConNo
        ' 
        mtxtEditCompConNo.BorderStyle = BorderStyle.FixedSingle
        mtxtEditCompConNo.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditCompConNo.Location = New Point(27, 397)
        mtxtEditCompConNo.Name = "mtxtEditCompConNo"
        mtxtEditCompConNo.Size = New Size(424, 44)
        mtxtEditCompConNo.TabIndex = 51
        ' 
        ' txtEditCompAddress
        ' 
        txtEditCompAddress.BorderStyle = BorderStyle.FixedSingle
        txtEditCompAddress.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditCompAddress.Location = New Point(27, 307)
        txtEditCompAddress.Name = "txtEditCompAddress"
        txtEditCompAddress.Size = New Size(1035, 44)
        txtEditCompAddress.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(454, 367)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 49
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 367)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 27)
        Label6.TabIndex = 48
        Label6.Text = "Contact No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 27)
        Label3.TabIndex = 47
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 27)
        Label2.TabIndex = 46
        Label2.Text = "Company ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(512, 80)
        Label1.TabIndex = 45
        Label1.Text = "Edit Company "
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(txtEditCompName)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(mtxtEditCompanyID)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 75
        ' 
        ' txtEditCompName
        ' 
        txtEditCompName.BorderStyle = BorderStyle.FixedSingle
        txtEditCompName.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditCompName.Location = New Point(291, 205)
        txtEditCompName.Name = "txtEditCompName"
        txtEditCompName.Size = New Size(771, 44)
        txtEditCompName.TabIndex = 79
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(291, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 27)
        Label4.TabIndex = 80
        Label4.Text = "Company Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 56
        ' 
        ' frmEditCompany
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(btnSaveComp)
        Controls.Add(btnEditCompCancel)
        Controls.Add(txtEditCompEmail)
        Controls.Add(mtxtEditCompConNo)
        Controls.Add(txtEditCompAddress)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(btnExitEditComp)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditCompany"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEditCompany"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnExitEditComp As Button
    Friend WithEvents mtxtEditCompanyID As MaskedTextBox
    Friend WithEvents btnSaveComp As RoundedButton
    Friend WithEvents btnEditCompCancel As RoundedButton
    Friend WithEvents txtEditCompEmail As TextBox
    Friend WithEvents mtxtEditCompConNo As MaskedTextBox
    Friend WithEvents txtEditCompAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtEditCompName As TextBox
    Friend WithEvents Label4 As Label
End Class
