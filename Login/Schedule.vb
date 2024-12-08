Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Schedule
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
        cborcodeloader()
    End Sub

    Public Sub cborcodeloader()
        ' SQL Query to select room_code from roomlist
        Dim sqlQuery As String = "SELECT room_code FROM roomlist"
        Dim command As New MySqlCommand(sqlQuery, conn)

        Try
            ' Open the database connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the query and read the data
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Temporarily hold room codes
            Dim roomCodes As New List(Of String)

            ' Add the default "Choose" option at the start
            roomCodes.Add("Choose")

            ' Loop through the result set and add room_code to the list
            While reader.Read()
                roomCodes.Add(reader("room_code").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading room codes: " & ex.Message)
        Finally
            ' Close the reader and connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

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
                                    schedtemp.shed_id, 
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


    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Check if a row is selected in DGVschedule
        If DGVschedules.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DGVschedules.SelectedRows(0)

                ' Safely extract values from the selected row
                Dim shedId As String = If(selectedRow.Cells("sched_code").Value?.ToString(), String.Empty)
                Dim roomCode As String = If(selectedRow.Cells("room_code").Value?.ToString(), String.Empty)
                Dim roomName As String = If(selectedRow.Cells("room").Value?.ToString(), String.Empty)
                Dim detail As String = If(selectedRow.Cells("detail").Value?.ToString(), String.Empty)
                Dim roomDay As String = If(selectedRow.Cells("s_day").Value?.ToString(), String.Empty)
                Dim roomDate As String = If(selectedRow.Cells("s_date").Value?.ToString(), String.Empty)
                Dim timeIn As String = If(selectedRow.Cells("time_in").Value?.ToString(), String.Empty)
                Dim timeOut As String = If(selectedRow.Cells("time_out").Value?.ToString(), String.Empty)
                Dim subject As String = If(selectedRow.Cells("subject").Value?.ToString(), String.Empty)
                Dim course As String = If(selectedRow.Cells("course").Value?.ToString(), String.Empty)
                Dim section As String = If(selectedRow.Cells("section").Value?.ToString(), String.Empty)

                ' Call the schedulereciever method in the scheduleaddmodify form
                Dim scheduleForm As New scheduleaddmodify()
                scheduleForm.schedulereciever(shedId, roomCode, roomName, subject, timeIn, timeOut, course, section, roomDay, roomDate)
                scheduleForm.Show() ' Display the form
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Inform the user to select a row
            MessageBox.Show("Please select a room from the list.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Ensure a row is selected before proceeding
        If DGVschedules.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a schedule to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the shed_id, s_date, and s_day from the selected row in the table
        Dim shedId As String = DGVschedules.SelectedRows(0).Cells("shed_id").Value.ToString()
        Dim sDate As Object = DGVschedules.SelectedRows(0).Cells("s_date").Value
        Dim sDay As Object = DGVschedules.SelectedRows(0).Cells("s_day").Value

        ' Confirm with the user before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' Determine whether to delete from `sched` or `schedtemp`
        Dim sqlDelete As String
        If sDate IsNot Nothing AndAlso Not IsDBNull(sDate) AndAlso Not String.IsNullOrEmpty(sDate.ToString()) Then
            ' If s_date is populated, delete from `schedtemp`
            sqlDelete = "DELETE FROM schedtemp WHERE shed_id = @shed_id"
        ElseIf sDay IsNot Nothing AndAlso Not IsDBNull(sDay) AndAlso Not String.IsNullOrEmpty(sDay.ToString()) Then
            ' If s_day is populated, delete from `sched`
            sqlDelete = "DELETE FROM sched WHERE shed_id = @shed_id"
        Else
            MessageBox.Show("The selected schedule does not have valid s_date or s_day data.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create the command for deleting from the appropriate table
        Dim command As New MySqlCommand(sqlDelete, conn)
        command.Parameters.AddWithValue("@shed_id", shedId)

        ' Execute the delete
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            command.ExecuteNonQuery()
            MessageBox.Show("Schedule deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadtable() ' Reload the table data after deletion
        Catch ex As Exception
            MessageBox.Show("Error deleting schedule: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
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
            sched.subject_name,
            sched.course_name,
            sched.sections
        FROM sched
        JOIN roomlist ON sched.room_code = roomlist.room_code 
                and listofsubjects ON sched.subject_name = listofsubjects.subject_name

        UNION ALL

        SELECT 
            schedtemp.shed_id,
            schedtemp.room_code, 
            roomlist.room_name, 
            schedtemp.detail, 
            NULL AS room_day, 
            schedtemp.room_time_in, 
            schedtemp.room_time_out, 
            schedtemp.room_date, 
            schedtemp.subject_name,
            schedtemp.course_name,
            schedtemp.sections
        FROM schedtemp
        JOIN roomlist ON schedtemp.room_code = roomlist.room_code 
                and listofsubjects ON sched.subject_name = listofsubjects.subject_name
        WHERE {0} LIKE @searchTerm;"

        ' Add WHERE clause for filtering based on the selected category
        Dim columnMap As New Dictionary(Of String, String) From {
            {"Schedule Code", "shed_id"},
            {"Room Code", "room_code"},
            {"Room Name", "room_name"},
            {"Subject", "subject_name"}, ' Updated for subject search
            {"Course", "course_name"},  ' Added course search
            {"Section", "sections"},  ' Added section search
            {"Day", "room_day"},
            {"Date", "room_date"},
            {"Time In", "room_time_in"},
            {"Time Out", "room_time_out"}
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
            DGVschedules.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
