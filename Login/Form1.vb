Public Class roomstud

    Private connection As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;pwd=password;database=project")

    Private Sub LoadRoomData()

        ' Updated query to fetch all rooms from the sched table
        ' Define the query to get all relevant columns from the roomlist table
        Dim query As String = "SELECT room_code, room_name, building_letter, room_status FROM roomlist"
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, connection)
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


    Private Sub roomstud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Student.Show()
        Me.Hide()
    End Sub
End Class