Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class admin_feedback

    Private Sub admin_feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        feedback()
        cboType.SelectedIndex = 0
        txtsearch.Text = ""
    End Sub

    Private Sub feedback()
        ' Query to select feedback details along with username
        Dim query As String = "SELECT f.feedbackid, a.username AS sender, f.d, f.t " &
                          "FROM feedback f " &
                          "JOIN accounts a ON f.ID = a.ID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the feedback table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVfeedback.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVfeedback.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVfeedback.Columns
                If column.Name = "FeedbackID" Then
                    column.DataPropertyName = "feedbackid"
                ElseIf column.Name = "FeedbackDate" Then
                    column.DataPropertyName = "d"
                ElseIf column.Name = "FeedbackTime" Then
                    column.DataPropertyName = "t"
                ElseIf column.Name = "sender" Then
                    column.DataPropertyName = "sender"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
    End Sub


    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVfeedback.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row
            Dim id As String = DGVfeedback.SelectedRows(0).Cells("FeedbackID").Value.ToString()

            viewreportfeedback.M_ID = id
            viewreportfeedback.type = "feedback"
            viewreportfeedback.Show()
        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVfeedback.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row
            Dim id As String = DGVfeedback.SelectedRows(0).Cells("FeedbackID").Value.ToString()

            ' Confirm deletion
            If MessageBox.Show($"Are you sure you want to delete feedback ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ' Execute the delete query
                Dim query As String = "DELETE FROM feedback WHERE feedbackid = @id"
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@id", id)
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If

            ' Refresh the DataGridView after deletion
            feedback()
        Catch ex As Exception
            MessageBox.Show("Error deleting feedback record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate that the user has entered a search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate that the user has selected a valid search category
        If cboType.Text = "Choose:" OrElse String.IsNullOrWhiteSpace(cboType.Text) Then
            MessageBox.Show("Please select a valid search category.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = ""
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Select the query based on the selected search category
        Select Case cboType.Text
            Case "Feedback ID"
                query = "SELECT f.feedbackid, a.username AS sender, f.d, f.t, f.message AS feedback_message " &
                    "FROM feedback f " &
                    "JOIN accounts a ON f.ID = a.ID " &
                    "WHERE f.feedbackid LIKE @search"
            Case "Username"
                query = "SELECT f.feedbackid, a.username AS sender, f.d, f.t, f.message AS feedback_message " &
                    "FROM feedback f " &
                    "JOIN accounts a ON f.ID = a.ID " &
                    "WHERE a.username LIKE @search"
            Case "Date"
                query = "SELECT f.feedbackid, a.username AS sender, f.d, f.t, f.message AS feedback_message " &
                    "FROM feedback f " &
                    "JOIN accounts a ON f.ID = a.ID " &
                    "WHERE f.d LIKE @search"
            Case "Time"
                query = "SELECT f.feedbackid, a.username AS sender, f.d, f.t, f.message AS feedback_message " &
                    "FROM feedback f " &
                    "JOIN accounts a ON f.ID = a.ID " &
                    "WHERE f.t LIKE @search"
            Case Else
                MessageBox.Show("Invalid category selected. Please select a valid search category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Add wildcard characters for partial matching
        Dim parameterValue As String = "%" & searchTerm & "%"

        ' Create a DataTable to hold the search results
        Dim dataTable As New DataTable()

        ' Execute the query and bind the results
        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Create the data adapter with the query
            Dim dataAdapter As New MySqlDataAdapter(query, conn)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@search", parameterValue)

            ' Fill the DataTable with the search results
            dataAdapter.Fill(dataTable)

            ' Bind the results to the DataGridView
            DGVfeedback.AutoGenerateColumns = False
            DGVfeedback.DataSource = dataTable

            ' Rebind the DataGridView columns (adjust column names based on your DataGridView setup)
            DGVfeedback.Columns("feedbackid").DataPropertyName = "feedbackid"
            DGVfeedback.Columns("sender").DataPropertyName = "sender"
            DGVfeedback.Columns("date").DataPropertyName = "d"
            DGVfeedback.Columns("time").DataPropertyName = "t"
            DGVfeedback.Columns("message").DataPropertyName = "feedback_message"

        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        AdminPage3.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FeedbackReport_RoomSelection.Show()
        FeedbackReport_sender.type = "feedback"
    End Sub
End Class