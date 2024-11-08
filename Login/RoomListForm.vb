Imports MySql.Data.MySqlClient

Public Class RoomListForm

    Private connection As New MySqlConnection("server=127.0.0.1;uid=root;pwd=password;database=project")

    Private Sub LoadRoomData()

        ' Updated query to fetch all rooms from the sched table
        ' Define the query to get all relevant columns from the roomlist table
        Dim query As String = "SELECT room_code, room_name, building_letter, room_status FROM roomlist"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            ' Open the connection and fill the DataTable with the query result
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            ' Bind the DataTable to the DataGridView to display the data
            dgvRoomList.DataSource = table
            dgvRoomList.AutoGenerateColumns = True

            ' Add a new column to display the room status if it doesn't already exist
            If dgvRoomList.Columns("room_status") Is Nothing Then
                Dim statusColumn As New DataGridViewTextBoxColumn()
                statusColumn.Name = "room_status"
                statusColumn.HeaderText = "Room Status"
                statusColumn.DataPropertyName = "room_status" ' Bind to the room_status field from the database

                ' Add the column to the DataGridView
                dgvRoomList.Columns.Add(statusColumn)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub RoomListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomData() ' Load room data when the form is loaded
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRoomData() ' Reload room data from the database
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdateRoomStatus.Click
        If dgvRoomList.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvRoomList.SelectedRows(0)

            ' Ensure the column name matches exactly
            Dim roomCode As String = selectedRow.Cells("room_code").Value.ToString()
            Dim newStatus As String = cmbRoomStatus.SelectedItem?.ToString()

            If String.IsNullOrEmpty(newStatus) Then
                MessageBox.Show("Please select a status from the dropdown.")
                Return
            End If

            Dim query As String = "UPDATE roomlist SET room_status = @status WHERE room_code = @code"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@status", newStatus)
            command.Parameters.AddWithValue("@code", roomCode)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Room status updated successfully!")
                LoadRoomData() ' Refresh the data
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please select a room to update.")
        End If
    End Sub

    Private Sub dgvRoomList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoomList.CellContentClick

    End Sub

  