Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewSpecies

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newspecaddbtn_Click(sender As Object, e As EventArgs) Handles Newspecaddbtn.Click

        connection.Open()

        Try
            If txtspecies.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO species_tbl (species_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtspecies.Text)
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
        txtspecies.Clear()

    End Sub

    Private Sub newspecexitbtn_Click(sender As Object, e As EventArgs) Handles newspecexitbtn.Click
        Me.Close()

    End Sub

    Private Sub NewSpecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class