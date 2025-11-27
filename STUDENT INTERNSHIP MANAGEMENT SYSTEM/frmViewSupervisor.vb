Public Class frmViewSupervisor
    Public Property ParentDashboard As Form ' Dashboard reference
    Private Sub btnAddSupervisor_Click(sender As Object, e As EventArgs) Handles btnAddSupervisor.Click
        Dim addForm As New frmAddSupervisor()

        ' Kunin Dashboard via Owner property
        Dim parentForm As Dashboard = TryCast(Me.Owner, Dashboard)
        If parentForm IsNot Nothing Then
            parentForm.ShowFormWithPadding(addForm, 470, 300, 416, 269)
        Else
            ' fallback
            addForm.StartPosition = FormStartPosition.CenterScreen
            addForm.ShowDialog()
        End If
    End Sub

    Private Sub btnEditSupervisor_Click(sender As Object, e As EventArgs) Handles btnEditSupervisor.Click
        Dim addForm As New frmEditSupervisor()

        ' Kunin Dashboard via Owner property
        Dim parentForm As Dashboard = TryCast(Me.Owner, Dashboard)
        If parentForm IsNot Nothing Then
            parentForm.ShowFormWithPadding(addForm, 470, 300, 416, 269)
        Else
            ' fallback
            addForm.StartPosition = FormStartPosition.CenterScreen
            addForm.ShowDialog()
        End If
    End Sub

    Private Sub btnExitSupervisor_Click(sender As Object, e As EventArgs) Handles btnExitSupervisor.Click
        Me.Close()
    End Sub
End Class