Imports MySql.Data.MySqlClient

Public Class remarks

    Public Sub submit()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Insert into contract_tbl
            Dim contractQuery As String = "INSERT INTO remarks (unique_code,code_remark, remarks) VALUES (@Value1, @Value2, @Value3)"
            Using command As New MySqlCommand(contractQuery, connection)
                ' ... (your parameter setting code)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", lblcode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.ExecuteNonQuery()
            End Using
            ' Optionally, display a success message
            MessageBox.Show("Data inserted successfully.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        Finally
            ' Ensure the connection is closed, even in the case of an exception
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sysremark = 1
        submit()

        If changeremark = 0 Then
            Seedling_planted.Close()
            Dim sp As New Seedling_planted()
            sp.Show()
        Else
            Maintenance_Protection.Close()
            Dim mp As New Maintenance_Protection()
            mp.Show()
        End If

        txtremarks.Clear()
        Me.Close()

    End Sub

    Private Sub remarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub





End Class