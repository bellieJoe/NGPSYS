Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewActivities

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newactcaddbtn_Click(sender As Object, e As EventArgs) Handles Newactcaddbtn.Click
        connection.Open()

        Try
            If Txtact.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO activities_tbl (activities_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", Txtact.Text)
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

    Private Sub newactexitbtn_Click(sender As Object, e As EventArgs) Handles newactexitbtn.Click
        Me.Close()

    End Sub

    Private Sub NewActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class