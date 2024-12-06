Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class FeedbackReport_RoomSelection

    ' Handles the selection of a room and passes data to the parent form
    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Ensure a row is selected in the DataGridView
        If DGVroomlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to proceed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Retrieve values from the selected row
            Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)
            Dim roomCode As String = selectedRow.Cells("room_code").Value?.ToString()
            Dim roomName As String = selectedRow.Cells("room_name").Value?.ToString()

            ' Locate the parent form and pass data
            Dim parentForm As FeedbackReport_sender = CType(Application.OpenForms("FeedbackReport_sender"), FeedbackReport_sender)
            If parentForm IsNot Nothing Then
                parentForm.room_ID = roomCode
                parentForm.room_name = roomName
                MessageBox.Show($"Room '{roomCode}' selected.", "Selection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Close the selection form
            Else
                MessageBox.Show("Parent form not found. Unable to pass data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Loads room data into the DataGridView
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
            ' Open the database connection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Load data into the DataTable
            dataAdapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            DGVroomlist.AutoGenerateColumns = False
            DGVroomlist.DataSource = dataTable

            ' Map DataGridView columns to data source fields
            DGVroomlist.Columns("room_code").DataPropertyName = "room_code"
            DGVroomlist.Columns("room_name").DataPropertyName = "room_name"
            DGVroomlist.Columns("building").DataPropertyName = "building"
            DGVroomlist.Columns("num_chairs").DataPropertyName = "num_chairs"
            DGVroomlist.Columns("num_computers").DataPropertyName = "num_computers"
            DGVroomlist.Columns("num_laptops").DataPropertyName = "num_laptops"
            DGVroomlist.Columns("status").DataPropertyName = "display_status" ' Use the calculated column
        Catch ex As Exception
            MessageBox.Show("Error loading room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Handles search functionality based on the selected category
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim category As String = cboType.SelectedItem?.ToString()
        Dim searchValue As String = txtsearch.Text.Trim()

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

        Try
            Dim dataTable As DataTable = CType(DGVroomlist.DataSource, DataTable)
            If String.IsNullOrEmpty(searchValue) Then
                dataTable.DefaultView.Sort = $"{columnName} ASC"
            Else
                dataTable.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'"
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handles form load and initial setup
    Private Sub Staff_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        cboType.SelectedIndex = 0
        DbConnect()
        LoadRoomData()
    End Sub

    ' Handles the back button click event
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
End Class
