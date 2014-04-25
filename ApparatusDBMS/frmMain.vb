Public Class frmMain


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logo2.Visible = True
        logo1.Visible = False
        Timer1.Start()


    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = My.Computer.Clock.LocalTime.Date + " | " + My.Computer.Clock.LocalTime.DayOfWeek.ToString + " | " + TimeOfDay

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("ARE YOU SURE TERIMINATE THE APPLICATION?", _
                    MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                    "HEY!!") = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub PictureBox7_MouseHover(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles logo2.MouseHover
        logo2.Visible = False
        logo1.Visible = True
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles logo1.MouseLeave
        logo2.Visible = True
        logo1.Visible = False
    End Sub

    Private Sub btnBorrower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrower.Click
        frmBorrower.ShowDialog()
    End Sub

    Private Sub btnDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartment.Click
        frmDepartment.ShowDialog()
    End Sub

    Private Sub btnApparatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApparatus.Click
        frmApparatus.ShowDialog()
    End Sub

    Private Sub btnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategories.Click
        frmCategories.ShowDialog()
    End Sub

    Private Sub btnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrand.Click
        frmBrand.ShowDialog()
    End Sub

    Private Sub btnViewCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCalendar.Click
        calendar.Visible = True
        btnViewCalendar.Visible = False
        btnHideCalendar.Visible = True

    End Sub

    Private Sub btnHideCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideCalendar.Click
        btnHideCalendar.Visible = False
        calendar.Visible = False
        btnViewCalendar.Visible = True
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        btnLogin.Visible = True
        btnLogout.Visible = False

        btnBorrower.Enabled = False
        btnDepartment.Enabled = False
        btnApparatus.Enabled = False
        btnCategories.Enabled = False
        btnBrand.Enabled = False
        btnSupplier.Enabled = False
        btnDeliver.Enabled = False
        btnInventory.Enabled = False
        btnBorrow.Enabled = False
        Me.KeyPreview = False

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then frmBorrower.ShowDialog()
        If e.KeyCode = Keys.F2 Then frmDepartment.ShowDialog()
        If e.KeyCode = Keys.F3 Then frmApparatus.ShowDialog()
        If e.KeyCode = Keys.F4 Then frmCategories.ShowDialog()
        If e.KeyCode = Keys.F5 Then frmBrand.ShowDialog()
        If e.KeyCode = Keys.F6 Then frmSupplier.ShowDialog()
        If e.KeyCode = Keys.F7 Then frmDelivery.ShowDialog()
        If e.KeyCode = Keys.F8 Then frmInventory.ShowDialog()
        If e.KeyCode = Keys.F9 Then frmBorrow.ShowDialog()






    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        frmSupplier.ShowDialog()
    End Sub

    Private Sub btnDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeliver.Click
        frmDelivery.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.ShowDialog()
    End Sub

 
    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        frmBorrow.ShowDialog()

    End Sub
End Class
