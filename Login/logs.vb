Imports MySql.Data.MySqlClient ' Ensure this is imported

Module logs
    Public L_ID As String
    Public Action As String
    Public action2 As String
    Public L_Course As String
    Public L_Section As String

    Public Sub logging_log()
        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            Dim query As String = ""
            If Action = "login" Then
                ' Check the latest entry for this user
                query = "SELECT log_out_date, log_out_time FROM login_history WHERE ID=@U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            ' Proceed with a new login entry
                            reader.Close()
                            query = "INSERT INTO login_history (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                            Dim insertCommand As New MySqlCommand(query, conn)
                            insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                            insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("yyyy-MM-dd"))
                            insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("HH:mm:ss"))
                            insertCommand.ExecuteNonQuery()
                        Else
                            ' Error: Previous log not properly closed
                            MsgBox("Error: Previous login session was not properly closed. Please contact admin.")
                            Return
                        End If
                    Else
                        ' No previous entry, insert a new login
                        reader.Close()
                        query = "INSERT INTO login_history (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                        Dim insertCommand As New MySqlCommand(query, conn)
                        insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                        insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("yyyy-MM-dd"))
                        insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("HH:mm:ss"))
                        insertCommand.ExecuteNonQuery()
                    End If
                End Using

            ElseIf Action = "logout" Then
                ' Update the latest log entry with logout time and date
                query = "SELECT log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE ID = @U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            ' Error: Log already has logout details
                            MsgBox("Error: User is already logged out.")
                            Return
                        Else
                            ' Update with logout details
                            Dim logInDate = reader("log_in_date").ToString()
                            Dim logInTime = reader("log_in_time").ToString()
                            reader.Close()
                            query = "UPDATE login_history 
                                    SET log_out_date = @log_out_date, log_out_time = @log_out_time
                                    WHERE ID = @U_ID AND log_in_date = @log_in_date AND log_in_time = @log_in_time;
"
                            Dim updateCommand As New MySqlCommand(query, conn)
                            updateCommand.Parameters.AddWithValue("@U_ID", L_ID)
                            updateCommand.Parameters.AddWithValue("@log_out_date", logOutDate)
                            updateCommand.Parameters.AddWithValue("@log_out_time", logOutTime)
                            updateCommand.Parameters.AddWithValue("@log_in_date", logInTime)
                            updateCommand.Parameters.AddWithValue("@log_in_time", logInTime)
                            updateCommand.ExecuteNonQuery()
                        End If
                    Else
                        MsgBox("Error: No login entry found for this user.")
                    End If
                End Using
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

    Public Sub staff_requestapproval_logs()
        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            Dim query As String = ""
            If action2 = "login" Then
                ' Check the latest entry for this user
                query = "SELECT log_out_date, log_out_time FROM staff_request_log WHERE ID=@U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            ' Proceed with a new login entry
                            reader.Close()
                            query = "INSERT INTO staff_request_log (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                            Dim insertCommand As New MySqlCommand(query, conn)
                            insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                            insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("yyyy-MM-dd"))
                            insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("HH:mm:ss"))
                            insertCommand.ExecuteNonQuery()
                        Else
                            ' Error: Previous log not properly closed
                            MsgBox("Error: Previous request session was not properly closed. Please contact admin.")
                            Return
                        End If
                    Else
                        ' No previous entry, insert a new login
                        reader.Close()
                        query = "INSERT INTO staff_request_log (ID, log_in_date, log_in_time) VALUES (@U_ID, @log_in_date, @log_in_time)"
                        Dim insertCommand As New MySqlCommand(query, conn)
                        insertCommand.Parameters.AddWithValue("@U_ID", L_ID)
                        insertCommand.Parameters.AddWithValue("@log_in_date", DateTime.Now.ToString("yyyy-MM-dd"))
                        insertCommand.Parameters.AddWithValue("@log_in_time", DateTime.Now.ToString("HH:mm:ss"))
                        insertCommand.ExecuteNonQuery()
                    End If
                End Using

            ElseIf action2 = "logout" Then
                ' Update the latest log entry with logout time and date
                query = "SELECT log_in_date, log_in_time, log_out_date, log_out_time FROM staff_request_log WHERE ID=@U_ID ORDER BY log_history_code DESC LIMIT 1"
                Dim checkCommand As New MySqlCommand(query, conn)
                checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

                Using reader As MySqlDataReader = checkCommand.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim logOutDate = reader("log_out_date").ToString()
                        Dim logOutTime = reader("log_out_time").ToString()

                        If Not String.IsNullOrEmpty(logOutDate) AndAlso Not String.IsNullOrEmpty(logOutTime) Then
                            ' Error: Log already has logout details
                            MsgBox("Error: User is already logged out.")
                            Return
                        Else
                            ' Update with logout details
                            Dim logInDate = reader("log_in_date").ToString()
                            Dim logInTime = reader("log_in_time").ToString()
                            reader.Close()

                            query = "UPDATE staff_request_log SET log_out_date=@log_out_date, log_out_time=@log_out_time WHERE ID=@U_ID AND log_in_date=@log_in_date AND log_in_time=@log_in_time"
                            Dim updateCommand As New MySqlCommand(query, conn)
                            updateCommand.Parameters.AddWithValue("@U_ID", L_ID)
                            updateCommand.Parameters.AddWithValue("@log_out_date", DateTime.Now.ToString("yyyy-MM-dd"))
                            updateCommand.Parameters.AddWithValue("@log_out_time", DateTime.Now.ToString("HH:mm:ss"))
                            updateCommand.Parameters.AddWithValue("@log_in_date", logInDate)
                            updateCommand.Parameters.AddWithValue("@log_in_time", logInTime)
                            updateCommand.ExecuteNonQuery()
                        End If
                    Else
                        MsgBox("Error: No login entry found for this user.")
                    End If
                End Using
            Else
                MsgBox("Invalid action specified for logging.")
                Return
            End If
        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

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

    Public Sub sectionfinder()
        L_ID = U_ID
        section = "" ' Clear the section initially

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect() ' Ensure the connection is open
            End If

            Dim query As String = "SELECT sections FROM accounts WHERE ID = @U_ID LIMIT 1"
            Dim checkCommand As New MySqlCommand(query, conn)
            checkCommand.Parameters.AddWithValue("@U_ID", L_ID)

            Dim result = checkCommand.ExecuteScalar() ' Fetch the section as a single value

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
