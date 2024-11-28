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
        Report_Feedbacksender.Show()
        type = "report"
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    Private Sub tableloader()
        ' Query to load data from both sched and schedtemp tables, including shed_id
        Dim sqlQuery As String = "SELECT * FROM report;"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the data into the DataTable
            dataAdapter.Fill(dataTable)

            DGVreport.AutoGenerateColumns = False

            ' Bind the populated DataTable to the DataGridView
            DGVreport.DataSource = dataTable

            ' Set the correct data bindings for each column in the DataGridView
            DGVreport.Columns("report_id").DataPropertyName = "ID"  ' Bind shed_id to sched_code
            DGVreport.Columns("sender").DataPropertyName = "sender"
            DGVreport.Columns("report_date").DataPropertyName = "d"
            DGVreport.Columns("report_time").DataPropertyName = "t"
            DGVreport.Columns("report_message").DataPropertyName = "message"

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

            ' Open the ViewFeedbackReport form and pass the ID
            Dim viewForm As New viewreportfeedback()
            M_ID = id
            type = "report"
            viewForm.Show()
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
        Dim sqlDeleteReport As String = "DELETE FROM report WHERE report_id = @report_id"

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

        ' Get the selected category and search term
        Dim selectedCategory As String

        ' Use Select Case to determine the selected category
        Select Case cboType.SelectedIndex
            Case 1
                selectedCategory = "ID"
            Case 2
                selectedCategory = "sender"
            Case 3
                selectedCategory = "d"
            Case 4
                selectedCategory = "t"
            Case Else
                MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select


        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Construct the SQL query based on the selected category
        Dim sqlQuery As String = $"SELECT * FROM report WHERE {selectedCategory} LIKE @searchTerm"

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
            DGVreport.DataSource = dataTable
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