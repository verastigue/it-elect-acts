Public Class frm_Form3
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_Button.Click
        chk_CheckBox.Visible = False
        opt_RadioButton.Visible = False
        MessageBox.Show("Check Box and Radio Button are hide")
    End Sub

    Private Sub chk_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CheckBox.CheckedChanged
        btn_Button.Visible = False
        opt_RadioButton.Visible = False
        MessageBox.Show("Button and Radio Button are Hide")
    End Sub

    Private Sub opt_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles opt_RadioButton.CheckedChanged
        btn_Button.Visible = False
        chk_CheckBox.Visible = False
        MessageBox.Show("Button and CheckBox are hide")
    End Sub

    Private Sub btn_ShowAll_Click(sender As Object, e As EventArgs) Handles btn_ShowAll.Click
        btn_Button.Visible = True
        chk_CheckBox.Visible = True
        opt_RadioButton.Visible = True
    End Sub

    Private Sub btn_HideAll_Click(sender As Object, e As EventArgs) Handles btn_HideAll.Click
        btn_Button.Visible = False
        chk_CheckBox.Visible = False
        opt_RadioButton.Visible = False
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class