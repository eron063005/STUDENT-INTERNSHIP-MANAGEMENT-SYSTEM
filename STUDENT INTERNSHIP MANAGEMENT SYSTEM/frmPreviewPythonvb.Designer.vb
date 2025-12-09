<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewPythonvb
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
        btnGenGraph = New RoundedButton()
        btnCancelPreview = New RoundedButton()
        Label1 = New Label()
        dgvPreview = New DataGridView()
        CType(dgvPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGenGraph
        ' 
        btnGenGraph.BackColor = SystemColors.Control
        btnGenGraph.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnGenGraph.BorderSize = 5
        btnGenGraph.CornerRadius = 18
        btnGenGraph.Cursor = Cursors.Hand
        btnGenGraph.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnGenGraph.FlatAppearance.BorderSize = 0
        btnGenGraph.FlatStyle = FlatStyle.Flat
        btnGenGraph.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenGraph.ForeColor = Color.Black
        btnGenGraph.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnGenGraph.Location = New Point(576, 494)
        btnGenGraph.Name = "btnGenGraph"
        btnGenGraph.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnGenGraph.Size = New Size(498, 95)
        btnGenGraph.TabIndex = 8
        btnGenGraph.Text = "Generate Graph"
        btnGenGraph.UseVisualStyleBackColor = False
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
        btnCancelPreview.Location = New Point(12, 494)
        btnCancelPreview.Name = "btnCancelPreview"
        btnCancelPreview.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnCancelPreview.Size = New Size(498, 95)
        btnCancelPreview.TabIndex = 7
        btnCancelPreview.Text = "Cancel"
        btnCancelPreview.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 59)
        Label1.TabIndex = 10
        Label1.Text = "PREVIEW"
        ' 
        ' dgvPreview
        ' 
        dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreview.Location = New Point(12, 72)
        dgvPreview.Name = "dgvPreview"
        dgvPreview.RowHeadersWidth = 51
        dgvPreview.Size = New Size(1062, 416)
        dgvPreview.TabIndex = 9
        ' 
        ' frmPreviewPythonvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 601)
        Controls.Add(Label1)
        Controls.Add(dgvPreview)
        Controls.Add(btnGenGraph)
        Controls.Add(btnCancelPreview)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPreviewPythonvb"
        Text = "frmPreviewPythonvb"
        CType(dgvPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenGraph As RoundedButton
    Friend WithEvents btnCancelPreview As RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPreview As DataGridView
End Class
