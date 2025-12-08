<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReport
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelCard = New RoundedPanel()
        WebView21Report = New Microsoft.Web.WebView2.WinForms.WebView2()
        btnViewCountPlot = New RoundedButton()
        RoundedPanel1 = New RoundedPanel()
        WebView22Report = New Microsoft.Web.WebView2.WinForms.WebView2()
        btnViewConfuseMatriz = New RoundedButton()
        panelCard.SuspendLayout()
        CType(WebView21Report, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(WebView22Report, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelCard
        ' 
        panelCard.BackColor = Color.Transparent
        panelCard.BorderColor = Color.Black
        panelCard.BorderSize = 5
        panelCard.Controls.Add(WebView21Report)
        panelCard.Controls.Add(btnViewCountPlot)
        panelCard.CornerRadius = 20
        panelCard.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        panelCard.Location = New Point(38, 26)
        panelCard.Name = "panelCard"
        panelCard.Size = New Size(696, 823)
        panelCard.TabIndex = 1
        ' 
        ' WebView21Report
        ' 
        WebView21Report.AllowExternalDrop = True
        WebView21Report.CreationProperties = Nothing
        WebView21Report.DefaultBackgroundColor = Color.White
        WebView21Report.Location = New Point(27, 30)
        WebView21Report.Name = "WebView21Report"
        WebView21Report.Size = New Size(642, 662)
        WebView21Report.TabIndex = 3
        WebView21Report.ZoomFactor = 1R
        ' 
        ' btnViewCountPlot
        ' 
        btnViewCountPlot.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnViewCountPlot.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnViewCountPlot.BorderSize = 5
        btnViewCountPlot.CornerRadius = 10
        btnViewCountPlot.Cursor = Cursors.Hand
        btnViewCountPlot.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnViewCountPlot.FlatStyle = FlatStyle.Flat
        btnViewCountPlot.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewCountPlot.ForeColor = Color.Black
        btnViewCountPlot.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnViewCountPlot.Location = New Point(27, 713)
        btnViewCountPlot.Name = "btnViewCountPlot"
        btnViewCountPlot.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnViewCountPlot.Size = New Size(642, 85)
        btnViewCountPlot.TabIndex = 0
        btnViewCountPlot.Text = "Generate"
        btnViewCountPlot.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.Transparent
        RoundedPanel1.BorderColor = Color.Black
        RoundedPanel1.BorderSize = 5
        RoundedPanel1.Controls.Add(WebView22Report)
        RoundedPanel1.Controls.Add(btnViewConfuseMatriz)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.FillColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        RoundedPanel1.Location = New Point(769, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(696, 823)
        RoundedPanel1.TabIndex = 2
        ' 
        ' WebView22Report
        ' 
        WebView22Report.AllowExternalDrop = True
        WebView22Report.CreationProperties = Nothing
        WebView22Report.DefaultBackgroundColor = Color.White
        WebView22Report.Location = New Point(36, 30)
        WebView22Report.Name = "WebView22Report"
        WebView22Report.Size = New Size(642, 662)
        WebView22Report.TabIndex = 4
        WebView22Report.ZoomFactor = 1R
        ' 
        ' btnViewConfuseMatriz
        ' 
        btnViewConfuseMatriz.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnViewConfuseMatriz.BorderColor = Color.FromArgb(CByte(49), CByte(119), CByte(180))
        btnViewConfuseMatriz.BorderSize = 5
        btnViewConfuseMatriz.CornerRadius = 10
        btnViewConfuseMatriz.Cursor = Cursors.Hand
        btnViewConfuseMatriz.FillColor = Color.FromArgb(CByte(120), CByte(201), CByte(221))
        btnViewConfuseMatriz.FlatStyle = FlatStyle.Flat
        btnViewConfuseMatriz.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewConfuseMatriz.ForeColor = Color.Black
        btnViewConfuseMatriz.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnViewConfuseMatriz.Location = New Point(27, 713)
        btnViewConfuseMatriz.Name = "btnViewConfuseMatriz"
        btnViewConfuseMatriz.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnViewConfuseMatriz.Size = New Size(642, 85)
        btnViewConfuseMatriz.TabIndex = 0
        btnViewConfuseMatriz.Text = "Generate"
        btnViewConfuseMatriz.UseVisualStyleBackColor = False
        ' 
        ' ucReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(RoundedPanel1)
        Controls.Add(panelCard)
        Name = "ucReport"
        Size = New Size(1496, 884)
        panelCard.ResumeLayout(False)
        CType(WebView21Report, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        CType(WebView22Report, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelCard As RoundedPanel
    Friend WithEvents btnViewCountPlot As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents btnViewConfuseMatriz As RoundedButton
    Friend WithEvents WebView21Report As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents WebView22Report As Microsoft.Web.WebView2.WinForms.WebView2

End Class
