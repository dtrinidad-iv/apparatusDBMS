Imports System.Data.SqlClient
Module mdlBorrow
#Region "GENERATE BORROW ID"
    Public Function GenerateBorrowID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateBorrowID")

        If dReader.HasRows Then
            While dReader.Read
                id = CInt(dReader.Item("newborrowID").ToString)
            End While
        End If

        Return id
    End Function
#End Region

    Public Sub FillCombobox()
        Dim connectionString As String = Nothing
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


            frmAddItems.cbApparatus.DataSource = ds.Tables(0)
            frmAddItems.cbApparatus.DisplayMember = "description"
            frmAddItems.cbApparatus.ValueMember = "apparatusID"


        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub

    Public Sub GetAllBorrowerID()
        Try


            frmSelectBorrower.lvBorrower.Items.Clear()

            ExecuteCommand("GetAllBorrower")

            If dReader.HasRows Then
                While dReader.Read
                    frmSelectBorrower.lvBorrower.Items.Add(dReader.Item("borrowerID").ToString)
                    With frmSelectBorrower.lvBorrower.Items(frmSelectBorrower.lvBorrower.Items.Count - 1)
                        .SubItems.Add(dReader.Item("name").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING BORROWER RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub GetAllBorrow()
        Try
            frmBorrow.lvBorrow.Items.Clear()

            ExecuteCommand("GetAllBorrow")

            If dReader.HasRows Then
                While dReader.Read
                    frmBorrow.lvBorrow.Items.Add(dReader.Item("borrowID").ToString)
                    With frmBorrow.lvBorrow.Items(frmBorrow.lvBorrow.Items.Count - 1)
                        .SubItems.Add(dReader.Item("name").ToString)
                        .SubItems.Add(dReader.Item("dateBorrowed").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub GetAllAvailableApparatus()
        Try
            frmAddItems.lvApparatus.Items.Clear()



            Dim code As Integer = 0

            code = frmAddItems.cbApparatus.SelectedValue


            Dim params() As SqlParameter = _
                         {New SqlParameter("@apparatusID", code)}


            ExecuteCommand("GetAvailableApparatusInfo", True, params)

            If dReader.HasRows Then
                While dReader.Read
                    frmAddItems.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString)
                    With frmAddItems.lvApparatus.Items(frmAddItems.lvApparatus.Items.Count - 1)
                        .SubItems.Add(dReader.Item("inventoryID").ToString)
                        .SubItems.Add(dReader.Item("description").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING BORROWER RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub BorrowedInfoFillForm()
        Try
            Dim code As Integer = frmBorrow.lvBorrow.FocusedItem.SubItems(0).Text
            frmViewBorrowed.txtBorrowID.Text = frmBorrow.lvBorrow.FocusedItem.SubItems(0).Text
            frmViewBorrowed.txtBorrower.Text = frmBorrow.lvBorrow.FocusedItem.SubItems(1).Text
            frmViewBorrowed.txtDate.Text = frmBorrow.lvBorrow.FocusedItem.SubItems(2).Text
            Dim params() As SqlParameter = _
                          {New SqlParameter("@borrowID", code)}


            ExecuteCommand("GetBorrowedInfo", True, params)

            frmViewBorrowed.lvApparatus.Items.Clear()

            If dReader.HasRows Then


                While dReader.Read

                    frmViewBorrowed.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString)

                    With frmViewBorrowed.lvApparatus.Items(frmViewBorrowed.lvApparatus.Items.Count - 1)
                        .SubItems.Add(dReader.Item("inventoryID").ToString)
                        .SubItems.Add(dReader.Item("description").ToString)
                    End With




                End While
            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub ToBeReturnedInfoFillForm()
        Try
            Dim code As Integer = frmBorrow.lvBorrow.FocusedItem.SubItems(0).Text
            frmReturnBorrowed.txtBorrowID.Text = frmBorrow.lvBorrow.FocusedItem.SubItems(0).Text
            frmReturnBorrowed.txtBorrower.Text = frmBorrow.lvBorrow.FocusedItem.SubItems(1).Text
            Dim params() As SqlParameter = _
                          {New SqlParameter("@borrowID", code)}


            ExecuteCommand("GetBorrowedInfo", True, params)

            frmReturnBorrowed.lvApparatus.Items.Clear()

            If dReader.HasRows Then


                While dReader.Read

                    frmReturnBorrowed.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString)

                    With frmReturnBorrowed.lvApparatus.Items(frmReturnBorrowed.lvApparatus.Items.Count - 1)
                        .SubItems.Add(dReader.Item("inventoryID").ToString)
                        .SubItems.Add(dReader.Item("description").ToString)
                    End With




                End While
            End If

        Catch ex As Exception

        End Try


    End Sub
End Module
