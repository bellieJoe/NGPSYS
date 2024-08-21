Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class Seedling_planted
    Dim progressresult As Integer
    Dim exitpe As Integer

    Dim numericValue As Decimal
    Dim ticValue As Decimal
    Dim accomplishment As Decimal

    Dim paramAccomplishment As String


    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
    Private Sub Seedling_planted_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user()


        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        If IsNumeric(ongoing_details.txtseedreq.Text) Then
            txtreq.Text = Decimal.Parse(ongoing_details.txtseedreq.Text).ToString("N")
        Else
            ' Handle invalid numeric value
            txtreq.Text = "Invalid Value"
        End If

        LoadDataToDataGridView()
        LoadDataToListView()
        loadremarks()
        start()


    End Sub

    Public Sub LoadReportPlantEst()
        Dim rptDS As ReportDataSource
        Try
            PlantationEstablishmentReport.ReportViewer1.RefreshReport()

            ' Load report file
            With PlantationEstablishmentReport.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\plantation_est_report.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' SQL query with WHERE clause
                Dim query As String = "SELECT t1. seed_code, t1.date_request, t1.date_inspected, t2.activities, t2.UWM, t2.total_contract, t2.unit_cost, t2.total_target, t2.accomplishment, t2.seed_planted " &
                     "FROM seedplanted_tbl AS t1 " &
                     "INNER JOIN plantation_estab_tbl AS t2 ON t1.seed_code = t2.seed_code " &
                     "WHERE t2.unique_code = @value;"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

                ' Execute the query and fill data into a DataSet
                Dim ds As New DataSet
                Dim da As New MySqlDataAdapter(command)
                da.Fill(ds, "PlantationEstablishmentReport")

                ' Close the connection
                connection.Close()

                ' Get the number of rows retrieved
                Dim rowCount As Integer = ds.Tables("PlantationEstablishmentReport").Rows.Count

                ' Display the number of rows retrieved
                MsgBox("Number of rows retrieved: " & rowCount, vbInformation)

                ' Create ReportDataSource and bind it to the ReportViewer
                rptDS = New ReportDataSource("DataSet1", ds.Tables("PlantationEstablishmentReport"))
                PlantationEstablishmentReport.ReportViewer1.LocalReport.DataSources.Add(rptDS)
            End Using

            ' Set display mode and zoom level
            PlantationEstablishmentReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            PlantationEstablishmentReport.ReportViewer1.ZoomMode = ZoomMode.Percent
            PlantationEstablishmentReport.ReportViewer1.ZoomPercent = 30


        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub parameters()
        ' Get the values from textboxes
        Dim uniqueCodeValue As String = uniquecodeloading  ' Assuming txtUniqueCode is the name of your textbox for unique code
        Dim org As String = txtorg.Text  ' Assuming txtUniqueCode is the name of your textbox for unique code
        Dim remarks As String = txtremarks.Text ' Assuming txtSeedReq is the name of your textbox for seed request
        Dim seedreq As String = txtreq.Text
        Dim seedplanted As String = txtplanted.Text

        ' Specify the parameters you want to pass to the report
        Dim reportParameters As New List(Of ReportParameter)()
        reportParameters.Add(New ReportParameter("uniquecode", uniqueCodeValue))
        reportParameters.Add(New ReportParameter("org", org))
        reportParameters.Add(New ReportParameter("remarks", remarks))
        reportParameters.Add(New ReportParameter("seedreq", seedreq))
        reportParameters.Add(New ReportParameter("seedplanted", seedplanted))
        reportParameters.Add(New ReportParameter("accomplishment", paramAccomplishment))

        ' Set the path of the RDLC file
        PlantationEstablishmentReport.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\plantation_est_report.rdlc"

        ' Set the parameters to the ReportViewer control
        PlantationEstablishmentReport.ReportViewer1.LocalReport.SetParameters(reportParameters)

        ' Refresh the report
        PlantationEstablishmentReport.ReportViewer1.RefreshReport()
    End Sub

    Public Sub LoadDataToListView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1. seed_code, t1.date_request, t1.date_inspected, t2.activities, t2.UWM, t2.total_contract, t2.unit_cost, t2.total_target, t2.accomplishment, t2.seed_planted " &
                     "FROM seedplanted_tbl AS t1 " &
                     "INNER JOIN plantation_estab_tbl AS t2 ON t1.seed_code = t2.seed_code " &
                     "WHERE t2.unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous items and columns
                ListView1.Items.Clear()
                ListView1.Columns.Clear()

                ' Set the view and add columns
                ListView1.View = System.Windows.Forms.View.Details
                ListView1.Columns.Add("Activities", 150)
                ListView1.Columns.Add("UWM", 100)
                ListView1.Columns.Add("Total Contract Cost", 190)
                ListView1.Columns.Add("Unit Cost", 150)
                ListView1.Columns.Add("Total Target", 150)
                ListView1.Columns.Add("% of Accomplishment", 190)

                ' Populate the ListView
                While reader.Read()
                    lblcode = reader.GetString("seed_code")
                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspected").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    txtplanted.Text = reader.GetDecimal("seed_planted").ToString("N")

                    Dim item As New ListViewItem(reader.GetString(3))
                    item.SubItems.Add(reader.GetString("UWM"))
                    item.SubItems.Add(reader.GetString("total_target"))

                    ' Assuming the first column is a string
                    ' Assuming the second column is a numeric value
                    Dim numericValue As Decimal
                    If Decimal.TryParse(reader.GetString(6), numericValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(numericValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim ticValue As Decimal
                    If Decimal.TryParse(reader.GetString(5), ticValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(ticValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("accomplishment")) Then
                        Dim accomplishment As Decimal = reader.GetDecimal("accomplishment")

                        item.SubItems.Add(accomplishment.ToString("N2") & "%")
                        paramAccomplishment = accomplishment.ToString("N2") & "%"
                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    Else
                        item.SubItems.Add("N/A")
                    End If

                    ListView1.Items.Add(item)
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)
                ' Display the overall percentage in a label or TextBox
                txtOverallPercentage.Text = overallPercentage.ToString()
            End Using
        End Using
    End Sub

    Public Sub LoadDataToDataGridView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.seed_code, t1.date_request, t1.date_inspected,  t2.plantation_id, t2.activities, t2.UWM, t2.total_contract, t2.unit_cost, t2.total_target, t2.accomplishment, t2.seed_planted " &
                 "FROM seedplanted_tbl AS t1 " &
                 "INNER JOIN plantation_estab_tbl AS t2 ON t1.seed_code = t2.seed_code " &
                 "WHERE t2.unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            ' Clear previous columns if any
            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Add columns to DataGridView
                DataGridView1.ColumnCount = 7
                DataGridView1.Columns(0).Name = "ID"
                DataGridView1.Columns(1).Name = "Activities"
                DataGridView1.Columns(2).Name = "UWM"
                DataGridView1.Columns(3).Name = "Total Target"
                DataGridView1.Columns(4).Name = "Unit Cost"
                DataGridView1.Columns(5).Name = "Total Contract Cost"
                DataGridView1.Columns(6).Name = "% of Accomplishment"


                DataGridView1.Columns(0).Visible = False


                ' Populate the DataGridView
                While reader.Read()


                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    lblcode = reader.GetString("seed_code")
                    Dim datetic As Date
                    If Date.TryParse(reader("date_inspected").ToString(), datetic) Then
                        txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")
                    End If
                    Dim datestake As Date
                    If Date.TryParse(reader("date_request").ToString(), datestake) Then
                        txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    End If

                    txtplanted.Text = reader.GetDecimal("seed_planted").ToString("N")

                    row.Cells(0).Value = reader.GetString("plantation_id")
                    row.Cells(1).Value = reader.GetString("activities")
                    row.Cells(2).Value = reader.GetString("UWM")
                    row.Cells(3).Value = reader.GetString("total_target")

                    ' Assuming the first column is a string
                    ' Assuming the second column is a numeric value
                    If Decimal.TryParse(reader.GetString(7), numericValue) Then
                        row.Cells(4).Value = numericValue.ToString("N")
                    Else
                        row.Cells(4).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(6), ticValue) Then
                        row.Cells(5).Value = ticValue.ToString("N")
                    Else
                        row.Cells(5).Value = "Invalid Value"
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("accomplishment")) Then
                        accomplishment = reader.GetDecimal("accomplishment")

                        row.Cells(6).Value = accomplishment.ToString("N2") & "%"

                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    Else
                        row.Cells(6).Value = "N/A"
                    End If

                    DataGridView1.Rows.Add(row)
                End While
            End Using



            ' Calculate the overall percentage
            Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)
            ' Display the overall percentage in a label or TextBox
            txtOverallPercentage.Text = overallPercentage.ToString()
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = If(DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtact.Text = If(DataGridView1.Item("Activities", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Activities", DataGridView1.CurrentRow.Index).Value.ToString(), "")
        txtuwm.Text = If(DataGridView1.Item("UWM", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("UWM", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtcost.Text = If(DataGridView1.Item("Total Contract Cost", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Total Contract Cost", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtunit.Text = If(DataGridView1.Item("Unit Cost", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Unit Cost", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txttarget.Text = If(DataGridView1.Item("Total Target", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Total Target", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtpercent.Text = If(DataGridView1.Item("% of Accomplishment", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("% of Accomplishment", DataGridView1.CurrentRow.Index).Value.ToString().Replace("%", ""), "")

    End Sub





    Sub loadremarks()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT remarks_id, remarks FROM remarks WHERE unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)  ' Replace some_value with your filter value

            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Check if the reader has rows and read the "remarks" column
                    txtreid.text = reader.GetString("remarks_id")
                    txtremarks.Text = reader.GetString("remarks")
                    txtremarks.ReadOnly = True
                    btnreadd.Visible = False
                Else
                    ' Handle the case where no remarks are found
                    btnreadd.Visible = True
                    txtremarks.Text = "No remarks found."
                End If
            End Using
        End Using
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Simulate progress (for example, increment by 5%)
        Dim currentProgress As Integer = ProgressBar1.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar1.Increment(1)

            ' Update the label to display the current percentage
            progress.Text = ProgressBar1.Value.ToString() & "%"
            txtprogress.Text = "Accomplished"
        Else
            ' Stop the timer when the progress reaches 90%
            Timer1.Stop()


        End If

        percentage += 1 ' Adjust the increment value to control the speed of progress

        ' Limit the progress to 100%
        If percentage >= progressresult Then
            percentage = progressresult ' Set the percentage to 100%
            Timer1.Stop() ' Stop the Timer
        End If

        ' Redraw the circular progress bar
        PictureBox1.Invalidate()

        ' Redraw the circular progress bar
        PictureBox1.Invalidate()
    End Sub



    Dim percentage As Double = 0.0 ' Percentage of progress

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, PictureBox1.Width - 20, PictureBox1.Height - 20) ' Adjust the size and position
        Dim center As New Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2)

        ' Create a custom gradient background with a system color
        Dim startColor As Color = SystemColors.GradientActiveCaption
        Dim endColor As Color = SystemColors.GradientActiveCaption
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(rect, startColor, endColor, Drawing2D.LinearGradientMode.ForwardDiagonal)

        ' Fill the background with the gradient brush
        g.FillEllipse(gradientBrush, rect)

        ' Calculate the sweep angle based on the percentage
        Dim startAngle As Integer = -90 ' Start angle (12 o'clock position)
        Dim sweepAngle As Integer = CInt(percentage * 3.6) ' Convert percentage to degrees
        Dim progressColor As New Pen(Color.Green, 5) ' Adjust color and width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub

    Public Sub start()
        Timer1.Start()

        Dim value1 As Decimal

        If Decimal.TryParse(txtOverallPercentage.Text, value1) Then
            ' Calculate the percentage
            Dim percentage As Double = value1

            ' Display the result in a message box
            progressresult = percentage

        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter valid integer values in both textboxes.", "Error")
        End If
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs)
        TICdashboard.Show()
    End Sub



    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If exitpe = 1 Then



        Else
            closesystemMF = 0
            TICdashboard.Close()
            With TICdashboard
                .TopLevel = False
                maindash.Panel5.Controls.Add(TICdashboard)
                .BringToFront()
                .Show()
            End With

        End If


    End Sub



    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        btnedit.Visible = False
        txtact.ReadOnly = False
        txtcost.ReadOnly = False
        txtpercent.ReadOnly = False
        txttarget.ReadOnly = False
        txtunit.ReadOnly = False
        txtuwm.ReadOnly = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        updatedata()
        LoadDataToListView()
        LoadDataToDataGridView()
        btnedit.Visible = True
        txtact.ReadOnly = True
        txtcost.ReadOnly = True
        txtpercent.ReadOnly = True
        txttarget.ReadOnly = True
        txtunit.ReadOnly = True
        txtuwm.ReadOnly = True
    End Sub

    Public Sub updatedata()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtact.Text = "" Or txtunit.Text = "" Or txttarget.Text = "" Or txtpercent.Text = "" Or txtcost.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE plantation_estab_tbl SET activities = @Value2, UWM = @Value3, total_contract = @Value4, unit_cost = @Value5, total_target = @Value6, accomplishment = @Value7 WHERE plantation_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtid.Text)
                    command.Parameters.AddWithValue("@Value2", txtact.Text)
                    command.Parameters.AddWithValue("@Value3", txtuwm.Text)
                    command.Parameters.AddWithValue("@Value4", txtcost.Text)
                    command.Parameters.AddWithValue("@Value5", txtunit.Text)
                    command.Parameters.AddWithValue("@Value6", txttarget.Text)
                    command.Parameters.AddWithValue("@Value7", txtpercent.Text)

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

            btnedit.Visible = True
        End If
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        deleteData()
        LoadDataToListView()
        LoadDataToDataGridView()
        btnedit.Visible = True
        txtact.ReadOnly = True
        txtcost.ReadOnly = True
        txtpercent.ReadOnly = True
        txttarget.ReadOnly = True
        txtunit.ReadOnly = True
        txtuwm.ReadOnly = True
    End Sub

    Public Sub deleteData()
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
                    Dim deleteQuery As String = "DELETE FROM plantation_estab_tbl WHERE plantation_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtid.Text)

                        command.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data successfully deleted.")

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.ToString())
                Finally
                    ' Ensure the connection is closed, even in the case of an exception
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
                btnedit.Visible = True
            End If
        End If
    End Sub

    Private Sub btnreedit_Click(sender As Object, e As EventArgs) Handles btnreedit.Click
        btnreedit.Visible = False
        txtremarks.ReadOnly = False
    End Sub



    Public Sub updateRemarks()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Update remarks
            Dim updateQuery As String = "UPDATE remarks SET remarks = @Value1 WHERE remarks_id = @Value2"
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@Value1", txtremarks.Text)
                command.Parameters.AddWithValue("@Value2", txtreid.Text)
                command.ExecuteNonQuery()
            End Using

            ' Display a success message with an information icon
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        Finally
            ' Ensure the connection is closed, even in the case of an exception
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        txtremarks.ReadOnly = True
        btnreedit.Visible = True
    End Sub




    Private Sub btnresave_Click(sender As Object, e As EventArgs) Handles btnresave.Click
        updateRemarks()
        loadremarks()
    End Sub
    Public Sub deleteRemarks()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Delete remark
            Dim deleteQuery As String = "DELETE FROM remarks WHERE remarks_id = @Value1"
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@Value1", txtreid.Text)
                command.ExecuteNonQuery()
            End Using

            ' Display a confirmation message with a warning icon
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this remark?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, display a success message
            If result = DialogResult.Yes Then
                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        Finally
            ' Ensure the connection is closed, even in the case of an exception
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        ' Additional code for UI adjustments, if any
        txtremarks.ReadOnly = True
        btnreedit.Visible = True
    End Sub

    Private Sub btnredelete_Click(sender As Object, e As EventArgs) Handles btnredelete.Click
        deleteRemarks()
        loadremarks()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadReportPlantEst()
        parameters()
        PlantationEstablishmentReport.ShowDialog()
    End Sub


    Private Sub user()
        If personnel = 1 Then
            btndelete.Enabled = True
            btnedit.Enabled = True
            btnsave.Enabled = True

            btnreedit.Enabled = True
            btnresave.Enabled = True
            btnredelete.Enabled = True


        Else
            btndelete.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = False

            btnreedit.Enabled = False
            btnresave.Enabled = False
            btnredelete.Enabled = False

        End If
    End Sub

    Private Sub btnreadd_Click(sender As Object, e As EventArgs) Handles btnreadd.Click

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)

        connection.Open()

        Try
            If txtremarks.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO remarks (unique_code,code_remark, remarks) VALUES (@Value1, @Value2, @Value3)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", lblcode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                loadremarks()
                btnreadd.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class