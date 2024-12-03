Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class FeedbackReport_RoomSelection
    Private Sub btnsend_click(sender As Object, e As EventArgs) Handles btnselect.Click
        ' Ensure a row is selected in the DataGridView
        If DGVroomlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to proceed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGVroomlist.SelectedRows(0)

            ' Retrieve values from the selected row
            Dim roomCode As String = selectedRow.Cells("room_code").Value?.ToString()
            Dim roomName As String = selectedRow.Cells("room_name").Value?.ToString()

            ' Assuming feedbackstudent is already instantiated
            Dim parentForm As FeedbackReport_sender_Student = CType(Application.OpenForms("feedbackstudent"), FeedbackReport_sender_Student)

            If parentForm IsNot Nothing Then
                parentForm.room_ID = roomCode
                parentForm.room_name = roomName

                MessageBox.Show($"Room '{roomCode}' selected.", "Selection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Close the room selection form
            Else
                MessageBox.Show("Parent form not found. Unable to pass data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


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

    Private Sub Staff_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        cboType.SelectedIndex = 0
        DbConnect()
    End Sub

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

        Dim dataTable As DataTable = CType(DGVroomlist.DataSource, DataTable)
        If String.IsNullOrEmpty(searchValue) Then
            dataTable.DefaultView.Sort = $"{columnName} ASC"
        Else
            dataTable.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'"
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
End Class