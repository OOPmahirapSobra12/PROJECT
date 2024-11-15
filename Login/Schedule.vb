Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Schedule
    ' Connection string to your MySQL database
    Dim connectionString As String = "Server=127.0.0.1; Database=project; Uid=root; Pwd=password;"
    Dim connection As New MySqlConnection(connectionString)

    ' Load data into DataGridView
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadScheduleData()
    End Sub

    Private Sub LoadScheduleData()
        Dim query As String = "SELECT * FROM sched"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Dim roomCode As String = txtRoomCode.Text
        Dim roomName As String = txtRoomName.Text
        Dim buildingLetter As String = cmbBuildingLetter.SelectedItem.ToString() ' Use the ComboBox value
        Dim roomTimeIn As String = dtpRoomTimeIn.Value.ToString("HH:mm") ' Format to 24-hour time
        Dim roomTimeOut As String = dtpRoomTimeOut.Value.ToString("HH:mm")
        Dim roomDay As String = cmbRoomDay.SelectedItem.ToString()
        Dim roomDate As String = dtpRoomDate.Value.ToString("yyyy-MM-dd")
        Dim shedID As String = txtShedID.Text

        ' SQL Query to insert data
        Dim query As String = "INSERT INTO sched (room_code, room_name, building_letter, room_time_in, room_time_out, room_day, room_date, shed_id) VALUES (@roomCode, @roomName, @buildingLetter, @roomTimeIn, @roomTimeOut, @roomDay, @roomDate, @shedID)"
        Dim command As New MySqlCommand(query, connection)

        ' Set parameters
        command.Parameters.AddWithValue("@roomCode", roomCode)
        command.Parameters.AddWithValue("@roomName", roomName)
        command.Parameters.AddWithValue("@buildingLetter", buildingLetter)
        command.Parameters.AddWithValue("@roomTimeIn", roomTimeIn)
        command.Parameters.AddWithValue("@roomTimeOut", roomTimeOut)
        command.Parameters.AddWithValue("@roomDay", roomDay)
        command.Parameters.AddWithValue("@roomDate", roomDate)
        command.Parameters.AddWithValue("@shedID", shedID)

        ' Execute the query
        Try
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Schedule added successfully!")
            LoadScheduleData() ' Refresh the DataGridView
            ClearFields() ' Clear input fields
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim roomCode As String = txtRoomCode.Text
        Dim roomName As String = txtRoomName.Text
        Dim buildingLetter As String = cmbBuildingLetter.SelectedItem.ToString()
        Dim roomTimeIn As String = dtpRoomTimeIn.Value.ToString("HH:mm")
        Dim roomTimeOut As String = dtpRoomTimeOut.Value.ToString("HH:mm")
        Dim roomDay As String = cmbRoomDay.SelectedItem.ToString()
        Dim roomDate As String = dtpRoomDate.Value.ToString("yyyy-MM-dd")
        Dim shedID As String = txtShedID.Text

        ' SQL Query to update data based on shed_id
        Dim query As String = "UPDATE sched SET room_code = @roomCode, room_name = @roomName, building_letter = @buildingLetter, room_time_in = @roomTimeIn, room_time_out = @roomTimeOut, room_day = @roomDay, room_date = @roomDate WHERE shed_id = @shedID"
        Dim command As New MySqlCommand(query, connection)

        ' Set parameters
        command.Parameters.AddWithValue("@roomCode", roomCode)
        command.Parameters.AddWithValue("@roomName", roomName)
        command.Parameters.AddWithValue("@buildingLetter", buildingLetter)
        command.Parameters.AddWithValue("@roomTimeIn", roomTimeIn)
        command.Parameters.AddWithValue("@roomTimeOut", roomTimeOut)
        command.Parameters.AddWithValue("@roomDay", roomDay)
        command.Parameters.AddWithValue("@roomDate", roomDate)
        command.Parameters.AddWithValue("@shedID", shedID)

        ' Execute the query
        Try
            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            connection.Close()

            ' Check if the update was successful
            If rowsAffected > 0 Then
                MessageBox.Show("Schedule updated successfully!")
                LoadScheduleData() ' Refresh the DataGridView
                ClearFields() ' Clear input fields
            Else
                MessageBox.Show("No matching schedule found to update.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub ClearFields()
        txtRoomCode.Clear()
        txtRoomName.Clear()
        If cmbBuildingLetter.Items.Count > 0 Then cmbBuildingLetter.SelectedIndex = 0
        dtpRoomTimeIn.Value = DateTime.Now
        dtpRoomTimeOut.Value = DateTime.Now
        cmbRoomDay.SelectedIndex = -1
        dtpRoomDate.Value = DateTime.Now
        txtShedID.Clear()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtShedID.Text) OrElse Not Integer.TryParse(txtShedID.Text, Nothing) Then
            MessageBox.Show("Please enter a valid numeric schedule ID to delete.")
            Return
        End If

        Dim query As String = "DELETE FROM sched WHERE shed_id = @shed_id"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@shed_id", Integer.Parse(txtShedID.Text)) ' Convert to Integer

        Try
            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Schedule deleted successfully.")
            Else
                MessageBox.Show("No schedule found with the given ID.")
            End If

            LoadScheduleData() ' Refresh the DataGridView
            ClearFields()       ' Clear the input fields after deletion
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close() ' Ensure the connection is closed
        End Try


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class