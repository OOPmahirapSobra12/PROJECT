Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class roomoccupancy
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtpassword.Text = ""
        cbocodeorname.SelectedIndex = -1
        cboChoose.SelectedIndex = 0
    End Sub

    Private Sub roomoccupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CloseExistingConnection()
            ConnectToDatabase()
            InitializeForm()
        Catch ex As Exception
            HandleError("Form Load Error", ex)
        End Try
    End Sub

    Private Sub CloseExistingConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub ConnectToDatabase()
        DbConnect()
    End Sub

    Private Sub InitializeForm()
        txtID.Text = U_ID
        cboChoose.SelectedIndex = 0
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Try
            If Not ValidateInput() Then Return

            Dim selectedRoomCode As String = GetSelectedRoomCode()
            If String.IsNullOrEmpty(selectedRoomCode) Then
                MessageBox.Show("Unable to determine room code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                ProcessRoomOccupancy(selectedRoomCode)
            End If
        Catch ex As Exception
            HandleError("Room Registration Error", ex)
        Finally
            CloseExistingConnection()
        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(txtID.Text) OrElse
           String.IsNullOrEmpty(txtpassword.Text) OrElse
           cbocodeorname.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Function GetSelectedRoomCode() As String
        Dim selectedRoomCode As String = ""
        Try
            CloseExistingConnection()
            ConnectToDatabase()

            If cboChoose.SelectedIndex = 1 Then
                ' Room code selected directly
                selectedRoomCode = cbocodeorname.SelectedItem.ToString()
            ElseIf cboChoose.SelectedIndex = 2 Then
                ' Room name selected, fetch room code
                selectedRoomCode = FetchRoomCodeByName(cbocodeorname.SelectedItem.ToString())
            End If
        Catch ex As Exception
            HandleError("Room Code Retrieval Error", ex)
        Finally
            CloseExistingConnection()
        End Try
        Return selectedRoomCode
    End Function

    Private Function FetchRoomCodeByName(roomName As String) As String
        Dim query As String = "SELECT room_code FROM roomlist WHERE room_name = @roomName"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@roomName", roomName)
            Return Convert.ToString(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub ProcessRoomOccupancy(roomCode As String)
        Try
            CloseExistingConnection()
            ConnectToDatabase()

            Dim latestLog = FetchLatestRoomLog(roomCode)

            If latestLog Is Nothing Then
                ' No occupancy history
                PromptAndUpdateRoomStatus(code:=roomCode, status:="Occupied")
            Else
                HandleExistingRoomLog(latestLog, roomCode)
            End If
        Catch ex As Exception
            HandleError("Room Occupancy Processing Error", ex)
        Finally
            CloseExistingConnection()
        End Try
    End Sub

    Private Function FetchLatestRoomLog(roomCode As String) As Dictionary(Of String, Object)
        Dim query As String = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time " &
                               "FROM room_logshistory WHERE room_code = @roomCode ORDER BY log_history_code DESC LIMIT 1"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@roomCode", roomCode)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Return New Dictionary(Of String, Object) From {
                        {"ID", reader("ID").ToString()},
                        {"log_out_date", If(IsDBNull(reader("log_out_date")), Nothing, reader("log_out_date").ToString())},
                        {"log_out_time", If(IsDBNull(reader("log_out_time")), Nothing, reader("log_out_time").ToString())}
                    }
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Private Sub HandleExistingRoomLog(latestLog As Dictionary(Of String, Object), roomCode As String)
        Dim currentOccupier = latestLog("ID").ToString()
        Dim logOutDate = latestLog("log_out_date")
        Dim logOutTime = latestLog("log_out_time")

        If String.IsNullOrEmpty(logOutDate) OrElse String.IsNullOrEmpty(logOutTime) Then
            If currentOccupier = txtID.Text Then
                PromptAndUpdateRoomStatus(code:=roomCode, status:="Not Occupied")
            Else
                HandleOccupiedByOtherUser(currentOccupier, roomCode)
            End If
        Else
            PromptAndUpdateRoomStatus(code:=roomCode, status:="Occupied")
        End If
    End Sub

    Private Sub HandleOccupiedByOtherUser(currentOccupier As String, roomCode As String)
        Dim username = FetchUsername(currentOccupier)
        Dim result = MessageBox.Show($"This room is occupied by {username}. Mark it as 'Not Occupied'?",
                                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            newStatus = "Not Occupied"
            room_code = roomCode
            UpdateRoomStatus()
            LogRoomHistory(txtID.Text, roomCode)
        End If
    End Sub

    Private Function FetchUsername(userID As String) As String
        Dim query As String = "SELECT username FROM accounts WHERE ID = @userID"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", userID)
            Return Convert.ToString(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub PromptAndUpdateRoomStatus(code As String, status As String)
        Dim result = MessageBox.Show($"Do you want to mark this room as '{status}'?",
                                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            newStatus = status
            room_code = code
            MessageBox.Show(newStatus, room_code)
            UpdateRoomStatus()
            LogRoomHistory(txtID.Text, roomCode:=code)
        End If
    End Sub

    Private Sub HandleError(context As String, ex As Exception)
        MessageBox.Show($"{context}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private newStatus As String
    Private room_code As String
    Private Sub UpdateRoomStatus()
        MessageBox.Show(newStatus, room_code)
        Dim updateQuery As String = "UPDATE roomlist SET occupancy_status = @newStatus WHERE room_code = @roomCode"

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@newStatus", newStatus)
                cmd.Parameters.AddWithValue("@roomCode", room_code)
                cmd.ExecuteNonQuery()
                MsgBox("Room status updated successfully!")
            End Using
        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub LogRoomHistory(userID As String, roomCode As String)
        Dim logQuery As String = "INSERT INTO room_logshistory (ID, room_code, log_in_date, log_in_time, log_out_date, log_out_time) " &
                                 "VALUES (@userID, @roomCode, @logInDate, @logInTime, NULL, NULL)"

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If
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
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
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
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If
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
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' Function to populate ComboBox with room names
    Private Sub PopulateRoomNames()
        ' SQL query to fetch room names (excluding rooms that are 'Closed')
        Dim query As String = "SELECT room_name FROM roomlist WHERE room_status <> 'Closed'"

        ' Clear previous items in ComboBox
        cbocodeorname.Items.Clear()

        Try
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If
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
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
End Class