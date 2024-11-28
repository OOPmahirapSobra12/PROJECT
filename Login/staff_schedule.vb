Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staff_schedule
    ' Load data into DataGridView
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State <> ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        loadtable()
        formatloader()
    End Sub

    Public Sub formatloader()
        cboType.SelectedIndex = 0
    End Sub

    Public Sub loadtable()
        ' Query to load data from both sched and schedtemp tables, including shed_id
        Dim sqlQuery As String = "
        SELECT 
            sched.shed_id,
            sched.room_code, 
            roomlist.room_name, 
            sched.detail, 
            sched.room_day, 
            sched.room_time_in, 
            sched.room_time_out, 
            NULL AS room_date, 
            roomlist.building
        FROM sched
            JOIN roomlist ON sched.room_code = roomlist.room_code

        UNION

        SELECT 
            schedtemp.shed_id,
            schedtemp.room_code, 
            roomlist.room_name, 
            schedtemp.detail, 
            NULL AS room_day, 
            schedtemp.room_time_in, 
            schedtemp.room_time_out, 
            schedtemp.room_date, 
            roomlist.building
        FROM schedtemp
            JOIN roomlist ON schedtemp.room_code = roomlist.room_code;"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the data into the DataTable
            dataAdapter.Fill(dataTable)

            ' Loop through each row to apply the day/date logic
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    ' If room_date is not empty, set room_day to "N/A"
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    ' If room_day is not empty, set room_date to "N/A"
                    row("room_date") = "N/A"
                End If
            Next

            DGVschedule.AutoGenerateColumns = False

            ' Bind the populated DataTable to the DataGridView
            DGVschedule.DataSource = dataTable

            ' Set the correct data bindings for each column in the DataGridView
            DGVschedule.Columns("sched_code").DataPropertyName = "shed_id"  ' Bind shed_id to sched_code
            DGVschedule.Columns("room_code").DataPropertyName = "room_code"
            DGVschedule.Columns("room_name").DataPropertyName = "room_name"
            DGVschedule.Columns("detail").DataPropertyName = "detail"
            DGVschedule.Columns("s_day").DataPropertyName = "room_day"
            DGVschedule.Columns("s_date").DataPropertyName = "room_date"
            DGVschedule.Columns("time_in").DataPropertyName = "room_time_in"
            DGVschedule.Columns("time_out").DataPropertyName = "room_time_out"

        Catch ex As Exception
            MessageBox.Show("Error loading table data: " & ex.Message)
        Finally
            ' Ensure to close the connection after the operation
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate that the user has entered a search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected category and search term
        Dim selectedCategory As String = cboType.SelectedItem.ToString()
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Construct the base SQL query
        Dim sqlQuery As String = "
        SELECT 
            sched.shed_id,
            sched.room_code, 
            roomlist.room_name, 
            sched.detail, 
            sched.room_day, 
            sched.room_time_in, 
            sched.room_time_out, 
            NULL AS room_date, 
            roomlist.building
        FROM sched
            JOIN roomlist ON sched.room_code = roomlist.room_code

        UNION

        SELECT 
            schedtemp.shed_id,
            schedtemp.room_code, 
            roomlist.room_name, 
            schedtemp.detail, 
            NULL AS room_day, 
            schedtemp.room_time_in, 
            schedtemp.room_time_out, 
            schedtemp.room_date, 
            roomlist.building
        FROM schedtemp
            JOIN roomlist ON schedtemp.room_code = roomlist.room_code
        WHERE {0} LIKE @searchTerm;"

        ' Add WHERE clause for filtering based on the selected category
        Dim columnMap As New Dictionary(Of String, String) From {
            {"Schedule ID", "shed_id"},
            {"Room Code", "room_code"},
            {"Room Name", "room_name"},
            {"Detail", "detail"},
            {"Day", "room_day"},
            {"Date", "room_date"}
        }

        If Not columnMap.ContainsKey(selectedCategory) Then
            MessageBox.Show("Invalid search category selected.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Replace placeholder in the query with the appropriate column name
        sqlQuery = String.Format(sqlQuery, columnMap(selectedCategory))

        ' Prepare the search term for a wildcard search
        Dim parameterValue As String = "%" & searchTerm & "%"

        ' Create a new DataAdapter to execute the query
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", parameterValue)

        ' Create a DataTable to hold the search results
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with search results
            dataAdapter.Fill(dataTable)

            ' Handle room_day/room_date logic in results
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    row("room_date") = "N/A"
                End If
            Next

            ' Bind the DataTable to the DataGridView
            DGVschedule.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnrequest_Click(sender As Object, e As EventArgs) Handles btnrequest.Click
        staff_request_add.Show()
    End Sub

    Private Sub btnrequest_modify_Click(sender As Object, e As EventArgs) Handles btnrequest_modify.Click
        staff_request_modify.Show()
    End Sub
End Class
