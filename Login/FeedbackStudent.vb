Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class feedbackstudent

    Private Sub feedbackstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        usernameloader()
        cbotype.SelectedIndex = 0
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

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmessage.Text = ""
        cbotype.SelectedIndex = 0
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
        If access = "mid" Then
            Staff.Show()
        ElseIf access = "low" Then
            Student.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        FeedbackReport_Sender.Show()
    End Sub
End Class