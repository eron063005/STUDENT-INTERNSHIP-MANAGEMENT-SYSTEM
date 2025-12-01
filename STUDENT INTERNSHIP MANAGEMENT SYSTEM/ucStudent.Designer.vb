<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudent
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
        dgvStudent = New DataGridView()
        btnEditStudent = New RoundedButton()
        btnDelStudent = New RoundedButton()
        btnAddStudent = New RoundedButton()
        btnImportFile = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        PictureBox1 = New PictureBox()
        txtSearchBar = New TextBox()
        ComboBox1 = New ComboBox()
        PictureBox2 = New PictureBox()
        RoundedPanel2 = New RoundedPanel()
        CType(dgvStudent, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvStudent
        ' 
        dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudent.Location = New Point(28, 114)
        dgvStudent.Name = "dgvStudent"
        dgvStudent.RowHeadersWidth = 51
        dgvStudent.Size = New Size(1442, 595)
        dgvStudent.TabIndex = 0
        ' 
        ' btnEditStudent
        ' 
        btnEditStudent.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnEditStudent.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditStudent.BorderSize = 5
        btnEditStudent.CornerRadius = 18
        btnEditStudent.Cursor = Cursors.Hand
        btnEditStudent.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditStudent.FlatStyle = FlatStyle.Flat
        btnEditStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditStudent.ForeColor = Color.Black
        btnEditStudent.HoverColor = Color.Yellow
        btnEditStudent.Location = New Point(355, 737)
        btnEditStudent.Name = "btnEditStudent"
        btnEditStudent.PressedColor = Color.Red
        btnEditStudent.Size = New Size(219, 77)
        btnEditStudent.TabIndex = 2
        btnEditStudent.Text = "Edit"
        btnEditStudent.UseVisualStyleBackColor = False
        ' 
        ' btnDelStudent
        ' 
        btnDelStudent.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnDelStudent.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelStudent.BorderSize = 5
        btnDelStudent.CornerRadius = 18
        btnDelStudent.Cursor = Cursors.Hand
        btnDelStudent.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelStudent.FlatStyle = FlatStyle.Flat
        btnDelStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelStudent.ForeColor = Color.Black
        btnDelStudent.HoverColor = Color.Yellow
        btnDelStudent.Image = My.Resources.Resources.Delete2
        btnDelStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnDelStudent.Location = New Point(602, 737)
        btnDelStudent.Name = "btnDelStudent"
        btnDelStudent.PressedColor = Color.Red
        btnDelStudent.Size = New Size(209, 77)
        btnDelStudent.TabIndex = 3
        btnDelStudent.Text = "Delete "
        btnDelStudent.TextAlign = ContentAlignment.MiddleLeft
        btnDelStudent.UseVisualStyleBackColor = False
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnAddStudent.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStudent.BorderSize = 5
        btnAddStudent.CornerRadius = 18
        btnAddStudent.Cursor = Cursors.Hand
        btnAddStudent.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStudent.ForeColor = Color.Black
        btnAddStudent.HoverColor = Color.Yellow
        btnAddStudent.Location = New Point(28, 737)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.PressedColor = Color.Red
        btnAddStudent.Size = New Size(290, 77)
        btnAddStudent.TabIndex = 1
        btnAddStudent.Text = "Add Student"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' btnImportFile
        ' 
        btnImportFile.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnImportFile.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnImportFile.BorderSize = 5
        btnImportFile.CornerRadius = 18
        btnImportFile.Cursor = Cursors.Hand
        btnImportFile.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnImportFile.FlatStyle = FlatStyle.Flat
        btnImportFile.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImportFile.ForeColor = Color.Black
        btnImportFile.HoverColor = Color.Yellow
        btnImportFile.Location = New Point(1225, 737)
        btnImportFile.Name = "btnImportFile"
        btnImportFile.PressedColor = Color.Red
        btnImportFile.Size = New Size(219, 77)
        btnImportFile.TabIndex = 4
        btnImportFile.Text = "Import"
        btnImportFile.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.FromArgb(CByte(80), CByte(118), CByte(133))
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Controls.Add(txtSearchBar)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.FillColor = Color.White
        RoundedPanel1.Location = New Point(28, 25)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(862, 65)
        RoundedPanel1.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Search
        PictureBox1.Location = New Point(8, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 52)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtSearchBar
        ' 
        txtSearchBar.BorderStyle = BorderStyle.None
        txtSearchBar.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchBar.Location = New Point(64, 12)
        txtSearchBar.Name = "txtSearchBar"
        txtSearchBar.Size = New Size(787, 41)
        txtSearchBar.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All Departments"})
        ComboBox1.Location = New Point(62, 13)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(235, 40)
        ComboBox1.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Filter
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 59)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.Transparent
        RoundedPanel2.BorderColor = Color.Black
        RoundedPanel2.BorderSize = 2
        RoundedPanel2.Controls.Add(PictureBox2)
        RoundedPanel2.Controls.Add(ComboBox1)
        RoundedPanel2.CornerRadius = 2
        RoundedPanel2.FillColor = Color.White
        RoundedPanel2.Location = New Point(909, 25)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(299, 65)
        RoundedPanel2.TabIndex = 8
        ' 
        ' ucStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(RoundedPanel2)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnImportFile)
        Controls.Add(btnDelStudent)
        Controls.Add(btnEditStudent)
        Controls.Add(btnAddStudent)
        Controls.Add(dgvStudent)
        Name = "ucStudent"
        Size = New Size(1496, 837)
        CType(dgvStudent, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents btnEditStudent As RoundedButton
    Friend WithEvents btnDelStudent As RoundedButton
    Friend WithEvents btnAddStudent As RoundedButton
    Friend WithEvents btnImportFile As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel2 As RoundedPanel

End Class
