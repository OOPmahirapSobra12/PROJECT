Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class feedbackreciever

    Private Sub feedback()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t, sender FROM feedback"
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
                    column.DataPropertyName = "ID"
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


    Private Sub feedbackreciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        feedback()
        cbosearch.SelectedIndex = 0
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

            ' Open the ViewFeedbackReport form and pass the ID
            Dim viewForm As New viewreportfeedback()
            M_ID = id
            type = "feedback"
            viewForm.Show()
            Me.Hide()
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
                Dim query As String = "DELETE FROM feedback WHERE ID = @id"
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

    Private Sub btnsearch_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' If the textbox is empty, refresh the data
        If String.IsNullOrEmpty(txtsearchbox.Text.Trim()) Then
            feedback() ' Refresh the DataGridView by reloading all data
            Return
        End If

        ' Get the search term from the textbox
        Dim searchTerm As String = txtsearchbox.Text.Trim()
        Dim query As String = ""

        ' Check the selected combo box item
        Select Case cbosearch.Text
            Case "Choose:"
                ' Search across all columns: Feedback ID, Date, and Time
                query = "SELECT sender, ID, d, t " &
                        "FROM feedback " &
                        "WHERE ID LIKE @search OR d LIKE @search OR t LIKE @search"

            Case "Feedback ID"
                query = "SELECT sender, ID, d, t " &
                        "FROM feedback " &
                        "WHERE ID LIKE @search"

            Case "Date"
                query = "SELECT sender, ID, d, t " &
                        "FROM feedback " &
                        "WHERE d LIKE @search"

            Case "Time"
                query = "SELECT sender, ID, d, t " &
                        "FROM feedback " &
                        "WHERE t LIKE @search"

            Case Else
                MessageBox.Show("Invalid category selected. Please select a valid search category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        ' Execute the search query
        Dim table As New DataTable()
        Using command As New MySqlCommand(query, conn)
            ' Add the search parameter with wildcard matching
            command.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

            Try
                ' Open the connection if it is closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                ' Bind the results to the DataGridView
                DGVfeedback.DataSource = table

                ' Notify the user if no results are found
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No matching records found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
End Class
