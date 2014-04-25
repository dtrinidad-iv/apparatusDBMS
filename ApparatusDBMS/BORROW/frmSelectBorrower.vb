Public Class frmSelectBorrower

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSelectBorrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation2(Me)
        GetAllBorrowerID()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With lvBorrower.FocusedItem
            frmAddBorrow.txtBorrowerID.Text = .SubItems(0).Text
            frmAddBorrow.txtName.Text = .SubItems(1).Text
        End With
        Me.Close()
    End Sub
End Class