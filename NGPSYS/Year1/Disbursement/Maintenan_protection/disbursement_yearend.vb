Imports MySql.Data.MySqlClient

Public Class disbursement_yearend

    Dim totalpayment As Double
    Dim retentionfee As Double
    Dim totalcost As Double
    Dim totalpe As Double

    Private Sub disbursement_yearend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sitecode()
        displayey()
        displaydata()
        obdata()


    End Sub

    Private Sub sitecode()

        txtuniquecode.Text = ongoing_details.txtuniquecode.Text
        txtuniquecode.ReadOnly = True

        txtorg.Text = ongoing_details.txtorg.Text
        txtorg.ReadOnly = True

    End Sub

    Private Sub displayey()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(total_cost) AS total_cost FROM maintenance_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_cost")) Then
                            projectcost.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_cost"))
                            projectcost.Text = totalAmount.ToString("N") ' Update the TextBox

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

    Private Sub txtbill_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub projectcost_TextChanged(sender As Object, e As EventArgs) Handles projectcost.TextChanged

        Dim pc As Double

        Dim rf As Double
        Dim tp As Double

        Dim mfresult As Double
        Dim rfresult As Double

        If Double.TryParse(projectcost.Text, pc) Then
            totalcost = pc
            ' Display the result in the txtResult TextBox.
            txtbill.Text = pc.ToString("N2")
            ' Format the result with 2 decimal places.
        Else
            ' If the input is not a valid number, clear the result TextBox.
            txtbill.Clear()
        End If

        If Double.TryParse(projectcost.Text, rf) Then
            Dim result As Double = rf * 0.1
            rfresult = result
            ' Display the result in the txtResult TextBox.
            retentionfee = rfresult
            txtretention.Text = result.ToString("N2")
        Else
            txtretention.Clear()

        End If

        If Double.TryParse(projectcost.Text, tp) Then
            Dim result As Double = (tp - (mfresult + rfresult))
            ' Display the result in the txtResult TextBox.
            totalpayment = result
            txtpayment.Text = result.ToString("N2")
        Else
            txtpayment.Clear()

        End If
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If txtcheque.Text = "" Or txtpayment.Text = "" Then

                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "INSERT INTO disbursement_yearend_tbl (unique_code, cheque_num,  date_issued, date_released, payment, total_cost, retention_fee, ob_no, ob_date, dv_no, dv_date)
                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11)"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Value1", txtuniquecode.Text)
                        command.Parameters.AddWithValue("@Value2", txtcheque.Text)
                        command.Parameters.AddWithValue("@Value3", date_issued.Value.Date)
                        command.Parameters.AddWithValue("@Value4", date_released.Value.Date)
                        command.Parameters.AddWithValue("@Value5", totalpayment.ToString)
                        command.Parameters.AddWithValue("@Value6", totalcost.ToString)
                        command.Parameters.AddWithValue("@Value7", retentionfee.ToString)
                        command.Parameters.AddWithValue("@Value8", txtob.Text)
                        command.Parameters.AddWithValue("@Value9", obdate.Value.Date)
                        command.Parameters.AddWithValue("@Value10", txtdv.Text)
                        command.Parameters.AddWithValue("@Value11", dvdate.Value.Date)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Data inserted successfully.")
                    ReadOn += 1
                    closesystemMF = 1


                    TICdashboard.Close()
                    With TICdashboard
                        .TopLevel = False
                        maindash.Panel5.Controls.Add(TICdashboard)
                        .BringToFront()
                        .Show()
                    End With

                    Maintenance_Protection.Show()

                    Me.Close()

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub displaydata()

        Dim totalpayment1 As Double
        Dim retentionfee1 As Double
        Dim totalcost1 As Double

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT unique_code, cheque_num,  date_issued, date_released, payment, total_cost, retention_fee, ob_no, ob_date, dv_no, dv_date FROM disbursement_yearend_tbl
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

                    totalpayment1 = reader("payment").ToString()

                    totalcost1 = reader("total_cost").ToString()

                    txtob.Text = reader("ob_no").ToString
                    Dim obdatevalue As Date = Convert.ToDateTime(reader("ob_date").ToString)
                    obdate.Value = obdatevalue

                    txtdv.Text = reader("dv_no").ToString
                    Dim dvdatevalue As Date = Convert.ToDateTime(reader("dv_date").ToString)
                    dvdate.Value = dvdatevalue

                    retentionfee1 = reader("retention_fee").ToString

                    txtbill.Text = totalcost1.ToString("N2")
                    txtpayment.Text = totalpayment1.ToString("N2")
                    txtretention.Text = retentionfee1.ToString("N2")
                    TextBox1.Text = totalpayment1.ToString("N2")


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
        Btnsub.Visible = False
        txtpayment.ReadOnly = True
        txtbill.ReadOnly = True
        txtretention.ReadOnly = True
        txtob.ReadOnly = True
        obdate.Enabled = False
        txtdv.ReadOnly = True
        dvdate.Enabled = False

    End Sub

    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If closesystemMF = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ' Cancel the form closing event if the user chooses not to close
                e.Cancel = True
            Else
            End If
        Else

        End If

    End Sub

    Public Sub displaymsgadd()

    End Sub

    Public Sub obdata()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectDataQuery As String = "SELECT ob_no, ob_date FROM disbursement_3rd_mf WHERE  unique_code = @uniqueCode;"

        ' Create a MySqlConnection and MySqlCommand objects within a Using block for proper resource management
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectDataQuery, connection)
                ' Add a parameter for the selected commodity
                command.Parameters.AddWithValue("@uniqueCode", uniquecodeloading)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then
                            ' Check if the reader has rows and read the "remarks" column
                            txtob.Text = reader.GetString("ob_no")
                            Dim dateob As Date = Convert.ToDateTime(reader("ob_date"))
                            obdate.Text = dateob

                        Else

                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
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

        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "4th Quarter Payment Report " + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("Project Unique Code: " + vbTab + vbTab & txtuniquecode.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Name of Implementer: " + vbTab + vbTab & txtorg.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Project Cost : " + vbTab + vbTab + vbTab & txtbill.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Less 10% Retention Fee : " + vbTab + vbTab & txtretention.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Amount to be Paid : " + vbTab + vbTab & txtpayment.Text + vbTab + vbTab + vbNewLine)


        txtseedproreport.AppendText("" + vbNewLine)
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

        txtseedproreport.AppendText("" + vbNewLine)


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

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class