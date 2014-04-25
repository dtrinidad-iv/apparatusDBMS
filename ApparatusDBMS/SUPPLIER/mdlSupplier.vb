Imports System.Data.SqlClient

Module mdlSupplier

#Region "GENERATE SUPPLIER ID"
    Public Function GenerateSupplierID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateSupplierID")

        If dReader.HasRows Then
            While dReader.Read
                id = dReader.Item("newsupplierID").ToString
            End While
        End If

        Return id
    End Function
#End Region
#Region "CHECK IF SUPPLIER NAME IS ALREADY EXISTED"

    Private Function checkSupplier() As Boolean

        Dim name As String = frmAddSupplier.txName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@supplierName", name)}
        ExecuteCommand("CheckSupplier", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

#End Region

    Public Sub SupplierClearFields()
        frmAddSupplier.txName.Text = ""
        frmAddSupplier.txtContact.Text = ""
        frmAddSupplier.txtAddress.Text = ""
    End Sub

    Public Sub GetAllSupplier()
        Try
            frmSupplier.lvSupplier.Items.Clear()

            ExecuteCommand("GetAllSupplier")

            If dReader.HasRows Then
                While dReader.Read
                    frmSupplier.lvSupplier.Items.Add(dReader.Item("supplierID").ToString)
                    With frmSupplier.lvSupplier.Items(frmSupplier.lvSupplier.Items.Count - 1)
                        .SubItems.Add(dReader.Item("supplierName").ToString)
                        .SubItems.Add(dReader.Item("address").ToString)
                        .SubItems.Add(dReader.Item("contact").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub SupplierFillForm()
        With frmSupplier.lvSupplier.FocusedItem
            frmEditSupplier.txtSupplierID.Text = .SubItems(0).Text
            frmEditSupplier.txName.Text = .SubItems(1).Text.ToUpper
            frmEditSupplier.txtAddress.Text = .SubItems(2).Text.ToUpper
            frmEditSupplier.txtContact.Text = .SubItems(3).Text
        End With
    End Sub

    Public Sub AddSupplier()
        Try


            'INITIALIZE VARIABLES

            Dim code As Integer = CInt(frmAddSupplier.txtSupplierID.Text.Trim)
            Dim name As String = frmAddSupplier.txName.Text.Trim.ToUpper()
            Dim address As String = frmAddSupplier.txtAddress.Text.Trim.ToUpper()
            Dim contact As String = frmAddSupplier.txtContact.Text.Trim




            'DATA VALIDATION
            If name = "" Then
                MsgBox("SUPPLIER NAME cannot be empty!")
                frmAddSupplier.txName.Focus()
                Exit Sub
            End If
            If address = "" Then
                MsgBox("ADDRESS cannot be empty!")
                frmAddSupplier.txtAddress.Focus()
                Exit Sub
            End If
            If contact = "" Then
                MsgBox("CONTACT cannot be empty!")
                frmAddSupplier.txtContact.Focus()
                Exit Sub
            End If


            If checkSupplier() = True Then
                MsgBox("SUPPLIER NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@supplierID", code), _
                                            New SqlParameter("@supplierName", name), _
                                            New SqlParameter("@address", address), _
                                            New SqlParameter("@contact", contact)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("AddSupplier", params)

            MsgBox("Successfully added Department!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddSupplier.Close()

            'CLEAR TEXT FIELDS
            SupplierClearFields()
            'REFRESH THE BRAND LIST
            GetAllSupplier()
            'REGENERATE A NEW BRAND ID
            frmAddSupplier.txtSupplierID.Text = GenerateSupplierID()

        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateSupplier()
        Try
            'INITIALIZE VARIABLES

            Dim code As Integer = CInt(frmEditSupplier.txtSupplierID.Text.Trim)
            Dim name As String = frmEditSupplier.txName.Text.Trim.ToUpper()
            Dim address As String = frmEditSupplier.txtAddress.Text.Trim.ToUpper()
            Dim contact As String = frmEditSupplier.txtContact.Text.Trim




            'DATA VALIDATION
            If name = "" Then
                MsgBox("SUPPLIER NAME cannot be empty!")
                frmAddSupplier.txName.Focus()
                Exit Sub
            End If
            If address = "" Then
                MsgBox("ADDRESS cannot be empty!")
                frmAddSupplier.txtAddress.Focus()
                Exit Sub
            End If
            If contact = "" Then
                MsgBox("CONTACT cannot be empty!")
                frmAddSupplier.txtContact.Focus()
                Exit Sub
            End If



            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@supplierID", code), _
                                            New SqlParameter("@supplierName", name), _
                                            New SqlParameter("@address", address), _
                                            New SqlParameter("@contact", contact)}



            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateSupplier", params)

            MsgBox("Successfully Updated Supplier!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditSupplier.Close()

            'CLEAR TEXT FIELDS
            SupplierClearFields()
            'REFRESH THE BRAND LIST
            GetAllSupplier()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteSupplier()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmSupplier.lvSupplier.SelectedItems.Count = 0 Then
                MsgBox("There is no selected supplier to be deleted", _
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
                    Val(frmSupplier.lvSupplier.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@supplierID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteSupplier", params)

                'REFRESH THE LIST
                GetAllSupplier()

                'CONFIRMATION
                MsgBox("Record has been deleted!", _
                       MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("There was an error deleting the record!", _
                   MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub




End Module

