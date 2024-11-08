Imports MySql.Data.MySqlClient
Imports ConnectionModule

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Ensure the connection is established when the form loads
        DbConnect()

        ' Add a Resize event handler to adjust font size dynamically
        AddHandler tableLayoutPanel.Resize, AddressOf TableLayoutPanel_Resize

        ' Also handle the Form Resize to trigger font adjustment
        AddHandler Me.Resize, AddressOf TableLayoutPanel_Resize

        ' Add the TableLayoutPanel to the form
        Me.Controls.Add(tableLayoutPanel)
    End Sub

    ' Method to dynamically adjust font sizes based on the TableLayoutPanel size
    Private Sub TableLayoutPanel_Resize(sender As Object, e As EventArgs)
        Dim tableLayoutPanel As TableLayoutPanel = DirectCast(sender, TableLayoutPanel)
        Dim fontSize As Single = Math.Min(tableLayoutPanel.Width / 25, tableLayoutPanel.Height / 25) ' Adjust scaling factor as needed

        ' Output table layout size and font size for debugging
        Debug.WriteLine("TableLayoutPanel Width: " & tableLayoutPanel.Width)
        Debug.WriteLine("TableLayoutPanel Height: " & tableLayoutPanel.Height)
        Debug.WriteLine("Calculated Font Size: " & fontSize)

        ' Adjust font for each control in the table layout
        For Each ctrl As Control In tableLayoutPanel.Controls
            If TypeOf ctrl Is Label OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is TextBox Then
                Debug.WriteLine("Resizing control: " & ctrl.Name & " - Type: " & ctrl.GetType().Name & " - Current Font Size: " & ctrl.Font.Size)

                ' Update the font with the new size
                ctrl.Font = New Font(ctrl.Font.FontFamily, fontSize, ctrl.Font.Style)

                ' Output updated font size for the control
                Debug.WriteLine("Updated Font Size for " & ctrl.Name & ": " & ctrl.Font.Size)
            End If
        Next
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtuname.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MsgBox("Username or Password is Incorrect, Please Try Again!")
            Return
        End If

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                DbConnect()
            End If

            ' Query to retrieve the ID and access level
            Dim query As String = "SELECT ID, accesslevel FROM accounts WHERE username=@username AND pword=@pword"
            Dim command As New MySqlCommand(query, conn)

            ' Add parameters to the command
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@pword", password)

            ' Execute the query and check if the user exists
            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Read() ' Move to the first row
                    Dim accountId As String = reader("ID").ToString() ' Get the ID of the account as a string
                    Dim accountlevel As String = reader("accesslevel").ToString().ToLower() ' Get account level in lowercase

                    reader.Close() ' Close the reader as it's no longer needed

                    ' Open different forms based on account level and pass the ID
                    Select Case accountlevel
                        Case "low"
                            Dim low As New Student()
                            ' low.U_ID = accountId
                            low.Show() ' Open Form for low-level account UI
                            Me.Hide() ' Hide current form
                            MsgBox("Welcome " & username)
                            txtpassword.Clear()
                            txtuname.Clear()

                        Case "mid"
                            Dim mid As New Staff()
                            ' mid.U_ID = accountId
                            mid.Show() ' Open Form for mid-level account UI
                            Me.Hide() ' Hide current form
                            MsgBox("Welcome " & username)
                            txtpassword.Clear()
                            txtuname.Clear()

                        Case "high"
                            ' Create the Admin form, assign U_ID and show it
                            Dim high As New Admin()
                            high.U_ID = accountId ' Pass the account ID to the Admin form
                            high.Show() ' Open Form for high-level account UI
                            Me.Hide() ' Hide current form
                            MsgBox("Welcome " & username)
                            txtpassword.Clear()
                            txtuname.Clear()

                        Case Else
                            MsgBox("Error: Account level not recognized")
                    End Select
                Else
                    MsgBox("Username or Password is Incorrect, Please Try Again!")
                End If
            End Using ' Reader and connection will be properly closed here

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






    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        ' Ensure the connection is closed
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Dim create As New accountcreationlow()
        create.Show() ' Open Form2 for account creation
        Me.Hide() ' Hide Form1
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
