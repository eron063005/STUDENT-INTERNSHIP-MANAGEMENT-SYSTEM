Imports Microsoft.Web.WebView2.Core

Public Class ucReport
    Private Sub btnGenerateGraph_Click(sender As Object, e As EventArgs)
        RunPythonScript()
        'picCounterPlot.Image = Image.FromFile("resources\countplot.png")
        'picConfusionMatrix.Image = Image.FromFile("resources\confusion_matrix.png")
    End Sub

    Private Async Sub btnViewCountPlot_Click(sender As Object, e As EventArgs) Handles btnViewCountPlot.Click
        Dim htmlPath As String = "C:\Users\User\Downloads\cluster-main\index.html"
        If Not IO.File.Exists(htmlPath) Then Return
        Await WebView21Report.EnsureCoreWebView2Async()
        WebView21Report.CoreWebView2.Navigate(New Uri(htmlPath).AbsoluteUri)
    End Sub

    Private Async Sub btnViewConfuseMatriz_Click(sender As Object, e As EventArgs) Handles btnViewConfuseMatriz.Click
        Dim htmlPath As String = "C:\Users\User\Downloads\cluster-main\index - Copy.html"
        If Not IO.File.Exists(htmlPath) Then Return
        Await WebView22Report.EnsureCoreWebView2Async()
        WebView22Report.CoreWebView2.Navigate(New Uri(htmlPath).AbsoluteUri)
    End Sub
End Class

