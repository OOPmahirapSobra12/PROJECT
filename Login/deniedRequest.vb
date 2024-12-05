Imports MySql.Data.MySqlClient

Module DeniedRequest
    ' Method to process and transfer denied requests
    Public Sub ProcessDeniedRequests()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Query to select denied requests
            Dim selectQuery As String =
                "SELECT ID, room_code, request FROM requests WHERE request_type = 'denied'"

            ' Query to insert denied requests into denied_request
            Dim insertQuery As String =
                "INSERT INTO denied_request (ID, room_code, request) " &
                "SELECT ID, room_code, request FROM requests WHERE request_type = 'denied'"

            ' Query to delete denied requests from requests
            Dim deleteQuery As String =
                "DELETE FROM requests WHERE request_type = 'denied'"

            ' Execute the select query to check if there are any denied requests
            Using cmd As New MySqlCommand(selectQuery, ConnectionModule.conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close() ' Close the reader before executing the next queries

                    ' Insert into denied_request
                    Using insertCmd As New MySqlCommand(insertQuery, ConnectionModule.conn)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Delete from requests
                    Using deleteCmd As New MySqlCommand(deleteQuery, ConnectionModule.conn)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    Console.WriteLine("Denied requests moved successfully.")
                Else
                    reader.Close()
                    Console.WriteLine("No denied requests found.")
                End If
            End Using
        Catch ex As MySqlException
            Console.WriteLine("MySQL Error: " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module

