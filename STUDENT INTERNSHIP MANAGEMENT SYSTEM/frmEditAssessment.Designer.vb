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
        NumericUpDown1 = New NumericUpDown()
        mtxtEditComConID = New MaskedTextBox()
        mtxtEditStdID = New MaskedTextBox()
        mtxtEditAssessID = New MaskedTextBox()
        btnSaveAssess = New RoundedButton()
        btnEditAssessCancel = New RoundedButton()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        btnExitEditAssessment = New Button()
        RoundedPanel1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(NumericUpDown1)
        RoundedPanel1.Controls.Add(mtxtEditComConID)
        RoundedPanel1.Controls.Add(mtxtEditStdID)
        RoundedPanel1.Controls.Add(mtxtEditAssessID)
        RoundedPanel1.Controls.Add(btnSaveAssess)
        RoundedPanel1.Controls.Add(btnEditAssessCancel)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label3)
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
        ' NumericUpDown1
        ' 
        NumericUpDown1.BorderStyle = BorderStyle.FixedSingle
        NumericUpDown1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NumericUpDown1.Location = New Point(44, 439)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(72, 44)
        NumericUpDown1.TabIndex = 49
        ' 
        ' mtxtEditComConID
        ' 
        mtxtEditComConID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditComConID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtEditComConID.Location = New Point(533, 338)
        mtxtEditComConID.Name = "mtxtEditComConID"
        mtxtEditComConID.Size = New Size(324, 44)
        mtxtEditComConID.TabIndex = 48
        ' 
        ' mtxtEditStdID
        ' 
        mtxtEditStdID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditStdID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtEditStdID.Location = New Point(44, 338)
        mtxtEditStdID.Name = "mtxtEditStdID"
        mtxtEditStdID.Size = New Size(324, 44)
        mtxtEditStdID.TabIndex = 47
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(533, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(249, 27)
        Label5.TabIndex = 40
        Label5.Text = "Company Contact ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 395)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 27)
        Label4.TabIndex = 39
        Label4.Text = "Grade "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 289)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 27)
        Label3.TabIndex = 38
        Label3.Text = "Student ID"
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
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnExitEditAssessment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSaveAssess As RoundedButton
    Friend WithEvents btnEditAssessCancel As RoundedButton
    Friend WithEvents mtxtEditAssessID As MaskedTextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents mtxtEditComConID As MaskedTextBox
    Friend WithEvents mtxtEditStdID As MaskedTextBox
End Class
