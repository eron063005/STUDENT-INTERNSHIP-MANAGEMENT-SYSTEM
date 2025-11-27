Public Class ucVisit
    Private Sub btnAddVisit_Click(sender As Object, e As EventArgs) Handles btnAddVisit.Click
        Dim addForm As New frmAddVisit()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub

    Private Sub btnEditVisit_Click(sender As Object, e As EventArgs) Handles btnEditVisit.Click
        Dim addForm As New frmEditVisit()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
    End Sub
    Private Sub ucVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVisitCards(panelVisit)
    End Sub
    'burat
End Class
