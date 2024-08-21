Imports System.Globalization
Imports System.Runtime.Intrinsics
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Seedling_pro
    Dim progressresult As Integer
    Dim totalproduce As Double
    Dim parametercode As String


    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"


    Private Sub Seedling_pro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user()
        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        parametercode = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString

        LoadDataToListView()
        DisplayTotalAmountseed()
        retrieveseeds()
        DisplayTotalAmount()
        start()
        LoadDataToDataGridView()

    End Sub

    Public Sub parameters()
        ' Get the values from textboxes
        Dim uniqueCodeValue As String = uniquecodeloading  ' Assuming txtUniqueCode is the name of your textbox for unique code
        Dim seedReqValue As String = txtreq.Text
        Dim org As String = txtorg.Text  ' Assuming txtUniqueCode is the name of your textbox for unique code
        Dim mortality As String = txtmortality.Text ' Assuming txtSeedReq is the name of your textbox for seed request

        ' Specify the parameters you want to pass to the report
        Dim reportParameters As New List(Of ReportParameter)()
        reportParameters.Add(New ReportParameter("uniquecode", uniqueCodeValue))
        reportParameters.Add(New ReportParameter("seedreq", seedReqValue))
        reportParameters.Add(New ReportParameter("org", org))
        reportParameters.Add(New ReportParameter("mortality", mortality))

        ' Set the path of the RDLC file
        Seedling_Production_Report.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\Report1.rdlc"

        ' Set the parameters to the ReportViewer control
        Seedling_Production_Report.ReportViewer1.LocalReport.SetParameters(reportParameters)

        ' Refresh the report
        Seedling_Production_Report.ReportViewer1.RefreshReport()
    End Sub




    Public Sub LoadReportsp()
        Dim rptDS As ReportDataSource
        Try
            Seedling_Production_Report.ReportViewer1.RefreshReport()

            ' Load report file
            With Seedling_Production_Report.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\Report1.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' SQL query with WHERE clause
                Dim query As String = "SELECT t1.date_request, t1.date_inspected, t2.multispecies_name, t2.multiseed_req, t2.tic_counted " &
                         "FROM seedproduction_tbl AS t1 " &
                         "INNER JOIN multispecies AS t2 ON t1.seed_code = t2.seed_produce_code " &
                         "WHERE t2.unique_code = @value;"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

                ' Execute the query and fill data into a DataSet
                Dim ds As New DataSet
                Dim da As New MySqlDataAdapter(command)
                da.Fill(ds, "SeedlingproductionReport")

                ' Close the connection
                connection.Close()

                ' Get the number of rows retrieved
                Dim rowCount As Integer = ds.Tables("SeedlingproductionReport").Rows.Count

                ' Display the number of rows retrieved
                MsgBox("Number of rows retrieved: " & rowCount, vbInformation)

                ' Create ReportDataSource and bind it to the ReportViewer
                rptDS = New ReportDataSource("DataSet1", ds.Tables("SeedlingproductionReport"))
                Seedling_Production_Report.ReportViewer1.LocalReport.DataSources.Add(rptDS)
            End Using

            ' Set display mode and zoom level
            Seedling_Production_Report.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Seedling_Production_Report.ReportViewer1.ZoomMode = ZoomMode.Percent
            Seedling_Production_Report.ReportViewer1.ZoomPercent = 30



        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub retrieveseeds()
        Dim inputValueText As String = ongoing_details.txtseedreq.Text.ToString
        Dim inputValue As Double

        If Double.TryParse(inputValueText, inputValue) Then
            ' Step 2: Multiply by 0.10 to calculate 10%
            Dim resultValue As Double = inputValue * 0.1

            ' Step 3: Display the result in a TextBox
            txtmortality.Text = resultValue.ToString("N2")
        Else


        End If


        Dim inputNumber As Decimal
        Dim seedpro As Decimal

        If Decimal.TryParse(ongoing_details.txtseedreq.Text, inputNumber) Then
            ' Format the inputNumber as money and display it back in the TextBox
            txtreq.Text = inputNumber.ToString("N")
        Else

        End If


    End Sub

    Public Sub LoadDataToListView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspected, t2.multispecies_name, t2.multiseed_req, t2.tic_counted " &
                         "FROM seedproduction_tbl AS t1 " &
                         "INNER JOIN multispecies AS t2 ON t1.seed_code = t2.seed_produce_code " &
                         "WHERE t2.unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)  ' Replace some_value with your filter value

            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous items and columns
                ListView1.Items.Clear()
                ListView1.Columns.Clear()

                ' Set the view and add columns
                ListView1.View = System.Windows.Forms.View.Details
                ListView1.Columns.Add("Species", 150)
                ListView1.Columns.Add("No. of Seedling Produce", 190)
                ListView1.Columns.Add("As per count of TIC", 170)

                ' Populate the ListView
                While reader.Read()

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspected").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    Dim produceValue As Decimal


                    If Decimal.TryParse(reader.GetString(3), produceValue) Then
                        totalproduce += produceValue ' Add the value to the total
                    End If

                    Dim item As New ListViewItem(reader.GetString(2)) ' Assuming the first column is a string

                    ' Assuming the second column is a numeric value
                    Dim numericValue As Decimal
                    If Decimal.TryParse(reader.GetString(3), numericValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(numericValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim ticValue As Decimal
                    If Decimal.TryParse(reader.GetString(4), ticValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(ticValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If



                    ListView1.Items.Add(item)
                End While
            End Using
        End Using
    End Sub



    Public Sub DisplayTotalAmount()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(tic_counted) AS total_counted FROM multispecies WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() AndAlso Not reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                        Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                        tic_counted.Text = totalAmount.ToString("N") ' Update the TextBox
                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub DisplayTotalAmountseed()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(multiseed_req) AS total_counted FROM multispecies WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() AndAlso Not reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                        Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                        txtproduced.Text = totalAmount.ToString("N") ' Update the TextBox
                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
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
        Dim value2 As Decimal

        If Decimal.TryParse(tic_counted.Text, value1) AndAlso Decimal.TryParse(txtreq.Text, value2) Then
            ' Calculate the percentage
            Dim percentage As Double = (value1 / value2) * 100

            ' Display the result in a message box
            progressresult = percentage

        Else
            ' Display an error message if parsing fails

        End If
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        TICdashboard.Close()
        With TICdashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(TICdashboard)
            .BringToFront()
            .Show()
        End With

    End Sub



    Public Sub LoadDataToDataGridView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT t2.multispecies_id, t2.seed_produce_code, t2.multispecies_name, t2.multiseed_req, t2.tic_counted " &
                     "FROM seedproduction_tbl AS t1 " &
                     "INNER JOIN multispecies AS t2 ON t1.seed_code = t2.seed_produce_code " &
                     "WHERE t2.unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)  ' Replace some_value with your filter value

            connection.Open()

            ' Clear previous columns and data in DataGridView
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()

            ' Add columns to DataGridView
            DataGridView1.Columns.Add("multispecies_id", "ID")
            DataGridView1.Columns.Add("seed_produce_code", "Code")
            DataGridView1.Columns.Add("Species", "Species")
            DataGridView1.Columns.Add("NoOfSeedlingProduce", "Seedling Produce")
            DataGridView1.Columns.Add("TICCounted", "Verified")

            DataGridView1.Columns("multispecies_id").Visible = False
            DataGridView1.Columns("seed_produce_code").Visible = False

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ' Retrieve data from the reader
                    Dim seed_code As String = reader("seed_produce_code").ToString()
                    Dim idname As String = reader("multispecies_id").ToString()
                    Dim speciesName As String = reader("multispecies_name").ToString()

                    ' Convert and add data to DataGridView
                    Dim rowIndex As Integer = DataGridView1.Rows.Add()
                    DataGridView1.Rows(rowIndex).Cells("multispecies_id").Value = idname
                    DataGridView1.Rows(rowIndex).Cells("seed_produce_code").Value = seed_code
                    DataGridView1.Rows(rowIndex).Cells("Species").Value = speciesName
                    txtseedcode.Text = seed_code



                    Dim produceValue As Decimal
                    If Decimal.TryParse(reader("multiseed_req").ToString(), produceValue) Then
                        DataGridView1.Rows(rowIndex).Cells("NoOfSeedlingProduce").Value = produceValue.ToString("N")
                    Else
                        DataGridView1.Rows(rowIndex).Cells("NoOfSeedlingProduce").Value = "Invalid Value"
                    End If

                    Dim ticValue As Decimal
                    If Decimal.TryParse(reader("tic_counted").ToString(), ticValue) Then
                        DataGridView1.Rows(rowIndex).Cells("TICCounted").Value = ticValue.ToString("N")
                    Else
                        DataGridView1.Rows(rowIndex).Cells("TICCounted").Value = "Invalid Value"
                    End If
                End While
            End Using
        End Using
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        txtid.Text = DataGridView1.Item("multispecies_id", DataGridView1.CurrentRow.Index).Value.ToString()
        sname.Text = DataGridView1.Item("Species", DataGridView1.CurrentRow.Index).Value.ToString()

        ' Retrieve data from DataGridView and extract only numbers
        Dim sproduceValue As String = Regex.Replace(DataGridView1.Item("NoOfSeedlingProduce", DataGridView1.CurrentRow.Index).Value.ToString(), "[^\d.]", "")
        Dim verifyValue As String = Regex.Replace(DataGridView1.Item("TICCounted", DataGridView1.CurrentRow.Index).Value.ToString(), "[^\d.]", "")

        ' Convert extracted strings to decimals
        Dim sproduceDecimal As Decimal
        Dim verifyDecimal As Decimal

        Decimal.TryParse(sproduceValue, sproduceDecimal)
        Decimal.TryParse(verifyValue, verifyDecimal)

        ' Format the decimals to remove trailing zeroes
        sproduce.Text = sproduceDecimal.ToString("G", CultureInfo.InvariantCulture)
        verify.Text = verifyDecimal.ToString("G", CultureInfo.InvariantCulture)

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        btnsave.BringToFront()
        sname.ReadOnly = False
        sproduce.ReadOnly = False
        verify.ReadOnly = False

    End Sub

    Private Sub updatedata()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Try
            If sname.Text = "" Or sproduce.Text = "" Or verify.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else
                Dim query As String = "UPDATE multispecies SET multispecies_name = @Value2, multiseed_req = @Value3, tic_counted = @Value4 WHERE multispecies_id = @Value1 "
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtid.Text)
                command.Parameters.AddWithValue("@Value2", sname.Text)
                command.Parameters.AddWithValue("@Value3", sproduce.Text)
                command.Parameters.AddWithValue("@Value4", verify.Text)

                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                btnedit.BringToFront()
                sname.ReadOnly = True
                sproduce.ReadOnly = True
                verify.ReadOnly = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully updated.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub additional()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Try
            If sname.Text = "" Or sproduce.Text = "" Or verify.Text = "" Then
                MsgBox("Please input a data !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", txtseedcode.Text)
                command.Parameters.AddWithValue("@Value3", sname.Text)
                command.Parameters.AddWithValue("@Value4", sproduce.Text)
                command.Parameters.AddWithValue("@Value5", verify.Text)
                command.ExecuteNonQuery()
                ' Close the connection
                connection.Close()
                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub deleteData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Try
            If txtid.Text = "" Then
                MsgBox("Please select a record to delete!", MsgBoxStyle.Exclamation, "Warning")
            Else
                ' Prompt user for confirmation
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this species?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM multispecies WHERE multispecies_id = @Value1"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Value1", txtid.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Close the connection
                        connection.Close()

                        ' Optionally, display a success message
                        MessageBox.Show("Species successfully deleted.")

                        ' Clear text fields or update UI as needed
                        txtid.Text = ""
                        sname.Text = ""
                        sproduce.Text = ""
                        verify.Text = ""
                    Else
                        MessageBox.Show("No record found with the specified ID.")
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        updatedata()
        LoadDataToDataGridView()
        LoadDataToListView()
        retrieveseeds()
        DisplayTotalAmount()
        DisplayTotalAmountseed()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        additional()
        LoadDataToDataGridView()
        LoadDataToListView()
        retrieveseeds()
        DisplayTotalAmount()
        DisplayTotalAmountseed()
        sname.Clear()
        sproduce.Clear()
        verify.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        deleteData()
        LoadDataToDataGridView()
        LoadDataToListView()
        retrieveseeds()
        DisplayTotalAmount()
        DisplayTotalAmountseed()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        parameters()
        LoadReportsp()
        Seedling_Production_Report.ShowDialog()
    End Sub

    Private Sub user()
        If personnel = 1 Then
            btndelete.Enabled = True
            btnadd.Enabled = True
            btnedit.Enabled = True
            btnsave.Enabled = True

        Else
            btndelete.Enabled = False
            btnadd.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = False
        End If
    End Sub



End Class