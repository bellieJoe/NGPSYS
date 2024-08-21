Imports MySql.Data.MySqlClient

Public Class organization_maintenance
    Private Sub organization_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddataorg()
    End Sub

    Private Sub loaddataorg()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' SQL query to select data from the database
        Dim query As String = "SELECT Org_ID, Org_name, Org_type, Org_tenure FROM organizational_tbl"

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




                usersdata.Columns("Org_name").HeaderText = "Organizational Name"
                usersdata.Columns("Org_type").HeaderText = "Org Type"
                usersdata.Columns("Org_tenure").HeaderText = "Org Tenure"

                ' Hide unwanted columns
                For Each column As DataGridViewColumn In usersdata.Columns
                    If column.Name <> "Org_name" AndAlso column.Name <> "Org_type" AndAlso column.Name <> "Org_tenure" Then
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
        txtorgname.Text = selectedRow.Cells("Org_name").Value.ToString()
        txtorgtype.Text = selectedRow.Cells("Org_type").Value.ToString()
        ' Display other data as needed
        txttenure.Text = selectedRow.Cells("Org_tenure").Value.ToString()
        txtid.Text = selectedRow.Cells("Org_ID").Value.ToString()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        UpdateData()
        loaddataorg()

    End Sub

    Private Sub UpdateData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Create SQL query to update data
        Dim query As String = "UPDATE organizational_tbl SET Org_name = @Orgname, Org_type = @Orgtype, Org_tenure = @Orgtenure WHERE Org_ID = @id"

        ' Create a new MySqlConnection object
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a MySqlCommand object with the query and connection
            Using command As New MySqlCommand(query, connection)
                ' Set parameters with values from textboxes

                command.Parameters.AddWithValue("@Orgname", txtorgname.Text)
                command.Parameters.AddWithValue("@Orgtype", txtorgtype.Text)
                command.Parameters.AddWithValue("@Orgtenure", txttenure.Text)
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
        Dim query As String = "DELETE FROM organizational_tbl WHERE Org_ID = @id"

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
            loaddataorg()
        Else
            MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub txtorgname_TextChanged(sender As Object, e As EventArgs) Handles txtorgname.TextChanged
    End Sub

    Private Sub txtorgtype_TextChanged(sender As Object, e As EventArgs) Handles txtorgtype.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
End Class