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

            ' Set the text for the buttons in the FeedbackView and FeedbackDelete columns
            SetButtonText(DGVfeedback, "FeedbackView")
            SetButtonText(DGVfeedback, "FeedbackDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return ' Avoid header row

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim id As String = dgv.Rows(e.RowIndex).Cells(0).Value.ToString() ' Assuming ID is the first column

        If dgv.Columns(e.ColumnIndex).Name.Contains("View") Then
            Dim viewForm As New ViewFeedbackReport()
            viewForm.feedback_ID = id
            viewForm.Show()
            Me.Hide()

        ElseIf dgv.Columns(e.ColumnIndex).Name.Contains("Delete") Then
            Dim tableName As String = If(dgv.Name = "DGVreport", "report", "feedback")
            DeleteRecord(tableName, id)
        End If
    End Sub

    Private Sub DeleteRecord(tableName As String, id As String)
        Dim query As String = $"DELETE FROM {tableName} WHERE ID = @id"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@id", id)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                command.ExecuteNonQuery()
                MessageBox.Show($"{tableName} record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error deleting {tableName} record: " & ex.Message)
            Finally
                conn.Close()
                feedback()
            End Try
        End Using
    End Sub

    Private Sub SetButtonText(dgv As DataGridView, columnName As String)
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In dgv.Rows
            If row.IsNewRow Then
                Continue For ' Skip the new row placeholder
            End If

            ' Ensure the button is of the correct type (DataGridViewButtonCell)
            Dim buttonCell As DataGridViewButtonCell = TryCast(row.Cells(columnName), DataGridViewButtonCell)

            ' Check if the button cell exists and set the value (text) of the button
            If buttonCell IsNot Nothing Then
                buttonCell.Value = "View" ' or "Delete", depending on the column
                If columnName.Contains("Delete") Then
                    buttonCell.Value = "Delete" ' Set Delete text for Delete buttons
                End If
            End If
        Next
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(txtsearchbox.Text) Then
            feedback()
        Else
            Dim category As String = cbosearch.Text()
            Dim search As String = txtsearchbox.Text()

            Dim query As String = ""

            ' Construct the SQL query based on the selected category
            Select Case category
                Case "Feedback ID"
                    query = "SELECT * FROM report WHERE d LIKE @search"
                Case "Date"
                    query = "SELECT * FROM report WHERE d LIKE @search"
                Case "Time"
                    query = "SELECT * FROM report WHERE t LIKE @search"
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
                DGVfeedback.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving room list: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub feedbackreciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        feedback()
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub
End Class
