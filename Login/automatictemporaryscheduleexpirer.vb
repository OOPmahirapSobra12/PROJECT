Imports MySql.Data.MySqlClient
Imports System.Timers

Module AutomaticTemporaryScheduleExpirer
    ' Timer for periodic execution
    Private WithEvents ScheduleTimer As Timer
    Public Automation_IsRunning As Boolean = False ' Prevent multiple starts

    ' Start the automatic process
    Public Sub StartExpirationCheck()
        If Not Automation_IsRunning Then
            ' Set up the timer (e.g., every minute)
            ScheduleTimer = New Timer(60000) ' 60000 ms = 1 minute
            ScheduleTimer.AutoReset = True
            ScheduleTimer.Enabled = True
            Automation_IsRunning = True
            Console.WriteLine("Timer started.")
            MessageBox.Show("timer started")
            StartExpirationCheck()
        End If
    End Sub

    ' Stop the automatic process
    Public Sub StopExpirationCheck()
        If Automation_IsRunning AndAlso ScheduleTimer IsNot Nothing Then
            ScheduleTimer.Stop()
            ScheduleTimer.Dispose()
            Automation_IsRunning = False
            Console.WriteLine("Timer stopped.")
            MessageBox.Show("timer ended")
        End If
    End Sub

    ' Event handler for the timer
    Private Sub ScheduleTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles ScheduleTimer.Elapsed
        CheckAndExpireSchedules()
    End Sub

    ' Main logic for checking and expiring schedules
    Private Sub CheckAndExpireSchedules()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Current date and time
            Dim currentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Query to select expired schedules
            Dim selectQuery As String =
                "SELECT * FROM schedtemp WHERE CONCAT(room_date, ' ', room_time_out) <= @CurrentDateTime"

            ' Query to insert into past_schedtemp
            Dim insertQuery As String =
                "INSERT INTO past_schedtemp (room_code, room_time_in, room_time_out, room_date, shedtemp_id, subject_name, sections, course_name) " &
                "SELECT room_code, room_time_in, room_time_out, room_date, shedtemp_id, subject_name, sections, course_name " &
                "FROM schedtemp WHERE CONCAT(room_date, ' ', room_time_out) <= @CurrentDateTime"

            ' Query to delete expired schedules from schedtemp
            Dim deleteQuery As String =
                "DELETE FROM schedtemp WHERE CONCAT(room_date, ' ', room_time_out) <= @CurrentDateTime"

            ' Execute the queries
            Using cmd As New MySqlCommand(selectQuery, ConnectionModule.conn)
                cmd.Parameters.AddWithValue("@CurrentDateTime", currentDateTime)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' If there are expired schedules
                If reader.HasRows Then
                    reader.Close() ' Close the reader before executing next queries

                    ' Insert into past_schedtemp
                    Using insertCmd As New MySqlCommand(insertQuery, ConnectionModule.conn)
                        insertCmd.Parameters.AddWithValue("@CurrentDateTime", currentDateTime)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Delete from schedtemp
                    Using deleteCmd As New MySqlCommand(deleteQuery, ConnectionModule.conn)
                        deleteCmd.Parameters.AddWithValue("@CurrentDateTime", currentDateTime)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    Console.WriteLine("Expired schedules moved to past_schedtemp successfully.")
                Else
                    reader.Close()
                    Console.WriteLine("No expired schedules found.")
                End If
            End Using
        Catch ex As MySqlException
            Console.WriteLine("MySQL Error: " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module
