<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAssessment
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
        DataGridView1 = New DataGridView()
        btnDelAssessment = New RoundedButton()
        btnEditAssessment = New RoundedButton()
        btnAddAssessment = New RoundedButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 36)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1442, 673)
        DataGridView1.TabIndex = 0
        ' 
        ' btnDelAssessment
        ' 
        btnDelAssessment.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnDelAssessment.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelAssessment.BorderSize = 5
        btnDelAssessment.CornerRadius = 18
        btnDelAssessment.Cursor = Cursors.Hand
        btnDelAssessment.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelAssessment.FlatStyle = FlatStyle.Flat
        btnDelAssessment.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelAssessment.ForeColor = Color.Black
        btnDelAssessment.HoverColor = Color.Yellow
        btnDelAssessment.Image = My.Resources.Resources.Delete2
        btnDelAssessment.ImageAlign = ContentAlignment.MiddleLeft
        btnDelAssessment.Location = New Point(602, 737)
        btnDelAssessment.Name = "btnDelAssessment"
        btnDelAssessment.PressedColor = Color.Red
        btnDelAssessment.Size = New Size(209, 77)
        btnDelAssessment.TabIndex = 6
        btnDelAssessment.Text = "Delete "
        btnDelAssessment.TextAlign = ContentAlignment.MiddleLeft
        btnDelAssessment.UseVisualStyleBackColor = False
        ' 
        ' btnEditAssessment
        ' 
        btnEditAssessment.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnEditAssessment.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditAssessment.BorderSize = 5
        btnEditAssessment.CornerRadius = 18
        btnEditAssessment.Cursor = Cursors.Hand
        btnEditAssessment.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditAssessment.FlatStyle = FlatStyle.Flat
        btnEditAssessment.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditAssessment.ForeColor = Color.Black
        btnEditAssessment.HoverColor = Color.Yellow
        btnEditAssessment.Location = New Point(355, 737)
        btnEditAssessment.Name = "btnEditAssessment"
        btnEditAssessment.PressedColor = Color.Red
        btnEditAssessment.Size = New Size(219, 77)
        btnEditAssessment.TabIndex = 5
        btnEditAssessment.Text = "Edit"
        btnEditAssessment.UseVisualStyleBackColor = False
        ' 
        ' btnAddAssessment
        ' 
        btnAddAssessment.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnAddAssessment.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddAssessment.BorderSize = 5
        btnAddAssessment.CornerRadius = 18
        btnAddAssessment.Cursor = Cursors.Hand
        btnAddAssessment.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddAssessment.FlatStyle = FlatStyle.Flat
        btnAddAssessment.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddAssessment.ForeColor = Color.Black
        btnAddAssessment.HoverColor = Color.Yellow
        btnAddAssessment.Location = New Point(28, 737)
        btnAddAssessment.Name = "btnAddAssessment"
        btnAddAssessment.PressedColor = Color.Red
        btnAddAssessment.Size = New Size(290, 77)
        btnAddAssessment.TabIndex = 4
        btnAddAssessment.Text = "Add Assessment "
        btnAddAssessment.UseVisualStyleBackColor = False
        ' 
        ' ucAssessment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnDelAssessment)
        Controls.Add(btnEditAssessment)
        Controls.Add(btnAddAssessment)
        Controls.Add(DataGridView1)
        Name = "ucAssessment"
        Size = New Size(1496, 837)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelAssessment As RoundedButton
    Friend WithEvents btnEditAssessment As RoundedButton
    Friend WithEvents btnAddAssessment As RoundedButton

End Class
