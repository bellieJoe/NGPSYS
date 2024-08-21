Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Reflection.Emit

Public Class add_plantationEstablishment

    Dim itcom As Integer

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub add_plantationEstablishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        closesys = 0

        PopulateComboBox()
        Dim itemCount As Integer = cmbcom.Items.Count
        itcom = itemCount
    End Sub


    Public Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (totalcost.Text = "" Or txtunit.Text = "" Or totaltarget.Text = "" Or accom.Text = "" Or txtplanted.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else


            Try

                connection.Open()

                ' Insert into contract_tbl
                Dim contractQuery As String = "INSERT INTO plantation_estab_tbl (unique_code, seed_code, activities, UWM, total_contract, unit_cost, total_target, accomplishment, seed_planted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9)"
                Using command As New MySqlCommand(contractQuery, connection)
                    ' ... (your parameter setting code)
                    command.Parameters.AddWithValue("@Value1", uniquecode)
                    command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                    command.Parameters.AddWithValue("@Value3", cmbcom.SelectedItem.ToString)
                    command.Parameters.AddWithValue("@Value4", uwm.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value5", totalcost.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value6", txtunit.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value7", totaltarget.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value8", accom.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value9", txtplanted.Text.Replace(",", ""))

                    command.ExecuteNonQuery()
                End Using

                ' Optionally, display a success message
                MessageBox.Show("Data successfully Added.")
                RemoveSelectedItem()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

            updateplanted()

        End If
    End Sub

    Public Sub update()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (totalcost.Text = "" Or txtunit.Text = "" Or totaltarget.Text = "" Or accom.Text = "" Or txtplanted.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE plantation_estab_tbl SET activities = @Value3, UWM = @Value4, total_contract = @Value5, unit_cost = @Value6, total_target = @Value7, accomplishment = @Value8, seed_planted = @Value9 WHERE unique_code = @Value1 AND seed_code = @Value2"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", uniquecode)
                    command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                    command.Parameters.AddWithValue("@Value3", cmbcom.SelectedItem.ToString)
                    command.Parameters.AddWithValue("@Value4", uwm.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value5", totalcost.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value6", txtunit.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value7", totaltarget.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value8", accom.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@Value9", txtplanted.Text.Replace(",", ""))

                    command.ExecuteNonQuery()
                End Using

                ' Optionally, display a success message
                MessageBox.Show("Data successfully Updated.")

                RemoveSelectedItem()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

            updateplanted()
        End If
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        closesys = 1
        submit()

    End Sub

    Sub updateplanted()
        Try
            connection.Open()

            Dim query As String = "UPDATE data_tbl SET seed_plant = @newValue WHERE data_id = @primaryKeyValue"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@newValue", txtplanted.Text) ' Set the new value you want to update
                cmd.Parameters.AddWithValue("@primaryKeyValue", seedlingproduceprimamry) ' Set the primary key value
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub clear()
        act1.Clear()
        totalcost.Clear()
        txtunit.Clear()
        totaltarget.Clear()
        accom.Clear()
    End Sub



    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Add your custom code here
        ' For example, you can prompt the user to confirm the closing action


        If closesys = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ' Cancel the form closing event if the user chooses not to close
                e.Cancel = True
            Else


                date_inspection.Close()


            End If

        Else

            date_inspection.Close()

        End If



    End Sub


    Private Sub RemoveSelectedItem()
        ' Check if an item is selected in the ComboBox
        If cmbcom.SelectedIndex <> -1 Then
            ' Remove the selected item from the ComboBox
            cmbcom.Items.RemoveAt(cmbcom.SelectedIndex)
            clear()
            itcom -= 1

            If itcom <= 0 Then

                Dim sp As New Seedling_planted()
                sp.Show(maindash)
                cmbcom.Enabled = False

                Me.Close()
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