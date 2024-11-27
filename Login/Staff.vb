Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Staff
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        Nameloader()
    End Sub

    Private Sub btnschedule_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnrequest_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nameloader()
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
                        btnaccount.Text = reader("username").ToString() & " (View Profile)"

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

    Private Sub btnaccount_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        Staff2.Show()
        Me.Hide()
    End Sub
End Class