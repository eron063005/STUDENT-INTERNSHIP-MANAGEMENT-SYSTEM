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
        CompanyContainer = New FlowLayoutPanel()
        btnDelCompany = New RoundedButton()
        btnAddCompany = New RoundedButton()
        btnEditCompany = New RoundedButton()
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
        btnDelCompany.HoverColor = Color.Yellow
        btnDelCompany.Image = My.Resources.Resources.Delete2
        btnDelCompany.ImageAlign = ContentAlignment.MiddleLeft
        btnDelCompany.Location = New Point(602, 737)
        btnDelCompany.Name = "btnDelCompany"
        btnDelCompany.PressedColor = Color.Red
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
        btnAddCompany.HoverColor = Color.Yellow
        btnAddCompany.Location = New Point(28, 737)
        btnAddCompany.Name = "btnAddCompany"
        btnAddCompany.PressedColor = Color.Red
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
        btnEditCompany.HoverColor = Color.Yellow
        btnEditCompany.Location = New Point(355, 737)
        btnEditCompany.Name = "btnEditCompany"
        btnEditCompany.PressedColor = Color.Red
        btnEditCompany.Size = New Size(219, 77)
        btnEditCompany.TabIndex = 8
        btnEditCompany.Text = "Edit"
        btnEditCompany.UseVisualStyleBackColor = False
        ' 
        ' ucCompany
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(btnDelCompany)
        Controls.Add(CompanyContainer)
        Controls.Add(btnAddCompany)
        Controls.Add(btnEditCompany)
        Name = "ucCompany"
        Size = New Size(1513, 884)
        ResumeLayout(False)
    End Sub

    Friend WithEvents CompanyContainer As FlowLayoutPanel
    Friend WithEvents btnDelCompany As RoundedButton
    Friend WithEvents btnEditCompany As RoundedButton
    Friend WithEvents btnAddCompany As RoundedButton

End Class
