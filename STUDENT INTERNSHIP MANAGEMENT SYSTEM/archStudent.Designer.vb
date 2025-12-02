<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(archStudent))
        dgvarchStudent = New DataGridView()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        btnStdExit = New Button()
        btnStdBack = New Button()
        btnStdDelPerma = New RoundedButton()
        btnStdRestore = New RoundedButton()
        CType(dgvarchStudent, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvarchStudent
        ' 
        dgvarchStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvarchStudent.Location = New Point(26, 123)
        dgvarchStudent.Name = "dgvarchStudent"
        dgvarchStudent.RowHeadersWidth = 51
        dgvarchStudent.Size = New Size(912, 393)
        dgvarchStudent.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 37)
        Label1.TabIndex = 15
        Label1.Text = "Archieved Student"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(btnStdExit)
        RoundedPanel1.Controls.Add(btnStdBack)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(965, 601)
        RoundedPanel1.TabIndex = 29
        ' 
        ' btnStdExit
        ' 
        btnStdExit.BackColor = Color.Transparent
        btnStdExit.Cursor = Cursors.Hand
        btnStdExit.FlatAppearance.BorderSize = 0
        btnStdExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdExit.FlatStyle = FlatStyle.Flat
        btnStdExit.Image = CType(resources.GetObject("btnStdExit.Image"), Image)
        btnStdExit.Location = New Point(864, 21)
        btnStdExit.Name = "btnStdExit"
        btnStdExit.Size = New Size(74, 59)
        btnStdExit.TabIndex = 7
        btnStdExit.UseVisualStyleBackColor = False
        ' 
        ' btnStdBack
        ' 
        btnStdBack.Cursor = Cursors.Hand
        btnStdBack.FlatAppearance.BorderSize = 0
        btnStdBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdBack.FlatStyle = FlatStyle.Flat
        btnStdBack.Image = CType(resources.GetObject("btnStdBack.Image"), Image)
        btnStdBack.Location = New Point(26, 21)
        btnStdBack.Name = "btnStdBack"
        btnStdBack.Size = New Size(74, 59)
        btnStdBack.TabIndex = 6
        btnStdBack.UseVisualStyleBackColor = True
        ' 
        ' btnStdDelPerma
        ' 
        btnStdDelPerma.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdDelPerma.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnStdDelPerma.BorderSize = 3
        btnStdDelPerma.CornerRadius = 20
        btnStdDelPerma.Cursor = Cursors.Hand
        btnStdDelPerma.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnStdDelPerma.FlatAppearance.BorderSize = 0
        btnStdDelPerma.FlatStyle = FlatStyle.Flat
        btnStdDelPerma.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnStdDelPerma.ForeColor = Color.Black
        btnStdDelPerma.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnStdDelPerma.Location = New Point(716, 526)
        btnStdDelPerma.Name = "btnStdDelPerma"
        btnStdDelPerma.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnStdDelPerma.Size = New Size(222, 59)
        btnStdDelPerma.TabIndex = 28
        btnStdDelPerma.Text = "Delete Permanently"
        btnStdDelPerma.UseVisualStyleBackColor = False
        ' 
        ' btnStdRestore
        ' 
        btnStdRestore.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnStdRestore.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnStdRestore.BorderSize = 3
        btnStdRestore.CornerRadius = 20
        btnStdRestore.Cursor = Cursors.Hand
        btnStdRestore.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnStdRestore.FlatAppearance.BorderSize = 0
        btnStdRestore.FlatStyle = FlatStyle.Flat
        btnStdRestore.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnStdRestore.ForeColor = Color.Black
        btnStdRestore.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnStdRestore.Location = New Point(524, 526)
        btnStdRestore.Name = "btnStdRestore"
        btnStdRestore.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnStdRestore.Size = New Size(186, 59)
        btnStdRestore.TabIndex = 27
        btnStdRestore.Text = "Restore"
        btnStdRestore.UseVisualStyleBackColor = False
        ' 
        ' archStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 601)
        Controls.Add(btnStdDelPerma)
        Controls.Add(btnStdRestore)
        Controls.Add(dgvarchStudent)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "archStudent"
        Text = "archStudent"
        CType(dgvarchStudent, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvarchStudent As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnStdExit As Button
    Friend WithEvents btnStdBack As Button
    Friend WithEvents btnStdDelPerma As RoundedButton
    Friend WithEvents btnStdRestore As RoundedButton
End Class
