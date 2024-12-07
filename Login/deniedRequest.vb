Imports MySql.Data.MySqlClient

Module DeniedRequest
    ' Variables to store request details
    Public R_ID As String
    Public R_requestID As String

    Public Sub ProcessDeniedRequests()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Query to select denied requests
            Dim selectQuery As String =
                "SELECT * FROM requests WHERE ID = @ID AND requestID = @requestID"

            ' Query to insert denied requests into denied_request
            Dim insertQuery As String =
                "INSERT INTO denied_request (ID, requestID, request, request_type) " &
                "VALUES (@ID, @requestID, @request, @type)"

            ' Query to delete denied requests from requests
            Dim deleteQuery As String =
                "DELETE FROM requests WHERE ID = @ID AND requestID = @requestID"

            ' Create a MySqlCommand object for the select query
            Using selectCommand As New MySqlCommand(selectQuery, ConnectionModule.conn)
                selectCommand.Parameters.AddWithValue("@ID", R_ID)
                selectCommand.Parameters.AddWithValue("@requestID", R_requestID)

                ' Execute the select query and read results
                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim request As String = reader("request").ToString()
                            Dim requestType As String = "Denied"

                            ' Close the reader before executing another query
                            reader.Close()

                            ' Insert the denied request into the denied_request table
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
                        Console.WriteLine("No matching request found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Log or display the exception details
            Console.WriteLine("An error occurred: " & ex.Message)
        Finally
            ' Ensure the database connection is closed
            ConnectionModule.DbDisconnect()
        End Try
    End Sub
End Module


