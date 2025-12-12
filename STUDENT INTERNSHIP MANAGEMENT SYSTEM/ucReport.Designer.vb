<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelCard = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        btnImportFile = New RoundedButton()
        btnPrintSummary = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        Label3 = New Label()
        Label4 = New Label()
        RoundedButton1 = New RoundedButton()
        panelCard.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelCard
        ' 
        panelCard.BackColor = Color.Transparent
        panelCard.BorderColor = Color.Black
        panelCard.BorderSize = 5
        panelCard.Controls.Add(Label2)
        panelCard.Controls.Add(Label1)
        panelCard.Controls.Add(btnImportFile)
        panelCard.CornerRadius = 20
        panelCard.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        panelCard.Location = New Point(38, 26)
        panelCard.Name = "panelCard"
        panelCard.Size = New Size(587, 436)
        panelCard.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(418, 280)
        Label2.TabIndex = 12
        Label2.Text = "Used to import and" & vbCrLf & "preview student " & vbCrLf & "internship data from" & vbCrLf & " a CSV file, enabling the " & vbCrLf & "generation of " & vbCrLf & "visualization graphs" & vbCrLf & "via Python."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 59)
        Label1.TabIndex = 11
        ' 
        ' btnImportFile
        ' 
        btnImportFile.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnImportFile.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnImportFile.BorderSize = 5
        btnImportFile.CornerRadius = 18
        btnImportFile.Cursor = Cursors.Hand
        btnImportFile.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnImportFile.FlatAppearance.BorderSize = 0
        btnImportFile.FlatStyle = FlatStyle.Flat
        btnImportFile.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImportFile.ForeColor = Color.Black
        btnImportFile.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnImportFile.Location = New Point(283, 332)
        btnImportFile.Name = "btnImportFile"
        btnImportFile.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnImportFile.Size = New Size(277, 69)
        btnImportFile.TabIndex = 5
        btnImportFile.Text = "Import"
        btnImportFile.UseVisualStyleBackColor = False
        ' 
        ' btnPrintSummary
        ' 
        btnPrintSummary.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnPrintSummary.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnPrintSummary.BorderSize = 5
        btnPrintSummary.CornerRadius = 18
        btnPrintSummary.Cursor = Cursors.Hand
        btnPrintSummary.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnPrintSummary.FlatAppearance.BorderSize = 0
        btnPrintSummary.FlatStyle = FlatStyle.Flat
        btnPrintSummary.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrintSummary.ForeColor = Color.Black
        btnPrintSummary.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnPrintSummary.Location = New Point(65, 779)
        btnPrintSummary.Name = "btnPrintSummary"
        btnPrintSummary.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnPrintSummary.Size = New Size(277, 69)
        btnPrintSummary.TabIndex = 13
        btnPrintSummary.Text = "Import"
        btnPrintSummary.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(RoundedButton1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(644, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(587, 436)
        RoundedPanel1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(418, 280)
        Label3.TabIndex = 12
        Label3.Text = "Used to import and" & vbCrLf & "preview student " & vbCrLf & "internship data from" & vbCrLf & " a CSV file, enabling the " & vbCrLf & "generation of " & vbCrLf & "visualization graphs" & vbCrLf & "via Python."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 59)
        Label4.TabIndex = 11
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedButton1.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        RoundedButton1.BorderSize = 5
        RoundedButton1.CornerRadius = 18
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        RoundedButton1.Location = New Point(283, 332)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        RoundedButton1.Size = New Size(277, 69)
        RoundedButton1.TabIndex = 5
        RoundedButton1.Text = "Create Summary"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' ucReport
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(btnPrintSummary)
        Controls.Add(RoundedPanel1)
        Controls.Add(panelCard)
        Name = "ucReport"
        Size = New Size(1496, 884)
        panelCard.ResumeLayout(False)
        panelCard.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelCard As RoundedPanel
    Friend WithEvents btnImportFile As RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrintSummary As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundedButton1 As RoundedButton

End Class
