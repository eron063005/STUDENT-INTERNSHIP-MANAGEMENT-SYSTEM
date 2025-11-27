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
        RoundedButton1 = New RoundedButton()
        btnImportFile = New RoundedButton()
        dgvPreview = New DataGridView()
        CType(dgvPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.Control
        RoundedButton1.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        RoundedButton1.BorderSize = 5
        RoundedButton1.CornerRadius = 18
        RoundedButton1.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.HoverColor = Color.Yellow
        RoundedButton1.Location = New Point(551, 494)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.PressedColor = Color.Red
        RoundedButton1.Size = New Size(498, 95)
        RoundedButton1.TabIndex = 6
        RoundedButton1.Text = "Save to Database"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' btnImportFile
        ' 
        btnImportFile.BackColor = SystemColors.Control
        btnImportFile.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnImportFile.BorderSize = 5
        btnImportFile.CornerRadius = 18
        btnImportFile.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnImportFile.FlatStyle = FlatStyle.Flat
        btnImportFile.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImportFile.ForeColor = Color.Black
        btnImportFile.HoverColor = Color.Yellow
        btnImportFile.Location = New Point(22, 494)
        btnImportFile.Name = "btnImportFile"
        btnImportFile.PressedColor = Color.Red
        btnImportFile.Size = New Size(498, 95)
        btnImportFile.TabIndex = 5
        btnImportFile.Text = "Cancel"
        btnImportFile.UseVisualStyleBackColor = False
        ' 
        ' dgvPreview
        ' 
        dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreview.Location = New Point(12, 65)
        dgvPreview.Name = "dgvPreview"
        dgvPreview.RowHeadersWidth = 51
        dgvPreview.Size = New Size(1062, 416)
        dgvPreview.TabIndex = 1
        ' 
        ' frmPreviewStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedButton1)
        Controls.Add(dgvPreview)
        Controls.Add(btnImportFile)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPreviewStudent"
        Text = "frmPreview"
        CType(dgvPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents btnImportFile As RoundedButton
End Class
