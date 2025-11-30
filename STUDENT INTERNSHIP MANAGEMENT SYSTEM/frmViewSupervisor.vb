Public Class frmViewSupervisor
    Dim CompanyID As String

    Public Sub New(companyID As String)
        InitializeComponent()
        Me.CompanyID = companyID
    End Sub

    Public Property ParentDashboard As Form ' Dashboard reference
    Private Sub btnAddSupervisor_Click(sender As Object, e As EventArgs) Handles btnAddSupervisor.Click
        Dim addForm As New frmAddSupervisor(CompanyID)

        ' Kunin Dashboard via Owner property
        Dim parentForm As Dashboard = TryCast(Me.Owner, Dashboard)
        If parentForm IsNot Nothing Then
            parentForm.ShowFormWithPadding(addForm, 470, 300, 416, 269)
        Else
            ' fallback
            addForm.StartPosition = FormStartPosition.CenterScreen
            addForm.ShowDialog()
        End If

        LoadCompanyContacts(dgvSupervisor, CompanyID)
    End Sub

    Private Sub btnEditSupervisor_Click(sender As Object, e As EventArgs) Handles btnEditSupervisor.Click
        If dgvSupervisor.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.")
            Return
        End If

        Dim CompanyContactID As String = dgvSupervisor.SelectedRows(0).Cells("CompanyContactID").Value.ToString()

        Dim editForm As New frmEditSupervisor(CompanyContactID)

        ' Kunin Dashboard via Owner property
        Dim parentForm As Dashboard = TryCast(Me.Owner, Dashboard)
        If parentForm IsNot Nothing Then
            parentForm.ShowFormWithPadding(editForm, 470, 300, 416, 269)
        Else
            ' fallback
            editForm.StartPosition = FormStartPosition.CenterScreen
            editForm.ShowDialog()
        End If

        LoadCompanyContacts(dgvSupervisor, CompanyID)
    End Sub

    Private Sub btnExitSupervisor_Click(sender As Object, e As EventArgs) Handles btnExitSupervisor.Click
        Me.Close()
    End Sub

    Private Sub frmViewSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyContacts(dgvSupervisor, CompanyID)
    End Sub

    Private Sub btnDelSupervisor_Click(sender As Object, e As EventArgs) Handles btnDelSupervisor.Click
        ' Check if a row is selected
        If dgvSupervisor.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        ' Get the ID from the selected row
        Dim ccID As String = dgvSupervisor.SelectedRows(0).Cells("CompanyContactID").Value.ToString()

        ' Confirm delete
        If MessageBox.Show("Are you sure you want to delete this Company Contact?",
                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        ' Call the delete function
        DeleteCompanyContact(ccID)

        ' Refresh the datagridview after deletion
        LoadCompanyContacts(dgvSupervisor, CompanyID)
    End Sub
End Class