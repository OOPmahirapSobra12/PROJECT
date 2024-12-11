Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Admin

    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        account_load()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        logs.L_ID = U_ID
        logs.Action = "logout"
        logging_log()
        Start_up_Login.Show()
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

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        RoomListForm.Show()

        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnschedule.Click
        Dim scheduleForm As New Schedule

        ' Show the Schedule form
        scheduleForm.Show()

        ' Hide the current form if you don't want it to be visible (Optional)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        AdminPage2.Show()
        Me.Hide()
    End Sub

    'profile part
    Private Sub account_load()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            ' Add the ID parameter to prevent SQL injection
            command.Parameters.AddWithValue("@U_ID", U_ID)

            Try
                ' Open the connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and read the data
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the textboxes with the data from the database
                        Dim name As String = reader("username").ToString()
                        btnprofile.Text = name & " (View Profile)"
                    Else
                        MessageBox.Show("No record found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub btnloging_Click(sender As Object, e As EventArgs) Handles btnloggin.Click
        roomoccupancy.StartPosition = FormStartPosition.CenterScreen
        roomoccupancy.Show()
    End Sub
End Class
