Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Sections
    Public Sub sections_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        tableloader()
    End Sub

    Private Sub tableloader()
        ' SQL query to fetch all sections and their associated courses
        Dim sqlQuery As String = "
        SELECT 
            sections, 
            course_name 
        FROM section;"

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
            DGVsections.AutoGenerateColumns = True
            DGVsections.DataSource = dataTable

            ' Set DataGridView column headers if necessary
            DGVsections.Columns("sections").HeaderText = "Section"
            DGVsections.Columns("course_name").HeaderText = "Course"

            ' Additional configuration (optional)
            DGVsections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGVsections.ReadOnly = True
            DGVsections.AllowUserToAddRows = False

        Catch ex As Exception
            ' Handle any errors that occur during data loading
            MessageBox.Show("Error loading sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        AdminPage2.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Check if "Choose" is selected
        If cbotype.Text = "Choose" Then
            ' Refresh the table by reloading all data
            tableloader()
            Return
        End If

        ' Validate if a search term is entered
        If String.IsNullOrWhiteSpace(txtsearch.Text) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare SQL query based on the selected type
        Dim searchType As String = cbotype.Text
        Dim searchTerm As String = "%" & txtsearch.Text.Trim() & "%"
        Dim sqlQuery As String = ""

        If searchType = "Course" Then
            sqlQuery = "SELECT sections, course_name FROM section WHERE course_name LIKE @searchTerm;"
        ElseIf searchType = "Section" Then
            sqlQuery = "SELECT sections, course_name FROM section WHERE sections LIKE @searchTerm;"
        Else
            MessageBox.Show("Invalid search type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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
            DGVsections.DataSource = dataTable

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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected in the DataGridView
        If DGVsections.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVsections.SelectedRows(0)

            ' Get the course and section values from the selected row
            Dim courseName As String = selectedRow.Cells("course_name").Value.ToString()
            Dim section As String = selectedRow.Cells("sections").Value.ToString()

            ' Ask the user to confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this section?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' SQL query to delete the section from the database
                Dim deleteQuery As String = "DELETE FROM section WHERE sections = @section AND course_name = @course_name"

                ' Create and configure the command
                Dim deleteCommand As New MySqlCommand(deleteQuery, conn)
                deleteCommand.Parameters.AddWithValue("@section", section)
                deleteCommand.Parameters.AddWithValue("@course_name", courseName)

                Try
                    ' Open the connection if it's not already open
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If

                    ' Execute the delete command
                    deleteCommand.ExecuteNonQuery()

                    ' Notify the user
                    MessageBox.Show("Section successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the table to reflect the changes
                    tableloader()

                Catch ex As Exception
                    ' Handle errors during deletion
                    MessageBox.Show("Error deleting section: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Ensure the connection is closed
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        ' Check if a row is selected in the DataGridView
        If DGVsections.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVsections.SelectedRows(0)

            ' Get the course and section values from the selected row
            Dim courseName As String = selectedRow.Cells("course_name").Value.ToString()
            Dim section As String = selectedRow.Cells("sections").Value.ToString()

            ' Pass the course and section values to the AddNewSection form for modification
            Dim addSectionForm As New addnewsection()
            addSectionForm.InitializeForModify(courseName, section)
            addSectionForm.isModify = True
            addSectionForm.Show()

            ' Optionally, hide the current form
            Me.Hide()
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Open the addnewsection form for adding new sections
        Dim addSectionForm As New addnewsection()
        addSectionForm.isModify = False
        addSectionForm.Show()
        Me.Hide()
    End Sub

End Class