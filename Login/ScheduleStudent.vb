Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class ScheduleStudent
    Public course As String
    Public section As String
    ' Load data into DataGridView
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State <> ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        loadtable()
        formatloader()
    End Sub

    Public Sub formatloader()
        cboType.SelectedIndex = 0
    End Sub

    Public Sub loadtable()
        ' SQL query to fetch data from sched and schedtemp
        Dim sqlQuery As String = "
       SELECT 
            sched.shed_id AS sched_code,
            sched.room_code, 
            NULL AS room_date, 
            sched.room_day, 
            sched.room_time_in, 
            sched.room_time_out, 
            listofsubjects.subject_name,
            roomlist.building
        FROM sched
        JOIN roomlist ON sched.room_code = roomlist.room_code
        WHERE sched.course_name = @courseName AND sched.sections = @section
    
        UNION ALL
    
        SELECT 
            schedtemp.shedtemp_id AS sched_code,
            schedtemp.room_code, 
            schedtemp.room_date, 
            NULL AS room_day, 
            schedtemp.room_time_in, 
            schedtemp.room_time_out, 
            listofsubjects.subject_name,
            roomlist.building
        FROM schedtemp
        JOIN roomlist ON schedtemp.room_code = roomlist.room_code
        WHERE schedtemp.course_name = @courseName AND schedtemp.sections = @section;"

        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        ' Add parameters
        dataAdapter.SelectCommand.Parameters.AddWithValue("@courseName", course)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@section", section)

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the data into the DataTable
            dataAdapter.Fill(dataTable)

            ' Configure the DataGridView
            DGVschedule_student.AutoGenerateColumns = False
            DGVschedule_student.DataSource = dataTable

            ' Bind columns to their respective data fields
            DGVschedule_student.Columns("sched_code").DataPropertyName = "sched_code"
            DGVschedule_student.Columns("room_code").DataPropertyName = "room_code"
            DGVschedule_student.Columns("s_day").DataPropertyName = "room_day"
            DGVschedule_student.Columns("s_date").DataPropertyName = "room_date"
            DGVschedule_student.Columns("time_in").DataPropertyName = "room_time_in"
            DGVschedule_student.Columns("time_out").DataPropertyName = "room_time_out"
            DGVschedule_student.Columns("building_where").DataPropertyName = "building"
            DGVschedule_student.Columns("subject").DataPropertyName = "subject_name"

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error loading table data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Student.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate that the user has entered a search term
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate that courseName and section are set
        If String.IsNullOrEmpty(course) OrElse String.IsNullOrEmpty(section) Then
            MessageBox.Show("Course and Section must be selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected category and search term
        Dim selectedCategory As String = cboType.SelectedItem.ToString()
        Dim searchTerm As String = txtsearch.Text.Trim()

        ' Construct the base SQL query with placeholder for filtering
        Dim sqlQuery As String = "
    SELECT 
        sched.shed_id,
        sched.room_code, 
        roomlist.room_name, 
        sched.room_day, 
        sched.room_time_in, 
        sched.room_time_out, 
        NULL AS room_date, 
        roomlist.building,
        sched.subject_name
    FROM sched
    JOIN roomlist ON sched.room_code = roomlist.room_code
    WHERE sched.course_name = @courseName AND sched.sections = @section

    UNION ALL

    SELECT 
        schedtemp.shed_id,
        schedtemp.room_code, 
        roomlist.room_name, 
        NULL AS room_day, 
        schedtemp.room_time_in, 
        schedtemp.room_time_out, 
        schedtemp.room_date, 
        roomlist.building,
        schedtemp.subject_name
    FROM schedtemp
    JOIN roomlist ON schedtemp.room_code = roomlist.room_code
    WHERE schedtemp.course_name = @courseName AND schedtemp.sections = @section AND {0} LIKE @searchTerm;"

        ' Map categories to database columns
        Dim columnMap As New Dictionary(Of String, String) From {
            {"Schedule Code", "shed_id"},
            {"Room Code", "room_code"},
            {"Room Name", "room_name"},
            {"Subject", "subject_name"},
            {"Building", "building"},
            {"Day", "room_day"},
            {"Date", "room_date"},
            {"Time In", "room_time_in"},
            {"Time Out", "room_time_out"}
        }

        ' Validate the selected category
        If Not columnMap.ContainsKey(selectedCategory) Then
            MessageBox.Show("Invalid search category selected.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Replace placeholder with the selected column
        sqlQuery = String.Format(sqlQuery, columnMap(selectedCategory))

        ' Prepare the search term for wildcard matching
        Dim parameterValue As String = "%" & searchTerm & "%"

        ' Create a new DataAdapter to execute the query
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@courseName", course)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@section", section)
        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", parameterValue)

        ' Create a DataTable to hold the search results
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with search results
            dataAdapter.Fill(dataTable)

            ' Handle room_day/room_date logic in results
            For Each row As DataRow In dataTable.Rows
                If Not String.IsNullOrEmpty(row("room_date").ToString()) Then
                    row("room_day") = "N/A"
                ElseIf Not String.IsNullOrEmpty(row("room_day").ToString()) Then
                    row("room_date") = "N/A"
                End If
            Next

            ' Bind the DataTable to the DataGridView
            DGVschedule_student.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error executing search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
