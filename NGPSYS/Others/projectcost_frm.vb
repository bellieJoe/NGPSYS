Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class projectcost_frm

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

        Try

            connection.Open()
            Dim query As String = "INSERT INTO projectcost_tbl (unique_code, project_cost, year1, year2, year3, gross_amount) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", uniquecodeloading)
            command.Parameters.AddWithValue("@Value2", txtprojectcost.Text.Replace(",", ""))
            command.Parameters.AddWithValue("@Value3", txtyear1.Text.Replace(",", ""))
            command.Parameters.AddWithValue("@Value4", txtyear2.Text.Replace(",", ""))
            command.Parameters.AddWithValue("@Value5", txtyear3.Text.Replace(",", ""))
            command.Parameters.AddWithValue("@Value6", txtactual.Text.Replace(",", ""))
            command.ExecuteNonQuery()
                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class