Imports System.Data.SqlClient
Module mdlInventory

    Public Sub AvailableApparatusInfoFillForm()
        Try
            Dim code As Integer = frmInventory.lvInventory.FocusedItem.SubItems(0).Text
            Dim name As String = frmInventory.lvInventory.FocusedItem.SubItems(1).Text
            frmViewAvailableApparatus.txtApparatus.Text = frmInventory.lvInventory.FocusedItem.SubItems(1).Text

            Dim params() As SqlParameter = _
                          {New SqlParameter("@apparatusID", code)}


            ExecuteCommand("GetAvailableApparatusInfo", True, params)

            frmViewAvailableApparatus.lvApparatus.Items.Clear()

            If dReader.HasRows Then


                While dReader.Read

                    frmViewAvailableApparatus.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString + "-" + dReader.Item("inventoryID").ToString)

                    With frmViewAvailableApparatus.lvApparatus.Items(frmViewAvailableApparatus.lvApparatus.Items.Count - 1)
                        .SubItems.Add(name)
                    End With




                End While
            End If

        Catch ex As Exception

        End Try


    End Sub


End Module
