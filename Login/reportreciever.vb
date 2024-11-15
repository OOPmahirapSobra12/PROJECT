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
                End If
            Next

            ' Set the text for the buttons in the ReportView and ReportDelete columns
            SetButtonText(DGVreport, "ReportView")
            SetButtonText(DGVreport, "ReportDelete")

        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        Finally
            ' Close the connection in the Finally block to ensure it always closes
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreport.CellContentClick
        If e.RowIndex < 0 Then Return ' Avoid header row

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim id As String = dgv.Rows(e.RowIndex).Cells(0).Value.ToString() ' Assuming ID is the first column

        If dgv.Columns(e.ColumnIndex).Name.Contains("View") Then
            ' Open the view form with the report ID
            Dim viewForm As New ViewFeedbackReport()
            If dgv.Name = "DGVreport" Then
                viewForm.report_ID = id
            Else
                MsgBox("Error fetching ID")
            End If
            viewForm.Show()
            Me.Hide() ' Optionally hide or close the current form

        ElseIf dgv.Columns(e.ColumnIndex).Name.Contains("Delete") Then
            ' Delete the selected record
            Dim tableName As String = If(dgv.Name = "DGVreport", "report", String.Empty)
            DeleteRecord(tableName, id)
        End If
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

    Private Sub SetButtonText(dgv As DataGridView, columnName As String)
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In dgv.Rows
            If row.IsNewRow Then Continue For ' Skip the new row placeholder

            ' Ensure the button is of the correct type (DataGridViewButtonCell)
            Dim buttonCell As DataGridViewButtonCell = TryCast(row.Cells(columnName), DataGridViewButtonCell)

            ' Check if the button cell exists and set the value (text) of the button
            If buttonCell IsNot Nothing Then
                buttonCell.Value = If(columnName.Contains("Delete"), "Delete", "View") ' Set Delete/View text based on column name
            End If
        Next
    End Sub

    Private Sub reportreciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        report()
        cbosearch.SelectedIndex = 0
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If String.IsNullOrEmpty(txtsearchbox.Text) Then
            report()
        Else
            Dim category As String = cbosearch.Text()
            Dim search As String = txtsearchbox.Text()

            Dim query As String = ""

            ' Construct the SQL query based on the selected category
            Select Case category
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
                DGVreport.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error retrieving room list: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class
