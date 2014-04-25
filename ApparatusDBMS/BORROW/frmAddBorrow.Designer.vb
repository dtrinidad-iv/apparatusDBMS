<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBorrow
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
        Me.btnAddApparatus = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBorrowingID = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lvApparatus = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtBorrowerID = New System.Windows.Forms.TextBox
        Me.btnAddBorrower = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtID2 = New System.Windows.Forms.TextBox
        Me.txtApp = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnAddApparatus
        '
        Me.btnAddApparatus.BackColor = System.Drawing.Color.Brown
        Me.btnAddApparatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddApparatus.Location = New System.Drawing.Point(581, 171)
        Me.btnAddApparatus.Name = "btnAddApparatus"
        Me.btnAddApparatus.Size = New System.Drawing.Size(115, 121)
        Me.btnAddApparatus.TabIndex = 151
        Me.btnAddApparatus.Text = "ADD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "APPARATUS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAddApparatus.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(305, 455)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(272, 33)
        Me.btnRemove.TabIndex = 150
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(31, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(272, 33)
        Me.btnClear.TabIndex = 149
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(31, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(544, 24)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "APPARATUS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "BORROWER ID"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(544, 122)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpDate.TabIndex = 145
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Brown
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(581, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 97)
        Me.btnClose.TabIndex = 144
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Brown
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(581, 298)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 93)
        Me.btnSave.TabIndex = 143
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(490, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "BORROWING ID"
        '
        'txtBorrowingID
        '
        Me.txtBorrowingID.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowingID.Location = New System.Drawing.Point(174, 119)
        Me.txtBorrowingID.Name = "txtBorrowingID"
        Me.txtBorrowingID.ReadOnly = True
        Me.txtBorrowingID.Size = New System.Drawing.Size(115, 29)
        Me.txtBorrowingID.TabIndex = 140
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(692, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 33)
        Me.Button1.TabIndex = 139
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Brown
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(-1, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(730, 20)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "NEW BORROWING TRANSACTION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(-1, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(730, 36)
        Me.Label4.TabIndex = 137
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Brown
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(31, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(544, 320)
        Me.Label6.TabIndex = 152
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvApparatus
        '
        Me.lvApparatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2})
        Me.lvApparatus.FullRowSelect = True
        Me.lvApparatus.GridLines = True
        Me.lvApparatus.Location = New System.Drawing.Point(31, 196)
        Me.lvApparatus.Name = "lvApparatus"
        Me.lvApparatus.Size = New System.Drawing.Size(544, 259)
        Me.lvApparatus.TabIndex = 153
        Me.lvApparatus.UseCompatibleStateImageBehavior = False
        Me.lvApparatus.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "apparatusID"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "itemID"
        Me.ColumnHeader4.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apparatus"
        Me.ColumnHeader2.Width = 400
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(174, 62)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.ReadOnly = True
        Me.txtBorrowerID.Size = New System.Drawing.Size(115, 29)
        Me.txtBorrowerID.TabIndex = 154
        '
        'btnAddBorrower
        '
        Me.btnAddBorrower.BackColor = System.Drawing.Color.Maroon
        Me.btnAddBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrower.ForeColor = System.Drawing.Color.White
        Me.btnAddBorrower.Location = New System.Drawing.Point(293, 58)
        Me.btnAddBorrower.Name = "btnAddBorrower"
        Me.btnAddBorrower.Size = New System.Drawing.Size(46, 33)
        Me.btnAddBorrower.TabIndex = 155
        Me.btnAddBorrower.Text = "+"
        Me.btnAddBorrower.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddBorrower.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(345, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(342, 29)
        Me.txtName.TabIndex = 156
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(31, 494)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(115, 29)
        Me.txtID.TabIndex = 157
        Me.txtID.Visible = False
        '
        'txtID2
        '
        Me.txtID2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID2.Location = New System.Drawing.Point(152, 494)
        Me.txtID2.Name = "txtID2"
        Me.txtID2.ReadOnly = True
        Me.txtID2.Size = New System.Drawing.Size(115, 29)
        Me.txtID2.TabIndex = 158
        Me.txtID2.Visible = False
        '
        'txtApp
        '
        Me.txtApp.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApp.Location = New System.Drawing.Point(273, 494)
        Me.txtApp.Name = "txtApp"
        Me.txtApp.ReadOnly = True
        Me.txtApp.Size = New System.Drawing.Size(115, 29)
        Me.txtApp.TabIndex = 159
        Me.txtApp.Visible = False
        '
        'frmAddBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 529)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtApp)
        Me.Controls.Add(Me.txtID2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAddBorrower)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.lvApparatus)
        Me.Controls.Add(Me.btnAddApparatus)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBorrowingID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddApparatus As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBorrowingID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lvApparatus As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBorrowerID As System.Windows.Forms.TextBox
    Friend WithEvents btnAddBorrower As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApp As System.Windows.Forms.TextBox
End Class
