

Public Class frmSelectApparatus

#Region "KEYPRESS"
    Private Sub _KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        numOnly(e)
    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSelectApparatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillApparatusCombobox()
        txtQty.Text = ""
        Me.Show()
        txtQty.Focus()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtQty.Text.Length = 0 Then
            MsgBox("Invalid Quantity!", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If
        Dim found = False

        For Each item As ListViewItem In frmAddDelivery.lvApparatus.Items

            If item.Text = cbApparatus.SelectedValue Then
                MsgBox("APPARATUS ALREADY EXISTED IN THE LIST VIEW")
                found = True
                Exit For
                '
            End If
        Next

        If found = False Then


            frmAddDelivery.lvApparatus.Items.Add(cbApparatus.SelectedValue.ToString)
            With frmAddDelivery.lvApparatus.Items(frmAddDelivery.lvApparatus.Items.Count - 1)
                .SubItems.Add(cbApparatus.Text)
                .SubItems.Add(txtQty.Text)
            End With
        End If




        Me.Close()
    End Sub
End Class