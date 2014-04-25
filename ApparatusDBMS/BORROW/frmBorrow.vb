Public Class frmBorrow
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        GetAllBorrow()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        frmAddBorrow.ShowDialog()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If lvBorrow.SelectedItems.Count = 0 Then
            MsgBox("There is no selected TRANSACTION to be view", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If

        frmViewBorrowed.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        If lvBorrow.SelectedItems.Count = 0 Then
            MsgBox("There is no selected TRANSACTION to be Returned", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If

        frmReturnBorrowed.ShowDialog()
    End Sub
End Class