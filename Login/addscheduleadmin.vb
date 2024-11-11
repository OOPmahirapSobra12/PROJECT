Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class addscheduleadmin
    Public Property requestID As String
    Dim time As String

    Private Sub addscheduleadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        If requestID.Trim().Length = 0 Then
            requestloader()
        Else
            MsgBox("no code recieved: " & requestID)
        End If

        btnaddschedule.Enabled = False
        searchcbo()
        DDcbo()
        tableloader_rooms()
        tableroomsload()
        timerefresh()
    End Sub

    Private Sub searchcbo()
        ' Add options to ComboBox
        cbosearch.Items.Add("All")
        cbosearch.Items.Add("Room Name")
        cbosearch.Items.Add("Room Code")
        cbosearch.Items.Add("Building Letter")

        ' Set a default selection if desired
        cbosearch.SelectedIndex = 0 ' Selects the first item (Room Name) by default
    End Sub

    Private Sub timerefresh()
        ' Populate "in" hours (1-12) in cbohourin for a 12-hour clock format
        cbohourin.Items.Clear()
        For hour As Integer = 1 To 12
            cbohourin.Items.Add(hour.ToString())
        Next

        ' Populate "out" hours (1-12) in cbohourout for a 12-hour clock format
        cbohourout.Items.Clear()
        For hour As Integer = 1 To 12
            cbohourout.Items.Add(hour.ToString())
        Next

        ' Populate "in" minutes (0-59) in cbominutein
        cbominutein.Items.Clear()
        For minute As Integer = 0 To 59
            cbominutein.Items.Add(minute.ToString("D2")) ' "D2" formats single digits as two-digit numbers (e.g., "01")
        Next

        ' Populate "out" minutes (0-59) in cbominuteout
        cbominuteout.Items.Clear()
        For minute As Integer = 0 To 59
            cbominuteout.Items.Add(minute.ToString("D2"))
        Next

        ' Populate "in" AM/PM options in cboampmin
        cboampmin.Items.Clear()
        cboampmin.Items.Add("AM")
        cboampmin.Items.Add("PM")

        ' Populate "out" AM/PM options in cboampmout
        cboampmout.Items.Clear()
        cboampmout.Items.Add("AM")
        cboampmout.Items.Add("PM")

        ' Set default selections: First hour (1), first minute (00), and AM for "in" and "out" times
        cbohourin.SelectedIndex = 0
        cbominutein.SelectedIndex = 0
        cboampmin.SelectedIndex = 0

        cbohourout.SelectedIndex = 0
        cbominuteout.SelectedIndex = 0
        cboampmout.SelectedIndex = 0
    End Sub

    Public Sub timeequation(ByRef timein As String, ByRef timeout As String)
        ' Get the hour, minute, and AM/PM for the "in" time
        Dim hourIn As Integer = Integer.Parse(cbohourin.SelectedItem.ToString())
        Dim minuteIn As Integer = Integer.Parse(cbominutein.SelectedItem.ToString())
        Dim secondIn As String = "00" ' Default to 00 seconds, as seconds aren't being selected
        Dim ampmIn As String = cboampmin.SelectedItem.ToString()

        ' Get the hour, minute, and AM/PM for the "out" time
        Dim hourOut As Integer = Integer.Parse(cbohourout.SelectedItem.ToString())
        Dim minuteOut As Integer = Integer.Parse(cbominuteout.SelectedItem.ToString())
        Dim secondOut As String = "00" ' Default to 00 seconds, as seconds aren't being selected
        Dim ampmOut As String = cboampmout.SelectedItem.ToString()

        ' Convert "in" time to 12-hour AM/PM format with seconds
        If ampmIn = "PM" And hourIn < 12 Then
            hourIn += 12
        ElseIf ampmIn = "AM" And hourIn = 12 Then
            hourIn = 0 ' Midnight case
        End If

        ' Convert "out" time to 12-hour AM/PM format with seconds
        If ampmOut = "PM" And hourOut < 12 Then
            hourOut += 12
        ElseIf ampmOut = "AM" And hourOut = 12 Then
            hourOut = 0 ' Midnight case
        End If

        ' Format the times to "hh:mm:ss AM/PM"
        timein = hourIn.ToString("D2") & ":" & minuteIn.ToString("D2") & ":" & secondIn & " " & ampmIn
        timeout = hourOut.ToString("D2") & ":" & minuteOut.ToString("D2") & ":" & secondOut & " " & ampmOut
    End Sub



    Private Sub DDcbo()
        ' Add options to ComboBox
        cboDD.Items.Add("Date") ' temporary schedule creation
        cboDD.Items.Add("Day") ' permanent schedule creation
        cboDD.Items.Add("Today")

        ' Set a default selection if desired
        cbosearch.SelectedIndex = 0 ' Selects the first item (Room Name) by default
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtbuilding.Clear()
        txtrcode.Clear()
        txtrname.Clear()
        txtrDD.Clear()
        txtrDD.Clear()
        cbohourin.SelectedIndex = 0
        cbominutein.SelectedIndex = 0
        cboampmin.SelectedIndex = 0
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Check if "All" is selected in cbosearch; if so, load all records
        If cbosearch.SelectedItem.ToString() = "All" Then
            tableloader_rooms() ' Load all rooms from the roomlist
        Else
            tablesearcher_rooms() ' Perform search based on other criteria
        End If
    End Sub


    Private Sub tableloader_rooms()
        Dim query As String = "SELECT room_code, room_name, building_letter,room_status from roomlist" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVrooms.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub


    Private Sub tablesearcher_rooms()
        Dim category As String = cbosearch.Text()
        Dim search As String = txtsearchbox.Text()

        Dim query As String = ""

        ' Construct the SQL query based on the selected category
        Select Case category
            Case "Room Name"
                query = "SELECT * FROM roomlist WHERE room_name LIKE @search"
            Case "Room Code"
                query = "SELECT * FROM roomlist WHERE room_code LIKE @search"
            Case "Building Letter"
                query = "SELECT * FROM roomlist WHERE building_letter LIKE @search"
            Case Else
                MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Create the MySqlCommand object
        Dim command As New MySqlCommand(query, conn)

        ' Add the parameter for the search term, using '%' for partial matching
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
            DGVrooms.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room list: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tableroomsload()
        ' Format the schedules DataGridView
        If DGVrooms.Rows.Count > 0 Then ' Check if there are rows
            With DGVrooms
                .Columns(0).HeaderText = "Room Code"
                .Columns(1).HeaderText = "Room Name"
                .Columns(2).HeaderText = "Building"
                .Columns(3).HeaderText = "Statuts"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVrooms
                .Columns(0).HeaderText = "Room Code"
                .Columns(1).HeaderText = "Room Name"
                .Columns(2).HeaderText = "Building"
                .Columns(3).HeaderText = "Statuts"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Check if a row is selected in the DataGridView
        If DGVrooms.SelectedRows.Count > 0 Then
            ' Retrieve the selected row
            Dim selectedRow As DataGridViewRow = DGVrooms.SelectedRows(0)

            ' Assign the values from the selected row to the text boxes
            txtrcode.Text = selectedRow.Cells("room_code").Value.ToString()   ' Assuming column name is "room_code"
            txtrname.Text = selectedRow.Cells("room_name").Value.ToString()   ' Assuming column name is "room_name"
            txtbuilding.Text = selectedRow.Cells("building_letter").Value.ToString() ' Assuming column name is "building_letter
        Else
            MessageBox.Show("Please select a room from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        ' Ensure all required fields are filled (textboxes and combo boxes)
        If String.IsNullOrEmpty(txtrname.Text) OrElse
       String.IsNullOrEmpty(txtrcode.Text) OrElse
       String.IsNullOrEmpty(txtbuilding.Text) OrElse
       String.IsNullOrEmpty(txtrDD.Text) OrElse
       String.IsNullOrEmpty(cbohourin.Text) OrElse
       String.IsNullOrEmpty(cbominutein.Text) OrElse
       String.IsNullOrEmpty(cboampmin.Text) OrElse
       String.IsNullOrEmpty(cbohourout.Text) OrElse
       String.IsNullOrEmpty(cbominuteout.Text) OrElse
       String.IsNullOrEmpty(cboampmout.Text) Then
            MessageBox.Show("Please fill in all fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Declare variables to hold the formatted time
        Dim timein As String = ""
        Dim timeout As String = ""

        ' Call timeequation() to properly format the time
        timeequation(timein, timeout)

        ' Proceed with checking for conflicts after the time is formatted
        Dim selectedCode As String = txtrcode.Text
        Dim selectedDateOrDay As String = txtrDD.Text

        ' Use the formatted timein and timeout from the timeequation method
        Dim selectedTimeIn As String = timein ' This is the formatted time_in
        Dim selectedTimeOut As String = timeout ' This is the formatted time_out

        ' Define query to search for conflicts in the database (schedtemp for Today/Date and shed for Day)
        Dim query As String = ""

        If cboDD.SelectedItem.ToString() = "Today" Or cboDD.SelectedItem.ToString() = "Date" Then
            ' Temporary schedule, only search in schedtemp table by date
            query = "SELECT * FROM schedtemp WHERE room_code = @room AND room_date = @date AND " &
                "(room_time_in <= @timeOut AND room_time_out >= @timeIn)"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room", selectedCode)
                command.Parameters.AddWithValue("@date", selectedDateOrDay)
                command.Parameters.AddWithValue("@timeIn", selectedTimeIn)
                command.Parameters.AddWithValue("@timeOut", selectedTimeOut)

                Dim table As New DataTable()

                Try
                    ' Open the database connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the query and fill the DataTable
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)

                    ' Check if any records were found
                    If table.Rows.Count > 0 Then
                        MessageBox.Show("There is already a schedule in this room at the selected time.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        btnaddschedule.Enabled = False ' Disable btnaddschedule if there's a conflict
                    Else
                        MessageBox.Show("No conflicts found. Schedule can be confirmed.", "No Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnaddschedule.Enabled = True ' Enable btnaddschedule when no conflict is found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error checking schedule conflicts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close() ' Ensure the connection is closed
                End Try
            End Using
        ElseIf cboDD.SelectedItem.ToString() = "Day" Then
            ' Permanent schedule, search in shed table by day
            query = "SELECT * FROM shed WHERE room_code = @room AND room_day = @day AND " &
                "(room_time_in <= @timeOut AND room_time_out >= @timeIn)"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room", selectedCode)
                command.Parameters.AddWithValue("@day", selectedDateOrDay)
                command.Parameters.AddWithValue("@timeIn", selectedTimeIn)
                command.Parameters.AddWithValue("@timeOut", selectedTimeOut)

                Dim table As New DataTable()

                Try
                    ' Open the database connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the query and fill the DataTable
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)

                    ' Check if any records were found
                    If table.Rows.Count > 0 Then
                        MessageBox.Show("There is already a schedule in this room at the selected time.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        btnaddschedule.Enabled = False ' Disable btnaddschedule if there's a conflict
                    Else
                        MessageBox.Show("No conflicts found. Schedule can be confirmed.", "No Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnaddschedule.Enabled = True ' Enable btnaddschedule when no conflict is found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error checking schedule conflicts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close() ' Ensure the connection is closed
                End Try
            End Using
        End If
    End Sub





    Private Sub cboDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDD.SelectedIndexChanged
        ' Get the selected option
        Dim selectedOption As String = cboDD.SelectedItem.ToString()

        ' Display different messages based on the selected option
        Select Case selectedOption
            Case "Date"
                MessageBox.Show("You have selected 'Date', this will create a temporary schedule.", "Selection Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Enable txtrDD for manual input
                txtrDD.Text = ""
                txtrDD.Enabled = True

            Case "Day"
                MessageBox.Show("You have selected 'Day', this will create a permanent schedule.", "Selection Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Enable txtrDD for manual input
                txtrDD.Text = ""
                txtrDD.Enabled = True

            Case "Today"
                MessageBox.Show("You have selected 'Today', this will create a temporary schedule containing today's date.", "Selection Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set txtrDD to today's date and make it uneditable
                txtrDD.Text = DateTime.Now.ToString("MM/dd/yyyy")
                txtrDD.Enabled = False

            Case Else
                ' Default behavior for any unexpected option
                txtrDD.Text = ""
                txtrDD.Enabled = True
        End Select
    End Sub

    Public Sub requestloader()
        ' Check if the requestID is provided (it should not be empty or null)
        If String.IsNullOrEmpty(requestID) Then
            MessageBox.Show("Request ID is missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to retrieve request data based on requestID
        Dim query As String = "SELECT * FROM requests WHERE requestID = @requestID"

        ' Create a new command to execute the query
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@requestID", requestID) ' Add the requestID parameter to the query

            ' Create a DataTable to hold the query results
            Dim table As New DataTable()

            Try
                ' Open the database connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Check if any record is found
                If table.Rows.Count > 0 Then
                    ' Extract values from the DataTable and populate the controls
                    Dim row As DataRow = table.Rows(0)

                    ' Populate controls with the data
                    txtbuilding.Text = row("room").ToString()
                    txtrcode.Text = row("request").ToString()
                    txtrname.Text = row("request_d").ToString()
                    txtrDD.Text = row("request_t").ToString()
                    cbohourin.Text = row("request_t_in").ToString()
                    cbominutein.Text = row("request_t_out").ToString()

                    ' Additional checks can be added here to match the correct combo boxes and textboxes if needed

                Else
                    ' If no data found, show a message
                    MessageBox.Show("No data found for the provided Request ID.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                ' Show any errors that occur
                MessageBox.Show("Error loading request data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub btnaddschedule_Click(sender As Object, e As EventArgs) Handles btnaddschedule.Click
        ' Ensure all required fields are filled (textboxes and combo boxes)
        If String.IsNullOrEmpty(txtrname.Text) OrElse
           String.IsNullOrEmpty(txtrcode.Text) OrElse
           String.IsNullOrEmpty(txtbuilding.Text) OrElse
           String.IsNullOrEmpty(txtrDD.Text) OrElse
           String.IsNullOrEmpty(cbohourin.Text) OrElse
           String.IsNullOrEmpty(cbominutein.Text) OrElse
           String.IsNullOrEmpty(cboampmin.Text) OrElse
           String.IsNullOrEmpty(cbohourout.Text) OrElse
           String.IsNullOrEmpty(cbominuteout.Text) OrElse
           String.IsNullOrEmpty(cboampmout.Text) Then
            MessageBox.Show("Please fill in all fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Declare variables to hold the formatted time
        Dim timein As String = ""
        Dim timeout As String = ""

        ' Call timeequation() to properly format the time
        timeequation(timein, timeout)

        ' Retrieve the selected room code, name, and building letter
        Dim selectedCode As String = txtrcode.Text
        Dim selectedName As String = txtrname.Text
        Dim selectedBuilding As String = txtbuilding.Text

        ' Get the selected date or day for the schedule
        Dim selectedDateOrDay As String = txtrDD.Text

        ' Use the formatted timein and timeout from the timeequation method
        Dim selectedTimeIn As String = timein ' This is the formatted time_in
        Dim selectedTimeOut As String = timeout ' This is the formatted time_out

        ' Determine which table to insert into based on the selected option
        If cboDD.SelectedItem.ToString() = "Today" Or cboDD.SelectedItem.ToString() = "Date" Then
            ' Temporary schedule, insert into schedtemp table
            Dim query As String = "INSERT INTO schedtemp (requesterID, room, request, request_d, request_t, request_t_in, request_t_out) " &
                                  "VALUES (@requesterID, @room, @request, @request_d, @request_t, @request_t_in, @request_t_out)"

            Using command As New MySqlCommand(query, conn)
                ' Add parameters for the INSERT statement
                command.Parameters.AddWithValue("@requesterID", requestID) ' Assuming requestID is set earlier
                command.Parameters.AddWithValue("@room", selectedCode)
                command.Parameters.AddWithValue("@request", "Room scheduling request")
                command.Parameters.AddWithValue("@request_d", selectedDateOrDay)
                command.Parameters.AddWithValue("@request_t", cboDD.SelectedItem.ToString())
                command.Parameters.AddWithValue("@request_t_in", selectedTimeIn)
                command.Parameters.AddWithValue("@request_t_out", selectedTimeOut)

                Try
                    ' Open the database connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the insert command
                    command.ExecuteNonQuery()
                    MessageBox.Show("Schedule has been successfully added to the temporary schedule.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error adding schedule: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close() ' Ensure the connection is closed
                End Try
            End Using

        ElseIf cboDD.SelectedItem.ToString() = "Day" Then
            ' Permanent schedule, insert into shed table
            Dim query As String = "INSERT INTO shed (requesterID, room, request, room_day, room_time_in, room_time_out) " &
                                  "VALUES (@requesterID, @room, @request, @room_day, @room_time_in, @room_time_out)"

            Using command As New MySqlCommand(query, conn)
                ' Add parameters for the INSERT statement
                command.Parameters.AddWithValue("@requesterID", requestID) ' Assuming requestID is set earlier
                command.Parameters.AddWithValue("@room", selectedCode)
                command.Parameters.AddWithValue("@request", "Room scheduling request")
                command.Parameters.AddWithValue("@room_day", selectedDateOrDay)
                command.Parameters.AddWithValue("@room_time_in", selectedTimeIn)
                command.Parameters.AddWithValue("@room_time_out", selectedTimeOut)

                Try
                    ' Open the database connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the insert command
                    command.ExecuteNonQuery()
                    MessageBox.Show("Schedule has been successfully added to the permanent schedule.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error adding schedule: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close() ' Ensure the connection is closed
                End Try
            End Using
        End If
    End Sub

End Class