Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staffreport

    Private Sub staffreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State <> ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        cboType.SelectedIndex = 0
        tableloader()
        txtsearch.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FeedbackReport_sender.Show()
        FeedbackReport_sender.type = "report"
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    Public Sub tableloader()
        ' Query to load report data and join with accounts to get the username
        Dim sqlQuery As String = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                             "FROM report r " &
                             "JOIN accounts a ON r.ID = a.ID"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Populate the data into the DataTable
            dataAdapter.Fill(dataTable)

            DGVreport.AutoGenerateColumns = False

            ' Bind the populated DataTable to the DataGridView
            DGVreport.DataSource = dataTable

            ' Set the correct data bindings for each column in the DataGridView
            DGVreport.Columns("report_id").DataPropertyName = "report_id"
            DGVreport.Columns("sender").DataPropertyName = "sender"
            DGVreport.Columns("report_date").DataPropertyName = "report_date"
            DGVreport.Columns("report_time").DataPropertyName = "report_time"
            DGVreport.Columns("report_message").DataPropertyName = "report_message"

        Catch ex As Exception
            MessageBox.Show("Error loading table data: " & ex.Message)
        Finally
            ' Ensure to close the connection after the operation
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVreport.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row safely
            Dim selectedRow As DataGridViewRow = DGVreport.SelectedRows(0)
            Dim reportID As String = selectedRow.Cells("report_id")?.Value?.ToString()

            If String.IsNullOrEmpty(reportID) Then
                MessageBox.Show("Invalid Feedback ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            viewreportfeedback.M_ID = reportID ' Assuming M_ID is a public  in the viewreportfeedback form
            viewreportfeedback.type = "report"  ' Assuming type is a public  in the viewreportfeedback form

            ' Show the view report feedback form
            viewreportfeedback.Show() ' Using ShowDialog for modal behavior
        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Ensure a row is selected before proceeding
        If DGVreport.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a report to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Retrieve the report ID from the selected row safely
            Dim selectedRow As DataGridViewRow = DGVreport.SelectedRows(0)
            Dim reportId As String = selectedRow.Cells("report_id")?.Value?.ToString()

            If String.IsNullOrWhiteSpace(reportId) Then
                MessageBox.Show("Invalid report ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Confirm with the user before deleting
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete report ID '{reportId}'?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If

            ' Define the SQL query for deleting the report
            Dim sqlDeleteReport As String = "DELETE FROM report WHERE reportid = @report_id"

            ' Create the command for deleting the report
            Using command As New MySqlCommand(sqlDeleteReport, conn)
                command.Parameters.AddWithValue("@report_id", reportId)

                ' Open the connection if not already open
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Execute the delete command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Report deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Reload the table data after successful deletion
                    tableloader()
                Else
                    MessageBox.Show("No report found with the provided ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after the operation
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate that the user has entered a search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            tableloader()
            Return
        End If

        ' Define the base SQL query and category to search by
        Dim sqlQuery As String = ""
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Use the selected index of the dropdown to determine the search category
        Select Case cboType.SelectedIndex
            Case 1  ' Search by Report ID
                sqlQuery = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                           "FROM report r " &
                           "JOIN accounts a ON r.ID = a.ID " &
                           "WHERE r.reportid LIKE @searchTerm"
            Case 2  ' Search by Username
                sqlQuery = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                           "FROM report r " &
                           "JOIN accounts a ON r.ID = a.ID " &
                           "WHERE a.username LIKE @searchTerm"
            Case 3  ' Search by Date
                sqlQuery = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                           "FROM report r " &
                           "JOIN accounts a ON r.ID = a.ID " &
                           "WHERE r.d LIKE @searchTerm"
            Case 4  ' Search by Time
                sqlQuery = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                           "FROM report r " &
                           "JOIN accounts a ON r.ID = a.ID " &
                           "WHERE r.t LIKE @searchTerm"
            Case Else
                MessageBox.Show("Please select a valid search category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Prepare the search term for a wildcard search
        Dim parameterValue As String = "%" & searchTerm & "%"

        ' Create a new DataAdapter to execute the query
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", parameterValue)

        ' Create a DataTable to hold the search results
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with search results
            dataAdapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            DGVreport.AutoGenerateColumns = False
            DGVreport.DataSource = dataTable

            ' Rebind the DataGridView columns
            DGVreport.Columns("report_id").DataPropertyName = "report_id"
            DGVreport.Columns("sender").DataPropertyName = "sender"
            DGVreport.Columns("report_date").DataPropertyName = "report_date"
            DGVreport.Columns("report_time").DataPropertyName = "report_time"
            DGVreport.Columns("report_message").DataPropertyName = "report_message"

        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class