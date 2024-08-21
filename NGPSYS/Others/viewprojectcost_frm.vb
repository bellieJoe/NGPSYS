Imports MySql.Data.MySqlClient

Public Class viewprojectcost_frm

    Private DataSet As New DataSet()
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim countPoly As Integer
    Private Sub viewprojectcost_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = uniquecodeloading.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString

        If Integer.TryParse(ongoing_details.txtcountpoly.Text, countPoly) AndAlso countPoly <= 1 Then
            LoadData()
        Else
            loaddatapoly()
        End If


    End Sub

    Private Sub LoadData()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT unique_code, cost_id, project_cost, year1, year2, year3, gross_amount FROM projectcost_tbl WHERE unique_code = @uniquecode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

            connection.Open()
            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Define DataGridView columns
                DataGridView1.ColumnCount = 7
                DataGridView1.Columns(0).Name = "cost_id"
                DataGridView1.Columns(1).Name = "unique_code"
                DataGridView1.Columns(2).Name = "project_cost"
                DataGridView1.Columns(3).Name = "year1"
                DataGridView1.Columns(4).Name = "year2"
                DataGridView1.Columns(5).Name = "year3"
                DataGridView1.Columns(6).Name = "gross_amount"

                ' Set column headers
                DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                DataGridView1.Columns("project_cost").HeaderText = "Project Cost (3 Years)"
                DataGridView1.Columns("year1").HeaderText = "Cost Year 1"
                DataGridView1.Columns("year2").HeaderText = "Cost Year 2"
                DataGridView1.Columns("year3").HeaderText = "Cost Year 3"
                DataGridView1.Columns("gross_amount").HeaderText = "Actual Gross Amount"

                ' Set column widths
                DataGridView1.Columns("unique_code").Width = 150
                DataGridView1.Columns("project_cost").Width = 150
                DataGridView1.Columns("year1").Width = 150
                DataGridView1.Columns("year2").Width = 150
                DataGridView1.Columns("year3").Width = 150
                DataGridView1.Columns("gross_amount").Width = 150

                ' Make cost_id column hidden
                DataGridView1.Columns("cost_id").Visible = False

                ' Populate the DataGridView
                While reader.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    row.Cells(0).Value = If(reader.IsDBNull(reader.GetOrdinal("cost_id")), String.Empty, reader("cost_id").ToString())
                    row.Cells(1).Value = If(reader.IsDBNull(reader.GetOrdinal("unique_code")), String.Empty, reader("unique_code").ToString())

                    If Not reader.IsDBNull(reader.GetOrdinal("project_cost")) Then
                        row.Cells(2).Value = Decimal.Parse(reader("project_cost").ToString()).ToString("N")
                    Else
                        row.Cells(2).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year1")) Then
                        row.Cells(3).Value = Decimal.Parse(reader("year1").ToString()).ToString("N")
                    Else
                        row.Cells(3).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year2")) Then
                        row.Cells(4).Value = Decimal.Parse(reader("year2").ToString()).ToString("N")
                    Else
                        row.Cells(4).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year3")) Then
                        row.Cells(5).Value = Decimal.Parse(reader("year3").ToString()).ToString("N")
                    Else
                        row.Cells(5).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("gross_amount")) Then
                        row.Cells(6).Value = Decimal.Parse(reader("gross_amount").ToString()).ToString("N")
                    Else
                        row.Cells(6).Value = ""
                    End If


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

    Private Sub loaddatapoly()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT unique_code, cost_id, project_cost, year1, year2, year3, gross_amount FROM projectcost_tbl WHERE polygon_code = @polycode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@polycode", ongoing_details.polygonCode)

            connection.Open()
            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Define DataGridView columns
                DataGridView1.ColumnCount = 7
                DataGridView1.Columns(0).Name = "cost_id"
                DataGridView1.Columns(1).Name = "unique_code"
                DataGridView1.Columns(2).Name = "project_cost"
                DataGridView1.Columns(3).Name = "year1"
                DataGridView1.Columns(4).Name = "year2"
                DataGridView1.Columns(5).Name = "year3"
                DataGridView1.Columns(6).Name = "gross_amount"

                ' Set column headers
                DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                DataGridView1.Columns("project_cost").HeaderText = "Project Cost (3 Years)"
                DataGridView1.Columns("year1").HeaderText = "Cost Year 1"
                DataGridView1.Columns("year2").HeaderText = "Cost Year 2"
                DataGridView1.Columns("year3").HeaderText = "Cost Year 3"
                DataGridView1.Columns("gross_amount").HeaderText = "Actual Gross Amount"

                ' Set column widths
                DataGridView1.Columns("unique_code").Width = 150
                DataGridView1.Columns("project_cost").Width = 150
                DataGridView1.Columns("year1").Width = 150
                DataGridView1.Columns("year2").Width = 150
                DataGridView1.Columns("year3").Width = 150
                DataGridView1.Columns("gross_amount").Width = 150

                ' Make cost_id column hidden
                DataGridView1.Columns("cost_id").Visible = False

                ' Populate the DataGridView
                While reader.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    row.Cells(0).Value = If(reader.IsDBNull(reader.GetOrdinal("cost_id")), String.Empty, reader("cost_id").ToString())
                    row.Cells(1).Value = If(reader.IsDBNull(reader.GetOrdinal("unique_code")), String.Empty, reader("unique_code").ToString())

                    If Not reader.IsDBNull(reader.GetOrdinal("project_cost")) Then
                        row.Cells(2).Value = Decimal.Parse(reader("project_cost").ToString()).ToString("N")
                    Else
                        row.Cells(2).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year1")) Then
                        row.Cells(3).Value = Decimal.Parse(reader("year1").ToString()).ToString("N")
                    Else
                        row.Cells(3).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year2")) Then
                        row.Cells(4).Value = Decimal.Parse(reader("year2").ToString()).ToString("N")
                    Else
                        row.Cells(4).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("year3")) Then
                        row.Cells(5).Value = Decimal.Parse(reader("year3").ToString()).ToString("N")
                    Else
                        row.Cells(5).Value = ""
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("gross_amount")) Then
                        row.Cells(6).Value = Decimal.Parse(reader("gross_amount").ToString()).ToString("N")
                    Else
                        row.Cells(6).Value = ""
                    End If


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

        txtid.Text = If(DataGridView1.Item("cost_id", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("cost_id", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")

        If DataGridView1.Item("project_cost", DataGridView1.CurrentRow.Index).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(DataGridView1.Item("project_cost", DataGridView1.CurrentRow.Index).Value.ToString()) Then
            txttotalyear.Text = Decimal.Parse(DataGridView1.Item("project_cost", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        Else
            txttotalyear.Text = "For Updating" ' Default value
        End If

        ' Check and set txtyear1
        If DataGridView1.Item("year1", DataGridView1.CurrentRow.Index).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(DataGridView1.Item("year1", DataGridView1.CurrentRow.Index).Value.ToString()) Then
            txtyear1.Text = Decimal.Parse(DataGridView1.Item("year1", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        Else
            txtyear1.Text = "For Updating" ' Default value
        End If

        ' Check and set txtyear2
        If DataGridView1.Item("year2", DataGridView1.CurrentRow.Index).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(DataGridView1.Item("year2", DataGridView1.CurrentRow.Index).Value.ToString()) Then
            txtyear2.Text = Decimal.Parse(DataGridView1.Item("year2", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        Else
            txtyear2.Text = "For Updating" ' Default value
        End If

        ' Check and set txtyear3
        If DataGridView1.Item("year3", DataGridView1.CurrentRow.Index).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(DataGridView1.Item("year3", DataGridView1.CurrentRow.Index).Value.ToString()) Then
            txtyear3.Text = Decimal.Parse(DataGridView1.Item("year3", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        Else
            txtyear3.Text = "For Updating" ' Default value
        End If

        If DataGridView1.Item("gross_amount", DataGridView1.CurrentRow.Index).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(DataGridView1.Item("gross_amount", DataGridView1.CurrentRow.Index).Value.ToString()) Then
            txtactual.Text = Decimal.Parse(DataGridView1.Item("gross_amount", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        Else
            txtactual.Text = "For Updating" ' or any default value you prefer
        End If

    End Sub

    Private Sub update()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txttotalyear.Text = "" Or txtyear1.Text = "" Or txtyear2.Text = "" Or txtyear3.Text = "" Or txtactual.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE projectcost_tbl SET project_cost = @pc, year1 = @y1, year2 = @y2, year3 = @y3, gross_amount = @ga WHERE cost_id = @id"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@id", txtid.Text)
                    command.Parameters.AddWithValue("@pc", txttotalyear.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@y1", txtyear1.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@y2", txtyear2.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@y3", txtyear3.Text.Replace(",", ""))
                    command.Parameters.AddWithValue("@ga", txtactual.Text.Replace(",", ""))

                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttotalyear.Clear()
                txtyear1.Clear()
                txtyear2.Clear()
                txtyear3.Clear()
                txtactual.Clear()

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
                    Dim deleteQuery As String = "DELETE FROM projectcost_tbl WHERE cost_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtid.Text)

                        command.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data successfully deleted.")
                    txtid.Clear()
                    txttotalyear.Clear()
                    txtyear1.Clear()
                    txtyear2.Clear()
                    txtyear3.Clear()
                    txtactual.Clear()


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
        txtactual.Clear()
        txtyear1.Clear()
        txtyear2.Clear()
        txtyear3.Clear()
        txttotalyear.Clear()
    End Sub



End Class