Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtName.Clear()
        TxtSub1.Clear()
        TxtSub2.Clear()
        TxtSub3.Clear()
        TxtTotal.Clear()
        TxtAvg.Clear()
        TxtGrade.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim sub1, sub2, sub3, total, avg As Double
        Dim grade As String

        name = Val(TxtName.Text)
        sub1 = Val(TxtSub1.Text)
        sub2 = Val(TxtSub2.Text)
        sub3 = Val(TxtSub3.Text)
        total = sub1 + sub2 + sub3
        avg = total / 3
        TxtTotal.Text = Str(total)
        TxtAvg.Text = Str(avg)

        Select Case avg
            Case 70 To 100
                grade = "A"
            Case 60 To 69
                grade = "B"
            Case 50 To 59
                grade = "C"
            Case 40 To 49
                grade = "D"
            Case < 40
                grade = "E"
            Case Else
                MsgBox("Invalid Marks")
        End Select
        TxtGrade.Text = grade
        MsgBox("Name: " & TxtName.Text & vbNewLine & "Total: " & total & vbNewLine & "Average: " & avg & vbNewLine & "Grade: " & grade)
        'name = InputBox(TxtName.Text)

    End Sub
End Class
