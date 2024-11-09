Public Class Student

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Login.Show()
    End Sub

    Private Sub btnroomlist_Click(sender As Object, e As EventArgs) Handles btnroomlist.Click
        roomstud.Show()
        Me.Hide()
    End Sub


End Class