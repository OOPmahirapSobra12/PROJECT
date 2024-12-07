Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class requestapproval
    Public Property U_ID As String

    Private Sub requestapproval_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        LoadRequests()
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        AcceptedRequest_automation.R_ID = Nothing
        AcceptedRequest_automation.R_requestID = Nothing

        If DGVrequest.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DGVrequest.SelectedRows(0)
            Dim addForm As New addscheduleadmin()
            addForm.requestID = selectedRow.Cells("requestID").Value.ToString()
            AcceptedRequest_automation.R_ID = selectedRow.Cells("requesterID").Value.ToString()
            AcceptedRequest_automation.R_requestID = selectedRow.Cells("requestID").Value.ToString()
            addForm.ShowDialog()
            Me.Hide()
        Else
            Dim addForm As New addscheduleadmin()
            addForm.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        DeniedRequest.R_ID = Nothing
        DeniedRequest.R_requestID = Nothing

        If DGVrequest.SelectedRows.Count > 0 Then
            Try
                Dim selectedRequestID As Integer = Convert.ToInt32(DGVrequest.SelectedRows(0).Cells("requestID").Value)
                Dim selectedID As String = DGVrequest.SelectedRows(0).Cells("requesterID").Value.ToString()

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected request?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    DeniedRequest.R_ID = selectedID
                    DeniedRequest.R_requestID = selectedRequestID
                    DeleteRequest(selectedRequestID)
                    MessageBox.Show("Request deleted successfully.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while processing the request: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub DeleteRequest(requestID As Integer)
        Dim query As String = "DELETE FROM requests WHERE requestID = @requestID"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@requestID", requestID)

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                cmd.ExecuteNonQuery()
                LoadRequests()
                MessageBox.Show("Request deleted successfully.")
                ProcessDeniedRequests()
            Catch ex As Exception
                MessageBox.Show("Error deleting request: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadRequests()
        Dim query As String = "SELECT r.requestID, r.ID, r.request_d, rl.room_name, r.request_t_in, r.request_t_out, r.request " &
                              "FROM requests r " &
                              "INNER JOIN roomlist rl ON r.room_code = rl.room_code"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            DGVrequest.AutoGenerateColumns = False
            DGVrequest.DataSource = table

            For Each column As DataGridViewColumn In DGVrequest.Columns
                If column.Name = "requestID" Then
                    column.DataPropertyName = "requestID"
                ElseIf column.Name = "requesterID" Then
                    column.DataPropertyName = "ID"
                ElseIf column.Name = "requestdate" Then
                    column.DataPropertyName = "request_d"
                ElseIf column.Name = "room" Then
                    column.DataPropertyName = "room_name"
                ElseIf column.Name = "timerequest_in" Then
                    column.DataPropertyName = "request_t_in"
                ElseIf column.Name = "timerequest_out" Then
                    column.DataPropertyName = "request_t_out"
                ElseIf column.Name = "requesttext" Then
                    column.DataPropertyName = "request"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error retrieving requests: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If access = "high" Then
            Admin.Show()
        ElseIf access = "mid" Then
            Staff.Show()
            logs.L_ID = U_ID
            logs.action2 = "logout"
            staff_requestapproval_logs()
        Else
            MsgBox("Error, can't go back to the previous UI!")
        End If
        Me.Hide()
    End Sub

    Private Sub btnrequestreload_Click(sender As Object, e As EventArgs) Handles btnrequestreload.Click
        LoadRequests()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim category As String = cbosearch.SelectedItem?.ToString()
        Dim searchValue As String = txtsearchbox.Text.Trim()

        If String.IsNullOrEmpty(category) OrElse category = "Choose:" Then
            LoadRequests()
            Return
        End If

        Dim columnName As String = ""
        Select Case category
            Case "Request ID"
                columnName = "requestID"
            Case "Request Type"
                columnName = "request_type"
            Case "Requester"
                columnName = "ID"
            Case "Date Requested"
                columnName = "request_d"
            Case "Room Requested"
                columnName = "room_name"
            Case "Time-In"
                columnName = "request_t_in"
            Case "Time-Out"
                columnName = "request_t_out"
            Case "Request Message"
                columnName = "request"
            Case Else
                MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        If String.IsNullOrEmpty(searchValue) Then
            MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = $"SELECT r.requestID, r.ID, r.request_d, rl.room_name, r.request_t_in, r.request_t_out, r.request " &
                              $"FROM requests r " &
                              $"INNER JOIN roomlist rl ON r.room_code = rl.room_code WHERE {columnName} LIKE @search"
        Dim table As New DataTable()

        Try
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@search", "%" & searchValue & "%")
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)
                DGVrequest.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving filtered requests: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
