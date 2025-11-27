<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUpcomingVisitItem
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
        lblUVDate = New Label()
        lblUVName = New Label()
        lblUVCompany = New Label()
        lblUVTime = New Label()
        Panel1 = New Panel()
        RoundedPanel2 = New RoundedPanel()
        RoundedPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUVDate
        ' 
        lblUVDate.AutoSize = True
        lblUVDate.BackColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        lblUVDate.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUVDate.ForeColor = Color.White
        lblUVDate.Location = New Point(14, 22)
        lblUVDate.Name = "lblUVDate"
        lblUVDate.Size = New Size(51, 37)
        lblUVDate.TabIndex = 0
        lblUVDate.Text = "15"
        ' 
        ' lblUVName
        ' 
        lblUVName.AutoSize = True
        lblUVName.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUVName.Location = New Point(238, 72)
        lblUVName.Name = "lblUVName"
        lblUVName.Size = New Size(182, 40)
        lblUVName.TabIndex = 1
        lblUVName.Text = "Rose Dela"
        ' 
        ' lblUVCompany
        ' 
        lblUVCompany.AutoSize = True
        lblUVCompany.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUVCompany.Location = New Point(238, 113)
        lblUVCompany.Name = "lblUVCompany"
        lblUVCompany.Size = New Size(339, 34)
        lblUVCompany.TabIndex = 2
        lblUVCompany.Text = "TechNova Solutions Inc."
        ' 
        ' lblUVTime
        ' 
        lblUVTime.AutoSize = True
        lblUVTime.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUVTime.Location = New Point(238, 147)
        lblUVTime.Name = "lblUVTime"
        lblUVTime.Size = New Size(99, 23)
        lblUVTime.TabIndex = 3
        lblUVTime.Text = "10:00 AM"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        Panel1.Location = New Point(115, 137)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(5, 67)
        Panel1.TabIndex = 15
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel2.BorderColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        RoundedPanel2.BorderSize = 5
        RoundedPanel2.Controls.Add(lblUVDate)
        RoundedPanel2.CornerRadius = 100
        RoundedPanel2.FillColor = Color.FromArgb(CByte(40), CByte(71), CByte(91))
        RoundedPanel2.Location = New Point(78, 53)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(77, 78)
        RoundedPanel2.TabIndex = 14
        ' 
        ' ucUpcomingVisitItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Controls.Add(Panel1)
        Controls.Add(lblUVTime)
        Controls.Add(lblUVCompany)
        Controls.Add(lblUVName)
        Controls.Add(RoundedPanel2)
        Name = "ucUpcomingVisitItem"
        Size = New Size(636, 235)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUVDate As Label
    Friend WithEvents lblUVName As Label
    Friend WithEvents lblUVCompany As Label
    Friend WithEvents lblUVTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RoundedPanel2 As RoundedPanel

End Class
