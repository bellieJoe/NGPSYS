Imports MySql.Data.MySqlClient

Public Class year3_view
    Private Sub year3_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populaterandr()
        Populatereplant()
        PopulatePWI()
        dateinspections()
    End Sub


    Private Sub dateinspections()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT date_request, date_inspection  FROM year3rd_inspection_date WHERE quarter_code = @value ;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management.
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectRecordQuery, connection)
                ' Add a parameter for the unique code to be used in the query.
                command.Parameters.AddWithValue("@value", Year3_inspection.lblcode.Text)


                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()




                    While reader.Read()
                        Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                        Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                        txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                        txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using



    End Sub
    Private Sub Populaterandr()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity  FROM year3rd_data_tbl WHERE unique_code = @value AND type_code = @value1 AND quarter_code = @value2;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management.
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectRecordQuery, connection)
                ' Add a parameter for the unique code to be used in the query.
                command.Parameters.AddWithValue("@value", uniquecodeloading.Trim)
                command.Parameters.AddWithValue("@value1", "rwrs") ' Use .Text.Trim() to get the value from the TextBox.
                command.Parameters.AddWithValue("@value2", Year3_inspection.lblcode.Text)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()


                    cmbcom.Items.Clear()

                    While reader.Read()
                        ' Populate ComboBox with commodity names.
                        cmbcom.Items.Add(reader.GetString("commodity"))
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Populatereplant()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity  FROM year3rd_data_tbl WHERE unique_code = @value AND type_code = @value1 AND quarter_code = @value2;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management.
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectRecordQuery, connection)
                ' Add a parameter for the unique code to be used in the query.
                command.Parameters.AddWithValue("@value", uniquecodeloading.Trim)
                command.Parameters.AddWithValue("@value1", "replant") ' Use .Text.Trim() to get the value from the TextBox.
                command.Parameters.AddWithValue("@value2", Year3_inspection.lblcode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    cmbcomre.Items.Clear()

                    While reader.Read()
                        ' Populate ComboBox with commodity names.
                        cmbcomre.Items.Add(reader.GetString("commodity"))
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub PopulatePWI()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity  FROM year3rd_data_tbl WHERE unique_code = @value AND type_code = @value1 AND quarter_code = @value2;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management.
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectRecordQuery, connection)
                ' Add a parameter for the unique code to be used in the query.
                command.Parameters.AddWithValue("@value", uniquecodeloading.Trim)
                command.Parameters.AddWithValue("@value1", "patrol")
                command.Parameters.AddWithValue("@value2", Year3_inspection.lblcode.Text) ' Use .Text.Trim() to get the value from the TextBox.

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    cmbcomPWI.Items.Clear()

                    While reader.Read()
                        ' Populate ComboBox with commodity names.
                        cmbcomPWI.Items.Add(reader.GetString("commodity"))
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbcom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcom.SelectedIndexChanged
        Dim selectedCommodity As String = cmbcom.Text ' or cmbcom.SelectedItem.ToString()

        ' Construct a query to retrieve data based on the selected item
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectDataQuery As String = "SELECT quantity, unit, total_cost FROM year3rd_data_tbl WHERE commodity = @selectedCommodity AND unique_code = @uniqueCode AND type_code = @type AND quarter_code = @value1;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectDataQuery, connection)
                ' Add a parameter for the selected commodity
                command.Parameters.AddWithValue("@selectedCommodity", selectedCommodity)
                command.Parameters.AddWithValue("@uniqueCode", uniquecodeloading)
                command.Parameters.AddWithValue("@type", "rwrs")
                command.Parameters.AddWithValue("@value1", Year3_inspection.lblcode.Text)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check if the reader has rows and read the "remarks" column
                            txtnoseed.Text = reader.GetString("quantity")
                            txtunit.Text = reader.GetString("unit")
                            txttotalcost.Text = reader.GetString("total_cost")
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

    Private Sub cmbcomre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcomre.SelectedIndexChanged
        Dim selectedCommodity As String = cmbcomre.Text ' or cmbcom.SelectedItem.ToString()

        ' Construct a query to retrieve data based on the selected item
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectDataQuery As String = "SELECT quantity, unit, total_cost FROM year3rd_data_tbl WHERE commodity = @selectedCommodity AND unique_code = @uniqueCode AND type_code = @type AND quarter_code = @value1;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectDataQuery, connection)
                ' Add a parameter for the selected commodity
                command.Parameters.AddWithValue("@selectedCommodity", selectedCommodity)
                command.Parameters.AddWithValue("@uniqueCode", uniquecodeloading)
                command.Parameters.AddWithValue("@type", "replant")
                command.Parameters.AddWithValue("@value1", Year3_inspection.lblcode.Text)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check if the reader has rows and read the "remarks" column
                            txtqty1.Text = reader.GetString("quantity")
                            txtunit1.Text = reader.GetString("unit")
                            txttotalcost1.Text = reader.GetString("total_cost")
                        Else
                            ' Handle the case where no remarks are found
                            txtqty1.Text = "No remarks found."
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbocomPWI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcomPWI.SelectedIndexChanged
        Dim selectedCommodity As String = cmbcomPWI.Text ' or cmbcom.SelectedItem.ToString()

        ' Construct a query to retrieve data based on the selected item
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectDataQuery As String = "SELECT quantity, unit, total_cost FROM year3rd_data_tbl WHERE commodity = @selectedCommodity AND unique_code = @uniqueCode AND type_code = @type AND quarter_code = @value1;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectDataQuery, connection)
                ' Add a parameter for the selected commodity
                command.Parameters.AddWithValue("@selectedCommodity", selectedCommodity)
                command.Parameters.AddWithValue("@uniqueCode", uniquecodeloading)
                command.Parameters.AddWithValue("@type", "patrol")
                command.Parameters.AddWithValue("@value1", Year3_inspection.lblcode.Text)


                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check if the reader has rows and read the "remarks" column
                            txtqty2.Text = reader.GetString("quantity")
                            txtunit2.Text = reader.GetString("unit")
                            txttotalcost2.Text = reader.GetString("total_cost")
                        Else
                            ' Handle the case where no remarks are found
                            txtqty2.Text = "No remarks found."
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        btnsubmit.Visible = False
        year3_1st2nd_quarter.Show(maindash)
        Me.Close()
    End Sub

    Private Sub btnsub2_Click_1(sender As Object, e As EventArgs) Handles btnsub2.Click
        btnsub2.Visible = False
        year3_3rdquarter.Show(maindash)
        Me.Close()
    End Sub


    Private Sub btnsub3_Click_1(sender As Object, e As EventArgs) Handles btnsub3.Click
        btnsub3.Visible = False
        year3_4thquarter.Show(maindash)
        Me.Close()
    End Sub


End Class