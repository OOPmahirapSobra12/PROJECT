Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Subjects
    ' Assuming you have a DataGridView named DGVsubjects and a TextBox named txtsearch
    ' Load the subjects when the form loads
    Public Sub subjects_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()  ' Ensure DbConnect is defined elsewhere in your project
        tableloader()  ' Load the subjects table into the DataGridView
    End Sub

    ' Method to load subjects into the DataGridView
    Private Sub tableloader()
        ' SQL query to fetch all subject details including course name and section
        Dim sqlQuery As String = "SELECT subject_name, sections, course_name FROM listofsubjects;"

        ' Create a new DataAdapter and DataTable
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Open the connection if it's not already open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Fill the DataTable with data from the database
            dataAdapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            DGVsubjects.AutoGenerateColumns = True
            DGVsubjects.DataSource = dataTable

            ' Set DataGridView column headers
            DGVsubjects.Columns("subject_name").HeaderText = "Subject Name"
            DGVsubjects.Columns("sections").HeaderText = "Section"
            DGVsubjects.Columns("course_name").HeaderText = "Course Name"

            ' Additional configuration (optional)
            DGVsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGVsubjects.ReadOnly = True
            DGVsubjects.AllowUserToAddRows = False

        Catch ex As Exception
            ' Handle any errors that occur during data loading
            MessageBox.Show("Error loading subjects: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Search functionality to filter subjects by name
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Validate if a search term is entered
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare the SQL query with a search term
        Dim searchTerm As String = "%" & txtsearch.Text.Trim() & "%"

        Dim sqlQuery As String = "SELECT subject_name, sections, course_name FROM listofsubjects WHERE subject_name LIKE @searchTerm;"

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
            DGVsubjects.DataSource = dataTable

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

    ' Delete functionality for a selected subject
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected in the DataGridView
        If DGVsubjects.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVsubjects.SelectedRows(0)

            ' Get the subject name from the selected row
            Dim subjectName As String = selectedRow.Cells("subject_name").Value.ToString()

            ' Ask the user to confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' SQL query to delete the subject from the listofsubjects table
                Dim deleteQuery As String = "DELETE FROM listofsubjects WHERE subject_name = @subject_name"

                ' Create and configure the command
                Dim deleteCommand As New MySqlCommand(deleteQuery, conn)
                deleteCommand.Parameters.AddWithValue("@subject_name", subjectName)
                Try
                    ' Open the connection if it's not already open
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If

                    ' Execute the delete command
                    deleteCommand.ExecuteNonQuery()

                    ' Notify the user
                    MessageBox.Show("Subject successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the table to reflect the changes
                    tableloader()

                Catch ex As Exception
                    ' Handle errors during deletion
                    MessageBox.Show("Error deleting subject: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Ensure the connection is closed
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event for the "Add" button: Opens the addnewsubject form to add a new subject
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Open the addnewsubject form for adding a new subject
        Dim addSubjectForm As New addnewsubject()
        addSubjectForm.isModify = False
        addSubjectForm.Show() ' Show the form
        Me.Hide() ' Hide the current form
    End Sub

    ' Event for the "Modify" button: Opens the addnewsubject form to modify the selected subject
    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        ' Check if a row is selected in the DataGridView
        If DGVsubjects.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVsubjects.SelectedRows(0)

            ' Get the subject name, course, and section from the selected row
            Dim subjectName As String = selectedRow.Cells("subject_name").Value.ToString()
            Dim courseName As String = selectedRow.Cells("course_name").Value.ToString() ' Assuming you have a column named "course_name"
            Dim sectionName As String = selectedRow.Cells("section").Value.ToString() ' Assuming you have a column named "section"

            ' Pass the subject, course, and section to the addnewsubject form for modification
            Dim modifySubjectForm As New addnewsubject()
            modifySubjectForm.InitializeForModify(subjectName, courseName, sectionName) ' Initialize for modification with all required values
            modifySubjectForm.isModify = True
            modifySubjectForm.Show()
            Me.Hide() ' Optionally hide the current form
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a subject to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
