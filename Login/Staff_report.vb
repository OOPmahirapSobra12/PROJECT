Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Staff_report
    Dim nowdate As String
    Dim nowtime As String
    Public Sub typeloader()
        If Type = "report then" Then
            txttitle.Text = "Report"
        ElseIf Type = "feedback" Then
            txttitle.Text = "Feedback"
        End If
    End Sub

    Public Sub nameloader()
        Dim query As String = "SELECT username FROM accounts WHERE ID = @U_ID"
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
                        txtuser.Text = reader("username").ToString()

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

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        If String.IsNullOrEmpty(txtmessage.Text) Then
            MsgBox("Error, no message detected, please fill up the messagebox!")
        Else
            timedategetter(nowdate, nowtime)
            If Type = "report" Then
                Dim query As String = "Insert into report (sender, ID, d, t, report) values (@sender, @ID, @d, @t, @report)"
                Using command As New MySqlCommand(query, conn)
                    ' Add the ID parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@sender", txtuser.Text)
                    command.Parameters.AddWithValue("@ID", U_ID)
                    command.Parameters.AddWithValue("@d", nowdate)
                    command.Parameters.AddWithValue("@t", nowtime)
                    command.Parameters.AddWithValue("@report", txtmessage.Text)

                    Try
                        ' Open the database connection if it's closed
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        ' Execute the insert command
                        command.ExecuteNonQuery()
                        MessageBox.Show("report has been successfully reported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error reporting: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        conn.Close() ' Ensure the connection is closed
                    End Try
                End Using
            ElseIf Type = "feedback" Then
                Dim query As String = "Insert into feedback (sender, ID, d, t, feedback) values (@sender, @ID, @d, @t, @feedback)"
                Using command As New MySqlCommand(query, conn)
                    ' Add the ID parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@sender", txtuser.Text)
                    command.Parameters.AddWithValue("@ID", U_ID)
                    command.Parameters.AddWithValue("@d", nowdate)
                    command.Parameters.AddWithValue("@t", nowtime)
                    command.Parameters.AddWithValue("@feedback", txtmessage.Text)

                    Try
                        ' Open the database connection if it's closed
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        ' Execute the insert command
                        command.ExecuteNonQuery()
                        MessageBox.Show("report has been successfully reported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error reporting: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        conn.Close() ' Ensure the connection is closed
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub Staff_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        typeloader()
        nameloader()
    End Sub

    Public Sub timedategetter(nowdate, nowtime)
        nowdate = DateTime.Now.ToString("MM-dd-yyyy")
        nowtime = DateTime.Now.ToString("hh:mm:ss-tt")
    End Sub
End Class