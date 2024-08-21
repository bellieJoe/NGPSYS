Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NewTenure

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Newtenaddbtn_Click(sender As Object, e As EventArgs) Handles Newtenaddbtn.Click
        connection.Open()

        Try
            If txttenure.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO tenure_tbl (tenure_name) VALUES (@Value1)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txttenure.Text)
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

    Private Sub newtenexitbtn_Click(sender As Object, e As EventArgs) Handles newtenexitbtn.Click
        Me.Close()

    End Sub

    Private Sub NewTenure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class