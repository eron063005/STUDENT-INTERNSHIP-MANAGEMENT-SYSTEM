<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPlacement
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
        dtpEditPlaceEndDate = New DateTimePicker()
        Label7 = New Label()
        btnSavePlace = New RoundedButton()
        btnEditPlaceCancel = New RoundedButton()
        txtEditPlaceStatus = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnExitEditPlace = New Button()
        mtxtEditPlaceCompID = New MaskedTextBox()
        txtEditPlaceStdID = New TextBox()
        Label9 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        dtpEditPlaceStartDate = New DateTimePicker()
        Label2 = New Label()
        mtxtEditPlaceInternID = New MaskedTextBox()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        Panel2 = New Panel()
        nudEditPlaceGrade = New NumericUpDown()
        RoundedPanel1.SuspendLayout()
        CType(nudEditPlaceGrade, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpEditPlaceEndDate
        ' 
        dtpEditPlaceEndDate.Location = New Point(368, 377)
        dtpEditPlaceEndDate.Name = "dtpEditPlaceEndDate"
        dtpEditPlaceEndDate.Size = New Size(250, 27)
        dtpEditPlaceEndDate.TabIndex = 66
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(371, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 27)
        Label7.TabIndex = 65
        Label7.Text = "End Date"
        ' 
        ' btnSavePlace
        ' 
        btnSavePlace.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnSavePlace.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSavePlace.BorderSize = 5
        btnSavePlace.CornerRadius = 10
        btnSavePlace.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSavePlace.FlatStyle = FlatStyle.Flat
        btnSavePlace.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnSavePlace.ForeColor = Color.Black
        btnSavePlace.HoverColor = Color.Yellow
        btnSavePlace.Location = New Point(891, 519)
        btnSavePlace.Name = "btnSavePlace"
        btnSavePlace.PressedColor = Color.Red
        btnSavePlace.Size = New Size(171, 63)
        btnSavePlace.TabIndex = 61
        btnSavePlace.Text = "Save"
        btnSavePlace.UseVisualStyleBackColor = False
        ' 
        ' btnEditPlaceCancel
        ' 
        btnEditPlaceCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditPlaceCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditPlaceCancel.BorderSize = 5
        btnEditPlaceCancel.CornerRadius = 10
        btnEditPlaceCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditPlaceCancel.FlatStyle = FlatStyle.Flat
        btnEditPlaceCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnEditPlaceCancel.ForeColor = Color.Black
        btnEditPlaceCancel.HoverColor = Color.Yellow
        btnEditPlaceCancel.Location = New Point(700, 519)
        btnEditPlaceCancel.Name = "btnEditPlaceCancel"
        btnEditPlaceCancel.PressedColor = Color.Red
        btnEditPlaceCancel.Size = New Size(171, 63)
        btnEditPlaceCancel.TabIndex = 60
        btnEditPlaceCancel.Text = "Cancel "
        btnEditPlaceCancel.UseVisualStyleBackColor = False
        ' 
        ' txtEditPlaceStatus
        ' 
        txtEditPlaceStatus.BorderStyle = BorderStyle.FixedSingle
        txtEditPlaceStatus.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditPlaceStatus.Location = New Point(746, 274)
        txtEditPlaceStatus.Name = "txtEditPlaceStatus"
        txtEditPlaceStatus.Size = New Size(323, 44)
        txtEditPlaceStatus.TabIndex = 59
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(371, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 27)
        Label4.TabIndex = 54
        Label4.Text = "Company ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(744, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 27)
        Label5.TabIndex = 55
        Label5.Text = "Status"
        ' 
        ' btnExitEditPlace
        ' 
        btnExitEditPlace.BackColor = Color.Transparent
        btnExitEditPlace.FlatAppearance.BorderSize = 0
        btnExitEditPlace.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitEditPlace.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitEditPlace.FlatStyle = FlatStyle.Flat
        btnExitEditPlace.Image = My.Resources.Resources.Exitbtn24
        btnExitEditPlace.Location = New Point(976, 54)
        btnExitEditPlace.Name = "btnExitEditPlace"
        btnExitEditPlace.Size = New Size(55, 57)
        btnExitEditPlace.TabIndex = 68
        btnExitEditPlace.UseVisualStyleBackColor = False
        ' 
        ' mtxtEditPlaceCompID
        ' 
        mtxtEditPlaceCompID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditPlaceCompID.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mtxtEditPlaceCompID.Location = New Point(368, 274)
        mtxtEditPlaceCompID.Name = "mtxtEditPlaceCompID"
        mtxtEditPlaceCompID.Size = New Size(365, 44)
        mtxtEditPlaceCompID.TabIndex = 69
        ' 
        ' txtEditPlaceStdID
        ' 
        txtEditPlaceStdID.BorderStyle = BorderStyle.FixedSingle
        txtEditPlaceStdID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        txtEditPlaceStdID.Location = New Point(27, 274)
        txtEditPlaceStdID.Name = "txtEditPlaceStdID"
        txtEditPlaceStdID.Size = New Size(326, 44)
        txtEditPlaceStdID.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(27, 429)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 27)
        Label9.TabIndex = 56
        Label9.Text = "Grade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(27, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 27)
        Label3.TabIndex = 53
        Label3.Text = "Student ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(29, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 27)
        Label6.TabIndex = 64
        Label6.Text = "Start Date"
        ' 
        ' dtpEditPlaceStartDate
        ' 
        dtpEditPlaceStartDate.Location = New Point(29, 377)
        dtpEditPlaceStartDate.Name = "dtpEditPlaceStartDate"
        dtpEditPlaceStartDate.Size = New Size(250, 27)
        dtpEditPlaceStartDate.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(29, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 27)
        Label2.TabIndex = 52
        Label2.Text = "Internship ID"
        ' 
        ' mtxtEditPlaceInternID
        ' 
        mtxtEditPlaceInternID.BorderStyle = BorderStyle.FixedSingle
        mtxtEditPlaceInternID.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        mtxtEditPlaceInternID.Location = New Point(27, 185)
        mtxtEditPlaceInternID.Name = "mtxtEditPlaceInternID"
        mtxtEditPlaceInternID.Size = New Size(244, 44)
        mtxtEditPlaceInternID.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(518, 80)
        Label1.TabIndex = 51
        Label1.Text = "Edit Placement"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(Panel2)
        RoundedPanel1.Controls.Add(nudEditPlaceGrade)
        RoundedPanel1.Controls.Add(mtxtEditPlaceInternID)
        RoundedPanel1.Controls.Add(btnExitEditPlace)
        RoundedPanel1.Controls.Add(mtxtEditPlaceCompID)
        RoundedPanel1.Controls.Add(btnSavePlace)
        RoundedPanel1.Controls.Add(dtpEditPlaceEndDate)
        RoundedPanel1.Controls.Add(btnEditPlaceCancel)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(txtEditPlaceStatus)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(dtpEditPlaceStartDate)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(txtEditPlaceStdID)
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
        Panel2.TabIndex = 71
        ' 
        ' nudEditPlaceGrade
        ' 
        nudEditPlaceGrade.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudEditPlaceGrade.Location = New Point(27, 459)
        nudEditPlaceGrade.Name = "nudEditPlaceGrade"
        nudEditPlaceGrade.Size = New Size(72, 44)
        nudEditPlaceGrade.TabIndex = 70
        ' 
        ' frmEditPlacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditPlacement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEditPlacementvb"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(nudEditPlaceGrade, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dtpEditPlaceEndDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSavePlace As RoundedButton
    Friend WithEvents btnEditPlaceCancel As RoundedButton
    Friend WithEvents txtEditPlaceStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExitEditPlace As Button
    Friend WithEvents mtxtEditPlaceCompID As MaskedTextBox
    Friend WithEvents txtEditPlaceStdID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpEditPlaceStartDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEditPlaceGrade As TextBox
    Friend WithEvents mtxtEditPlaceInternID As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents nudEditPlaceGrade As NumericUpDown
    Friend WithEvents Panel2 As Panel
End Class
