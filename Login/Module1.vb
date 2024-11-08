Imports MySql.Data.MySqlClient ' Ensure this is imported

Module ConnectionModule
    Public conn As MySqlConnection ' Declare the MySqlConnection object

    Public Sub DbConnect()
        Dim dbname As String = "project" ' Database name
        Dim username As String = "root" ' Database username
        Dim password As String = "password" ' Database password
        Dim server As String = "127.0.0.1" ' Server address (localhost)

        ' Initialize the connection if it is Nothing
        If conn Is Nothing Then
            conn = New MySqlConnection() ' Create a new MySqlConnection object
        End If

        ' Set up the connection string
        conn.ConnectionString = $"server={server};user id={username};password={password};database={dbname}"

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
                MsgBox("MySQL Connected") ' Show success message
            End If
        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Optional: Method to close the database connection
    Public Sub DbDisconnect()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close() ' Close the connection
            MsgBox("MySQL Connection Closed") ' Show closure message
        End If
    End Sub
End Module
