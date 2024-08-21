Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports MySql.Data.MySqlClient

Public Class addsurvivalrate

    Dim itcom As Integer
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Public Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        Try
            connection.Open()

            ' Insert into contract_tbl
            Dim contractQuery As String = "INSERT INTO survival_rate_year1 (unique_code, commodity, area_planted, no_seedling_planted, no_seedling_survive, survival_rate) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
            Using command As New MySqlCommand(contractQuery, connection)
                ' ... (your parameter setting code)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", cmbcom.SelectedItem.ToString)
                command.Parameters.AddWithValue("@Value3", txtarea.Text.Replace(",", ""))
                command.Parameters.AddWithValue("@Value4", txtplanted.Text.Replace(",", ""))
                command.Parameters.AddWithValue("@Value5", txtsurvive.Text.Replace(",", ""))
                command.Parameters.AddWithValue("@Value6", txtsurvivalrate.Text.Replace(",", ""))
                command.ExecuteNonQuery()
            End Using

            ' Optionally, display a success message
            MessageBox.Show("Data inserted successfully.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        Finally
            ' Ensure the connection is closed, even in the case of an exception
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        clear()


    End Sub

    Sub clear()

        txtarea.Clear()
        txtplanted.Clear()
        txtsurvive.Clear()
        txtsurvivalrate.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        syssurvive = 1
        submit()
        RemoveSelectedItem()

        '
    End Sub

    Private Sub txtplanted_TextChanged(sender As Object, e As EventArgs) Handles txtplanted.TextChanged, txtsurvive.TextChanged
        Dim input1 As Double
        Dim input2 As Double
        If Double.TryParse(txtsurvive.Text, input1) AndAlso Double.TryParse(txtplanted.Text, input2) Then
            ' Calculate the percentage and display it in TextBox3
            Dim percentage As Double = (input1 / input2) * 100
            txtsurvivalrate.Text = percentage.ToString("0.00") ' Display percentage with two decimal places
        Else
            ' If the input is not valid, clear TextBox3
            txtsurvivalrate.Clear()
        End If

    End Sub

    Private Sub addsurvivalrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        PopulateComboBox()
        Dim itemCount As Integer = cmbcom.Items.Count
        itcom = itemCount
    End Sub

    Private Sub RemoveSelectedItem()
        ' Check if an item is selected in the ComboBox
        If cmbcom.SelectedIndex <> -1 Then
            ' Remove the selected item from the ComboBox
            cmbcom.Items.RemoveAt(cmbcom.SelectedIndex)
            clear()
            itcom -= 1

            If itcom <= 0 Then
                Me.Close()



                Dim mp As New Maintenance_Protection()
                mp.Show()
                cmbcom.Enabled = False
            End If

        Else
            MessageBox.Show("No item selected to remove.")
        End If
    End Sub

    Private Sub PopulateComboBox()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity_name FROM commodity_unitcost_tbl WHERE unique_code = @value;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management.
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectRecordQuery, connection)
                ' Add a parameter for the unique code to be used in the query.
                command.Parameters.AddWithValue("@value", uniquecodeloading.Trim) ' Use .Text.Trim() to get the value from the TextBox.

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    cmbcom.Items.Clear()

                    While reader.Read()
                        ' Populate ComboBox with commodity names.
                        cmbcom.Items.Add(reader.GetString("commodity_name"))
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class