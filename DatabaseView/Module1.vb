Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public ranny As New DataGridViewRow

    Sub opencon()
        con.ConnectionString = "server=localhost;username=root;password=;database=ngp"
        con.Open()
    End Sub

    Public Class dbconnect
        Dim connect As New MySqlConnection("server = 'localhost';uid='root';pwd='';database='ngp'")

        Public Function open() As MySqlConnection
            Try
                connect.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return connect
        End Function

        Public Function close() As MySqlConnection
            Try
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return connect
        End Function


    End Class

End Module
