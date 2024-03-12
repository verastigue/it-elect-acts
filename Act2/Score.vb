Public Class Score
    'DECLARE
    Public quiz1, quiz2, quiz3 As Double
    Public act1, act2, act3 As Double
    Public recitaion As Double
    Public attendance As Double
    Public exam As Double

    'PROCESS
    Public Function totalQuiz() As Double
        Return ((quiz1 + quiz2 + quiz3) / 3) * 0.2
    End Function

    Public Function totalAct() As Double
        Return ((act1 + act2 + act3) / 3) * 0.25
    End Function

    Public Function totalRec() As Double
        Return recitaion * 0.15
    End Function

    Public Function totalAtt() As Double
        Return attendance * 0.1
    End Function

    Public Function totalExam() As Double
        Return exam * 0.3
    End Function

    Public Function totalGrade(percent As Double) As Double
        Return (totalQuiz() + totalAct() + totalRec() + totalAtt() + totalExam()) * percent
    End Function
End Class
