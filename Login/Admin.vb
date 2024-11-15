Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Admin

    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        accountname_reload()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click
        AccountManagement.Show()
        Me.Hide()
    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    Private Sub accountname_reload()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@U_ID", UniversalDim.U_ID)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and get the username
                Dim result As Object = command.ExecuteScalar()

                ' Check if the result is not null (Nothing)
                If result IsNot Nothing Then
                    Dim username As String = result.ToString()
                    ' Update the button's text with the welcome message
                    btnprofile.Text = "Welcome " & username
                Else
                    ' Handle case where no username is found
                    MessageBox.Show("No username found for the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error retrieving username from database! Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        RoomListForm.Show()

        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim scheduleForm As New Schedule

        ' Show the Schedule form
        scheduleForm.Show()

        ' Optionally, you can hide the current form if you don't want it to be visible
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminPage2.Show()
        Me.Hide()
    End Sub
End Class
