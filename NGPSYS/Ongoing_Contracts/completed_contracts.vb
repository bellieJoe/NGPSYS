Imports System.Text.Json
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class completed_contracts

    Dim loadyear As String
    Dim loadmuni As String
    Dim loadarea As String
    Dim loadorg As String

    Private Sub completed_contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentYear As Integer = DateTime.Now.Year
        For year As Integer = 2011 To currentYear
            cmbyear.Items.Add(year.ToString())
        Next

        LoadData()
        datafilter()
        paneltwo()
        cmborgselect()

        Me.ControlBox = False
    End Sub

    Private DataSet As New DataSet()
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"


    Private Sub LoadData(Optional search As String = "")

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M-%Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M-%Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                  "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay, t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                  "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                  "FROM contract_tbl AS t1 " &
                  "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                  "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                  "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                  "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "

            If Not String.IsNullOrEmpty(search) Then
                query &= " WHERE t1.unique_code = @search" ' Fixed the concatenation with WHERE
            End If

            query &= " ORDER BY t5.unique_code ASC" ' Moved ORDER BY after the JOIN conditions

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    cmd.Parameters.AddWithValue("@search", search)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")

                    DataGridView1.DataSource = DataSet.Tables("YourTableName")

                    DataGridView1.Columns("unique_code").HeaderText = "Project Site Code"
                    DataGridView1.Columns("date_execution").HeaderText = "Date of Execution"
                    DataGridView1.Columns("date_expiry").HeaderText = "Date of Expiration"
                    DataGridView1.Columns("area_planted").HeaderText = "Area"
                    DataGridView1.Columns("Org_name").HeaderText = "Organization"
                    DataGridView1.Columns("Org_type").HeaderText = "Organization Type"

                    DataGridView1.Columns("unique_code").Width = 170

                    ' Format date columns to display year and month as words
                    DataGridView1.Columns("date_execution").DefaultCellStyle.Format = "MMMM-yyyy"
                    DataGridView1.Columns("date_expiry").DefaultCellStyle.Format = "MMMM-yyyy"

                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using

    End Sub





    Private Sub datafilter()

        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        Next

        For i As Integer = 3 To 19
            DataGridView1.Columns(i).Visible = False
        Next i

        For d As Integer = 21 To 23
            DataGridView1.Columns(d).Visible = False
        Next d


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Newtxtuniquecode_TextChanged(sender As Object, e As EventArgs)

        Dim uniquecode As String = Newtxtuniquecode.Text & " " & newtxtcode.Text & " " & txtnewuni.Text & " " & txtnewcode.Text
        code.Text = uniquecode

    End Sub

    Private Sub newyear_ValueChanged(sender As Object, e As EventArgs) Handles newyear.ValueChanged

    End Sub

    Private Sub Populateyear(selectedYear As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)


            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M %Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M %Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay, t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "


            If Not String.IsNullOrEmpty(selectedYear) Then
                query &= "WHERE t1.year = @selectedyear AND t5.unique_code IS NOT NULL;"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(selectedYear) Then
                    cmd.Parameters.AddWithValue("@selectedyear", selectedYear)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")
                    DataGridView1.DataSource = DataSet.Tables("YourTableName")
                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using

    End Sub

    Private Sub PopulatebyMuniyear(selectedmuni As String, selectedyear As String, selectedarea As String, selectedorg As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M %Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M %Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay,  t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "

            If Not String.IsNullOrEmpty(selectedmuni) Then
                query &= "WHERE t1.year = @selectedyear AND t1.municipality = @selectedmuni AND t2.area_planted = @selectedarea AND t3.org_name = @selectedorg ;"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(selectedmuni) And Not String.IsNullOrEmpty(selectedyear) Then
                    cmd.Parameters.AddWithValue("@selectedmuni", selectedmuni)
                    cmd.Parameters.AddWithValue("@selectedyear", selectedyear)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")
                    DataGridView1.DataSource = DataSet.Tables("YourTableName")
                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using


    End Sub


    Private Sub chkyear_CheckedChanged(sender As Object, e As EventArgs) Handles chkyear.CheckedChanged


        If chkyear.Checked = True Then

            If cmbyear.SelectedIndex >= 0 Then
                Dim selectedYear As String = cmbyear.SelectedItem.ToString()
                loadyear = selectedYear
            Else
                MessageBox.Show("Please choose first the Year", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkyear.Checked = False
            End If

        Else

        End If

    End Sub




    Private Sub txtnewuni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnewuni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press event
        End If
    End Sub

    Private Sub Newtxtuniquecode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Newtxtuniquecode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press event
        End If
    End Sub

    Private Sub newtxtcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles newtxtcode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press event
        End If
    End Sub

    Private Sub txtnewcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnewcode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press event
        End If
    End Sub



    Private Sub PopulatebyMuni(selectedmuni As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)


            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M %Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M %Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay,  t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "



            If Not String.IsNullOrEmpty(selectedmuni) Then
                query &= "WHERE t1.municipality = @selectedmuni AND t5.unique_code IS NOT NULL;"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(selectedmuni) Then
                    cmd.Parameters.AddWithValue("@selectedmuni", selectedmuni)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")
                    DataGridView1.DataSource = DataSet.Tables("YourTableName")
                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using


    End Sub


    Private Sub chkmuni_CheckedChanged(sender As Object, e As EventArgs) Handles chkmuni.CheckedChanged
        If chkmuni.Checked = True Then

            If cmbmuni.SelectedIndex >= 0 Then
                Dim selectedmuni As String = cmbmuni.SelectedItem.ToString()
                loadmuni = selectedmuni
            Else
                MessageBox.Show("Please choose first the Municipality", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkmuni.Checked = False

            End If

        Else

        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ongoing_details.selectedContract = "COMPLETED"
        ongoing_details.selectedContract = "COMPLETED"
        ongoing_details.lblprimarykey.Text = DataGridView1.Item("data_id", DataGridView1.CurrentRow.Index).Value
        seedlingproduceprimamry = DataGridView1.Item("data_id", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtuniquecode.Text = DataGridView1.Item("unique_code", DataGridView1.CurrentRow.Index).Value
        uniquecode = DataGridView1.Item("unique_code", DataGridView1.CurrentRow.Index).Value
        uniquecodeloading = DataGridView1.Item("unique_code", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtorg.Text = DataGridView1.Item("Org_name", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txttenure.Text = DataGridView1.Item("Org_tenure", DataGridView1.CurrentRow.Index).Value


        Dim firstName As String = DataGridView1.Item("Firstname", DataGridView1.CurrentRow.Index).Value.ToString()
        Dim middleName As String = DataGridView1.Item("Middlename", DataGridView1.CurrentRow.Index).Value.ToString()
        Dim lastName As String = DataGridView1.Item("Lastname", DataGridView1.CurrentRow.Index).Value.ToString()
        Dim contact As String = $"{firstName} {middleName} {lastName}"
        ongoing_details.newcontact.Text = contact

        ongoing_details.txttypeorg.Text = DataGridView1.Item("Org_type", DataGridView1.CurrentRow.Index).Value



        ongoing_details.txtconregion.Text = DataGridView1.Item("region", DataGridView1.CurrentRow.Index).Value
        ongoing_details.condistricttxt.Text = DataGridView1.Item("district", DataGridView1.CurrentRow.Index).Value

        ongoing_details.txtarea.Text = Decimal.Parse(DataGridView1.Item("area_planted", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        ongoing_details.txtseedreq.Text = Decimal.Parse(DataGridView1.Item("seed_req", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        ongoing_details.txtspe.Text = DataGridView1.Item("seed_reqdisplay", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtseedpro.Text = Decimal.Parse(DataGridView1.Item("seed_pro", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")
        ongoing_details.txtseedplanted.Text = Decimal.Parse(DataGridView1.Item("seed_plant", DataGridView1.CurrentRow.Index).Value.ToString()).ToString("N")

        ongoing_details.datecontractexe.Text = DataGridView1.Item("date_execution", DataGridView1.CurrentRow.Index).Value
        ongoing_details.datecontractexp.Text = DataGridView1.Item("date_expiry", DataGridView1.CurrentRow.Index).Value

        ongoing_details.txtyear.Text = DataGridView1.Item("year", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtbarangay.Text = DataGridView1.Item("baranggay", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtmunicipality.Text = DataGridView1.Item("municipality", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtprovince.Text = DataGridView1.Item("province", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtspecies.Text = DataGridView1.Item("species", DataGridView1.CurrentRow.Index).Value

        ongoing_details.txtcomponent.Text = DataGridView1.Item("component", DataGridView1.CurrentRow.Index).Value
        ongoing_details.txtcommodity.Text = DataGridView1.Item("commodity", DataGridView1.CurrentRow.Index).Value


        If ongoing_details.dateofactual.Value.Date = DateTime.Today Then
            ongoing_details.dateofactual.Visible = False
            ongoing_details.txtactual.Visible = True
            ongoing_details.txtactual.BackColor = Color.Yellow
        Else

        End If

        If ongoing_details.dateofreport.Value.Date = DateTime.Today Then
            ongoing_details.dateofreport.Visible = False
            ongoing_details.txtreport.Visible = True
            ongoing_details.txtreport.BackColor = Color.Yellow

        Else

        End If

        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub paneltwo()
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Panel2.Width, Panel2.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, Panel2.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(Panel2.Width, radius, Panel2.Width, Panel2.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(Panel2.Width - radius, Panel2.Height, radius, Panel2.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        Panel2.Region = New Region(panelPath)
    End Sub



    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        loadingthis += 1
        dashboard.Show()
        Me.Close()

    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub


    Private Sub Populatearea(selectedarea As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M %Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M %Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "

            If Not String.IsNullOrEmpty(selectedarea) Then
                ' Add a WHERE clause to filter records based on the input text using LIKE.
                query &= "WHERE t2.area_planted = @selectedarea AND t5.unique_code IS NOT NULL;"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(selectedarea) Then
                    ' Provide the input text (selectedarea) as a parameter.
                    cmd.Parameters.AddWithValue("@selectedarea", selectedarea)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")
                    DataGridView1.DataSource = DataSet.Tables("YourTableName")
                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using
    End Sub



    Private Sub chkarea_CheckedChanged(sender As Object, e As EventArgs) Handles chkarea.CheckedChanged
        Dim selectedarea As String = txtarea.Text

        If chkarea.Checked AndAlso Not String.IsNullOrEmpty(selectedarea) Then
            ' Populate DataGridView with data based on both checkboxes and selected values
            Populatearea(selectedarea)
            loadarea = selectedarea
        Else
            ' Populate DataGridView with data based on the year checkbox only
            LoadData()
        End If

    End Sub

    Private Sub Ongoingcon_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel2.Left = (Me.Width - Panel2.Width) / 2
    End Sub


    Private Sub Populateorg(org As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)


            Dim query As String = "SELECT t1.unique_code, DATE_FORMAT(t1.date_execution, '%M %Y') AS date_execution, DATE_FORMAT(t1.date_expiry, '%M %Y') AS date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay, t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "INNER JOIN date_turnover_tbl AS t5 ON t1.unique_code = t5.unique_code "


            If Not String.IsNullOrEmpty(org) Then
                query &= "WHERE Org_name = @selectedorg AND t5.unique_code IS NOT NULL;"
            End If

            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(org) Then
                    cmd.Parameters.AddWithValue("@selectedorg", org)
                End If

                connection.Open()

                Using adapter As New MySqlDataAdapter(cmd)
                    DataSet.Clear()
                    adapter.Fill(DataSet, "YourTableName")
                    DataGridView1.DataSource = DataSet.Tables("YourTableName")
                    txtrecords.Text = DataSet.Tables("YourTableName").Rows.Count.ToString()
                    If DataSet.Tables("YourTableName").Rows.Count = 0 Then
                        MessageBox.Show("No data retrieved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                connection.Close()
            End Using
        End Using

    End Sub

    Private Sub chkorg_CheckedChanged(sender As Object, e As EventArgs) Handles chkorg.CheckedChanged
        If chkorg.Checked = True Then

            If cmborg.SelectedIndex >= 0 Then
                Dim selectedorg As String = cmborg.SelectedItem.ToString()
                loadorg = selectedorg
            Else
                MessageBox.Show("Please choose first the Organization", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkorg.Checked = False
            End If

        Else



        End If
    End Sub


    Sub cmborgselect()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT DISTINCT Org_name FROM organizational_tbl ORDER BY Org_name"


        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmborg.Items.Clear()
            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                cmborg.Items.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uniquecode As String = Newtxtuniquecode.Text & "-" & newtxtcode.Text & "-" & txtnewuni.Text & "-" & txtnewcode.Text
        code.Text = uniquecode
        LoadData(uniquecode)
        Newtxtuniquecode.Clear()
        newtxtcode.Clear()
        txtnewuni.Clear()
        txtnewcode.Clear()
    End Sub


    Private Sub cmbyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyear.SelectedIndexChanged
        If cmbyear.SelectedItem IsNot Nothing Then
            Dim selectedYear As String = cmbyear.SelectedItem.ToString()
            Populateyear(selectedYear)
            loadyear = selectedYear
        End If
    End Sub

    Private Sub cmborg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmborg.SelectedIndexChanged
        If cmborg.SelectedItem IsNot Nothing Then
            Dim selectedorg As String = cmborg.SelectedItem.ToString()
            Populateorg(selectedorg)
            loadorg = selectedorg
        End If
    End Sub

    Private Sub cmbmuni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmuni.SelectedIndexChanged
        If cmbmuni.SelectedItem IsNot Nothing Then
            Dim selectedmuni As String = cmbmuni.SelectedItem.ToString()
            PopulatebyMuni(selectedmuni)
            loadmuni = selectedmuni
        End If
    End Sub

    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"


    Private Sub btnprintreport_Click(sender As Object, e As EventArgs) Handles btnprintreport.Click
        HandleCheckboxes()
    End Sub


    Public Sub LoadConsolidatedProjectReporters(filterType As String, filterValue As String)
        Dim rptDSDetails As ReportDataSource

        Try
            NGPdata_Report.ReportViewer1.RefreshReport()

            ' Load report files
            With NGPdata_Report.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\AllConsolidatedData.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' Consolidated query with a flexible filter
                Dim consolidatedQuery As String = "SELECT DISTINCT " &
                "t1.unique_code, t1.year, t1.baranggay, " &
                "t1.municipality, t1.component, " &
                "t1.commodity, t2.data_id, " &
                "t2.target_area, t2.area_planted, " &
                "t2.seed_pro, t2.seed_plant, " &
                "t3.Org_name, t4.project_cost, " &
                "t4.year1, t4.year2, t4.year3, " &
                "t4.gross_amount, t4.polygon_code, " &
                "t5.date_execution, t5.date_expiry, " &
                "t6.amount_cip, t6.amount_under, " &
                "t7.date_turnover, t8.date_validation, " &
                "t9.survival_rate, t10.date_updated, " &
                "t10.status AS status_site, t10.adopting_entity, " &
                "t11.area_damaged, t11.type_damage, " &
                "t11.status, " &
                "t12.seed_code, " &
                "t13.seed_produce_code, " &
                "(SELECT GROUP_CONCAT(t13.multispecies_name SEPARATOR ', ') " &
                " FROM multispecies AS t13 " &
                " WHERE t13.seed_produce_code = t12.seed_code) AS multispecies_name " &
                "FROM contract_tbl AS t1 " &
                "LEFT JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                "LEFT JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                "LEFT JOIN projectcost_tbl AS t4 ON t1.unique_code = t4.unique_code " &
                "LEFT JOIN contract_tbl AS t5 ON t1.unique_code = t5.unique_code " &
                "LEFT JOIN status_registry AS t6 ON t1.unique_code = t6.unique_code " &
                "LEFT JOIN date_turnover_tbl AS t7 ON t6.unique_code = t7.unique_code " &
                "LEFT JOIN date_validation_report AS t8 ON t7.unique_code = t8.unique_code " &
                "LEFT JOIN survival_rate_year3 AS t9 ON t1.unique_code = t9.unique_code " &
                "LEFT JOIN site_status_tbl AS t10 ON t1.unique_code = t10.unique_code " &
                "LEFT JOIN disturbances_tbl AS t11 ON t1.unique_code = t11.unique_code " &
                "LEFT JOIN multispecies AS t13 ON t1.unique_code = t13.unique_code " &
                "LEFT JOIN seedproduction_tbl AS t12 ON t13.seed_produce_code = t12.seed_code " &
                "LEFT JOIN date_turnover_tbl AS t14 ON t1.unique_code = t14.unique_code " &
                "WHERE " & GetFilterCondition(filterType) & " = @filterValue AND t14.unique_code IS NOT NULL " &
                "ORDER BY t1.unique_code ASC"

                Dim consolidatedCommand As New MySqlCommand(consolidatedQuery, connection)
                consolidatedCommand.Parameters.AddWithValue("@filterValue", filterValue)

                ' Fill data into a DataSet for the consolidated query
                Dim dsConsolidated As New DataSet
                Dim daConsolidated As New MySqlDataAdapter(consolidatedCommand)
                daConsolidated.Fill(dsConsolidated, "ConsolidatedData")

                ' Close the connection
                connection.Close()

                ' List of columns specified in the query
                Dim columns As List(Of String) = New List(Of String) From {
                "unique_code", "year", "baranggay", "municipality", "component",
                "commodity", "data_id", "target_area", "area_planted", "seed_pro",
                "seed_plant", "Org_name", "project_cost", "year1", "year2",
                "year3", "gross_amount", "polygon_code", "date_execution",
                "date_expiry", "amount_cip", "amount_under", "date_turnover",
                "date_validation", "survival_rate", "date_updated", "status_site",
                "adopting_entity", "area_damaged", "type_damage", "status",
                "seed_code", "seed_produce_code", "multispecies_name"
            }

                ' Iterate through each row and set default value if any specified column is empty
                For Each row As DataRow In dsConsolidated.Tables("ConsolidatedData").Rows
                    For Each column As String In columns
                        If row.Table.Columns.Contains(column) Then
                            If row.IsNull(column) OrElse String.IsNullOrEmpty(row(column).ToString()) Then
                                If row.Table.Columns(column).DataType Is GetType(String) Then
                                    row(column) = "For updating"
                                ElseIf row.Table.Columns(column).DataType Is GetType(Integer) OrElse row.Table.Columns(column).DataType Is GetType(Decimal) OrElse row.Table.Columns(column).DataType Is GetType(Double) Then
                                    row(column) = 0
                                ElseIf row.Table.Columns(column).DataType Is GetType(DateTime) Then
                                    row(column) = DateTime.MinValue
                                ElseIf row.Table.Columns(column).DataType Is GetType(Boolean) Then
                                    row(column) = False
                                End If
                            End If
                        End If
                    Next
                Next

                ' Create ReportDataSources and bind them to the ReportViewer
                rptDSDetails = New ReportDataSource("consilidatedData", dsConsolidated.Tables("ConsolidatedData"))

                NGPdata_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSDetails)
            End Using

            ' Set display mode and zoom level
            NGPdata_Report.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            NGPdata_Report.ReportViewer1.ZoomMode = ZoomMode.Percent
            NGPdata_Report.ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Function GetFilterCondition(filterType As String) As String
        Select Case filterType
            Case "year"
                Return "t1.year"
            Case "municipality"
                Return "t1.municipality"
            Case "area_planted"
                Return "t2.area_planted"
            Case "org_name"
                Return "t3.Org_name"
            Case Else
                Throw New ArgumentException("Invalid filter type")
        End Select
    End Function

    Private Sub HandleCheckboxes()
        If chkyear.Checked Then
            LoadConsolidatedProjectReporters("year", loadyear)
            parameters()
            NGPdata_Report.ShowDialog()
        ElseIf chkmuni.Checked Then
            If cmbmuni.SelectedIndex >= 0 Then
                LoadConsolidatedProjectReporters("municipality", cmbmuni.SelectedItem.ToString())
                parameters()
                NGPdata_Report.ShowDialog()
            End If
        ElseIf chkarea.Checked Then
            Dim selectedarea As String = txtarea.Text
            If Not String.IsNullOrEmpty(selectedarea) Then
                LoadConsolidatedProjectReporters("area_planted", selectedarea)
                parameters()
                NGPdata_Report.ShowDialog()
            End If
        ElseIf chkorg.Checked Then
            If cmborg.SelectedIndex >= 0 Then
                LoadConsolidatedProjectReporters("org_name", cmborg.SelectedItem.ToString())
                parameters()
                NGPdata_Report.ShowDialog()
            End If
        ElseIf chkall.checked Then
            AllLoadConsolidatedProjectReporters()
            parameters()
            NGPdata_Report.ShowDialog()
        Else
            MessageBox.Show("Please choose the filter you want to print", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub AllLoadConsolidatedProjectReporters()
        Dim rptDSDetails As ReportDataSource

        Try
            NGPdata_Report.ReportViewer1.RefreshReport()

            ' Load report files
            With NGPdata_Report.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\AllConsolidatedData.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' Consolidated query with a flexible filter
                Dim consolidatedQuery As String = "SELECT DISTINCT " &
                "t1.unique_code, t1.year, t1.baranggay, " &
                "t1.municipality, t1.component, " &
                "t1.commodity, t2.data_id, " &
                "t2.target_area, t2.area_planted, " &
                "t2.seed_pro, t2.seed_plant, " &
                "t3.Org_name, t4.project_cost, " &
                "t4.year1, t4.year2, t4.year3, " &
                "t4.gross_amount, t4.polygon_code, " &
                "t5.date_execution, t5.date_expiry, " &
                "t6.amount_cip, t6.amount_under, " &
                "t7.date_turnover, t8.date_validation, " &
                "t9.survival_rate, t10.date_updated, " &
                "t10.status AS status_site, t10.adopting_entity, " &
                "t11.area_damaged, t11.type_damage, " &
                "t11.status, " &
                "t12.seed_code, " &
                "t13.seed_produce_code, " &
                "(SELECT GROUP_CONCAT(t13.multispecies_name SEPARATOR ', ') " &
                " FROM multispecies AS t13 " &
                " WHERE t13.seed_produce_code = t12.seed_code) AS multispecies_name " &
                "FROM contract_tbl AS t1 " &
                "LEFT JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                "LEFT JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                "LEFT JOIN projectcost_tbl AS t4 ON t1.unique_code = t4.unique_code " &
                "LEFT JOIN contract_tbl AS t5 ON t1.unique_code = t5.unique_code " &
                "LEFT JOIN status_registry AS t6 ON t1.unique_code = t6.unique_code " &
                "LEFT JOIN date_turnover_tbl AS t7 ON t6.unique_code = t7.unique_code " &
                "LEFT JOIN date_validation_report AS t8 ON t7.unique_code = t8.unique_code " &
                "LEFT JOIN survival_rate_year3 AS t9 ON t1.unique_code = t9.unique_code " &
                "LEFT JOIN site_status_tbl AS t10 ON t1.unique_code = t10.unique_code " &
                "LEFT JOIN disturbances_tbl AS t11 ON t1.unique_code = t11.unique_code " &
                "LEFT JOIN multispecies AS t13 ON t1.unique_code = t13.unique_code " &
                "LEFT JOIN seedproduction_tbl AS t12 ON t13.seed_produce_code = t12.seed_code " &
                "LEFT JOIN date_turnover_tbl AS t14 ON t1.unique_code = t14.unique_code " &
                "WHERE t14.unique_code IS NOT NULL " &
                "ORDER BY t1.unique_code ASC"

                Dim consolidatedCommand As New MySqlCommand(consolidatedQuery, connection)
                consolidatedCommand.Parameters.AddWithValue("@filterValue", DBNull.Value)

                ' Fill data into a DataSet for the consolidated query
                Dim dsConsolidated As New DataSet
                Dim daConsolidated As New MySqlDataAdapter(consolidatedCommand)
                daConsolidated.Fill(dsConsolidated, "ConsolidatedData")

                ' Close the connection
                connection.Close()

                ' List of columns specified in the query
                Dim columns As List(Of String) = New List(Of String) From {
                "unique_code", "year", "baranggay", "municipality", "component",
                "commodity", "data_id", "target_area", "area_planted", "seed_pro",
                "seed_plant", "Org_name", "project_cost", "year1", "year2",
                "year3", "gross_amount", "polygon_code", "date_execution",
                "date_expiry", "amount_cip", "amount_under", "date_turnover",
                "date_validation", "survival_rate", "date_updated", "status_site",
                "adopting_entity", "area_damaged", "type_damage", "status",
                "seed_code", "seed_produce_code", "multispecies_name"
            }

                ' Iterate through each row and set default value if any specified column is empty
                For Each row As DataRow In dsConsolidated.Tables("ConsolidatedData").Rows
                    For Each column As String In columns
                        If row.Table.Columns.Contains(column) Then
                            If row.IsNull(column) OrElse String.IsNullOrEmpty(row(column).ToString()) Then
                                If row.Table.Columns(column).DataType Is GetType(String) Then
                                    row(column) = "For updating"
                                ElseIf row.Table.Columns(column).DataType Is GetType(Integer) OrElse row.Table.Columns(column).DataType Is GetType(Decimal) OrElse row.Table.Columns(column).DataType Is GetType(Double) Then
                                    row(column) = 0
                                ElseIf row.Table.Columns(column).DataType Is GetType(DateTime) Then
                                    row(column) = DateTime.MinValue
                                ElseIf row.Table.Columns(column).DataType Is GetType(Boolean) Then
                                    row(column) = False
                                End If
                            End If
                        End If
                    Next
                Next

                ' Create ReportDataSources and bind them to the ReportViewer
                rptDSDetails = New ReportDataSource("consilidatedData", dsConsolidated.Tables("ConsolidatedData"))

                NGPdata_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSDetails)
            End Using

            ' Set display mode and zoom level
            NGPdata_Report.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            NGPdata_Report.ReportViewer1.ZoomMode = ZoomMode.Percent
            NGPdata_Report.ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub parameters()
        ' Get the values from textboxes
        Dim totalProjects As String = txtrecords.Text  ' Assuming txtUniqueCode is the name of your textbox for unique code

        ' Specify the parameters you want to pass to the report
        Dim reportParameters As New List(Of ReportParameter)()
        reportParameters.Add(New ReportParameter("totalpro", totalProjects))

        ' Set the path of the RDLC file
        NGPdata_Report.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\AllConsolidatedData.rdlc"

        ' Set the parameters to the ReportViewer control
        NGPdata_Report.ReportViewer1.LocalReport.SetParameters(reportParameters)

        ' Refresh the report
        NGPdata_Report.ReportViewer1.RefreshReport()
    End Sub

End Class