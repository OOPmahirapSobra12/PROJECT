Imports MySql.Data.MySqlClient


Public Class RoomlistStaff
    Dim connString As String = "server=127.0.0.1;port=3306;database=roomliststaff2;user=root;password=password;"
    Private conn As MySqlConnection

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

    End Sub





    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoomName.SelectedIndexChanged

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadComboBoxes() ' Call the LoadComboBoxes method


    End Sub
    Public Sub LoadComboBoxes()
        Try
            ' Initialize MySQL connection (do not redeclare it)
            conn = New MySqlConnection(connString)
            conn.Open()

            Dim query As String = "SELECT room_name, room_number, capacity FROM rooms"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear ComboBoxes before loading new data
            ComboBoxRoomName.Items.Clear()
            ComboBoxRoomNumber.Items.Clear()
            ComboBoxCapacity.Items.Clear()

            ' Loop through the records and add data to ComboBoxes
            While reader.Read()
                ComboBoxRoomName.Items.Add(reader("room_name").ToString())
                ComboBoxRoomNumber.Items.Add(reader("room_number").ToString())
                ComboBoxCapacity.Items.Add(reader("capacity").ToString())
            End While

            ' Close the reader and connection
            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoomNumber.SelectedIndexChanged

        If ComboBoxRoomNumber.SelectedItem IsNot Nothing Then
            MessageBox.Show("Selected Room: " & ComboBoxRoomNumber.SelectedItem.ToString())
        End If


    End Sub




End Class