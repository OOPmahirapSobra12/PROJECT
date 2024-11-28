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
        tableloader()

    End Sub

    Private Sub tableloader()
        Dim query As String = "SELECT room_name, occupancy_status, room_status CASE WHEN room_status = 'Open' THEN occupancy_status ELSE 'Closed' END AS display_status FROM roomlist"
        Using command As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()

            Try
                ' Ensure the connection is open
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                command.Fill(dataTable)
                DGVrooms.AutoGenerateColumns = False
                DGVrooms.DataSource = dataTable

                ' Map data to columns
                For Each column As DataGridViewColumn In DGVrooms.Columns
                    Select Case column.Name
                        Case "room_name"
                            column.DataPropertyName = "room_name"
                        Case "status"
                            column.DataPropertyName = "display_status"
                    End Select
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Always close the connection after use
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
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

    Private Sub btnroomlist_click(sender As Object, e As EventArgs) Handles btnroomlist.Click
        Dim roomliststaff As New roomliststaff()
        roomliststaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnaccount_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        Staffprofile.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim accountID As String = U_ID
        Dim Action As String = "logout"
        logging_log(accountID, Action)
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnschedule_Click_1(sender As Object, e As EventArgs) Handles btnschedule.Click
        staff_schedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        ' Prompt the user to input their password
        Dim inputPassword As String = InputBox("Please enter your password:", "Password Confirmation")

        ' Check if the user canceled the input box
        If String.IsNullOrEmpty(inputPassword) Then
            MessageBox.Show("Password confirmation was canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Define the SQL query to fetch the password for the logged-in user
        Dim sqlQuery As String = "SELECT password FROM users WHERE user_id = @user_id"
        Dim dbPassword As String = String.Empty

        ' Create the command to execute the query
        Dim command As New MySqlCommand(sqlQuery, conn)
        command.Parameters.AddWithValue("@user_id", U_ID)

        Try
            ' Open the connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the query and retrieve the password
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                dbPassword = reader("password").ToString()
            Else
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            reader.Close()

            ' Compare the entered password with the one from the database
            If inputPassword = dbPassword Then
                MessageBox.Show("Password confirmed! You can now proceed.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim accountId As String = U_ID
                Dim action2 As String = "login"
                staff_requestapproval_logs(accountId, action2)
                requestapproval.Show()
                Me.Hide()

            Else
                MessageBox.Show("Incorrect password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure to close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        staffreport.Show()
        Me.Hide()
    End Sub
End Class