Imports MySql.Data.MySqlClient
Imports ConnectionModule
Public Class accountcreationlow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect() ' Ensure the connection is established when the form loads
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim login As New Start_up_Login()
        login.Show() ' Show Form1
        Me.Close() ' Hide Form2
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim username As String = txtuname.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()
        Dim fname As String = txtFname.Text.Trim()
        Dim lname As String = txtLname.Text.Trim()
        Dim id As String = txtID.Text.Trim()
        Dim section As String = TextBox1.Text.Trim()
        Dim course As String = txtcourse.Text.Trim()

        If username = "" OrElse password = "" OrElse fname = "" OrElse lname = "" OrElse id = "" OrElse section = "" OrElse course = "" Then
            MsgBox("Error! Please answer everything and don't leave any blanks")
            Return
        End If

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            Dim query As String = "INSERT INTO accounts (username, pword, fname, lname, ID, course_name, sections, accesslevel)
                                    VALUES (@username, @pword, @fname, @lname, @ID, @course, @section, 'Low');"
            Dim logging As New MySqlCommand(query, conn)

            ' Add parameters to the command
            logging.Parameters.AddWithValue("@username", username)
            logging.Parameters.AddWithValue("@pword", password)
            logging.Parameters.AddWithValue("@fname", fname)
            logging.Parameters.AddWithValue("@lname", lname)
            logging.Parameters.AddWithValue("@ID", id)
            logging.Parameters.AddWithValue("@course", course)
            logging.Parameters.AddWithValue("@section", section)

            ' adding to mysql database
            Dim rowsAffected As Integer = logging.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Account created successfully! " & username & " " & id & password & " " & lname & "," & fname & " of " & course & "-" & " ")
                txtuname.Clear()
                txtpassword.Clear()
                txtFname.Clear()
                txtLname.Clear()
                txtID.Clear()
                txtcourse.Clear()
                TextBox1.Clear()
            Else
                MsgBox("Account creation failed!")
            End If
            logging.Dispose()
        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ' Close the connection if it's open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class