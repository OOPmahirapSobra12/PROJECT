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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO sched (shed_id, room_code, room_name, building_letter, room_time, room_day, room_date) VALUES (@shed_id, @room_code, @room_name, @building_letter, @room_time, @room_day, @room_date)"
        Dim command As New MySqlCommand(query, connection)

        ' Ensure sched_id is entered manually
        command.Parameters.AddWithValue("@shed_id", Integer.Parse(txtSchedID.Text)) ' Convert to Integer
        command.Parameters.AddWithValue("@room_code", txtRoomCode.Text)
        command.Parameters.AddWithValue("@room_name", txtRoomName.Text)
        command.Parameters.AddWithValue("@building_letter", cboBuildingLetter.Text)
        command.Parameters.AddWithValue("@room_time", txtRoomTime.Text)
        command.Parameters.AddWithValue("@room_day", cboRoomDay.Text)
        command.Parameters.AddWithValue("@room_date", dtpRoomDate.Value.ToString("yyyy-MM-dd"))

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        LoadScheduleData()
        ClearFields()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE sched SET room_code = @room_code, room_name = @room_name, building_letter = @building_letter, room_time = @room_time, room_day = @room_day, room_date = @room_date WHERE shed_id = @shed_id"
        Dim command As New MySqlCommand(query, connection)

        ' Ensure shed_id is entered
        If String.IsNullOrWhiteSpace(txtSchedID.Text) OrElse Not Integer.TryParse(txtSchedID.Text, Nothing) Then
            MessageBox.Show("Please enter a valid schedule ID.")
            Return
        End If

        command.Parameters.AddWithValue("@shed_id", Integer.Parse(txtSchedID.Text)) ' Convert to Integer
        command.Parameters.AddWithValue("@room_code", txtRoomCode.Text)
        command.Parameters.AddWithValue("@room_name", txtRoomName.Text)
        command.Parameters.AddWithValue("@building_letter", cboBuildingLetter.Text)
        command.Parameters.AddWithValue("@room_time", txtRoomTime.Text)
        command.Parameters.AddWithValue("@room_day", cboRoomDay.Text)
        command.Parameters.AddWithValue("@room_date", dtpRoomDate.Value.ToString("yyyy-MM-dd"))

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        LoadScheduleData() ' Refresh the DataGridView
        ClearFields()       ' Clear the input fields after update
    End Sub

    Private Sub ClearFields()
        txtRoomName.Clear()
        cboBuildingLetter.SelectedIndex = -1
        txtRoomTime.Clear()
        cboRoomDay.SelectedIndex = -1
        dtpRoomDate.Value = DateTime.Now
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtSchedID.Text) OrElse Not Integer.TryParse(txtSchedID.Text, Nothing) Then
            MessageBox.Show("Please enter a valid numeric schedule ID to delete.")
            Return
        End If

        Dim query As String = "DELETE FROM sched WHERE shed_id = @shed_id"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@shed_id", Integer.Parse(txtSchedID.Text)) ' Convert to Integer

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class