Imports MySql.Data.MySqlClient

Public Class Add_maintenanceprotection
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)



    Private Sub Add_maintenanceprotection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        closesys = 0
    End Sub

    Public Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        If (act1.Text = "" Or totalcost.Text = "" Or txtunit.Text = "" Or totaltarget.Text = "" Or accom.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")


        Else



            Try

                connection.Open()

                ' Insert into contract_tbl
                Dim contractQuery As String = "INSERT INTO maintenance_tbl (unique_code, main_code, activities, UWM, total_cost, unit_cost, total_target, accomplishment) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)"
                Using command As New MySqlCommand(contractQuery, connection)
                    ' ... (your parameter setting code)
                    command.Parameters.AddWithValue("@Value1", uniquecode)
                    command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                    command.Parameters.AddWithValue("@Value3", act1.Text)
                    command.Parameters.AddWithValue("@Value4", uwm.Text)
                    command.Parameters.AddWithValue("@Value5", totalcost.Text)
                    command.Parameters.AddWithValue("@Value6", txtunit.Text)
                    command.Parameters.AddWithValue("@Value7", totaltarget.Text)
                    command.Parameters.AddWithValue("@Value8", accom.Text)
                    command.ExecuteNonQuery()
                End Using

                ' Optionally, display a success message
                MessageBox.Show("Data added successfully.")

                date_inspection.Close()
                Me.Close()

                Maintenance_Protection.Show(maindash)



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        closesys = 1
        submit()
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




        End If
    End Sub




End Class