<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewAssess
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
        Label1 = New Label()
        btnImport = New RoundedButton()
        dgvPreviewAssess = New DataGridView()
        btnCancelPreviewAssess = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        btnAddStdCancel = New RoundedButton()
        btnAddStd = New RoundedButton()
        CType(dgvPreviewAssess, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(326, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(443, 59)
        Label1.TabIndex = 82
        Label1.Text = "ASSESSMENT GRADES "
        ' 
        ' btnImport
        ' 
        btnImport.BackColor = SystemColors.Control
        btnImport.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnImport.BorderSize = 5
        btnImport.CornerRadius = 18
        btnImport.Cursor = Cursors.Hand
        btnImport.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnImport.FlatAppearance.BorderSize = 0
        btnImport.FlatStyle = FlatStyle.Flat
        btnImport.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImport.ForeColor = Color.Black
        btnImport.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnImport.Location = New Point(551, 494)
        btnImport.Name = "btnImport"
        btnImport.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnImport.Size = New Size(498, 95)
        btnImport.TabIndex = 81
        btnImport.Text = "Import"
        btnImport.UseVisualStyleBackColor = False
        ' 
        ' dgvPreviewAssess
        ' 
        dgvPreviewAssess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreviewAssess.Location = New Point(12, 68)
        dgvPreviewAssess.Name = "dgvPreviewAssess"
        dgvPreviewAssess.RowHeadersWidth = 51
        dgvPreviewAssess.Size = New Size(1062, 416)
        dgvPreviewAssess.TabIndex = 79
        ' 
        ' btnCancelPreviewAssess
        ' 
        btnCancelPreviewAssess.BackColor = SystemColors.Control
        btnCancelPreviewAssess.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnCancelPreviewAssess.BorderSize = 5
        btnCancelPreviewAssess.CornerRadius = 18
        btnCancelPreviewAssess.Cursor = Cursors.Hand
        btnCancelPreviewAssess.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnCancelPreviewAssess.FlatAppearance.BorderSize = 0
        btnCancelPreviewAssess.FlatStyle = FlatStyle.Flat
        btnCancelPreviewAssess.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelPreviewAssess.ForeColor = Color.Black
        btnCancelPreviewAssess.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnCancelPreviewAssess.Location = New Point(22, 494)
        btnCancelPreviewAssess.Name = "btnCancelPreviewAssess"
        btnCancelPreviewAssess.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnCancelPreviewAssess.Size = New Size(498, 95)
        btnCancelPreviewAssess.TabIndex = 80
        btnCancelPreviewAssess.Text = "Cancel"
        btnCancelPreviewAssess.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 6
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnAddStdCancel)
        RoundedPanel1.Controls.Add(btnAddStd)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.White
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 83
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
        ' frmPreviewAssess
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 601)
        Controls.Add(btnImport)
        Controls.Add(dgvPreviewAssess)
        Controls.Add(btnCancelPreviewAssess)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPreviewAssess"
        Text = "frmPreviewAssess"
        CType(dgvPreviewAssess, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnImport As RoundedButton
    Friend WithEvents dgvPreviewAssess As DataGridView
    Friend WithEvents btnCancelPreviewAssess As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnAddStdCancel As RoundedButton
    Friend WithEvents btnAddStd As RoundedButton
End Class
