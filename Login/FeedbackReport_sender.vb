Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class FeedbackReport_sender
    Public room_name As String
    Public room_ID As String
    Public type As String

    Private Sub feedbackstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        usernameloader()
        If type = "report" Then
            cbotype.SelectedIndex = 1
            If Not String.IsNullOrEmpty(room_name) And Not String.IsNullOrEmpty(room_ID) Then
                cboWHAT.SelectedIndex = 1
            End If
        ElseIf type = "feedback" Then
            cbotype.SelectedIndex = 2
            If Not String.IsNullOrEmpty(room_name) And Not String.IsNullOrEmpty(room_ID) Then
                cboWHAT.SelectedIndex = 1
            End If
        Else
            cbotype.SelectedIndex = 0
        End If
    End Sub

    Public Sub usernameloader()
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

    Private Sub labelchanger()
        lblWHAT.Visible = True
        cboWHAT.Visible = True
        If cbotype.SelectedIndex = 1 Then
            lblWHAT.Text = "What to Report?"
        ElseIf cbotype.SelectedIndex = 2 Then
            lblWHAT.Text = "What to Feedback?"
        End If
    End Sub

    Private Sub buttonformater()
        If cboWHAT.SelectedIndex = 1 Then
            btnselect.Visible = True
        End If
    End Sub

    Private Sub clear(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmessage.Text = ""
        cbotype.SelectedIndex = 0
        cboWHAT.SelectedIndex = 0
        room_name = ""
        room_ID = ""
    End Sub

    Private Sub cbotype_selecteditem_change(sender As Object, e As EventArgs) Handles cbotype.SelectedIndexChanged
        If cbotype.SelectedIndex = 0 Then

        ElseIf cbotype.SelectedIndex = 1 Then
            labelchanger()
            buttonformater()
        ElseIf cbotype.SelectedIndex = 2 Then
            labelchanger()
            buttonformater()
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If access = "low" Then
            Student.Show()
        ElseIf access = "mid" Then
            staffreport.tableloader()
            staff_feedback.FeedbackDate()
        End If
        Me.Close()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        FeedbackReport_RoomSelection.Show()
    End Sub

    Private Sub messagesending(sender As Object, e As EventArgs) Handles btnsend.Click
        messageediting = ""
        messagecompiler()
        messagetosend = ""
    End Sub

    Public messagetosend As String
    Public messageediting As String

    Public Sub messagesender()
        If String.IsNullOrEmpty(messageediting) Then
            MessageBox.Show("Error retrieving message")
        Else
            messagetosend = messageediting
        End If

        Dim tableName As String
        Dim messageType As String = cbotype.SelectedItem?.ToString()
        Dim query As String = ""
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim currentTime As String = DateTime.Now.ToString("HH:mm:ss")

        ' Determine the table and query based on the selected message type
        If messageType = "Feedback" Then
            tableName = "feedback"
            query = "INSERT INTO feedback (ID, d, t, feedback) VALUES (@ID, @d, @t, @message)"
        ElseIf messageType = "Report" Then
            tableName = "report"
            query = "INSERT INTO report (ID, d, t, report) VALUES (@ID, @d, @t, @message)"
        Else
            MessageBox.Show("Please select a valid type (Feedback or Report).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using command As New MySqlCommand(query, conn)
            ' Add parameters to prevent SQL injection
            command.Parameters.AddWithValue("@ID", U_ID)
            command.Parameters.AddWithValue("@d", currentDate)
            command.Parameters.AddWithValue("@t", currentTime)
            command.Parameters.AddWithValue("@message", messagetosend)

            Try
                ' Open the connection if it is closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Execute the query
                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtmessage.Clear()
                    cboWHAT.SelectedIndex = 0
                    room_ID = ""
                    room_name = ""
                Else
                    MessageBox.Show("Failed to send the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As MySqlException
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub


    Public Sub messagecompiler()
        If Not String.IsNullOrEmpty(txtuser.Text) And Not String.IsNullOrEmpty(txtmessage.Text()) And cbotype.SelectedIndex > 0 Then
            If cboWHAT.SelectedIndex = 1 Then
                messageediting = "Room Name: " & room_name & vbCrLf & "Room ID: " & room_ID & vbCrLf & txtmessage.Text.Trim()
                messagesender()
            ElseIf cboWHAT.SelectedIndex > 1 Then
                messageediting = txtmessage.Text.Trim()
                messagesender()
            End If
        Else
                MessageBox.Show("Incomplete " & cbotype.Text.ToString() & "!")
        End If
    End Sub

    Public Sub cboWHAT_change(sender As Object, e As EventArgs) Handles cboWHAT.SelectedIndexChanged
        If cboWHAT.SelectedIndex = 1 Then
            btnselect.Visible = True
            btnselect.Enabled = True
        ElseIf Not cboWHAT.SelectedIndex = 1 Then
            btnselect.Visible = False
            btnselect.Enabled = False
        End If
    End Sub

End Class