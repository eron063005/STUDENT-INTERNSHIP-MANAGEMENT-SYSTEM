<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditVisit
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
        btnExitEditVisit = New Button()
        btnSaveVisit = New RoundedButton()
        btnEditVisitCancel = New RoundedButton()
        mtxtEditVisitInternID = New MaskedTextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        dtpEditVisitDate = New DateTimePicker()
        txtEditVisitEval = New TextBox()
        RoundedPanel1 = New RoundedPanel()
        cbEditVisitID = New ComboBox()
        nudEditVisitScore = New NumericUpDown()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        CType(nudEditVisitScore, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExitEditVisit
        ' 
        btnExitEditVisit.BackColor = Color.Transparent
        btnExitEditVisit.Cursor = Cursors.Hand
        btnExitEditVisit.FlatAppearance.BorderSize = 0
        btnExitEditVisit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditVisit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditVisit.FlatStyle = FlatStyle.Flat
        btnExitEditVisit.Image = My.Resources.Resources.Exitbtn210
        btnExitEditVisit.Location = New Point(976, 54)
        btnExitEditVisit.Name = "btnExitEditVisit"
        btnExitEditVisit.Size = New Size(55, 57)
        btnExitEditVisit.TabIndex = 56
        btnExitEditVisit.UseVisualStyleBackColor = False
        ' 
        ' btnSaveVisit
        ' 
        btnSaveVisit.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSaveVisit.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveVisit.BorderSize = 5
        btnSaveVisit.CornerRadius = 10
        btnSaveVisit.Cursor = Cursors.Hand
        btnSaveVisit.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveVisit.FlatStyle = FlatStyle.Flat
        btnSaveVisit.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSaveVisit.ForeColor = Color.Black
        btnSaveVisit.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveVisit.Location = New Point(891, 519)
        btnSaveVisit.Name = "btnSaveVisit"
        btnSaveVisit.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveVisit.Size = New Size(171, 63)
        btnSaveVisit.TabIndex = 66
        btnSaveVisit.Text = "Save"
        btnSaveVisit.UseVisualStyleBackColor = False
        ' 
        ' btnEditVisitCancel
        ' 
        btnEditVisitCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditVisitCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditVisitCancel.BorderSize = 5
        btnEditVisitCancel.CornerRadius = 10
        btnEditVisitCancel.Cursor = Cursors.Hand
        btnEditVisitCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditVisitCancel.FlatStyle = FlatStyle.Flat
        btnEditVisitCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditVisitCancel.ForeColor = Color.Black
        btnEditVisitCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditVisitCancel.Location = New Point(700, 519)
        btnEditVisitCancel.Name = "btnEditVisitCancel"
        btnEditVisitCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditVisitCancel.Size = New Size(171, 63)
        btnEditVisitCancel.TabIndex = 65
        btnEditVisitCancel.Text = "Cancel "
        btnEditVisitCancel.UseVisualStyleBackColor = False
        ' 
        ' mtxtEditVisitInternID
        ' 
        mtxtEditVisitInternID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditVisitInternID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditVisitInternID.Location = New Point(27, 399)
        mtxtEditVisitInternID.Name = "mtxtEditVisitInternID"
        mtxtEditVisitInternID.ReadOnly = True
        mtxtEditVisitInternID.Size = New Size(250, 44)
        mtxtEditVisitInternID.TabIndex = 63
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(309, 369)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 27)
        Label7.TabIndex = 61
        Label7.Text = "Score"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 369)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 27)
        Label6.TabIndex = 60
        Label6.Text = "Internship ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 27)
        Label3.TabIndex = 59
        Label3.Text = "Visit Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(27, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 27)
        Label2.TabIndex = 58
        Label2.Text = "Visit ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 80)
        Label1.TabIndex = 57
        Label1.Text = "Edit Visit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(309, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 27)
        Label4.TabIndex = 68
        Label4.Text = "Evaluation"
        ' 
        ' dtpEditVisitDate
        ' 
        dtpEditVisitDate.Location = New Point(27, 309)
        dtpEditVisitDate.Name = "dtpEditVisitDate"
        dtpEditVisitDate.Size = New Size(250, 27)
        dtpEditVisitDate.TabIndex = 69
        ' 
        ' txtEditVisitEval
        ' 
        txtEditVisitEval.BorderStyle = BorderStyle.FixedSingle
        txtEditVisitEval.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEditVisitEval.ForeColor = SystemColors.WindowText
        txtEditVisitEval.Location = New Point(309, 309)
        txtEditVisitEval.Name = "txtEditVisitEval"
        txtEditVisitEval.Size = New Size(753, 44)
        txtEditVisitEval.TabIndex = 72
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(cbEditVisitID)
        RoundedPanel1.Controls.Add(nudEditVisitScore)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(btnSaveVisit)
        RoundedPanel1.Controls.Add(btnEditVisitCancel)
        RoundedPanel1.Controls.Add(btnExitEditVisit)
        RoundedPanel1.Controls.Add(txtEditVisitEval)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(dtpEditVisitDate)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(mtxtEditVisitInternID)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 74
        ' 
        ' cbEditVisitID
        ' 
        cbEditVisitID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        cbEditVisitID.FormattingEnabled = True
        cbEditVisitID.Location = New Point(27, 220)
        cbEditVisitID.Name = "cbEditVisitID"
        cbEditVisitID.Size = New Size(1035, 45)
        cbEditVisitID.TabIndex = 97
        ' 
        ' nudEditVisitScore
        ' 
        nudEditVisitScore.BorderStyle = BorderStyle.FixedSingle
        nudEditVisitScore.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudEditVisitScore.Location = New Point(309, 399)
        nudEditVisitScore.Name = "nudEditVisitScore"
        nudEditVisitScore.Size = New Size(129, 44)
        nudEditVisitScore.TabIndex = 96
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 95
        ' 
        ' frmEditVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditVisit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEditVisit"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(nudEditVisitScore, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnExitEditVisit As Button
    Friend WithEvents btnSaveVisit As RoundedButton
    Friend WithEvents btnEditVisitCancel As RoundedButton
    Friend WithEvents mtxtEditVisitInternID As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEditVisitDate As DateTimePicker
    Friend WithEvents txtEditVisitEval As TextBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nudEditVisitScore As NumericUpDown
    Friend WithEvents cbEditVisitID As ComboBox
End Class
