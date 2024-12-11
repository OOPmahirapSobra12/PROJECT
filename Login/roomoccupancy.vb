Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class roomoccupancy
    Private currentRoomName As String = ""
    Private currentRoomCode As String = ""

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtpassword.Text = ""
        cbocodeorname.SelectedIndex = -1
        cboChoose.SelectedIndex = 0
    End Sub

    Private Sub roomoccupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        txtID.Text = U_ID
        cboChoose.SelectedIndex = 0
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        ' Check if required fields are filled
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or cbocodeorname.SelectedIndex = -1 Then
            MsgBox("Error: Please fill in all required fields!")
            Return
        End If

        ' Check if database connection is open
        If conn.State <> ConnectionState.Open Then
            MsgBox("Error: Database connection is not open.")
            Return
        End If

        ' Determine which field was selected in cboChoose
        Dim selectedRoomCode As String = ""
        Dim selectedRoomName As String = cbocodeorname.SelectedItem.ToString()

        If cboChoose.SelectedIndex = 1 Then
            ' If the Room code selected, fetch the room code directly
            selectedRoomCode = cbocodeorname.SelectedItem.ToString()
        ElseIf cboChoose.SelectedIndex = 2 Then
            ' If the Room name selected, fetch the room code corresponding to the selected room name
            selectedRoomName = cbocodeorname.SelectedItem.ToString()

            ' Query to get the room code from the room name
            Dim queryRoomCode As String = "SELECT room_code FROM roomlist WHERE room_name = @roomName"
            Try
                Using cmd As New MySqlCommand(queryRoomCode, conn)
                    cmd.Parameters.AddWithValue("@roomName", selectedRoomName)
                    selectedRoomCode = Convert.ToString(cmd.ExecuteScalar())
                End Using
            Catch ex As MySqlException
                MsgBox("MySQL Error: " & ex.Message)
                Return
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return
            End Try
        End If

        ' Query to get the latest room occupancy log
        Dim query As String = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time " &
                          "FROM room_logshistory WHERE room_code = @roomCode ORDER BY log_history_code DESC LIMIT 1"

        Try
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomCode", selectedRoomCode)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim currentOccupier As String = reader("ID").ToString()
                        Dim logOutDate As String = If(IsDBNull(reader("log_out_date")), Nothing, reader("log_out_date").ToString())
                        Dim logOutTime As String = If(IsDBNull(reader("log_out_time")), Nothing, reader("log_out_time").ToString())

                        ' Handle room status based on log data
                        If String.IsNullOrEmpty(logOutDate) Or String.IsNullOrEmpty(logOutTime) Then
                            ' The room is currently occupied
                            If currentOccupier = txtID.Text Then
                                If MessageBox.Show("You are occupying this room. Mark it as 'Not Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                    UpdateRoomStatus("Not Occupied")
                                    LogRoomHistory(txtID.Text, selectedRoomCode, "Not Occupied")
                                End If
                            Else
                                ' Get username of the current occupier
                                Using userCmd As New MySqlCommand("SELECT username FROM accounts WHERE ID = @userID", conn)
                                    userCmd.Parameters.AddWithValue("@userID", currentOccupier)
                                    Dim username As String = Convert.ToString(userCmd.ExecuteScalar())
                                    If MessageBox.Show($"This room is occupied by {username}. Mark it as 'Not Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                        UpdateRoomStatus("Not Occupied")
                                        LogRoomHistory(txtID.Text, selectedRoomCode, "Not Occupied")
                                    End If
                                End Using
                            End If
                        Else
                            ' The room is not occupied
                            If MessageBox.Show("This room is not occupied. Mark it as 'Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                UpdateRoomStatus("Occupied")
                                LogRoomHistory(txtID.Text, selectedRoomCode, "Occupied")
                            End If
                        End If
                    Else
                        ' No occupancy history found, mark as 'Occupied'
                        If MessageBox.Show("No occupancy history for this room. Mark it as 'Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            UpdateRoomStatus("Occupied")
                            LogRoomHistory(txtID.Text, selectedRoomCode, "Occupied")
                        End If
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateRoomStatus(newStatus As String)
        Dim updateQuery As String = "UPDATE roomlist SET occupancy_status = @newStatus WHERE room_code = @roomCode"

        Try
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@newStatus", newStatus)
                cmd.Parameters.AddWithValue("@roomCode", currentRoomCode)
                cmd.ExecuteNonQuery()
                MsgBox("Room status updated successfully!")
            End Using
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LogRoomHistory(userID As String, roomCode As String, action As String)
        Dim logQuery As String = "INSERT INTO room_logshistory (ID, room_code, log_in_date, log_in_time, log_out_date, log_out_time) " &
                                 "VALUES (@userID, @roomCode, @logInDate, @logInTime, NULL, NULL)"

        Try
            Using cmd As New MySqlCommand(logQuery, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.Parameters.AddWithValue("@roomCode", roomCode)
                cmd.Parameters.AddWithValue("@logInDate", DateTime.Now.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@logInTime", DateTime.Now.ToString("HH:mm:ss"))
                cmd.ExecuteNonQuery()
                MsgBox("Room status change logged successfully!")
            End Using
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cboChoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChoose.SelectedIndexChanged
        ' Clear the ComboBox before adding new items
        cbocodeorname.Items.Clear()

        If cboChoose.SelectedIndex = 1 Then
            ' Room code selected
            PopulateRoomCodes()
        ElseIf cboChoose.SelectedIndex = 2 Then
            ' Room name selected
            PopulateRoomNames()
        End If
    End Sub

    ' Method to populate ComboBox with room codes
    Private Sub PopulateRoomCodes()
        ' SQL query to fetch room codes (excluding rooms that are 'Closed')
        Dim query As String = "SELECT room_code FROM roomlist WHERE room_status <> 'Closed'"

        ' Clear previous items in ComboBox
        cbocodeorname.Items.Clear()

        Try
            ' Create a MySQL command to execute the query
            Dim cmd As New MySqlCommand(query, conn)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Add room codes to ComboBox
            While reader.Read()
                cbocodeorname.Items.Add(reader("room_code").ToString())
            End While

            reader.Close()
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Function to populate ComboBox with room names
    Private Sub PopulateRoomNames()
        ' SQL query to fetch room names (excluding rooms that are 'Closed')
        Dim query As String = "SELECT room_name FROM roomlist WHERE room_status <> 'Closed'"

        ' Clear previous items in ComboBox
        cbocodeorname.Items.Clear()

        Try
            ' Create a MySQL command to execute the query
            Dim cmd As New MySqlCommand(query, conn)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Add room names to ComboBox
            While reader.Read()
                cbocodeorname.Items.Add(reader("room_name").ToString())
            End While

            reader.Close()
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
End Class
