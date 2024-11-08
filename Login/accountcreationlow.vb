Imports MySql.Data.MySqlClient
Imports ConnectionModule
Public Class accountcreationlow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new TableLayoutPanel and set Dock to fill the form
        Dim tableLayoutPanel As New TableLayoutPanel()
        tableLayoutPanel.Dock = DockStyle.Fill

        ' Set the number of rows and columns
        tableLayoutPanel.RowCount = 6
        tableLayoutPanel.ColumnCount = 5

        ' Define row styles based on the percentages you provided
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 1
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 7.56F))  ' Row 2
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.67F))  ' Row 3
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 9.56F))  ' Row 4
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.22F))  ' Row 5
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 6

        ' Define column styles based on the percentages you provided
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F)) ' Column 1
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 2
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 3
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.13F)) ' Column 4
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.38F))  ' Column 5

        ' Optionally, add controls to specific cells
        Dim label1 As New Label()
        label1.Text = "Label 1"
        label1.Dock = DockStyle.Fill
        tableLayoutPanel.Controls.Add(label1, 0, 0) ' (column, row)

        ' Add TableLayoutPanel to the form
        Me.Controls.Add(tableLayoutPanel)
        DbConnect() ' Ensure the connection is established when the form loads
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        ' Ensure the connection is closed
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Dim login As New Login()
        login.Show() ' Show Form1
        Me.Close() ' Hide Form2
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim username As String = txtuname.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()
        Dim fname As String = txtFname.Text.Trim()
        Dim lname As String = txtLname.Text.Trim()
        Dim id As String = txtID.Text.Trim()

        If username = "" OrElse password = "" OrElse fname = "" OrElse lname = "" OrElse id = "" Then
            MsgBox("Error! Please answer everything and don't leave any blanks")
            Return
        End If

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            Dim query As String = "insert into accounts (username,pword,fname,lname,ID,accesslevel) values (@username,@pword,@fname,@lname,@ID,'Low');"
            Dim logging As New MySqlCommand(query, conn)

            ' Add parameters to the command
            logging.Parameters.AddWithValue("@username", username)
            logging.Parameters.AddWithValue("@pword", password)
            logging.Parameters.AddWithValue("@fname", fname)
            logging.Parameters.AddWithValue("@lname", lname)
            logging.Parameters.AddWithValue("@ID", id)

            ' adding to mysql database
            Dim rowsAffected As Integer = logging.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Account created successfully! " & username & " " & password & " " & lname & "," & fname & " " & id)
                txtuname.Clear()
                txtpassword.Clear()
                txtFname.Clear()
                txtLname.Clear()
                txtID.Clear()
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class