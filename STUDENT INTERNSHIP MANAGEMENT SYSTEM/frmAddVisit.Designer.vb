<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddVisit
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
        mtxtAddVisitID = New MaskedTextBox()
        dtpAddVisitDate = New DateTimePicker()
        Label4 = New Label()
        btnExitAddVisit = New Button()
        btnAddVisitAdd = New RoundedButton()
        btnAddVisitCancel = New RoundedButton()
        mtxtAddVisitInternID = New MaskedTextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtAddVisitEval = New TextBox()
        RoundedPanel1 = New RoundedPanel()
        nudAddVisitScore = New NumericUpDown()
        Panel2 = New Panel()
        RoundedPanel1.SuspendLayout()
        CType(nudAddVisitScore, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mtxtAddVisitID
        ' 
        mtxtAddVisitID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddVisitID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddVisitID.Location = New Point(27, 229)
        mtxtAddVisitID.Name = "mtxtAddVisitID"
        mtxtAddVisitID.Size = New Size(244, 44)
        mtxtAddVisitID.TabIndex = 22
        ' 
        ' dtpAddVisitDate
        ' 
        dtpAddVisitDate.Location = New Point(27, 309)
        dtpAddVisitDate.Name = "dtpAddVisitDate"
        dtpAddVisitDate.Size = New Size(250, 27)
        dtpAddVisitDate.TabIndex = 85
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(309, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 27)
        Label4.TabIndex = 84
        Label4.Text = "Evaluation"
        ' 
        ' btnExitAddVisit
        ' 
        btnExitAddVisit.BackColor = Color.Transparent
        btnExitAddVisit.Cursor = Cursors.Hand
        btnExitAddVisit.FlatAppearance.BorderSize = 0
        btnExitAddVisit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddVisit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddVisit.FlatStyle = FlatStyle.Flat
        btnExitAddVisit.Image = My.Resources.Resources.Exitbtn210
        btnExitAddVisit.Location = New Point(976, 54)
        btnExitAddVisit.Name = "btnExitAddVisit"
        btnExitAddVisit.Size = New Size(55, 57)
        btnExitAddVisit.TabIndex = 74
        btnExitAddVisit.UseVisualStyleBackColor = False
        ' 
        ' btnAddVisitAdd
        ' 
        btnAddVisitAdd.BackColor = Color.Transparent
        btnAddVisitAdd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddVisitAdd.BorderSize = 5
        btnAddVisitAdd.CornerRadius = 10
        btnAddVisitAdd.Cursor = Cursors.Hand
        btnAddVisitAdd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddVisitAdd.FlatStyle = FlatStyle.Flat
        btnAddVisitAdd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddVisitAdd.ForeColor = Color.Black
        btnAddVisitAdd.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddVisitAdd.Location = New Point(891, 519)
        btnAddVisitAdd.Name = "btnAddVisitAdd"
        btnAddVisitAdd.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddVisitAdd.Size = New Size(171, 63)
        btnAddVisitAdd.TabIndex = 82
        btnAddVisitAdd.Text = "Add"
        btnAddVisitAdd.UseVisualStyleBackColor = True
        ' 
        ' btnAddVisitCancel
        ' 
        btnAddVisitCancel.BackColor = Color.Transparent
        btnAddVisitCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddVisitCancel.BorderSize = 5
        btnAddVisitCancel.CornerRadius = 10
        btnAddVisitCancel.Cursor = Cursors.Hand
        btnAddVisitCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddVisitCancel.FlatStyle = FlatStyle.Flat
        btnAddVisitCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddVisitCancel.ForeColor = Color.Black
        btnAddVisitCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddVisitCancel.Location = New Point(700, 519)
        btnAddVisitCancel.Name = "btnAddVisitCancel"
        btnAddVisitCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddVisitCancel.Size = New Size(171, 63)
        btnAddVisitCancel.TabIndex = 81
        btnAddVisitCancel.Text = "Cancel "
        btnAddVisitCancel.UseVisualStyleBackColor = True
        ' 
        ' mtxtAddVisitInternID
        ' 
        mtxtAddVisitInternID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddVisitInternID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddVisitInternID.Location = New Point(27, 399)
        mtxtAddVisitInternID.Name = "mtxtAddVisitInternID"
        mtxtAddVisitInternID.Size = New Size(250, 44)
        mtxtAddVisitInternID.TabIndex = 80
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(309, 369)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 27)
        Label7.TabIndex = 79
        Label7.Text = "Score"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(27, 369)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 27)
        Label6.TabIndex = 78
        Label6.Text = "Internship ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 27)
        Label3.TabIndex = 77
        Label3.Text = "Visit Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(27, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 27)
        Label2.TabIndex = 76
        Label2.Text = "Visit ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 80)
        Label1.TabIndex = 75
        Label1.Text = "Add Visit"
        ' 
        ' txtAddVisitEval
        ' 
        txtAddVisitEval.BorderStyle = BorderStyle.FixedSingle
        txtAddVisitEval.Font = New Font("Century Gothic", 18F)
        txtAddVisitEval.ForeColor = SystemColors.WindowText
        txtAddVisitEval.Location = New Point(309, 309)
        txtAddVisitEval.Name = "txtAddVisitEval"
        txtAddVisitEval.Size = New Size(753, 44)
        txtAddVisitEval.TabIndex = 86
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(nudAddVisitScore)
        RoundedPanel1.Controls.Add(mtxtAddVisitID)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(btnExitAddVisit)
        RoundedPanel1.Controls.Add(dtpAddVisitDate)
        RoundedPanel1.Controls.Add(btnAddVisitAdd)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(btnAddVisitCancel)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(txtAddVisitEval)
        RoundedPanel1.Controls.Add(mtxtAddVisitInternID)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 88
        ' 
        ' nudAddVisitScore
        ' 
        nudAddVisitScore.BorderStyle = BorderStyle.FixedSingle
        nudAddVisitScore.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddVisitScore.Location = New Point(309, 399)
        nudAddVisitScore.Name = "nudAddVisitScore"
        nudAddVisitScore.Size = New Size(129, 44)
        nudAddVisitScore.TabIndex = 96
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 95
        ' 
        ' frmAddVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddVisit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddVisit"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(nudAddVisitScore, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents mtxtAddVisitID As MaskedTextBox
    Friend WithEvents dtpAddVisitDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExitAddVisit As Button
    Friend WithEvents btnAddVisitAdd As RoundedButton
    Friend WithEvents btnAddVisitCancel As RoundedButton
    Friend WithEvents mtxtAddVisitInternID As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddVisitEval As TextBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nudAddVisitScore As NumericUpDown
End Class
