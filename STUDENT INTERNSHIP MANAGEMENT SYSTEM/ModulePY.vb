Imports System.Diagnostics

Module ModulePY
    Sub RunPythonScript(filePath As String)
        'Dim pythonExe As String = "C:\Users\User\AppData\Local\Programs\Python\Python313\python.exe"
        'Dim scriptPath As String = "C:\Users\User\Documents\VBNET\STUDENT INTERNSHIP MANAGEMENT SYSTEM\Resources\Final Case Study Platech.py"
        Dim pythonExe As String = "C:\Users\HP\AppData\Local\Microsoft\WindowsApps\python3.13.exe"
        Dim scriptPath As String = "C:\Users\HP\source\repos\eron063005\STUDENT-INTERNSHIP-MANAGEMENT-SYSTEM\STUDENT INTERNSHIP MANAGEMENT SYSTEM\Resources\Final_Case_Study_Platech.py"


        Dim psi As New ProcessStartInfo()
        psi.FileName = pythonExe
        ' Pass the filePath as argument
        psi.Arguments = $"""{scriptPath}"" ""{filePath}"""
        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        psi.RedirectStandardError = True
        psi.CreateNoWindow = True

        Dim process As Process = Process.Start(psi)

        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim errors As String = process.StandardError.ReadToEnd()
        process.WaitForExit()

        ' Optional: show Python output/errors
        Console.WriteLine(output)
        If Not String.IsNullOrEmpty(errors) Then Console.WriteLine(errors)
    End Sub
End Module
