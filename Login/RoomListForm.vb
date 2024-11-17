Imports MySql.Data.MySqlClient

Public Class RoomListForm

    ' Connection using MySQL
    Private connection As New MySqlConnection("server=127.0.0.1;uid=root;pwd=password;database=project")

    ' Method to load room data
    Private Sub LoadRoomData()

        Dim sqlQuery As String = "SELECT s.room_code, s.room_name, s.building_letter, s.room_time_in, s.room_time_out, _
                                    s.room_day, s.room_date, r.num_chairs, r.num_computers, r.num_laptops FROM sched s LEFT JOIN roomlist r ON s.room_code = r.room_code"

        Try
            connection.Open()

            Dim dataAdapter As New MySqlDataAdapter(sqlQuery, connection)
            Dim dataTable As New DataTable()

            ' Clear current data and reload
            dataAdapter.Fill(dataTable)

            ' Clear previous data source and bind to new data
            dgvRoomList.DataSource = Nothing
            dgvRoomList.DataSource = dataTable

            ' Set column headers
            dgvRoomList.Columns("num_chairs").HeaderText = "Number of Chairs"
            dgvRoomList.Columns("num_computers").HeaderText = "Number of Computers"
            dgvRoomList.Columns("num_laptops").HeaderText = "Number of Laptops"

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    ' Form Load event to call the LoadRoomData method
    Private Sub RoomListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRoomData()
    End Sub

    ' Refresh button to reload the data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvRoomList.DataSource = Nothing
        LoadRoomData()
    End Sub

    ' Back button to navigate back to Admin form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    ' Update room status button
    Private Sub btnUpdateRoomStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateRoomStatus.Click
        If dgvRoomList.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRoomList.SelectedRows(0)

            ' Ensure the column name matches exactly
            Dim roomCode As String = selectedRow.Cells("room_code").Value.ToString()
            Dim newStatus As String = cmbRoomStatus.SelectedItem?.ToString()

            If String.IsNullOrEmpty(newStatus) Then
                MessageBox.Show("Please select a status from the dropdown.")
                Return
            End If

            ' Query to update the room status in the roomlist table
            Dim query As String = "UPDATE roomlist SET room_status = @status WHERE room_code = @code"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@status", newStatus)
            command.Parameters.AddWithValue("@code", roomCode)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Room status updated successfully!")
                LoadRoomData() ' Refresh the data after update
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please select a room to update.")
        End If
    End Sub

    Private Sub btnUpdateRoomDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateRoomDetails.Click
        If dgvRoomList.SelectedRows.Count > 0 Then
            ' Loop through each selected row (if multiple rows are selected)
            For Each selectedRow As DataGridViewRow In dgvRoomList.SelectedRows

                ' Retrieve the room details
                Dim roomCode As String = selectedRow.Cells("room_code").Value.ToString()

                ' Retrieve the values entered by the admin in the TextBoxes
                Dim numChairs As Integer = If(Integer.TryParse(txtNumChairs.Text, numChairs), numChairs, 0)
                Dim numComputers As Integer = If(Integer.TryParse(txtNumComputers.Text, numComputers), numComputers, 0)
                Dim numLaptops As Integer = If(Integer.TryParse(txtNumLaptops.Text, numLaptops), numLaptops, 0)

                ' SQL query to update the room details
                Dim query As String = "UPDATE roomlist SET num_chairs = @numChairs, num_computers = @numComputers, num_laptops = @numLaptops WHERE room_code = @roomCode"

                ' Create the MySQL command to execute the query
                Dim command As New MySqlCommand(query, connection)

                ' Add the parameters with the values from the form
                command.Parameters.AddWithValue("@numChairs", numChairs)
                command.Parameters.AddWithValue("@numComputers", numComputers)
                command.Parameters.AddWithValue("@numLaptops", numLaptops)
                command.Parameters.AddWithValue("@roomCode", roomCode)

                Try
                    ' Open the connection
                    connection.Open()
                    ' Execute the query to update room details
                    command.ExecuteNonQuery()

                    ' Show a message confirming the update
                    MessageBox.Show("Room details updated successfully!")

                    ' Reload the room data in the DataGridView after update
                    LoadRoomData()
                Catch ex As Exception
                    ' Show error message if something goes wrong
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    ' Ensure the connection is closed in the end
                    connection.Close()
                End Try
            Next
        Else
            ' If no row is selected, show a message
            MessageBox.Show("Please select a room to update.")
        End If

    End Sub

    Private Sub dgvRoomList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoomList.CellContentClick

    End Sub


End Class
