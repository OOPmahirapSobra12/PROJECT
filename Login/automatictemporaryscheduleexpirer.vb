﻿Imports MySql.Data.MySqlClient
Imports System.Timers

Module AutomaticTemporaryScheduleExpirer
    ' Timer for continous execution
    Private WithEvents ScheduleTimer As Timer
    Public Automation_IsRunning As Boolean = False ' Prevent multiple starts

    ' Start the automatic expiration process
    Public Sub StartExpirationCheck()
        If Not Automation_IsRunning Then
            ' Set up the timer (e.g., every minute)
            ScheduleTimer = New Timer(60000) ' 60000 ms = 1 minute
            ScheduleTimer.AutoReset = True
            AddHandler ScheduleTimer.Elapsed, AddressOf ScheduleTimer_Elapsed
            ScheduleTimer.Enabled = True

            Automation_IsRunning = True
            MessageBox.Show("Automatic schedule expiration has started.")
        End If
    End Sub

    ' Stop the automatic expiration process
    Public Sub StopExpirationCheck()
        If Automation_IsRunning AndAlso ScheduleTimer IsNot Nothing Then
            ScheduleTimer.Stop()
            ScheduleTimer.Dispose()
            Automation_IsRunning = False
            MessageBox.Show("Automatic schedule expiration has stopped.")
        End If
    End Sub

    ' Event handler for the timer
    Private Sub ScheduleTimer_Elapsed(sender As Object, e As ElapsedEventArgs)
        CheckAndExpireSchedules()
    End Sub

    ' Main Method for checking and expiring schedules
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
                Else
                    reader.Close()
                End If
            End Using
        Finally
            ' Ensure the database connection is closed
            If ConnectionModule.conn.State = ConnectionState.Open Then
                ConnectionModule.conn.Close()
            End If
        End Try
    End Sub
End Module
