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
        btnGenerateGraph = New RoundedButton()
        picCounterPlot = New PictureBox()
        picConfusionMatrix = New PictureBox()
        CType(picCounterPlot, ComponentModel.ISupportInitialize).BeginInit()
        CType(picConfusionMatrix, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGenerateGraph
        ' 
        btnGenerateGraph.BackColor = Color.FromArgb(CByte(200), CByte(236), CByte(245))
        btnGenerateGraph.BorderColor = Color.FromArgb(CByte(159), CByte(177), CByte(195))
        btnGenerateGraph.BorderSize = 5
        btnGenerateGraph.CornerRadius = 10
        btnGenerateGraph.Cursor = Cursors.Hand
        btnGenerateGraph.FillColor = Color.FromArgb(CByte(218), CByte(248), CByte(255))
        btnGenerateGraph.FlatStyle = FlatStyle.Flat
        btnGenerateGraph.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerateGraph.ForeColor = Color.Black
        btnGenerateGraph.HoverColor = Color.FromArgb(CByte(140), CByte(220), CByte(235))
        btnGenerateGraph.Location = New Point(22, 799)
        btnGenerateGraph.Name = "btnGenerateGraph"
        btnGenerateGraph.PressedColor = Color.FromArgb(CByte(100), CByte(180), CByte(200))
        btnGenerateGraph.Size = New Size(233, 64)
        btnGenerateGraph.TabIndex = 1
        btnGenerateGraph.Text = "Generate Graph"
        btnGenerateGraph.UseVisualStyleBackColor = False
        ' 
        ' picCounterPlot
        ' 
        picCounterPlot.Location = New Point(76, 32)
        picCounterPlot.Name = "picCounterPlot"
        picCounterPlot.Size = New Size(486, 397)
        picCounterPlot.TabIndex = 2
        picCounterPlot.TabStop = False
        ' 
        ' picConfusionMatrix
        ' 
        picConfusionMatrix.Location = New Point(644, 32)
        picConfusionMatrix.Name = "picConfusionMatrix"
        picConfusionMatrix.Size = New Size(486, 397)
        picConfusionMatrix.TabIndex = 3
        picConfusionMatrix.TabStop = False
        ' 
        ' ucReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(236))
        Controls.Add(picConfusionMatrix)
        Controls.Add(picCounterPlot)
        Controls.Add(btnGenerateGraph)
        Name = "ucReport"
        Size = New Size(1496, 884)
        CType(picCounterPlot, ComponentModel.ISupportInitialize).EndInit()
        CType(picConfusionMatrix, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGenerateGraph As RoundedButton
    Friend WithEvents picCounterPlot As PictureBox
    Friend WithEvents picConfusionMatrix As PictureBox

End Class
