Imports System.Data.SqlClient
Public Class frmReturnBorrowed

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReturnBorrowed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        ToBeReturnedInfoFillForm()
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        If MsgBox("Are you sure to RETURN THIS RECORD?", _
                     MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                     "CONFIRMATION") = MsgBoxResult.Yes Then


            Try
                'INITIALIZE VARIABLES
                Dim code As Integer = CInt(txtBorrowID.Text.Trim)
                Dim dateReturned As DateTime = dtpDate.Value


                'DATA VALIDATION
                'If desc = "" Then
                '    MsgBox("DEPT NAME cannot be empty!")
                '    frmAddDepartment.txtDeptName.Focus()
                '    Exit Sub
                'End If
                'INSTANTIATE AN SQL PARAMATER

                With lvApparatus
                    For i As Short = 0 To .Items.Count - 1
                        Dim apparatusID As Integer = Val(.Items(i).SubItems(0).Text)
                        Dim inventoryID As Integer = Val(.Items(i).SubItems(1).Text)


                        Dim params() As SqlParameter = {New SqlParameter("@dateReturned", dateReturned), _
                                                        New SqlParameter("@apparatusID", apparatusID), _
                                                        New SqlParameter("@inventoryID", inventoryID)}


                        'EXECUTE SQL COMMAND
                        ExecuteCommand("UpdateBorrowAndInventory", params)

                    Next


                End With



                MsgBox("Successfully Returned Apparatus!", _
                       MsgBoxStyle.Information, "SUCCESS")
                Me.Close()

                'REFRESH THE BRAND LIST
                mdlBorrow.GetAllBorrow()


            Catch ex As Exception
                Dim msg As String

                msg = "ERROR#" & Err.Number.ToString & _
                " There was an error in modifying a record. " & _
                   ex.Message

                MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")

            End Try
        End If
    End Sub

End Class