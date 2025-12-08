Imports System.Diagnostics

Module ModulePY
    Sub RunPythonScript()
        Dim pythonExe As String = "C:\Users\User\AppData\Local\Programs\Python\Python313\python.exe"
        Dim scriptPath As String = "C:\Users\User\Documents\VBNET\STUDENT INTERNSHIP MANAGEMENT SYSTEM\STUDENT INTERNSHIP MANAGEMENT SYSTEM\Resources\Final Case Study Platech.py"

        Dim psi As New ProcessStartInfo()
        psi.FileName = pythonExe
        psi.Arguments = $"""{scriptPath}"""
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        psi.RedirectStandardError = True
        psi.CreateNoWindow = True

        Dim process As Process = process.Start(psi)

        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim errors As String = process.StandardError.ReadToEnd()
        process.WaitForExit()

        ' Optional: print Python output
        Console.WriteLine(output)
        If Not String.IsNullOrEmpty(errors) Then Console.WriteLine(errors)

        ' Load saved images into PictureBoxes (WinForms)
        Dim countplotPath As String = "Resources\countplot.png"
        Dim confusionMatrixPath As String = "Resources\confusion_matrix.png"

        ' Example: in your Form you can have PictureBox1 and PictureBox2
        ' PictureBox1.Image = Image.FromFile(countplotPath)
        ' PictureBox2.Image = Image.FromFile(confusionMatrixPath)
    End Sub
End Module
