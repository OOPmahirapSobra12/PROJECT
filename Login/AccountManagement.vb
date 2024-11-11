Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class AccountManagement
    Public Property U_ID As String

    Private Sub AccountManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        tableloader()
        btnupdate.Enabled = False  ' Disable the button
        btnupdate.Visible = False  ' Hide the button
    End Sub
    Public Sub tableloader()
        Dim query As String = "SELECT username, ID, accesslevel FROM accounts"

        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data from the report table
            adapter.Fill(table)

            ' Set AutoGenerateColumns to False to avoid extra columns
            DGVaccounts.AutoGenerateColumns = False

            ' Bind the DataTable to the DataGridView
            DGVaccounts.DataSource = table

            ' Manually map the data to the existing columns
            For Each column As DataGridViewColumn In DGVaccounts.Columns
                If column.Name = "accountID" Then
                    column.DataPropertyName = "ID"
                ElseIf column.Name = "username" Then
                    column.DataPropertyName = "username"
                ElseIf column.Name = "Accesslevel" Then
                    column.DataPropertyName = "accesslevel"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving reports: " & ex.Message)
        End Try
    End Sub
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Ensure a row is selected
        If DGVaccounts.SelectedRows.Count > 0 Then
            ' Get the account ID from the selected row
            MsgBox(DGVaccounts.SelectedRows)
            Dim selectedAccountID As String = DGVaccounts.SelectedRows(0).Cells("accountID").Value.ToString()
            MsgBox(selectedAccountID)
            ' Confirm deletion with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Call the DeleteAccount method with the selected account ID
                DeleteAccount(selectedAccountID)
            End If
        Else
            ' If no row is selected, show a warning message
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteAccount(selectedAccountID)
        ' SQL query to delete the account
        Dim query As String = "DELETE FROM accounts WHERE ID = @id"

        Using command As New MySqlCommand(query, conn)
            ' Add the parameter to prevent SQL injection
            command.Parameters.AddWithValue("@id", selectedAccountID)

            Try
                ' Open the connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the delete command
                command.ExecuteNonQuery()
                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView to reflect changes
                tableloader()

            Catch ex As Exception
                MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ' Clear the textboxes
        txtfname.Clear()
        txtID.Clear()
        txtlname.Clear()
        txtpassword.Clear()
        txtusername.Clear()

        ' Clear the image in the PictureBox
        PBpic.Image = Nothing

        ' Reset the ComboBox to no selection
        cbolevel.SelectedIndex = -1 ' No item selected
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Validate that none of the fields are empty
        If String.IsNullOrEmpty(txtcode.Text) OrElse
       String.IsNullOrEmpty(txtfname.Text) OrElse
       String.IsNullOrEmpty(txtID.Text) OrElse
       String.IsNullOrEmpty(txtlname.Text) OrElse
       String.IsNullOrEmpty(txtpassword.Text) OrElse
       String.IsNullOrEmpty(txtusername.Text) OrElse
       cbolevel.SelectedIndex < 0 Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate that the access level is either Low, Middle, or High (case insensitive)
        Dim allowedLevels As String() = {"low", "middle", "high"}
        Dim accesslevel As String = cbolevel.SelectedItem.ToString().ToLower() ' Convert to lowercase for comparison

        If Not allowedLevels.Contains(accesslevel) Then
            MessageBox.Show("Access level must be Low, Middle, or High.", "Invalid Access Level", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare data for insertion
        Dim code As String = txtcode.Text
        Dim fname As String = txtfname.Text
        Dim id As String = txtID.Text
        Dim lname As String = txtlname.Text
        Dim password As String = txtpassword.Text
        Dim username As String = txtusername.Text

        ' Convert the image in PBpic to a byte array
        Dim imageBytes As Byte() = Nothing
        If PBpic.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using
        End If

        ' Define the query to insert the new account
        Dim query As String = "INSERT INTO accounts (username, pword, fname, lname, ID, accesslevel, image) " &
                          "VALUES (@username, @pword, @fname, @lname, @id, @accesslevel, @image)"

        ' Execute the query using a MySqlCommand
        Using command As New MySqlCommand(query, conn)
            ' Add parameters to prevent SQL injection
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@pword", password)
            command.Parameters.AddWithValue("@fname", fname)
            command.Parameters.AddWithValue("@lname", lname)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@accesslevel", accesslevel) ' Insert the validated access level
            command.Parameters.AddWithValue("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)) ' Insert image if available

            Try
                ' Open the connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the insert command
                command.ExecuteNonQuery()
                MessageBox.Show("Account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the fields after successful insertion
                btnclear.PerformClick()

                ' Refresh the DataGridView or account listing
                tableloader() ' Assuming you have a method to reload the account data

            Catch ex As Exception
                MessageBox.Show($"Error adding account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub cboloader(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the ComboBox to be a drop-down list, preventing manual input
        cbolevel.DropDownStyle = ComboBoxStyle.DropDownList

        ' Clear any existing items and add the desired options
        cbolevel.Items.Clear()
        cbolevel.Items.Add("Low")
        cbolevel.Items.Add("Middle")
        cbolevel.Items.Add("High")

        ' Optionally set the default selected index (e.g., set to -1 if nothing should be selected)
        cbolevel.SelectedIndex = -1 ' No item selected by default
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        Try
            ' Ensure that a row is selected in the DataGridView
            If DGVaccounts.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            btnadd.Enabled = False  ' Disable the button
            btnadd.Visible = False  ' Hide the button
            btnupdate.Enabled = True
            btnupdate.Visible = True

            ' Get the ID from the selected row (assume ID is in the first column of the DataGridView)
            Dim selectedRow As DataGridViewRow = DGVaccounts.SelectedRows(0)
            Dim selectedID As String = selectedRow.Cells("accountID").Value.ToString()

            ' Define the query to retrieve the account based on the selected ID
            Dim query As String = "SELECT username, pword, fname, lname, ID, accesslevel, image FROM accounts WHERE ID = @id"

            ' Execute the query using MySqlCommand
            Using command As New MySqlCommand(query, conn)
                ' Add the ID parameter to prevent SQL injection
                command.Parameters.AddWithValue("@id", selectedID)

                Try
                    ' Open the connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the query and read the data
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the textboxes with the data from the database
                            txtusername.Text = reader("username").ToString()
                            txtpassword.Text = reader("pword").ToString()
                            txtfname.Text = reader("fname").ToString()
                            txtlname.Text = reader("lname").ToString()
                            txtID.Text = reader("ID").ToString()

                            ' Set the ComboBox based on the accesslevel retrieved (case-insensitive match)
                            Dim accessLevel As String = reader("accesslevel").ToString().ToLower()
                            Select Case accessLevel
                                Case "low"
                                    cbolevel.SelectedIndex = 0
                                Case "middle"
                                    cbolevel.SelectedIndex = 1
                                Case "high"
                                    cbolevel.SelectedIndex = 2
                                Case Else
                                    cbolevel.SelectedIndex = -1 ' No valid selection
                            End Select

                            ' Load the image if exists
                            If reader("image") IsNot DBNull.Value Then
                                Dim imgData As Byte() = CType(reader("image"), Byte())
                                Using ms As New IO.MemoryStream(imgData)
                                    PBpic.Image = Image.FromStream(ms)
                                End Using
                            Else
                                PBpic.Image = Nothing ' Set the image as null if no image is found
                            End If

                        Else
                            MessageBox.Show("No record found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub buttonpic_Click(sender As Object, e As EventArgs) Handles buttonpic.Click
        ' Create an OpenFileDialog to allow the user to select a picture
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter for image files (e.g., .jpg, .png, .bmp)
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        ' Set the title of the dialog
        openFileDialog.Title = "Select an Image"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the file path of the selected image
            Dim filePath As String = openFileDialog.FileName

            ' Load the image into the PictureBox (PBpic)
            PBpic.Image = Image.FromFile(filePath)
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ' Ensure that the ID field is not empty
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please enter an ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the ID from the txtID textbox
        Dim selectedID As String = txtID.Text

        ' Ensure only one record exists with the same ID
        Dim query As String = "SELECT COUNT(*) FROM accounts WHERE ID = @id"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@id", selectedID)

            Try
                ' Open the connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query to count the matching IDs
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count = 1 Then
                    ' If only one record is found, proceed with the update
                    Dim updateQuery As String = "UPDATE accounts SET " &
                                                "username = @username, " &
                                                "pword = @pword, " &
                                                "fname = @fname, " &
                                                "lname = @lname, " &
                                                "accesslevel = @accesslevel, " &
                                                "image = @picture " &  ' Assuming picture is stored as a binary (BLOB) field
                                                "WHERE ID = @id"

                    ' Execute the update query
                    Using updateCommand As New MySqlCommand(updateQuery, conn)
                        ' Add parameters to prevent SQL injection
                        updateCommand.Parameters.AddWithValue("@username", txtusername.Text)
                        updateCommand.Parameters.AddWithValue("@pword", txtpassword.Text)
                        updateCommand.Parameters.AddWithValue("@fname", txtfname.Text)
                        updateCommand.Parameters.AddWithValue("@lname", txtlname.Text)
                        updateCommand.Parameters.AddWithValue("@accesslevel", cbolevel.SelectedItem.ToString())

                        ' For the picture, we need to save the image in the database (convert it to a binary format if needed)
                        If PBpic.Image IsNot Nothing Then
                            Try
                                Dim ms As New IO.MemoryStream()
                                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                                updateCommand.Parameters.AddWithValue("@picture", ms.ToArray())  ' Store the image as a binary data
                            Catch ex As Exception
                                MessageBox.Show("Error saving image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End Try
                        Else
                            ' If no picture is selected, you can store a NULL or empty value (depending on your database schema)
                            updateCommand.Parameters.AddWithValue("@picture", DBNull.Value)
                        End If

                        updateCommand.Parameters.AddWithValue("@id", selectedID)

                        Try
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView or account listing
                            tableloader()  ' Assuming this is the method to reload the account data

                            ' Clear the fields after successful update (optional)
                            btnclear.PerformClick()

                            ' Disable btnupdate and hide it
                            btnupdate.Enabled = False
                            btnupdate.Visible = False

                            ' Enable btnadd and make it visible
                            btnadd.Enabled = True
                            btnadd.Visible = True

                        Catch ex As Exception
                            MessageBox.Show($"Error updating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                Else
                    ' If more than one record is found, show an error (should not happen in your case)
                    MessageBox.Show("Multiple records found with the same ID. Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error checking record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub



End Class