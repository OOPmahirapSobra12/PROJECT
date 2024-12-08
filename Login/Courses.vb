Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Courses
    ' Assuming you have a DataGridView named DGVcourses and a TextBox named txtsearch

    ' Load the courses when the form loads
    Public Sub courses_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()  ' Ensure DbConnect is defined elsewhere in your project
        tableloader()  ' Load the courses table into the DataGridView
    End Sub

    ' Method to load courses into the DataGridView
    Private Sub tableloader()
        ' SQL query to fetch all course names
        Dim sqlQuery As String = "SELECT course_id, course_name FROM courses;"

        ' Create a new DataAdapter and DataTable
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open the database connection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Load data into the DataTable
            dataAdapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            DGVcourses.AutoGenerateColumns = False
            DGVcourses.DataSource = dataTable

            DGVcourses.Columns("course").DataPropertyName = "course_name"
            DGVcourses.Columns("c_id").DataPropertyName = "course_id"

        Catch ex As Exception
            MessageBox.Show("Error loading room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Search functionality to filter courses by name
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate if a search term is entered
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare the SQL query with a search term
        Dim searchTerm As String = "%" & txtsearch.Text.Trim() & "%"

        Dim sqlQuery As String = "SELECT course_name FROM courses WHERE course_name LIKE @searchTerm;"

        ' Create a new DataAdapter and DataTable
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Add parameter for the search term
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm)

            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with filtered data
            dataAdapter.Fill(dataTable)

            ' Bind the filtered data to the DataGridView
            DGVcourses.DataSource = dataTable

        Catch ex As Exception
            ' Handle any errors during the search
            MessageBox.Show("Error performing search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Delete functionality for a selected course
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected in the DataGridView
        If DGVcourses.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVcourses.SelectedRows(0)

            ' Get the course name from the selected row
            Dim courseName As String = selectedRow.Cells("course_name").Value.ToString()

            ' Ask the user to confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' SQL query to delete the course from the database
                Dim deleteQuery As String = "DELETE FROM courses WHERE course_name = @course_name"

                ' Create and configure the command
                Dim deleteCommand As New MySqlCommand(deleteQuery, conn)
                deleteCommand.Parameters.AddWithValue("@course_name", courseName)

                Try
                    ' Open the connection if it's not already open
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If

                    ' Execute the delete command
                    deleteCommand.ExecuteNonQuery()

                    ' Notify the user
                    MessageBox.Show("Course successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the table to reflect the changes
                    tableloader()

                Catch ex As Exception
                    ' Handle errors during deletion
                    MessageBox.Show("Error deleting course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Ensure the connection is closed
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a course to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event for the "Add" button: Opens the addnewcourse form to add a new course
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Open the addnewcourse form for adding a new course
        Dim addCourseForm As New addnewcourse()
        addCourseForm.isModify = False
        addCourseForm.Show() ' Show the form
    End Sub


    ' Event for the "Modify" button: Opens the addnewcourse form to modify the selected course
    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        ' Check if a row is selected in the DataGridView
        If DGVcourses.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVcourses.SelectedRows(0)

            ' Get the course name from the selected row
            addnewcourse.course = selectedRow.Cells("course").Value.ToString()
            addnewcourse.course_id = selectedRow.Cells("c_id").Value.ToString()

            addnewcourse.isModify = True
            addnewcourse.Show()
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a course to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        AdminPage2.Show()
        Me.Hide()
    End Sub
End Class

