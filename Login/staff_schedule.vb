﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staff_schedule
    ' Load data into DataGridView
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure connection is closed before reconnecting
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        ' Connect to the database
        DbConnect()

        ' Load the schedule table and set default values
        loadtable()
        formatloader()
    End Sub

    ' Initialize default values in controls
    Public Sub formatloader()
        cboType.SelectedIndex = 0 ' Set default selection for combo box
    End Sub

    ' Load schedule data into DataGridView
    Public Sub loadtable()
        ' SQL query to load data from both `sched` and `schedtemp` tables
        Dim sqlQuery As String = "SELECT 
                                    sched.shed_id, 
                                    sched.room_code, 
                                    roomlist.room_name, 
                                    NULL AS room_date, 
                                    sched.room_day, 
                                    sched.room_time_in, 
                                    sched.room_time_out, 
                                    sched.course_name, 
                                    sched.sections, 
                                    listofsubjects.subject_name
                                FROM 
                                    sched
                                JOIN 
                                    listofsubjects ON sched.subject_name = listofsubjects.subject_name
                                JOIN 
                                    roomlist ON sched.room_code = roomlist.room_code
                                UNION ALL
                                SELECT 
                                    schedtemp.shed_id, 
                                    schedtemp.room_code, 
                                    roomlist.room_name, 
                                    schedtemp.room_date, 
                                    NULL AS room_day, 
                                    schedtemp.room_time_in, 
                                    schedtemp.room_time_out, 
                                    schedtemp.course_name, 
                                    schedtemp.sections, 
                                    listofsubjects.subject_name
                                FROM 
                                    schedtemp
                                JOIN 
                                    listofsubjects ON schedtemp.subject_name = listofsubjects.subject_name
                                JOIN 
                                    roomlist ON schedtemp.room_code = roomlist.room_code;"

        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with data
            dataAdapter.Fill(dataTable)

            ' Adjust rows to display "N/A" for empty date/day
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    row("room_date") = "N/A"
                End If
            Next

            ' Bind the DataTable to the DataGridView
            DGVschedule.AutoGenerateColumns = False
            DGVschedule.DataSource = dataTable

            ' Set DataPropertyName for each column
            DGVschedule.Columns("sched_code").DataPropertyName = "shed_id"
            DGVschedule.Columns("room_code").DataPropertyName = "room_code"
            DGVschedule.Columns("s_day").DataPropertyName = "room_day"
            DGVschedule.Columns("s_date").DataPropertyName = "room_date"
            DGVschedule.Columns("time_in").DataPropertyName = "room_time_in"
            DGVschedule.Columns("time_out").DataPropertyName = "room_time_out"
            DGVschedule.Columns("course").DataPropertyName = "course_name"
            DGVschedule.Columns("section").DataPropertyName = "sections"
            DGVschedule.Columns("subject").DataPropertyName = "subject_name"

        Catch ex As Exception
            MessageBox.Show("Error loading table data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Handle Back button click
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Staff.Show()
        Me.Hide()
    End Sub

    ' Handle Search button click
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get selected category and search term
        Dim selectedCategory As String = cboType.SelectedItem.ToString()
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Map column names to search categories
        Dim columnMap As New Dictionary(Of String, String) From {
            {"Schedule Code", "shed_id"},
            {"Room Code", "room_code"},
            {"Room Name", "room_name"},
            {"Subject", "subject_name"},
            {"Course", "course_name"},
            {"Section", "sections"},
            {"Day", "room_day"},
            {"Date", "room_date"},
            {"Time In", "room_time_in"},
            {"Time Out", "room_time_out"}
        }

        If Not columnMap.ContainsKey(selectedCategory) Then
            MessageBox.Show("Invalid search category selected.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Construct SQL query with search filter
        Dim sqlQuery As String = "SELECT 
                                    sched.shed_id, 
                                    sched.room_code, 
                                    roomlist.room_name, 
                                    sched.room_day, " &
                                    "sched.room_time_in, 
                                    sched.room_time_out, 
                                    NULL AS room_date, 
                                    sched.subject_name, " &
                                    "sched.course_name, 
                                    sched.sections " &
                                "FROM sched " &
                                "JOIN roomlist ON sched.room_code = roomlist.room_code " &
                                "WHERE " & columnMap(selectedCategory) & " LIKE @searchTerm " &
                                "UNION ALL " &
                                "SELECT 
                                    schedtemp.shed_id, 
                                    schedtemp.room_code, 
                                    roomlist.room_name, 
                                    NULL AS room_day, " &
                                    "schedtemp.room_time_in, 
                                    schedtemp.room_time_out, 
                                    schedtemp.room_date, 
                                    schedtemp.subject_name, " &
                                    "schedtemp.course_name, 
                                    schedtemp.sections " &
                                "FROM schedtemp " &
                                "JOIN roomlist ON schedtemp.room_code = roomlist.room_code " &
                                "WHERE " & columnMap(selectedCategory) & " LIKE @searchTerm;"

        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

        Dim dataTable As New DataTable()

        Try
            ' Open connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill DataTable with search results
            dataAdapter.Fill(dataTable)

            ' Adjust rows to display "N/A" for empty date/day
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    row("room_date") = "N/A"
                End If
            Next

            ' Bind DataTable to DataGridView
            DGVschedule.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Handle Request button click
    Private Sub btnrequest_Click(sender As Object, e As EventArgs) Handles btnrequest.Click
        staff_request_add.Show()
    End Sub

    ' Handle Modify Request button click
    Private Sub btnrequest_modify_Click(sender As Object, e As EventArgs) Handles btnrequest_modify.Click
        ' Ensure a row is selected
        If DGVschedule.SelectedRows.Count > 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DGVschedule.SelectedRows(0)

                ' Extract values from selected row
                Dim shedId As String = If(selectedRow.Cells("sched_code").Value?.ToString(), String.Empty)
                Dim roomCode As String = If(selectedRow.Cells("room_code").Value?.ToString(), String.Empty)
                Dim roomName As String = If(selectedRow.Cells("room_name").Value?.ToString(), String.Empty)
                Dim detail As String = If(selectedRow.Cells("detail").Value?.ToString(), String.Empty)
                Dim roomDay As String = If(selectedRow.Cells("s_day").Value?.ToString(), String.Empty)
                Dim roomDate As String = If(selectedRow.Cells("s_date").Value?.ToString(), String.Empty)
                Dim timeIn As String = If(selectedRow.Cells("time_in").Value?.ToString(), String.Empty)
                Dim timeOut As String = If(selectedRow.Cells("time_out").Value?.ToString(), String.Empty)
                Dim subject As String = If(selectedRow.Cells("subject").Value?.ToString(), String.Empty)
                Dim course As String = If(selectedRow.Cells("course").Value?.ToString(), String.Empty)
                Dim section As String = If(selectedRow.Cells("section").Value?.ToString(), String.Empty)

                ' Pass data to the modify request form
                staff_request_modify.Show()
                staff_request_modify.schedulereciever(shedId, roomCode, roomName, subject, timeIn, timeOut, course, section, roomDay, roomDate)
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Notify user to select a row
            MessageBox.Show("Please select a schedule from the list.", "No Schedule Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
