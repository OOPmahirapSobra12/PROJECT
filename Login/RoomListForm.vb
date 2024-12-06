Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class RoomListForm
    ' Load room data into the DataGridView
    Private Sub LoadRoomData()
        Dim sqlQuery As String = "
        SELECT 
            room_code, room_name, building, num_chairs, num_computers, num_laptops, room_status, CASE WHEN room_status = 'Open' THEN occupancy_status ELSE 'Closed' 
            END AS display_status FROM roomlist"
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


    ' Form Load event
    Private Sub RoomListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        LoadRoomData()
        cboType.SelectedIndex = 0
        cbostatus.SelectedIndex = 0
        cbostat.SelectedIndex = 0
    End Sub

    ' Back button
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim category As String = cboType.SelectedItem?.ToString()
        Dim searchValue As String = txtsearch.Text.Trim()

        If String.IsNullOrEmpty(category) OrElse category = "Choose" Then
            LoadRoomData()
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


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DGVroomlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)
        Dim roomCode As String = selectedRow.Cells("room_code").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete room with code '{roomCode}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                Dim query As String = "DELETE FROM roomlist WHERE room_code = @room_code"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@room_code", roomCode)
                command.ExecuteNonQuery()

                DGVroomlist.Rows.Remove(selectedRow)
                MessageBox.Show("Room successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting room: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtname.Text) OrElse
       String.IsNullOrEmpty(txtbuilding.Text) OrElse String.IsNullOrEmpty(txtchair.Text) OrElse
       String.IsNullOrEmpty(txtcomputer.Text) OrElse String.IsNullOrEmpty(txtlaptop.Text) OrElse
       cbostatus.SelectedIndex = 0 Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "UPDATE roomlist SET room_name = @room_name, building = @building, num_chairs = @num_chairs, " &
                              "num_computers = @num_computers, num_laptops = @num_laptops, occupancy_status = @occupancy_status, room_status = @status " &
                              "WHERE room_code = @room_code"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@room_code", txtcode.Text.Trim())
            command.Parameters.AddWithValue("@room_name", txtname.Text.Trim())
            command.Parameters.AddWithValue("@building", txtbuilding.Text.Trim())
            command.Parameters.AddWithValue("@num_chairs", Convert.ToInt32(txtchair.Text.Trim()))
            command.Parameters.AddWithValue("@num_computers", Convert.ToInt32(txtcomputer.Text.Trim()))
            command.Parameters.AddWithValue("@num_laptops", Convert.ToInt32(txtlaptop.Text.Trim()))
            command.Parameters.AddWithValue("@occupancy_status", cbostatus.Text.Trim())
            command.Parameters.AddWithValue("@status", cbostat.Text.Trim())
            command.ExecuteNonQuery()

            MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRoomData()
            txtcode.Enabled = True
            cbostat.SelectedIndex = 0
            cbostatus.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error updating room: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtname.Text) OrElse
           String.IsNullOrEmpty(txtbuilding.Text) OrElse String.IsNullOrEmpty(txtchair.Text) OrElse
           String.IsNullOrEmpty(txtcomputer.Text) OrElse String.IsNullOrEmpty(txtlaptop.Text) OrElse
           String.IsNullOrEmpty(cbostatus.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "INSERT INTO roomlist (room_code, room_name, building, num_chairs, num_computers, num_laptops, occupancy_status, room_status) " &
                                  "VALUES (@room_code, @room_name, @building, @num_chairs, @num_computers, @num_laptops, @occupancy_status, @status)"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@room_code", txtcode.Text.Trim())
            command.Parameters.AddWithValue("@room_name", txtname.Text.Trim())
            command.Parameters.AddWithValue("@building", txtbuilding.Text.Trim())
            command.Parameters.AddWithValue("@num_chairs", Convert.ToInt32(txtchair.Text.Trim()))
            command.Parameters.AddWithValue("@num_computers", Convert.ToInt32(txtcomputer.Text.Trim()))
            command.Parameters.AddWithValue("@num_laptops", Convert.ToInt32(txtlaptop.Text.Trim()))
            command.Parameters.AddWithValue("@occupancy_status", cbostatus.Text.Trim())
            command.Parameters.AddWithValue("@status", cbostat.Text.Trim())
            command.ExecuteNonQuery()

            MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRoomData()
            cbostat.SelectedIndex = 0
            cbostatus.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Ensure a row is selected in the DataGridView
        If DGVroomlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to proceed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)

            ' Retrieve values from the selected row
            Dim roomCode As String = selectedRow.Cells("room_code").Value?.ToString()
            Dim roomName As String = selectedRow.Cells("room_name").Value?.ToString()
            Dim building As String = selectedRow.Cells("building").Value?.ToString()
            Dim numChairs As String = selectedRow.Cells("num_chairs").Value?.ToString()
            Dim numComputers As String = selectedRow.Cells("num_computers").Value?.ToString()
            Dim numLaptops As String = selectedRow.Cells("num_laptops").Value?.ToString()
            Dim occupancyStatus As String = selectedRow.Cells("status").Value?.ToString()

            ' Populate fields with the retrieved values
            txtcode.Text = roomCode
            txtname.Text = roomName
            txtbuilding.Text = building
            txtchair.Text = numChairs
            txtcomputer.Text = numComputers
            txtlaptop.Text = numLaptops

            ' Handle cbostatus based on occupancyStatus
            If String.Equals(occupancyStatus, "Closed", StringComparison.OrdinalIgnoreCase) Then
                cbostatus.SelectedIndex = 3 ' Assuming index 0 is "Closed"
                cbostatus.Enabled = False  ' Make the combo box inaccessible
            Else
                cbostatus.SelectedIndex = 1
                cbostatus.Enabled = True   ' Make the combo box accessible
            End If

            ' Disable editing of room code to prevent duplicates
            txtcode.Enabled = False

            MessageBox.Show($"Room '{roomCode}' selected.", "Selection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error selecting room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbostatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostatus.SelectedIndexChanged
        ' Check if the selected status in cbostatus is "Closed"
        If cbostatus.SelectedIndex = 3 Then
            ' Set cbostat to "Closed" (index 2)
            cbostat.SelectedIndex = 2

            ' Disable cbostatus (make it inaccessible)
            cbostatus.Enabled = False

            ' Optionally inform the user
            MessageBox.Show("Room status set to 'Closed'. Occupancy status is now unavailable.", "Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Enable cbostatus and allow the user to modify occupancy status
            cbostatus.Enabled = True

            ' Set cbostat to open (or any other value as required)
            If cbostatus.SelectedIndex = 1 Or cbostatus.SelectedIndex = 2 Then
                cbostat.Enabled = True
                cbostat.SelectedIndex = 1 ' Assuming "Open" is at index 1
            Else
                cbostat.SelectedIndex = 0 ' Adjust to the default value if needed
            End If
        End If
    End Sub

    Private Sub cbostat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostat.SelectedIndexChanged
        ' If the user selects "Closed" in cbostat (index 2), update cbostatus to "Closed" and disable it
        If cbostat.SelectedIndex = 2 Then
            cbostatus.SelectedIndex = 3  ' Assuming "Closed" is at index 3 in cbostatus
            cbostatus.Enabled = False    ' Disable cbostatus when it's closed
        Else
            cbostatus.Enabled = True     ' Enable cbostatus if the status is not closed
        End If
    End Sub


End Class