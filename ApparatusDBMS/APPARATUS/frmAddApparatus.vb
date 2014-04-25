Public Class frmAddApparatus

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmAddApparatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mdlApparatus.ClearFieldsApparatus()
        setLocation2(Me)
        FillBrandCombobox()
        FillCategoryCombobox()
        cbBrand.SelectedIndex = 0
        cbCategory.SelectedIndex = 0
        Me.Show()
        txtDescription.Focus()
        cbCategory.SelectedIndex = 1
        Dim val As Integer = CInt(cbCategory.SelectedValue)
        txtApparatusID.Text = (val * 1000) + CInt(GenerateApparatusID())

    End Sub



    Private Sub cbCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCategory.SelectionChangeCommitted
        Dim val As Integer = CInt(cbCategory.SelectedValue)
        txtApparatusID.Text = (val * 1000) + CInt(GenerateApparatusID())
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddApparatus()
    End Sub
End Class