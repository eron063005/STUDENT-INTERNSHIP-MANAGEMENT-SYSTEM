Public Class ucAssessment
    Private Sub btnAddAssessment_Click(sender As Object, e As EventArgs) Handles btnAddAssessment.Click
        Dim addForm As New frmAddAssessment()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub

    Private Sub btnEditAssessment_Click(sender As Object, e As EventArgs) Handles btnEditAssessment.Click
        Dim addForm As New frmEditAssessment
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = FindForm
        parentForm.ShowFormWithPadding(addForm, leftPadding:=500, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
End Class
