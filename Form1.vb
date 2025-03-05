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

        ''Select Case
        'Select Case avg
        '    Case 70 To 100
        '        TxtGrade.Text = "A" '' or grade = "A"
        '    Case 60 To 69
        '        TxtGrade.Text = "B" '' or grade = "B"
        '    Case 50 To 59
        '        TxtGrade.Text = "C" '' or grade = "C"
        '    Case 40 To 49
        '        TxtGrade.Text = "D" ''  or grade = "D"
        '    Case < 40
        '        TxtGrade.Text = "E"  '' or grade = "E"
        '    Case Else
        '        MsgBox("Invalid Marks")
        'End Select

        ''If Else if
        'If (avg >= 70) And (avg <= 100) Then
        '    grade = "A"
        'ElseIf (avg >= 60) And (avg < 70) Then
        '    grade = "B"
        'ElseIf (avg >= 50) And (avg < 60) Then
        '    grade = "C"
        'ElseIf (avg >= 40) And (avg < 50) Then
        '    grade = "D"
        'ElseIf (avg < 40) Then
        '    grade = "E"
        'Else
        '    MsgBox("Invalid Marks!!")
        'End If
        'TxtGrade.Text = grade
        'MsgBox("Name: " & TxtName.Text & vbNewLine & "Total: " & total & vbNewLine & "Average: " & avg & vbNewLine & "Grade: " & grade)
        'name = InputBox(TxtName.Text)

        '' While loop
        'Dim num As Integer
        'num = 3
        'While (num <= 15)
        '    TxtGrade.Text = num
        '    num = num + 4
        'End While

        ''For loop
        'Dim I As Integer
        'Dim sum As Integer
        'Dim num As Integer
        'sum = 0
        'For I = 1 To 3
        '    num = InputBox(“ Key in number”, “ addition”)
        '    sum = sum + num
        'Next I
        'TxtGrade.Text = sum
    End Sub
End Class
