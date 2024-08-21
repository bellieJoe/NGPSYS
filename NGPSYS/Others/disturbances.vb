Imports MySql.Data.MySqlClient

Public Class disturbances
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        submit()
    End Sub

    Public Sub submit()
        connection.Open()
        Try
            If date_occurence.Text = "" Or txtareadamage.Text = "" Or txttypedamage.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO disturbances_tbl (unique_code, date_occurence, area_damaged, type_damage, status) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", date_occurence.Value)
                command.Parameters.AddWithValue("@Value3", txtareadamage.Text)
                command.Parameters.AddWithValue("@Value4", txttypedamage.Text)
                command.Parameters.AddWithValue("@Value5", txtstatus.Text)
                command.ExecuteNonQuery()
                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class