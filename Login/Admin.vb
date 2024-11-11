Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Admin

    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        report()
        feedback()
        accountname_reload()
    End Sub

    Private Sub report()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t FROM report"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
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
                End If
            Next

            ' Set the text for the buttons in the ReportView and ReportDelete columns
            SetButtonText(DGVreport, "ReportView")
            SetButtonText(DGVreport, "ReportDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        End Try
    End Sub

    Private Sub feedback()
        ' Query to select necessary columns (ID, d, t)
        Dim query As String = "SELECT ID, d, t FROM feedback"
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
                End If
            Next

            ' Set the text for the buttons in the FeedbackView and FeedbackDelete columns
            SetButtonText(DGVfeedback, "FeedbackView")
            SetButtonText(DGVfeedback, "FeedbackDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreport.CellContentClick, DGVfeedback.CellContentClick
        If e.RowIndex < 0 Then Return ' Avoid header row

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim id As String = dgv.Rows(e.RowIndex).Cells(0).Value.ToString() ' Assuming ID is the first column

        If dgv.Columns(e.ColumnIndex).Name.Contains("View") Then
            Dim viewForm As New ViewFeedbackReport()
            If dgv.Name = "DGVreport" Then
                viewForm.report_ID = id
            Else
                viewForm.feedback_ID = id
            End If
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
                report()
                feedback()
            End Try
        End Using
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        report()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        feedback()
    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click
        AccountManagement.Show()
        Me.Hide()
    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    Private Sub accountname_reload()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@U_ID", UniversalDim.U_ID)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query and get the username
                Dim result As Object = command.ExecuteScalar()

                ' Check if the result is not null (Nothing)
                If result IsNot Nothing Then
                    Dim username As String = result.ToString()
                    ' Update the button's text with the welcome message
                    btnprofile.Text = "Welcome " & username
                Else
                    ' Handle case where no username is found
                    MessageBox.Show("No username found for the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error retrieving username from database! Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        profile.Show()
        Me.Hide()
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        RoomListForm.Show()

        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim scheduleForm As New Schedule

        ' Show the Schedule form
        scheduleForm.Show()

        ' Optionally, you can hide the current form if you don't want it to be visible
        Me.Hide()
    End Sub
End Class
