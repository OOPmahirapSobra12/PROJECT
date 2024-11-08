Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Public Class addscheduleadmin

    Public Property rDate As String
    Public Property rTime As String
    Public Property rRoom As String
    Dim time As String

    Private Sub addscheduleadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
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
        ' Populate hours (1-12) in cbohour for a 12-hour clock format
        cbohour.Items.Clear()
        For hour As Integer = 1 To 12
            cbohour.Items.Add(hour.ToString())
        Next

        ' Populate minutes (0-59) in cbominute
        cbominute.Items.Clear()
        For minute As Integer = 0 To 59
            cbominute.Items.Add(minute.ToString("D2")) ' "D2" formats single digits as two-digit numbers (e.g., "01")
        Next

        ' Populate AM/PM options in cboampm
        cboampm.Items.Clear()
        cboampm.Items.Add("AM")
        cboampm.Items.Add("PM")

        ' Set default selections: First hour (1), first minute (00), and AM
        cbohour.SelectedIndex = 0
        cbominute.SelectedIndex = 0
        cboampm.SelectedIndex = 0
    End Sub

    Private Sub timeequation()
        ' Construct the time string in the format hh:mm AM/PM
        Dim hour As String = cbohour.SelectedItem.ToString()
        Dim minute As String = cbominute.SelectedItem.ToString()
        Dim ampm As String = cboampm.SelectedItem.ToString()

        ' Combine components to form the final time string
        time = hour & ":" & minute & " " & ampm
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
        cbohour.SelectedIndex = 0
        cbominute.SelectedIndex = 0
        cboampm.SelectedIndex = 0
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
        ' Check if all required text boxes are filled
        If String.IsNullOrEmpty(txtrname.Text) Or
       String.IsNullOrEmpty(txtrcode.Text) Or
       String.IsNullOrEmpty(txtbuilding.Text) Then

            MessageBox.Show("Please fill in all fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed with conflict checking logic if all fields are filled
        Dim selectedRoom As String = txtrcode.Text
        Dim selectedDateOrDay As String = txtrDD.Text
        Dim selectedTime As String = time

        ' Define queries to search for conflicts in both shed and shedtemp tables
        Dim query As String = ""
        If cboDD.SelectedItem.ToString() = "Today" Or cboDD.SelectedItem.ToString() = "Date" Then
            ' Temporary schedule, search by date
            query = "SELECT * FROM shedtemp WHERE room_code = @room AND rDate = @date AND rTime = @time " &
                "UNION ALL " &
                "SELECT * FROM shed WHERE room_code = @room AND rDate = @date AND rTime = @time"
        ElseIf cboDD.SelectedItem.ToString() = "Day" Then
            ' Permanent schedule, search by day
            query = "SELECT * FROM shedtemp WHERE room_code = @room AND rDay = @date AND rTime = @time " &
                "UNION ALL " &
                "SELECT * FROM shed WHERE room_code = @room AND rDay = @date AND rTime = @time"
        End If

        ' Create the MySqlCommand with the query and parameters
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@room", selectedRoom)
            command.Parameters.AddWithValue("@date", selectedDateOrDay)
            command.Parameters.AddWithValue("@time", selectedTime)

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
                    btnadd.Enabled = False ' Disable btnadd if there's a conflict
                Else
                    MessageBox.Show("No conflicts found. Schedule can be confirmed.", "No Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnaddschedule.Enabled = True ' Enable btnadd if no conflict is found
                End If
            Catch ex As Exception
                MessageBox.Show("Error checking schedule conflicts: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
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

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub
End Class