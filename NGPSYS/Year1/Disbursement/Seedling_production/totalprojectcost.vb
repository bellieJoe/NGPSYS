Imports MySql.Data.MySqlClient

Public Class totalprojectcost

    Dim totaltarget As Double
    Dim itcom As Integer
    Private Sub totalprojectcost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                command.Parameters.AddWithValue("@value", TICdashboard.txtuniquecode.Text.Trim) ' Use .Text.Trim() to get the value from the TextBox.

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

    Private Sub cmbcom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcom.SelectedIndexChanged
        ' Get the selected item from the ComboBox
        Dim selectedCommodity As String = cmbcom.Text ' or cmbcom.SelectedItem.ToString()

        ' Construct a query to retrieve data based on the selected item
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectDataQuery As String = "SELECT seedlingcount FROM commodity_unitcost_tbl WHERE commodity_name = @selectedCommodity AND unique_code = @uniqueCode;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectDataQuery, connection)
                ' Add a parameter for the selected commodity
                command.Parameters.AddWithValue("@selectedCommodity", selectedCommodity)
                command.Parameters.AddWithValue("@uniqueCode", TICdashboard.txtuniquecode.Text)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check if the reader has rows and read the "remarks" column
                            txtnoseed.Text = reader.GetString("seedlingcount")
                        Else
                            ' Handle the case where no remarks are found
                            txtnoseed.Text = "No remarks found."
                        End If
                    End Using
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
                Disburstment_1stquarter.Show(maindash)
                Disburstment_1stquarter.Button1.Visible = False
                Disburstment_1stquarter.Button2.Visible = False
                Disburstment_1stquarter.Button3.Visible = False

                Me.Close()
            End If
        Else
            MessageBox.Show("No item selected to remove.")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateCommodityName()
    End Sub

    Private Sub txtunit_TextChanged(sender As Object, e As EventArgs) Handles txtunit.TextChanged

        Dim mf As Double
        Dim rf As Double



        If Double.TryParse(txtunit.Text, mf) Then
            ' Calculate 15% of the input value.
            Dim result As Double = mf
        Else
            ' If the input is not a valid number, clear the result TextBox.

        End If

        If Double.TryParse(txtnoseed.Text, rf) Then
            Dim result As Double = rf

        Else
        End If

        totaltarget = mf * rf
        txttotalcost.Text = totaltarget.ToString("N2")
    End Sub

    Private Sub UpdateCommodityName()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim updateQuery As String = "UPDATE commodity_unitcost_tbl " &
                                "SET unit_cost = @value1, total_cost_seeds = @value2 " &
                                "WHERE unique_code = @uniqueCode AND commodity_name = @commodityName;"

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(updateQuery, connection)

        ' Add parameters for the new commodity name, unique code, unit cost, and total cost seed
        command.Parameters.AddWithValue("@uniqueCode", TICdashboard.txtuniquecode.Text)
        command.Parameters.AddWithValue("@commodityName", cmbcom.SelectedItem.ToString())
        command.Parameters.AddWithValue("@value1", txtunit.Text)
        command.Parameters.AddWithValue("@value2", totaltarget) ' Make sure totaltarget contains the intended value

        Try
            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("data added successful")


            Else
                MessageBox.Show("No records were updated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

        switch = 1
        RemoveSelectedItem()
    End Sub

    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtnoseed.Clear()
        txttotalcost.Clear()
        txtunit.Clear()

    End Sub



End Class

