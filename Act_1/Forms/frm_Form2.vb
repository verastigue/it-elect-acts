Public Class frm_Form2

    Private Sub btn_Hello_Click(sender As Object, e As EventArgs) Handles btn_Hello.Click
        MessageBox.Show("Hello Message")
    End Sub

    Private Sub btn_Welcome_Click(sender As Object, e As EventArgs) Handles btn_Welcome.Click
        MessageBox.Show("Welcome Message")
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_MainForm.Show()
        Hide()
    End Sub

    Private Sub btn_Exit_Click_1(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub


End Class