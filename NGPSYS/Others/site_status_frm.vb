Imports MySql.Data.MySqlClient

Public Class site_status_frm
    Private Sub site_status_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
            If dateupdated.Text = "" Or txtstatus.Text = "" Or txtAe.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO site_status_tbl (unique_code, date_updated, status, adopting_entity) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", dateupdated.Value)
                command.Parameters.AddWithValue("@Value3", txtstatus.Text)
                command.Parameters.AddWithValue("@Value4", txtAe.Text)
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