Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.F1 Then frmBorrower.ShowDialog()
    End Sub
   
    
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLocation(Me)
        Me.Show()
        txtUsername.Focus()
        txtPassword.Text = ""
        txtUsername.Text = ""

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try

            Dim username As String = txtUsername.Text.Trim
            Dim password As String = txtPassword.Text.Trim


            Dim param() As SqlParameter = _
                        {New SqlParameter("@USERNAME", username), _
                        New SqlParameter("@USERPASS", password)}


            Dim sqlComm As New SqlCommand

            OpenConnection()

            With sqlComm
                .Connection = sqlConn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "GetSecurity"
                .Parameters.AddRange(param)
            End With


            dReader = sqlComm.ExecuteReader

            If dReader.HasRows Then
                enableButton()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Close()


            Else
                MsgBox("ACCESS DENIED!", MsgBoxStyle.Exclamation, _
                       "INVALID")
                txtUsername.Focus()
                txtPassword.Text = ""
                txtUsername.Text = ""

            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("There has been an error! " & ex.Message, _
                   MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub
    Private Sub enableButton()
        frmMain.btnLogin.Visible = False
        frmMain.btnLogout.Visible = True

        frmMain.btnBorrower.Enabled = True
        frmMain.btnDepartment.Enabled = True
        frmMain.btnApparatus.Enabled = True
        frmMain.btnCategories.Enabled = True
        frmMain.btnBrand.Enabled = True
        frmMain.btnSupplier.Enabled = True
        frmMain.btnDeliver.Enabled = True
        frmMain.btnInventory.Enabled = True
        frmMain.btnBorrow.Enabled = True
        frmMain.KeyPreview = True





    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        sender.BackColor = Color.Silver
        lb1.Visible = True
        lb2.Visible = False

    End Sub
    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        sender.BackColor = Color.Silver
        lb1.Visible = False
        lb2.Visible = True

    End Sub


    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave, txtPassword.Leave
        sender.BackColor = Color.White

        lb1.Visible = False
        lb2.Visible = False
    End Sub
End Class