<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCompany))
        CompanyContainer = New FlowLayoutPanel()
        btnDelCompany = New RoundedButton()
        btnAddCompany = New RoundedButton()
        btnEditCompany = New RoundedButton()
        btnarchCompany = New Button()
        RoundedPanel1 = New RoundedPanel()
        PictureBox1 = New PictureBox()
        txtStdSearchBox = New TextBox()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CompanyContainer
        ' 
        CompanyContainer.AutoScroll = True
        CompanyContainer.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        CompanyContainer.BorderStyle = BorderStyle.FixedSingle
        CompanyContainer.Location = New Point(65, 114)
        CompanyContainer.Name = "CompanyContainer"
        CompanyContainer.Size = New Size(1385, 595)
        CompanyContainer.TabIndex = 0
        ' 
        ' btnDelCompany
        ' 
        btnDelCompany.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnDelCompany.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelCompany.BorderSize = 5
        btnDelCompany.CornerRadius = 18
        btnDelCompany.Cursor = Cursors.Hand
        btnDelCompany.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelCompany.FlatStyle = FlatStyle.Flat
        btnDelCompany.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelCompany.ForeColor = Color.Black
        btnDelCompany.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDelCompany.Image = My.Resources.Resources.Delete2
        btnDelCompany.ImageAlign = ContentAlignment.MiddleLeft
        btnDelCompany.Location = New Point(602, 752)
        btnDelCompany.Name = "btnDelCompany"
        btnDelCompany.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnDelCompany.Size = New Size(209, 77)
        btnDelCompany.TabIndex = 9
        btnDelCompany.Text = "Delete "
        btnDelCompany.TextAlign = ContentAlignment.MiddleLeft
        btnDelCompany.UseVisualStyleBackColor = False
        ' 
        ' btnAddCompany
        ' 
        btnAddCompany.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnAddCompany.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddCompany.BorderSize = 5
        btnAddCompany.CornerRadius = 18
        btnAddCompany.Cursor = Cursors.Hand
        btnAddCompany.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddCompany.FlatStyle = FlatStyle.Flat
        btnAddCompany.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCompany.ForeColor = Color.Black
        btnAddCompany.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnAddCompany.Location = New Point(28, 752)
        btnAddCompany.Name = "btnAddCompany"
        btnAddCompany.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnAddCompany.Size = New Size(290, 77)
        btnAddCompany.TabIndex = 7
        btnAddCompany.Text = "Add Company"
        btnAddCompany.UseVisualStyleBackColor = False
        ' 
        ' btnEditCompany
        ' 
        btnEditCompany.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnEditCompany.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnEditCompany.BorderSize = 5
        btnEditCompany.CornerRadius = 18
        btnEditCompany.Cursor = Cursors.Hand
        btnEditCompany.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnEditCompany.FlatStyle = FlatStyle.Flat
        btnEditCompany.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditCompany.ForeColor = Color.Black
        btnEditCompany.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnEditCompany.Location = New Point(355, 752)
        btnEditCompany.Name = "btnEditCompany"
        btnEditCompany.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnEditCompany.Size = New Size(219, 77)
        btnEditCompany.TabIndex = 8
        btnEditCompany.Text = "Edit"
        btnEditCompany.UseVisualStyleBackColor = False
        ' 
        ' btnarchCompany
        ' 
        btnarchCompany.Cursor = Cursors.Hand
        btnarchCompany.FlatAppearance.BorderSize = 0
        btnarchCompany.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchCompany.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        btnarchCompany.FlatStyle = FlatStyle.Flat
        btnarchCompany.Image = CType(resources.GetObject("btnarchCompany.Image"), Image)
        btnarchCompany.Location = New Point(1342, 730)
        btnarchCompany.Name = "btnarchCompany"
        btnarchCompany.Size = New Size(128, 119)
        btnarchCompany.TabIndex = 10
        btnarchCompany.UseVisualStyleBackColor = True
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
        RoundedPanel1.TabIndex = 11
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
        ' ucCompany
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(RoundedPanel1)
        Controls.Add(btnarchCompany)
        Controls.Add(btnDelCompany)
        Controls.Add(CompanyContainer)
        Controls.Add(btnAddCompany)
        Controls.Add(btnEditCompany)
        Name = "ucCompany"
        Size = New Size(1496, 884)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CompanyContainer As FlowLayoutPanel
    Friend WithEvents btnDelCompany As RoundedButton
    Friend WithEvents btnEditCompany As RoundedButton
    Friend WithEvents btnAddCompany As RoundedButton
    Friend WithEvents btnarchCompany As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtStdSearchBox As TextBox

End Class
