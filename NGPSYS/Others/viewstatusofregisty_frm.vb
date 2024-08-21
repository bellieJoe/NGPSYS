Imports MySql.Data.MySqlClient

Public Class viewstatusofregisty_frm

    Private DataSet As New DataSet()
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Private Sub viewstatusofregisty_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = uniquecodeloading.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT unique_code, registry_id, amount_cip, amount_under FROM status_registry WHERE unique_code = @uniquecode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

            connection.Open()
            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Define DataGridView columns
                DataGridView1.ColumnCount = 4
                DataGridView1.Columns(0).Name = "registry_id"
                DataGridView1.Columns(1).Name = "unique_code"
                DataGridView1.Columns(2).Name = "amount_cip"
                DataGridView1.Columns(3).Name = "amount_under"

                ' Set column headers

                DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                DataGridView1.Columns("amount_cip").HeaderText = "Amount still in CIP"
                DataGridView1.Columns("amount_under").HeaderText = "Amount Underdevelopment"

                ' Set column widths

                DataGridView1.Columns("unique_code").Width = 150
                DataGridView1.Columns("amount_cip").Width = 150
                DataGridView1.Columns("amount_under").Width = 150
                DataGridView1.Columns("registry_id").Visible = False



                ' Populate the DataGridView
                While reader.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    row.Cells(0).Value = reader("registry_id").ToString()
                    row.Cells(1).Value = reader("unique_code").ToString()
                    row.Cells(2).Value = Decimal.Parse(reader("amount_cip").ToString()).ToString("N")
                    row.Cells(3).Value = Decimal.Parse(reader("amount_under").ToString()).ToString("N")

                    DataGridView1.Rows.Add(row)
                End While

                If DataGridView1.Rows.Count = 0 Then
                    MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using

        ' Set header style after loading data
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        Next
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = DataGridView1.Item("registry_id", DataGridView1.CurrentRow.Index).Value
        txtcip.Text = DataGridView1.Item("amount_cip", DataGridView1.CurrentRow.Index).Value
        txtunder.Text = DataGridView1.Item("amount_under", DataGridView1.CurrentRow.Index).Value
    End Sub


    Private Sub update()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtcip.Text = "" Or txtunder.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE status_registry SET amount_cip = @cip, amount_under = @under WHERE registry_id = @id"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@id", txtid.Text)
                    command.Parameters.AddWithValue("@cip", txtcip.Text)
                    command.Parameters.AddWithValue("@under", txtunder.Text)
                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcip.Clear()
                txtunder.Clear()

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

    Private Sub delete()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If txtid.Text = "" Then
            MsgBox("Please select a record to delete!", MsgBoxStyle.Exclamation, "Warning")
        Else
            ' Display a confirmation dialog with a danger icon
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, proceed with the deletion operation
            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    ' Delete record from plantation_estab_tbl
                    Dim deleteQuery As String = "DELETE FROM status_registry WHERE registry_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtid.Text)

                        command.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data successfully deleted.")
                    txtid.Clear()
                    txtcip.Clear()
                    txtunder.Clear()


                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.ToString())
                Finally
                    ' Ensure the connection is closed, even in the case of an exception
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update()
        LoadData()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        delete()
        LoadData()
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        cleardata()
        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub cleardata()
        txtcip.Clear()
        txtunder.Clear()
        txtid.Clear()
    End Sub



End Class