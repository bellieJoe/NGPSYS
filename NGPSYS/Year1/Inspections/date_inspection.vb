Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class date_inspection

    Dim closeSP As String
    Dim closePE As String
    Dim closeMP As String
    Dim closeTIC As Integer

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub date_inspection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim randomCode As String = GenerateRandomUniqueCode(2)
        lblcode.Text = randomCode
        daterequest.CustomFormat = "yyyy-MM-dd"
        dateinspection.CustomFormat = "yyyy-MM-dd"


    End Sub

    Private Sub Newcommcaddbtn_Click(sender As Object, e As EventArgs) Handles Newcommcaddbtn.Click
        connection.Open()
        Try
            If dateinspection.Text = "" Or daterequest.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO date_ticinspection_tbl (unique_code, date_request, date_inspected) VALUES (@Value1, @Value2, @value3)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", Establisment_Pro.txtuniquecode.Text)
                command.Parameters.AddWithValue("@Value2", daterequest.Value)
                command.Parameters.AddWithValue("@Value3", dateinspection.Value)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub daterequest_ValueChanged(sender As Object, e As EventArgs) Handles daterequest.ValueChanged
        If daterequest.Value <> DateTime.MinValue Then
            daterequest.CustomFormat = "yyyy-MM-dd" ' Set your desired date/time format here
            ' Update the year of dateinspection to match daterequest
            dateinspection.Value = New Date(daterequest.Value.Year, dateinspection.Value.Month, dateinspection.Value.Day)
        Else
            daterequest.CustomFormat = "" ' Reset to empty string if no date is selected
        End If
    End Sub

    Private Sub dateinspection_ValueChanged(sender As Object, e As EventArgs) Handles dateinspection.ValueChanged
        If dateinspection.Value <> DateTime.MinValue Then
            dateinspection.CustomFormat = "yyyy-MM-dd" ' Set your desired date/time format here
            ' Update the year of daterequest to match dateinspection
            daterequest.Value = New Date(dateinspection.Value.Year, daterequest.Value.Month, daterequest.Value.Day)
        Else
            dateinspection.CustomFormat = "" ' Reset to empty string if no date is selected
        End If
    End Sub

    Private Sub AddTechnicalInspectionCommitteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTechnicalInspectionCommitteeToolStripMenuItem.Click

        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please add the date of request and inspection first!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            add_TICinspector.ShowDialog()

        End If


    End Sub

    Private Sub AddSeedlingProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSeedlingProductionToolStripMenuItem.Click
        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please add the date of request and inspection first !.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            seedlingpro()
            MultipleSpecies.ShowDialog()
        End If
    End Sub

    Public Sub seedproduction()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(tic_counted) AS total_counted FROM multispecies WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                            closeSP = "0.00" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                            closeSP = totalAmount.ToString("N") ' Update the TextBox
                        End If
                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
        displaysp
    End Sub

    Private Sub displaysp()
        If closeSP = 0 Then
            AddSeedlingProductionToolStripMenuItem.Visible = True
        Else
            AddSeedlingProductionToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Function GenerateRandomUniqueCode(length As Integer) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim data As Byte() = New Byte(3) {}
        Dim result As New StringBuilder(length)
        Dim rng As New RNGCryptoServiceProvider()

        While result.Length < length
            rng.GetBytes(data)
            For Each b As Byte In data
                Dim charIndex As Integer = Convert.ToInt32(b) Mod chars.Length
                If result.Length < length Then
                    result.Append(chars(charIndex))
                End If
            Next
        End While

        Return result.ToString()
    End Function
    Public Sub removePE()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT accomplishment FROM plantation_estab_tbl WHERE unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        Dim accomplishment As Decimal = reader.GetDecimal(0)

                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    End If
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)
                closePE = overallPercentage.ToString

            End Using
        End Using

        displaype()
    End Sub

    Private Sub displaype()
        If closePE = 0 Then
            AddSeedlingPlantedToolStripMenuItem.Visible = True
        Else
            AddSeedlingPlantedToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub AddSeedlingPlantedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSeedlingPlantedToolStripMenuItem.Click


        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please Change the date of request and inspection first!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            plantation()
            add_plantationEstablishment.ShowDialog()

        End If

    End Sub
    Private Sub removeMP()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT accomplishment FROM maintenance_tbl WHERE unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        Dim accomplishment As Decimal = reader.GetDecimal(0)

                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    End If
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)

                ' Display the overall percentage and individual accomplishment in a TextBox

                closeMP = overallPercentage.ToString()
            End Using
        End Using
        displaymp()
    End Sub

    Private Sub displaymp()
        If closeMP = 0 Then
            AddSeedlingRePlantedToolStripMenuItem.Visible = True
        Else
            AddSeedlingRePlantedToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Sub removeTIC()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) FROM inspector_details_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    closeTIC = count
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using
        displayisd()
    End Sub

    Private Sub displayisd()
        If closeTIC = 0 Then
            AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = True
        Else
            AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
        End If
    End Sub
    Sub seedlingpro()
        ' Insert query with placeholders for parameters
        Dim insertQuery As String = "INSERT INTO seedproduction_tbl (seed_code, date_request, date_inspected) VALUES (@Value1, @Value2, @Value3)"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    ' Set parameter values for the insert query
                    insertCommand.Parameters.AddWithValue("@Value1", lblcode.Text) ' Replace with the actual values to insert
                    insertCommand.Parameters.AddWithValue("@Value2", daterequest.Value)
                    insertCommand.Parameters.AddWithValue("@Value3", dateinspection.Value)
                    ' Execute the SQL command to insert into the database
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub plantation()
        Dim insertQuery As String = "INSERT INTO seedplanted_tbl (seed_code, date_request, date_inspected) VALUES (@Value1, @Value2, @Value3)"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    ' Set parameter values for the insert query
                    insertCommand.Parameters.AddWithValue("@Value1", lblcode.Text) ' Replace with the actual values to insert
                    insertCommand.Parameters.AddWithValue("@Value2", daterequest.Value)
                    insertCommand.Parameters.AddWithValue("@Value3", dateinspection.Value)
                    ' Execute the SQL command to insert into the database
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub maintenance()
        Dim insertQuery As String = "INSERT INTO maintenance_pro_tbl (main_code, date_request, date_inspected) VALUES (@Value1, @Value2, @Value3)"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    ' Set parameter values for the insert query
                    insertCommand.Parameters.AddWithValue("@Value1", lblcode.Text) ' Replace with the actual values to insert
                    insertCommand.Parameters.AddWithValue("@Value2", daterequest.Value)
                    insertCommand.Parameters.AddWithValue("@Value3", dateinspection.Value)
                    ' Execute the SQL command to insert into the database
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AddSeedlingRePlantedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSeedlingRePlantedToolStripMenuItem.Click
        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please add the date of request and inspection first!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            maintenance()
            Add_maintenanceprotection.ShowDialog()
        End If
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Public Sub Displayseedproduction()
        Dim closesp As String

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(tic_counted) AS total_counted FROM multispecies WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                            closesp = "0.00" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                            closesp = totalAmount.ToString("N") ' Update the TextBox
                        End If
                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub hidemenu()

        If a = 0 Then
            AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
            AddSeedlingPlantedToolStripMenuItem.Visible = False
            AddSeedlingRePlantedToolStripMenuItem.Visible = False
        ElseIf a = 1 Then
            AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
            AddSeedlingRePlantedToolStripMenuItem.Visible = False
            AddSeedlingProductionToolStripMenuItem.Visible = False
        ElseIf a = 2 Then
            AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
            AddSeedlingPlantedToolStripMenuItem.Visible = False
            AddSeedlingProductionToolStripMenuItem.Visible = False
        Else
            AddSeedlingPlantedToolStripMenuItem.Visible = False
            AddSeedlingProductionToolStripMenuItem.Visible = False
            AddSeedlingRePlantedToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub TICInspectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TICInspectorToolStripMenuItem.Click
        Establisment_Pro.ShowDialog()
    End Sub

    Private Sub WelcomwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomwToolStripMenuItem.Click

    End Sub
End Class