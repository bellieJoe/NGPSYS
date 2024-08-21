Imports System.Text
Imports Microsoft.Win32.SafeHandles
Imports MySql.Data.MySqlClient

Public Class polygonsites

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Dim choices As Integer


    Private Sub polygonsites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cleardata()
        LoadData()
        txtrandom.Text = GenerateRandomCode()
    End Sub

    Private Sub LoadData()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query to check for polygon_code
            Dim query As String = "SELECT polygon_code FROM projectcost_tbl WHERE unique_code = @uniquecode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

            Try
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(reader.GetOrdinal("polygon_code")) Then
                            ' polygon_code has a value
                            choices = 1
                        Else
                            ' polygon_code is null
                            choices = 0
                        End If
                    Else
                        choices = 0
                    End If
                End Using
            Catch ex As Exception
                ' Handle exceptions here (e.g., log the error or show an error message)
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure that the connection is closed, even if an exception occurs
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub



    Public Sub submit()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtpolycode.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE projectcost_tbl SET polygon_code = @poly WHERE unique_code = @code"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@code", uniquecodeloading)
                    command.Parameters.AddWithValue("@poly", txtpolycode.Text)

                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub update()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtpolycode.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE projectcost_tbl SET polygon_code = @poly WHERE unique_code = @code"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@code", uniquecodeloading)
                    command.Parameters.AddWithValue("@poly", txtpolycode.Text)

                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub cleardata()
        txtpolycode.Clear()
        choices = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If choices = 1 Then
            submit()
            cleardata()
            ongoing_details.Close()
            With ongoing_details
                .TopLevel = False
                maindash.Panel5.Controls.Add(ongoing_details)
                .BringToFront()
                .Show()
            End With
            Me.Close()
        Else
            update()
            cleardata()
            ongoing_details.Close()
            With ongoing_details
                .TopLevel = False
                maindash.Panel5.Controls.Add(ongoing_details)
                .BringToFront()
                .Show()
            End With
            Me.Close()
        End If
    End Sub


    Private Function GenerateRandomCode() As String
        Dim prefix As String = "sites-"
        Dim length As Integer = 5 ' Length of the random part of the code
        Dim characters As String = "0123456789"
        Dim random As New Random()
        Dim result As New StringBuilder(prefix)

        For i As Integer = 1 To length
            Dim index As Integer = random.Next(characters.Length)
            result.Append(characters(index))
        Next

        Return result.ToString()

    End Function

End Class

