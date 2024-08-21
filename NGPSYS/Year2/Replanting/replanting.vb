Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class replanting

    Dim totaltarget As Double
    Dim itcom As Integer
    Dim qty As Double
    Dim unit As Double
    Private Sub replanting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox()

        Dim itemCount As Integer = cmbcom.Items.Count
        itcom = itemCount

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

    Private Sub RemoveSelectedItem()
        ' Check if an item is selected in the ComboBox
        If cmbcom.SelectedIndex <> -1 Then
            ' Remove the selected item from the ComboBox
            cmbcom.Items.RemoveAt(cmbcom.SelectedIndex)
            txttotalcost.Clear()
            txtunit.Clear()
            txtnoseed.Clear()
            itcom -= 1

            If itcom <= 0 Then
                patrolworks_inventory.Show()
                Me.Close()
                btnsubmit.Visible = False
                txtunit.Enabled = False
                txttotalcost.Enabled = False
                txtnoseed.Enabled = False
                cmbcom.Enabled = False
            End If

        Else
            MessageBox.Show("No item selected to remove.")
        End If
    End Sub

    Private Sub txtnoseed_TextChanged(sender As Object, e As EventArgs) Handles txtnoseed.TextChanged

    End Sub

    Private Sub txtunit_TextChanged(sender As Object, e As EventArgs) Handles txtunit.TextChanged



        Dim total_qty As Double
        Dim total_unit As Double


        If Double.TryParse(txtnoseed.Text, qty) Then
            total_qty = qty

        Else

        End If

        If Double.TryParse(txtunit.Text, unit) Then
            total_unit = unit

        Else

        End If

        totaltarget = (total_qty * total_unit)
        txttotalcost.Text = totaltarget.ToString("N2")
    End Sub

    Private Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Try

            Dim query As String = "INSERT INTO year2nd_data_tbl (unique_code, type_code, quarter_code, commodity, quantity, unit, total_cost, filter_code ) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", uniquecodeloading)
            command.Parameters.AddWithValue("@Value2", lbltype.Text)
            command.Parameters.AddWithValue("@Value3", year2_inspection.lblcode.Text)
            command.Parameters.AddWithValue("@Value4", cmbcom.SelectedItem.ToString)
            command.Parameters.AddWithValue("@Value5", txtnoseed.Text)
            command.Parameters.AddWithValue("@Value6", txtunit.Text)
            command.Parameters.AddWithValue("@Value7", totaltarget)
            command.Parameters.AddWithValue("@Value8", quarter12)
            command.ExecuteNonQuery()

            ' Close the connection
            connection.Close()
            MessageBox.Show("Data inserted Successfully.")
            ' Optionally, display a success message
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        submit()
        RemoveSelectedItem()


    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class