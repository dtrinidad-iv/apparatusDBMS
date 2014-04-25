Imports System.Data.SqlClient
Module mdlDelivery

#Region "GENERATE DELIVERY ID"
    Public Function GenerateDeliveryID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateDeliveryID")

        If dReader.HasRows Then
            While dReader.Read
                id = CInt(dReader.Item("newdeliveryID").ToString)
            End While
        End If

        Return id
    End Function
#End Region

#Region "FILL SUPPLIER ComboBox"
    Public Sub FillSupplierCombobox()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblSupplier"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmAddDelivery.cbSupplier.DataSource = ds.Tables(0)
            frmAddDelivery.cbSupplier.DisplayMember = "supplierName"
            frmAddDelivery.cbSupplier.ValueMember = "supplierID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub

    Public Sub FillApparatusCombobox()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblApparatus"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmSelectApparatus.cbApparatus.DataSource = ds.Tables(0)
            frmSelectApparatus.cbApparatus.DisplayMember = "description"
            frmSelectApparatus.cbApparatus.ValueMember = "apparatusID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub


#End Region

    Public Sub GetAllDelivery()
        Try
            frmDelivery.lvDelivery.Items.Clear()

            ExecuteCommand("GetAllDelivery")

            If dReader.HasRows Then
                While dReader.Read
                    frmDelivery.lvDelivery.Items.Add(dReader.Item("deliveryID").ToString)
                    With frmDelivery.lvDelivery.Items(frmDelivery.lvDelivery.Items.Count - 1)
                        .SubItems.Add(dReader.Item("supplierName").ToString)
                        .SubItems.Add(dReader.Item("deliveryDate").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Public Sub DeliveryInfoFillForm()
        Try
            Dim code As Integer = frmDelivery.lvDelivery.FocusedItem.SubItems(0).Text
            frmViewDelivery.txtDeliveryID.Text = frmDelivery.lvDelivery.FocusedItem.SubItems(0).Text
            frmViewDelivery.txtDate.Text = frmDelivery.lvDelivery.FocusedItem.SubItems(2).Text
            frmViewDelivery.txtSupplier.Text = frmDelivery.lvDelivery.FocusedItem.SubItems(1).Text
            Dim params() As SqlParameter = _
                          {New SqlParameter("@deliveryID", code)}


            ExecuteCommand("GetDeliveryInfo", True, params)

            frmViewDelivery.lvApparatus.Items.Clear()

            If dReader.HasRows Then


                While dReader.Read
                    
                    frmViewDelivery.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString)

                    With frmViewDelivery.lvApparatus.Items(frmViewDelivery.lvApparatus.Items.Count - 1)
                        .SubItems.Add(dReader.Item("description").ToString)
                        .SubItems.Add(dReader.Item("quantity").ToString)
                    End With




                End While
            End If

        Catch ex As Exception

        End Try


    End Sub



End Module
