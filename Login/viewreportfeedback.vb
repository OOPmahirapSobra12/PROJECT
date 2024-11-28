Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class viewreportfeedback
    Public message_ID As String = M_ID
    Private Sub viewreportfeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        ' Check if report_ID is not empty, if so, load report data
        If type = "report" Then
            loadReport(message_ID)
            cbotype.SelectedIndex = 1
            lbltitle.Text = "Report"
            ' Check if feedback_ID is not empty, if so, load feedback data
        ElseIf type = "feedback" Then
            loadFeedback(message_ID)
            cbotype.SelectedIndex = 2
            lbltitle.Text = "Feedback"
        Else
            ' Show error if neither report_ID nor feedback_ID is provided
            MessageBox.Show("Error: No valid report or feedback ID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DbConnect()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        M_ID = ""
        Me.Hide()
    End Sub

    Public Sub loadReport(message_ID As String)
        Dim query As String = "SELECT sender, d, t, report FROM report WHERE ID = @reportID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@reportID", message_ID)

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtusername.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()
                txtmessage.Text = row("report").ToString()
            Else
                MessageBox.Show("No report found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving report: " & ex.Message)
        End Try
    End Sub

    ' Separate method to load feedback data
    Public Sub loadFeedback(message_ID As String)
        Dim query As String = "SELECT sender, d, t, feedback FROM feedback WHERE ID = @feedbackID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@feedbackID", message_ID)

        Try
            ' Fill the DataTable with data from the feedback table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtusername.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()
                txtmessage.Text = row("report").ToString()
            Else
                MessageBox.Show("No feedback found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
    End Sub
End Class