Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staff_feedback

    Private Sub staff_feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        feedback()
        cboType.SelectedIndex = 0
        txtsearch.Text = ""
    End Sub

    Public Sub feedback()
        ' Query to select necessary columns (ID, feedback date, time, feedback message, and username)
        Dim query As String = "SELECT feedback.feedbackid, feedback.d, feedback.t, feedback.feedback, accounts.username " &
                          "FROM feedback " &
                          "INNER JOIN accounts ON feedback.ID = accounts.ID"

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
                ElseIf column.Name = "FeedbackMessage" Then
                    column.DataPropertyName = "feedback"
                ElseIf column.Name = "Username" Then
                    column.DataPropertyName = "username"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
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
        ' Validate that the search term is not empty
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            feedback() ' Reload all data if no search term is provided
            Return
        End If

        ' Define the SQL query based on the selected search type
        Dim query As String = ""
        Dim searchTerm As String = "%" & txtsearch.Text.Trim() & "%" ' Add wildcards for flexible matching

        Select Case cboType.Text
            Case "Feedback ID"
                ' Search by Feedback ID
                query = "SELECT feedback.feedbackid, feedback.d, feedback.t, feedback.feedback, accounts.username " &
                    "FROM feedback " &
                    "INNER JOIN accounts ON feedback.ID = accounts.ID " &
                    "WHERE feedback.feedbackid LIKE @searchTerm"

            Case "Sender Name"
                ' Search by Sender Name (Username)
                query = "SELECT feedback.feedbackid, feedback.d, feedback.t, feedback.feedback, accounts.username " &
                    "FROM feedback " &
                    "INNER JOIN accounts ON feedback.ID = accounts.ID " &
                    "WHERE accounts.username LIKE @searchTerm"

            Case "Date Reported"
                ' Search by Date Reported
                query = "SELECT feedback.feedbackid, feedback.d, feedback.t, feedback.feedback, accounts.username " &
                    "FROM feedback " &
                    "INNER JOIN accounts ON feedback.ID = accounts.ID " &
                    "WHERE feedback.d LIKE @searchTerm"

            Case "Time Reported"
                ' Search by Time Reported
                query = "SELECT feedback.feedbackid, feedback.d, feedback.t, feedback.feedback, accounts.username " &
                    "FROM feedback " &
                    "INNER JOIN accounts ON feedback.ID = accounts.ID " &
                    "WHERE feedback.t LIKE @searchTerm"

            Case Else
                ' Handle invalid selection
                MessageBox.Show("Please select a valid search category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Execute the search query
        Dim table As New DataTable()
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@searchTerm", searchTerm)

            Try
                ' Open the connection if closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Bind the results to the DataGridView
                DGVfeedback.DataSource = table

                ' Notify if no results are found
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No matching records found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub



    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FeedbackReport_sender.Show()
        FeedbackReport_sender.type = "report"
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVfeedback.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row safely
            Dim selectedRow As DataGridViewRow = DGVfeedback.SelectedRows(0)
            Dim feedbackID As String = selectedRow.Cells("FeedbackID")?.Value?.ToString()

            If String.IsNullOrEmpty(feedbackID) Then
                MessageBox.Show("Invalid Feedback ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            viewreportfeedback.M_ID = feedbackID ' Assuming M_ID is a public property in the viewreportfeedback form
            viewreportfeedback.type = "feedback"  ' Assuming type is a public property in the viewreportfeedback form

            ' Show the view report feedback form
            viewreportfeedback.Show() ' Using ShowDialog for modal behavior
        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class