Imports MySql.Data.MySqlClient

Public Class date_vreport
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        submit()
    End Sub

    Public Sub submit()
        connection.Open()
        Try
            If daterequest.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO date_validation_report (unique_code,date_validation) VALUES (@Value1, @Value2)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", daterequest.Value)
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