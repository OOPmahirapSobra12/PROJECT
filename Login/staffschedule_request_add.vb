Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staffschedule_request_add
    Private Sub staff_request_add_load(sender As Object, e As EventArgs) Handles MyBase.Load
        cborcode.Items.Clear()
        cboroomname.Items.Clear()
        cbocourse.Items.Clear()
        cbosection.Items.Clear()
        cbosubject.Items.Clear()

        If conn.State <> ConnectionState.Open Then
            conn.Close()
        End If

        DbConnect()
        formatloader()
        datetimeformat()
        FillCourseComboBox()
        FillSectionComboBox()
        FillSubjectComboBox()
        roomname_filler()

    End Sub

    Private Sub formatloader()
        DTPdate.Enabled = False
        DTPdate.Value = DateTime.Now
        DTPtimein.Value = DateTime.Now
    End Sub
    Public Sub datetimeformat()
        ' Date-only DateTimePicker (DTPdate)
        DTPdate.Format = DateTimePickerFormat.Short  ' Displays only the date (e.g., 11/17/2024)
        DTPdate.ShowUpDown = False  ' Disables the up/down spinner, uses a calendar for date selection

        ' Time-only DateTimePicker (DTPtime)
        DTPtimein.Format = DateTimePickerFormat.Custom  ' Custom format for time only
        DTPtimein.CustomFormat = "HH:mm"  ' 24-hour time format (e.g., 14:30)
        DTPtimein.ShowUpDown = True  ' Enables the up/down spinner for selecting time

        DTPtimeout.Format = DateTimePickerFormat.Custom
        DTPtimeout.CustomFormat = "HH:mm"
        DTPtimeout.ShowUpDown = True
    End Sub
    Private Sub cboday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboday.SelectedIndexChanged
        ' Check the selected index of the ComboBox
        If cboday.SelectedIndex = 1 Then
            ' Enable DTPdate if index is 1
            DTPdate.Enabled = True
        Else
            ' Disable DTPdate for all other indices
            DTPdate.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Ensure all required fields are filled
        If cboroomname.SelectedIndex < 0 OrElse cboday.SelectedIndex = -1 OrElse cbocourse.SelectedIndex = -1 OrElse
        cbosection.SelectedIndex = -1 OrElse cbosubject.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields and select valid options.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get input values
        Dim roomCode As String = cborcode.Text.Trim()
        Dim roomName As String = cboroomname.Text.Trim()
        Dim timeIn As String = DTPtimein.Value.ToString("HH:mm")
        Dim timeOut As String = DTPtimeout.Value.ToString("HH:mm")
        Dim course As String = cbocourse.SelectedItem.ToString()
        Dim section As String = cbosection.SelectedItem.ToString()
        Dim subject As String = cbosubject.SelectedItem.ToString()
        Dim roomDay As String = "N/A"
        Dim roomDate As String = "N/A"
        Dim shedID As String = Guid.NewGuid().ToString() ' Generate a unique ID for shed_id

        ' Handle day or date selection
        If cboday.SelectedIndex = 0 Then
            MessageBox.Show("Please select a valid Day or Date option.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf cboday.SelectedIndex = 1 Then
            roomDate = DTPdate.Value.ToString("yyyy-MM-dd")
            roomDay = "N/A"
        Else
            roomDay = cboday.SelectedItem.ToString()
            roomDate = "N/A"
        End If

        ' Check for conflicts
        Dim conflictQuery As String
        If cboday.SelectedIndex = 1 Then
            conflictQuery = "
        SELECT COUNT(*) FROM schedtemp 
        WHERE room_code = @room_code AND room_date = @room_date
        AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out))"
        Else
            conflictQuery = "
        SELECT COUNT(*) FROM sched 
        WHERE room_code = @room_code AND room_day = @room_day 
        AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out))"
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim conflictCmd As New MySqlCommand(conflictQuery, conn)
            conflictCmd.Parameters.AddWithValue("@room_code", roomCode)
            conflictCmd.Parameters.AddWithValue("@room_day", roomDay)
            conflictCmd.Parameters.AddWithValue("@room_date", roomDate)
            conflictCmd.Parameters.AddWithValue("@time_in", timeIn)
            conflictCmd.Parameters.AddWithValue("@time_out", timeOut)

            Dim conflictCount As Integer = Convert.ToInt32(conflictCmd.ExecuteScalar())
            If conflictCount > 0 Then
                MessageBox.Show("The selected room, date, and time already conflict with an existing schedule. Please choose a different time or room.", "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking for conflicts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        ' Insert into the appropriate table
        Dim sqlQuery As String
        If cboday.SelectedIndex = 1 Then
            sqlQuery = "
        INSERT INTO schedtemp (room_code, room_time_in, room_time_out, room_date, shed_id, subject_name, sections, course_name) 
        VALUES (@room_code, @room_time_in, @room_time_out, @room_date, @shed_id, @subject_name, @sections, @course_name)"
        Else
            sqlQuery = "
        INSERT INTO sched (room_code, room_time_in, room_time_out, room_day, shed_id, subject_name, sections, course_name) 
        VALUES (@room_code, @room_time_in, @room_time_out, @room_day, @shed_id, @subject_name, @sections, @course_name)"
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@room_code", roomCode)
            cmd.Parameters.AddWithValue("@room_time_in", timeIn)
            cmd.Parameters.AddWithValue("@room_time_out", timeOut)
            cmd.Parameters.AddWithValue("@room_day", roomDay)
            cmd.Parameters.AddWithValue("@room_date", roomDate)
            cmd.Parameters.AddWithValue("@shed_id", shedID)
            cmd.Parameters.AddWithValue("@subject_name", subject)
            cmd.Parameters.AddWithValue("@sections", section)
            cmd.Parameters.AddWithValue("@course_name", course)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Schedule added successfully!", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding schedule: " & ex.Message, "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' Method to fill the cboSubject ComboBox with subject names from the subjects table
    Private Sub FillSubjectComboBox()
        ' Define the SQL query to fetch all subject names from the subjects table
        Dim sqlQuery As String = "SELECT subject_name FROM listofsubjects"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with the subject names
            dataAdapter.Fill(dataTable)

            ' Clear any existing items in the ComboBox
            cbosubject.Items.Clear()

            ' Add the subject names from the DataTable to the ComboBox
            For Each row As DataRow In dataTable.Rows
                cbosubject.Items.Add(row("subject_name").ToString())
            Next

            ' Optionally, set the default selected item (if any)
            If cbosubject.Items.Count > 0 Then
                cbosubject.SelectedIndex = 0  ' Select the first item by default
            End If
            dataAdapter.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Method to fill the cboCourse ComboBox with course names from the courses table
    Private Sub FillCourseComboBox()
        ' Define the SQL query to fetch all course names from the courses table
        Dim sqlQuery As String = "SELECT course_name FROM courses"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with the course names
            dataAdapter.Fill(dataTable)

            ' Clear any existing items in the ComboBox
            cbocourse.Items.Clear()

            ' Add the course names from the DataTable to the ComboBox
            For Each row As DataRow In dataTable.Rows
                cbocourse.Items.Add(row("course_name").ToString())
            Next

            ' Optionally, set the default selected item (if any)
            If cbocourse.Items.Count > 0 Then
                cbocourse.SelectedIndex = 0  ' Select the first item by default
            End If
            dataAdapter.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub FillSectionComboBox()
        ' Define the SQL query to fetch all section names from the section table
        Dim sqlQuery As String = "SELECT sections FROM section"

        ' Create a new DataAdapter to fetch data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with the section names
            dataAdapter.Fill(dataTable)

            ' Clear any existing items in the ComboBox
            cbosection.Items.Clear()

            ' Add the section names from the DataTable to the ComboBox
            For Each row As DataRow In dataTable.Rows
                cbosection.Items.Add(row("sections").ToString())
            Next

            ' Optionally, set the default selected item (if any)
            If cbosection.Items.Count > 0 Then
                cbosection.SelectedIndex = 0  ' Select the first item by default
            End If
            dataAdapter.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub cbosection_DropDown(sender As Object, e As EventArgs) Handles cbosection.DropDown
        ' Define the SQL query to fetch all sections
        Dim sqlQuery As String = "SELECT sections FROM listofsubjects"

        ' Add a WHERE clause if cbosubject has a selected value
        If Not String.IsNullOrEmpty(cbocourse.SelectedItem?.ToString()) Then
            sqlQuery &= " WHERE course_name = @selectedcourse"
        End If

        ' Create a new DataAdapter to fetch section data
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)

        If Not String.IsNullOrEmpty(cbocourse.SelectedItem?.ToString()) Then
            dataAdapter.SelectCommand.Parameters.AddWithValue("@selectedcourse", cbocourse.SelectedItem.ToString())
        End If

        ' Create a DataTable to hold the result
        Dim dataTable As New DataTable()

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            dataAdapter.Fill(dataTable)

            ' Clear the ComboBox and add the sections
            cbosection.Items.Clear()
            For Each row As DataRow In dataTable.Rows
                cbosection.Items.Add(row("sections").ToString())
            Next

            ' Optionally select the first item if available
            If cbosection.Items.Count > 0 Then
                cbosection.SelectedIndex = 0
            End If
            dataAdapter.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub HandleSubjectDropdown() Handles cbosubject.DropDown
        ' Clear the existing items in the cbosubject ComboBox
        cbosubject.Items.Clear()

        ' Start building the SQL query to get subjects from the listofsubjects table
        Dim sqlQuery As String = "SELECT DISTINCT subject_name FROM listofsubjects WHERE 1=1"

        ' Check if a section is selected in cbosection
        If Not String.IsNullOrEmpty(cbosection.SelectedItem?.ToString()) Then
            sqlQuery &= " AND sections = @section"
        End If

        ' Check if a course is selected in cbocourse
        If Not String.IsNullOrEmpty(cbocourse.SelectedItem?.ToString()) Then
            sqlQuery &= " AND course_name = @course"
        End If

        ' Prepare the command and parameters
        Dim command As New MySqlCommand(sqlQuery, conn)

        ' Add parameters for section and course if they are selected
        If Not String.IsNullOrEmpty(cbosection.SelectedItem?.ToString()) Then
            command.Parameters.AddWithValue("@section", cbosection.SelectedItem.ToString())
        End If

        If Not String.IsNullOrEmpty(cbocourse.SelectedItem?.ToString()) Then
            command.Parameters.AddWithValue("@course", cbocourse.SelectedItem.ToString())
        End If

        ' Execute the query and populate cbosubject with multiple rows (if applicable)
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Create a DataAdapter to fetch the filtered subject names
            Dim dataAdapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            ' Add all retrieved subjects to the ComboBox
            For Each row As DataRow In dataTable.Rows
                cbosubject.Items.Add(row("subject_name").ToString())
            Next

            ' Optionally, set the first item as selected (if needed)
            If cbosubject.Items.Count > 0 Then
                cbosubject.SelectedIndex = 0 ' Select the first item if there are results
            End If
            dataAdapter.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Sub roomname_filler()
        Dim sqlQuery As String = "SELECT room_name FROM roomlist"

        ' Use a Using block to ensure proper disposal of the DataAdapter
        Using dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim dataTable As New DataTable()

            Try
                If conn.State <> ConnectionState.Open Then conn.Open()

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Clear and update ComboBox items
                cboroomname.Items.Clear()
                For Each row As DataRow In dataTable.Rows
                    cboroomname.Items.Add(row("room_name").ToString())
                Next

                ' Optionally set the first item as default
                If cboroomname.Items.Count > 0 Then
                    cboroomname.SelectedIndex = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading room names: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Public Sub roomcode_chooser(sender As Object, e As EventArgs) Handles cboroomname.SelectedIndexChanged
        Dim sqlQuery As String = "SELECT room_code FROM roomlist WHERE room_name = @roomname"

        Using dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim roomcode_choosertable As New DataTable()

            Try
                If conn.State <> ConnectionState.Open Then conn.Open()

                dataAdapter.SelectCommand.Parameters.AddWithValue("@roomname", cboroomname.SelectedItem.ToString())
                dataAdapter.Fill(roomcode_choosertable)

                cborcode.Items.Clear()
                For Each row As DataRow In roomcode_choosertable.Rows
                    cborcode.Items.Add(row("room_code").ToString())
                Next

                If cborcode.Items.Count > 0 Then
                    cborcode.SelectedIndex = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading room codes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
End Class