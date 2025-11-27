Imports MySql.Data.MySqlClient

Public Class ucStudent
    Public Sub RefreshData()
        ModuleDB.LoadData(dgvStudent, "student")
    End Sub

    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvStudent, "Student")
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim addForm As New frmAddStudent()
        ' Kunin parent form (Dashboard) at tawagin ang helper
        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(addForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadData(dgvStudent, "Student")
    End Sub

    Private Sub btnDelStudent_Click(sender As Object, e As EventArgs) Handles btnDelStudent.Click
        If dgvStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        ' Get StudentID from the selected row
        Dim studentID As String = dgvStudent.SelectedRows(0).Cells("StudentID").Value

        Dim result = MessageBox.Show("Are you sure you want to delete this student?",
                                     "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then Return

        Dim query As String = "DELETE FROM student WHERE StudentID = @id"

        Using con As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", studentID)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Record deleted successfully.")

        ' Refresh the DataGridView
        LoadData(dgvStudent, "Student")
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        If dgvStudent.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.")
            Return
        End If

        Dim studentID As String = dgvStudent.SelectedRows(0).Cells("StudentId").Value.ToString()
        Dim editForm As New frmEditStudent(studentID)

        Dim parentForm As Dashboard = Me.FindForm()
        parentForm.ShowFormWithPadding(editForm, leftPadding:=470, topPadding:=300, rightPadding:=416, bottomPadding:=269)
        LoadData(dgvStudent, "Student")
    End Sub
End Class