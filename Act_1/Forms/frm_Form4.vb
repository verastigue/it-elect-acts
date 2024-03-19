Public Class frm_Form4
    Private Sub btn_Enable_Click(sender As Object, e As EventArgs) Handles btn_Enable.Click
        btn_ShowMessage.Enabled = True
    End Sub

    Private Sub btn_Disable_Click(sender As Object, e As EventArgs) Handles btn_Disable.Click
        btn_ShowMessage.Enabled = False
    End Sub

    Private Sub btn_ShowMessage_Click(sender As Object, e As EventArgs) Handles btn_ShowMessage.Click
        txt_Message.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class