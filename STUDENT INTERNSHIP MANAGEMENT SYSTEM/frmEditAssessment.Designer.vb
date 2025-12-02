<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAssessment
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
        cmbEditInternID = New ComboBox()
        Label6 = New Label()
        cmbEditCCId = New ComboBox()
        cmbEditStudentId = New ComboBox()
        Label7 = New Label()
        Label5 = New Label()
        mtxtEditAssessID = New MaskedTextBox()
        btnSaveAssess = New RoundedButton()
        btnEditAssessCancel = New RoundedButton()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        btnExitEditAssessment = New Button()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(cmbEditInternID)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(cmbEditCCId)
        RoundedPanel1.Controls.Add(cmbEditStudentId)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(mtxtEditAssessID)
        RoundedPanel1.Controls.Add(btnSaveAssess)
        RoundedPanel1.Controls.Add(btnEditAssessCancel)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnExitEditAssessment)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 1
        ' 
        ' cmbEditInternID
        ' 
        cmbEditInternID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbEditInternID.FormattingEnabled = True
        cmbEditInternID.Location = New Point(44, 343)
        cmbEditInternID.Name = "cmbEditInternID"
        cmbEditInternID.Size = New Size(324, 45)
        cmbEditInternID.TabIndex = 68
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(44, 289)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 27)
        Label6.TabIndex = 67
        Label6.Text = "Internship ID"
        ' 
        ' cmbEditCCId
        ' 
        cmbEditCCId.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbEditCCId.FormattingEnabled = True
        cmbEditCCId.Location = New Point(533, 343)
        cmbEditCCId.Name = "cmbEditCCId"
        cmbEditCCId.Size = New Size(361, 45)
        cmbEditCCId.TabIndex = 66
        ' 
        ' cmbEditStudentId
        ' 
        cmbEditStudentId.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbEditStudentId.FormattingEnabled = True
        cmbEditStudentId.Location = New Point(533, 216)
        cmbEditStudentId.Name = "cmbEditStudentId"
        cmbEditStudentId.Size = New Size(362, 45)
        cmbEditStudentId.TabIndex = 65
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(533, 162)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 27)
        Label7.TabIndex = 63
        Label7.Text = "Student ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(533, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(249, 27)
        Label5.TabIndex = 64
        Label5.Text = "Company Contact ID"
        ' 
        ' mtxtEditAssessID
        ' 
        mtxtEditAssessID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditAssessID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtEditAssessID.Location = New Point(44, 217)
        mtxtEditAssessID.Name = "mtxtEditAssessID"
        mtxtEditAssessID.Size = New Size(324, 44)
        mtxtEditAssessID.TabIndex = 46
        ' 
        ' btnSaveAssess
        ' 
        btnSaveAssess.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSaveAssess.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveAssess.BorderSize = 5
        btnSaveAssess.CornerRadius = 10
        btnSaveAssess.Cursor = Cursors.Hand
        btnSaveAssess.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveAssess.FlatStyle = FlatStyle.Flat
        btnSaveAssess.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSaveAssess.ForeColor = Color.Black
        btnSaveAssess.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveAssess.Location = New Point(753, 513)
        btnSaveAssess.Name = "btnSaveAssess"
        btnSaveAssess.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveAssess.Size = New Size(171, 63)
        btnSaveAssess.TabIndex = 45
        btnSaveAssess.Text = "Save"
        btnSaveAssess.UseVisualStyleBackColor = False
        ' 
        ' btnEditAssessCancel
        ' 
        btnEditAssessCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditAssessCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditAssessCancel.BorderSize = 5
        btnEditAssessCancel.CornerRadius = 10
        btnEditAssessCancel.Cursor = Cursors.Hand
        btnEditAssessCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditAssessCancel.FlatStyle = FlatStyle.Flat
        btnEditAssessCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditAssessCancel.ForeColor = Color.Black
        btnEditAssessCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditAssessCancel.Location = New Point(562, 513)
        btnEditAssessCancel.Name = "btnEditAssessCancel"
        btnEditAssessCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditAssessCancel.Size = New Size(171, 63)
        btnEditAssessCancel.TabIndex = 44
        btnEditAssessCancel.Text = "Cancel "
        btnEditAssessCancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Location = New Point(44, 131)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(850, 4)
        Panel1.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 27)
        Label2.TabIndex = 36
        Label2.Text = "Assessment ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(562, 80)
        Label1.TabIndex = 35
        Label1.Text = "Edit Assessment "
        ' 
        ' btnExitEditAssessment
        ' 
        btnExitEditAssessment.BackColor = Color.Transparent
        btnExitEditAssessment.Cursor = Cursors.Hand
        btnExitEditAssessment.FlatAppearance.BorderSize = 0
        btnExitEditAssessment.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditAssessment.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditAssessment.FlatStyle = FlatStyle.Flat
        btnExitEditAssessment.Image = My.Resources.Resources.Exitbtn2
        btnExitEditAssessment.Location = New Point(832, 54)
        btnExitEditAssessment.Name = "btnExitEditAssessment"
        btnExitEditAssessment.Size = New Size(55, 57)
        btnExitEditAssessment.TabIndex = 11
        btnExitEditAssessment.UseVisualStyleBackColor = False
        ' 
        ' frmEditAssessment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditAssessment"
        Text = "frmEditAssessment"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnExitEditAssessment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSaveAssess As RoundedButton
    Friend WithEvents btnEditAssessCancel As RoundedButton
    Friend WithEvents mtxtEditAssessID As MaskedTextBox
    Friend WithEvents cmbEditInternID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbEditCCId As ComboBox
    Friend WithEvents cmbEditStudentId As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
End Class
