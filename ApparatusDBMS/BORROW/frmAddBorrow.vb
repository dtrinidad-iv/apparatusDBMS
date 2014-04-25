Imports System.Data.SqlClient
Public Class frmAddBorrow

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmAddBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        setLocation(Me)
        lvApparatus.Items.Clear()
        txtBorrowingID.Text = GenerateBorrowID()
        txtBorrowerID.Text = ""
        txtName.Text = ""


    End Sub

    Private Sub btnAddApparatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddApparatus.Click
        frmAddItems.ShowDialog()
    End Sub

    Private Sub btnAddBorrower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBorrower.Click
        frmSelectBorrower.ShowDialog()

    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvApparatus.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lvApparatus.SelectedItems.Count = 0 Then Exit Sub



        Dim selected As Integer = lvApparatus.SelectedItems(0).Index
        lvApparatus.Items(selected).Remove()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If lvApparatus.Items.Count = 0 Then
                MsgBox("Empty apparatus Item")
                Exit Sub
            End If
            If txtBorrowerID.Text = "" Then
                MsgBox("PLS SELECT A BORROWER!")
                Exit Sub
            End If


            With lvApparatus
                For i As Short = 0 To .Items.Count - 1
                    Dim borrowID As Integer = Val(txtBorrowingID.Text)
                    Dim borrowerID As Integer = Val(txtBorrowerID.Text)
                    Dim dateBorrowed As DateTime = dtpDate.Value
                    Dim apparatusID As Integer = Val(.Items(i).SubItems(0).Text)
                    Dim inventoryID As Integer = Val(.Items(i).SubItems(1).Text)


                    Dim params() As SqlParameter = {New SqlParameter("@borrowID", borrowID), _
                                                    New SqlParameter("@borrowerID", borrowerID), _
                                                    New SqlParameter("@dateBorrowed", dateBorrowed), _
                                                    New SqlParameter("@apparatusID", apparatusID), _
                                                    New SqlParameter("@inventoryID", inventoryID)}


                    'EXECUTE SQL COMMAND
                    ExecuteCommand("AddBorrow", params)

                Next


            End With



            MsgBox("Successfully saved!", _
                   MsgBoxStyle.Information, "SUCCESS")

            Me.Dispose()
            'REFRESH BORROWLIST
            GetAllBorrow()


        Catch ex As Exception
            Dim msg As String

            msg = "ERROR#" & Err.Number.ToString & _
            " There was an error in adding a record. " & _
               ex.Message

            MsgBox(msg, MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub
End Class