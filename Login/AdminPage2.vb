Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class AdminPage2
    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        profilepanel.Visible = False
        account_load()
        buttonhidder()
        txtdisabler()
    End Sub

    Private Sub buttonback_Click(sender As Object, e As EventArgs) Handles buttonback.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        adminreport.Show()
        Me.Hide()
    End Sub

    Private Sub btnfeedback_Click(sender As Object, e As EventArgs) Handles btnfeedback.Click
        admin_feedback.Show()
        Me.Hide()
    End Sub

    Private Sub btnroomlogs_Click(sender As Object, e As EventArgs) Handles btnroomlogs.Click
        roomlogs.Show()
        Me.Hide()
    End Sub

    Private Sub btnaccountlogs_Click(sender As Object, e As EventArgs) Handles btnaccountlogs.Click
        accountlogs.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim accountID As String = U_ID
        Dim Action As String = "logout"
        logging_log(accountID, Action)
        U_ID = Nothing
        Login.Show()
        Me.Hide()
    End Sub

    ' profile part
    'profile part
    Private Sub account_load()
        Dim query As String = "SELECT username, fname, lname, ID, accesslevel, image FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            ' Add the ID parameter to prevent SQL injection
            command.Parameters.AddWithValue("@U_ID", U_ID)

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
                        lbname.Text = reader("username").ToString()
                        txtfname.Text = reader("fname").ToString()
                        txtlname.Text = reader("lname").ToString()
                        txtID.Text = reader("ID").ToString()
                        txtlevel.Text = reader("accesslevel").ToString()

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
    End Sub


    Public Sub buttonhidder()
        btnupdate.Visible = False
        btnupdate.Enabled = False
        btnpic.Visible = False
        btnpic.Enabled = False
    End Sub

    Public Sub buttonshow()
        btnupdate.Visible = True
        btnupdate.Enabled = True
        btnpic.Visible = True
        btnpic.Enabled = True
    End Sub


    Private Sub buttonpic_Click(sender As Object, e As EventArgs)
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

    Public Sub txtenabler()
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtusername.ReadOnly = False
    End Sub

    Public Sub txtdisabler()
        txtfname.ReadOnly = True
        txtlname.ReadOnly = True
        txtusername.ReadOnly = True
    End Sub


    Private Sub btnmodify_Click(sender As Object, e As EventArgs)
        buttonshow()
        txtenabler()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)
        ' Ensure that username, fname, and lname fields are not empty
        If String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtfname.Text) OrElse String.IsNullOrEmpty(txtlname.Text) Then
            MessageBox.Show("Please ensure that all fields (Username, First Name, Last Name) are filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' The ID (U_ID) and access level are not editable, so we can use the existing U_ID
        Dim selectedID As String = U_ID

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
                                                "fname = @fname, " &
                                                "lname = @lname, " &
                                                "image = @picture " &  ' Assuming picture is stored as a binary (BLOB) field
                                                "WHERE ID = @id"

                    ' Execute the update query
                    Using updateCommand As New MySqlCommand(updateQuery, conn)
                        ' Add parameters to prevent SQL injection
                        updateCommand.Parameters.AddWithValue("@username", txtusername.Text)
                        updateCommand.Parameters.AddWithValue("@fname", txtfname.Text)
                        updateCommand.Parameters.AddWithValue("@lname", txtlname.Text)

                        ' For the picture, we need to save the image in the database (convert it to a binary format if needed)
                        If PBpic.Image IsNot Nothing Then
                            Try
                                Dim ms As New IO.MemoryStream()
                                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                                updateCommand.Parameters.AddWithValue("@picture", ms.ToArray())  ' Store the image as binary data
                            Catch ex As Exception
                                MessageBox.Show("Error saving image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End Try
                        Else
                            ' If no picture is selected, store a NULL or empty value (depending on your database schema)
                            updateCommand.Parameters.AddWithValue("@picture", DBNull.Value)
                        End If

                        updateCommand.Parameters.AddWithValue("@id", selectedID)

                        Try
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Optionally, refresh the profile information (e.g., call account_load() to reload the data)
                            account_load()

                            ' Optionally clear fields or reset the UI state
                            txtdisabler()
                            buttonhidder()

                        Catch ex As Exception
                            MessageBox.Show($"Error updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        If profilepanel.Visible = False Then
            profilepanel.Visible = True
        ElseIf profilepanel.Visible = True Then
            profilepanel.Visible = False
        End If
    End Sub
End Class