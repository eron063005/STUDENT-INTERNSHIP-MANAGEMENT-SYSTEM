Public Class ucReport
    Private Sub btnGenerateGraph_Click(sender As Object, e As EventArgs) Handles btnGenerateGraph.Click
        RunPythonScript()
        picCounterPlot.Image = Image.FromFile("C:\Users\HP\Desktop\VScode\Final Case Study OJT\countplot.png")
        picConfusionMatrix.Image = Image.FromFile("C:\Users\HP\Desktop\VScode\Final Case Study OJT\confusion_matrix.png")
    End Sub
End Class
