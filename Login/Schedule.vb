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
        datetimeformat()
        formatloader()
    End Sub

    Public Sub formatloader()
        DTPdate.Enabled = False
        DTPdate.Value = DateTime.Now
        DTPtimein.Value = DateTime.Now
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

            ' Clear any existing items in the ComboBox
            cborcode.Items.Clear()

            ' Add the items to the ComboBox in one go
            cborcode.Items.AddRange(roomCodes.ToArray())

            ' Ensure "Choose" is selected by default
            cborcode.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error loading room codes: " & ex.Message)
        Finally
            ' Close the reader and connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Public Sub datetimeformat()
        ' Date-only DateTimePicker (DTPdate)
        DTPdate.Format = DateTimePickerFormat.Short  ' Displays only the date (e.g., 11/17/2024)
        DTPdate.ShowUpDown = False  ' Disables the up/down spinner, uses a calendar for date selection

        ' Time-only DateTimePicker (DTPtime)
        DTPtimein.Format = DateTimePickerFormat.Custom  ' Custom format for time only
        DTPtimein.CustomFormat = "HH:mm"  ' 24-hour time format (e.g., 14:30)
        DTPtimein.ShowUpDown = True  ' Enables the up/down spinner for selecting time

        DTPtimeout.Format = DateTimePickerFormat.Custom
        DTPtimeout.CustomFormat = "HH:mm"
        DTPtimeout.ShowUpDown = True
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

    Private Sub cboday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboday.SelectedIndexChanged
        ' Check the selected index of the ComboBox
        If cboday.SelectedIndex = 1 Then
            ' Enable DTPdate if index is 1
            DTPdate.Enabled = True
        Else
            ' Disable DTPdate for all other indices
            DTPdate.Enabled = False
        End If
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Check if a row is selected in DGVschedule
        If DGVschedule.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DGVschedule.SelectedRows(0)

            ' Extract values from the selected row
            Dim shedId As String = selectedRow.Cells("sched_code").Value.ToString()  ' Get shed_id (sched_code)
            Dim roomCode As String = selectedRow.Cells("room_code").Value.ToString()
            Dim roomName As String = selectedRow.Cells("room_name").Value.ToString()
            Dim detail As String = selectedRow.Cells("detail").Value.ToString()
            Dim roomDay As String = selectedRow.Cells("s_day").Value.ToString()
            Dim roomDate As String = selectedRow.Cells("s_date").Value.ToString()
            Dim timeIn As String = selectedRow.Cells("time_in").Value.ToString()
            Dim timeOut As String = selectedRow.Cells("time_out").Value.ToString()

            ' Populate controls with the selected row data
            txtschedID.Text = shedId  ' Populate shed_id into txtschedID
            cborcode.Text = roomCode
            txtname.Text = roomName
            txtdetail.Text = detail
            DTPtimein.Value = DateTime.Parse(timeIn)
            DTPtimeout.Value = DateTime.Parse(timeOut)

            ' Handle the ComboBox and DateTimePicker logic based on s_day and s_date
            If roomDay = "N/A" OrElse String.IsNullOrEmpty(roomDay) Then
                ' If s_day is N/A or blank, enable the DateTimePicker for date selection
                cboday.SelectedIndex = 1 ' Date selection
                DTPdate.Enabled = True
                If Not String.IsNullOrEmpty(roomDate) Then
                    ' Set DTPdate to the value from the selected row
                    DTPdate.Value = DateTime.Parse(roomDate)
                End If
            ElseIf roomDate = "N/A" OrElse String.IsNullOrEmpty(roomDate) Then
                ' If roomDate is N/A or blank, enable ComboBox for day selection
                DTPdate.Enabled = False

                If String.IsNullOrEmpty(roomDay) OrElse roomDay.Equals("N/A", StringComparison.OrdinalIgnoreCase) Then
                    ' If roomDay is also blank or N/A, default to "Temporary" or the blank option
                    cboday.SelectedIndex = 0 ' Set to the default option (Temporary/Blank)
                Else
                    ' Map the day to the corresponding ComboBox index
                    Select Case roomDay
                        Case "Monday"
                            cboday.SelectedIndex = 2
                        Case "Tuesday"
                            cboday.SelectedIndex = 3
                        Case "Wednesday"
                            cboday.SelectedIndex = 4
                        Case "Thursday"
                            cboday.SelectedIndex = 5
                        Case "Friday"
                            cboday.SelectedIndex = 6
                        Case "Saturday"
                            cboday.SelectedIndex = 7
                        Case Else
                            cboday.SelectedIndex = 0 ' Fallback to default if no match
                    End Select
                End If
            End If

            ' Optionally, disable the room code for editing (or leave it enabled for editing)
            txtschedID.Enabled = False
            txtname.Enabled = False
        Else
            ' Inform the user to select a row
            MessageBox.Show("Please select a room from the list.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ' Ensure that all required fields are filled before proceeding
        If String.IsNullOrEmpty(txtschedID.Text) OrElse String.IsNullOrEmpty(cborcode.Text) OrElse String.IsNullOrEmpty(txtname.Text) OrElse
       String.IsNullOrEmpty(txtdetail.Text) OrElse String.IsNullOrEmpty(DTPtimein.Text) OrElse
       String.IsNullOrEmpty(DTPtimeout.Text) OrElse cboday.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields and select a valid option from the day/date combo box.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected room's shed_id and code
        Dim shedId As String = txtschedID.Text.Trim()
        Dim roomCode As String = cborcode.Text.Trim()

        ' Get the values from the controls
        Dim roomName As String = txtname.Text.Trim()
        Dim detail As String = txtdetail.Text.Trim()
        Dim timeIn As String = DTPtimein.Value.ToString("HH:mm") ' Formatting the time to "HH:mm"
        Dim timeOut As String = DTPtimeout.Value.ToString("HH:mm") ' Formatting the time to "HH:mm"
        Dim roomDay As String = "N/A" ' Default to "N/A"
        Dim roomDate As String = "N/A" ' Default to "N/A"

        ' Check the ComboBox index and set the appropriate day/date fields
        If cboday.SelectedIndex = 0 Then
            MessageBox.Show("Please select a valid Day or Date option.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf cboday.SelectedIndex = 1 Then
            ' If "Date" (index = 1) is selected, update the schedtemp table
            roomDate = DTPdate.Value.ToString("yyyy-MM-dd") ' Use the selected date for room_date
            roomDay = "N/A" ' Set roomDay to "N/A"
        ElseIf cboday.SelectedIndex >= 2 AndAlso cboday.SelectedIndex <= 7 Then
            ' If "Day" (index = 2 to 7) is selected, update the sched table
            roomDay = cboday.SelectedItem.ToString() ' Use the selected day for room_day
            roomDate = "N/A" ' Set roomDate to "N/A"
        End If

        ' Check for existing conflicts in both tables
        Dim conflictQuerySched As String = "
        SELECT COUNT(*) FROM sched 
        WHERE room_code = @room_code AND room_day = @room_day AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out)) AND shed_id <> @shed_id"

        Dim conflictQuerySchedTemp As String = "
        SELECT COUNT(*) FROM schedtemp 
        WHERE room_code = @room_code AND room_date = @room_date AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out)) AND shed_id <> @shed_id"

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Create commands to check for conflicts in both tables
            Dim conflictCmdSched As New MySqlCommand(conflictQuerySched, conn)
            conflictCmdSched.Parameters.AddWithValue("@room_code", roomCode)
            conflictCmdSched.Parameters.AddWithValue("@room_day", roomDay)
            conflictCmdSched.Parameters.AddWithValue("@room_date", roomDate)
            conflictCmdSched.Parameters.AddWithValue("@time_in", timeIn)
            conflictCmdSched.Parameters.AddWithValue("@time_out", timeOut)
            conflictCmdSched.Parameters.AddWithValue("@shed_id", shedId)

            Dim conflictCmdSchedTemp As New MySqlCommand(conflictQuerySchedTemp, conn)
            conflictCmdSchedTemp.Parameters.AddWithValue("@room_code", roomCode)
            conflictCmdSchedTemp.Parameters.AddWithValue("@room_date", roomDate)
            conflictCmdSchedTemp.Parameters.AddWithValue("@time_in", timeIn)
            conflictCmdSchedTemp.Parameters.AddWithValue("@time_out", timeOut)
            conflictCmdSchedTemp.Parameters.AddWithValue("@shed_id", shedId)

            ' Check for conflicts
            Dim conflictCountSched As Integer = Convert.ToInt32(conflictCmdSched.ExecuteScalar())
            Dim conflictCountSchedTemp As Integer = Convert.ToInt32(conflictCmdSchedTemp.ExecuteScalar())
            If conflictCountSched > 0 OrElse conflictCountSchedTemp > 0 Then
                MessageBox.Show("The selected room, date, and time already conflict with an existing schedule. Please choose a different time or room.", "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking for conflicts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        ' Define SQL queries for both tables
        Dim sqlQuery As String = "
        UPDATE sched 
        SET room_code = @room_code, 
        detail = @detail, 
        room_day = @room_day, 
        room_time_in = @room_time_in, 
        room_time_out = @room_time_out 
        WHERE shed_id = @shed_id"

        Dim sqlQueryTemp As String = "
        UPDATE schedtemp 
        SET room_code = @room_code, 
        detail = @detail, 
        room_time_in = @room_time_in, 
        room_time_out = @room_time_out, 
        room_date = @room_date 
        WHERE shed_id = @shed_id"

        ' Create the command and parameters for the scheduled update
        Dim command As New MySqlCommand()

        ' Set the appropriate command and query
        If cboday.SelectedIndex = 1 Then
            command.CommandText = sqlQueryTemp
        Else
            command.CommandText = sqlQuery
        End If

        command.Connection = conn
        command.Parameters.AddWithValue("@shed_id", shedId)
        command.Parameters.AddWithValue("@room_code", roomCode)
        command.Parameters.AddWithValue("@detail", detail)
        command.Parameters.AddWithValue("@room_day", roomDay)
        command.Parameters.AddWithValue("@room_time_in", timeIn)
        command.Parameters.AddWithValue("@room_time_out", timeOut)
        command.Parameters.AddWithValue("@room_date", roomDate)

        ' Execute the update
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            command.ExecuteNonQuery()
            MessageBox.Show("Schedule updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadtable() ' Reload the table data after update
            txtschedID.Enabled = True
            txtname.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error updating schedule: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Ensure that all required fields are filled before proceeding
        If String.IsNullOrEmpty(txtschedID.Text) OrElse String.IsNullOrEmpty(cborcode.Text) OrElse
       String.IsNullOrEmpty(txtdetail.Text) OrElse String.IsNullOrEmpty(DTPtimein.Text) OrElse
       String.IsNullOrEmpty(DTPtimeout.Text) OrElse cboday.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields and select a valid option from the day/date combo box.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected room's shed_id and code
        Dim shedId As String = txtschedID.Text.Trim()
        Dim roomCode As String = cborcode.Text.Trim()

        ' Get the values from the controls
        Dim roomName As String = txtname.Text.Trim()
        Dim detail As String = txtdetail.Text.Trim()
        Dim timeIn As String = DTPtimein.Value.ToString("HH:mm") ' Formatting the time to "HH:mm"
        Dim timeOut As String = DTPtimeout.Value.ToString("HH:mm") ' Formatting the time to "HH:mm"
        Dim roomDay As String = "N/A" ' Default to "N/A"
        Dim roomDate As String = "N/A" ' Default to "N/A"

        ' Check the ComboBox index and set the appropriate day/date fields
        If cboday.SelectedIndex = 0 Then
            MessageBox.Show("Please select a valid Day or Date option.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf cboday.SelectedIndex = 1 Then
            ' If "Date" (index = 1) is selected, use the selected date
            roomDate = DTPdate.Value.ToString("yyyy-MM-dd") ' Use the selected date for room_date
            roomDay = "N/A" ' Set roomDay to "N/A"
        ElseIf cboday.SelectedIndex >= 2 AndAlso cboday.SelectedIndex <= 7 Then
            ' If "Day" (index = 2 to 7) is selected, use the selected day for room_day
            roomDay = cboday.SelectedItem.ToString() ' Use the selected day for room_day
            roomDate = "N/A" ' Set roomDate to "N/A"
        End If

        ' Check for conflicts in both 'sched' and 'schedtemp' tables before proceeding with the insert
        Dim conflictQuery As String = "
    SELECT COUNT(*) 
    FROM (
        SELECT room_code, room_time_in, room_time_out
        FROM sched 
        WHERE room_code = @room_code 
        AND ((room_time_in BETWEEN @room_time_in AND @room_time_out) 
        OR (room_time_out BETWEEN @room_time_in AND @room_time_out))
        UNION
        SELECT room_code, room_time_in, room_time_out
        FROM schedtemp 
        WHERE room_code = @room_code 
        AND ((room_time_in BETWEEN @room_time_in AND @room_time_out) 
        OR (room_time_out BETWEEN @room_time_in AND @room_time_out))
    ) AS conflicts"

        ' Create the command for the conflict check query
        Dim conflictCommand As New MySqlCommand(conflictQuery, conn)
        conflictCommand.Parameters.AddWithValue("@room_code", roomCode)
        conflictCommand.Parameters.AddWithValue("@room_time_in", timeIn)
        conflictCommand.Parameters.AddWithValue("@room_time_out", timeOut)

        ' Execute the conflict check query
        Dim conflictCount As Integer
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            conflictCount = Convert.ToInt32(conflictCommand.ExecuteScalar())

            ' If there's a conflict, show an error and exit
            If conflictCount > 0 Then
                MessageBox.Show("There is a conflict with an existing schedule for the selected room and time. Please choose a different time or room.", "Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking for conflicts: " & ex.Message, "Conflict Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        ' Define the SQL queries for adding a record to the sched or schedtemp table
        Dim sqlQuery As String = "
    INSERT INTO sched (shed_id, room_code, detail, room_day, room_time_in, room_time_out)
    VALUES (@shed_id, @room_code, @detail, @room_day, @room_time_in, @room_time_out)"

        Dim sqlQueryTemp As String = "
    INSERT INTO schedtemp (shed_id, room_code, detail, room_time_in, room_time_out, room_date)
    VALUES (@shed_id, @room_code, @detail, @room_time_in, @room_time_out, @room_date)"

        ' Create the command and parameters for the scheduled insert
        Dim command As New MySqlCommand()

        ' Set the appropriate command and query
        If cboday.SelectedIndex = 1 Then
            command.CommandText = sqlQueryTemp
        Else
            command.CommandText = sqlQuery
        End If

        command.Connection = conn
        command.Parameters.AddWithValue("@shed_id", shedId)
        command.Parameters.AddWithValue("@room_code", roomCode)
        command.Parameters.AddWithValue("@detail", detail)
        command.Parameters.AddWithValue("@room_day", roomDay)
        command.Parameters.AddWithValue("@room_time_in", timeIn)
        command.Parameters.AddWithValue("@room_time_out", timeOut)
        command.Parameters.AddWithValue("@room_date", roomDate)

        ' Execute the insert
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            command.ExecuteNonQuery()
            MessageBox.Show("Schedule added successfully!", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadtable() ' Reload the table data after adding
        Catch ex As Exception
            MessageBox.Show("Error adding schedule: " & ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Ensure a row is selected before proceeding
        If DGVschedule.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a schedule to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the shed_id from the selected row in the table
        Dim shedId As String = DGVschedule.SelectedRows(0).Cells("shed_id").Value.ToString()

        ' Confirm with the user before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' Define SQL queries for deleting from both tables
        Dim sqlDeleteSched As String = "DELETE FROM sched WHERE shed_id = @shed_id"
        Dim sqlDeleteSchedTemp As String = "DELETE FROM schedtemp WHERE shed_id = @shed_id"

        ' Create the command for deleting from the appropriate table
        Dim command As New MySqlCommand()

        ' Choose the appropriate query based on whether it's a regular schedule or temporary schedule
        If cboday.SelectedIndex = 1 Then
            command.CommandText = sqlDeleteSchedTemp
        Else
            command.CommandText = sqlDeleteSched
        End If

        command.Connection = conn
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


End Class
