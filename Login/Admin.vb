Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule
Public Class Admin
    Public Property U_ID As String
    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        MessageBox.Show(U_ID)
        DbConnect()
        report()
        feedback()
        accountname_reload()
        FormatDataGridViews_report()
        FormatDataGridViews_feedback()
    End Sub
    Private Sub report()
        Dim query As String = "SELECT d,t,report FROM report"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVreport.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        End Try
    End Sub

    Private Sub feedback()
        Dim query As String = "SELECT d,t,feedback FROM feedback" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVfeedback.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDataGridViews_report()
        ' Format the reports DataGridView
        If DGVreport.Rows.Count > 0 Then ' Check if there are rows
            With DGVreport
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Report"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVreport
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Report"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub FormatDataGridViews_feedback()
        ' Format the feedback DataGridView
        If DGVfeedback.Rows.Count > 0 Then ' Check if there are rows
            With DGVfeedback
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Feedback"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVfeedback
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Feedback"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub


    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        report()
        FormatDataGridViews_report()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        feedback()
        FormatDataGridViews_feedback()
    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click

    End Sub

    Private Sub btnapproval_Click(sender As Object, e As EventArgs) Handles btnapproval.Click
        requestapproval.Show()
        Me.Hide()
    End Sub

    Private Sub DGVreport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreport.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGVreport.Rows(e.RowIndex)
            Dim reportId As String = selectedRow.Cells("report_id").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Do you want to delete the report?", "Delete Report",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Code to delete the report
                DeleteReport(reportId)
                MessageBox.Show("Report deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                report() ' Refresh report data
                FormatDataGridViews_report() ' Reformat the DataGridView
            Else
                MessageBox.Show("Feature not yet available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DGVfeedback_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVfeedback.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGVfeedback.Rows(e.RowIndex)
            Dim feedbackId As String = selectedRow.Cells("feedback_id").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Do you want to delete the feedback?",
                                                          "Delete Feedback",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Code to delete the feedback
                DeleteFeedback(feedbackId)
                MessageBox.Show("Feedback deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                feedback() ' Refresh feedback data
                FormatDataGridViews_feedback() ' Reformat the DataGridView
            Else
                MessageBox.Show("Feature not yet available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' Sample deletion method (implement as needed)
    Private Sub DeleteReport(reportId As String)
        Dim query As String = "DELETE FROM report WHERE report_id = @reportId"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@reportId", reportId)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error deleting report: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Sample deletion method (implement as needed)
    Private Sub DeleteFeedback(feedbackId As String)
        Dim query As String = "DELETE FROM feedback WHERE feedback_id = @feedbackId"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@feedbackId", feedbackId)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error deleting feedback: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub accountname_reload()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@U_ID", U_ID)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim scheduleForm As New Schedule

        ' Show the Schedule form
        scheduleForm.Show()

        ' Optionally, you can hide the current form if you don't want it to be visible
        Me.Hide()
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        RoomListForm.Show()

        Me.Hide()
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click

    End Sub
End Class