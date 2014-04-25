Public Class frmEditApparatus

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmEditApparatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation2(Me)
        FillCategoryCombobox2()
        FillBrandCombobox2()
        ApparatusFillForm()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UpdateApparatus()
    End Sub


    Private Sub cbCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCategory.SelectionChangeCommitted
        Dim val As Integer = CInt(cbCategory.SelectedValue)
        txtApparatusID.Text = (val * 1000) + CInt(GenerateApparatusID()) - 1
    End Sub
End Class