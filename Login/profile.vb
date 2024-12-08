Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Profile
    Private Sub Staff2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        DbConnect()
        account_load()
        buttonhidder()
        txtdisabler()
        txtdisabler_withcondition()
        txtenabler_withcondition()
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        buttonshow()
        txtenabler()
    End Sub

    Private Sub account_load()
        Dim query As String = "SELECT username, fname, lname, ID, pword, sections, course_name, accesslevel, image FROM accounts WHERE ID = @U_ID"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@U_ID", U_ID)

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtusername.Text = reader("username").ToString()
                        txtfname.Text = reader("fname").ToString()
                        txtlname.Text = reader("lname").ToString()
                        txtID.Text = reader("ID").ToString()
                        txtpassword.Text = reader("pword").ToString()
                        txtlevel.Text = reader("accesslevel").ToString()

                        If reader("accesslevel").ToString().ToLower() = "low" Then
                            txtcourse.Text = reader("course_name").ToString()
                            txtsection.Text = reader("sections").ToString()
                        ElseIf Not reader("accesslevel").ToString.ToLower() = "low" Then
                            txtcourse.Enabled = False
                            txtsection.Enabled = False
                            txtcourse.Visible = False
                            txtsection.Visible = False
                            lblcourse.Visible = False
                            lblsection.Visible = False
                        End If

                        If reader("image") IsNot DBNull.Value Then
                            Dim imgData As Byte() = CType(reader("image"), Byte())
                            Using ms As New IO.MemoryStream(imgData)
                                PBpic.Image = Image.FromStream(ms)
                            End Using
                        Else
                            PBpic.Image = Nothing
                        End If
                    Else
                        MessageBox.Show("No record found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
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

    Private Sub buttonpic_Click(sender As Object, e As EventArgs) Handles btnpic.Click
        Dim openFileDialog As New OpenFileDialog() With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            .Title = "Select an Image"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PBpic.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtfname.Text) OrElse String.IsNullOrEmpty(txtlname.Text) Then
            MessageBox.Show("Please ensure that all fields are filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim updateQuery As String
        If access = "low" Then
            updateQuery = "UPDATE accounts SET username = @username, fname = @fname, lname = @lname, pword = @pword, course_name = @course, sections = @section, image = @picture WHERE ID = @id"
        Else
            updateQuery = "UPDATE accounts SET username = @username, fname = @fname, lname = @lname, pword = @pword, image = @picture WHERE ID = @id"
        End If

        Using updateCommand As New MySqlCommand(updateQuery, conn)
            updateCommand.Parameters.AddWithValue("@username", txtusername.Text)
            updateCommand.Parameters.AddWithValue("@fname", txtfname.Text)
            updateCommand.Parameters.AddWithValue("@lname", txtlname.Text)
            updateCommand.Parameters.AddWithValue("@pword", txtpassword.Text)
            updateCommand.Parameters.AddWithValue("@id", txtID.Text)

            If access = "low" Then
                updateCommand.Parameters.AddWithValue("@course", If(String.IsNullOrEmpty(txtcourse.Text), DBNull.Value, txtcourse.Text))
                updateCommand.Parameters.AddWithValue("@section", If(String.IsNullOrEmpty(txtsection.Text), DBNull.Value, txtsection.Text))
            End If

            If PBpic.Image IsNot Nothing Then
                Dim ms As New IO.MemoryStream()
                PBpic.Image.Save(ms, PBpic.Image.RawFormat)
                updateCommand.Parameters.AddWithValue("@picture", ms.ToArray())
            Else
                updateCommand.Parameters.AddWithValue("@picture", DBNull.Value)
            End If

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                account_load()
                txtdisabler()
                buttonhidder()
            Catch ex As Exception
                MessageBox.Show($"Error updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Public Sub txtenabler()
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtusername.ReadOnly = False
        txtpassword.Visible = True
        lblpassword.Visible = True
    End Sub

    Public Sub txtenabler_withcondition()
        If access = "low" Then
            txtcourse.ReadOnly = False
            txtsection.ReadOnly = False
        End If
    End Sub

    Public Sub txtdisabler()
        txtfname.ReadOnly = True
        txtlname.ReadOnly = True
        txtusername.ReadOnly = True
        txtpassword.Visible = False
        lblpassword.Visible = False
    End Sub

    Public Sub txtdisabler_withcondition()
        If Not access = "low" Then
            txtcourse.ReadOnly = True
            txtsection.ReadOnly = True
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If access = "high" Then
            Admin.Show()
        ElseIf access = "mid" Then
            Staff.Show()
        ElseIf access = "low" Then
            Student.Show()
        End If
        Me.Hide()
    End Sub
End Class
