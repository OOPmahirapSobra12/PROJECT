﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class accountlogs

    Private Sub accountlogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Close the connection if it is open
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        ' Connect to the database
        DbConnect()

        ' Load account logs into the DataGridView
        LoadAccountLogs()

        ' Set default search category
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub LoadAccountLogs()
        ' Query to join login_history and accounts tables
        Dim query As String = "SELECT lh.ID, a.username, lh.log_in_date, lh.log_in_time, lh.log_out_date, lh.log_out_time " &
                          "FROM login_history lh " &
                          "JOIN accounts a ON lh.ID = a.ID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Populate the DataTable with data from the login_history table (with username from accounts)
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVaccountlogs.AutoGenerateColumns = False ' Prevent auto-generation of columns
            DGVaccountlogs.DataSource = table

            ' Disable user interaction for adding new columns or rows
            DGVaccountlogs.AllowUserToAddRows = False  ' Prevent adding new rows
            DGVaccountlogs.AllowUserToDeleteRows = False ' Prevent deleting rows
            DGVaccountlogs.AllowUserToOrderColumns = False ' Prevent reordering columns
            DGVaccountlogs.AllowUserToResizeColumns = False ' Prevent resizing columns if needed
            DGVaccountlogs.AllowUserToResizeRows = False ' Prevent resizing rows

            ' Manually map the data to the existing columns in DGVaccountlogs
            For Each column As DataGridViewColumn In DGVaccountlogs.Columns
                If column.Name = "username" Then
                    column.DataPropertyName = "username" ' Bind username to the column
                ElseIf column.Name = "datein" Then
                    column.DataPropertyName = "log_in_date"
                ElseIf column.Name = "timein" Then
                    column.DataPropertyName = "log_in_time"
                ElseIf column.Name = "dateout" Then
                    column.DataPropertyName = "log_out_date"
                ElseIf column.Name = "timeout" Then
                    column.DataPropertyName = "log_out_time"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving account logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnsearch_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' If the search box is empty, refresh the data
        If String.IsNullOrEmpty(txtsearchbox.Text.Trim()) Then
            LoadAccountLogs() ' Reload all logs
            Return
        End If

        ' Get the search term and selected category
        Dim searchTerm As String = txtsearchbox.Text.Trim()
        Dim query As String = ""

        ' Handle search based on the selected category
        Select Case cbosearch.Text
            Case "Choose:"
                ' Search across all relevant columns
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time " &
                        "FROM login_history " &
                        "WHERE ID LIKE @search OR log_in_date LIKE @search OR log_in_time LIKE @search OR " &
                        "log_out_date LIKE @search OR log_out_time LIKE @search"

            Case "Username"
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE ID LIKE @search"
            Case "Date In"
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE log_in_date LIKE @search"
            Case "Date Out"
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE log_out_date LIKE @search"
            Case "Time In"
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE log_in_time LIKE @search"
            Case "Time Out"
                query = "SELECT ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history WHERE log_out_time LIKE @search"
            Case Else
                MessageBox.Show("Invalid search category. Please select a valid category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Execute the search query
        Dim table As New DataTable()
        Using command As New MySqlCommand(query, conn)
            ' Add parameter for partial matching
            command.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

            Try
                ' Open the database connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Fill the DataTable with the query results
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Bind the results to the DataGridView
                DGVaccountlogs.DataSource = table

                ' Notify if no matching records are found
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No matching records found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        ' Close the current form
        Me.Close()
    End Sub
End Class

