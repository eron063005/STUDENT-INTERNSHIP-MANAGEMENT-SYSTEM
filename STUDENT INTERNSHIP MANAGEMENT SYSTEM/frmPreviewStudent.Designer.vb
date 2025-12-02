<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewStudent
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
        btnAddStdCancel = New RoundedButton()
        btnAddStd = New RoundedButton()
        Label1 = New Label()
        dgvPreview = New DataGridView()
        btnCancelPreview = New RoundedButton()
        btnSaveDB = New RoundedButton()
        RoundedPanel1.SuspendLayout()
        CType(dgvPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 6
        RoundedPanel1.Controls.Add(btnAddStdCancel)
        RoundedPanel1.Controls.Add(btnAddStd)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.White
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 78
        ' 
        ' btnAddStdCancel
        ' 
        btnAddStdCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStdCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStdCancel.BorderSize = 5
        btnAddStdCancel.CornerRadius = 10
        btnAddStdCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStdCancel.FlatStyle = FlatStyle.Flat
        btnAddStdCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStdCancel.ForeColor = Color.Black
        btnAddStdCancel.HoverColor = Color.Yellow
        btnAddStdCancel.Location = New Point(697, 618)
        btnAddStdCancel.Name = "btnAddStdCancel"
        btnAddStdCancel.PressedColor = Color.Red
        btnAddStdCancel.Size = New Size(171, 63)
        btnAddStdCancel.TabIndex = 30
        btnAddStdCancel.Text = "Cancel "
        btnAddStdCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAddStd
        ' 
        btnAddStd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStd.BorderSize = 5
        btnAddStd.CornerRadius = 10
        btnAddStd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStd.FlatStyle = FlatStyle.Flat
        btnAddStd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStd.ForeColor = Color.Black
        btnAddStd.HoverColor = Color.Yellow
        btnAddStd.Location = New Point(891, 618)
        btnAddStd.Name = "btnAddStd"
        btnAddStd.PressedColor = Color.Red
        btnAddStd.Size = New Size(171, 63)
        btnAddStd.TabIndex = 31
        btnAddStd.Text = "Add"
        btnAddStd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(327, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 59)
        Label1.TabIndex = 7
        Label1.Text = "PREVIEW OF STUDENTS"
        ' 
        ' dgvPreview
        ' 
        dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreview.Location = New Point(12, 68)
        dgvPreview.Name = "dgvPreview"
        dgvPreview.RowHeadersWidth = 51
        dgvPreview.Size = New Size(1062, 416)
        dgvPreview.TabIndex = 1
        ' 
        ' btnCancelPreview
        ' 
        btnCancelPreview.BackColor = SystemColors.Control
        btnCancelPreview.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnCancelPreview.BorderSize = 5
        btnCancelPreview.CornerRadius = 18
        btnCancelPreview.Cursor = Cursors.Hand
        btnCancelPreview.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnCancelPreview.FlatAppearance.BorderSize = 0
        btnCancelPreview.FlatStyle = FlatStyle.Flat
        btnCancelPreview.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelPreview.ForeColor = Color.Black
        btnCancelPreview.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnCancelPreview.Location = New Point(22, 494)
        btnCancelPreview.Name = "btnCancelPreview"
        btnCancelPreview.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnCancelPreview.Size = New Size(498, 95)
        btnCancelPreview.TabIndex = 5
        btnCancelPreview.Text = "Cancel"
        btnCancelPreview.UseVisualStyleBackColor = False
        ' 
        ' btnSaveDB
        ' 
        btnSaveDB.BackColor = SystemColors.Control
        btnSaveDB.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnSaveDB.BorderSize = 5
        btnSaveDB.CornerRadius = 18
        btnSaveDB.Cursor = Cursors.Hand
        btnSaveDB.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnSaveDB.FlatAppearance.BorderSize = 0
        btnSaveDB.FlatStyle = FlatStyle.Flat
        btnSaveDB.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveDB.ForeColor = Color.Black
        btnSaveDB.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnSaveDB.Location = New Point(551, 494)
        btnSaveDB.Name = "btnSaveDB"
        btnSaveDB.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnSaveDB.Size = New Size(498, 95)
        btnSaveDB.TabIndex = 6
        btnSaveDB.Text = "Save to Database"
        btnSaveDB.UseVisualStyleBackColor = False
        ' 
        ' frmPreviewStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1086, 601)
        Controls.Add(Label1)
        Controls.Add(btnSaveDB)
        Controls.Add(dgvPreview)
        Controls.Add(btnCancelPreview)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPreviewStudent"
        Text = "frmPreview"
        RoundedPanel1.ResumeLayout(False)
        CType(dgvPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnAddStdCancel As RoundedButton
    Friend WithEvents btnAddStd As RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents btnCancelPreview As RoundedButton
    Friend WithEvents btnSaveDB As RoundedButton
End Class
