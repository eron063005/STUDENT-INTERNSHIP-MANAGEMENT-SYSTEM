<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelVisit
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
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        cbDelCompany = New ComboBox()
        btnAddStdCancel = New RoundedButton()
        btnDelete = New RoundedButton()
        btnAddStd = New RoundedButton()
        btnCancel = New RoundedButton()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 75)
        Label1.TabIndex = 81
        Label1.Text = "VISIT"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 6
        RoundedPanel1.Controls.Add(cbDelCompany)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(btnAddStdCancel)
        RoundedPanel1.Controls.Add(btnDelete)
        RoundedPanel1.Controls.Add(btnAddStd)
        RoundedPanel1.Controls.Add(btnCancel)
        RoundedPanel1.CornerRadius = 2
        RoundedPanel1.FillColor = Color.White
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(820, 330)
        RoundedPanel1.TabIndex = 83
        ' 
        ' cbDelCompany
        ' 
        cbDelCompany.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbDelCompany.FormattingEnabled = True
        cbDelCompany.Location = New Point(35, 105)
        cbDelCompany.Name = "cbDelCompany"
        cbDelCompany.Size = New Size(755, 78)
        cbDelCompany.TabIndex = 82
        ' 
        ' btnAddStdCancel
        ' 
        btnAddStdCancel.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStdCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStdCancel.BorderSize = 5
        btnAddStdCancel.CornerRadius = 10
        btnAddStdCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStdCancel.FlatStyle = FlatStyle.Flat
        btnAddStdCancel.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStdCancel.ForeColor = Color.Black
        btnAddStdCancel.HoverColor = Color.Yellow
        btnAddStdCancel.Location = New Point(697, 618)
        btnAddStdCancel.Name = "btnAddStdCancel"
        btnAddStdCancel.PressedColor = Color.Red
        btnAddStdCancel.Size = New Size(171, 63)
        btnAddStdCancel.TabIndex = 30
        btnAddStdCancel.Text = "Cancel "
        btnAddStdCancel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnDelete.BorderSize = 5
        btnDelete.CornerRadius = 18
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Black
        btnDelete.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnDelete.Location = New Point(406, 219)
        btnDelete.Name = "btnDelete"
        btnDelete.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnDelete.Size = New Size(384, 67)
        btnDelete.TabIndex = 80
        btnDelete.Text = "Delete "
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAddStd
        ' 
        btnAddStd.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnAddStd.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnAddStd.BorderSize = 5
        btnAddStd.CornerRadius = 10
        btnAddStd.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnAddStd.FlatStyle = FlatStyle.Flat
        btnAddStd.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold)
        btnAddStd.ForeColor = Color.Black
        btnAddStd.HoverColor = Color.Yellow
        btnAddStd.Location = New Point(891, 618)
        btnAddStd.Name = "btnAddStd"
        btnAddStd.PressedColor = Color.Red
        btnAddStd.Size = New Size(171, 63)
        btnAddStd.TabIndex = 31
        btnAddStd.Text = "Add"
        btnAddStd.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.Control
        btnCancel.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnCancel.BorderSize = 5
        btnCancel.CornerRadius = 18
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Black
        btnCancel.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnCancel.Location = New Point(35, 219)
        btnCancel.Name = "btnCancel"
        btnCancel.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnCancel.Size = New Size(365, 67)
        btnCancel.TabIndex = 79
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmDelVisit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 330)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDelVisit"
        Text = "frmDelVisit"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents cbDelCompany As ComboBox
    Friend WithEvents btnAddStdCancel As RoundedButton
    Friend WithEvents btnDelete As RoundedButton
    Friend WithEvents btnAddStd As RoundedButton
    Friend WithEvents btnCancel As RoundedButton
End Class
