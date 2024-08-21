Imports MySql.Data.MySqlClient

Public Class update_sitecode

    Dim msgupdate As Integer = 0

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub update_sitecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()

    End Sub

    Private Sub loadData()
        Dim query As String = "SELECT unique_code FROM contract_tbl
                                Where unique_code = @selectedvalue"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@selectedvalue", uniquecodeloading)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()

                    txtsitecode.Text = reader("unique_code").ToString

                End While
                reader.Close()

            End Using
        End Using
    End Sub

    Private Sub updatePSC()
        Dim updateQuery As String = "UPDATE contract_tbl SET unique_code = @new_value WHERE unique_code = @selectedvalue"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@new_value", txtsitecode.Text) ' Replace with the new value you want to set.
                command.Parameters.AddWithValue("@selectedvalue", uniquecodeloading)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        ' The update was successful.
                        MessageBox.Show("Project site code updated successfully.")
                    Else
                        ' The unique_code was not found in the table.
                        MessageBox.Show("No record with the specified unique_code was found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub Newcomaddbtn_Click(sender As Object, e As EventArgs) Handles Newcomaddbtn.Click
        loadingthis += 1
        Dim newValue As String = txtsitecode.Text

        UpdateTableColumn("commodity_unitcost_tbl", "unique_code", newValue)
        UpdateTableColumn("contract_tbl", "unique_code", newValue)
        UpdateTableColumn("data_tbl", "unique_code", newValue)
        UpdateTableColumn("disbursement_tbl", "unique_code", newValue)
        UpdateTableColumn("disbursement_3rd_mf", "unique_code", newValue)
        UpdateTableColumn("disbursement_76_tbl", "unique_code", newValue)
        UpdateTableColumn("disbursement_tbl", "unique_code", newValue)
        UpdateTableColumn("disbursement_yearend_tbl", "unique_code", newValue)
        UpdateTableColumn("inspector_details_tbl", "unique_code", newValue)
        UpdateTableColumn("maintenance_tbl", "unique_code", newValue)
        UpdateTableColumn("multispecies", "unique_code", newValue)
        UpdateTableColumn("plantation_estab_tbl", "unique_code", newValue)
        UpdateTableColumn("remarks", "unique_code", newValue)
        UpdateTableColumn("survival_rate_year1", "unique_code", newValue)
        If msgupdate > 0 Then
            MessageBox.Show("Porject sitecode updated successfully.")
        End If
        dashboard.Show()
        Me.Close()

    End Sub

    Private Sub UpdateTableColumn(tableName As String, columnName As String, newValue As String)
        Dim updateQuery As String = $"UPDATE {tableName} SET {columnName} = @new_value WHERE {columnName} = @selectedvalue"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@new_value", newValue) ' Replace with the new value you want to set.
                command.Parameters.AddWithValue("@selectedvalue", uniquecodeloading)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        ' The update was successful.
                        msgupdate += 1
                    Else
                        ' The unique_code was not found in the table.

                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class