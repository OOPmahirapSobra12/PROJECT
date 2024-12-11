Imports MySql.Data.MySqlClient

Module AcceptedRequest_automation ' Module name should be properly capitalized (Optional but recommended)
    Public R_ID As String
    Public R_requestID As String
    'Processing and transferring accepted requests 
    Public Sub ProcessAcceptedRequests()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Query to select accepted requests
            Dim selectQuery As String =
                "SELECT * FROM requests WHERE ID = @ID AND requestID = @requestID AND request_type = 'accepted'"

            ' Query to insert accepted requests into accepted_request
            Dim insertQuery As String =
                "INSERT INTO accepted_request (ID, requestID, request, request_type) " &
                "VALUES (@ID, @requestID, @request, @type)"

            ' Query to delete accepted requests from requests
            Dim deleteQuery As String =
                "DELETE FROM requests WHERE ID = @ID AND requestID = @requestID AND request_type = 'accepted'"

            ' Create a MySqlCommand object for the select query
            Using selectCommand As New MySqlCommand(selectQuery, ConnectionModule.conn)
                selectCommand.Parameters.AddWithValue("@ID", R_ID)
                selectCommand.Parameters.AddWithValue("@requestID", R_requestID)

                ' Execute the select query and read results
                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim request As String = reader("request").ToString()
                            Dim requestType As String = "Accepted"

                            ' Close the reader before executing another query
                            reader.Close()

                            ' Insert the accepted request into the accepted_request table
                            Using insertCommand As New MySqlCommand(insertQuery, ConnectionModule.conn)
                                insertCommand.Parameters.AddWithValue("@ID", R_ID)
                                insertCommand.Parameters.AddWithValue("@requestID", R_requestID)
                                insertCommand.Parameters.AddWithValue("@request", request)
                                insertCommand.Parameters.AddWithValue("@type", requestType)
                                insertCommand.ExecuteNonQuery()
                            End Using

                            ' Delete the request from the requests table
                            Using deleteCommand As New MySqlCommand(deleteQuery, ConnectionModule.conn)
                                deleteCommand.Parameters.AddWithValue("@ID", R_ID)
                                deleteCommand.Parameters.AddWithValue("@requestID", R_requestID)
                                deleteCommand.ExecuteNonQuery()
                            End Using
                        End While
                    Else
                        Console.WriteLine("No matching accepted request found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Display the exception details
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            ' Ensure the database connection is closed
            ConnectionModule.DbDisconnect()
        End Try
    End Sub

End Module
