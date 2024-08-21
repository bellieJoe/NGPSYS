Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class user_maintenance


    Private Sub user_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaduserdata
    End Sub

    Private Sub loaduserdata()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' SQL query to select data from the database
        Dim query As String = "SELECT CONCAT_WS(' ', firstname, middlename, lastname) AS name, user_id, account_type, username, email_address, password, address, phone_num, gender FROM account"

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
                    column.HeaderCell.Style.Font = New Font(usersdata.Font.FontFamily, 8) ' Set smaller font size
                Next

                usersdata.Columns("account_type").HeaderText = "Account Type"
                usersdata.Columns("username").HeaderText = "Username"
                usersdata.Columns("password").HeaderText = "Password"
                usersdata.Columns("email_address").HeaderText = "Email Address"
                usersdata.Columns("address").HeaderText = "Address"

                ' Hide unwanted columns
                For Each column As DataGridViewColumn In usersdata.Columns
                    If column.Name <> "account_type" AndAlso column.Name <> "username" AndAlso column.Name <> "password" AndAlso column.Name <> "email_address" AndAlso column.Name <> "address" Then
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
        txtid.Text = selectedRow.Cells("user_id").Value.ToString()
        txtname.Text = selectedRow.Cells("name").Value.ToString()
        ' Display other data as needed
        txttype.Text = selectedRow.Cells("account_type").Value.ToString()
        txtuser.Text = selectedRow.Cells("username").Value.ToString()
        txtemail.Text = selectedRow.Cells("email_address").Value.ToString()
        txtpassword.Text = selectedRow.Cells("password").Value.ToString()
        txtadd.Text = selectedRow.Cells("address").Value.ToString()
        txtphone.Text = selectedRow.Cells("phone_num").Value.ToString()
        txtgender.Text = selectedRow.Cells("gender").Value.ToString()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        UpdateData()
        loaduserdata()

    End Sub

    Private Sub UpdateData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Create SQL query to update data
        Dim query As String = "UPDATE account SET account_type = @account_type, username = @username, email_address = @email_address, password = @password, address = @address, phone_num = @phone_num, gender = @gender WHERE user_id = @id"

        ' Create a new MySqlConnection object
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a MySqlCommand object with the query and connection
            Using command As New MySqlCommand(query, connection)
                ' Set parameters with values from textboxes

                command.Parameters.AddWithValue("@account_type", txttype.Text)
                command.Parameters.AddWithValue("@username", txtuser.Text)
                command.Parameters.AddWithValue("@email_address", txtemail.Text)
                command.Parameters.AddWithValue("@password", txtpassword.Text)
                command.Parameters.AddWithValue("@address", txtadd.Text)
                command.Parameters.AddWithValue("@phone_num", txtphone.Text)
                command.Parameters.AddWithValue("@gender", txtgender.Text)
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
        Dim query As String = "DELETE FROM account WHERE user_id = @id"

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
            loaduserdata()
        Else
            MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



End Class