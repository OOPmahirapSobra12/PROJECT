Public Class roomliststaff
    Private Sub DGVroomlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVroomlist.CellContentClick

    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        ' Get the text from txtSearch1
        Dim searchText As String = txtSearch1.Text

        ' Perform a search or desired action with the input text
        MessageBox.Show("You entered: " & searchText)
    End Sub


    Private Sub txtsearchstaff_TextChanged(sender As Object, e As EventArgs) Handles txtsearch1.TextChanged

    End Sub

    Private Sub btnSearch1_Click_1(sender As Object, e As EventArgs) Handles btnSearch1.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        ' Create an instance of the Staff form
        Dim staffForm As New Staff()

        ' Show the Staff form
        staffForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

End Class