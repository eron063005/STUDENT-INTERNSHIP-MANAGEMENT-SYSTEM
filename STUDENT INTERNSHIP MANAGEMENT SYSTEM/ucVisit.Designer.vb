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
        panelVisit = New Panel()
        btnDelVisit = New RoundedButton()
        btnAddVisit = New RoundedButton()
        btnEditVisit = New RoundedButton()
        SuspendLayout()
        ' 
        ' panelVisit
        ' 
        panelVisit.AutoScroll = True
        panelVisit.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        panelVisit.BorderStyle = BorderStyle.FixedSingle
        panelVisit.Location = New Point(61, 26)
        panelVisit.Name = "panelVisit"
        panelVisit.Size = New Size(1400, 676)
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
        btnDelVisit.FlatStyle = FlatStyle.Flat
        btnDelVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelVisit.ForeColor = Color.Black
        btnDelVisit.HoverColor = Color.Yellow
        btnDelVisit.Image = My.Resources.Resources.Delete2
        btnDelVisit.ImageAlign = ContentAlignment.MiddleLeft
        btnDelVisit.Location = New Point(602, 737)
        btnDelVisit.Name = "btnDelVisit"
        btnDelVisit.PressedColor = Color.Red
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
        btnAddVisit.FlatStyle = FlatStyle.Flat
        btnAddVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddVisit.ForeColor = Color.Black
        btnAddVisit.HoverColor = Color.Yellow
        btnAddVisit.Location = New Point(28, 737)
        btnAddVisit.Name = "btnAddVisit"
        btnAddVisit.PressedColor = Color.Red
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
        btnEditVisit.FlatStyle = FlatStyle.Flat
        btnEditVisit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditVisit.ForeColor = Color.Black
        btnEditVisit.HoverColor = Color.Yellow
        btnEditVisit.Location = New Point(355, 737)
        btnEditVisit.Name = "btnEditVisit"
        btnEditVisit.PressedColor = Color.Red
        btnEditVisit.Size = New Size(219, 77)
        btnEditVisit.TabIndex = 8
        btnEditVisit.Text = "Edit"
        btnEditVisit.UseVisualStyleBackColor = False
        ' 
        ' ucVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(btnDelVisit)
        Controls.Add(panelVisit)
        Controls.Add(btnEditVisit)
        Controls.Add(btnAddVisit)
        Name = "ucVisit"
        Size = New Size(1496, 837)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelVisit As Panel
    Friend WithEvents btnDelVisit As RoundedButton
    Friend WithEvents btnAddVisit As RoundedButton
    Friend WithEvents btnEditVisit As RoundedButton

End Class
