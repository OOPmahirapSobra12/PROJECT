Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Roomlist
    ' Load room data into the DataGridView
    Private Sub LoadRoomData()
        Dim sqlQuery As String = "
        SELECT 
            room_code, 
            room_name, 
            building, 
            num_chairs, 
            num_computers, 
            num_laptops, 
            room_status,
            CASE 
                WHEN room_status = 'Open' THEN occupancy_status 
                ELSE 'Closed' 
            END AS display_status
        FROM roomlist"
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, conn)
        Dim dataTable As New DataTable()

        Try
            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            dataAdapter.Fill(dataTable)
            DGVroomlist.AutoGenerateColumns = False
            DGVroomlist.DataSource = dataTable

            ' Map data to columns
            For Each column As DataGridViewColumn In DGVroomlist.Columns
                Select Case column.Name
                    Case "room_code"
                        column.DataPropertyName = "room_code"
                    Case "room_name"
                        column.DataPropertyName = "room_name"
                    Case "building"
                        column.DataPropertyName = "building"
                    Case "num_chairs"
                        column.DataPropertyName = "num_chairs"
                    Case "num_computers"
                        column.DataPropertyName = "num_computers"
                    Case "num_laptops"
                        column.DataPropertyName = "num_laptops"
                    Case "status"
                        column.DataPropertyName = "display_status" ' Use the calculated column
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection after use
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Form Load event
    Private Sub roomliststaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        LoadRoomData()
        cboType.SelectedIndex = 0
    End Sub

    ' Back button
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If access = "mid" Then
            Staff.Show()
        ElseIf access = "low" Then
            Student.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim category As String = cboType.SelectedItem?.ToString()
        Dim searchValue As String = txtsearch.Text.Trim()

        ' Check if category is valid
        If String.IsNullOrEmpty(category) OrElse category = "Choose" Then
            LoadRoomData()
            Return
        End If

        Dim columnName As String = ""
        Select Case category
            Case "Room Code"
                columnName = "room_code"
            Case "Room Name"
                columnName = "room_name"
            Case "Building"
                columnName = "building"
            Case "Chair #"
                columnName = "num_chairs"
            Case "Computer #"
                columnName = "num_computers"
            Case "Laptop #"
                columnName = "num_laptops"
            Case "Availability"
                columnName = "display_status"
            Case Else
                MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        Dim dataTable As DataTable = CType(DGVroomlist.DataSource, DataTable)

        Try
            ' Handle numeric filtering for specific columns
            If category = "Chair #" OrElse category = "Computer #" OrElse category = "Laptop #" Then
                ' Ensure the input is numeric
                If Not Integer.TryParse(searchValue, Nothing) Then
                    MessageBox.Show($"Please enter a valid number for '{category}'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                dataTable.DefaultView.RowFilter = $"{columnName} = {searchValue}"
            Else
                ' Default string-based filtering
                If String.IsNullOrEmpty(searchValue) Then
                    dataTable.DefaultView.Sort = $"{columnName} ASC"
                Else
                    dataTable.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error applying filter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class