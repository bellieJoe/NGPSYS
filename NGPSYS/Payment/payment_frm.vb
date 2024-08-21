
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC.Multiplier

Public Class payment_frm

    Dim pc As Double
    Dim tp As Double
    Dim bal As Double

    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

    Private DataSet As New DataSet()
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"


    Private Sub payment_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user()

        ClearFormData()
        LoadData()
        displayprojectcost()
        DisplayTotalAmount()
        balance()




        txtuniquecode.Text = uniquecodeloading.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString


    End Sub

    Private Sub LoadData()
        Dim y As String = "year1"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT disbursement_id, unique_code, disbursement_code, cheque_num, yearcode, payment, date_issued, date_released, ob_mf, ob_rf, db_mf, db_rf, others, total_payment, " &
                              "ob_no, ob_date, dv_no, dv_date, obtc, dvtc FROM flexible_disbursement_tbl WHERE unique_code = @uniquecode AND yearcode = @year"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                cmd.Parameters.AddWithValue("@year", y)

                Try
                    connection.Open()

                    Using adapter As New MySqlDataAdapter(cmd)

                        ' Fill the DataSet with new data
                        adapter.Fill(DataSet, "YourTableName")

                        ' Rebind the DataGridView to the updated DataSet
                        DataGridView1.DataSource = DataSet.Tables("YourTableName")

                        ' Update column headers and visibility
                        DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                        DataGridView1.Columns("disbursement_code").HeaderText = "Section"
                        DataGridView1.Columns("cheque_num").HeaderText = "Cheque No."
                        DataGridView1.Columns("payment").HeaderText = "Payment"

                        DataGridView1.Columns("unique_code").Width = 120
                        DataGridView1.Columns("disbursement_code").Width = 300
                        DataGridView1.Columns("cheque_num").Width = 100

                        For Each column As DataGridViewColumn In DataGridView1.Columns
                            If column.Name <> "unique_code" AndAlso column.Name <> "disbursement_code" AndAlso column.Name <> "cheque_num" Then
                                column.Visible = False
                            End If
                        Next

                        ' Show a message if no data was retrieved
                        If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                            MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle exceptions here (e.g., log the error or show an error message)
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Ensure that the connection is closed, even if an exception occurs
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End Using
        End Using
    End Sub








    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        clearcheckedbox()

        txtid.Text = DataGridView1.Item("disbursement_id", DataGridView1.CurrentRow.Index).Value

        txttitle.Text = DataGridView1.Item("disbursement_code", DataGridView1.CurrentRow.Index).Value


        txtpc.Text = Decimal.Parse(DataGridView1.Item("obtc", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")


        txtmf.Text = Decimal.Parse(DataGridView1.Item("ob_mf", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        If txtmf.Text = "0.00" Then
            txtmf.Text = "N/A"
        Else
            chkmf.Checked = True
        End If

        txtrf.Text = Decimal.Parse(DataGridView1.Item("ob_rf", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        If txtrf.Text = "0.00" Then
            txtrf.Text = "N/A"
        Else
            chkrf.Checked = True
        End If

        txtamount.Text = Decimal.Parse(DataGridView1.Item("dvtc", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")

        txtlessmf.Text = Decimal.Parse(DataGridView1.Item("db_mf", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        If txtlessmf.Text = "0.00" Then
            txtlessmf.Text = "N/A"
        Else
            chklessmf.Checked = True
        End If
        txtlessrf.Text = Decimal.Parse(DataGridView1.Item("db_rf", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        If txtlessrf.Text = "0.00" Then
            txtlessrf.Text = "N/A"
        Else
            chklessrf.Checked = True
        End If
        txtothers.Text = Decimal.Parse(DataGridView1.Item("others", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        If txtothers.Text = "0.00" Then
            txtothers.Text = "N/A"

        Else
            chkothers.Checked = True
        End If

        txtcheque.Text = DataGridView1.Item("cheque_num", DataGridView1.CurrentRow.Index).Value
        txtpayment.Text = Decimal.Parse(DataGridView1.Item("total_payment", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        date_issued.Text = DataGridView1.Item("date_issued", DataGridView1.CurrentRow.Index).Value
        date_released.Text = DataGridView1.Item("date_released", DataGridView1.CurrentRow.Index).Value

        txtob.Text = DataGridView1.Item("ob_no", DataGridView1.CurrentRow.Index).Value
        obdate.Text = DataGridView1.Item("ob_date", DataGridView1.CurrentRow.Index).Value

        txtdv.Text = DataGridView1.Item("dv_no", DataGridView1.CurrentRow.Index).Value
        dvdate.Text = DataGridView1.Item("dv_date", DataGridView1.CurrentRow.Index).Value





    End Sub


    Public Sub DisplayTotalAmount()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(total_payment) AS total_counted FROM flexible_disbursement_tbl WHERE unique_code = @id AND yearcode = 'year1';"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() AndAlso Not reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                        Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                        tp = totalAmount
                        ' Update the TextBox
                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub clearcheckedbox()
        chkmf.Checked = False
        chkrf.Checked = False
        chklessmf.Checked = False
        chklessrf.Checked = False
        chkothers.Checked = False

    End Sub



    Public Sub displayprojectcost()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM( DISTINCT obtc) AS total_payment " &
                          "FROM flexible_disbursement_tbl " &
                          "WHERE unique_code = @id AND yearcode = @year " &
                          "GROUP BY unique_code, yearcode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@year", "year1") ' Replace with the actual year value

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                        Dim totalAmount As Decimal = Convert.ToDecimal(result)
                        pc = totalAmount
                        txtpcy.Text = totalAmount.ToString("N2")
                        ' Update the TextBox
                    Else
                        ' Handle the case where no data is returned
                        txtpcy.Text = "0.00"
                    End If
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Public Sub balance()
        bal = pc - tp
        txtbal.Text = bal.ToString("N2")
    End Sub




    Private Sub ClearFormData()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ' Clear TextBox
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                ' Reset ComboBox selection
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                ' Uncheck CheckBox
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is ListBox Then
                ' Clear ListBox items
                DirectCast(ctrl, ListBox).Items.Clear()
            ElseIf TypeOf ctrl Is DateTimePicker Then
                ' Set DateTimePicker to today's date
                DirectCast(ctrl, DateTimePicker).Value = Date.Today
                ' Add more conditions based on the types of controls you have

            End If
        Next

        ' Assuming your DataGridView is named DataGridView1
    End Sub
    Private Sub DeleteData()
        Dim y As String = "year1"

        ' Ask for confirmation before deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM flexible_disbursement_tbl WHERE unique_code = @uniquecode AND yearcode = @year AND disbursement_id = @id"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                    cmd.Parameters.AddWithValue("@year", y)
                    cmd.Parameters.AddWithValue("@id", txtid.Text)

                    Try
                        connection.Open()

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No records deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        If connection.State = ConnectionState.Open Then
                            connection.Close()
                        End If
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub UpdateData()
        Dim y As String = "year1"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE flexible_disbursement_tbl SET disbursement_code = @disbursement_code, cheque_num = @cheque_num, date_issued = @date_issued, date_released = @date_released, total_payment = @total_payment, ob_no = @ob_no, ob_date = @ob_date, dv_no = @dv_no, dv_date = @dv_date WHERE disbursement_id = @id"

            Using cmd As New MySqlCommand(query, connection)
                ' Provide parameter values for the update operation
                cmd.Parameters.AddWithValue("@disbursement_code", txttitle.Text)
                cmd.Parameters.AddWithValue("@cheque_num", txtcheque.Text)
                cmd.Parameters.AddWithValue("@date_issued", date_issued.Value)
                cmd.Parameters.AddWithValue("@date_released", date_released.Value)
                cmd.Parameters.AddWithValue("@total_payment", txtpayment.Text)
                cmd.Parameters.AddWithValue("@ob_no", txtob.Text)
                cmd.Parameters.AddWithValue("@ob_date", obdate.Value)
                cmd.Parameters.AddWithValue("@dv_no", txtdv.Text)
                cmd.Parameters.AddWithValue("@dv_date", dvdate.Value)
                cmd.Parameters.AddWithValue("@id", txtid.Text)

                Try
                    connection.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No records updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End Using
        End Using
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        DeleteData()
        LoadData()
        displayprojectcost()
        DisplayTotalAmount()
        balance()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        btnsave.BringToFront()
        txttitle.ReadOnly = False
        txtpayment.ReadOnly = False
        txtcheque.ReadOnly = False
        txtob.ReadOnly = False
        txtdv.ReadOnly = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        UpdateData()
        LoadData()
        displayprojectcost()
        DisplayTotalAmount()
        balance()
        btnedit.BringToFront()
        txttitle.ReadOnly = True
        txtpayment.ReadOnly = True
        txtcheque.ReadOnly = True
        txtob.ReadOnly = True
        txtdv.ReadOnly = True
    End Sub


    Public Sub LoadSummaryBiling()
        Dim y As String = "year1"
        Dim rptDS As ReportDataSource
        Try
            BillingSummaryReport.ReportViewer1.RefreshReport()

            ' Load report file
            With BillingSummaryReport.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\BillingSummaryReport.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' SQL query with WHERE clause
                Dim query As String = "SELECT disbursement_code, cheque_num, total_payment, date_issued, date_released, " &
                                "ob_no, ob_date, dv_no, dv_date FROM flexible_disbursement_tbl WHERE unique_code = @uniquecode AND yearcode = @year"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", ongoing_details.txtuniquecode.Text)
                command.Parameters.AddWithValue("@year", y)

                ' Execute the query and fill data into a DataSet
                Dim ds As New DataSet
                Dim da As New MySqlDataAdapter(command)
                da.Fill(ds, "BillingSummaryReport")

                ' Close the connection
                connection.Close()

                ' Get the number of rows retrieved
                Dim rowCount As Integer = ds.Tables("BillingSummaryReport").Rows.Count

                ' Display the number of rows retrieved
                MsgBox("Number of rows retrieved: " & rowCount, vbInformation)

                ' Create ReportDataSource and bind it to the ReportViewer
                rptDS = New ReportDataSource("DataSet1", ds.Tables("BillingSummaryReport"))
                BillingSummaryReport.ReportViewer1.LocalReport.DataSources.Add(rptDS)
            End Using

            ' Set display mode and zoom level
            BillingSummaryReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            BillingSummaryReport.ReportViewer1.ZoomMode = ZoomMode.Percent
            BillingSummaryReport.ReportViewer1.ZoomPercent = 30


        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub parameters()
        ' Get the values from textboxes
        Dim uniqueCodeValue As String = uniquecodeloading  ' Assuming txtUniqueCode is the name of your textbox for unique code
        Dim org As String = txtorg.Text  ' Assuming txtUniqueCode is the name of your textbox for unique code
        ' Assuming txtSeedReq is the name of your textbox for seed request


        ' Specify the parameters you want to pass to the report
        Dim reportParameters As New List(Of ReportParameter)()
        reportParameters.Add(New ReportParameter("uniquecode", uniqueCodeValue))
        reportParameters.Add(New ReportParameter("org", org))
        reportParameters.Add(New ReportParameter("billingtitle", "Billing Summary of Year 1"))
        reportParameters.Add(New ReportParameter("projectcost", pc))
        reportParameters.Add(New ReportParameter("balance", bal))

        ' Set the path of the RDLC file
        BillingSummaryReport.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\BillingSummaryReport.rdlc"

        ' Set the parameters to the ReportViewer control
        BillingSummaryReport.ReportViewer1.LocalReport.SetParameters(reportParameters)

        ' Refresh the report
        BillingSummaryReport.ReportViewer1.RefreshReport()
    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        LoadSummaryBiling()
        parameters()
        BillingSummaryReport.ShowDialog()
    End Sub


    Private Sub user()
        If personnel = 1 Then
            btndelete.Enabled = True
            btnedit.Enabled = True
            btnsave.Enabled = True




        Else
            btndelete.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = False

        End If
    End Sub

    Private Sub YourFormName_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DataSet.Clear()
    End Sub

End Class