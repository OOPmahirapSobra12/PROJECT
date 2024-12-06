﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class addnewcourse
    ' Flag to determine if we are adding or modifying a course
    Public isModify As Boolean
    Private currentCourse As String = String.Empty

    ' Form load event: Initializes the form based on whether we're modifying or adding a new course
    Public Sub addnewcourse_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect() ' Ensure DbConnect is defined elsewhere in your project

        ' If modifying, populate the textbox with the current course name
        If isModify Then
            txtcourse.Text = currentCourse
            btnAdd.Text = "Update"  ' Change button text to "Update"
        End If
    End Sub

    ' Event handler for the "Add" or "Update" button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If isModify Then
            ' Update the existing course
            UpdateCourse()
        Else
            ' Add a new course
            AddNewCourse()
        End If
    End Sub

    ' Method to check if a course already exists in the database
    Private Function CourseExists(courseName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM courses WHERE course_name = @course_name"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@course_name", courseName)

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking course existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    ' Method to add a new course
    Private Sub AddNewCourse()
        ' Validate if the course name is empty
        If String.IsNullOrWhiteSpace(txtcourse.Text) Then
            MessageBox.Show("Please enter a course name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the course already exists in the database
        If CourseExists(txtcourse.Text.Trim()) Then
            MessageBox.Show("This course already exists in the database.", "Duplicate Course", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to insert a new course
        Dim insertQuery As String = "INSERT INTO courses (course_name) VALUES (@course_name)"

        ' Create and configure the command
        Dim insertCommand As New MySqlCommand(insertQuery, conn)
        insertCommand.Parameters.AddWithValue("@course_name", txtcourse.Text.Trim())

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the insert command
            insertCommand.ExecuteNonQuery()

            ' Notify the user
            MessageBox.Show("New course successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error adding course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Method to update an existing course
    Private Sub UpdateCourse()
        ' Validate if the course name is empty
        If String.IsNullOrWhiteSpace(txtcourse.Text) Then
            MessageBox.Show("Please enter a course name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the course already exists in the database (except the current course)
        If CourseExists(txtcourse.Text.Trim()) AndAlso txtcourse.Text.Trim() <> currentCourse Then
            MessageBox.Show("This course already exists in the database.", "Duplicate Course", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update an existing course
        Dim updateQuery As String = "UPDATE courses SET course_name = @course_name WHERE course_name = @current_course"

        ' Create and configure the command
        Dim updateCommand As New MySqlCommand(updateQuery, conn)
        updateCommand.Parameters.AddWithValue("@course_name", txtcourse.Text.Trim())
        updateCommand.Parameters.AddWithValue("@current_course", currentCourse)

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the update command
            updateCommand.ExecuteNonQuery()

            ' Notify the user
            MessageBox.Show("Course successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error updating course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handler for the "Back" button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    ' Method to initialize the form for modification
    Public Sub InitializeForModify(course As String)
        ' Set the current course to the field
        currentCourse = course
        txtcourse.Text = course ' Populate the textbox with the existing course name

        ' Set the modify flag and change the button text
        isModify = True
        btnAdd.Text = "Update" ' Change button text to "Update"
    End Sub
End Class