Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewZone

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newzoneaddbtn_Click(sender As Object, e As EventArgs) Handles Newzoneaddbtn.Click
        connection.Open()

        Try
            If txtzone.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO zone_tbl (zone_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtzone.Text)
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
        txtzone.Clear()

    End Sub

    Private Sub newzoneexitbtn_Click(sender As Object, e As EventArgs) Handles newzoneexitbtn.Click
        Me.Close()

    End Sub
End Class