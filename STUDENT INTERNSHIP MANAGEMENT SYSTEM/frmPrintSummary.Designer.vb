<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSummary
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
        btnPrintSummary = New RoundedButton()
        dgvPreview = New DataGridView()
        btnCancelPreview = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        btnAddStdCancel = New RoundedButton()
        btnAddStd = New RoundedButton()
        CType(dgvPreview, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 59)
        Label1.TabIndex = 82
        Label1.Text = "PREVIEW"
        ' 
        ' btnPrintSummary
        ' 
        btnPrintSummary.BackColor = SystemColors.Control
        btnPrintSummary.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnPrintSummary.BorderSize = 5
        btnPrintSummary.CornerRadius = 18
        btnPrintSummary.Cursor = Cursors.Hand
        btnPrintSummary.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnPrintSummary.FlatAppearance.BorderSize = 0
        btnPrintSummary.FlatStyle = FlatStyle.Flat
        btnPrintSummary.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrintSummary.ForeColor = Color.Black
        btnPrintSummary.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnPrintSummary.Location = New Point(551, 494)
        btnPrintSummary.Name = "btnPrintSummary"
        btnPrintSummary.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnPrintSummary.Size = New Size(498, 95)
        btnPrintSummary.TabIndex = 81
        btnPrintSummary.Text = "Print Summary"
        btnPrintSummary.UseVisualStyleBackColor = False
        ' 
        ' dgvPreview
        ' 
        dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreview.Location = New Point(12, 68)
        dgvPreview.Name = "dgvPreview"
        dgvPreview.RowHeadersWidth = 51
        dgvPreview.Size = New Size(1062, 416)
        dgvPreview.TabIndex = 79
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
        btnCancelPreview.TabIndex = 80
        btnCancelPreview.Text = "Cancel"
        btnCancelPreview.UseVisualStyleBackColor = False
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
        RoundedPanel1.Location = New Point(-7, -3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1101, 605)
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
        ' frmPrintSummary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 601)
        Controls.Add(Label1)
        Controls.Add(btnPrintSummary)
        Controls.Add(dgvPreview)
        Controls.Add(btnCancelPreview)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPrintSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPrintSummary"
        CType(dgvPreview, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrintSummary As RoundedButton
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents btnCancelPreview As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnAddStdCancel As RoundedButton
    Friend WithEvents btnAddStd As RoundedButton
End Class
