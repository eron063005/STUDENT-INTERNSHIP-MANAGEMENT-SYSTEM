<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(archCompany))
        dgvarchCompany = New DataGridView()
        RoundedPanel1 = New RoundedPanel()
        btnCompExit = New Button()
        Label2 = New Label()
        btnCompBack = New Button()
        btnDeletePermanent = New RoundedButton()
        btnRestore = New RoundedButton()
        CType(dgvarchCompany, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvarchCompany
        ' 
        dgvarchCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvarchCompany.Location = New Point(26, 123)
        dgvarchCompany.Name = "dgvarchCompany"
        dgvarchCompany.RowHeadersWidth = 51
        dgvarchCompany.Size = New Size(912, 393)
        dgvarchCompany.TabIndex = 1
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(btnCompExit)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(btnCompBack)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 23
        ' 
        ' btnCompExit
        ' 
        btnCompExit.BackColor = Color.Transparent
        btnCompExit.Cursor = Cursors.Hand
        btnCompExit.FlatAppearance.BorderSize = 0
        btnCompExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnCompExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnCompExit.FlatStyle = FlatStyle.Flat
        btnCompExit.Image = CType(resources.GetObject("btnCompExit.Image"), Image)
        btnCompExit.Location = New Point(864, 21)
        btnCompExit.Name = "btnCompExit"
        btnCompExit.Size = New Size(74, 59)
        btnCompExit.TabIndex = 7
        btnCompExit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(321, 37)
        Label2.TabIndex = 5
        Label2.Text = "Archieved Company"
        ' 
        ' btnCompBack
        ' 
        btnCompBack.Cursor = Cursors.Hand
        btnCompBack.FlatAppearance.BorderSize = 0
        btnCompBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnCompBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnCompBack.FlatStyle = FlatStyle.Flat
        btnCompBack.Image = CType(resources.GetObject("btnCompBack.Image"), Image)
        btnCompBack.Location = New Point(26, 21)
        btnCompBack.Name = "btnCompBack"
        btnCompBack.Size = New Size(74, 59)
        btnCompBack.TabIndex = 6
        btnCompBack.UseVisualStyleBackColor = True
        ' 
        ' btnDeletePermanent
        ' 
        btnDeletePermanent.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnDeletePermanent.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDeletePermanent.BorderSize = 3
        btnDeletePermanent.CornerRadius = 20
        btnDeletePermanent.Cursor = Cursors.Hand
        btnDeletePermanent.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDeletePermanent.FlatAppearance.BorderSize = 0
        btnDeletePermanent.FlatStyle = FlatStyle.Flat
        btnDeletePermanent.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnDeletePermanent.ForeColor = Color.Black
        btnDeletePermanent.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDeletePermanent.Location = New Point(716, 526)
        btnDeletePermanent.Name = "btnDeletePermanent"
        btnDeletePermanent.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnDeletePermanent.Size = New Size(222, 59)
        btnDeletePermanent.TabIndex = 22
        btnDeletePermanent.Text = "Delete Permanently"
        btnDeletePermanent.UseVisualStyleBackColor = False
        ' 
        ' btnRestore
        ' 
        btnRestore.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnRestore.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnRestore.BorderSize = 3
        btnRestore.CornerRadius = 20
        btnRestore.Cursor = Cursors.Hand
        btnRestore.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnRestore.FlatAppearance.BorderSize = 0
        btnRestore.FlatStyle = FlatStyle.Flat
        btnRestore.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnRestore.ForeColor = Color.Black
        btnRestore.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnRestore.Location = New Point(524, 526)
        btnRestore.Name = "btnRestore"
        btnRestore.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnRestore.Size = New Size(186, 59)
        btnRestore.TabIndex = 21
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = False
        ' 
        ' archCompany
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(btnDeletePermanent)
        Controls.Add(btnRestore)
        Controls.Add(dgvarchCompany)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "archCompany"
        Text = "archCompany"
        CType(dgvarchCompany, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvarchCompany As DataGridView
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnCompExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCompBack As Button
    Friend WithEvents btnDeletePermanent As RoundedButton
    Friend WithEvents btnRestore As RoundedButton
End Class
