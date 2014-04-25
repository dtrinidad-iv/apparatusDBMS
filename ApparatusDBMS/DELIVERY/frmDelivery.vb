Imports System.Data.SqlClient

Public Class frmDelivery
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddDelivery.ShowDialog()
    End Sub

    Private Sub frmDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        GetAllDelivery()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If lvDelivery.SelectedItems.Count = 0 Then
            MsgBox("There is no selected DELIVER to be view", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If

        frmViewDelivery.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If lvDelivery.SelectedItems.Count = 0 Then
                MsgBox("There is no selected delivery to be deleted", _
                       MsgBoxStyle.Exclamation, _
                       "")
                Exit Sub
            End If
            'ASK THE USER TO CONFIRM DELETION
            If MsgBox("Are you sure to delete this record?", _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                      "CONFIRMATION") = MsgBoxResult.Yes Then

                'READY THE DATA FOR DELETION
                Dim ID As Integer = _
                    Val(lvDelivery.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@deliveryID", ID)}
                'DECLARE AN SQL PARAMETER
                Dim params2() As SqlParameter = _
                        {New SqlParameter("@deliveryID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteDelivery", params)
                ExecuteCommand("DeleteInventory", params2)


                'REFRESH THE LIST
                GetAllDelivery()

                'CONFIRMATION
                MsgBox("Record has been deleted!", _
                       MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("There was an error deleting the record!", _
                   MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class