<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewSupervisor
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
        btnDelSupervisor = New RoundedButton()
        btnAddSupervisor = New RoundedButton()
        btnEditSupervisor = New RoundedButton()
        dgvSupervisor = New DataGridView()
        btnExitSupervisor = New Button()
        Label1 = New Label()
        RoundedPanel1.SuspendLayout()
        CType(dgvSupervisor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(btnDelSupervisor)
        RoundedPanel1.Controls.Add(btnAddSupervisor)
        RoundedPanel1.Controls.Add(btnEditSupervisor)
        RoundedPanel1.Controls.Add(dgvSupervisor)
        RoundedPanel1.Controls.Add(btnExitSupervisor)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1086, 601)
        RoundedPanel1.TabIndex = 91
        ' 
        ' btnDelSupervisor
        ' 
        btnDelSupervisor.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnDelSupervisor.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelSupervisor.BorderSize = 5
        btnDelSupervisor.CornerRadius = 10
        btnDelSupervisor.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelSupervisor.FlatStyle = FlatStyle.Flat
        btnDelSupervisor.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelSupervisor.ForeColor = Color.Black
        btnDelSupervisor.HoverColor = Color.Yellow
        btnDelSupervisor.Image = My.Resources.Resources.Delete2
        btnDelSupervisor.ImageAlign = ContentAlignment.MiddleLeft
        btnDelSupervisor.Location = New Point(502, 511)
        btnDelSupervisor.Name = "btnDelSupervisor"
        btnDelSupervisor.PressedColor = Color.Red
        btnDelSupervisor.Size = New Size(203, 60)
        btnDelSupervisor.TabIndex = 79
        btnDelSupervisor.Text = "Delete "
        btnDelSupervisor.TextAlign = ContentAlignment.MiddleLeft
        btnDelSupervisor.UseVisualStyleBackColor = False
        ' 
        ' btnAddSupervisor
        ' 
        btnAddSupervisor.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddSupervisor.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddSupervisor.BorderSize = 5
        btnAddSupervisor.CornerRadius = 10
        btnAddSupervisor.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddSupervisor.FlatStyle = FlatStyle.Flat
        btnAddSupervisor.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddSupervisor.ForeColor = Color.Black
        btnAddSupervisor.HoverColor = Color.Yellow
        btnAddSupervisor.Location = New Point(26, 511)
        btnAddSupervisor.Name = "btnAddSupervisor"
        btnAddSupervisor.PressedColor = Color.Red
        btnAddSupervisor.Size = New Size(273, 60)
        btnAddSupervisor.TabIndex = 77
        btnAddSupervisor.Text = "Add Supervisor"
        btnAddSupervisor.UseVisualStyleBackColor = False
        ' 
        ' btnEditSupervisor
        ' 
        btnEditSupervisor.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnEditSupervisor.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditSupervisor.BorderSize = 5
        btnEditSupervisor.CornerRadius = 10
        btnEditSupervisor.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditSupervisor.FlatStyle = FlatStyle.Flat
        btnEditSupervisor.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditSupervisor.ForeColor = Color.Black
        btnEditSupervisor.HoverColor = Color.Yellow
        btnEditSupervisor.Location = New Point(310, 511)
        btnEditSupervisor.Name = "btnEditSupervisor"
        btnEditSupervisor.PressedColor = Color.Red
        btnEditSupervisor.Size = New Size(182, 60)
        btnEditSupervisor.TabIndex = 78
        btnEditSupervisor.Text = "Edit"
        btnEditSupervisor.UseVisualStyleBackColor = False
        ' 
        ' dgvSupervisor
        ' 
        dgvSupervisor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSupervisor.Location = New Point(26, 102)
        dgvSupervisor.Name = "dgvSupervisor"
        dgvSupervisor.RowHeadersWidth = 51
        dgvSupervisor.Size = New Size(1030, 384)
        dgvSupervisor.TabIndex = 76
        ' 
        ' btnExitSupervisor
        ' 
        btnExitSupervisor.BackColor = Color.Transparent
        btnExitSupervisor.FlatAppearance.BorderSize = 0
        btnExitSupervisor.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExitSupervisor.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExitSupervisor.FlatStyle = FlatStyle.Flat
        btnExitSupervisor.Image = My.Resources.Resources.Exitbtn210
        btnExitSupervisor.Location = New Point(976, 25)
        btnExitSupervisor.Name = "btnExitSupervisor"
        btnExitSupervisor.Size = New Size(55, 57)
        btnExitSupervisor.TabIndex = 74
        btnExitSupervisor.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(44, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 80)
        Label1.TabIndex = 75
        Label1.Text = "Supervisor"
        ' 
        ' frmViewSupervisor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        ClientSize = New Size(1086, 601)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmViewSupervisor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmViewSupervisor"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(dgvSupervisor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents dgvSupervisor As DataGridView
    Friend WithEvents btnExitSupervisor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelSupervisor As RoundedButton
    Friend WithEvents btnAddSupervisor As RoundedButton
    Friend WithEvents btnEditSupervisor As RoundedButton
End Class
