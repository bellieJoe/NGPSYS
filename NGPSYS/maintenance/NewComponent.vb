Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewComponent

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newcomaddbtn_Click(sender As Object, e As EventArgs) Handles Newcomaddbtn.Click

        connection.Open()

        Try
            If txtcom.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO component_tbl (component_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtcom.Text)
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
        txtcom.Clear()

    End Sub

    Private Sub newcomexitbtn_Click(sender As Object, e As EventArgs) Handles newcomexitbtn.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NewComponent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class