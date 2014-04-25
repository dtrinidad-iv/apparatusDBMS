Public Class frmSupplier
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        rbID.Checked = True
        GetAllSupplier()
        lvSupplier.Columns(1).Width = 270
        lvSupplier.Columns(2).Width = 180
        lvSupplier.Columns(3).Width = 140

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If lvSupplier.SelectedItems.Count = 0 Then
            MsgBox("There is no selected Supplier to be edit", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If
        frmEditSupplier.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddSupplier.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteSupplier()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class