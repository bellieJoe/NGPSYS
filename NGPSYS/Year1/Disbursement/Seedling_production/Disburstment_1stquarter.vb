
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Disburstment_1stquarter

    Dim totalpayment As Double
    Private Sub Disburstment_1stquarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        projectcostbill()

        displaybill()
        displaydata()
        sitecode()
        loaddatalistview
        If String.IsNullOrEmpty(txtcheque.Text) Then
            populatefund()
        Else
        End If
    End Sub


    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If txtcheque.Text = "" Or txtpayment.Text = "" Or cmbfund.SelectedIndex = -1 Then

                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "INSERT INTO disbursement_tbl (unique_code,cheque_num, date_issued, date_released, fund, payment, total_cost, ob_no, ob_date, dv_no, dv_date)
                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11)"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Value1", txtuniquecode.Text)
                        command.Parameters.AddWithValue("@Value2", txtcheque.Text)
                        command.Parameters.AddWithValue("@Value3", date_issued.Value.Date)
                        command.Parameters.AddWithValue("@Value4", date_released.Value.Date)
                        command.Parameters.AddWithValue("@Value5", cmbfund.Text)
                        command.Parameters.AddWithValue("@Value6", totalpayment.ToString)
                        command.Parameters.AddWithValue("@Value7", txtbill2.Text)
                        command.Parameters.AddWithValue("@Value8", txtob.Text)
                        command.Parameters.AddWithValue("@Value9", obdate.Value.Date)
                        command.Parameters.AddWithValue("@Value10", txtdv.Text)
                        command.Parameters.AddWithValue("@Value11", dvdate.Value.Date)
                        command.ExecuteNonQuery()
                    End Using

                    Dim query1 As String = "UPDATE contract_tbl SET fund = @Value1 WHERE unique_code = @Value"
                    Using command1 As New MySqlCommand(query1, connection)
                        command1.Parameters.AddWithValue("@Value1", cmbfund.Text)
                        command1.Parameters.AddWithValue("@Value", txtuniquecode.Text)
                        command1.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Data inserted successfully.")
                    closesystemMF = 1
                    Me.Close()


                    With Seedling_pro
                        .TopLevel = False
                        maindash.Panel5.Controls.Add(Seedling_pro)

                        ' Calculate the position to center the form
                        Dim x As Integer = (maindash.Panel5.Width - .Width) / 2
                        Dim y As Integer = (maindash.Panel5.Height - .Height) / 2
                        ' Set the form's location to center it
                        .Location = New Point(x, y)
                        .BringToFront()
                        .Show()
                    End With


                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub



    Private Sub sitecode()

        txtuniquecode.Text = ongoing_details.txtuniquecode.Text
        txtuniquecode.ReadOnly = True
        txtorg.Text = ongoing_details.txtorg.Text
        txtorg.ReadOnly = True

    End Sub



    Private Sub populatefund()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT funding_name FROM funding_tbl"

        ' Create a connection
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Create a command
            Using command As New MySqlCommand(query, connection)
                ' Execute the query
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Clear existing items from ComboBox
                    cmbfund.Items.Clear()

                    ' Loop through the reader and add items to ComboBox
                    While reader.Read()

                        Dim name As String = reader.GetString("funding_name")

                        cmbfund.Items.Add(name)
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub displaydata()
        Dim bill As Integer
        Dim payment As Integer
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT unique_code, cheque_num, payment, date_issued, date_released, fund, total_cost, ob_no, ob_date, dv_no, dv_date FROM disbursement_tbl
                                Where unique_code = @selectedvalue"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@selectedvalue", uniquecodeloading)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()

                    Dim dateissued As Date = Convert.ToDateTime(reader("date_issued").ToString)
                    date_issued.Value = dateissued

                    Dim daterel As Date = Convert.ToDateTime(reader("date_released").ToString)
                    date_released.Value = daterel

                    txtcheque.Text = reader("cheque_num").ToString()

                    Dim funding As String = reader("fund").ToString()
                    cmbfund.Items.Add(funding)
                    cmbfund.SelectedItem = funding

                    payment = reader("payment").ToString
                    txtpayment.Text = payment.ToString("N2")


                    bill = reader("total_cost").ToString
                    txtbill.Text = bill.ToString("N2")

                    txtob.Text = reader("ob_no").ToString
                    Dim obdatevalue As Date = Convert.ToDateTime(reader("ob_date").ToString)
                    obdate.Value = obdatevalue

                    txtdv.Text = reader("dv_no").ToString
                    Dim dvdatevalue As Date = Convert.ToDateTime(reader("dv_date").ToString)
                    dvdate.Value = dvdatevalue


                    readonlydisplay()


                End While
                reader.Close()

            End Using
        End Using
    End Sub

    Private Sub displaybill()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT 1st_payment FROM year1_disbursement
                                Where unique_code = @selectedvalue"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@selectedvalue", ongoing_details.txtuniquecode.Text)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()

                    If Not reader.IsDBNull(reader.GetOrdinal("1st_payment")) Then
                        Dim paymentValue As Decimal = reader.GetDecimal(reader.GetOrdinal("1st_payment"))
                        txtbill.Text = paymentValue.ToString("N")
                    Else
                        ' Handle the case where the value is NULL or DBNull.Value
                        txtbill.Text = "N/A" ' or any other appropriate value or message
                    End If

                End While
                reader.Close()

            End Using
        End Using
    End Sub



    Private Sub readonlydisplay()
        txtuniquecode.ReadOnly = True
        txtcheque.ReadOnly = True
        date_issued.Enabled = False
        date_released.Enabled = False
        txtpayment.ReadOnly = True
        cmbfund.Enabled = False
        Btnsub.Visible = False
        txtbill.ReadOnly = True
        txtob.ReadOnly = True
        obdate.Enabled = False
        txtdv.ReadOnly = True
        dvdate.Enabled = False
    End Sub

    Private Sub txtbill_TextChanged(sender As Object, e As EventArgs) Handles txtbill.TextChanged
        Dim inputValue As Double
        If Double.TryParse(txtbill.Text, inputValue) Then
            ' Calculate 15% of the input value.
            Dim result As Double = inputValue * 0.15

            ' Display the result in the txtResult TextBox.
            txtpayment.Text = result.ToString("N2")
            ' Format the result with 2 decimal places.
            totalpayment = result
        Else
            ' If the input is not a valid number, clear the result TextBox.
            txtpayment.Clear()
        End If
    End Sub





    Private Sub projectcostbill()
        Dim uniqueCode As String = uniquecodeloading  ' Replace with the actual source of unique_code
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT SUM(total_cost_seeds) " &
                                "FROM commodity_unitcost_tbl " &
                                "WHERE unique_code = @uniqueCode;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                ' Add a parameter for unique_code
                command.Parameters.AddWithValue("@uniqueCode", uniqueCode)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Dim projectcost As Integer = Convert.ToInt32(result)
                        txtbill2.Text = projectcost.ToString
                        txtbill.Text = projectcost.ToString("N2")
                    Else
                        txtbill.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If closesystemMF = 0 Then
            displaymsgadd()
        Else

        End If

        TICdashboard.Close()
        With TICdashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(TICdashboard)
            .BringToFront()
            .Show()
        End With

    End Sub



    Public Sub loaddatalistview()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT commodity_name, seedlingcount, unit_cost, total_cost_seeds " &
                                 "FROM commodity_unitcost_tbl " &
                                 "WHERE unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Clear previous items and columns
                ListView1.Items.Clear()
                ListView1.Columns.Clear()

                ' Set the view and add columns
                ListView1.View = System.Windows.Forms.View.Details
                ListView1.Columns.Add("Commodity Name", 150)
                ListView1.Columns.Add("No. of Seedling", 150)
                ListView1.Columns.Add("Unit Cost", 150)
                ListView1.Columns.Add("Total Cost", 150)

                ' Populate the ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader.GetString(0)) ' Commodity
                    item.SubItems.Add(reader.GetDecimal(1).ToString("N")) ' Area planted
                    item.SubItems.Add(reader.GetDecimal(2).ToString("N")) ' No. of Seedling Planted
                    item.SubItems.Add(reader.GetDecimal(3).ToString("N")) ' No. Of Seedling Survive

                    ListView1.Items.Add(item)
                End While

                ' Calculate the overall percentage

            End Using
        End Using
    End Sub

    Public Sub displaymsgadd()
        If MessageBox.Show("Are you sure you want to close? Your data won't be saved.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            If DialogResult = DialogResult.Yes Then
                ClearFormControls(Disburstment_1stquarter.ActiveForm)
            End If
        Else
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtseedproreport.Text = ""
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "1st Quarter Payment Report (15% MF)" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("Project Unique Code: " + vbTab + vbTab & txtuniquecode.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Name of Implementer: " + vbTab + vbTab & txtorg.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Funding : " + vbTab + vbTab + vbTab & cmbfund.SelectedItem.ToString + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Total Project Cost : " + vbTab + vbTab & txtbill.Text + vbTab + vbTab + vbNewLine)

        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "DETAILS" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)


        txtseedproreport.AppendText("Commodity" + vbTab + vbTab + vbTab)
        txtseedproreport.AppendText("No. of Seedling" + vbTab + vbTab + vbTab)
        txtseedproreport.AppendText("Unit Cost" + vbTab + vbTab + vbTab)
        txtseedproreport.AppendText("Total Cost" + vbTab + vbTab + vbTab)


        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        For Each item As ListViewItem In ListView1.Items
            Dim comm As String = item.SubItems(0).Text.PadRight(10) ' Adjust the width (e.g., 40) as needed
            Dim numseed As String = item.SubItems(1).Text.PadRight(5) ' Adjust the width (e.g., 20) as needed
            Dim unitcost As String = item.SubItems(2).Text.PadRight(5) ' Adjust the width (e.g., 20) as needed
            Dim totalcost As String = item.SubItems(3).Text.PadRight(5)
            txtseedproreport.AppendText(comm + vbTab + vbTab + vbTab + numseed + vbTab + vbTab + vbTab + vbTab + unitcost + vbTab + vbTab + vbTab + vbTab + totalcost + vbNewLine)
        Next


        txtseedproreport.AppendText("" + vbCrLf)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)


        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "CHEQUE DETAILS" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)


        txtseedproreport.AppendText("Cheque Number : " + vbTab + vbTab & txtcheque.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Date Issued : " + vbTab + vbTab + vbTab & date_issued.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Date Released : " + vbTab + vbTab + vbTab & date_released.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Total Payment : " + vbTab + vbTab + vbTab & txtpayment.Text + vbTab + vbTab + vbNewLine)



        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "OBLIGATION DETAILS" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)

        txtseedproreport.AppendText("Obligation No. : " + vbTab + vbTab & txtob.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Date : " + vbTab + vbTab + vbTab & obdate.Text + vbTab + vbTab + vbNewLine)



        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "DISBURSEMENT DETAILS" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("Disbursement No. : " + vbTab & txtdv.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Date : " + vbTab + vbTab + vbTab & dvdate.Text + vbTab + vbTab + vbNewLine)

        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtseedproreport.Text, Font, Brushes.Black, 70, 50)
    End Sub

End Class