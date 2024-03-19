Public Class frm_MainForm
    Private Sub btn_Form1_Click(sender As Object, e As EventArgs) Handles btn_Form1.Click
        frm_Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Form2_Click(sender As Object, e As EventArgs) Handles btn_Form2.Click
        frm_Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Form3_Click(sender As Object, e As EventArgs) Handles btn_Form3.Click
        frm_Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Form4_Click(sender As Object, e As EventArgs) Handles btn_Form4.Click
        frm_Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class