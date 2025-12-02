<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archPlacement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(archPlacement))
        dgvarchPlacement = New DataGridView()
        Label1 = New Label()
        btnPlaceExit = New Button()
        btnPlaceBack = New Button()
        RoundedButton2 = New RoundedButton()
        RoundedButton1 = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        CType(dgvarchPlacement, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvarchPlacement
        ' 
        dgvarchPlacement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvarchPlacement.Location = New Point(26, 123)
        dgvarchPlacement.Name = "dgvarchPlacement"
        dgvarchPlacement.RowHeadersWidth = 51
        dgvarchPlacement.Size = New Size(912, 393)
        dgvarchPlacement.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 37)
        Label1.TabIndex = 10
        Label1.Text = "Archieved Placement"
        ' 
        ' btnPlaceExit
        ' 
        btnPlaceExit.BackColor = Color.Transparent
        btnPlaceExit.Cursor = Cursors.Hand
        btnPlaceExit.FlatAppearance.BorderSize = 0
        btnPlaceExit.FlatStyle = FlatStyle.Flat
        btnPlaceExit.Image = CType(resources.GetObject("btnPlaceExit.Image"), Image)
        btnPlaceExit.Location = New Point(864, 21)
        btnPlaceExit.Name = "btnPlaceExit"
        btnPlaceExit.Size = New Size(74, 59)
        btnPlaceExit.TabIndex = 7
        btnPlaceExit.UseVisualStyleBackColor = False
        ' 
        ' btnPlaceBack
        ' 
        btnPlaceBack.Cursor = Cursors.Hand
        btnPlaceBack.FlatAppearance.BorderSize = 0
        btnPlaceBack.FlatStyle = FlatStyle.Flat
        btnPlaceBack.Image = CType(resources.GetObject("btnPlaceBack.Image"), Image)
        btnPlaceBack.Location = New Point(26, 21)
        btnPlaceBack.Name = "btnPlaceBack"
        btnPlaceBack.Size = New Size(74, 59)
        btnPlaceBack.TabIndex = 6
        btnPlaceBack.UseVisualStyleBackColor = True
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
        RoundedButton2.TabIndex = 25
        RoundedButton2.Text = "Delete Permanently"
        RoundedButton2.UseVisualStyleBackColor = False
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
        RoundedButton1.TabIndex = 24
        RoundedButton1.Text = "Restore"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnPlaceExit)
        RoundedPanel1.Controls.Add(btnPlaceBack)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 26
        ' 
        ' archPlacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(dgvarchPlacement)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "archPlacement"
        Text = "archPlacement"
        CType(dgvarchPlacement, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvarchPlacement As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlaceExit As Button
    Friend WithEvents btnPlaceBack As Button
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
End Class
