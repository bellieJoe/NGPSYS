Imports MySql.Data.MySqlClient

Public Class zone_maintenance
    Private Sub zone_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatazone()

    End Sub

    Private Sub loaddatazone()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' SQL query to select data from the database
        Dim query As String = "SELECT zone_id, zone_name FROM zone_tbl"

        ' Create a new MySqlConnection object
        Using connection As New MySqlConnection(connectionString)
            ' Create a MySqlCommand object with the query and connection
            Using command As New MySqlCommand(query, connection)
                ' Open the database connection
                connection.Open()

                ' Create a new DataTable to hold the results
                Dim dataTable As New DataTable()

                ' Load data from the database into the DataTable
                dataTable.Load(command.ExecuteReader())

                ' Bind the DataTable to the DataGridView
                usersdata.DataSource = dataTable

                For Each column As DataGridViewColumn In usersdata.Columns
                    column.HeaderCell.Style.Font = New Font(usersdata.Font, FontStyle.Bold) ' Set bold font
                    column.HeaderCell.Style.Font = New Font(usersdata.Font.FontFamily, 9) ' Set smaller font size
                Next




                usersdata.Columns("zone_name").HeaderText = "Zone"

                ' Hide unwanted columns
                For Each column As DataGridViewColumn In usersdata.Columns
                    If column.Name <> "zone_name" Then
                        column.Visible = False
                    End If
                Next

                If usersdata.Columns.Count > 0 Then
                    usersdata.Columns(0).Visible = False
                End If

                usersdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                usersdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersdata.CellDoubleClick
        ' Check if a valid row is clicked (not header row)

        ' Get the data from the selected row
        Dim selectedRow As DataGridViewRow = usersdata.Rows(e.RowIndex)
        ' Display the data in the text box
        txtid.Text = selectedRow.Cells("zone_id").Value.ToString()
        txtname.Text = selectedRow.Cells("zone_name").Value.ToString()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        UpdateData()
        loaddatazone()
    End Sub
    Private Sub UpdateData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Create SQL query to update data
        Dim query As String = "UPDATE zone_tbl SET zone_name = @comnam WHERE zone_id = @id"

        ' Create a new MySqlConnection object
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a MySqlCommand object with the query and connection
            Using command As New MySqlCommand(query, connection)
                ' Set parameters with values from textboxes

                command.Parameters.AddWithValue("@comnam", txtname.Text)
                command.Parameters.AddWithValue("@id", txtid.Text) ' Assuming TextBoxID contains the ID of the record to update

                ' Execute the update command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check if any rows were affected
                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No data updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

    Private Sub DeleteData(id As Integer)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Create SQL query to delete data
        Dim query As String = "DELETE FROM zone_tbl WHERE zone_id = @id"

        ' Create a new MySqlConnection object
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a MySqlCommand object with the query and connection
            Using command As New MySqlCommand(query, connection)
                ' Set parameters with values
                command.Parameters.AddWithValue("@id", id)

                ' Execute the delete command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check if any rows were affected
                If rowsAffected > 0 Then
                    MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No data deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Get the ID from the txtid TextBox
        Dim id As Integer
        If Integer.TryParse(txtid.Text, id) Then
            ' Call the function to delete data from the database
            DeleteData(id)

            ' Reload the updated data in the DataGridView
            loaddatazone()
        Else
            MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class