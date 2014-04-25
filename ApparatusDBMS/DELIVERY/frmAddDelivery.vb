Imports System.Data.SqlClient

Public Class frmAddDelivery


    Private Sub btnAddApparatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddApparatus.Click
        frmSelectApparatus.ShowDialog()
    End Sub

    Private Sub frmAddDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lvApparatus.Items.Clear()
        setLocation(Me)
        FillSupplierCombobox()
        txtDeliveryID.Text = GenerateDeliveryID()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvApparatus.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lvApparatus.SelectedItems.Count = 0 Then Exit Sub
        If lvApparatus.SelectedItems.Count = 0 Then Exit Sub


        Dim selected As Integer = lvApparatus.SelectedItems(0).Index
        lvApparatus.Items(selected).Remove()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If lvApparatus.Items.Count = 0 Then
                MsgBox("Empty delivery Item")
                Exit Sub
            End If
            Dim qty As Integer

            With lvApparatus
                For i As Short = 0 To .Items.Count - 1
                    Dim deliveryID As Integer = Val(txtDeliveryID.Text)
                    Dim supplierID As Integer = Val(cbSupplier.SelectedValue)
                    Dim apparatusID As String = .Items(i).SubItems(0).Text
                    qty = Val(.Items(i).SubItems(2).Text)
                    Dim d As Date = (dtpDate.Value.ToString)

                    Dim params() As SqlParameter = {New SqlParameter("@deliveryID", deliveryID), _
                                           New SqlParameter("@apparatusID", apparatusID), New SqlParameter("@supplierID", supplierID), New SqlParameter("@deliveryDate", d), New SqlParameter("@quantity", qty)}


                    'EXECUTE SQL COMMAND
                    ExecuteCommand("AddDelivery", params)

                Next

                
            End With


            With lvApparatus
                For i As Short = 0 To .Items.Count - 1
                    Dim apparatusID As String = .Items(i).SubItems(0).Text
                    qty = Val(.Items(i).SubItems(2).Text)
                    'ADD INVENTORY
                    For j As Short = 0 To qty - 1
                        Dim deliveryID As Integer = Val(txtDeliveryID.Text)
                        Dim params() As SqlParameter = {New SqlParameter("@apparatusID", apparatusID), _
                                                        New SqlParameter("@deliveryID", deliveryID)}

                        'EXECUTE SQL COMMAND
                        ExecuteCommand("AddInventory", params)
                    Next

                Next

            End With


            MsgBox("Successfully saved!", _
                   MsgBoxStyle.Information, "SUCCESS")

            Me.Dispose()

            GetAllDelivery()


        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub
End Class