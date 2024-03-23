Imports Guna.UI2.WinForms

Public Class frm_Mains
    'GLOBAL VARIABLE
    Dim prelim As New Score()
    Dim midterm As New Score()
    Dim finals As New Score()
    Dim dt_gradeList As DataTable
    Dim dt_gradeRange As DataTable

    Dim currentBtn As Guna2Button

    Sub activateBtn(clickBtn As Guna2Button, tbp As TabPage)
        deactivateBtn()
        currentBtn = clickBtn
        currentBtn.FillColor = Color.IndianRed
        tb_section.SelectedTab = tbp
    End Sub

    Sub deactivateBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.FillColor = Color.FromArgb(0, 82, 63)
        End If
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dt_gradeList Is Nothing Then
            dt_gradeList = New DataTable()
            dt_gradeList.Columns.Add("Name", GetType(String))
            dt_gradeList.Columns.Add("Prelim", GetType(Double))
            dt_gradeList.Columns.Add("Midterm", GetType(Double))
            dt_gradeList.Columns.Add("Finals", GetType(Double))
            dt_gradeList.Columns.Add("Total", GetType(Double))
            dt_gradeList.Columns.Add("Range", GetType(String))
            dtgv_gradeList.DataSource = dt_gradeList
        Else
            dt_gradeList = DirectCast(dtgv_gradeList.DataSource, DataTable)
        End If

        If dt_gradeRange Is Nothing Then
            dt_gradeRange = New DataTable()
            dt_gradeRange.Columns.Add("Name", GetType(String))
            dt_gradeRange.Columns.Add("Grade", GetType(Double))
            dt_gradeRange.Columns.Add("Range", GetType(String))
            dtgv_grade.DataSource = dt_gradeRange
        End If
    End Sub

    Private Sub btn_pcomp_Click(sender As Object, e As EventArgs) Handles btn_pcomp.Click
        'QUIZ
        prelim.quiz1 = Val(txt_pq1.Text)
        prelim.quiz2 = Val(txt_pq2.Text)
        prelim.quiz3 = Val(txt_pq3.Text)

        'ACTIVITY
        prelim.act1 = Val(txt_pact1.Text)
        prelim.act2 = Val(txt_pact2.Text)
        prelim.act3 = Val(txt_pact3.Text)

        'ATTENDANCE
        prelim.attendance = Val(txt_patt.Text)

        'RECITATION
        prelim.recitaion = Val(txt_prec.Text)

        'EXAM
        prelim.exam = Val(txt_pex.Text)

        'DISPLAY THE PRELIM GRADE
        txt_ptotal.Text = prelim.totalGrade(0.3)
    End Sub

    Private Sub btn_mcomp_Click(sender As Object, e As EventArgs) Handles btn_mcomp.Click
        'QUIZ
        midterm.quiz1 = Val(txt_mq1.Text)
        midterm.quiz2 = Val(txt_mq2.Text)
        midterm.quiz3 = Val(txt_mq3.Text)

        'ACTIVITY
        midterm.act1 = Val(txt_mact1.Text)
        midterm.act2 = Val(txt_mact2.Text)
        midterm.act3 = Val(txt_mact3.Text)

        'ATTENDANCE
        midterm.attendance = Val(txt_matt.Text)

        'RECITATION
        midterm.recitaion = Val(txt_mrec.Text)

        'EXAM
        midterm.exam = Val(txt_mex.Text)

        'DISPLAY THE MIDTERM GRADE
        txt_mtotal.Text = midterm.totalGrade(0.3)
    End Sub

    Private Sub btn_fcomp_Click(sender As Object, e As EventArgs) Handles btn_fcomp.Click
        'QUIZ
        finals.quiz1 = Val(txt_fq1.Text)
        finals.quiz2 = Val(txt_fq2.Text)
        finals.quiz3 = Val(txt_fq3.Text)

        'ACTIVITY
        finals.act1 = Val(txt_fact1.Text)
        finals.act2 = Val(txt_fact2.Text)
        finals.act3 = Val(txt_fact3.Text)

        'ATTENDANCE
        finals.attendance = Val(txt_fatt.Text)

        'RECITATION
        finals.recitaion = Val(txt_frec.Text)

        'EXAM
        finals.exam = Val(txt_fex.Text)

        'DISPLAY THE FINALS GRADE
        txt_ftotal.Text = finals.totalGrade(0.4)
    End Sub

    Private Sub btn_tcomp_Click(sender As Object, e As EventArgs) Handles btn_tcomp.Click
        txt_total.Text = prelim.totalGrade(0.3) + midterm.totalGrade(0.3) + finals.totalGrade(0.4)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim newRow As DataRow = dt_gradeList.NewRow()

        newRow("Name") = txt_enterName.Text
        newRow("Prelim") = prelim.totalGrade(0.3)
        newRow("Midterm") = midterm.totalGrade(0.3)
        newRow("Finals") = finals.totalGrade(0.4)
        newRow("Total") = CDbl(txt_total.Text)
        newRow("Range") = Range_det(CDbl(txt_total.Text))

        dt_gradeList.Rows.Add(newRow)

        dtgv_gradeList.Refresh()


        For Each ctrl As Control In tbp_gradeCalc.Controls
            If TypeOf ctrl Is Guna2TextBox Then
                CType(ctrl, Guna2TextBox).Clear()
            End If
        Next
    End Sub

    Private Function Range_det(totalGrade As Double) As String
        Dim gradeRange As String

        Select Case totalGrade
            Case >= 90
                gradeRange = "A"
            Case >= 80
                gradeRange = "B"
            Case >= 70
                gradeRange = "C"
            Case >= 60
                gradeRange = "D"
            Case Else
                gradeRange = "F"
        End Select

        Return gradeRange
    End Function



    'CALCLATOR

    Dim expression As String = ""
    Dim preExpression As String = ""
    Dim operatorUsed As Boolean = False
    Dim dotUsed As Boolean = False
    Dim history As New List(Of String)()

    Private Sub number_click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        Dim button As Guna2Button = CType(sender, Guna2Button)
        expression += button.Text
        operatorUsed = False
        txt_displayNumber.Text = expression
    End Sub

    Private Sub operator_click(sender As Object, e As EventArgs) Handles btn_plus.Click, btn_minus.Click, btn_times.Click, btn_divide.Click
        Dim button As Guna2Button = CType(sender, Guna2Button)
        If Not operatorUsed AndAlso expression.Length > 0 Then
            expression += button.Text
            operatorUsed = True
            dotUsed = False
            txt_displayNumber.Text = expression
        End If
    End Sub

    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        If Not dotUsed Then
            expression += "."
            operatorUsed = False
            dotUsed = True
            txt_displayNumber.Text = expression
        End If
    End Sub

    Private Sub btn_percent_Click(sender As Object, e As EventArgs) Handles btn_percent.Click
        If expression IsNot "" AndAlso IsNumeric(expression) Then
            Dim number As Double = CDbl(expression)
            number /= 100
            expression = number.ToString
            txt_displayNumber.Text = expression
        End If
    End Sub

    Private Sub btn_positiveNegative_Click(sender As Object, e As EventArgs) Handles btn_positiveNegative.Click
        If expression IsNot "" AndAlso IsNumeric(expression) Then
            Dim number As Double = CDbl(expression)
            number = -number
            expression = number.ToString
            txt_displayNumber.Text = expression
        End If
    End Sub

    Private Function evaluate(expression As String)
        Dim dataTable As New DataTable
        Dim result As Object = dataTable.Compute(expression, "")

        Return Convert.ToDouble(result)
    End Function

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Try
            Dim result As Double = evaluate(expression)
            txt_displayNumber.Text = result.ToString
            preExpression = expression
            expression = result.ToString
            history.Add(preExpression & " = " & result.ToString())

            lst_viewHistory.Items.Clear()
            For Each item As String In history
                lst_viewHistory.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Invalid Expression")
            txt_displayNumber.Text = ""
            expression = ""
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If expression.Length > 1 OrElse (expression.Length = 1 AndAlso expression IsNot "0") Then
            expression = expression.Substring(0, expression.Length - 1)
            txt_displayNumber.Text = expression

            If expression.Length > 0 AndAlso Not Char.IsDigit(expression(expression.Length - 1)) Then
                operatorUsed = True
            Else
                operatorUsed = False
            End If

            If Not expression.Contains(".") Then
                dotUsed = False
            End If
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_displayNumber.Text = "0"
        txt_displayResult.Text = "0"
        expression = ""
        operatorUsed = False
        dotUsed = False
    End Sub

    Private Sub txt_displayNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_displayNumber.TextChanged
        If txt_displayNumber.Text = "" Then
            txt_displayNumber.Text = "0"
        End If
        Try
            If txt_displayNumber.Text <> "" Then
                Dim result As Double = evaluate(txt_displayNumber.Text)
                txt_displayResult.Text = result.ToString()
            Else
                txt_displayResult.Text = ""
            End If
        Catch ex As Exception
            txt_displayResult.Text = "0"
        End Try
    End Sub

    Private Sub btn_delHistory_Click(sender As Object, e As EventArgs) Handles btn_delPreHIstory.Click
        If history.Count > 0 Then
            history.RemoveAt(history.Count - 1)
            lst_viewHistory.Items.Clear()
            For Each item As String In history
                lst_viewHistory.Items.Add(item)
            Next
        End If
    End Sub


    'GRADE RANGE
    Private Sub bsubmit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim grade As Double

        If txt_grade.Text = "" And txt_name.Text = "" Then
            MessageBox.Show("Please Provide your Name and Grade!")
        ElseIf txt_grade.Text = "" Then
            MessageBox.Show("Provide your name")
        ElseIf txt_name.Text = "" Then
            MessageBox.Show("Provide your Grade!")
        ElseIf Not Double.TryParse(txt_grade.Text, grade) Then
            MessageBox.Show("Invalid Input. Enter valid numeric number")
        Else
            If grade > 100 Or grade < 0 Then
                MessageBox.Show("out of range")
            Else
                Dim newRow As DataRow = dt_gradeRange.NewRow()
                newRow("Name") = txt_name.Text
                newRow("Grade") = CDbl(txt_grade.Text)
                newRow("Range") = Range_det(grade)

                dt_gradeRange.Rows.Add(newRow)
                dtgv_grade.Refresh()
                txt_name.Clear()
                txt_grade.Clear()
            End If
        End If
    End Sub

    'CHANGE ACCOUNT
    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        activateBtn(btn_change, tbp_changeAcc)
        txt_nameAcc.Text = session.Name
        txt_email.Text = session.Email
        txt_username.Text = session.Username
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim textboxes() As Guna2TextBox = {txt_password, txt_newPassword, txt_newUsername}
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
            If txt_password.Text = session.Password Then
                session.Username = txt_newUsername.Text
                session.Password = txt_newPassword.Text
                MessageBox.Show("Successfully updated!")
                txt_username.Text = session.Username
                lbl_username.Text = session.Username
                txt_password.Clear()
                txt_newUsername.Clear()
                txt_newPassword.Clear()
            Else
                txt_password.BorderColor = Color.IndianRed
                lbl_errorMessage.Text = "Incorrect Password!"
                lbl_errorMessage.Visible = True
            End If
        End If

    End Sub

    Private Sub Textbox_TextChange(sender As Object, e As EventArgs) Handles txt_password.TextChanged, txt_newPassword.TextChanged, txt_newUsername.TextChanged
        Dim textbox As Guna2TextBox = CType(sender, Guna2TextBox)
        textbox.BorderColor = Color.FromArgb(255, 196, 42)
        lbl_errorMessage.Visible = False
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        UsersData.session = Nothing
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_gradeCalc_Click(sender As Object, e As EventArgs) Handles btn_gradeCalc.Click
        activateBtn(btn_gradeCalc, tbp_gradeCalc)
    End Sub

    Private Sub btn_calculator_Click(sender As Object, e As EventArgs) Handles btn_calculator.Click
        activateBtn(btn_calculator, tbp_calculator)
    End Sub

    Private Sub btn_range_Click(sender As Object, e As EventArgs) Handles btn_range.Click
        activateBtn(btn_range, tbp_gradeRange)
    End Sub
End Class