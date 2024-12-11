Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staff_schedule
    ' Load data into DataGridView
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure connection is closed before reconnecting
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        ' Connect to the database
        DbConnect()

        ' Load the schedule table and set default values
        loadtable()
        formatloader()
    End Sub

    ' Initialize default values in controls
    Public Sub formatloader()
        cboType.SelectedIndex = 0 ' Set default selection for combo box
    End Sub

    ' Load schedule data into DataGridView
    Public Sub loadtable()
        ' Query to load data from both sched and schedtemp tables, joining with the subjects table to get subject_name
        Dim sqlQuery As String = " SELECT 
                                    sched.shed_id, 
                                    sched.room_code, 
                                    roomlist.room_name, 
                                    NULL AS room_date, 
                                    sched.room_day, 
                                    sched.room_time_in, 
                                    sched.room_time_out, 
                                    sched.course_name, 
                                    sched.sections, 
                                    listofsubjects.subject_name
                                FROM sched
                                JOIN listofsubjects ON sched.subject_name = listofsubjects.subject_name
                                JOIN roomlist ON sched.room_code = roomlist.room_code

                                UNION ALL

                                SELECT 
                                    schedtemp.shedtemp_id as shed_id, 
                                    schedtemp.room_code, 
                                    roomlist.room_name, 
                                    schedtemp.room_date, 
                                    NULL AS room_day, 
                                    schedtemp.room_time_in, 
                                    schedtemp.room_time_out, 
                                    schedtemp.course_name, 
                                    schedtemp.sections, 
                                    listofsubjects.subject_name
                                FROM schedtemp
                                JOIN listofsubjects ON schedtemp.subject_name = listofsubjects.subject_name
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

            ' Loop through each row to handle `room_day` and `room_date` logic
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    ' If room_date is not empty, set room_day to "N/A"
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    ' If room_day is not empty, set room_date to "N/A"
                    row("room_date") = "N/A"
                End If
            Next

            ' Configure the DataGridView for proper column bindings
            DGVschedules.AutoGenerateColumns = False

            ' Bind the populated DataTable to the DataGridView
            DGVschedules.DataSource = dataTable

            ' Set the correct data bindings for each column in the DataGridView
            DGVschedules.Columns("sched_code").DataPropertyName = "shed_id"
            DGVschedules.Columns("room_code").DataPropertyName = "room_code"
            DGVschedules.Columns("room").DataPropertyName = "room_name"
            DGVschedules.Columns("s_day").DataPropertyName = "room_day"
            DGVschedules.Columns("s_date").DataPropertyName = "room_date"
            DGVschedules.Columns("time_in").DataPropertyName = "room_time_in"
            DGVschedules.Columns("time_out").DataPropertyName = "room_time_out"
            DGVschedules.Columns("course").DataPropertyName = "course_name"
            DGVschedules.Columns("section").DataPropertyName = "sections"
            DGVschedules.Columns("subject").DataPropertyName = "subject_name"

        Catch ex As Exception
            MessageBox.Show("Error loading table data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure to close the connection after the operation
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '  Back button 
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    ' Search butto
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            loadtable()
            Return
        End If

        ' Get selected category and search term
        Dim selectedCategory As String = cboType.SelectedItem.ToString()
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Map column names to search categories
        Dim columnMap As New Dictionary(Of String, String) From {
            {"Schedule Code", "shed_id"},
            {"Room Code", "room_code"},
            {"Room Name", "room_name"},
            {"Subject", "subject_name"},
            {"Course", "course_name"},
            {"Section", "sections"},
            {"Day", "room_day"},
            {"Date", "room_date"},
            {"Time In", "room_time_in"},
            {"Time Out", "room_time_out"}
        }

        If Not columnMap.ContainsKey(selectedCategory) Then
            MessageBox.Show("Invalid search category selected.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Construct SQL query with search filter
        Dim sqlQuery As String = "SELECT 
                                    sched.shed_id, 
                                    sched.room_code, 
                                    roomlist.room_name, 
                                    sched.room_day, " &
                                    "sched.room_time_in, 
                                    sched.room_time_out, 
                                    NULL AS room_date, 
                                    sched.subject_name, " &
                                    "sched.course_name, 
                                    sched.sections " &
                                "FROM sched " &
                                "JOIN roomlist ON sched.room_code = roomlist.room_code " &
                                "WHERE " & columnMap(selectedCategory) & " LIKE @searchTerm " &
                                "UNION ALL " &
                                "SELECT 
                                    schedtemp.shedtemp_id as shed_id, 
                                    schedtemp.room_code, 
                                    roomlist.room_name, 
                                    NULL AS room_day, " &
                                    "schedtemp.room_time_in, 
                                    schedtemp.room_time_out, 
                                    schedtemp.room_date, 
                                    schedtemp.subject_name, " &
                                    "schedtemp.course_name, 
                                    schedtemp.sections " &
                                "FROM schedtemp " &
                                "JOIN roomlist ON schedtemp.room_code = roomlist.room_code " &
                                "WHERE " & columnMap(selectedCategory) & " LIKE @searchTerm;"

        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill DataTable with search results
            dataAdapter.Fill(dataTable)

            ' Adjust rows to display "N/A" for empty date/day
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    row("room_date") = "N/A"
                End If
            Next

            ' Bind DataTable to DataGridView
            DGVschedules.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    '  Request button 
    Private Sub btnrequest_Click(sender As Object, e As EventArgs) Handles btnrequest.Click
        staffschedule_request_add.Show()
    End Sub

    ' Modify Request button 
    Private Sub btnrequest_modify_Click(sender As Object, e As EventArgs) Handles btnrequest_modify.Click
        ' Ensure a row is selected
        If DGVschedules.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DGVschedules.SelectedRows(0)

                ' Extract values from selected row
                Dim shedId As String = If(selectedRow.Cells("sched_code").Value?.ToString(), String.Empty)
                Dim roomCode As String = If(selectedRow.Cells("room_code").Value?.ToString(), String.Empty)
                Dim roomName As String = If(selectedRow.Cells("room").Value?.ToString(), String.Empty)
                Dim roomDay As String = If(selectedRow.Cells("s_day").Value?.ToString(), String.Empty)
                Dim roomDate As String = If(selectedRow.Cells("s_date").Value?.ToString(), String.Empty)
                Dim timeIn As String = If(selectedRow.Cells("time_in").Value?.ToString(), String.Empty)
                Dim timeOut As String = If(selectedRow.Cells("time_out").Value?.ToString(), String.Empty)
                Dim subject As String = If(selectedRow.Cells("subject").Value?.ToString(), String.Empty)
                Dim course As String = If(selectedRow.Cells("course").Value?.ToString(), String.Empty)
                Dim section As String = If(selectedRow.Cells("section").Value?.ToString(), String.Empty)

                ' Pass data to the modify request form
                staffschedule_request_modify.Show()
                staffschedule_request_modify.schedulereciever(shedId, roomCode, roomName, subject, timeIn, timeOut, course, section, roomDay, roomDate)
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Notify user to select a row
            MessageBox.Show("Please select a schedule from the list.", "No Schedule Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
