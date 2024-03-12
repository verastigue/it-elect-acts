Public Class Form1
    'GLOBAL VARIABLE
    Dim prelim As New Score()
    Dim midterm As New Score()
    Dim finals As New Score()

    'PRELIMS
    Private Sub btn_Pcomp_Click(sender As Object, e As EventArgs) Handles btn_Pcomp.Click
        'QUIZ
        prelim.quiz1 = Val(txt_Pq1.Text)
        prelim.quiz2 = Val(txt_Pq2.Text)
        prelim.quiz3 = Val(txt_Pq3.Text)

        'ACTIVITY
        prelim.act1 = Val(txt_Pact1.Text)
        prelim.act2 = Val(txt_Pact2.Text)
        prelim.act3 = Val(txt_Pact3.Text)

        'ATTENDANCE
        prelim.attendance = Val(txt_Patt.Text)

        'RECITATION
        prelim.recitaion = Val(txt_Prec.Text)

        'EXAM
        prelim.exam = Val(txt_Pex.Text)

        'DISPLAY THE PRELIM GRADE
        txt_Tp.Text = prelim.totalGrade(0.3)
    End Sub

    'MIDTERM
    Private Sub btn_Mcomp_Click(sender As Object, e As EventArgs) Handles btn_Mcomp.Click
        'QUIZ
        midterm.quiz1 = Val(txt_Mq1.Text)
        midterm.quiz2 = Val(txt_Mq2.Text)
        midterm.quiz3 = Val(txt_Mq3.Text)

        'ACTIVITY
        midterm.act1 = Val(txt_Mact1.Text)
        midterm.act2 = Val(txt_Mact2.Text)
        midterm.act3 = Val(txt_Mact3.Text)

        'ATTENDANCE
        midterm.attendance = Val(txt_Matt.Text)

        'RECITATION
        midterm.recitaion = Val(txt_Mrec.Text)

        'EXAM
        midterm.exam = Val(txt_Mex.Text)

        'DISPLAY THE MIDTERM GRADE
        txt_Tm.Text = midterm.totalGrade(0.3)
    End Sub


    'FINALS
    Private Sub btn_Fcomp_Click(sender As Object, e As EventArgs) Handles btn_Fcomp.Click
        'QUIZ
        finals.quiz1 = Val(txt_Fq1.Text)
        finals.quiz2 = Val(txt_Fq2.Text)
        finals.quiz3 = Val(txt_Fq3.Text)

        'ACTIVITY
        finals.act1 = Val(txt_Fact1.Text)
        finals.act2 = Val(txt_Fact2.Text)
        finals.act3 = Val(txt_Fact3.Text)

        'ATTENDANCE
        finals.attendance = Val(txt_Fatt.Text)

        'RECITATION
        finals.recitaion = Val(txt_Frec.Text)

        'EXAM
        finals.exam = Val(txt_Fex.Text)

        'DISPLAY THE FINALS GRADE
        txt_Tf.Text = finals.totalGrade(0.4)
    End Sub

    'TOTAL GRADE
    Private Sub btn_Tcomp_Click(sender As Object, e As EventArgs) Handles btn_Tcomp.Click
        txt_Tg.Text = prelim.totalGrade(0.3) + midterm.totalGrade(0.3) + finals.totalGrade(0.4)
    End Sub
End Class


