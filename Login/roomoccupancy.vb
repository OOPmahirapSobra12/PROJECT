Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class roomoccupancy
    Private currentRoomName As String = ""
    Private currentRoomCode As String = ""
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtpassword.Text = ""
        cbocodeorname.SelectedIndex = -1
        cboChoose.SelectedIndex = 0
    End Sub

    Private Sub roomoccupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        txtID.Text = U_ID
        cboChoose.SelectedIndex = 0
        btnregister.Enabled = False
    End Sub

    ' Function to search for room by code
    Private Sub roomcode()
        ' Check if any field is empty
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or cbocodeorname.SelectedIndex = -1 Then
            MsgBox("Error, please fill up all information!")
            Return
        End If

        ' Ensure the connection is open before proceeding
        If conn.State <> ConnectionState.Open Then
            MsgBox("Database connection is not open.")
            Return
        End If

        ' SQL query to find room_code in roomlist table and retrieve room_name
        Dim query As String = "SELECT room_name, room_code FROM roomlist WHERE room_code = @roomCode"

        Try
            ' Create MySQL command with parameters to avoid SQL injection
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@roomCode", cbocodeorname) ' Use the value from txtroom as room_code

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' If room is found
            If reader.HasRows Then
                reader.Read()
                ' Store the room details in the temporary variables
                currentRoomName = reader("room_name").ToString()
                currentRoomCode = reader("room_code").ToString()

                ' Enable the Register button after room verification
                btnregister.Enabled = True
            Else
                ' If room is not found, show an error message
                MsgBox("Room not found!")
            End If

            reader.Close()

        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    ' Function to search for room by name
    Private Sub roomname()
        ' Check if any field is empty
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or cbocodeorname.SelectedIndex = -1 Then
            MsgBox("Error, please fill up all information!")
            Return
        End If

        ' Ensure the connection is open before proceeding
        If conn.State <> ConnectionState.Open Then
            MsgBox("Database connection is not open.")
            Return
        End If

        ' SQL query to find room_name in roomlist table and retrieve room_code
        Dim query As String = "SELECT room_name, room_code FROM roomlist WHERE room_name = @roomName"

        Try
            ' Create MySQL command with parameters to avoid SQL injection
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@roomName", cbocodeorname) ' Use the value from txtroom as room_name

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' If room is found
            If reader.HasRows Then
                reader.Read()
                ' Store the room details in the temporary variables
                currentRoomName = reader("room_name").ToString()
                currentRoomCode = reader("room_code").ToString()

                ' Enable the Register button after room verification
                btnregister.Enabled = True
            Else
                ' If room is not found, show an error message
                MsgBox("Room not found!")
            End If

            reader.Close()

        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If cboChoose.SelectedIndex = 1 Then
            roomcode()
        ElseIf cboChoose.SelectedIndex = 2 Then
            roomname()
        Else
            MsgBox("Error, please choose properly if room code or name")
        End If
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        ' Check if any field is empty
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or cbocodeorname.SelectedIndex = -1 Then
            MsgBox("Error, please fill up all information!")
            Return
        End If

        ' Ensure the connection is open before proceeding
        If conn.State <> ConnectionState.Open Then
            MsgBox("Database connection is not open.")
            Return
        End If

        ' SQL query to get the most recent occupancy log for the room from roomhistory
        Dim query As String = "SELECT U_ID, log_date, log_time FROM roomhistory WHERE room_code = @roomCode OR room_name = @roomName ORDER BY log_history_code DESC LIMIT 1"

        Try
            ' Create MySQL command with parameters to avoid SQL injection
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@roomCode", currentRoomCode) ' Use room code as input
            cmd.Parameters.AddWithValue("@roomName", currentRoomName) ' Use room name as input (to search by name or code)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                ' Read the most recent entry
                reader.Read()
                Dim currentOccupier As String = reader("U_ID").ToString()
                Dim logDate As String = reader("log_date").ToString()
                Dim logTime As String = reader("log_time").ToString()

                ' Show a message based on the current status of the room
                If currentOccupier = txtID.Text Then
                    ' If the current user occupied the room, ask if they want to change it to "Not Occupied"
                    Dim result As DialogResult = MsgBox("This room is currently occupied by you. Do you want to change it to 'Not Occupied'?", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        ' Update the status to "Not Occupied" in roomlist
                        UpdateRoomStatus("Not Occupied")
                        ' Log the action in roomhistory
                        LogRoomHistory("Not Occupied")
                    End If
                Else
                    ' If another user occupied the room, show their username and ask if the user wants to change the status
                    Dim usernameQuery As String = "SELECT username FROM accounts WHERE user_id = @userID"
                    Dim usernameCmd As New MySqlCommand(usernameQuery, conn)
                    usernameCmd.Parameters.AddWithValue("@userID", currentOccupier)
                    Dim username As String = Convert.ToString(usernameCmd.ExecuteScalar())

                    Dim result As DialogResult = MsgBox("This room is currently occupied by " & username & ". Do you want to change it to 'Not Occupied'?", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        ' Update the status to "Not Occupied" in roomlist
                        UpdateRoomStatus("Not Occupied")
                        ' Log the action in roomhistory
                        LogRoomHistory("Not Occupied")
                    End If
                End If
            Else
                ' If the room is not in the history table (i.e., no previous record), the room is not occupied
                Dim result As DialogResult = MsgBox("This room is currently not occupied. Do you want to change it to 'Occupied'?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    ' Update the status to "Occupied" in roomlist
                    UpdateRoomStatus("Occupied")
                    ' Log the action in roomhistory
                    LogRoomHistory("Occupied")
                End If
            End If

            reader.Close()

        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    ' Function to update the room status in roomlist
    Private Sub UpdateRoomStatus(newStatus As String)
        ' SQL query to update the occupancy status of the room in roomlist
        Dim updateQuery As String = "UPDATE roomlist SET occupancy_status = @newStatus WHERE room_code = @roomCode OR room_name = @roomName"

        Try
            ' Create MySQL command with parameters to avoid SQL injection
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@newStatus", newStatus) ' Set the new status
            cmd.Parameters.AddWithValue("@roomCode", currentRoomCode) ' Use room code
            cmd.Parameters.AddWithValue("@roomName", currentRoomName) ' Use room name

            ' Execute the update query
            cmd.ExecuteNonQuery()
            MsgBox("Room status updated successfully!")
        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    ' Function to log the room status change in roomhistory
    Private Sub LogRoomHistory(newStatus As String)
        ' SQL query to insert the action into roomhistory
        Dim logQuery As String = "INSERT INTO roomhistory (U_ID, room_name, room_code, log_date, log_time) " &
                             "VALUES (@userID, @roomName, @roomCode, @logDate, @logTime)"

        Try
            ' Get the current date and time
            Dim logDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim logTime As String = DateTime.Now.ToString("HH:mm:ss")

            ' Create MySQL command with parameters to avoid SQL injection
            Dim cmd As New MySqlCommand(logQuery, conn)
            cmd.Parameters.AddWithValue("@userID", txtID.Text) ' Current user ID
            cmd.Parameters.AddWithValue("@roomName", currentRoomName) ' Room name
            cmd.Parameters.AddWithValue("@roomCode", currentRoomCode) ' Room code
            cmd.Parameters.AddWithValue("@logDate", logDate) ' Log date
            cmd.Parameters.AddWithValue("@logTime", logTime) ' Log time

            ' Execute the insert query to log the room status change
            cmd.ExecuteNonQuery()
            MsgBox("Room status change logged successfully!")
        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillComboBox(sender As Object, e As EventArgs) Handles cbocodeorname.DropDown
        ' Ensure the connection is open before proceeding
        If conn.State <> ConnectionState.Open Then
            MsgBox("Database connection is not open.")
            Return
        End If

        ' Clear previous items in the ComboBox
        cbocodeorname.Items.Clear()

        ' Check which option is selected in cboChoose
        If cboChoose.SelectedIndex = 1 Then
            ' If 'Code' is selected, fetch room codes excluding closed rooms
            Dim query As String = "SELECT room_code FROM roomlist WHERE room_status <> 'Closed'"
            Try
                ' Create MySQL command with parameters to avoid SQL injection
                Dim cmd As New MySqlCommand(query, conn)

                ' Execute the query and get the result
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Populate ComboBox with room codes (excluding closed rooms)
                While reader.Read()
                    cbocodeorname.Items.Add(reader("room_code").ToString())
                End While

                reader.Close()
            Catch ex As MySqlException
                MsgBox("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        ElseIf cboChoose.SelectedIndex = 2 Then
            ' If 'Name' is selected, fetch room names excluding closed rooms
            Dim query As String = "SELECT room_name FROM roomlist WHERE room_status <> 'Closed'"
            Try
                ' Create MySQL command with parameters to avoid SQL injection
                Dim cmd As New MySqlCommand(query, conn)

                ' Execute the query and get the result
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Populate ComboBox with room names (excluding closed rooms)
                While reader.Read()
                    cbocodeorname.Items.Add(reader("room_name").ToString())
                End While

                reader.Close()
            Catch ex As MySqlException
                MsgBox("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            ' If no valid selection is made in cboChoose, show a message
            MsgBox("Please choose whether to search by room code or room name.")
        End If
    End Sub
End Class