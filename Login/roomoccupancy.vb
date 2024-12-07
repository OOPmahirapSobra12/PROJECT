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
        btnregister.Enabled = False
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or cbocodeorname.SelectedIndex = -1 Then
            MsgBox("Error: Please fill in all required fields!")
            Return
        End If

        If conn.State <> ConnectionState.Open Then
            MsgBox("Error: Database connection is not open.")
            Return
        End If

        Dim query As String = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time " &
                              "FROM room_logshistory WHERE room_code = @roomCode ORDER BY log_history_code DESC LIMIT 1"

        Try
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomCode", currentRoomCode)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim currentOccupier As String = reader("ID").ToString()
                        Dim logOutDate As String = If(IsDBNull(reader("log_out_date")), Nothing, reader("log_out_date").ToString())
                        Dim logOutTime As String = If(IsDBNull(reader("log_out_time")), Nothing, reader("log_out_time").ToString())

                        If String.IsNullOrEmpty(logOutDate) Or String.IsNullOrEmpty(logOutTime) Then
                            If currentOccupier = txtID.Text Then
                                If MessageBox.Show("You are occupying this room. Mark it as 'Not Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                    UpdateRoomStatus("Not Occupied")
                                    LogRoomHistory(txtID.Text, currentRoomCode, "Not Occupied")
                                End If
                            Else
                                Using userCmd As New MySqlCommand("SELECT username FROM accounts WHERE ID = @userID", conn)
                                    userCmd.Parameters.AddWithValue("@userID", currentOccupier)
                                    Dim username As String = Convert.ToString(userCmd.ExecuteScalar())
                                    If MessageBox.Show($"This room is occupied by {username}. Mark it as 'Not Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                        UpdateRoomStatus("Not Occupied")
                                        LogRoomHistory(txtID.Text, currentRoomCode, "Not Occupied")
                                    End If
                                End Using
                            End If
                        Else
                            If MessageBox.Show("This room is not occupied. Mark it as 'Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                UpdateRoomStatus("Occupied")
                                LogRoomHistory(txtID.Text, currentRoomCode, "Occupied")
                            End If
                        End If
                    Else
                        If MessageBox.Show("No occupancy history for this room. Mark it as 'Occupied'?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            UpdateRoomStatus("Occupied")
                            LogRoomHistory(txtID.Text, currentRoomCode, "Occupied")
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
End Class
