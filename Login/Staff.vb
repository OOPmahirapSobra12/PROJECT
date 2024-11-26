Public Class Staff
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnschedule_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnrequest_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnroomlist_click(sender As Object, e As EventArgs)
        Dim roomliststaff As New roomliststaff()
        roomliststaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs)
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub


End Class