Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class frm_login

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim defaultUser As New User("Jhon Brian Arce", "arce.jhonbrian@gmail.com", "unclestan14", "teemoako2")
        AddUser(defaultUser)
        txt_password.UseSystemPasswordChar = True
        ckb_controlEye.Checked = True
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim textboxes() As Guna2TextBox = {txt_username, txt_password}
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
            UsersData.session = Login(txt_username.Text, txt_password.Text)
            If UsersData.session IsNot Nothing Then
                frm_Mains.lbl_username.Text = session.Username
                Me.Hide()
                frm_Mains.Show()
                txt_username.Clear()
                txt_password.Clear()
            Else
                txt_password.BorderColor = Color.IndianRed
                lbl_errorMessage.Text = "Incorrect Username or Password!"
                lbl_errorMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub lbl_register_Click(sender As Object, e As EventArgs) Handles lbl_register.Click
        txt_username.Clear()
        txt_password.Clear()
        lbl_errorMessage.Visible = False
        txt_username.BorderColor = Color.FromArgb(255, 196, 42)
        txt_password.BorderColor = Color.FromArgb(255, 196, 42)
        Me.Hide()
        frm_Register.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub ckb_controlEye_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_controlEye.CheckedChanged
        If ckb_controlEye.Checked = True Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Textbox_TextChange(sender As Object, e As EventArgs) Handles txt_username.TextChanged, txt_password.TextChanged
        Dim textbox As Guna2TextBox = CType(sender, Guna2TextBox)
        textbox.BorderColor = Color.FromArgb(255, 196, 42)
        lbl_errorMessage.Visible = False
    End Sub

    Private Sub lbl_forgetPass_Click(sender As Object, e As EventArgs) Handles lbl_forgetPass.Click
        Me.Hide()
        frm_Recovery.Show()
    End Sub
End Class
