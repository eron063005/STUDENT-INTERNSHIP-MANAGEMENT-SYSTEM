<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucVisit))
        panelVisit = New Panel()
        btnDelVisit = New RoundedButton()
        btnAddVisit = New RoundedButton()
        btnEditVisit = New RoundedButton()
        btnarchVisit = New Button()
        RoundedPanel1 = New RoundedPanel()
        PictureBox1 = New PictureBox()
        txtStdSearchBox = New TextBox()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelVisit
        ' 
        panelVisit.AutoScroll = True
        panelVisit.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        panelVisit.BorderStyle = BorderStyle.FixedSingle
        panelVisit.Location = New Point(51, 114)
        panelVisit.Name = "panelVisit"
        panelVisit.Size = New Size(1400, 595)
        panelVisit.TabIndex = 0
        ' 
        ' btnDelVisit
        ' 
        btnDelVisit.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnDelVisit.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelVisit.BorderSize = 5
        btnDelVisit.CornerRadius = 18
        btnDelVisit.Cursor = Cursors.Hand
        btnDelVisit.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelVisit.FlatAppearance.BorderSize = 0
        btnDelVisit.FlatStyle = FlatStyle.Flat
        btnDelVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelVisit.ForeColor = Color.Black
        btnDelVisit.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDelVisit.Image = My.Resources.Resources.Delete2
        btnDelVisit.ImageAlign = ContentAlignment.MiddleLeft
        btnDelVisit.Location = New Point(602, 752)
        btnDelVisit.Name = "btnDelVisit"
        btnDelVisit.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnDelVisit.Size = New Size(209, 77)
        btnDelVisit.TabIndex = 9
        btnDelVisit.Text = "Delete "
        btnDelVisit.TextAlign = ContentAlignment.MiddleLeft
        btnDelVisit.UseVisualStyleBackColor = False
        ' 
        ' btnAddVisit
        ' 
        btnAddVisit.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnAddVisit.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddVisit.BorderSize = 5
        btnAddVisit.CornerRadius = 18
        btnAddVisit.Cursor = Cursors.Hand
        btnAddVisit.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddVisit.FlatAppearance.BorderSize = 0
        btnAddVisit.FlatStyle = FlatStyle.Flat
        btnAddVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddVisit.ForeColor = Color.Black
        btnAddVisit.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddVisit.Location = New Point(28, 752)
        btnAddVisit.Name = "btnAddVisit"
        btnAddVisit.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddVisit.Size = New Size(290, 77)
        btnAddVisit.TabIndex = 7
        btnAddVisit.Text = "Add Visit"
        btnAddVisit.UseVisualStyleBackColor = False
        ' 
        ' btnEditVisit
        ' 
        btnEditVisit.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnEditVisit.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditVisit.BorderSize = 5
        btnEditVisit.CornerRadius = 18
        btnEditVisit.Cursor = Cursors.Hand
        btnEditVisit.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditVisit.FlatAppearance.BorderSize = 0
        btnEditVisit.FlatStyle = FlatStyle.Flat
        btnEditVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditVisit.ForeColor = Color.Black
        btnEditVisit.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditVisit.Location = New Point(355, 752)
        btnEditVisit.Name = "btnEditVisit"
        btnEditVisit.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditVisit.Size = New Size(219, 77)
        btnEditVisit.TabIndex = 8
        btnEditVisit.Text = "Edit"
        btnEditVisit.UseVisualStyleBackColor = False
        ' 
        ' btnarchVisit
        ' 
        btnarchVisit.Cursor = Cursors.Hand
        btnarchVisit.FlatAppearance.BorderSize = 0
        btnarchVisit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchVisit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchVisit.FlatStyle = FlatStyle.Flat
        btnarchVisit.Image = CType(resources.GetObject("btnarchVisit.Image"), Image)
        btnarchVisit.Location = New Point(1342, 730)
        btnarchVisit.Name = "btnarchVisit"
        btnarchVisit.Size = New Size(128, 119)
        btnarchVisit.TabIndex = 11
        btnarchVisit.UseVisualStyleBackColor = True
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
        RoundedPanel1.TabIndex = 12
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
        ' ucVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(RoundedPanel1)
        Controls.Add(btnarchVisit)
        Controls.Add(btnDelVisit)
        Controls.Add(panelVisit)
        Controls.Add(btnEditVisit)
        Controls.Add(btnAddVisit)
        Name = "ucVisit"
        Size = New Size(1496, 884)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelVisit As Panel
    Friend WithEvents btnDelVisit As RoundedButton
    Friend WithEvents btnAddVisit As RoundedButton
    Friend WithEvents btnEditVisit As RoundedButton
    Friend WithEvents btnarchVisit As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtStdSearchBox As TextBox

End Class
