Imports Guna.UI2.WinForms

Public Class frm_Recovery

    Private Sub formLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_newPass.UseSystemPasswordChar = True
        txt_conNewPass.UseSystemPasswordChar = True
        ckb_newpass.Checked = True
        ckb_conpass.Checked = True
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim textboxes() As Guna2TextBox = {txt_username, txt_email, txt_newPass, txt_conNewPass}
        Dim anyEmpty As Boolean = False

        For Each textbox As Guna2TextBox In textboxes
            If IsEmpty(textbox) Then
                textbox.BorderColor = Color.IndianRed
                anyEmpty = True
            Else
                textbox.BorderColor = Color.FromArgb(255, 196, 42)
            End If
        Next

        If anyEmpty Then
            lbl_errorMessage.Text = "Fill the required fields"
            lbl_errorMessage.Visible = True
        Else
            If IsRecoverAccount(txt_username.Text, txt_email.Text) Then
                If txt_newPass.Text = txt_conNewPass.Text Then
                    UpdatePassword(txt_username.Text, txt_newPass.Text)
                    MessageBox.Show("Successfully Recover!")
                    For Each textbox As Guna2TextBox In textboxes
                        textbox.Clear()
                        textbox.BackColor = Color.FromArgb(255, 196, 42)
                        lbl_errorMessage.Visible = False
                    Next
                Else
                    txt_newPass.BorderColor = Color.IndianRed
                    txt_conNewPass.BorderColor = Color.IndianRed
                    lbl_errorMessage.Text = "New password and Confirm new password did not match"
                    lbl_errorMessage.Visible = True
                End If
            Else
                txt_username.BorderColor = Color.IndianRed
                txt_email.BorderColor = Color.IndianRed
                lbl_errorMessage.Text = "Username and Email did not found"
                lbl_errorMessage.Visible = True
            End If
        End If
    End Sub



    Private Sub textChange(sender As Object, e As EventArgs) Handles txt_username.TextChanged, txt_email.TextChanged, txt_newPass.TextChanged, txt_conNewPass.TextChanged
        Dim textboxes() As Guna2TextBox = {txt_username, txt_email, txt_newPass, txt_conNewPass}

        For Each textbox As Guna2TextBox In textboxes
            textbox.BorderColor = Color.FromArgb(255, 196, 42)
            lbl_errorMessage.Visible = False
        Next
    End Sub

    Private Sub ckb_newpass_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_newpass.CheckedChanged
        If ckb_newpass.Checked = True Then
            txt_newPass.UseSystemPasswordChar = True
        Else
            txt_newPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ckb_conpass_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_conpass.CheckedChanged
        If ckb_conpass.Checked = True Then
            txt_conNewPass.UseSystemPasswordChar = True
        Else
            txt_conNewPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class