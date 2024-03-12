Public Class frm_Form1
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Dim stUsername As String
        Dim stPassword As String

        stUsername = txt_Username.Text
        stPassword = txt_Password.Text

        MessageBox.Show("Successfully Login as " + stUsername)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class