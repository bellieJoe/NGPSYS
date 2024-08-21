Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Disbursement_halfquarter

    Dim totalpayment As Double
    Private Sub Disbursement_halfquarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sitecode()
        displaydata()



    End Sub

    Private Sub sitecode()

        txtuniquecode.Text = ongoing_details.txtuniquecode.Text
        txtuniquecode.ReadOnly = True
        txtorg.Text = ongoing_details.txtorg.Text
        txtorg.ReadOnly = True

    End Sub

    Private Sub txtbill2_TextChanged(sender As Object, e As EventArgs) Handles txtbill2.TextChanged
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



    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If txtcheque.Text = "" Or txtpayment.Text = "" Then

                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "INSERT INTO disbursement_3rd_mf (unique_code,cheque_num, payment, date_issued, date_released, total_cost, ob_no, ob_date, dv_no, dv_date)
                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Value1", txtuniquecode.Text)
                        command.Parameters.AddWithValue("@Value2", txtcheque.Text)
                        command.Parameters.AddWithValue("@Value3", totalpayment.ToString)
                        command.Parameters.AddWithValue("@Value4", date_issued.Value.Date)
                        command.Parameters.AddWithValue("@Value5", date_released.Value.Date)
                        command.Parameters.AddWithValue("@Value6", txtbill.Text)
                        command.Parameters.AddWithValue("@Value7", txtob.Text)
                        command.Parameters.AddWithValue("@Value8", obdate.Value.Date)
                        command.Parameters.AddWithValue("@Value9", txtdv.Text)
                        command.Parameters.AddWithValue("@Value10", dvdate.Value.Date)
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data inserted successfully.")
                    closesystemMF = 1

                    TICdashboard.Close()
                    With TICdashboard
                        .TopLevel = False
                        maindash.Panel5.Controls.Add(TICdashboard)
                        .BringToFront()
                        .Show()
                    End With

                    Seedling_planted.Show()

                    Me.Close()

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub displaydata()
        Dim bill As Integer
        Dim payment As Integer
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT unique_code, cheque_num, payment, date_issued, date_released, total_cost, ob_no, ob_date, dv_no, dv_date FROM disbursement_3rd_mf
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

    Private Sub readonlydisplay()
        txtob.ReadOnly = True
        obdate.Enabled = False
        txtdv.ReadOnly = True
        dvdate.Enabled = False
        txtuniquecode.ReadOnly = True
        txtcheque.ReadOnly = True
        txtbill.ReadOnly = True
        date_issued.Enabled = False
        date_released.Enabled = False
        txtpayment.ReadOnly = True
        Btnsub.Visible = False

    End Sub



    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If closesystemMF = 0 Then
            displaymsgadd()
        Else

        End If

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

        txtseedproreport.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "3rd Quarter Payment Report (15% MF)" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("" + vbNewLine)
        txtseedproreport.AppendText("Project Unique Code: " + vbTab + vbTab & txtuniquecode.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Name of Implementer: " + vbTab + vbTab & txtorg.Text + vbTab + vbTab + vbNewLine)
        txtseedproreport.AppendText("Total Project Cost : " + vbTab + vbTab & txtbill.Text + vbTab + vbTab + vbNewLine)

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

    Private Sub txtbill_TextChanged(sender As Object, e As EventArgs) Handles txtbill.TextChanged
        txtbill2.Text = txtbill.Text.ToString()
    End Sub
End Class