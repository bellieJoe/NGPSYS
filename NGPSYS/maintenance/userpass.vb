Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class userpass

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub userpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomUsername As String = GenerateRandomUsername(8)
        Dim randomPassword As String = GenerateRandomPassword(12)

        txtuser.Text = randomUsername
        txtpass.Text = randomPassword

    End Sub


    Public Shared Function GenerateRandomUsername(length As Integer) As String
        Dim usernameChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder()
        Dim rand As New Random()

        For i As Integer = 0 To length - 1
            Dim index As Integer = rand.Next(0, usernameChars.Length)
            sb.Append(usernameChars(index))
        Next

        Return sb.ToString()
    End Function

    ' Function to generate a random password
    Public Shared Function GenerateRandomPassword(length As Integer) As String
        Dim passwordChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+"
        Dim sb As New StringBuilder()
        Dim rand As New Random()

        For i As Integer = 0 To length - 1
            Dim index As Integer = rand.Next(0, passwordChars.Length)
            sb.Append(passwordChars(index))
        Next
        Return sb.ToString()
    End Function

    Sub add()



        Try

            connection.Open()


            Dim query As String = "INSERT INTO account (account_type, username, email_address, password, firstname, middlename, lastname, address, phone_num, gender) 
                                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", lbluser.Text)
            command.Parameters.AddWithValue("@Value2", txtuser.Text)
            command.Parameters.AddWithValue("@Value3", DBNull.Value)
            command.Parameters.AddWithValue("@Value4", txtpass.Text)
            command.Parameters.AddWithValue("@Value5", DBNull.Value)
            command.Parameters.AddWithValue("@Value6", DBNull.Value)
            command.Parameters.AddWithValue("@Value7", DBNull.Value)
            command.Parameters.AddWithValue("@Value8", DBNull.Value)
            command.Parameters.AddWithValue("@Value9", DBNull.Value)
            command.Parameters.AddWithValue("@Value10", DBNull.Value)
            command.ExecuteNonQuery()

            ' Close the connection
            connection.Close()

            ' Optionally, display a success message
            MessageBox.Show("Data inserted successfully.")



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        add()

    End Sub



End Class