Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class multspecieseditform

    Private Sub multspecieseditform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function GetDataBySpecificColumn(id As Integer) As List(Of String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT multispecies_name, multiseed_req FROM multispecies WHERE unique_code = @id"
        Dim retrievedData As New List(Of String)()
        Dim retrievedseed As New List(Of String)()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        retrievedData.Add(reader.GetString("multispecies_name"))
                        retrievedData.Add(reader.GetString("multiseed_req"))
                    End While
                End Using
            End Using
        End Using

        Return retrievedData
        Return retrievedseed



    End Function



    Private Sub spec1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles spec1.SelectedIndexChanged

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()

    End Sub
End Class