Imports System.Data.SqlClient

Public Class frmAddDepartment


#Region "KEYPRESS"
    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeptName.KeyPress
        keyCheck(e)
    End Sub
#End Region

    Private Sub frmAddDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation2(Me)
        txtDeptName.Text = ""
        txtDeptID.Text = GenerateDepartmentID().ToString
        Me.Show()
        txtDeptName.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddDepartment()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class