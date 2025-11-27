Public Class frmAddVisit
    Private Sub btnEditVisitCancel_Click(sender As Object, e As EventArgs) Handles btnAddVisitCancel.Click
        Me.Close()
    End Sub

    Private Sub btdExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAddVisit.Click
        Close
    End Sub

    Private Sub mtxtAddVisitID_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtAddVisitID.MaskInputRejected

    End Sub
End Class