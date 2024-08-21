﻿Imports MySql.Data.MySqlClient

Public Class year2_remark
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn1.Click
        connection.Open()

        Try
            If txtremarks.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO year2_remarks (unique_code, quarter_code, remark, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", _1stand2nd_quarter.quartercode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()
                _1stand2nd_quarter.Close()
                _1stand2nd_quarter.Show()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        connection.Open()

        Try
            If txtremarks.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO year2_remarks (unique_code, quarter_code, remark, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", _3rd_quarter.quartercode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()
                _3rd_quarter.Close()
                _3rd_quarter.Show()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Try
            If txtremarks.Text = "" Then
                MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
            Else
                ' Check if the connection is already open, if yes, close it
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If

                ' Open the connection
                connection.Open()

                Dim query As String = "INSERT INTO year2_remarks (unique_code, quarter_code, remark, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", _4th_quarter.quartercode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Display a success message box with an information icon
                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                _4th_quarter.Close()
                _4th_quarter.Show()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


End Class