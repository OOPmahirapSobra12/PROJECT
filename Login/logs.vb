﻿Imports MySql.Data.MySqlClient ' Ensure this is imported

Module logs
    Public L_ID As String
    Public Action As String
    Public L_Course As String
    Public L_Section As String

    ' Method handling login/logout functionality
    Public Sub logging_log()
        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect() ' Ensure the connection is open
            End If

            Dim query As String = ""
            If Action = "login" Then
                ' Check if the user has a previous log-out entry
                query = "SELECT log_out_date, log_out_time FROM login_history WHERE ID=@U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            ' Proceed with a new login entry if the previous session has been logged out
                            reader.Close()
                            query = "INSERT INTO login_history (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                            Dim insertCommand As New MySqlCommand(query, conn)
                            insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                            insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("MM-dd-yyyy"))
                            insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("hh:mm:ss"))
                            insertCommand.ExecuteNonQuery()
                        Else
                            ' Error: Previous log-out has not been properly recorded
                            MsgBox("Error: Previous login session was not properly closed. Please contact admin.")
                            Return
                        End If
                    Else
                        ' No previous entry, insert a new login
                        reader.Close()
                        query = "INSERT INTO login_history (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                        Dim insertCommand As New MySqlCommand(query, conn)
                        insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                        insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("MM-dd-yyyy"))
                        insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("hh:mm:tt"))
                        insertCommand.ExecuteNonQuery()
                    End If
                End Using

            ElseIf Action = "logout" Then
                ' Retrieve the latest log entry for this user
                query = "SELECT log_history_code, log_out_date, log_out_time FROM login_history WHERE ID = @U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Dim logHistoryCode As Integer = -1
                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        logHistoryCode = reader("log_history_code")
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()
                        reader.Close()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            MsgBox("Error: User is already logged out.")
                            Return
                        End If
                    Else
                        MsgBox("Error: No login entry found for this user.")
                        Return
                    End If
                End Using

                If logHistoryCode <> -1 Then
                    ' Update the latest log entry with logout details
                    query = "UPDATE login_history SET log_out_date = @log_out_date, log_out_time = @log_out_time WHERE log_history_code = @log_history_code"
                    Dim updateCommand As New MySqlCommand(query, conn)
                    updateCommand.Parameters.AddWithValue("@log_out_date", DateTime.Now.ToString("MM-dd-yyyy"))
                    updateCommand.Parameters.AddWithValue("@log_out_time", DateTime.Now.ToString("hh:mm:tt"))
                    updateCommand.Parameters.AddWithValue("@log_history_code", logHistoryCode)
                    updateCommand.ExecuteNonQuery()

                    MsgBox("Logout successful.")
                Else
                    MsgBox("Error: Unable to identify the latest login entry.")
                End If
            Else
                MsgBox("Invalid action specified for logging.")
                Return
            End If
        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            L_ID = Nothing
            Action = Nothing
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Sub staff_requestapproval_login()
        Try
            ' Ensure the database connection is open
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            ' Insert new login
            Dim query As String = "INSERT INTO staff_request_log (ID, log_in_date, log_in_time) 
                               VALUES (@U_ID, @log_in_date, @log_in_time)"
            Using insertCommand As New MySqlCommand(query, conn)
                insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("MM-dd-yyyy"))
                insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("hh:mm tt"))
                insertCommand.ExecuteNonQuery()
            End Using

        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    ' Method for fetching course based on user ID
    Public course As String
    Public section As String

    Public Sub coursefinder()
        course = "" ' Clear the course initially

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect() ' Ensure the connection is open
            End If

            Dim query As String = "SELECT course_name FROM accounts WHERE ID = @U_ID LIMIT 1"
            Dim checkCommand As New MySqlCommand(query, conn)
            checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

            Dim result = checkCommand.ExecuteScalar() ' Fetch the course as a single value

            If result IsNot Nothing Then
                course = result.ToString() ' Set the course value
            Else
                If access = "mid" Then
                    course = "Staff"
                ElseIf access = "admin" Then
                    course = "Admin"
                End If
            End If

        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Ensure the connection is closed
            End If
        End Try
    End Sub

    ' Method for fetching section based on user ID
    Public Sub sectionfinder()
        L_ID = U_ID
        section = "" ' Clear the section first

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect() ' Ensure the connection is open
            End If

            Dim query As String = "SELECT sections FROM accounts WHERE ID = @U_ID LIMIT 1"
            Dim checkCommand As New MySqlCommand(query, conn)
            checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

            Dim result = checkCommand.ExecuteScalar() ' Retrieve the section as a single value

            If result IsNot Nothing Then
                section = result.ToString() ' Set the section value
            Else
                If access = "mid" Then
                    section = "Staff"
                ElseIf access = "admin" Then
                    section = "Admin"
                End If
            End If

        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Ensure the connection is closed
            End If
        End Try
    End Sub
End Module