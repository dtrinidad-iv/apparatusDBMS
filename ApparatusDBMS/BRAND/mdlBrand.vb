Imports System.Data.SqlClient

Module mdlBrand
#Region "GENERATE BRAND ID"
    Public Function GenerateBrandID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateBrandID")

        If dReader.HasRows Then
            While dReader.Read
                id = dReader.Item("newbrandID").ToString
            End While
        End If

        Return id
    End Function
#End Region
#Region "CHECK IF BRAND NAME IS ALREADY EXISTED"

    Private Function checkBrand() As Boolean

        Dim name As String = frmAddBrand.txtBrandName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@brandName", name)}
        ExecuteCommand("CheckBrand", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Function checkBrand2() As Boolean

        Dim name As String = frmEditBrand.txtBrandName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@brandName", name)}
        ExecuteCommand("CheckBrand", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

#End Region

    Public Sub ClearFields()
        frmAddBrand.txtBrandID.Text = ""
        frmAddBrand.txtBrandName.Text = ""
    End Sub

    Public Sub GetAllBrand()
        Try
            frmBrand.lvBrand.Items.Clear()

            ExecuteCommand("GetAllBrand")

            If dReader.HasRows Then
                While dReader.Read
                    frmBrand.lvBrand.Items.Add(dReader.Item("brandID").ToString)
                    With frmBrand.lvBrand.Items(frmBrand.lvBrand.Items.Count - 1)
                        .SubItems.Add(dReader.Item("brandName").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub BrandFillForm()
        With frmBrand.lvBrand.FocusedItem
            frmEditBrand.txtBrandID.Text = .SubItems(0).Text
            frmEditBrand.txtBrandName.Text = .SubItems(1).Text.ToUpper
        End With
    End Sub

    Public Sub AddBrand()
        Try

            'INITIALIZE VARIABLES

            Dim code As Integer = CInt(frmAddBrand.txtBrandID.Text.Trim)
            Dim desc As String = frmAddBrand.txtBrandName.Text.Trim.ToUpper()

            'DATA VALIDATION
            If desc = "" Then
                MsgBox("BRAND NAME cannot be empty!")
                frmAddDepartment.txtDeptName.Focus()
                Exit Sub
            End If


            If checkBrand() = True Then
                MsgBox("BRAND NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@brandID", code), _
                                            New SqlParameter("@brandName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("AddBrand", params)

            MsgBox("Successfully added Apparatus Category!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddBrand.Close()

            'CLEAR TEXT FIELDS
            mdlBrand.ClearFields()
            'REFRESH THE CAT LIST
            GetAllBrand()
            'REGENERATE A NEW BRAND ID
            frmAddBrand.txtBrandID.Text = GenerateBrandID()

        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateBrand()
        Try
            'INITIALIZE VARIABLES
            Dim code As Integer = CInt(frmEditBrand.txtBrandID.Text.Trim)
            Dim desc As String = frmEditBrand.txtBrandName.Text.Trim

            'DATA VALIDATION
            If desc = "" Then
                MsgBox("BRAND NAME cannot be empty!")
                frmAddBrand.txtBrandName.Focus()
                Exit Sub
            End If


            If checkBrand2() = True Then
                MsgBox("CATEGORY NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@brandID", code), _
                                            New SqlParameter("@brandName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateBrand", params)

            MsgBox("Successfully Updated Category!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditBrand.Close()

            'CLEAR TEXT FIELDS
            mdlBrand.ClearFields()
            'REFRESH THE BRAND LIST
            GetAllBrand()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteBrand()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmBrand.lvBrand.SelectedItems.Count = 0 Then
                MsgBox("There is no selected BRAND to be deleted", _
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
                    Val(frmBrand.lvBrand.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@brandID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteBrand", params)

                'REFRESH THE LIST
                GetAllBrand()

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
