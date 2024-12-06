Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class AdminPage3
    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        account_load()
    End Sub

    Private Sub buttonback_Click(sender As Object, e As EventArgs) Handles buttonback.Click
        AdminPage2.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        adminreport.Show()
        Me.Hide()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        admin_feedback.Show()
        Me.Hide()
    End Sub

    Private Sub btnroomlogs_Click(sender As Object, e As EventArgs) Handles btnroomlogs.Click
        roomlogs.Show()
        Me.Hide()
    End Sub

    Private Sub btnaccountlogs_Click(sender As Object, e As EventArgs) Handles btnaccountlogs.Click
        accountlogs.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim accountID As String = U_ID
        Dim Action As String = "logout"
        logging_log(accountID, Action)
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub
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

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        'AdminPage4.show()
        Me.Hide()
    End Sub
End Class