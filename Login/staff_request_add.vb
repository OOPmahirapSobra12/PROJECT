Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staff_request_add
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
        Dim sqlQuery As String = "
        SELECT 
            room_code, 
            room_name, 
            building, 
            num_chairs, 
            num_computers, 
            num_laptops, 
            room_status,
            CASE 
                WHEN room_status = 'Open' THEN occupancy_status 
                ELSE 'Closed' 
            END AS display_status
        FROM roomlist"
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            dataAdapter.Fill(dataTable)
            DGVroomlist.AutoGenerateColumns = False
            DGVroomlist.DataSource = dataTable

            ' Map data to columns
            For Each column As DataGridViewColumn In DGVroomlist.Columns
                Select Case column.Name
                    Case "room_code"
                        column.DataPropertyName = "room_code"
                    Case "room_name"
                        column.DataPropertyName = "room_name"
                    Case "building"
                        column.DataPropertyName = "building"
                    Case "num_chairs"
                        column.DataPropertyName = "num_chairs"
                    Case "num_computers"
                        column.DataPropertyName = "num_computers"
                    Case "num_laptops"
                        column.DataPropertyName = "num_laptops"
                    Case "status"
                        column.DataPropertyName = "display_status" ' Use the calculated column
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection after use
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

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim category As String = cboType.SelectedItem?.ToString()
        Dim searchValue As String = txtsearch.Text.Trim()

        If String.IsNullOrEmpty(category) OrElse category = "Choose" Then
            loadtable()
            Return
        End If

        Dim columnName As String = ""
        Select Case category
            Case "Room Code"
                columnName = "room_code"
            Case "Room Name"
                columnName = "room_name"
            Case "Building"
                columnName = "building"
            Case "Chair #"
                columnName = "num_chairs"
            Case "Computer #"
                columnName = "num_computers"
            Case "Laptop #"
                columnName = "num_laptops"
            Case "Availability"
                columnName = "display_status"
            Case Else
                MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        Dim dataTable As DataTable = CType(DGVroomlist.DataSource, DataTable)
        If String.IsNullOrEmpty(searchValue) Then
            dataTable.DefaultView.Sort = $"{columnName} ASC"
        Else
            dataTable.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'"
        End If
    End Sub

End Class
