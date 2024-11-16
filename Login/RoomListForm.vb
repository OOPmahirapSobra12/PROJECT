Imports MySql.Data.MySqlClient

Public Class RoomListForm


    ' Method to load room data
    Private Sub LoadRoomData()
        ' Query to select necessary columns from sched and roomlist tables, excluding time, day, and date fields
        Dim sqlQuery As String = "SELECT room_code, room_name, building, num_chairs, num_computers, num_laptops FROM roomlist"

        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Fill the DataTable with data from the query
            dataAdapter.Fill(dataTable)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVroomlist.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVroomlist.DataSource = dataTable

            ' Manually map the data to the existing columns
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
                End Select
            Next

        Catch ex As Exception
            ' Display an error message in case of an exception
            MessageBox.Show("Error loading room data: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            conn.Close()
        End Try
    End Sub


    ' Form Load event to call the LoadRoomData method
    Private Sub RoomListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        LoadRoomData()
        cboType.SelectedIndex = 0
    End Sub



    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Get selected category from cbotype and search input from txtsearch
        Dim category As String = cboType.SelectedItem?.ToString()
        Dim searchValue As String = txtsearch.Text.Trim()

        ' Check if "Choose" is selected
        If String.IsNullOrEmpty(category) OrElse category = "Choose" Then
            ' Refresh the table by reloading data
            LoadRoomData()
            Return
        End If

        ' Map cbotype category to DataGridView column name
        Dim columnName As String = ""
        Select Case category
            Case "Room Code"
                columnName = "roomcode"
            Case "Room Name"
                columnName = "roomname"
            Case "Building"
                columnName = "building"
            Case "Chair #"
                columnName = "chairs"
            Case "Computer #"
                columnName = "computers"
            Case "Laptop #"
                columnName = "laptops"
            Case Else
                MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' Check if txtsearch is blank
        If String.IsNullOrEmpty(searchValue) Then
            ' Refresh the table and sort it based on the selected category
            Dim dataTable As DataTable = CType(DGVroomlist.DataSource, DataTable)
            If dataTable IsNot Nothing Then
                Try
                    ' Apply sorting to the DataTable's DefaultView
                    dataTable.DefaultView.Sort = $"{columnName} ASC"
                    DGVroomlist.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("An error occurred while sorting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No data to sort.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return
        End If

        ' If txtsearch is not blank, filter the DataTable based on search input
        Dim dataTableForSearch As DataTable = CType(DGVroomlist.DataSource, DataTable)
        If dataTableForSearch IsNot Nothing Then
            Try
                ' Use DataTable.DefaultView.RowFilter for filtering
                dataTableForSearch.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'"
            Catch ex As Exception
                MessageBox.Show("An error occurred while searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No data to search in.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected
        If DGVroomlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the primary key value from the selected row (assuming it's "room_code")
        Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)
        Dim roomCode As String = selectedRow.Cells("roomcode").Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete room with code '{roomCode}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Try
                ' Delete from the database
                Dim query As String = "DELETE FROM sched WHERE room_code = @room_code"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room_code", roomCode)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()


                ' Check if the deletion was successful
                If rowsAffected > 0 Then
                    ' Remove the row from the DataGridView
                    DGVroomlist.Rows.Remove(selectedRow)
                    MessageBox.Show("Room successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No matching room found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting the room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ' Check if all the textboxes have values
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtname.Text) OrElse
       String.IsNullOrEmpty(txtbuilding.Text) OrElse String.IsNullOrEmpty(txtchair.Text) OrElse
       String.IsNullOrEmpty(txtcomputer.Text) OrElse String.IsNullOrEmpty(txtlaptop.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the data from the textboxes
        Dim roomCode As String = txtcode.Text.Trim()
        Dim roomName As String = txtname.Text.Trim()
        Dim building As String = txtbuilding.Text.Trim()
        Dim numChairs As Integer = Convert.ToInt32(txtchair.Text.Trim())
        Dim numComputers As Integer = Convert.ToInt32(txtcomputer.Text.Trim())
        Dim numLaptops As Integer = Convert.ToInt32(txtlaptop.Text.Trim())

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to update room with code '{roomCode}'?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Try
                ' Prepare the SQL update query
                Dim query As String = "UPDATE roomlist SET room_name = @room_name, building = @building, num_chairs = @num_chairs, num_computers = @num_computers, num_laptops = @num_laptops WHERE room_code = @room_code"

                ' Create a command to execute the query
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room_code", roomCode)
                command.Parameters.AddWithValue("@room_name", roomName)
                command.Parameters.AddWithValue("@building", building)
                command.Parameters.AddWithValue("@num_chairs", numChairs)
                command.Parameters.AddWithValue("@num_computers", numComputers)
                command.Parameters.AddWithValue("@num_laptops", numLaptops)


                Dim rowsAffected As Integer = command.ExecuteNonQuery()


                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Room data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Optionally, refresh the DataGridView to reflect the updated data
                    LoadRoomData() ' Assuming LoadRoomData is the method to reload the room data
                Else
                    MessageBox.Show("Room not found or no changes made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        txtcode.Enabled = False
        ' Check if a row is selected in the DataGridView
        If DGVroomlist.SelectedRows.Count > 0 Then
            ' Get the selected row (assuming only one row is selected)
            Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)

            ' Get the values from the selected row and assign them to the textboxes
            txtcode.Text = selectedRow.Cells("room_code").Value.ToString()
            txtname.Text = selectedRow.Cells("room_name").Value.ToString()
            txtbuilding.Text = selectedRow.Cells("building").Value.ToString()
            txtchair.Text = selectedRow.Cells("num_chairs").Value.ToString()
            txtcomputer.Text = selectedRow.Cells("num_computers").Value.ToString()
            txtlaptop.Text = selectedRow.Cells("num_laptops").Value.ToString()
        Else
            ' If no row is selected, show a message
            MessageBox.Show("Please select a row first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate that all necessary fields are filled out
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtname.Text) OrElse
           String.IsNullOrEmpty(txtbuilding.Text) OrElse String.IsNullOrEmpty(txtchair.Text) OrElse
           String.IsNullOrEmpty(txtcomputer.Text) OrElse String.IsNullOrEmpty(txtlaptop.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get values from the textboxes
        Dim roomCode As String = txtcode.Text.Trim()
        Dim roomName As String = txtname.Text.Trim()
        Dim building As String = txtbuilding.Text.Trim()
        Dim numChairs As Integer = Convert.ToInt32(txtchair.Text.Trim())
        Dim numComputers As Integer = Convert.ToInt32(txtcomputer.Text.Trim())
        Dim numLaptops As Integer = Convert.ToInt32(txtlaptop.Text.Trim())

        ' Confirm the addition
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to add room with code '{roomCode}'?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Prepare the insert SQL query
                Dim query As String = "INSERT INTO roomlist (room_code, room_name, building, num_chairs, num_computers, num_laptops, occupancy_status, room_status) " &
                                      "VALUES (@room_code, @room_name, @building, @num_chairs, @num_computers, @num_laptops, )"

                ' Create the command and add parameters
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room_code", roomCode)
                command.Parameters.AddWithValue("@room_name", roomName)
                command.Parameters.AddWithValue("@building", building)
                command.Parameters.AddWithValue("@num_chairs", numChairs)
                command.Parameters.AddWithValue("@num_computers", numComputers)
                command.Parameters.AddWithValue("@num_laptops", numLaptops)

                ' Execute the insert command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check if the insert was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRoomData() ' Reload the room data
                Else
                    MessageBox.Show("An error occurred while adding the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while adding the room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                conn.Close()
            End Try
        End If
    End Sub

End Class
