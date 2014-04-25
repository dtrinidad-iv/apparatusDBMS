Imports System.Data.SqlClient

Public Class frmAddItems

    Private Sub newBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation2(Me)
        lvApparatus.SelectedItems.Clear()

        mdlBorrow.FillCombobox()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        mdlBorrow.GetAllAvailableApparatus()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
  Dim found = False
        If lvApparatus.SelectedItems.Count = 0 Then
            MsgBox("There is no selected APPARATUS", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If

        With lvApparatus.FocusedItem
            frmAddBorrow.txtID.Text = .SubItems(0).Text
            frmAddBorrow.txtID2.Text = .SubItems(1).Text
            frmAddBorrow.txtApp.Text = .SubItems(2).Text
        End With

        For Each item As ListViewItem In frmAddBorrow.lvApparatus.Items


            If item.SubItems(1).Text = frmAddBorrow.txtID2.Text And item.Text = frmAddBorrow.txtID.Text Then

                MsgBox("APPARATUS ALREADY EXISTED IN THE LIST VIEW")
                found = True
                Exit For


                '
            End If
        Next

        If found = False Then



            frmAddBorrow.lvApparatus.Items.Add(frmAddBorrow.txtID.Text.ToString)
            With frmAddBorrow.lvApparatus.Items(frmAddBorrow.lvApparatus.Items.Count - 1)
                .SubItems.Add(frmAddBorrow.txtID2.Text.ToString)
                .SubItems.Add(frmAddBorrow.txtApp.Text.ToString)
            End With
        End If





       

        Me.Close()

    End Sub
End Class