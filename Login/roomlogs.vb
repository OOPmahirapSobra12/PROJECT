Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class roomlogs

    ' Method to load room logs into the DataGridView
    Private Sub LoadRoomLogs()
        ' Query to select necessary columns from room_logshistory table and join with accounts table
        Dim query As String = "SELECT l.ID, a.username, l.log_in_date, l.log_in_time, l.log_out_date, l.log_out_time, l.room_code " &
                          "FROM room_logshistory l " &
                          "JOIN accounts a ON l.ID = a.ID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Open the connection if it's not already open
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Populate the DataTable with data from the room_logshistory table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns in DataGridView
            DGVroomlogs.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVroomlogs.DataSource = table

            ' Manually map the data to the existing columns in DGVroomlogs
            For Each column As DataGridViewColumn In DGVroomlogs.Columns
                If column.Name = "username" Then
                    column.DataPropertyName = "username" ' Bind username from the query
                ElseIf column.Name = "room" Then
                    column.DataPropertyName = "room_code" ' Bind room_code from the query
                ElseIf column.Name = "datein" Then
                    column.DataPropertyName = "log_in_date"
                ElseIf column.Name = "timein" Then
                    column.DataPropertyName = "log_in_time"
                ElseIf column.Name = "dateout" Then
                    column.DataPropertyName = "log_out_date"
                ElseIf column.Name = "timeout" Then
                    column.DataPropertyName = "log_out_time"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving room logs: " & ex.Message)
        Finally
            ' Close the connection after operation
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Search function based on the selected category
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If String.IsNullOrEmpty(txtsearchbox.Text) Then
            LoadRoomLogs()
        Else
            Dim category As String = cbosearch.Text
            Dim search As String = txtsearchbox.Text

            Dim query As String = ""

            ' Construct the SQL query based on the selected category
            Select Case category
                Case "Username"
                    query = "SELECT l.ID, a.username, l.log_in_date, l.log_in_time, l.log_out_date, l.log_out_time, l.room_code " &
                            "FROM room_logshistory l " &
                            "JOIN accounts a ON l.ID = a.ID " &
                            "WHERE LOWER(a.username) LIKE LOWER(@search)"
                Case "Date In"
                    query = "SELECT * FROM room_logshistory WHERE log_in_date LIKE @search"
                Case "Date Out"
                    query = "SELECT * FROM room_logshistory WHERE log_out_date LIKE @search"
                Case "Time In"
                    query = "SELECT * FROM room_logshistory WHERE log_in_time LIKE @search"
                Case "Time Out"
                    query = "SELECT * FROM room_logshistory WHERE log_out_time LIKE @search"
                Case Else
                    MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
            End Select

            ' Create the MySqlCommand object
            Dim command As New MySqlCommand(query, conn)

            ' Add the parameter for the search term, using '%' for matching
            command.Parameters.AddWithValue("@search", "%" & search & "%")

            Dim table As New DataTable()

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Bind the DataTable to the DataGridView
                DGVroomlogs.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving logs: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    ' Method to load the form and initialize data
    Private Sub roomlogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure connection is closed before connecting
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect() ' Assuming this method initializes the connection
        LoadRoomLogs() ' Load room logs into DataGridView
        cbosearch.SelectedIndex = 0 ' Set default search category
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
End Class