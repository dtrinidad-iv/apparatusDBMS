Imports System.Data.SqlClient
Module mdlApparatus
    Dim oldID As Integer = 0

#Region "GENERATE APPARATUS ID"
    Public Function GenerateApparatusID() As String
        Dim id As Integer = 0

        ExecuteCommand("GenerateApparatusID")

        If dReader.HasRows Then
            While dReader.Read
                id = CInt(dReader.Item("newapparatusID").ToString)
            End While
        End If

        Return id
    End Function
#End Region
#Region "FILL CATEGORY ComboBox"
    Public Sub FillCategoryCombobox()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblCategory"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmAddApparatus.cbCategory.DataSource = ds.Tables(0)
            frmAddApparatus.cbCategory.DisplayMember = "catName"
            frmAddApparatus.cbCategory.ValueMember = "catID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub
    Public Sub FillCategoryCombobox2()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblCategory"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()

            frmEditApparatus.cbCategory.DataSource = ds.Tables(0)
            frmEditApparatus.cbCategory.DisplayMember = "catName"
            frmEditApparatus.cbCategory.ValueMember = "catID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")




        End Try

    End Sub

#End Region
#Region "FILL BRAND ComboBox"
    Public Sub FillBrandCombobox()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblBrand"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmAddApparatus.cbBrand.DataSource = ds.Tables(0)
            frmAddApparatus.cbBrand.DisplayMember = "brandName"
            frmAddApparatus.cbBrand.ValueMember = "brandID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try

    End Sub
    Public Sub FillBrandCombobox2()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = Nothing

        sql = "select * from tblBrand"

        Try
            mdlConnection.OpenConnection()
            command = New SqlCommand(sql, sqlConn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()


            frmEditApparatus.cbBrand.DataSource = ds.Tables(0)
            frmEditApparatus.cbBrand.DisplayMember = "brandName"
            frmEditApparatus.cbBrand.ValueMember = "brandID"

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try


    End Sub

#End Region

#Region "CHECK IF APPARATUS NAME IS ALREADY EXISTED"

    Private Function checkApparatus() As Boolean

        Dim name As String = frmAddApparatus.txtDescription.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@description", name)}
        ExecuteCommand("CheckApparatus", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Function checkApparatus2() As Boolean

        Dim name As String = frmEditApparatus.txtDescription.Text.Trim.ToUpper

        Dim params() As SqlParameter = { _
                                        New SqlParameter("@description", name)}
        ExecuteCommand("CheckApparatus", True, params)
        If dReader.HasRows Then
            Return True
            Exit Function
        End If
        Return False
    End Function

#End Region

    Public Sub ClearFieldsApparatus()
        frmAddApparatus.txtDescription.Text = ""

    End Sub

    Public Sub GetAllApparatus()
        Try
            frmApparatus.lvApparatus.Items.Clear()

            ExecuteCommand("GetAllApparatus")

            If dReader.HasRows Then
                While dReader.Read
                    frmApparatus.lvApparatus.Items.Add(dReader.Item("apparatusID").ToString)
                    With frmApparatus.lvApparatus.Items(frmApparatus.lvApparatus.Items.Count - 1)
                        .SubItems.Add(dReader.Item("description").ToString)
                        .SubItems.Add(dReader.Item("catName").ToString)
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

    Public Sub ApparatusFillForm()
        Try

            'READY THE DATA TO EDIT
            Dim apparatusID As Integer = _
                Val(frmApparatus.lvApparatus.FocusedItem.SubItems(0).Text.Trim)
            'FILL THE CATEGORY COMBOBOX
            FillCategoryCombobox()
            'FILL THE BRAND COMBOBOX
            FillBrandCombobox()

            oldID = apparatusID

            'DECLARE AN SQL PARAMETER
            Dim param() As SqlParameter = _
                    {New SqlParameter("@apparatusID", apparatusID)}
            'Open Connection
            mdlConnection.OpenConnection()


            'FILL THE FORM
            Dim sql_cmd As New SqlCommand("SelectApparatus", sqlConn)
            sql_cmd.CommandType = CommandType.StoredProcedure
            sql_cmd.Parameters.AddRange(param)
            dReader = sql_cmd.ExecuteReader




            While dReader.Read
                If dReader.HasRows Then
                    frmEditApparatus.txtApparatusID.Text = apparatusID

                    frmEditApparatus.txtApparatusID.Text = dReader.Item("apparatusID")
                    frmEditApparatus.txtDescription.Text = dReader.Item("description")


                    Dim table As DataTable = DirectCast(frmEditApparatus.cbCategory.DataSource, DataTable)
                    For i As Integer = 0 To table.Rows.Count - 1
                        Dim displayItem As String = table.Rows(i)(frmEditApparatus.cbCategory.DisplayMember).ToString()
                        Dim valueItem As String = table.Rows(i)(frmEditApparatus.cbCategory.ValueMember).ToString()

                        If valueItem = dReader.Item("catID") Then
                            ' something to do e.g.
                            frmEditApparatus.cbCategory.SelectedIndex = i
                        End If
                    Next



                    Dim table2 As DataTable = DirectCast(frmEditApparatus.cbBrand.DataSource, DataTable)
                    For i As Integer = 0 To table2.Rows.Count - 1
                        Dim displayItem As String = table2.Rows(i)(frmEditApparatus.cbBrand.DisplayMember).ToString()
                        Dim valueItem As String = table2.Rows(i)(frmEditApparatus.cbBrand.ValueMember).ToString()

                        If valueItem = dReader.Item("brandID") Then
                            ' something to do e.g.
                            frmEditApparatus.cbBrand.SelectedIndex = i
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

    Public Sub AddApparatus()
        Try


            'INITIALIZE VARIABLES

            Dim apparatusID As Integer = CInt(frmAddApparatus.txtApparatusID.Text.Trim)
            Dim desc As String = frmAddApparatus.txtDescription.Text.Trim.ToUpper()
            Dim catID As Integer = frmAddApparatus.cbCategory.SelectedValue
            Dim brandID As Integer = frmAddApparatus.cbBrand.SelectedValue

            'DATA VALIDATION

            If desc = "" Then
                MsgBox("description cannot be empty!")
                frmAddBorrower.txtName.Focus()
                Exit Sub
            End If
            If checkApparatus() = True Then
                MsgBox("APPARATUS NAME ALREADY EXISTED", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@apparatusID", apparatusID), _
                                            New SqlParameter("@description", desc), _
                                            New SqlParameter("@catID", catID), _
                                            New SqlParameter("@brandID", brandID)}



            'EXECUTE SQL COMMAND
            ExecuteCommand("AddApparatus", params)

            MsgBox("Successfully added a Borrower!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmAddApparatus.Close()
            'CLEAR TEXT FIELDS
            ClearFieldsApparatus()
            'REFRESH THE BORROWER LIST
            GetAllApparatus()



        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Public Sub UpdateApparatus()
        Try
            'INITIALIZE VARIABLES

            Dim apparatusID As Integer = CInt(frmEditApparatus.txtApparatusID.Text.Trim)
            Dim desc As String = frmEditApparatus.txtDescription.Text.Trim.ToUpper()
            Dim catID As Integer = frmEditApparatus.cbCategory.SelectedValue
            Dim brandID As Integer = frmEditApparatus.cbBrand.SelectedValue





            'DATA VALIDATION
            If desc = "" Then
                MsgBox("description cannot be empty!")
                frmAddBorrower.txtName.Focus()
                Exit Sub
            End If

            'INSTANTIATE AN SQL PARAMATER
            Dim params() As SqlParameter = {New SqlParameter("@apparatusID", apparatusID), _
                                            New SqlParameter("@oldID", oldID), _
                                            New SqlParameter("@description", desc), _
                                            New SqlParameter("@catID", catID), _
                                            New SqlParameter("@brandID", brandID)}


            'EXECUTE SQL COMMAND
            ExecuteCommand("UpdateApparatus", params)

            MsgBox("Successfully Updated a Apparatus!", _
                   MsgBoxStyle.Information, "SUCCESS")
            frmEditApparatus.Close()

            'CLEAR TEXT FIELDS
            mdlApparatus.ClearFieldsApparatus()
            'REFRESH THE BRAND LIST
            GetAllApparatus()
        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in modifying a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

        End Try
    End Sub

    Public Sub DeleteApparatus()
        Try
            'ENSURES THAT AN ITEM IS SELECTED

            If frmApparatus.lvApparatus.SelectedItems.Count = 0 Then
                MsgBox("There is no selected APPARATUS to be deleted", _
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
                    Val(frmApparatus.lvApparatus.FocusedItem.SubItems(0).Text.Trim)

                'DECLARE AN SQL PARAMETER
                Dim params() As SqlParameter = _
                        {New SqlParameter("@apparatusID", ID)}

                'EXECUTE COMMAND
                ExecuteCommand("DeleteApparatus", params)

                'REFRESH THE LIST
                GetAllApparatus()

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
