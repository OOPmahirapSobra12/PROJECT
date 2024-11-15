Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class accountlogs
    Private Sub accountlogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        LoadAccountLogs()
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub LoadAccountLogs()
        ' Query to select necessary columns (U_ID, log_in_date, log_in_time, log_out_date, log_out_time)
        Dim query As String = "SELECT U_ID, log_in_date, log_in_time, log_out_date, log_out_time FROM login_history"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the login_history table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVaccountlogs.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVaccountlogs.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVaccountlogs.Columns
                If column.Name = "Username" Then
                    column.DataPropertyName = "U_ID"
                ElseIf column.Name = "DateIn" Then
                    column.DataPropertyName = "log_in_date"
                ElseIf column.Name = "TimeIn" Then
                    column.DataPropertyName = "log_in_time"
                ElseIf column.Name = "DateOut" Then
                    column.DataPropertyName = "log_out_date"
                ElseIf column.Name = "TimeOut" Then
                    column.DataPropertyName = "log_out_time"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving account logs: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If String.IsNullOrEmpty(txtsearchbox.Text) Then
            LoadAccountLogs()
        Else
            Dim category As String = cbosearch.Text
            Dim search As String = txtsearchbox.Text

            Dim query As String = ""

            ' Construct the SQL query based on the selected category
            Select Case category
                Case "Username"
                    query = "SELECT * FROM login_history WHERE U_ID LIKE @search"
                Case "Date In"
                    query = "SELECT * FROM login_history WHERE log_in_date LIKE @search"
                Case "Date Out"
                    query = "SELECT * FROM login_history WHERE log_out_date LIKE @search"
                Case "Time In"
                    query = "SELECT * FROM login_history WHERE log_in_time LIKE @search"
                Case "Time Out"
                    query = "SELECT * FROM login_history WHERE log_out_time LIKE @search"
                Case Else
                    MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
            End Select

            ' Create the MySqlCommand object
            Dim command As New MySqlCommand(query, conn)

            ' Add the parameter for the search term, using '%' for partial matching
            command.Parameters.AddWithValue("@search", "%" & search & "%")

            Dim table As New DataTable()

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Bind the DataTable to the DataGridView
                DGVaccountlogs.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving account logs: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
End Class
