<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlacement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPlacement))
        dgvPlacement = New DataGridView()
        btnDelPlacement = New RoundedButton()
        btnEditPlacement = New RoundedButton()
        btnAddPlacement = New RoundedButton()
        RoundedPanel3 = New RoundedPanel()
        ComboBox2 = New ComboBox()
        btnarchPlacement = New Button()
        CType(dgvPlacement, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvPlacement
        ' 
        dgvPlacement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPlacement.Location = New Point(28, 114)
        dgvPlacement.Name = "dgvPlacement"
        dgvPlacement.RowHeadersWidth = 51
        dgvPlacement.Size = New Size(1442, 595)
        dgvPlacement.TabIndex = 0
        ' 
        ' btnDelPlacement
        ' 
        btnDelPlacement.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnDelPlacement.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelPlacement.BorderSize = 5
        btnDelPlacement.CornerRadius = 18
        btnDelPlacement.Cursor = Cursors.Hand
        btnDelPlacement.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelPlacement.FlatAppearance.BorderSize = 0
        btnDelPlacement.FlatStyle = FlatStyle.Flat
        btnDelPlacement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelPlacement.ForeColor = Color.Black
        btnDelPlacement.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDelPlacement.Image = My.Resources.Resources.Delete2
        btnDelPlacement.ImageAlign = ContentAlignment.MiddleLeft
        btnDelPlacement.Location = New Point(602, 752)
        btnDelPlacement.Name = "btnDelPlacement"
        btnDelPlacement.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnDelPlacement.Size = New Size(209, 77)
        btnDelPlacement.TabIndex = 6
        btnDelPlacement.Text = "Delete "
        btnDelPlacement.TextAlign = ContentAlignment.MiddleLeft
        btnDelPlacement.UseVisualStyleBackColor = False
        ' 
        ' btnEditPlacement
        ' 
        btnEditPlacement.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnEditPlacement.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditPlacement.BorderSize = 5
        btnEditPlacement.CornerRadius = 18
        btnEditPlacement.Cursor = Cursors.Hand
        btnEditPlacement.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditPlacement.FlatAppearance.BorderSize = 0
        btnEditPlacement.FlatStyle = FlatStyle.Flat
        btnEditPlacement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditPlacement.ForeColor = Color.Black
        btnEditPlacement.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditPlacement.Location = New Point(355, 752)
        btnEditPlacement.Name = "btnEditPlacement"
        btnEditPlacement.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditPlacement.Size = New Size(219, 77)
        btnEditPlacement.TabIndex = 5
        btnEditPlacement.Text = "Edit"
        btnEditPlacement.UseVisualStyleBackColor = False
        ' 
        ' btnAddPlacement
        ' 
        btnAddPlacement.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnAddPlacement.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddPlacement.BorderSize = 5
        btnAddPlacement.CornerRadius = 18
        btnAddPlacement.Cursor = Cursors.Hand
        btnAddPlacement.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddPlacement.FlatAppearance.BorderSize = 0
        btnAddPlacement.FlatStyle = FlatStyle.Flat
        btnAddPlacement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddPlacement.ForeColor = Color.Black
        btnAddPlacement.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddPlacement.Location = New Point(28, 752)
        btnAddPlacement.Name = "btnAddPlacement"
        btnAddPlacement.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddPlacement.Size = New Size(290, 77)
        btnAddPlacement.TabIndex = 4
        btnAddPlacement.Text = "Add Placement "
        btnAddPlacement.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.Transparent
        RoundedPanel3.BorderColor = Color.Black
        RoundedPanel3.BorderSize = 2
        RoundedPanel3.Controls.Add(ComboBox2)
        RoundedPanel3.CornerRadius = 2
        RoundedPanel3.FillColor = Color.White
        RoundedPanel3.Location = New Point(1227, 25)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(243, 65)
        RoundedPanel3.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FlatStyle = FlatStyle.Flat
        ComboBox2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"All Status", "Active", "Completed ", "Pending"})
        ComboBox2.Location = New Point(3, 13)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(236, 40)
        ComboBox2.TabIndex = 6
        ' 
        ' btnarchPlacement
        ' 
        btnarchPlacement.Cursor = Cursors.Hand
        btnarchPlacement.FlatAppearance.BorderSize = 0
        btnarchPlacement.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchPlacement.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchPlacement.FlatStyle = FlatStyle.Flat
        btnarchPlacement.Image = CType(resources.GetObject("btnarchPlacement.Image"), Image)
        btnarchPlacement.Location = New Point(1342, 730)
        btnarchPlacement.Name = "btnarchPlacement"
        btnarchPlacement.Size = New Size(128, 119)
        btnarchPlacement.TabIndex = 12
        btnarchPlacement.UseVisualStyleBackColor = True
        ' 
        ' ucPlacement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(btnarchPlacement)
        Controls.Add(RoundedPanel3)
        Controls.Add(btnDelPlacement)
        Controls.Add(btnEditPlacement)
        Controls.Add(btnAddPlacement)
        Controls.Add(dgvPlacement)
        Name = "ucPlacement"
        Size = New Size(1496, 884)
        CType(dgvPlacement, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvPlacement As DataGridView
    Friend WithEvents btnDelPlacement As RoundedButton
    Friend WithEvents btnEditPlacement As RoundedButton
    Friend WithEvents btnAddPlacement As RoundedButton
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnarchPlacement As Button

End Class
