Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports ConnectionModule

Public Class requestapproval

    Private Sub requestapproval_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        tableloader_request()
        tableloader_schedules()
        FormatDataGridViews_schedules()
        FormatDataGridViews_request()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to add a new schedule", "Confirm Creation of New Schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            If DGVrequest.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DGVschedules.SelectedRows(0)

                ' Create an instance of addscheduleadmin form
                Dim addForm As New addscheduleadmin()

                ' Pass the selected schedule data to the addscheduleadmin form
                addForm.rDate = selectedRow.Cells("Date").Value.ToString()
                addForm.rTime = selectedRow.Cells("Time").Value.ToString()
                addForm.rRoom = selectedRow.Cells("Room").Value.ToString()

                ' Show the addscheduleadmin form
                addForm.ShowDialog()
                addscheduleadmin.Show()
                Me.Hide()

            Else
                addscheduleadmin.Show()
                Me.Hide()
            End If

        ElseIf result = DialogResult.No Then
            tableloader_request()
            tableloader_schedules()
            FormatDataGridViews_schedules()
            FormatDataGridViews_request()
        Else
            MsgBox("Error Try Again!")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected in the DGVrequest DataGridView (requests table)
        If DGVrequest.SelectedRows.Count > 0 Then
            ' Retrieve the requestID from the selected row (assumed to be in the 5th column)
            Dim selectedRequestID As Integer = Convert.ToInt32(DGVrequest.SelectedRows(0).Cells("requestID").Value)

            ' Confirmation prompt for request deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected request?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Delete the record from the database using requestID
                Dim query As String = "DELETE FROM requests WHERE requestID = @requestID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@requestID", selectedRequestID)

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    cmd.ExecuteNonQuery()

                    ' Refresh the table to show updated data
                    tableloader_request()
                    tableloader_schedules()
                    FormatDataGridViews_schedules()
                    FormatDataGridViews_request()

                    MessageBox.Show("Request deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error deleting request: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If

            ' Check if a row is selected in the DGVschedules DataGridView (schedules table)
        ElseIf DGVschedules.SelectedRows.Count > 0 Then
            ' Retrieve the shed_id from the selected row (assumed to be in the 5th column)
            Dim selectedShedID As Integer = Convert.ToInt32(DGVschedules.SelectedRows(0).Cells("shed_id").Value)

            ' Confirmation prompt for schedule deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected schedule?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Delete the record from the sched table using shed_id
                Dim query As String = "DELETE FROM sched WHERE shed_id = @shed_id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@shed_id", selectedShedID)

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    cmd.ExecuteNonQuery()

                    ' Refresh the table to show updated data
                    tableloader_request()
                    tableloader_schedules()
                    FormatDataGridViews_schedules()
                    FormatDataGridViews_request()

                    MessageBox.Show("Schedule deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error deleting schedule: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub


    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub
    Private Sub tableloader_request()
        Dim query As String = "SELECT request_d, request_t, room, request, requestID FROM requests" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVrequest.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDataGridViews_request()
        ' Format the schedules DataGridView
        If DGVrequest.Rows.Count > 0 Then ' Check if there are rows
            With DGVrequest
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Room"
                .Columns(3).HeaderText = "Request Message"
                .Columns(4).HeaderText = "Request ID"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVrequest
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Time"
                .Columns(2).HeaderText = "Room"
                .Columns(3).HeaderText = "Request Message"
                .Columns(4).HeaderText = "Request ID"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub tableloader_schedules()
        Dim query As String = "SELECT room_date, room_day, room_time, room_name, building_letter, room_code, shed_id FROM sched _
            union all SELECT room_date, room_day, room_time, room_name, building_letter, room_code, shed_id FROM schedtemp;" ' Use roomlist if you want to get room status from that table
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the sched table
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            DGVschedules.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error retrieving room statuses: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatDataGridViews_schedules()
        ' Format the schedules DataGridView
        If DGVschedules.Rows.Count > 0 Then ' Check if there are rows
            With DGVschedules
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Day"
                .Columns(2).HeaderText = "Time"
                .Columns(3).HeaderText = "Room Name"
                .Columns(4).HeaderText = "Building Letter"
                .Columns(5).HeaderText = "Room Code"
                .Columns(6).HeaderText = "Sched ID"

                ' First, adjust the columns based on data length
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' Then, set it back to Fill for a balanced layout
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Else
            With DGVschedules
                .Columns(0).HeaderText = "Date"
                .Columns(1).HeaderText = "Day"
                .Columns(2).HeaderText = "Time"
                .Columns(3).HeaderText = "Room Name"
                .Columns(4).HeaderText = "Building Letter"
                .Columns(5).HeaderText = "Room Code"
                .Columns(6).HeaderText = "Sched ID"

                ' No auto-size adjustment if no data
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub btnrequestreload_Click(sender As Object, e As EventArgs) Handles btnrequestreload.Click
        tableloader_request()
        FormatDataGridViews_request()
    End Sub

    Private Sub btnlistreload_Click(sender As Object, e As EventArgs) Handles btnlistreload.Click
        tableloader_schedules()
        FormatDataGridViews_schedules()
    End Sub
End Class