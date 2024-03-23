Imports Guna.UI2.WinForms

Public Class frm_Register

    Private Sub frm_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim textboxes() As Guna2TextBox = {txt_name, txt_email, txt_username, txt_password}
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
            lbl_errorMessage.Visible = False

            If UsernameExists(txt_username.Text) AndAlso EmailExists(txt_email.Text) Then
                lbl_errorMessage.Text = "Username and Email already exist"
                lbl_errorMessage.Visible = True
            ElseIf EmailExists(txt_email.Text) Then
                lbl_errorMessage.Text = "Email already exist"
                lbl_errorMessage.Visible = True
            ElseIf UsernameExists(txt_username.Text) Then
                lbl_errorMessage.Text = "Username already exist"
                lbl_errorMessage.Visible = True
            Else
                Dim newUser As New User(txt_name.Text, txt_email.Text, txt_username.Text, txt_password.Text)
                AddUser(newUser)

                For Each textbox As Guna2TextBox In textboxes
                    textbox.Clear()
                Next

                MessageBox.Show("Registration Successfully")
                Me.Hide()
                frm_login.Show()
            End If
        End If
    End Sub

    Private Sub Textbox_TextChange(sender As Object, e As EventArgs) Handles txt_name.TextChanged, txt_email.TextChanged, txt_username.TextChanged, txt_password.TextChanged
        Dim textbox As Guna2TextBox = CType(sender, Guna2TextBox)
        textbox.BorderColor = Color.FromArgb(255, 196, 42)
        lbl_errorMessage.Visible = False
    End Sub

    Private Sub ckb_controlEye_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_controlEye.CheckedChanged
        If ckb_controlEye.Checked = True Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        Dim textboxes() As Guna2TextBox = {txt_name, txt_email, txt_username, txt_password}

        For Each textbox As Guna2TextBox In textboxes
            textbox.Clear()
        Next
        Me.Hide()
        frm_login.Show()
    End Sub
End Class
