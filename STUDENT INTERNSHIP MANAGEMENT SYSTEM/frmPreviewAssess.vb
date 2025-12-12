Imports System.Data

Public Class frmPreviewAssess
    Private _data As DataTable
    Private _filePath As String

    ' Constructor that accepts DataTable and file path
    Public Sub New(data As DataTable, filePath As String)
        InitializeComponent()

        _data = data
        _filePath = filePath

        ' Initialize DataGridView
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        ' Add a DataGridView to the form
        Dim dgv As New DataGridView With {
            .Dock = DockStyle.Fill,
            .DataSource = _data,
            .ReadOnly = True,
            .AllowUserToAddRows = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        }

        Me.Controls.Add(dgv)
    End Sub
End Class
