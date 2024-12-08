Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class addnewsubject
    ' Flag to determine if we are adding or modifying a subject
    Public isModify As Boolean
    Public subject As String
    Public course As String
    Public section As String
    Public subject_id As String

    ' Form load event: Initializes the form
    Public Sub addnewsubject_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect() ' Ensure DbConnect is defined elsewhere in your project

        ' Populate the course ComboBox first
        PopulateCourseComboBox()

        ' If modifying, populate the textbox with the current subject name
        If isModify = True Then
            txtsubject.Text = subject
            btnAdd.Text = "Update"  ' Change button text to "Update"

            ' After populating ComboBoxes, select the corresponding course and section
            SelectCorrectComboBoxData()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If isModify = True Then
            ModifySubject()
        ElseIf isModify = False Then
            AddNewSubject()
        End If
    End Sub

    Private Sub ModifySubject()
        ' Validate if the subject name is empty
        If String.IsNullOrWhiteSpace(txtsubject.Text) Then
            MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate if a course and section are selected
        If cbocourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbosection.SelectedIndex = -1 Then
            MessageBox.Show("Please select a section.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update the subject details
        Dim updateQuery As String = "UPDATE listofsubjects SET subject_name = @new_subject_name, course_name = @new_course_name, sections = @new_section WHERE subject_id = @subject_id"

        ' Create and configure the command
        Dim updateCommand As New MySqlCommand(updateQuery, conn)
        updateCommand.Parameters.AddWithValue("@new_subject_name", txtsubject.Text.Trim())
        updateCommand.Parameters.AddWithValue("@new_course_name", cbocourse.SelectedItem.ToString())
        updateCommand.Parameters.AddWithValue("@new_section", cbosection.SelectedItem.ToString())
        updateCommand.Parameters.AddWithValue("@subject_id", subject_id)

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the update command
            Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

            ' Notify the user based on the result
            If rowsAffected > 0 Then
                MessageBox.Show("Subject successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("No changes were made to the subject.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error updating subject: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Method to check if a subject already exists in the database
    Private Function SubjectExists(subjectName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM listofsubjects WHERE subject_name = @subject_name"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@subject_name", subjectName)

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking subject existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    ' Method to add a new subject along with selected course and section
    Private Sub AddNewSubject()
        ' Validate if the subject name is empty
        If String.IsNullOrWhiteSpace(txtsubject.Text) Then
            MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the subject already exists in the database
        If SubjectExists(txtsubject.Text.Trim()) Then
            MessageBox.Show("This subject already exists in the database.", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate if a course and section are selected
        If cbocourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbosection.SelectedIndex = -1 Then
            MessageBox.Show("Please select a section.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to insert a new subject
        Dim insertQuery As String = "INSERT INTO listofsubjects (subject_name, course_name, sections) VALUES (@subject_name, @course_name, @section)"

        ' Create and configure the command
        Dim insertCommand As New MySqlCommand(insertQuery, conn)
        insertCommand.Parameters.AddWithValue("@subject_name", txtsubject.Text.Trim())
        insertCommand.Parameters.AddWithValue("@course_name", cbocourse.SelectedItem.ToString())
        insertCommand.Parameters.AddWithValue("@section", cbosection.SelectedItem.ToString())

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the insert command
            insertCommand.ExecuteNonQuery()

            ' Notify the user
            MessageBox.Show("New subject successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error adding subject: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handler to populate the sections ComboBox based on selected course
    Private Sub cbocourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocourse.SelectedIndexChanged
        ' Populate the section ComboBox when a course is selected
        If cbocourse.SelectedIndex <> -1 Then
            PopulateSectionComboBox(cbocourse.SelectedItem.ToString())
        End If
    End Sub

    ' Method to populate the course ComboBox
    Private Sub PopulateCourseComboBox()
        Dim query As String = "SELECT course_name FROM courses"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = Nothing

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()

            ' Clear existing items in the ComboBox
            cbocourse.Items.Clear()

            ' Populate ComboBox with course names
            While reader.Read()
                cbocourse.Items.Add(reader("course_name").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error populating course ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Method to populate the section ComboBox based on selected course
    Private Sub PopulateSectionComboBox(courseName As String)
        Dim query As String = "SELECT sections FROM section WHERE course_name = @course_name"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@course_name", courseName)
        Dim reader As MySqlDataReader = Nothing

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()

            ' Clear existing items in the ComboBox
            cbosection.Items.Clear()

            ' Populate ComboBox with section names
            While reader.Read()
                cbosection.Items.Add(reader("sections").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error populating section ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Select the correct course and section based on the passed values
    Private Sub SelectCorrectComboBoxData()
        ' Select course in ComboBox
        If cbocourse.Items.Contains(course) Then
            cbocourse.SelectedItem = course
        End If

        ' Populate sections based on the selected course
        PopulateSectionComboBox(course)

        ' Select section in ComboBox
        If cbosection.Items.Contains(section) Then
            cbosection.SelectedItem = section
        End If
    End Sub

    ' Event handler for the "Back" button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        subject_id = ""
        subject = ""
        course = ""
        section = ""
        Me.Close()
        isModify = Nothing
    End Sub
End Class

