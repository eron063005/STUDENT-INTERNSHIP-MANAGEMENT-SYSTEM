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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStudent))
        dgvStudent = New DataGridView()
        btnEditStudent = New RoundedButton()
        btnDelStudent = New RoundedButton()
        btnAddStudent = New RoundedButton()
        btnImportFile = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        PictureBox1 = New PictureBox()
        txtStdSearchBox = New TextBox()
        btnarchStudents = New Button()
        CType(dgvStudent, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnEditStudent.FlatAppearance.BorderSize = 0
        btnEditStudent.FlatStyle = FlatStyle.Flat
        btnEditStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditStudent.ForeColor = Color.Black
        btnEditStudent.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditStudent.Location = New Point(355, 752)
        btnEditStudent.Name = "btnEditStudent"
        btnEditStudent.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
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
        btnDelStudent.FlatAppearance.BorderSize = 0
        btnDelStudent.FlatStyle = FlatStyle.Flat
        btnDelStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelStudent.ForeColor = Color.Black
        btnDelStudent.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDelStudent.Image = My.Resources.Resources.Delete2
        btnDelStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnDelStudent.Location = New Point(602, 752)
        btnDelStudent.Name = "btnDelStudent"
        btnDelStudent.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
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
        btnAddStudent.FlatAppearance.BorderSize = 0
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStudent.ForeColor = Color.Black
        btnAddStudent.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddStudent.Location = New Point(28, 752)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
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
        btnImportFile.FlatAppearance.BorderSize = 0
        btnImportFile.FlatStyle = FlatStyle.Flat
        btnImportFile.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImportFile.ForeColor = Color.Black
        btnImportFile.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnImportFile.Location = New Point(1083, 752)
        btnImportFile.Name = "btnImportFile"
        btnImportFile.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
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
        RoundedPanel1.Controls.Add(txtStdSearchBox)
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
        ' txtStdSearchBox
        ' 
        txtStdSearchBox.BorderStyle = BorderStyle.None
        txtStdSearchBox.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStdSearchBox.Location = New Point(64, 12)
        txtStdSearchBox.Name = "txtStdSearchBox"
        txtStdSearchBox.Size = New Size(787, 41)
        txtStdSearchBox.TabIndex = 0
        ' 
        ' btnarchStudents
        ' 
        btnarchStudents.FlatAppearance.BorderSize = 0
        btnarchStudents.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchStudents.FlatStyle = FlatStyle.Flat
        btnarchStudents.Image = CType(resources.GetObject("btnarchStudents.Image"), Image)
        btnarchStudents.Location = New Point(1342, 730)
        btnarchStudents.Name = "btnarchStudents"
        btnarchStudents.Size = New Size(128, 119)
        btnarchStudents.TabIndex = 9
        btnarchStudents.UseVisualStyleBackColor = True
        ' 
        ' ucStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(btnarchStudents)
        Controls.Add(RoundedPanel1)
        Controls.Add(btnImportFile)
        Controls.Add(btnDelStudent)
        Controls.Add(btnEditStudent)
        Controls.Add(btnAddStudent)
        Controls.Add(dgvStudent)
        Cursor = Cursors.Hand
        Name = "ucStudent"
        Size = New Size(1496, 884)
        CType(dgvStudent, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents btnEditStudent As RoundedButton
    Friend WithEvents btnDelStudent As RoundedButton
    Friend WithEvents btnAddStudent As RoundedButton
    Friend WithEvents btnImportFile As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtStdSearchBox As TextBox
    Friend WithEvents btnarchStudents As Button

End Class
