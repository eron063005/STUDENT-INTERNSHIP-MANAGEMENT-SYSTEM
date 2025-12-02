<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAssessment
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        nudAddStdAge = New NumericUpDown()
        Label3 = New Label()
        Label8 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        mtxtAddStudentID = New MaskedTextBox()
        Label2 = New Label()
        Label12 = New Label()
        RoundedPanel1 = New RoundedPanel()
        nudAddAssessGrade = New NumericUpDown()
        Panel2 = New Panel()
        mtxtAddComConID = New MaskedTextBox()
        Label4 = New Label()
        mtxtAddStdID = New MaskedTextBox()
        btnExitAddAssessment = New Button()
        mtxtAddAssessID = New MaskedTextBox()
        btnAddAssess = New RoundedButton()
        Label9 = New Label()
        btnAddAssessCancel = New RoundedButton()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(nudAddStdAge, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        CType(nudAddAssessGrade, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(411, 282)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(244, 44)
        TextBox2.TabIndex = 90
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(32, 282)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 44)
        TextBox1.TabIndex = 89
        ' 
        ' nudAddStdAge
        ' 
        nudAddStdAge.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        nudAddStdAge.Location = New Point(36, 407)
        nudAddStdAge.Name = "nudAddStdAge"
        nudAddStdAge.Size = New Size(83, 44)
        nudAddStdAge.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(411, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 27)
        Label3.TabIndex = 87
        Label3.Text = "Company Contact ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label8.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label8.Location = New Point(36, 378)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 27)
        Label8.TabIndex = 87
        Label8.Text = "Grade"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(29, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 27)
        Label1.TabIndex = 85
        Label1.Text = "Student ID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        Panel1.Controls.Add(mtxtAddStudentID)
        Panel1.Location = New Point(29, 169)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(3)
        Panel1.Size = New Size(250, 44)
        Panel1.TabIndex = 84
        ' 
        ' mtxtAddStudentID
        ' 
        mtxtAddStudentID.BorderStyle = BorderStyle.None
        mtxtAddStudentID.Dock = DockStyle.Fill
        mtxtAddStudentID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddStudentID.Location = New Point(3, 3)
        mtxtAddStudentID.Name = "mtxtAddStudentID"
        mtxtAddStudentID.Size = New Size(244, 37)
        mtxtAddStudentID.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(25, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 27)
        Label2.TabIndex = 83
        Label2.Text = "Assessment ID"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label12.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(9, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(566, 80)
        Label12.TabIndex = 75
        Label12.Text = "Add Assessment"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(nudAddAssessGrade)
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(mtxtAddComConID)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(mtxtAddStdID)
        RoundedPanel1.Controls.Add(btnExitAddAssessment)
        RoundedPanel1.Controls.Add(mtxtAddAssessID)
        RoundedPanel1.Controls.Add(btnAddAssess)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(btnAddAssessCancel)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 0
        ' 
        ' nudAddAssessGrade
        ' 
        nudAddAssessGrade.BorderStyle = BorderStyle.FixedSingle
        nudAddAssessGrade.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddAssessGrade.Location = New Point(44, 439)
        nudAddAssessGrade.Name = "nudAddAssessGrade"
        nudAddAssessGrade.Size = New Size(72, 44)
        nudAddAssessGrade.TabIndex = 59
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 4)
        Panel2.TabIndex = 38
        ' 
        ' mtxtAddComConID
        ' 
        mtxtAddComConID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddComConID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtAddComConID.Location = New Point(533, 338)
        mtxtAddComConID.Name = "mtxtAddComConID"
        mtxtAddComConID.Size = New Size(324, 44)
        mtxtAddComConID.TabIndex = 58
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label4.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(585, 80)
        Label4.TabIndex = 35
        Label4.Text = "Add Assessment "
        ' 
        ' mtxtAddStdID
        ' 
        mtxtAddStdID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddStdID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtAddStdID.Location = New Point(44, 338)
        mtxtAddStdID.Name = "mtxtAddStdID"
        mtxtAddStdID.Size = New Size(324, 44)
        mtxtAddStdID.TabIndex = 57
        ' 
        ' btnExitAddAssessment
        ' 
        btnExitAddAssessment.BackColor = Color.Transparent
        btnExitAddAssessment.Cursor = Cursors.Hand
        btnExitAddAssessment.FlatAppearance.BorderSize = 0
        btnExitAddAssessment.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddAssessment.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddAssessment.FlatStyle = FlatStyle.Flat
        btnExitAddAssessment.Image = My.Resources.Resources.Exitbtn21
        btnExitAddAssessment.Location = New Point(832, 54)
        btnExitAddAssessment.Name = "btnExitAddAssessment"
        btnExitAddAssessment.Size = New Size(55, 57)
        btnExitAddAssessment.TabIndex = 11
        btnExitAddAssessment.UseVisualStyleBackColor = False
        ' 
        ' mtxtAddAssessID
        ' 
        mtxtAddAssessID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddAssessID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtAddAssessID.Location = New Point(44, 217)
        mtxtAddAssessID.Name = "mtxtAddAssessID"
        mtxtAddAssessID.Size = New Size(324, 44)
        mtxtAddAssessID.TabIndex = 56
        ' 
        ' btnAddAssess
        ' 
        btnAddAssess.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddAssess.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddAssess.BorderSize = 5
        btnAddAssess.CornerRadius = 10
        btnAddAssess.Cursor = Cursors.Hand
        btnAddAssess.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddAssess.FlatStyle = FlatStyle.Flat
        btnAddAssess.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddAssess.ForeColor = Color.Black
        btnAddAssess.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddAssess.Location = New Point(753, 513)
        btnAddAssess.Name = "btnAddAssess"
        btnAddAssess.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddAssess.Size = New Size(171, 63)
        btnAddAssess.TabIndex = 55
        btnAddAssess.Text = "Add"
        btnAddAssess.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label9.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(44, 169)
        Label9.Name = "Label9"
        Label9.Size = New Size(170, 27)
        Label9.TabIndex = 50
        Label9.Text = "Assessment ID"
        ' 
        ' btnAddAssessCancel
        ' 
        btnAddAssessCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddAssessCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddAssessCancel.BorderSize = 5
        btnAddAssessCancel.CornerRadius = 10
        btnAddAssessCancel.Cursor = Cursors.Hand
        btnAddAssessCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddAssessCancel.FlatStyle = FlatStyle.Flat
        btnAddAssessCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddAssessCancel.ForeColor = Color.Black
        btnAddAssessCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddAssessCancel.Location = New Point(562, 513)
        btnAddAssessCancel.Name = "btnAddAssessCancel"
        btnAddAssessCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddAssessCancel.Size = New Size(171, 63)
        btnAddAssessCancel.TabIndex = 54
        btnAddAssessCancel.Text = "Cancel "
        btnAddAssessCancel.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(44, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 27)
        Label7.TabIndex = 51
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
        Label5.TabIndex = 53
        Label5.Text = "Company Contact ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(44, 395)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 27)
        Label6.TabIndex = 52
        Label6.Text = "Grade "
        ' 
        ' frmAddAssessment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddAssessment"
        Text = "frmAddAssessment"
        CType(nudAddStdAge, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(nudAddAssessGrade, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nudAddStdAge As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mtxtAddStudentID As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddAssessment As RoundedButton
    Friend WithEvents btnAddAssessCancel As RoundedButton
    Friend WithEvents Label12 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnExitAddAssessment As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nudAddAssessGrade As NumericUpDown
    Friend WithEvents mtxtAddComConID As MaskedTextBox
    Friend WithEvents mtxtAddStdID As MaskedTextBox
    Friend WithEvents mtxtAddAssessID As MaskedTextBox
    Friend WithEvents btnAddAssess As RoundedButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
