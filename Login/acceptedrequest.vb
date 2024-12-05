Imports MySql.Data.MySqlClient

Module AcceptedRequest
    ' Method to process and transfer accepted requests
    Public Sub ProcessAcceptedRequests()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Query to select accepted requests (modify as per your condition for "accepted")
            Dim selectQuery As String =
                "SELECT ID, room_code, request FROM requests WHERE request_type = 'accepted'"

            ' Query to insert accepted requests into accepted_request
            Dim insertQuery As String =
                "INSERT INTO accepted_request (ID, room_code, request) " &
                "SELECT ID, room_code, request FROM requests WHERE request_type = 'accepted'"

            ' Query to delete accepted requests from requests
            Dim deleteQuery As String =
                "DELETE FROM requests WHERE request_type = 'accepted'"

            ' Execute the select query to check if there are any accepted requests
            Using cmd As New MySqlCommand(selectQuery, ConnectionModule.conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close() ' Close the reader before executing the next queries

                    ' Insert into accepted_request
                    Using insertCmd As New MySqlCommand(insertQuery, ConnectionModule.conn)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Delete from requests
                    Using deleteCmd As New MySqlCommand(deleteQuery, ConnectionModule.conn)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    Console.WriteLine("Accepted requests moved successfully.")
                Else
                    reader.Close()
                    Console.WriteLine("No accepted requests found.")
                End If
            End Using
        Catch ex As MySqlException
            Console.WriteLine("MySQL Error: " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module
