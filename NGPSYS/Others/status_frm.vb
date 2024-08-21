Imports MySql.Data.MySqlClient

Public Class status_frm


    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        submit()
        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Public Sub submit()
        connection.Open()
        Try
            If txtcip.Text = "" Or txtunder.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO status_registry (unique_code, amount_cip, amount_under) VALUES (@Value1, @Value2, @Value3)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", txtcip.Text.Replace(",", ""))
                command.Parameters.AddWithValue("@Value3", txtunder.Text.Replace(",", ""))
                command.ExecuteNonQuery()
                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()

            End If

            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class