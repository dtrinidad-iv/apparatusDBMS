Public Class frmEditSupplier
#Region "KEYPRESS"
    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        numOnly(e)
    End Sub
#End Region
    Private Sub frmEditSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        setLocation2(Me)
        SupplierFillForm()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UpdateSupplier()
    End Sub
End Class