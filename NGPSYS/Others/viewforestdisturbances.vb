Imports MySql.Data.MySqlClient

Public Class viewforestdisturbances

    Private DataSet As New DataSet()
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Private Sub viewforestdisturbances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = uniquecodeloading.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString


        LoadData()

    End Sub

    Private Sub LoadData()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT unique_code, disturbances_id, date_occurence, area_damaged, type_damage, status FROM disturbances_tbl WHERE unique_code = @uniquecode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

            connection.Open()
            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Define DataGridView columns
                DataGridView1.ColumnCount = 6
                DataGridView1.Columns(0).Name = "disturbances_id"
                DataGridView1.Columns(1).Name = "unique_code"
                DataGridView1.Columns(2).Name = "date_occurence"
                DataGridView1.Columns(3).Name = "area_damaged"
                DataGridView1.Columns(4).Name = "type_damage"
                DataGridView1.Columns(5).Name = "status"

                ' Set column headers

                DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                DataGridView1.Columns("date_occurence").HeaderText = "Date of Occurrence"
                DataGridView1.Columns("area_damaged").HeaderText = "Area Damaged"
                DataGridView1.Columns("type_damage").HeaderText = "Type of Damage"
                DataGridView1.Columns("status").HeaderText = "Status of Derecognition"

                ' Set column widths

                DataGridView1.Columns("unique_code").Width = 150
                DataGridView1.Columns("date_occurence").Width = 150
                DataGridView1.Columns("area_damaged").Width = 100
                DataGridView1.Columns("type_damage").Width = 100
                DataGridView1.Columns("status").Width = 130

                DataGridView1.Columns("disturbances_id").Visible = False
                ' Populate the DataGridView
                While reader.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    row.Cells(0).Value = reader("disturbances_id").ToString()
                    row.Cells(1).Value = reader("unique_code").ToString()
                    row.Cells(2).Value = Convert.ToDateTime(reader("date_occurence")).ToString("MMMM dd, yyyy")
                    row.Cells(3).Value = reader("area_damaged").ToString()
                    row.Cells(4).Value = reader("type_damage").ToString()
                    row.Cells(5).Value = reader("status").ToString()

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
        txtid.Text = DataGridView1.Item("disturbances_id", DataGridView1.CurrentRow.Index).Value
        date_occurence.Text = DataGridView1.Item("date_occurence", DataGridView1.CurrentRow.Index).Value
        txtareadamage.Text = Decimal.Parse(DataGridView1.Item("area_damaged", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        txttypedamage.Text = DataGridView1.Item("type_damage", DataGridView1.CurrentRow.Index).Value
        txtstatus.Text = DataGridView1.Item("status", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub update()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtareadamage.Text = "" Or txttypedamage.Text = "" Or txtstatus.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE disturbances_tbl SET date_occurence = @date_occurence, area_damaged = @area_damaged, type_damage = @type_damage, status = @status WHERE disturbances_id = @id"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@id", txtid.Text)
                    command.Parameters.AddWithValue("@date_occurence", date_occurence.Value)
                    command.Parameters.AddWithValue("@area_damaged", txtareadamage.Text)
                    command.Parameters.AddWithValue("@type_damage", txttypedamage.Text)
                    command.Parameters.AddWithValue("@status", txtstatus.Text)
                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstatus.Clear()
                txttypedamage.Clear()
                txtareadamage.Clear()

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
                    Dim deleteQuery As String = "DELETE FROM disturbances_tbl WHERE disturbances_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtid.Text)

                        command.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data successfully deleted.")
                    txtid.Clear()
                    txtstatus.Clear()
                    txttypedamage.Clear()
                    txtareadamage.Clear()


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

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        txtid.Clear()
        txtareadamage.Clear()
        txtstatus.Clear()
        txttypedamage.Clear()

    End Sub
End Class