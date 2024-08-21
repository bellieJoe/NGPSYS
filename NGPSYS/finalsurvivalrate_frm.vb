Imports MySql.Data.MySqlClient

Public Class finalsurvivalrate_frm
    Private Sub finalsurvivalrate_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btnsub1_Click(sender As Object, e As EventArgs) Handles btnsub1.Click
        connection.Open()
        Try
            If txtsurvival.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO survival_rate_year3 (unique_code, quarter_code, survival_rate, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", DBNull.Value)
                command.Parameters.AddWithValue("@Value3", txtsurvival.Text)
                command.Parameters.AddWithValue("@Value4", DBNull.Value)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")

                ongoing_details.Close()
                With ongoing_details
                    .TopLevel = False
                    maindash.Panel5.Controls.Add(ongoing_details)
                    .BringToFront()
                    .Show()
                End With


                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsub2_Click(sender As Object, e As EventArgs) Handles btnsub2.Click
        connection.Open()
        Try
            If txtsurvival.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO survival_rate_year3 (unique_code, quarter_code, survival_rate, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", year3_3rdquarter.quartercode.ToString)
                command.Parameters.AddWithValue("@Value3", txtsurvival.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()
                year3_3rdquarter.Close()
                year3_3rdquarter.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsub3_Click(sender As Object, e As EventArgs) Handles btnsub3.Click
        connection.Open()
        Try
            If txtsurvival.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO survival_rate_year3 (unique_code, quarter_code, survival_rate, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", year3_4thquarter.quartercode.ToString)
                command.Parameters.AddWithValue("@Value3", txtsurvival.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()
                year3_4thquarter.Close()
                year3_4thquarter.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnyear3_Click(sender As Object, e As EventArgs) Handles btnyear3.Click
        connection.Open()
        Try
            If txtsurvival.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO survival_rate_year3 (unique_code, quarter_code, survival_rate, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", year3_1st2nd_quarter.quartercode.ToString)
                command.Parameters.AddWithValue("@Value3", txtsurvival.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()
                year3_1st2nd_quarter.Close()
                year3_1st2nd_quarter.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class