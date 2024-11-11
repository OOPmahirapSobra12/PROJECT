Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class ViewFeedbackReport
    Public Property report_ID As String
    Public Property feedback_ID As String

    Private Sub ViewFeedbackReort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        MsgBox(report_ID)
        MsgBox(feedback_ID)
        DbConnect()



    End Sub
    ' Separate method to load report data
    Public Sub loadReport(report_ID As String)
        Dim query As String = "SELECT sender, d, t, report FROM report WHERE ID = @reportID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@reportID", report_ID)

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtsender.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()

                ' Set the DataGridView's text column data source
                DGVtextbox.AutoGenerateColumns = False
                DGVtextbox.DataSource = table

                ' Manually map the data to the existing columns
                For Each column As DataGridViewColumn In DGVtextbox.Columns
                    If column.Name = "sendertext" Then
                        column.DataPropertyName = "report"
                    End If
                Next
            Else
                MessageBox.Show("No report found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving report: " & ex.Message)
        End Try
    End Sub

    ' Separate method to load feedback data
    Public Sub loadFeedback(feedback_ID As String)
        Dim query As String = "SELECT sender, d, t, feedback FROM feedback WHERE ID = @feedbackID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Add parameter to prevent SQL injection
        adapter.SelectCommand.Parameters.AddWithValue("@feedbackID", feedback_ID)

        Try
            ' Fill the DataTable with data from the feedback table
            adapter.Fill(table)

            ' If the table has rows, populate the controls
            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)

                ' Populate the respective controls with the values from the row
                txtsender.Text = row("sender").ToString()
                txtdate.Text = row("d").ToString()
                txttime.Text = row("t").ToString()

                ' Set the DataGridView's text column data source
                DGVtextbox.AutoGenerateColumns = False
                DGVtextbox.DataSource = table

                ' Manually map the data to the existing columns
                For Each column As DataGridViewColumn In DGVtextbox.Columns
                    If column.Name = "sendertext" Then
                        column.DataPropertyName = "feedback"
                    End If
                Next
            Else
                MessageBox.Show("No feedback found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving feedback: " & ex.Message)
        End Try
    End Sub

    ' Updated loader method to call the correct loading method based on the ID provided
    Public Sub loader()
        ' Check if report_ID is not empty, if so, load report data
        If Not String.IsNullOrEmpty(report_ID) Then
            loadReport(report_ID)
            txttype.Text = "Report"
            ' Check if feedback_ID is not empty, if so, load feedback data
        ElseIf Not String.IsNullOrEmpty(feedback_ID) Then
            loadFeedback(feedback_ID)
            txttype.Text = "Feedback"
        Else
            ' Show error if neither report_ID nor feedback_ID is provided
            MessageBox.Show("Error: No valid report or feedback ID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class