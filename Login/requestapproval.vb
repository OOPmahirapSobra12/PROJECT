Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class requestapproval
    Public Property U_ID As String

    Private Sub requestapproval_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        LoadRequests()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to add a new schedule?", "Confirm Creation of New Schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Check if a row is selected in the DGVrequest DataGridView
            If DGVrequest.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DGVrequest.SelectedRows(0)

                ' Create an instance of the add schedule form
                Dim addForm As New addscheduleadmin()

                ' Transfer the requestID to the add schedule form
                addForm.requestID = selectedRow.Cells("requestID").Value.ToString()

                ' Show the add schedule form with data from the selected row
                addForm.ShowDialog()
                Me.Hide()
            Else
                ' Create and show the add schedule form without transferring any data
                Dim addForm As New addscheduleadmin()
                addForm.ShowDialog()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DGVrequest.SelectedRows.Count > 0 Then
            Dim selectedRequestID As Integer = Convert.ToInt32(DGVrequest.SelectedRows(0).Cells("requestID").Value)

            ' Confirm deletion of request
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected request?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteRequest(selectedRequestID)
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    ' Delete request by ID
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
            Catch ex As Exception
                MessageBox.Show("Error deleting request: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Load requests from the database and bind to DataGridView
    Private Sub LoadRequests()
        ' Query to select necessary columns (requestID, requesterID, request_d, request_t, room, request_t_in, request_t_out, request)
        Dim query As String = "SELECT requestID, requesterID, request_d, request_t, room, request_t_in, request_t_out, request FROM requests"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the requests table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVrequest.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVrequest.DataSource = table

            ' Manually map the data to the existing columns in the DataGridView
            For Each column As DataGridViewColumn In DGVrequest.Columns
                If column.Name = "requestID" Then
                    column.DataPropertyName = "requestID"
                ElseIf column.Name = "requesterID" Then
                    column.DataPropertyName = "requesterID"
                ElseIf column.Name = "requestdate" Then
                    column.DataPropertyName = "request_d"
                ElseIf column.Name = "requesttime" Then
                    column.DataPropertyName = "request_t"
                ElseIf column.Name = "room" Then
                    column.DataPropertyName = "room"
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
        Admin.Show()
        Me.Hide()
    End Sub
End Class
