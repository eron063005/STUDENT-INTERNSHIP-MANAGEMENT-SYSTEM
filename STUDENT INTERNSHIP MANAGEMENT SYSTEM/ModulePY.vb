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

        Dim process As Process = Process.Start(psi)

        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim errors As String = process.StandardError.ReadToEnd()
        process.WaitForExit()

        Console.WriteLine("Python Output:")
        Console.WriteLine(output)

        If Not String.IsNullOrEmpty(errors) Then
            Console.WriteLine("Python Errors:")
            Console.WriteLine(errors)
        End If

        ' Paths to saved images
        Dim countplotPath As String = "C:\Users\HP\Desktop\VScode\Final Case Study OJT\countplot.png"
        Dim confusionMatrixPath As String = "C:\Users\HP\Desktop\VScode\Final Case Study OJT\confusion_matrix.png"

        ' Example: display images in Windows Forms PictureBox
        ' Dim pbCountplot As New PictureBox()
        ' pbCountplot.Image = Image.FromFile(countplotPath)
        ' Dim pbConfusion As New PictureBox()
        ' pbConfusion.Image = Image.FromFile(confusionMatrixPath)

        Console.WriteLine("Plots saved successfully.")
        'Console.ReadKey()
    End Sub
End Module
