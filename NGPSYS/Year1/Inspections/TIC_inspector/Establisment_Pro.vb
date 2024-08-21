Imports System.Collections.ObjectModel
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Imports clear.FormUtilities
Imports Mysqlx
Imports Org.BouncyCastle.Crypto.Engines

Public Class Establisment_Pro
    Private Sub Establisment_Pro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        cmbdateinspected()


    End Sub


    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Me.Close()

    End Sub






    Private Sub readonlydisplay()
        txtuniquecode.ReadOnly = True
        tic_name.ReadOnly = True
        tic_position.ReadOnly = True

        tict_totalseed.ReadOnly = True
        tic_seedpro.ReadOnly = True

        Btnsub.Visible = False


    End Sub




    Public Sub displayinspector()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        Dim query As String = "SELECT firstname, middlename, lastname, job_position, date_request, date_inspection FROM inspector_details_tbl WHERE unique_code = @selectedValue AND filter_code iS NULL "
        Dim dataSet As New DataSet()
        Dim code As String = ongoing_details.txtuniquecode.Text.ToString

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@selectedValue", code)

            connection.Open()

            dataSet.Clear()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dataSet, "YourTableName")



            DataGridView1.DataSource = dataSet.Tables("YourTableName")

            DataGridView1.Columns("firstname").HeaderText = "Firstname"
            DataGridView1.Columns("middlename").HeaderText = "Middlename"
            DataGridView1.Columns("lastname").HeaderText = "Lastname"
            DataGridView1.Columns("job_position").HeaderText = "Job Position"




            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Assuming you have TextBox controls named TextBoxFirstName and TextBoxLastName
                Dim firstName As String = reader("firstname").ToString()
                Dim middleName As String = reader("middlename").ToString()
                Dim lastName As String = reader("lastname").ToString()
                Dim contact As String = $"{firstName} {middleName} {lastName}"
                Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                Dim datestake As Date = Convert.ToDateTime(reader("date_request").ToString)

                tic_name.Text = contact
                tic_position.Text = reader("job_position").ToString()


                datereq.Value = datestake.ToString("MMMM dd, yyyy")
                dateinspection.Text = datetic.ToString("MMMM dd, yyyy")

            Else

            End If

            reader.Close()
        End Using

        connection.Close()
    End Sub

    Public Sub displayinspectoryear2()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        Dim query As String = "SELECT firstname, middlename, lastname, job_position, date_request, date_inspection FROM inspector_details_tbl WHERE unique_code = @selectedValue AND LENGTH(filter_code) = 4 "
        Dim dataSet As New DataSet()
        Dim code As String = ongoing_details.txtuniquecode.Text.ToString

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@selectedValue", code)

            connection.Open()

            dataSet.Clear()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dataSet, "YourTableName")



            DataGridView1.DataSource = dataSet.Tables("YourTableName")

            DataGridView1.Columns("firstname").HeaderText = "Firstname"
            DataGridView1.Columns("middlename").HeaderText = "Middlename"
            DataGridView1.Columns("lastname").HeaderText = "Lastname"
            DataGridView1.Columns("job_position").HeaderText = "Job Position"




            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Assuming you have TextBox controls named TextBoxFirstName and TextBoxLastName
                Dim firstName As String = reader("firstname").ToString()
                Dim middleName As String = reader("middlename").ToString()
                Dim lastName As String = reader("lastname").ToString()
                Dim contact As String = $"{firstName} {middleName} {lastName}"
                Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                Dim datestake As Date = Convert.ToDateTime(reader("date_request").ToString)



                tic_name.Text = contact
                tic_position.Text = reader("job_position").ToString()


                datereq.Value = datestake.ToString("MMMM dd, yyyy")
                dateinspection.Text = datetic.ToString("MMMM dd, yyyy")

            Else

            End If

            reader.Close()
        End Using

        connection.Close()
    End Sub





    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Add your custom code here
        ' This code will run when the form is closing

        ' For example, you can prompt the user to confirm before closing:
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the form closing event
        Else
            FormUtilities.ClearFormControls(Me)
            cmbinspected.Items.Clear()

        End If
    End Sub




    Public Sub cmbdateinspected()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = ""
        Dim code As String = ongoing_details.txtuniquecode.Text.Trim() ' Trim to remove any leading or trailing spaces
        Dim connection As New MySqlConnection(connectionString)

        ' Determine the query based on the value of tic_change
        If tic_change = 2 Then
            query = "SELECT DISTINCT date_request FROM inspector_details_tbl WHERE unique_code = @selectedValue AND LENGTH(filter_code) = 5"
        ElseIf tic_change = 1 Then
            query = "SELECT DISTINCT date_request FROM inspector_details_tbl WHERE unique_code = @selectedValue AND LENGTH(filter_code) = 4"
        Else
            query = "SELECT DISTINCT date_request FROM inspector_details_tbl WHERE unique_code = @selectedValue AND filter_code IS NULL"
        End If

        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@selectedValue", code)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbinspected.Items.Clear()

            While reader.Read()
                ' Populate ComboBox with formatted date requests if the retrieved value is a valid date
                If Not reader.IsDBNull(reader.GetOrdinal("date_request")) Then
                    Dim dateRequest As DateTime
                    If DateTime.TryParse(reader("date_request").ToString(), dateRequest) Then
                        Dim formattedDate As String = dateRequest.ToString("MMMM dd, yyyy")
                        cmbinspected.Items.Add(formattedDate)
                    Else
                        ' Handle invalid date format
                        MessageBox.Show("Invalid date format retrieved from the database.")
                    End If
                End If
            End While

            reader.Close()

            ' Check if no data was retrieved
            If cmbinspected.Items.Count = 0 Then
                MessageBox.Show("No data retrieved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try


    End Sub

    Private Sub cmbinspected_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbinspected.SelectedIndexChanged
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        Dim code As String = ongoing_details.txtuniquecode.Text.Trim()
        Dim query As String = ""

        If tic_change = 2 Then
            query = "SELECT inspector_id, firstname, middlename, lastname, job_position, date_request, date_inspection FROM inspector_details_tbl WHERE unique_code = @selectedValue1 AND date_request = @selectedValue AND LENGTH(filter_code) = 5"

        ElseIf tic_change = 1 Then
            query = "SELECT inspector_id, firstname, middlename, lastname, job_position, date_request, date_inspection FROM inspector_details_tbl WHERE unique_code = @selectedValue1 AND date_request = @selectedValue AND LENGTH(filter_code) = 4"
        Else
            query = "SELECT inspector_id, firstname, middlename, lastname, job_position, date_request, date_inspection FROM inspector_details_tbl WHERE unique_code = @selectedValue1 AND date_request = @selectedValue AND filter_code IS NULL"
        End If

        Dim dataSet As New DataSet()
        Dim selectedDate As Date

        ' Check if the selected item is a valid date
        If Date.TryParse(cmbinspected.SelectedItem?.ToString(), selectedDate) Then
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@selectedValue", selectedDate)
                cmd.Parameters.AddWithValue("@selectedValue1", code)

                Try
                    connection.Open()

                    dataSet.Clear()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataSet, "YourTableName")

                    DataGridView1.DataSource = dataSet.Tables("YourTableName")

                    DataGridView1.Columns("firstname").HeaderText = "Firstname"
                    DataGridView1.Columns("middlename").HeaderText = "Middlename"
                    DataGridView1.Columns("lastname").HeaderText = "Lastname"
                    DataGridView1.Columns("job_position").HeaderText = "Job Position"

                    ' Hide unwanted columns
                    For Each column As DataGridViewColumn In DataGridView1.Columns
                        If column.Name <> "firstname" AndAlso column.Name <> "middlename" AndAlso column.Name <> "lastname" AndAlso column.Name <> "job_position" Then
                            column.Visible = False
                        End If
                    Next

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' Assuming you have TextBox controls named tic_name and tic_position
                        txtid.Text = reader("inspector_id").ToString()
                        tic_name.Text = reader("firstname").ToString()
                        tic_mid.Text = reader("middlename").ToString()
                        tic_lastname.Text = reader("lastname").ToString()
                        tic_position.Text = reader("job_position").ToString()

                        Dim datetic As Date = reader.GetDateTime("date_inspection")
                        Dim datestake As Date = reader.GetDateTime("date_request")

                        datereq.Value = datestake.ToString("MMMM dd, yyyy")
                        dateinspection.Value = datetic.ToString("MMMM dd, yyyy")
                    Else
                        ' Handle case where no records found for the selected value
                        MessageBox.Show("No records found for the selected date.")
                    End If

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a valid date.")
        End If

        connection.Close()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim firstName As String = DataGridView1.Item("Firstname", DataGridView1.CurrentRow.Index).Value.ToString()
        Dim middleName As String = DataGridView1.Item("Middlename", DataGridView1.CurrentRow.Index).Value.ToString()
        Dim lastName As String = DataGridView1.Item("Lastname", DataGridView1.CurrentRow.Index).Value.ToString()
        txtid.Text = DataGridView1.Item("inspector_id", DataGridView1.CurrentRow.Index).Value.ToString()
        tic_name.Text = firstName
        tic_mid.Text = middleName
        tic_lastname.Text = lastName


        tic_position.Text = DataGridView1.Item("Job_Position", DataGridView1.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        tic_name.ReadOnly = False
        tic_mid.ReadOnly = False
        tic_lastname.ReadOnly = False
        tic_position.ReadOnly = False
        btnsave.BringToFront()
    End Sub

    Public Sub UpdateInspectorDetails()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query for update
                Dim query As String = "UPDATE inspector_details_tbl " &
                                      "SET firstname = @firstname, middlename = @middlename, lastname = @lastname, " &
                                      "job_position = @job_position, date_request = @date_request, date_inspection = @date_inspection " &
                                      "WHERE inspector_id = @id" ' Replace with your specific condition

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", txtid.Text)
                    command.Parameters.AddWithValue("@firstname", tic_name.Text)
                    command.Parameters.AddWithValue("@middlename", tic_mid.Text)
                    command.Parameters.AddWithValue("@lastname", tic_lastname.Text)
                    command.Parameters.AddWithValue("@job_position", tic_position.Text)
                    command.Parameters.AddWithValue("@date_request", datereq.Value)
                    command.Parameters.AddWithValue("@date_inspection", dateinspection.Value)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Inspector details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No records updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
            btnedit.BringToFront()
        End Using
    End Sub

    Public Sub DeleteInspectorDetails()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query for deletion
                Dim query As String = "DELETE FROM inspector_details_tbl WHERE inspector_id = @id"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", txtid.Text)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Inspector details deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No records deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        UpdateInspectorDetails()
        cmbdateinspected()


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        DataGridView1.DataSource = Nothing
        DeleteInspectorDetails()
        cmbdateinspected()
    End Sub
End Class