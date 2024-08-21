Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewCommodity

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newcommcaddbtn_Click(sender As Object, e As EventArgs) Handles Newcommcaddbtn.Click

        connection.Open()
        Try
            If txtcomm.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO commodity_tbl (commodity_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtcomm.Text)
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

        txtcomm.Clear()

    End Sub

    Private Sub newcommexitbtn_Click(sender As Object, e As EventArgs) Handles newcommexitbtn.Click
        Me.Close()

    End Sub

    Private Sub NewCommodity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class