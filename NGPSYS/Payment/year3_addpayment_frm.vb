Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class year3_addpayment_frm

    Dim pcresult As Double
    Dim mfresult As Double
    Dim rfresult As Double

    Dim lessmfresult As Double
    Dim lessrfresult As Double

    Dim totallessresult As Double
    Dim finalpc As Double

    Dim other As Double

    Private Sub year3_addpayment_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = ongoing_details.txtuniquecode.Text
        txtuniquecode.ReadOnly = True

        txtorg.Text = ongoing_details.txtorg.Text
        txtorg.ReadOnly = True

        Dim randomCode As String = GenerateRandomUniqueCode(10)
        disbursement_code.Text = randomCode
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

    Private Sub chkmf_CheckedChanged(sender As Object, e As EventArgs) Handles chkmf.CheckedChanged
        If chkmf.Checked = True Then
            chkrf.Checked = False
        Else


        End If


    End Sub

    Private Sub chkrf_CheckedChanged(sender As Object, e As EventArgs) Handles chkrf.CheckedChanged
        If chkrf.Checked = True Then
            chkmf.Checked = False
        Else

        End If
    End Sub

    Private Sub chkothers_CheckedChanged(sender As Object, e As EventArgs) Handles chkothers.CheckedChanged
        If chkothers.Checked = True Then
            txtothers.Enabled = True
        Else
            chkothers.Checked = False
            txtothers.Enabled = False
            txtothers.Clear()
        End If
    End Sub

    Public Sub calculateless()

        If chkothers.Checked Then

            If chkmf.Checked AndAlso chklessrf.Checked Then
                totallessresult = mfresult + lessrfresult + other
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf Not String.IsNullOrWhiteSpace(txtothers.Text) Then
                totallessresult = other
                finalpc = totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chkrf.Checked AndAlso chklessmf.Checked Then
                totallessresult = rfresult + lessmfresult + other
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf Not String.IsNullOrWhiteSpace(txtamount.Text) AndAlso chkrf.Checked Then
                totallessresult = rfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf Not String.IsNullOrWhiteSpace(txtamount.Text) AndAlso chklessrf.Checked Then
                totallessresult = lessrfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chkmf.Checked Then
                finalpc = (pcresult - (mfresult + other))
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chkrf.Checked Then
                finalpc = pcresult - (rfresult + other)
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chklessmf.Checked Then
                finalpc = pcresult - (lessmfresult + other)
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chklessrf.Checked Then
                finalpc = pcresult - (lessrfresult + other)
                txtpayment.Text = finalpc.ToString("N2")
            Else


            End If

        Else

            If chkmf.Checked AndAlso chklessrf.Checked Then
                totallessresult = mfresult + lessrfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")


            ElseIf chkrf.Checked AndAlso chklessmf.Checked Then
                totallessresult = rfresult + lessmfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf Not String.IsNullOrWhiteSpace(txtamount.Text) AndAlso chkrf.Checked Then
                totallessresult = rfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf Not String.IsNullOrWhiteSpace(txtamount.Text) AndAlso chklessrf.Checked Then
                totallessresult = lessrfresult
                finalpc = pcresult - totallessresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chkmf.Checked Then
                finalpc = mfresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chkrf.Checked Then
                finalpc = rfresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chklessmf.Checked Then
                finalpc = lessmfresult
                txtpayment.Text = finalpc.ToString("N2")

            ElseIf chklessrf.Checked Then
                finalpc = lessrfresult
                txtpayment.Text = finalpc.ToString("N2")
            Else


            End If

        End If

    End Sub

    Private Sub txtpc_TextChanged(sender As Object, e As EventArgs) Handles txtpc.TextChanged
        Dim mf As Double
        Dim rf As Double
        Dim pc As Double

        If Double.TryParse(txtpc.Text, mf) Then
            ' Calculate 15% of the input value.
            Dim result As Double = mf * 0.15
            mfresult = result
            ' Display the result in the txtResult TextBox.
            txtmf.Text = result.ToString("N2")

        Else
            txtmf.Clear()
        End If

        If Double.TryParse(txtpc.Text, rf) Then
            Dim result As Double = rf * 0.1
            rfresult = result
            ' Display the result in the txtResult TextBox.
            txtrf.Text = result.ToString("N2")
        Else
            txtrf.Clear()

        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        calculateless()

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        Dim pc As Double
        Dim lessmf As Double
        Dim lessrf As Double

        If Double.TryParse(txtamount.Text, pc) Then
            pcresult = pc
            ' Display the result in the txtResult TextBox.
            'txtpc.Text = pc.ToString("N2")
            ' Format the result with 2 decimal places.
        Else
            ' If the input is not a valid number, clear the result TextBox.

        End If

        If Double.TryParse(txtamount.Text, lessmf) Then
            ' Calculate 15% of the input value.
            Dim result As Double = lessmf * 0.15
            lessmfresult = result
            ' Display the result in the txtResult TextBox.
            txtlessmf.Text = result.ToString("N2")

        Else
            txtlessmf.Clear()
        End If

        If Double.TryParse(txtamount.Text, lessrf) Then
            Dim result As Double = lessrf * 0.1
            lessrfresult = result
            ' Display the result in the txtResult TextBox.
            txtlessrf.Text = result.ToString("N2")
        Else
            txtlessrf.Clear()

        End If
    End Sub

    Private Sub txtothers_TextChanged(sender As Object, e As EventArgs) Handles txtothers.TextChanged
        Dim add As Double

        If Double.TryParse(txtothers.Text, add) Then

            other = add
            ' Display the result in the txtResult TextBox.
        Else
            txtothers.Clear()

        End If
    End Sub

    Public Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If String.IsNullOrWhiteSpace(txtcheque.Text) OrElse String.IsNullOrWhiteSpace(txtpayment.Text) OrElse String.IsNullOrWhiteSpace(disbursement_code.Text) Then
                MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
            Else
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Use descriptive parameter names
                    Dim query As String = "INSERT INTO flexible_disbursement_tbl (unique_code, disbursement_code,  cheque_num, payment, date_issued, date_released, ob_mf, ob_rf,  db_mf, db_rf, others, total_payment, ob_no, ob_date, dv_no, dv_date, obtc, dvtc, yearcode ) " &
                                          "VALUES (@UniqueCode, @DisbursementCode, @ChequeNum, @Payment, @DateIssued, @DateReleased, @ObMF, @ObRF, @DbMF, @DbRF, @Others, @TotalPayment, @ObNo, @ObDate, @DvNo, @DvDate, @Obtc, @Dvtc, @yearcode)"

                    Using command As New MySqlCommand(query, connection)
                        ' Use more descriptive parameter names
                        command.Parameters.AddWithValue("@UniqueCode", txtuniquecode.Text)
                        command.Parameters.AddWithValue("@DisbursementCode", disbursement_code.Text)
                        command.Parameters.AddWithValue("@ChequeNum", txtcheque.Text)
                        command.Parameters.AddWithValue("@Payment", pcresult)
                        command.Parameters.AddWithValue("@DateIssued", date_issued.Value.Date)
                        command.Parameters.AddWithValue("@DateReleased", date_released.Value.Date)
                        command.Parameters.AddWithValue("@yearcode", "year3")

                        If chkmf.Checked = True Then

                        Else
                            mfresult = 0
                        End If

                        command.Parameters.AddWithValue("@ObMF", mfresult)

                        If chkrf.Checked = True Then

                        Else
                            rfresult = 0
                        End If

                        command.Parameters.AddWithValue("@ObRF", rfresult)

                        If chklessmf.Checked = True Then
                        Else
                            lessmfresult = 0
                        End If
                        command.Parameters.AddWithValue("@DbMF", lessmfresult)


                        If chklessrf.Checked = True Then
                        Else
                            lessrfresult = 0
                        End If

                        command.Parameters.AddWithValue("@DbRF", lessrfresult)

                        If chkothers.Checked = True Then
                        Else
                            other = 0
                        End If

                        command.Parameters.AddWithValue("@Others", other)

                        command.Parameters.AddWithValue("@TotalPayment", finalpc) ' You might want to adjust this based on your actual logic
                        command.Parameters.AddWithValue("@ObNo", txtob.Text)
                        command.Parameters.AddWithValue("@ObDate", obdate.Value.Date)
                        command.Parameters.AddWithValue("@DvNo", txtdv.Text)
                        command.Parameters.AddWithValue("@DvDate", dvdate.Value.Date)

                        command.Parameters.AddWithValue("@Obtc", txtpc.Text)

                        If Not String.IsNullOrWhiteSpace(txtamount.Text) Then

                        Else
                            txtamount.Text = 0

                        End If

                        command.Parameters.AddWithValue("@Dvtc", txtamount.Text)

                        ' Execute the query within a transaction
                        Using transaction As MySqlTransaction = connection.BeginTransaction()
                            Try
                                command.Transaction = transaction
                                command.ExecuteNonQuery()

                                ' If all operations succeed, commit the transaction
                                transaction.Commit()

                                MessageBox.Show("Data inserted successfully.")
                            Catch ex As Exception
                                ' Rollback the transaction if an error occurs
                                transaction.Rollback()
                                MessageBox.Show("Error: " & ex.Message)
                            End Try
                        End Using
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click

        submit()
        Me.Hide()
        Me.Close()

        year3_viewpayment_frm.ShowDialog()

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

            End If
        Next
    End Sub

    Private Sub clearcheckedbox()
        chkmf.Checked = False
        chkrf.Checked = False
        chklessmf.Checked = False
        chklessrf.Checked = False
        chkothers.Checked = False

    End Sub

    Private Sub disbursement_code_TextChanged(sender As Object, e As EventArgs) Handles disbursement_code.TextChanged
        Dim title As String = disbursement_code.Text.ToString
        lbltitle.Text = title
    End Sub


End Class