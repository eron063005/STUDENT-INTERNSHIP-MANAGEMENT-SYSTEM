<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCompanyCard
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
        panelCard = New RoundedPanel()
        lblCompanyEmail = New Label()
        Label7 = New Label()
        lblCompanyConNum = New Label()
        Label5 = New Label()
        lblCompanyAddr = New Label()
        Label3 = New Label()
        lblCompanyName = New Label()
        lblCompanyID = New Label()
        btnViewSupervisor = New RoundedButton()
        panelCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelCard
        ' 
        panelCard.BackColor = Color.Transparent
        panelCard.BorderColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        panelCard.BorderSize = 5
        panelCard.Controls.Add(lblCompanyEmail)
        panelCard.Controls.Add(Label7)
        panelCard.Controls.Add(lblCompanyConNum)
        panelCard.Controls.Add(Label5)
        panelCard.Controls.Add(lblCompanyAddr)
        panelCard.Controls.Add(Label3)
        panelCard.Controls.Add(lblCompanyName)
        panelCard.Controls.Add(lblCompanyID)
        panelCard.Controls.Add(btnViewSupervisor)
        panelCard.CornerRadius = 20
        panelCard.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        panelCard.Location = New Point(3, 3)
        panelCard.Name = "panelCard"
        panelCard.Size = New Size(668, 509)
        panelCard.TabIndex = 0
        ' 
        ' lblCompanyEmail
        ' 
        lblCompanyEmail.AutoSize = True
        lblCompanyEmail.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblCompanyEmail.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        lblCompanyEmail.Location = New Point(44, 343)
        lblCompanyEmail.Name = "lblCompanyEmail"
        lblCompanyEmail.Size = New Size(262, 34)
        lblCompanyEmail.TabIndex = 8
        lblCompanyEmail.Text = "hr@technova.com"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.Location = New Point(44, 323)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 23)
        Label7.TabIndex = 7
        Label7.Text = "Email:"
        ' 
        ' lblCompanyConNum
        ' 
        lblCompanyConNum.AutoSize = True
        lblCompanyConNum.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblCompanyConNum.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        lblCompanyConNum.Location = New Point(44, 258)
        lblCompanyConNum.Name = "lblCompanyConNum"
        lblCompanyConNum.Size = New Size(159, 34)
        lblCompanyConNum.TabIndex = 6
        lblCompanyConNum.Text = "288881234"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.Location = New Point(44, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 23)
        Label5.TabIndex = 5
        Label5.Text = "Contact No."
        ' 
        ' lblCompanyAddr
        ' 
        lblCompanyAddr.AutoSize = True
        lblCompanyAddr.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblCompanyAddr.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        lblCompanyAddr.Location = New Point(44, 181)
        lblCompanyAddr.Name = "lblCompanyAddr"
        lblCompanyAddr.Size = New Size(359, 34)
        lblCompanyAddr.TabIndex = 4
        lblCompanyAddr.Text = "Ortigas Center, Pasig City"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.Location = New Point(44, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 3
        Label3.Text = "Address: "
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.AutoSize = True
        lblCompanyName.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblCompanyName.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompanyName.Location = New Point(42, 63)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(561, 56)
        lblCompanyName.TabIndex = 2
        lblCompanyName.Text = "TechNova Solutions Inc."
        ' 
        ' lblCompanyID
        ' 
        lblCompanyID.AutoSize = True
        lblCompanyID.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        lblCompanyID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblCompanyID.Location = New Point(44, 40)
        lblCompanyID.Name = "lblCompanyID"
        lblCompanyID.Size = New Size(76, 23)
        lblCompanyID.TabIndex = 1
        lblCompanyID.Text = "CO001"
        ' 
        ' btnViewSupervisor
        ' 
        btnViewSupervisor.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnViewSupervisor.BorderColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        btnViewSupervisor.BorderSize = 5
        btnViewSupervisor.CornerRadius = 10
        btnViewSupervisor.Cursor = Cursors.Hand
        btnViewSupervisor.FillColor = Color.FromArgb(CByte(218), CByte(248), CByte(255))
        btnViewSupervisor.FlatStyle = FlatStyle.Flat
        btnViewSupervisor.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSupervisor.ForeColor = Color.Black
        btnViewSupervisor.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnViewSupervisor.Location = New Point(396, 423)
        btnViewSupervisor.Name = "btnViewSupervisor"
        btnViewSupervisor.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnViewSupervisor.Size = New Size(233, 64)
        btnViewSupervisor.TabIndex = 0
        btnViewSupervisor.Text = "View Supervisor "
        btnViewSupervisor.UseVisualStyleBackColor = False
        ' 
        ' ucCompanyCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(panelCard)
        Name = "ucCompanyCard"
        Size = New Size(679, 515)
        panelCard.ResumeLayout(False)
        panelCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelCard As RoundedPanel
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCompanyID As Label
    Friend WithEvents btnViewSupervisor As RoundedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCompanyEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCompanyConNum As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCompanyAddr As Label

End Class
