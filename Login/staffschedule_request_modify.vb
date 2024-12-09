Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class staffschedule_request_modify

    Private Sub staff_request_modify_load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtrcode.Items.Clear()
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
        FillSubjectComboBox()
        FillSectionComboBox()
        roomname_filler()
    End Sub

    Public Sub schedulereciever(shedId As String, roomCode As String, roomName As String, subject As String,
                            timeIn As String, timeOut As String, course As String, section As String,
                            roomDay As String, roomDate As String)
        Try
            ' Populate controls with the selected row data
            txtschedID.Text = shedId
            txtrcode.Text = roomCode
            cboroomname.Text = roomName

            ' Handle ComboBox for subject
            If Not String.IsNullOrEmpty(subject) Then
                cbosubject.SelectedItem = subject
            Else
                cbosubject.SelectedIndex = -1 ' No selection
            End If

            ' Set time pickers with proper parsing and validation
            If Not String.IsNullOrEmpty(timeIn) Then
                DTPtimein.Value = DateTime.Parse(timeIn)
            Else
                DTPtimein.Value = DateTime.Now
            End If

            If Not String.IsNullOrEmpty(timeOut) Then
                DTPtimeout.Value = DateTime.Parse(timeOut)
            Else
                DTPtimeout.Value = DateTime.Now
            End If

            ' Handle ComboBox for course
            If Not String.IsNullOrEmpty(course) Then
                cbocourse.SelectedItem = course
            Else
                cbocourse.SelectedIndex = -1 ' No selection
            End If

            ' Handle ComboBox for section
            If Not String.IsNullOrEmpty(section) Then
                cbosection.SelectedItem = section
            Else
                cbosection.SelectedIndex = -1 ' No selection
            End If

            ' Handle the ComboBox and DateTimePicker logic based on roomDay and roomDate
            If String.IsNullOrEmpty(roomDay) OrElse roomDay = "N/A" Then
                ' Enable DateTimePicker for date selection
                cboday.SelectedIndex = 1 ' Assume "Date Selection" index is 1
                DTPdate.Enabled = True
                If Not String.IsNullOrEmpty(roomDate) Then
                    DTPdate.Value = DateTime.Parse(roomDate)
                Else
                    DTPdate.Value = DateTime.Now
                End If
            ElseIf String.IsNullOrEmpty(roomDate) OrElse roomDate = "N/A" Then
                ' Enable ComboBox for day selection
                DTPdate.Enabled = False
                Select Case roomDay.ToLower()
                    Case "monday"
                        cboday.SelectedIndex = 2
                    Case "tuesday"
                        cboday.SelectedIndex = 3
                    Case "wednesday"
                        cboday.SelectedIndex = 4
                    Case "thursday"
                        cboday.SelectedIndex = 5
                    Case "friday"
                        cboday.SelectedIndex = 6
                    Case "saturday"
                        cboday.SelectedIndex = 7
                    Case Else
                        cboday.SelectedIndex = 0 ' Default to blank or temporary
                End Select
            End If

            ' Optionally, disable editing of specific controls
            txtschedID.Enabled = False

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Public Sub Clear()
        cbocourse.Text = ""
        cboday.Text = ""
        cboroomname.Text = ""
        cbosection.Text = ""
        cbosubject.Text = ""
        txtschedID.Text = ""
        txtrcode.Text = ""
    End Sub

    Public Sub conflicfinder()
        If String.IsNullOrEmpty(txtschedID.Text) OrElse cboroomname.SelectedIndex < 0 OrElse
       String.IsNullOrEmpty(DTPtimein.Text) OrElse String.IsNullOrEmpty(DTPtimeout.Text) OrElse cboday.SelectedIndex = -1 OrElse
       cbocourse.SelectedIndex = -1 OrElse cbosection.SelectedIndex = -1 OrElse cbosubject.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields and select valid options.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the values
        Dim shedId As String = txtschedID.Text.Trim.ToString()
        Dim roomCode As String = txtrcode.Text.Trim.ToString()
        Dim timeIn As String = DTPtimein.Value.ToString("HH:mm")
        Dim timeOut As String = DTPtimeout.Value.ToString("HH:mm")
        Dim course As String = cbocourse.SelectedItem.ToString()
        Dim section As String = cbosection.SelectedItem.ToString()
        Dim subject As String = cbosubject.SelectedItem.ToString()
        Dim roomDay As String = If(cboday.SelectedIndex >= 2, cboday.SelectedItem.ToString(), "N/A")
        Dim roomDate As String = If(cboday.SelectedIndex = 1, DTPdate.Value.ToString("yyyy-MM-dd"), "N/A")

        ' Conflict check query
        Dim conflictQuery As String = If(cboday.SelectedIndex = 1, "
        SELECT COUNT(*) FROM schedtemp 
        WHERE room_code = @room_code AND room_date = @room_date 
        AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out)) 
        AND shedtemp_id <> @shed_id 
        AND course_name = @course AND sections = @section AND subject_name = @subject",
        "
        SELECT COUNT(*) FROM sched 
        WHERE room_code = @room_code AND room_day = @room_day 
        AND ((@time_in BETWEEN room_time_in AND room_time_out) OR (@time_out BETWEEN room_time_in AND room_time_out) 
        OR (room_time_in BETWEEN @time_in AND @time_out) OR (room_time_out BETWEEN @time_in AND @time_out)) 
        AND shed_id <> @shed_id 
        AND course_name = @course AND sections = @section AND subject_name = @subject")

        Try
            ' Check for conflicts
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim conflictCmd As New MySqlCommand(conflictQuery, conn)
            conflictCmd.Parameters.AddWithValue("@room_code", roomCode)
            conflictCmd.Parameters.AddWithValue("@room_day", roomDay)
            conflictCmd.Parameters.AddWithValue("@room_date", roomDate)
            conflictCmd.Parameters.AddWithValue("@time_in", timeIn)
            conflictCmd.Parameters.AddWithValue("@time_out", timeOut)
            conflictCmd.Parameters.AddWithValue("@shed_id", shedId)
            conflictCmd.Parameters.AddWithValue("@course", course)
            conflictCmd.Parameters.AddWithValue("@section", section)
            conflictCmd.Parameters.AddWithValue("@subject", subject)

            If Convert.ToInt32(conflictCmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("The selected room, date, and time conflict with an existing schedule.", "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                updater()
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking for conflicts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Sub updater()
        Dim sqlmodify As String = ""
        Dim sqldelete As String = ""
        Dim deletechoice As Boolean
        Dim todelete As String = txtschedID.Text.Trim()
        MessageBox.Show(todelete)
        If changed = False Then
            ' Update logic
            If (cboday.SelectedIndex = 1) Then
                sqlmodify = "UPDATE schedtemp SET " &
                        "room_code = @room_code, " &
                        "room_time_in = @room_time_in, " &
                        "room_time_out = @room_time_out, " &
                        "room_date = @room_date, " &
                        "course_name = @course, " &
                        "sections = @section, " &
                        "subject_name = @subject " &
                        "WHERE shedtemp_id = @shed_id"
            Else
                sqlmodify = "UPDATE sched SET " &
                        "room_code = @room_code, " &
                        "room_day = @room_day, " &
                        "room_time_in = @room_time_in, " &
                        "room_time_out = @room_time_out, " &
                        "course_name = @course, " &
                        "sections = @section, " &
                        "subject_name = @subject " &
                        "WHERE shed_id = @shed_id"
            End If
            deletechoice = True
        Else
            ' Insert logic
            If (cboday.SelectedIndex = 1) Then
                sqlmodify = "INSERT INTO schedtemp (room_code, room_time_in, room_time_out, room_date, course_name, sections, subject_name) " &
                        "VALUES (@room_code, @room_time_in, @room_time_out, @room_date, @course, @section, @subject)"
            Else
                sqlmodify = "INSERT INTO sched (room_code, room_day, room_time_in, room_time_out, course_name, sections, subject_name) " &
                        "VALUES (@room_code, @room_day, @room_time_in, @room_time_out, @course, @section, @subject)"
            End If
            deletechoice = False
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Execute SQL query (Update or Insert)
            Dim cmd As New MySqlCommand(sqlmodify, conn)
            cmd.Parameters.AddWithValue("@shed_id", txtschedID.Text.Trim())
            cmd.Parameters.AddWithValue("@room_code", txtrcode.Text())
            cmd.Parameters.AddWithValue("@room_day", If(cboday.SelectedIndex >= 2, cboday.SelectedItem.ToString(), "N/A"))
            cmd.Parameters.AddWithValue("@room_date", If(cboday.SelectedIndex = 1, DTPdate.Value.ToString("MM-dd-yyyy"), "N/A"))
            cmd.Parameters.AddWithValue("@room_time_in", DTPtimein.Value.ToString("hh:mm:tt"))
            cmd.Parameters.AddWithValue("@room_time_out", DTPtimeout.Value.ToString("hh:mm:tt"))
            cmd.Parameters.AddWithValue("@course", cbocourse.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("@section", cbosection.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("@subject", cbosubject.SelectedItem?.ToString())
            cmd.ExecuteNonQuery()

            ' Delete logic if `changed = True`
            If deletechoice = False Then
                If cboday.SelectedIndex = 1 Then
                    sqldelete = "DELETE FROM sched WHERE shed_id = @id"
                ElseIf cboday.SelectedIndex > 1 Then
                    sqldelete = "DELETE FROM schedtemp WHERE shedtemp_id = @id"
                End If

                Dim deleteCmd As New MySqlCommand(sqldelete, conn)
                deleteCmd.Parameters.AddWithValue("@id", todelete)
                deleteCmd.ExecuteNonQuery()
            End If

            MessageBox.Show("Schedule updated successfully! deleted" & todelete, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            todelete = ""

        Catch ex As Exception
            MessageBox.Show("Error updating schedule: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        conflicfinder()

    End Sub


    Dim changed As Boolean
    Public Sub cboday_status_scanner() Handles cboday.SelectedIndexChanged
        changed = True
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

                txtrcode.Items.Clear()
                For Each row As DataRow In roomcode_choosertable.Rows
                    txtrcode.Items.Add(row("room_code").ToString())
                Next

                If txtrcode.Items.Count > 0 Then
                    txtrcode.SelectedIndex = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading room codes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        staff_schedule.loadtable()
        Me.Close()
    End Sub
End Class