Public Class Student

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        U_ID.ToString("")
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnroomlist_Click(sender As Object, e As EventArgs) Handles btnroomlist.Click
        roomstud.Show()
        Me.Hide()
    End Sub

    Private Sub btnfeedbackstud_click(sender As Object, e As EventArgs) Handles btnfeedbackstud.Click
        feedbackstudent.Show()
        Me.Hide()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        ScheduleStudent.Show()
        Me.Hide()
    End Sub
End Class