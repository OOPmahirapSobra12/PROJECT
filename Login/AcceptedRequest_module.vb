Imports MySql.Data.MySqlClient

Module AcceptedRequest_automation ' Module name should be properly capitalized (Optional but recommended)

    ' Method to process and transfer accepted requests
    Public Sub ProcessAcceptedRequests()
        Try
            ' Ensure the database connection is open
            ConnectionModule.DbConnect()

            ' Query to insert accepted requests into accepted_request
            Dim insertQuery As String =
                "INSERT INTO accepted_request (ID, room_code, request) " &
                "SELECT ID, room_code, request FROM requests WHERE request_type = 'accepted'"

            ' Query to delete accepted requests from requests
            Dim deleteQuery As String =
                "DELETE FROM requests WHERE request_type = 'accepted'"

            ' Use a transaction to ensure both operations happen atomically
            Using transaction As MySqlTransaction = ConnectionModule.conn.BeginTransaction()

                Try
                    ' Insert into accepted_request
                    Using insertCmd As New MySqlCommand(insertQuery, ConnectionModule.conn, transaction)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Delete from requests
                    Using deleteCmd As New MySqlCommand(deleteQuery, ConnectionModule.conn, transaction)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    ' Commit the transaction
                    transaction.Commit()

                    Console.WriteLine("Accepted requests moved successfully.")
                Catch ex As MySqlException
                    ' In case of error, rollback the transaction
                    transaction.Rollback()
                    Console.WriteLine("MySQL Error: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            ' Catch general exceptions
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module
