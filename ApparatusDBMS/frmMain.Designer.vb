<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.calendar = New System.Windows.Forms.MonthCalendar
        Me.btnViewCalendar = New System.Windows.Forms.Button
        Me.btnHideCalendar = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnSupplier = New System.Windows.Forms.Button
        Me.logo2 = New System.Windows.Forms.Label
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnDeliver = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnBorrow = New System.Windows.Forms.Button
        Me.btnInventory = New System.Windows.Forms.Button
        Me.btnBrand = New System.Windows.Forms.Button
        Me.btnCategories = New System.Windows.Forms.Button
        Me.btnDepartment = New System.Windows.Forms.Button
        Me.btnApparatus = New System.Windows.Forms.Button
        Me.btnBorrower = New System.Windows.Forms.Button
        Me.logo1 = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkRed
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-3, 741)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1388, 30)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Database Management System I | University Of Nueva Caceres | College of Computer " & _
            "Studies"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(0, 139)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(1368, 24)
        Me.lblTime.TabIndex = 79
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1388, 37)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "UNC PHYSICS LAB APPARATUS MANAGEMENT SYSTEM version 1.0.1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(1131, 163)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 80
        Me.calendar.TitleBackColor = System.Drawing.Color.Orange
        Me.calendar.Visible = False
        '
        'btnViewCalendar
        '
        Me.btnViewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewCalendar.Location = New System.Drawing.Point(1131, 139)
        Me.btnViewCalendar.Name = "btnViewCalendar"
        Me.btnViewCalendar.Size = New System.Drawing.Size(227, 23)
        Me.btnViewCalendar.TabIndex = 81
        Me.btnViewCalendar.Text = "Calendar"
        Me.btnViewCalendar.UseVisualStyleBackColor = True
        '
        'btnHideCalendar
        '
        Me.btnHideCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideCalendar.Location = New System.Drawing.Point(1131, 139)
        Me.btnHideCalendar.Name = "btnHideCalendar"
        Me.btnHideCalendar.Size = New System.Drawing.Size(227, 23)
        Me.btnHideCalendar.TabIndex = 82
        Me.btnHideCalendar.Text = "Hide"
        Me.btnHideCalendar.UseVisualStyleBackColor = True
        Me.btnHideCalendar.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Brown
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.ApparatusDBMS.My.Resources.Resources.lock_icon__2_
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(909, 42)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(94, 89)
        Me.btnLogout.TabIndex = 85
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        Me.btnLogout.Visible = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Brown
        Me.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSupplier.Enabled = False
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupplier.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSupplier.Image = Global.ApparatusDBMS.My.Resources.Resources.administrator_icon
        Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupplier.Location = New System.Drawing.Point(510, 42)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(94, 89)
        Me.btnSupplier.TabIndex = 84
        Me.btnSupplier.Text = "Supplier [F6]"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'logo2
        '
        Me.logo2.Image = Global.ApparatusDBMS.My.Resources.Resources.appartus3
        Me.logo2.Location = New System.Drawing.Point(393, 217)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(586, 376)
        Me.logo2.TabIndex = 78
        Me.logo2.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Brown
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Global.ApparatusDBMS.My.Resources.Resources.Keys_icon
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogin.Location = New System.Drawing.Point(909, 42)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 89)
        Me.btnLogin.TabIndex = 77
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnDeliver
        '
        Me.btnDeliver.BackColor = System.Drawing.Color.Brown
        Me.btnDeliver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeliver.Enabled = False
        Me.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeliver.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliver.ForeColor = System.Drawing.Color.White
        Me.btnDeliver.Image = Global.ApparatusDBMS.My.Resources.Resources.lorry_icon
        Me.btnDeliver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeliver.Location = New System.Drawing.Point(610, 42)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(94, 89)
        Me.btnDeliver.TabIndex = 76
        Me.btnDeliver.Text = "Delivery [F7]"
        Me.btnDeliver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeliver.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Global.ApparatusDBMS.My.Resources.Resources.Button_Close_icon
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1009, 42)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 89)
        Me.btnExit.TabIndex = 75
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.Brown
        Me.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrow.Enabled = False
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrow.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBorrow.Image = Global.ApparatusDBMS.My.Resources.Resources.Lab_icon
        Me.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrow.Location = New System.Drawing.Point(810, 42)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(94, 89)
        Me.btnBorrow.TabIndex = 74
        Me.btnBorrow.Text = "Borrow [F9]"
        Me.btnBorrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Brown
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInventory.Enabled = False
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventory.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Image = Global.ApparatusDBMS.My.Resources.Resources.Inventory_icon
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventory.Location = New System.Drawing.Point(710, 42)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(94, 89)
        Me.btnInventory.TabIndex = 73
        Me.btnInventory.Text = "Inventory [F8]"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.BackColor = System.Drawing.Color.Brown
        Me.btnBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrand.Enabled = False
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrand.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrand.ForeColor = System.Drawing.Color.White
        Me.btnBrand.Image = Global.ApparatusDBMS.My.Resources.Resources.brand_icon
        Me.btnBrand.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrand.Location = New System.Drawing.Point(410, 42)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(94, 89)
        Me.btnBrand.TabIndex = 72
        Me.btnBrand.Text = "Brand [F5]"
        Me.btnBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'btnCategories
        '
        Me.btnCategories.BackColor = System.Drawing.Color.Brown
        Me.btnCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCategories.Enabled = False
        Me.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCategories.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategories.ForeColor = System.Drawing.Color.White
        Me.btnCategories.Image = Global.ApparatusDBMS.My.Resources.Resources.Dock_Trash_full_icon
        Me.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCategories.Location = New System.Drawing.Point(310, 42)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(94, 89)
        Me.btnCategories.TabIndex = 71
        Me.btnCategories.Text = "Categories [F4]"
        Me.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCategories.UseVisualStyleBackColor = False
        '
        'btnDepartment
        '
        Me.btnDepartment.BackColor = System.Drawing.Color.Brown
        Me.btnDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDepartment.Enabled = False
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDepartment.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.White
        Me.btnDepartment.Image = Global.ApparatusDBMS.My.Resources.Resources.Home_icon
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDepartment.Location = New System.Drawing.Point(110, 42)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(94, 89)
        Me.btnDepartment.TabIndex = 70
        Me.btnDepartment.Text = "Department[F2]"
        Me.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDepartment.UseVisualStyleBackColor = False
        '
        'btnApparatus
        '
        Me.btnApparatus.BackColor = System.Drawing.Color.Brown
        Me.btnApparatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnApparatus.Enabled = False
        Me.btnApparatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApparatus.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApparatus.ForeColor = System.Drawing.Color.White
        Me.btnApparatus.Image = Global.ApparatusDBMS.My.Resources.Resources.laboratory_icon
        Me.btnApparatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnApparatus.Location = New System.Drawing.Point(210, 42)
        Me.btnApparatus.Name = "btnApparatus"
        Me.btnApparatus.Size = New System.Drawing.Size(94, 89)
        Me.btnApparatus.TabIndex = 69
        Me.btnApparatus.Text = "Apparatus [F3]"
        Me.btnApparatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnApparatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnApparatus.UseVisualStyleBackColor = False
        '
        'btnBorrower
        '
        Me.btnBorrower.BackColor = System.Drawing.Color.Brown
        Me.btnBorrower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrower.Enabled = False
        Me.btnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrower.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrower.ForeColor = System.Drawing.Color.White
        Me.btnBorrower.Image = Global.ApparatusDBMS.My.Resources.Resources.User_Coat_Red_icon
        Me.btnBorrower.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrower.Location = New System.Drawing.Point(10, 42)
        Me.btnBorrower.Name = "btnBorrower"
        Me.btnBorrower.Size = New System.Drawing.Size(94, 89)
        Me.btnBorrower.TabIndex = 68
        Me.btnBorrower.Text = "Borrower [F1]"
        Me.btnBorrower.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrower.UseVisualStyleBackColor = False
        '
        'logo1
        '
        Me.logo1.Image = Global.ApparatusDBMS.My.Resources.Resources.appartus2
        Me.logo1.Location = New System.Drawing.Point(394, 216)
        Me.logo1.Name = "logo1"
        Me.logo1.Size = New System.Drawing.Size(586, 376)
        Me.logo1.TabIndex = 53
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.DarkGray
        Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Image = Global.ApparatusDBMS.My.Resources.Resources.a1
        Me.lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl.Location = New System.Drawing.Point(-29, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(1441, 139)
        Me.lbl.TabIndex = 49
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnHideCalendar)
        Me.Controls.Add(Me.btnViewCalendar)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnDeliver)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnBrand)
        Me.Controls.Add(Me.btnCategories)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.btnApparatus)
        Me.Controls.Add(Me.btnBorrower)
        Me.Controls.Add(Me.logo1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logo1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrower As System.Windows.Forms.Button
    Friend WithEvents btnApparatus As System.Windows.Forms.Button
    Friend WithEvents btnDepartment As System.Windows.Forms.Button
    Friend WithEvents btnCategories As System.Windows.Forms.Button
    Friend WithEvents btnBrand As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents logo2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnViewCalendar As System.Windows.Forms.Button
    Friend WithEvents btnHideCalendar As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button

End Class
