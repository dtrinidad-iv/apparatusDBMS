Imports System.Text.RegularExpressions
Module mdlKeypress

    Public Sub setLocation(ByVal FORM)
        FORM.top = frmMain.lbl.Height + 1
    End Sub
    Public Sub setLocation2(ByVal FORM)
        FORM.top = frmMain.lbl.Height + 145
    End Sub
    Public Sub keyCheck(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Regex.IsMatch(e.KeyChar, "[a-zA-Z \-\b]") Then
            e.Handled = True
        End If
    End Sub
    Public Sub numCheck(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Regex.IsMatch(e.KeyChar, "[0-9 \-\b]") Then
            e.Handled = True
        End If
    End Sub
    Public Sub adDCheck(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Regex.IsMatch(e.KeyChar, "[0-9a-zA-Z#,. \-\b]") Then
            e.Handled = True
        End If
    End Sub
    Public Sub numOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Regex.IsMatch(e.KeyChar, "[0-9 \-\b]") Then
            e.Handled = True
        End If
    End Sub
End Module

