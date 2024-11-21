Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class reportreciever

    Private Sub report()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t FROM report"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Open the connection if it's not open
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVreport.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVreport.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVreport.Columns
                If column.Name = "ReportID" Then
                    column.DataPropertyName = "ID"
                ElseIf column.Name = "ReportDate" Then
                    column.DataPropertyName = "d"
                ElseIf column.Name = "ReportTime" Then
                    column.DataPropertyName = "t"
                ElseIf column.Name = "sender" Then
                    column.DataPropertyName = "sender"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        Finally
            ' Close the connection in the Finally block to ensure it always closes
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DeleteRecord(tableName As String, id As String)
        Dim query As String = $"DELETE FROM {tableName} WHERE ID = @id"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@id", id)

            Try
                ' Ensure the connection is open
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the delete command
                command.ExecuteNonQuery()
                MessageBox.Show($"{tableName} record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the report list after deletion
                report()

            Catch ex As Exception
                MessageBox.Show($"Error deleting {tableName} record: " & ex.Message)
            Finally
                ' Close the connection after operation
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub reportreciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        report()
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub btnsearch_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        If String.IsNullOrEmpty(txtsearchbox.Text) Then
            report()
        Else
            Dim category As String = cbosearch.Text()
            Dim search As String = txtsearchbox.Text()

            Dim query As String = ""

            ' Construct the SQL query based on the selected category
            Select Case cbosearch.Text
                Case "Choose:"
                    ' Search across all columns: report ID, Date, and Time
                    query = "SELECT sender, ID, d, t " &
                        "FROM report " &
                        "WHERE ID LIKE @search OR d LIKE @search OR t LIKE @search"

                Case "Report ID"
                    query = "SELECT sender, ID, d, t " &
                        "FROM report " &
                        "WHERE ID LIKE @search"

                Case "Date Reported"
                    query = "SELECT sender, ID, d, t " &
                        "FROM report " &
                        "WHERE d LIKE @search"

                Case "Time Reported"
                    query = "SELECT sender, ID, d, t " &
                        "FROM report " &
                        "WHERE t LIKE @search"

                Case Else
                    MessageBox.Show("Invalid category selected. Please select a valid search category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                DGVreport.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving room list: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVreport.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row
            Dim id As String = DGVreport.SelectedRows(0).Cells("ReportID").Value.ToString()

            ' Open the ViewFeedbackReport form and pass the ID
            Dim viewForm As New ViewFeedbackReport()
            viewForm.report_ID = id
            viewForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error retrieving report record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVreport.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the ID of the selected row
            Dim id As String = DGVreport.SelectedRows(0).Cells("ReportID").Value.ToString()

            ' Confirm deletion
            If MessageBox.Show($"Are you sure you want to delete report ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ' Execute the delete query
                Dim query As String = "DELETE FROM report WHERE ID = @id"
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
            report()
        Catch ex As Exception
            MessageBox.Show("Error deleting report record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
