Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewFunding

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newfundaddbtn_Click(sender As Object, e As EventArgs) Handles Newfundaddbtn.Click
        connection.Open()

        Try
            If txtfund.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO funding_tbl (funding_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtfund.Text)
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

    Private Sub newfundexitbtn_Click(sender As Object, e As EventArgs) Handles newfundexitbtn.Click
        Me.Close()

    End Sub

    Private Sub NewFunding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class