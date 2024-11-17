Imports MySql.Data.MySqlClient
Public Class ScheduleStudent

    Private btnsearchstud As Object


    Private Sub ScheduleStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
            btnsearchstud.Enabled = True
        End If

        searchcbo()
    End Sub

    Private Sub searchcbo()
        ' Add options to ComboBox
        cboSearchStud.Items.Add("All")
        cboSearchStud.Items.Add("Room Name")
        cboSearchStud.Items.Add("Room Code")
        cboSearchStud.Items.Add("Building Letter")

        ' Set a default selection if desired
        cboSearchStud.SelectedIndex = 0 ' Selects the first item (Room Name) by default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Student.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles txtsearchsched.Click


        If cboSearchStud.SelectedItem.ToString() = "All" Then
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
            dvgsearchStud.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub tablesearcher_rooms()
        Dim category As String = cboSearchStud.Text()
        Dim search As String = txtsearchRoomStud.Text()

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
            dvgsearchStud.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room list: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tableroomsload()
        ' Format the schedules DataGridView
        If dvgsearchStud.Rows.Count > 0 Then ' Check if there are rows
            With dvgsearchStud
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
            With dvgsearchStud
                .Columns(0).HeaderText = "Room Code"
                .Columns(1).HeaderText = "Room Name"
                .Columns(2).HeaderText = "Building"
                .Columns(3).HeaderText = "Statuts"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub cboSearchStud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchStud.SelectedIndexChanged
        cboSearchStud.Width = 102
    End Sub
End Class