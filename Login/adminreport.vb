Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class adminreport

    Private Sub adminreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State <> ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        cboType.SelectedIndex = 0
        tableloader()
        txtsearch.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FeedbackReport_RoomSelection.Show()
        FeedbackReport_sender.type = "report"
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        AdminPage3.Show()
        Me.Hide()
    End Sub

    Private Sub tableloader()
        ' Ensure that a valid filter/category is selected before loading the data (if applicable)
        If cboType.Text = "Choose:" OrElse String.IsNullOrWhiteSpace(cboType.Text) Then
            MessageBox.Show("Please select a valid filter category.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Query to load report data and join with accounts to get the username
        Dim sqlQuery As String = "SELECT r.reportid AS report_id, a.username AS sender, r.d AS report_date, r.t AS report_time, r.report AS report_message " &
                             "FROM report r " &
                             "JOIN accounts a ON r.ID = a.ID"

        ' Optionally, apply a filter if a category is selected
        If cboType.Text <> "Choose:" Then
            sqlQuery &= " WHERE r.report LIKE @filter"
        End If

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Add parameters for filtering if applicable
            If cboType.Text <> "Choose:" Then
                Dim filterTerm As String = "%" & txtsearch.Text.Trim() & "%"  ' Assuming you have a textbox for the filter
                dataAdapter.SelectCommand.Parameters.AddWithValue("@filter", filterTerm)
            End If

            ' Fill the data into the DataTable
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

            ' Get the ID of the selected row
            Dim id As String = DGVreport.SelectedRows(0).Cells("FeedbackID").Value.ToString()

            viewreportfeedback.M_ID = id
            viewreportfeedback.type = "report"
            viewreportfeedback.Show()
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

        ' Get the report_id from the selected row in the table
        Dim reportId As String = DGVreport.SelectedRows(0).Cells("report_id").Value.ToString()

        ' Confirm with the user before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this report?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' Define the SQL query for deleting the report
        Dim sqlDeleteReport As String = "DELETE FROM report WHERE reportid = @report_id"

        ' Create the command for deleting the report
        Dim command As New MySqlCommand(sqlDeleteReport, conn)
        command.Parameters.AddWithValue("@report_id", reportId)

        ' Execute the delete
        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the delete command
            command.ExecuteNonQuery()
            MessageBox.Show("Report deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the table data after deletion
            tableloader()
        Catch ex As Exception
            MessageBox.Show("Error deleting report: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure that the user has selected a valid search category
        If cboType.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a valid search category.", "Category Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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