Public Class ucReport
    Private Sub btnGenerateGraph_Click(sender As Object, e As EventArgs) Handles btnGenerateGraph.Click
        RunPythonScript()
        'picCounterPlot.Image = Image.FromFile("resources\countplot.png")
        'picConfusionMatrix.Image = Image.FromFile("resources\confusion_matrix.png")
    End Sub
End Class
