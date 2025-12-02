<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(archVisit))
        dgvarchVisit = New DataGridView()
        RoundedButton1 = New RoundedButton()
        RoundedButton2 = New RoundedButton()
        Label1 = New Label()
        btnVisitBack = New Button()
        btnVisitExit = New Button()
        RoundedPanel1 = New RoundedPanel()
        CType(dgvarchVisit, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvarchVisit
        ' 
        dgvarchVisit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvarchVisit.Location = New Point(26, 123)
        dgvarchVisit.Name = "dgvarchVisit"
        dgvarchVisit.RowHeadersWidth = 51
        dgvarchVisit.Size = New Size(912, 393)
        dgvarchVisit.TabIndex = 1
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedButton1.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        RoundedButton1.BorderSize = 3
        RoundedButton1.CornerRadius = 20
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        RoundedButton1.Location = New Point(524, 526)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        RoundedButton1.Size = New Size(186, 59)
        RoundedButton1.TabIndex = 2
        RoundedButton1.Text = "Restore"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedButton2.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        RoundedButton2.BorderSize = 3
        RoundedButton2.CornerRadius = 20
        RoundedButton2.Cursor = Cursors.Hand
        RoundedButton2.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        RoundedButton2.Location = New Point(716, 526)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        RoundedButton2.Size = New Size(222, 59)
        RoundedButton2.TabIndex = 3
        RoundedButton2.Text = "Delete Permanently"
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 37)
        Label1.TabIndex = 5
        Label1.Text = "Archieved Visit"
        ' 
        ' btnVisitBack
        ' 
        btnVisitBack.Cursor = Cursors.Hand
        btnVisitBack.FlatAppearance.BorderSize = 0
        btnVisitBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnVisitBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnVisitBack.FlatStyle = FlatStyle.Flat
        btnVisitBack.Image = CType(resources.GetObject("btnVisitBack.Image"), Image)
        btnVisitBack.Location = New Point(26, 21)
        btnVisitBack.Name = "btnVisitBack"
        btnVisitBack.Size = New Size(74, 59)
        btnVisitBack.TabIndex = 6
        btnVisitBack.UseVisualStyleBackColor = True
        ' 
        ' btnVisitExit
        ' 
        btnVisitExit.BackColor = Color.Transparent
        btnVisitExit.Cursor = Cursors.Hand
        btnVisitExit.FlatAppearance.BorderSize = 0
        btnVisitExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnVisitExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnVisitExit.FlatStyle = FlatStyle.Flat
        btnVisitExit.Image = CType(resources.GetObject("btnVisitExit.Image"), Image)
        btnVisitExit.Location = New Point(864, 21)
        btnVisitExit.Name = "btnVisitExit"
        btnVisitExit.Size = New Size(74, 59)
        btnVisitExit.TabIndex = 7
        btnVisitExit.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(btnVisitExit)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnVisitBack)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 8
        ' 
        ' archVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(dgvarchVisit)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "archVisit"
        Text = "archVisit"
        CType(dgvarchVisit, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvarchVisit As DataGridView
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVisitBack As Button
    Friend WithEvents btnVisitExit As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
End Class
