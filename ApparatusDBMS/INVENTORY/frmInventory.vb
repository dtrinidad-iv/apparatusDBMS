Imports System.Data.SqlClient
Public Class frmInventory

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Public Sub GetAllDistinctApparatus()
        Try
            lvInventory.Items.Clear()

            ExecuteCommand("GetAllDistinctApparatus")

            If dReader.HasRows Then
                While dReader.Read
                    lvInventory.Items.Add(dReader.Item("apparatusID").ToString)
                    With lvInventory.Items(lvInventory.Items.Count - 1)
                        .SubItems.Add(dReader.Item("description").ToString)
                        .SubItems.Add("x")
                        .SubItems.Add("x")
                        .SubItems.Add("x")
                    End With
                End While
            End If

            dReader.Close()

        Catch ex As Exception
            MsgBox("THERE HAS BEEN ERROR RETRIEVING POSITION RECORDS! " + ex.Message, _
                   MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub fillTotals()

        Dim total1 As Integer = 0
        Dim total2 As Integer = 0
        Dim total3 As Integer = 0

        For i As Short = 0 To lvInventory.Items.Count - 1


            Dim id As Integer = CInt(lvInventory.Items(i).SubItems(0).Text)
            Dim params() As SqlParameter = {New SqlParameter("@apparatusID", id)}
            Dim params2() As SqlParameter = {New SqlParameter("@apparatusID", id)}

            ExecuteCommand("AvailableCountPerApparatus", True, params)


            If dReader.HasRows Then
                While dReader.Read
                    lvInventory.Items(i).SubItems(2).Text = dReader("count")
                    total1 += CInt(lvInventory.Items(i).SubItems(2).Text)
                End While

            End If

            dReader.Close()

            ExecuteCommand("BorrowedCountPerApparatus", True, params2)


            If dReader.HasRows Then
                While dReader.Read
                    lvInventory.Items(i).SubItems(3).Text = dReader("count")
                    total2 += CInt(lvInventory.Items(i).SubItems(3).Text)
                End While

            End If

            dReader.Close()

            lvInventory.Items(i).SubItems(4).Text = CInt(lvInventory.Items(i).SubItems(2).Text) + CInt(lvInventory.Items(i).SubItems(3).Text)
            total3 += CInt(lvInventory.Items(i).SubItems(4).Text)


        Next
        txtTotalAvailable.Text = total1
        txtTotalBorrowed.Text = total2
        txtGrandTotal.Text = total3
    End Sub


    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        GetAllDistinctApparatus()
        fillTotals()




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



  
    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewAvailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAvailable.Click
        If lvInventory.SelectedItems.Count = 0 Then
            MsgBox("There is no selected APPARATUS to be viewed", _
                   MsgBoxStyle.Exclamation, _
                   "")
            Exit Sub
        End If

        frmViewAvailableApparatus.ShowDialog()
    End Sub
End Class