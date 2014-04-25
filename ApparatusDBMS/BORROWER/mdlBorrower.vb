Imports System.Data.SqlClient
Module mdlBorrower
#Region "GENERATE BORROWER ID"
    Public Function GenerateBorrowerID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateBorrowerID")

        If dReader.HasRows Then
            While dReader.Read
                id = CInt(dReader.Item("newborrowerID").ToString)
            End While
        End If

        Return id
    End Function
#End Region
#Region "FILL DEPARTMENT ComboBox"
    Public Sub FillCombobox()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblDepartment"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmAddBorrower.cbDepartment.DataSource = ds.Tables(0)
            frmAddBorrower.cbDepartment.DisplayMember = "deptName"
            frmAddBorrower.cbDepartment.ValueMember = "deptID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub
    Public Sub FillCombobox2()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblDepartment"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()

            frmEditBorrower.cbDepartment.DataSource = ds.Tables(0)
            frmEditBorrower.cbDepartment.DisplayMember = "deptName"
            frmEditBorrower.cbDepartment.ValueMember = "deptID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")




        End Try

    End Sub

#End Region

    Public Sub ClearFields()
        frmAddBorrower.txtAddress.Text = ""
        frmAddBorrower.txtContact.Text = ""
        frmAddBorrower.txtEmail.Text = ""
        frmAddBorrower.txtName.Text = ""
    End Sub

    Public Sub GetAllBorrower()
        Try
            frmBorrower.lvBorrower.Items.Clear()

            ExecuteCommand("GetAllBorrower")

            If dReader.HasRows Then
                While dReader.Read
                    frmBorrower.lvBorrower.Items.Add(dReader.Item("borrowerID").ToString)
                    With frmBorrower.lvBorrower.Items(frmBorrower.lvBorrower.Items.Count - 1)
                        .SubItems.Add(dReader.Item("name").ToString)
                        .SubItems.Add(dReader.Item("gender").ToString)
                        .SubItems.Add(dReader.Item("position").ToString)
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

    Public Sub BorrowerFillForm()
        Try

            'READY THE DATA TO EDIT
            Dim borrowerID As Integer = _
                Val(frmBorrower.lvBorrower.FocusedItem.SubItems(0).Text.Trim)
            'FILL THE POSITION COMBOBOX
            FillCombobox()

            'DECLARE AN SQL PARAMETER
            Dim param() As SqlParameter = _
                    {New SqlParameter("@borrowerID", borrowerID)}
            'Open Connection
            mdlConnection.OpenConnection()


            'FILL THE FORM
            Dim sql_cmd As New SqlCommand("SelectBorrower", sqlConn)
            sql_cmd.CommandType = CommandType.StoredProcedure
            sql_cmd.Parameters.AddRange(param)
            dReader = sql_cmd.ExecuteReader




            While dReader.Read
                If dReader.HasRows Then
                    frmEditBorrower.txtBorrowerID.Text = borrowerID


                    If dReader.Item("gender") = "M" Then
                        frmEditBorrower.cbGender.SelectedIndex = 0
                    Else
                        frmEditBorrower.cbGender.SelectedIndex = 1
                    End If

                    If dReader.Item("position") = "TEACHER" Then
                        frmEditBorrower.cbPosition.SelectedIndex = 0
                    Else
                        frmEditBorrower.cbPosition.SelectedIndex = 1
                    End If

                    frmEditBorrower.txtName.Text = dReader.Item("name")
                    frmEditBorrower.txtAddress.Text = dReader.Item("address")
                    frmEditBorrower.txtContact.Text = dReader.Item("contactNo")
                    frmEditBorrower.txtEmail.Text = dReader.Item("email")

                    Dim table As DataTable = DirectCast(frmEditBorrower.cbDepartment.DataSource, DataTable)
                    For i As Integer = 0 To table.Rows.Count - 1
                        Dim displayItem As String = table.Rows(i)(frmEditBorrower.cbDepartment.DisplayMember).ToString()
                        Dim valueItem As String = table.Rows(i)(frmEditBorrower.cbDepartment.ValueMember).ToString()

                        If valueItem = dReader.Item("deptID") Then
                            ' something to do e.g.
                            frmEditBorrower.cbDepartment.SelectedIndex = i
                        End If
                    Next

                End If
            End While




            'CLOSE dReader and DB CONNECTION
            dReader.Close()



        Catch ex As Exception
            MsgBox("ERROR" + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub AddBorrower()
        Try


            'INITIALIZE VARIABLES

            Dim borrowerID As Integer = CInt(frmAddBorrower.txtBorrowerID.Text.Trim)
            Dim name As String = frmAddBorrower.txtName.Text.Trim.ToUpper()

            Dim gender As String = frmAddBorrower.cbGender.Text.Substring(0, 1)
            Dim position As String = frmAddBorrower.cbPosition.Text
            Dim deptID As Integer = frmAddBorrower.cbDepartment.SelectedValue
            Dim address As String = frmAddBorrower.txtAddress.Text.Trim.ToUpper()
            Dim contact As String = frmAddBorrower.txtContact.Text.Trim.ToUpper()
            Dim email As String = frmAddBorrower.txtEmail.Text.Trim.ToUpper()



            'DATA VALIDATION

            If name = "" Then
                MsgBox("Name cannot be empty!")
                frmAddBorrower.txtName.Focus()
                Exit Sub
            End If
            If address = "" Then
                MsgBox("Address cannot be empty!")
                frmAddBorrower.txtAddress.Focus()
                Exit Sub
            End If


            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@borrowerID", borrowerID), _
                                            New SqlParameter("@gender", gender), _
                                            New SqlParameter("@name", name), _
                                            New SqlParameter("@address", address), _
                                            New SqlParameter("@position", position), _
                                            New SqlParameter("@deptID", deptID), _
                                            New SqlParameter("@contactNo", contact), _
                                            New SqlParameter("@email", email)}



            'EXECUTE SQL COMMAND
            ExecuteCommand("AddBorrower", params)

            MsgBox("Successfully added a Borrower!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddBorrower.Close()
            'CLEAR TEXT FIELDS
            ClearFields()
            'REFRESH THE BORROWER LIST
            GetAllBorrower()
            'REGENERATE A NEW BRAND ID
            frmAddBorrower.txtBorrowerID.Text = GenerateBorrowerID()

        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateBorrower()
        Try
            'INITIALIZE VARIABLES
            Dim borrowerID As Integer = CInt(frmEditBorrower.txtBorrowerID.Text.Trim)
            Dim name As String = frmEditBorrower.txtName.Text.Trim.ToUpper()
            Dim gender As String = frmEditBorrower.cbGender.Text.Substring(0, 1)
            Dim position As String = frmEditBorrower.cbPosition.Text
            Dim deptID As Integer = frmEditBorrower.cbDepartment.SelectedValue
            Dim address As String = frmEditBorrower.txtAddress.Text.Trim.ToUpper()
            Dim contact As String = frmEditBorrower.txtContact.Text.Trim.ToUpper()
            Dim email As String = frmEditBorrower.txtEmail.Text.Trim.ToUpper()



            'DATA VALIDATION

            If name = "" Then
                MsgBox("Name cannot be empty!")
                frmAddBorrower.txtName.Focus()
                Exit Sub
            End If
            If address = "" Then
                MsgBox("Address cannot be empty!")
                frmAddBorrower.txtAddress.Focus()
                Exit Sub
            End If


            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@borrowerID", borrowerID), _
                                            New SqlParameter("@gender", gender), _
                                            New SqlParameter("@name", name), _
                                            New SqlParameter("@address", address), _
                                            New SqlParameter("@position", position), _
                                            New SqlParameter("@deptID", deptID), _
                                            New SqlParameter("@contactNo", contact), _
                                            New SqlParameter("@email", email)}

            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateBorrower", params)

            MsgBox("Successfully Updated a Borrower!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditBorrower.Close()

            'CLEAR TEXT FIELDS
            mdlBorrower.ClearFields()
            'REFRESH THE BRAND LIST
            GetAllBorrower()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteBorrower()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmBorrower.lvBorrower.SelectedItems.Count = 0 Then
                MsgBox("There is no selected BORROWER to be deleted", _
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
                    Val(frmBorrower.lvBorrower.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@borrowerID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteBorrower", params)

                'REFRESH THE LIST
                GetAllBorrower()

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
