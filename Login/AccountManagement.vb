Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class AccountManagement

    Private Sub AccountManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        tableloader()
        cbosearch.SelectedIndex = 0
    End Sub

    Public Sub tableloader()
        Dim query As String = "SELECT username, ID, accesslevel FROM accounts"

        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            DGVaccounts.AutoGenerateColumns = False
            DGVaccounts.DataSource = table

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

    Private Sub DeleteAccount(selectedAccountID As String)
        Dim query As String = "DELETE FROM accounts WHERE ID = @id"

        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@id", selectedAccountID)

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                command.ExecuteNonQuery()
                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tableloader()
            Catch ex As Exception
                MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub adding()
        If String.IsNullOrEmpty(txtfname.Text) OrElse
           String.IsNullOrEmpty(txtID.Text) OrElse
           String.IsNullOrEmpty(txtlname.Text) OrElse
           String.IsNullOrEmpty(txtpassword.Text) OrElse
           String.IsNullOrEmpty(txtusername.Text) OrElse
           String.IsNullOrEmpty(txtcourse.Text) OrElse
           String.IsNullOrEmpty(txtsection.Text) OrElse
           cbolevel.SelectedIndex < 0 Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim allowedLevels As String() = {"low", "middle", "high"}
        Dim accesslevel As String = cbolevel.SelectedItem.ToString().ToLower()

        If Not allowedLevels.Contains(accesslevel) Then
            MessageBox.Show("Access level must be Low, Middle, or High.", "Invalid Access Level", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim fname As String = txtfname.Text
        Dim id As String = txtID.Text
        Dim lname As String = txtlname.Text
        Dim password As String = txtpassword.Text
        Dim username As String = txtusername.Text
        Dim section As String = txtsection.Text
        Dim course As String = txtcourse.Text

        Dim imageBytes As Byte() = Nothing
        If PBpic.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using
        End If

        Dim query As String = "INSERT INTO accounts (username, pword, fname, lname, ID, course, section, accesslevel, image) " &
                              "VALUES (@username, @pword, @fname, @lname, @id, @course, @section, @accesslevel, @image)"

        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@pword", password)
            command.Parameters.AddWithValue("@fname", fname)
            command.Parameters.AddWithValue("@lname", lname)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@section", course)
            command.Parameters.AddWithValue("@course", section)
            command.Parameters.AddWithValue("@accesslevel", accesslevel)
            command.Parameters.AddWithValue("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value))

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                command.ExecuteNonQuery()
                MessageBox.Show("Account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnclear.PerformClick()
                tableloader()
            Catch ex As Exception
                MessageBox.Show($"Error adding account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        If btnadd.Text.Trim() = "Add" Then
            adding()
        ElseIf btnadd.Text.Trim() = "Update" Then
            updating()
        End If
    End Sub

    Private Sub btndelete_Click_1(sender As Object, e As EventArgs) Handles btndelete.Click
        If DGVaccounts.SelectedRows.Count > 0 Then
            Dim selectedAccountID As String = DGVaccounts.SelectedRows(0).Cells("accountID").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteAccount(selectedAccountID)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnclear_Click_1(sender As Object, e As EventArgs)
        txtfname.Clear()
        txtID.Clear()
        txtlname.Clear()
        txtpassword.Clear()
        txtusername.Clear()
        PBpic.Image = Nothing
        cbolevel.SelectedIndex = 0
        txtsection.Clear()
        txtcourse.Clear()
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub buttonpic_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Title = "Select an Image"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            PBpic.Image = Image.FromFile(filePath)
        End If
    End Sub

    Private Sub updating()
        ' Validate that none of the fields are empty
        If String.IsNullOrEmpty(txtfname.Text) OrElse
           String.IsNullOrEmpty(txtID.Text) OrElse
           String.IsNullOrEmpty(txtlname.Text) OrElse
           String.IsNullOrEmpty(txtpassword.Text) OrElse
           String.IsNullOrEmpty(txtusername.Text) OrElse
            String.IsNullOrEmpty(txtcourse.Text) OrElse
           String.IsNullOrEmpty(txtsection.Text) OrElse
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

        ' Prepare data for update
        Dim fname As String = txtfname.Text
        Dim id As String = txtID.Text
        Dim lname As String = txtlname.Text
        Dim password As String = txtpassword.Text
        Dim username As String = txtusername.Text
        Dim section As String = txtsection.Text
        Dim course As String = txtcourse.Text

        ' Convert the image in PBpic to a byte array
        Dim imageBytes As Byte() = Nothing
        If PBpic.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using
        End If

        ' Define the query to update the account
        Dim query As String = "UPDATE accounts SET username = @username, pword = @pword, fname = @fname, lname = @lname,course = @course, section = @section,
                                accesslevel = @accesslevel, image = @image WHERE ID = @id"

        ' Execute the update query using MySqlCommand
        Using command As New MySqlCommand(query, conn)
            ' Add parameters to prevent SQL injection
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@pword", password)
            command.Parameters.AddWithValue("@fname", fname)
            command.Parameters.AddWithValue("@lname", lname)
            command.Parameters.AddWithValue("@section", course)
            command.Parameters.AddWithValue("@course", section)
            command.Parameters.AddWithValue("@accesslevel", accesslevel) ' Insert the validated access level
            command.Parameters.AddWithValue("@id", id) ' Ensure the correct account ID is updated
            command.Parameters.AddWithValue("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)) ' Insert image if available

            Try
                ' Open the connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the update command
                command.ExecuteNonQuery()
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the fields after successful update
                btnclear.PerformClick()

                ' Refresh the DataGridView or account listing
                tableloader()

            Catch ex As Exception
                MessageBox.Show($"Error updating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        ' Ensure a row is selected in the DataGridView
        If DGVaccounts.SelectedRows.Count > 0 Then
            Dim selectedAccountID As String = DGVaccounts.SelectedRows(0).Cells("accountID").Value.ToString()

            ' Define the query to retrieve account data
            Dim query As String = "SELECT username, pword, fname, lname, course, section, accesslevel, image FROM accounts WHERE ID = @id"

            ' Execute the query and populate the fields
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@id", selectedAccountID)

                Try
                    ' Open the connection if it's closed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Execute the command and read the results
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the fields with the data from the database
                            txtusername.Text = reader("username").ToString()
                            txtpassword.Text = reader("pword").ToString()
                            txtfname.Text = reader("fname").ToString()
                            txtlname.Text = reader("lname").ToString()
                            txtcourse.Text = reader("course").ToString()
                            txtsection.Text = reader("section").ToString()
                            cbolevel.SelectedItem = reader("accesslevel").ToString()

                            ' Check if the image field is not null
                            If Not IsDBNull(reader("image")) Then
                                Dim imageBytes As Byte() = DirectCast(reader("image"), Byte())
                                Using ms As New IO.MemoryStream(imageBytes)
                                    PBpic.Image = Image.FromStream(ms)
                                End Using
                            Else
                                PBpic.Image = Nothing ' Clear the picture box if no image exists
                            End If

                            ' Change the button text to "Update" to indicate modification mode
                            btnadd.Text = "Update"
                        Else
                            MessageBox.Show("No account found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error retrieving account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Close the connection
                    conn.Close()
                End Try
            End Using
        Else
            MessageBox.Show("Please select a row to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    End Sub
End Class
