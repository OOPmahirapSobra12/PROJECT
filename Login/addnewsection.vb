Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class addnewsection
    Public isModify As Boolean
    Private currentSection As String = String.Empty
    Private currentCourse As String = String.Empty

    Public Sub addnewsection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        cbocourseloader()

        ' If we are modifying an existing section, populate the fields
        If isModify Then
            txtsection.Text = currentSection
            cbocourse.SelectedItem = currentCourse
            btnAdd.Text = "Update"  ' Change the button text to "Update"
        End If
    End Sub

    ' Method to load the course names into the ComboBox
    Public Sub cbocourseloader()
        Dim sqlQuery As String = "SELECT course_name FROM courses"
        Dim command As New MySqlCommand(sqlQuery, conn)

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim reader As MySqlDataReader = command.ExecuteReader()

            cbocourse.Items.Clear()

            While reader.Read()
                cbocourse.Items.Add(reader("course_name").ToString())
            End While

            ' If modifying, select the correct course in the ComboBox
            If isModify AndAlso Not String.IsNullOrEmpty(currentCourse) Then
                cbocourse.SelectedItem = currentCourse
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Modify the section, instead of adding a new one
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If isModify Then
            ' Update the existing section
            UpdateSection()
        Else
            ' Add a new section
            AddNewSection()
        End If
    End Sub

    ' Method to check if a section already exists
    Private Function SectionExists(courseName As String, sectionName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM section WHERE course_name = @course_name AND sections = @section"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@course_name", courseName)
        cmd.Parameters.AddWithValue("@section", sectionName)

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking section existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Sub UpdateSection()
        If cbocourse.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a valid course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the section already exists in the database (excluding the current section if modifying)
        If SectionExists(cbocourse.SelectedItem.ToString(), txtsection.Text.Trim()) AndAlso txtsection.Text.Trim() <> currentSection Then
            MessageBox.Show("This section already exists for the selected course.", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update an existing section
        Dim updateQuery As String = "UPDATE section SET course_name = @course_name WHERE sections = @section"

        ' Create and configure the command
        Dim updateCommand As New MySqlCommand(updateQuery, conn)
        updateCommand.Parameters.AddWithValue("@course_name", cbocourse.SelectedItem.ToString())
        updateCommand.Parameters.AddWithValue("@section", txtsection.Text.Trim())

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the update command
            updateCommand.ExecuteNonQuery()

            ' Notify the user
            MessageBox.Show("Section successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error updating section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub AddNewSection()
        If String.IsNullOrWhiteSpace(txtsection.Text) Then
            MessageBox.Show("Please enter a section name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbocourse.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the section already exists
        If SectionExists(cbocourse.SelectedItem.ToString(), txtsection.Text.Trim()) Then
            MessageBox.Show("This section already exists for the selected course.", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to add a new section
        Dim insertQuery As String = "INSERT INTO section (sections, course_name) VALUES (@section, @course_name)"

        ' Create and configure the command
        Dim insertCommand As New MySqlCommand(insertQuery, conn)
        insertCommand.Parameters.AddWithValue("@section", txtsection.Text.Trim())
        insertCommand.Parameters.AddWithValue("@course_name", cbocourse.SelectedItem.ToString())

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Execute the insert command
            insertCommand.ExecuteNonQuery()

            ' Notify the user
            MessageBox.Show("New section successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error adding section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handler for the "Back" button
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    ' Method to initialize the form in modify mode
    Public Sub InitializeForModify(course As String, section As String)
        ' Load the courses first
        cbocourseloader()

        ' Set the current section and course to the fields
        txtsection.Text = section
        cbocourse.SelectedItem = course ' Make sure cbocourse is loaded before selecting the course

        ' Set the modify flag and change the button text
        isModify = True
        btnAdd.Text = "Update" ' Change button text to "Update"
    End Sub
End Class
