<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlacement
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
        btnAddPlaceAdd = New RoundedButton()
        btnAddPlaceCancel = New RoundedButton()
        txtAddPlaceStatus = New TextBox()
        txtAddPlaceStdID = New TextBox()
        Label9 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dtpAddPlaceStartDate = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        dtpAddPlaceEndDate = New DateTimePicker()
        btnExitAddPlace = New Button()
        mtxtEditPlaceCompID = New MaskedTextBox()
        RoundedPanel1 = New RoundedPanel()
        Panel2 = New Panel()
        nudAddPlaceGrade = New NumericUpDown()
        mtxtAddPlaceInternID = New MaskedTextBox()
        RoundedPanel1.SuspendLayout()
        CType(nudAddPlaceGrade, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddPlaceAdd
        ' 
        btnAddPlaceAdd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddPlaceAdd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddPlaceAdd.BorderSize = 5
        btnAddPlaceAdd.CornerRadius = 10
        btnAddPlaceAdd.Cursor = Cursors.Hand
        btnAddPlaceAdd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddPlaceAdd.FlatStyle = FlatStyle.Flat
        btnAddPlaceAdd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddPlaceAdd.ForeColor = Color.Black
        btnAddPlaceAdd.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddPlaceAdd.Location = New Point(891, 519)
        btnAddPlaceAdd.Name = "btnAddPlaceAdd"
        btnAddPlaceAdd.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddPlaceAdd.Size = New Size(171, 63)
        btnAddPlaceAdd.TabIndex = 44
        btnAddPlaceAdd.Text = "Add"
        btnAddPlaceAdd.UseVisualStyleBackColor = False
        ' 
        ' btnAddPlaceCancel
        ' 
        btnAddPlaceCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddPlaceCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddPlaceCancel.BorderSize = 5
        btnAddPlaceCancel.CornerRadius = 10
        btnAddPlaceCancel.Cursor = Cursors.Hand
        btnAddPlaceCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddPlaceCancel.FlatStyle = FlatStyle.Flat
        btnAddPlaceCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddPlaceCancel.ForeColor = Color.Black
        btnAddPlaceCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddPlaceCancel.Location = New Point(700, 519)
        btnAddPlaceCancel.Name = "btnAddPlaceCancel"
        btnAddPlaceCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddPlaceCancel.Size = New Size(171, 63)
        btnAddPlaceCancel.TabIndex = 43
        btnAddPlaceCancel.Text = "Cancel "
        btnAddPlaceCancel.UseVisualStyleBackColor = False
        ' 
        ' txtAddPlaceStatus
        ' 
        txtAddPlaceStatus.BorderStyle = BorderStyle.FixedSingle
        txtAddPlaceStatus.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddPlaceStatus.Location = New Point(748, 274)
        txtAddPlaceStatus.Name = "txtAddPlaceStatus"
        txtAddPlaceStatus.Size = New Size(323, 44)
        txtAddPlaceStatus.TabIndex = 41
        ' 
        ' txtAddPlaceStdID
        ' 
        txtAddPlaceStdID.BorderStyle = BorderStyle.FixedSingle
        txtAddPlaceStdID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtAddPlaceStdID.Location = New Point(29, 274)
        txtAddPlaceStdID.Name = "txtAddPlaceStdID"
        txtAddPlaceStdID.Size = New Size(326, 44)
        txtAddPlaceStdID.TabIndex = 39
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(27, 429)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 27)
        Label9.TabIndex = 38
        Label9.Text = "Grade"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(747, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 27)
        Label5.TabIndex = 37
        Label5.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(368, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 27)
        Label4.TabIndex = 36
        Label4.Text = "Company ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(29, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 27)
        Label3.TabIndex = 35
        Label3.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(29, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 27)
        Label2.TabIndex = 34
        Label2.Text = "Internship ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(541, 80)
        Label1.TabIndex = 33
        Label1.Text = "Add Placement"
        ' 
        ' dtpAddPlaceStartDate
        ' 
        dtpAddPlaceStartDate.Location = New Point(29, 377)
        dtpAddPlaceStartDate.Name = "dtpAddPlaceStartDate"
        dtpAddPlaceStartDate.Size = New Size(250, 27)
        dtpAddPlaceStartDate.TabIndex = 46
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(29, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 27)
        Label6.TabIndex = 47
        Label6.Text = "Start Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(368, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 27)
        Label7.TabIndex = 48
        Label7.Text = "End Date"
        ' 
        ' dtpAddPlaceEndDate
        ' 
        dtpAddPlaceEndDate.Location = New Point(368, 377)
        dtpAddPlaceEndDate.Name = "dtpAddPlaceEndDate"
        dtpAddPlaceEndDate.Size = New Size(250, 27)
        dtpAddPlaceEndDate.TabIndex = 49
        ' 
        ' btnExitAddPlace
        ' 
        btnExitAddPlace.BackColor = Color.Transparent
        btnExitAddPlace.Cursor = Cursors.Hand
        btnExitAddPlace.FlatAppearance.BorderSize = 0
        btnExitAddPlace.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitAddPlace.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitAddPlace.FlatStyle = FlatStyle.Flat
        btnExitAddPlace.Image = My.Resources.Resources.Exitbtn25
        btnExitAddPlace.Location = New Point(976, 54)
        btnExitAddPlace.Name = "btnExitAddPlace"
        btnExitAddPlace.Size = New Size(55, 57)
        btnExitAddPlace.TabIndex = 51
        btnExitAddPlace.UseVisualStyleBackColor = False
        ' 
        ' mtxtEditPlaceCompID
        ' 
        mtxtEditPlaceCompID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditPlaceCompID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtEditPlaceCompID.Location = New Point(368, 274)
        mtxtEditPlaceCompID.Name = "mtxtEditPlaceCompID"
        mtxtEditPlaceCompID.Size = New Size(365, 44)
        mtxtEditPlaceCompID.TabIndex = 70
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(nudAddPlaceGrade)
        RoundedPanel1.Controls.Add(mtxtAddPlaceInternID)
        RoundedPanel1.Controls.Add(btnExitAddPlace)
        RoundedPanel1.Controls.Add(mtxtEditPlaceCompID)
        RoundedPanel1.Controls.Add(btnAddPlaceAdd)
        RoundedPanel1.Controls.Add(txtAddPlaceStdID)
        RoundedPanel1.Controls.Add(btnAddPlaceCancel)
        RoundedPanel1.Controls.Add(txtAddPlaceStatus)
        RoundedPanel1.Controls.Add(dtpAddPlaceEndDate)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(dtpAddPlaceStartDate)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 75
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(44, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 4)
        Panel2.TabIndex = 72
        ' 
        ' nudAddPlaceGrade
        ' 
        nudAddPlaceGrade.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddPlaceGrade.Location = New Point(27, 459)
        nudAddPlaceGrade.Name = "nudAddPlaceGrade"
        nudAddPlaceGrade.Size = New Size(72, 44)
        nudAddPlaceGrade.TabIndex = 71
        ' 
        ' mtxtAddPlaceInternID
        ' 
        mtxtAddPlaceInternID.BorderStyle = BorderStyle.FixedSingle
        mtxtAddPlaceInternID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtAddPlaceInternID.Location = New Point(27, 185)
        mtxtAddPlaceInternID.Name = "mtxtAddPlaceInternID"
        mtxtAddPlaceInternID.Size = New Size(244, 44)
        mtxtAddPlaceInternID.TabIndex = 21
        ' 
        ' frmAddPlacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddPlacement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddPlacement"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(nudAddPlaceGrade, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAddPlaceAdd As RoundedButton
    Friend WithEvents btnAddPlaceCancel As RoundedButton
    Friend WithEvents txtAddPlaceStatus As TextBox
    Friend WithEvents txtAddPlaceStdID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpAddPlaceStartDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpAddPlaceEndDate As DateTimePicker
    Friend WithEvents btnExitAddPlace As Button
    Friend WithEvents mtxtEditPlaceCompID As MaskedTextBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents mtxtAddPlaceInternID As MaskedTextBox
    Friend WithEvents nudAddPlaceGrade As NumericUpDown
    Friend WithEvents Panel2 As Panel
End Class
