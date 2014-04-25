Public Class frmAddBorrower

#Region "KEYPRESS"
    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        numOnly(e)
    End Sub
    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        keyCheck(e)
    End Sub

#End Region


    Private Sub frmAddBorrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdlBorrower.ClearFields()
        setLocation2(Me)
        cbGender.SelectedIndex = 0
        cbPosition.SelectedIndex = 0
        Me.Show()
        txtName.Focus()
        mdlBorrower.FillCombobox()
        txtBorrowerID.Text = GenerateBorrowerID()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddBorrower()
    End Sub
End Class