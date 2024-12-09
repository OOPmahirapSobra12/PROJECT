
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Student
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        Nameloader()
        tableloader()

    End Sub

    Private Sub tableloader()
        ' Define the SQL query with UNION to combine data from `sched` and `schedtemp`
        Dim query As String = "
        SELECT 
            sched.subject_name AS subject, 
            CONCAT(sched.room_time_in, ' - ', sched.room_time_out) AS time,
            roomlist.room_name AS room,
            roomlist.building AS building,
            roomlist.room_status AS room_status
        FROM sched
        LEFT JOIN roomlist ON sched.room_code = roomlist.room_code
        WHERE sched.course_name = @course AND sched.sections = @section

        UNION ALL

        SELECT 
            schedtemp.subject_name AS subject, 
            CONCAT(schedtemp.room_time_in, ' - ', schedtemp.room_time_out) AS time,
            roomlist.room_name AS room,
            roomlist.building AS building,
            roomlist.room_status AS room_status
        FROM schedtemp
        LEFT JOIN roomlist ON schedtemp.room_code = roomlist.room_code
        WHERE schedtemp.course_name = @course AND schedtemp.sections = @section"

        ' Initialize the DataAdapter
        Using adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()

            Try
                ' Add filtering parameters for course and section
                adapter.SelectCommand.Parameters.AddWithValue("@course", course)
                adapter.SelectCommand.Parameters.AddWithValue("@section", section)

                ' Ensure the connection is open
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Fill the data table with the query result
                adapter.Fill(dataTable)

                ' Configure the DataGridView
                DGVrooms.AutoGenerateColumns = False
                DGVrooms.DataSource = dataTable

                ' Ensure the columns in the DataGridView are mapped correctly
                For Each column As DataGridViewColumn In DGVrooms.Columns
                    Select Case column.Name
                        Case "subject"
                            column.DataPropertyName = "subject"
                        Case "time"
                            column.DataPropertyName = "time"
                        Case "room"
                            column.DataPropertyName = "room"
                        Case "building"
                            column.DataPropertyName = "building"
                        Case "room_status"
                            column.DataPropertyName = "room_status"
                    End Select
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading table data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnaccount_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnroomlist.Click
        Roomlist.Show()
        Me.Hide()
    End Sub

    Private Sub btnschedule_Click(sender As Object, e As EventArgs) Handles btnschedule.Click
        ScheduleStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        logs.L_ID = U_ID
        logs.Action = "logout"
        logging_log()
        Start_up_Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        FeedbackReport_sender.Show()
    End Sub
End Class