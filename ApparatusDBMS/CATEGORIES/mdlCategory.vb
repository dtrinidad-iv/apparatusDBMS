Imports System.Data.SqlClient

Module mdlCategory
#Region "GENERATE CAT ID"
    Public Function GenerateCategoryID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateCategoryID")

        If dReader.HasRows Then
            While dReader.Read
                id = dReader.Item("newcatID").ToString
            End While
        End If

        Return id
    End Function
#End Region
#Region "CHECK IF CATEGORY NAME IS ALREADY EXISTED"

    Private Function checkCategory() As Boolean

        Dim name As String = frmAddCategory.txtCatName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@catName", name)}
        ExecuteCommand("CheckCategory", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Function checkCategory2() As Boolean

        Dim name As String = frmEditCategory.txtCatName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@catName", name)}
        ExecuteCommand("CheckCategory", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

#End Region

    Public Sub ClearFields()
        frmAddCategory.txtCatID.Text = ""
        frmAddCategory.txtCatName.Text = ""
    End Sub

    Public Sub GetAllCategory()
        Try
            frmCategories.lvCategory.Items.Clear()

            ExecuteCommand("GetAllCategory")

            If dReader.HasRows Then
                While dReader.Read
                    frmCategories.lvCategory.Items.Add(dReader.Item("catID").ToString)
                    With frmCategories.lvCategory.Items(frmCategories.lvCategory.Items.Count - 1)
                        .SubItems.Add(dReader.Item("catName").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub CategoryFillForm()
        With frmCategories.lvCategory.FocusedItem
            frmEditCategory.txtCatID.Text = .SubItems(0).Text
            frmEditCategory.txtCatName.Text = .SubItems(1).Text.ToUpper
        End With
    End Sub

    Public Sub AddCategory()
        Try

            'INITIALIZE VARIABLES

            Dim code As Integer = CInt(frmAddCategory.txtCatID.Text.Trim)
            Dim desc As String = frmAddCategory.txtCatName.Text.Trim.ToUpper()

            'DATA VALIDATION
            If desc = "" Then
                MsgBox("DEPT NAME cannot be empty!")
                frmAddDepartment.txtDeptName.Focus()
                Exit Sub
            End If


            If checkCategory() = True Then
                MsgBox("CATEGORY NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@catID", code), _
                                            New SqlParameter("@catName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("AddCategory", params)

            MsgBox("Successfully added Apparatus Category!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddCategory.Close()

            'CLEAR TEXT FIELDS
            mdlCategory.ClearFields()
            'REFRESH THE CAT LIST
            GetAllCategory()
            'REGENERATE A NEW BRAND ID
            frmAddCategory.txtCatID.Text = GenerateCategoryID()

        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateCategory()
        Try
            'INITIALIZE VARIABLES
            Dim code As Integer = CInt(frmEditCategory.txtCatID.Text.Trim)
            Dim desc As String = frmEditCategory.txtCatName.Text.Trim

            'DATA VALIDATION
            If desc = "" Then
                MsgBox("CATEGORY NAME cannot be empty!")
                frmAddCategory.txtCatName.Focus()
                Exit Sub
            End If


            If checkCategory2() = True Then
                MsgBox("CATEGORY NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@catID", code), _
                                            New SqlParameter("@catName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateCategory", params)

            MsgBox("Successfully Updated Category!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditCategory.Close()

            'CLEAR TEXT FIELDS
            mdlCategory.ClearFields()
            'REFRESH THE BRAND LIST
            GetAllCategory()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteCategory()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmCategories.lvCategory.SelectedItems.Count = 0 Then
                MsgBox("There is no selected CATEGORY to be deleted", _
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
                    Val(frmCategories.lvCategory.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@catID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteCategory", params)

                'REFRESH THE LIST
                GetAllCategory()

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
