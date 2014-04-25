Imports System.Data.SqlClient
Module mdlDepartment

#Region "GENERATE DEPT ID"
    Public Function GenerateDepartmentID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateDepartmentID")

        If dReader.HasRows Then
            While dReader.Read
                id = dReader.Item("newdeptID").ToString
            End While
        End If

        Return id
    End Function
#End Region
#Region "CHECK IF DEPARTMENT NAME IS ALREADY EXISTED"

    Private Function checkDepartment() As Boolean

        Dim name As String = frmAddDepartment.txtDeptName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@deptName", name)}
        ExecuteCommand("CheckDepartment", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Function checkDepartment2() As Boolean

        Dim name As String = frmEditDepartment.txtDeptName.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@deptName", name)}
        ExecuteCommand("CheckDepartment", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

#End Region

    Public Sub ClearFields()
        frmAddDepartment.txtDeptID.Text = ""
        frmAddDepartment.txtDeptName.Text = ""
    End Sub

    Public Sub GetAllDepartment()
        Try
            frmDepartment.lvDepartment.Items.Clear()

            ExecuteCommand("GetAllDepartment")

            If dReader.HasRows Then
                While dReader.Read
                    frmDepartment.lvDepartment.Items.Add(dReader.Item("deptID").ToString)
                    With frmDepartment.lvDepartment.Items(frmDepartment.lvDepartment.Items.Count - 1)
                        .SubItems.Add(dReader.Item("deptName").ToString)
                    End With
                End While
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub DepartmentFillForm()
        With frmDepartment.lvDepartment.FocusedItem
            frmEditDepartment.txtDeptID.Text = .SubItems(0).Text
            frmEditDepartment.txtDeptName.Text = .SubItems(1).Text.ToUpper
        End With
    End Sub

    Public Sub AddDepartment()
        Try


            'INITIALIZE VARIABLES

            Dim code As Integer = CInt(frmAddDepartment.txtDeptID.Text.Trim)
            Dim desc As String = frmAddDepartment.txtDeptName.Text.Trim.ToUpper()



            'DATA VALIDATION
            If desc = "" Then
                MsgBox("DEPT NAME cannot be empty!")
                frmAddDepartment.txtDeptName.Focus()
                Exit Sub
            End If


            If checkDepartment() = True Then
                MsgBox("DEPARTMENT NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@deptID", code), _
                                            New SqlParameter("@deptName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("AddDepartment", params)

            MsgBox("Successfully added Department!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddDepartment.Close()

            'CLEAR TEXT FIELDS
            ClearFields()
            'REFRESH THE BRAND LIST
            GetAllDepartment()
            'REGENERATE A NEW BRAND ID
            frmAddDepartment.txtDeptID.Text = GenerateDepartmentID()

        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateDepartment()
        Try
            'INITIALIZE VARIABLES
            Dim code As Integer = CInt(frmEditDepartment.txtDeptID.Text.Trim)
            Dim desc As String = frmEditDepartment.txtDeptName.Text.Trim
            
            'DATA VALIDATION
            If desc = "" Then
                MsgBox("DEPT NAME cannot be empty!")
                frmAddDepartment.txtDeptName.Focus()
                Exit Sub
            End If


            If checkDepartment2() = True Then
                MsgBox("DEPARTMENT NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@deptID", code), _
                                            New SqlParameter("@deptName", desc)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateDepartment", params)

            MsgBox("Successfully Updated Department!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditDepartment.Close()

            'CLEAR TEXT FIELDS
            ClearFields()
            'REFRESH THE BRAND LIST
            GetAllDepartment()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteDepartment()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmDepartment.lvDepartment.SelectedItems.Count = 0 Then
                MsgBox("There is no selected department to be deleted", _
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
                    Val(frmDepartment.lvDepartment.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@deptID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteDepartment", params)

                'REFRESH THE LIST
                GetAllDepartment()

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
