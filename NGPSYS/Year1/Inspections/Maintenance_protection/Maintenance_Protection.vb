Imports CrystalDecisions.ReportAppServer.Prompting
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Maintenance_Protection

    Dim codeRemarks As String
    Dim progressresult As Integer

    Dim numericValue As Decimal
    Dim ticValue As Decimal
    Dim accomplishment As Decimal

    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

    Private Sub Maintenance_Protection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user()

        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        LoadDataToListView()
        LoadDataToDataGridView()
        loadremarks()
        survivalrate()
        survivalratedatagrid()
        start()
        start2()
    End Sub

    Public Sub LoadDataToListView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.main_code, t1.date_request, t1.date_inspected, t2.activities, t2.uwm, t2.total_cost, t2.unit_cost, t2.total_target, t2.accomplishment, t2.main_code " &
                     "FROM maintenance_pro_tbl AS t1 " &
                     "INNER JOIN maintenance_tbl AS t2 ON t1.main_code = t2.main_code " &
                     "WHERE t2.unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)  ' Replace some_value with your filter value

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
                    lblcode = reader.GetString("main_code")
                    codeRemarks = reader.GetString("main_code")
                    coderemark1.Text = codeRemarks

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspected").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")



                    Dim item As New ListViewItem(reader.GetString(3))
                    item.SubItems.Add(reader.GetString("UWM"))
                    item.SubItems.Add(reader.GetString("total_target"))

                    ' Assuming the first column is a string
                    ' Assuming the second column is a numeric value
                    Dim numericValue As Decimal
                    If Decimal.TryParse(reader.GetString(5), numericValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(numericValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim ticValue As Decimal
                    If Decimal.TryParse(reader.GetString(6), ticValue) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(ticValue.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("accomplishment")) Then
                        Dim accomplishment As Decimal = reader.GetDecimal("accomplishment")
                        item.SubItems.Add(accomplishment.ToString("N2") & "%")

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
                txtOverallPercentage2.Text = overallPercentage.ToString()
            End Using
        End Using
    End Sub

    Public Sub LoadDataToDataGridView()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.main_code, t1.date_request, t1.date_inspected, t2.maintenance_id, t2.activities, t2.uwm, t2.total_cost, t2.unit_cost, t2.total_target, t2.accomplishment, t2.main_code " &
                 "FROM maintenance_pro_tbl AS t1 " &
                 "INNER JOIN maintenance_tbl AS t2 ON t1.main_code = t2.main_code " &
                 "WHERE t2.unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)  ' Replace some_value with your filter value

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous data in DataGridView
                DataGridView1.Rows.Clear()
                DataGridView1.Columns.Clear()

                ' Add columns to the DataGridView
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

                    lblcode = reader.GetString("main_code")
                    codeRemarks = reader.GetString("main_code")
                    coderemark1.Text = codeRemarks

                    Dim datetic As Date
                    If Date.TryParse(reader("date_inspected").ToString(), datetic) Then
                        txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")
                    End If
                    Dim datestake As Date
                    If Date.TryParse(reader("date_request").ToString(), datestake) Then
                        txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    End If

                    row.Cells(0).Value = reader.GetString("maintenance_id")
                    row.Cells(1).Value = reader.GetString("activities")
                    row.Cells(2).Value = reader.GetString("UWM")
                    row.Cells(3).Value = reader.GetString("total_target")

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


    Public Sub survivalrate()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT commodity, area_planted, no_seedling_planted, no_seedling_survive, survival_rate " &
             "FROM survival_rate_year1 " &
             "WHERE unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Clear previous items and columns
                ListView2.Items.Clear()
                ListView2.Columns.Clear()

                ' Set the view and add columns
                ListView2.View = System.Windows.Forms.View.Details
                ListView2.Columns.Add("Commodity", 150)
                ListView2.Columns.Add("Area planted", 100)
                ListView2.Columns.Add("No. of Seedling Planted", 190)
                ListView2.Columns.Add("No. Of Seedling Survive", 190)
                ListView2.Columns.Add("Survival rate", 150)

                ' Populate the ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader.GetString(0)) ' Commodity
                    item.SubItems.Add(reader.GetDecimal(1).ToString("N")) ' Area planted
                    item.SubItems.Add(reader.GetDecimal(2).ToString("N")) ' No. of Seedling Planted
                    item.SubItems.Add(reader.GetDecimal(3).ToString("N")) ' No. Of Seedling Survive

                    If Not reader.IsDBNull(4) Then
                        Dim survivalRate As Decimal = reader.GetDecimal(4)
                        item.SubItems.Add(survivalRate.ToString("N2") & "%") ' Survival rate

                        ' Add the survival rate to the total
                        totalAccomplishment += survivalRate
                        totalRows += 1
                    Else
                        item.SubItems.Add("N/A")
                    End If

                    ListView2.Items.Add(item)
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)
                ' Display the overall percentage in a label or TextBox
                txtOverallPercentage.Text = overallPercentage.ToString
            End Using
        End Using
    End Sub

    Public Sub survivalratedatagrid()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT survival_id, commodity, area_planted, no_seedling_planted, no_seedling_survive, survival_rate " &
         "FROM survival_rate_year1 " &
         "WHERE unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            ' Clear previous columns if any
            DataGridView2.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Clear previous data in DataGridView
                DataGridView2.Rows.Clear()

                ' Add columns to DataGridView
                DataGridView2.ColumnCount = 6
                DataGridView2.Columns(0).Name = "ID"
                DataGridView2.Columns(1).Name = "Commodity"
                DataGridView2.Columns(2).Name = "Area Planted"
                DataGridView2.Columns(3).Name = "No. of Seedling Planted"
                DataGridView2.Columns(4).Name = "No. of Seedling Survive"
                DataGridView2.Columns(5).Name = "Survival Rate"
                DataGridView2.Columns(0).Visible = False

                ' Populate the DataGridView
                While reader.Read()
                    Dim rowIndex As Integer = DataGridView2.Rows.Add()
                    Dim row As DataGridViewRow = DataGridView2.Rows(rowIndex)
                    row.Cells(0).Value = reader.GetString(0)
                    row.Cells(1).Value = reader.GetString(1) ' Commodity
                    row.Cells(2).Value = reader.GetDecimal(2).ToString("N") ' Area planted
                    row.Cells(3).Value = reader.GetDecimal(3).ToString("N") ' No. of Seedling Planted
                    row.Cells(4).Value = reader.GetDecimal(4).ToString("N") ' No. Of Seedling Survive

                    If Not reader.IsDBNull(5) Then
                        Dim survivalRate As Decimal = reader.GetDecimal(5)
                        row.Cells(5).Value = survivalRate.ToString("N2") & "%" ' Survival rate

                        ' Add the survival rate to the total
                        totalAccomplishment += survivalRate
                        totalRows += 1
                    Else
                        row.Cells(4).Value = "N/A"
                    End If
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)
                ' Display the overall percentage in a label or TextBox
                txtOverallPercentage.Text = overallPercentage.ToString
            End Using
        End Using
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        txtidsurvival.Text = If(DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtcommodity.Text = If(DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value.ToString(), "")
        txtareaplanted.Text = If(DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtseedplanted.Text = If(DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtseedlingsurvive.Text = If(DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        Dim survivalRate As String = If(DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtsurvivalrate.Text = survivalRate.Replace("%", "")
    End Sub



    Sub loadremarks()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT remarks_id, remarks FROM remarks WHERE unique_code = @value AND code_remark = @value2;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecode)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value2", codeRemarks)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Check if the reader has rows and read the "remarks" column
                    txtreid.Text = reader.GetString("remarks_id")
                    txtremarks.Text = reader.GetString("remarks")

                Else
                    ' Handle the case where no remarks are found
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
            txtprogress.Text = "Survival Rating"
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

    Dim percentage2 As Double = 0.0
    Dim progressresult2 As Double = 0.0

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Check if the progress is less than 100%
        If percentage2 < progressresult2 Then
            ' Increment the progress
            percentage2 += 1

            ' Update the progress bar
            ProgressBar2.Value = CInt(percentage2)
            progress2.Text = ProgressBar2.Value.ToString() & "%"
            txtprogress2.Text = "Accomplished"
        Else
            ' Stop the timer when the progress reaches 100%
            Timer2.Stop()
        End If

        ' Redraw the circular progress bar
        PictureBox2.Invalidate()
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, PictureBox2.Width - 20, PictureBox2.Height - 20) ' Adjust the size and position
        Dim center As New Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2)

        ' Create a custom gradient background with a system color
        Dim startColor As Color = SystemColors.GradientActiveCaption
        Dim endColor As Color = SystemColors.GradientActiveCaption
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(rect, startColor, endColor, Drawing2D.LinearGradientMode.ForwardDiagonal)

        ' Fill the background with the gradient brush
        g.FillEllipse(gradientBrush, rect)

        ' Calculate the sweep angle based on the percentage
        Dim startAngle As Integer = -90 ' Start angle (12 o'clock position)
        Dim sweepAngle As Integer = CInt(percentage2 * 3.6) ' Convert percentage to degrees
        Dim progressColor As New Pen(Color.Green, 5) ' Adjust color and width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub

    Public Sub start2()
        Timer2.Start()

        Dim value1 As Decimal

        If Decimal.TryParse(txtOverallPercentage2.Text, value1) Then
            ' Calculate the percentage
            progressresult2 = value1

            ' Ensure the progress is within a valid range (0 to 100)
            progressresult2 = Math.Min(Math.Max(progressresult2, 0), 100)
        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter a valid numeric value for progress.", "Error")
        End If
    End Sub






    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TICdashboard.Close()
        With TICdashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(TICdashboard)
            .BringToFront()
            .Show()
        End With
        closesystemMF = 0

    End Sub




    Private Sub AddRemarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRemarksToolStripMenuItem.Click
        Me.Close()
        changeremark = 1
        remarks.Show(maindash)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        addsurvivalrate.Show(maindash)
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
                Dim updateQuery As String = "UPDATE maintenance_tbl SET activities = @Value2, UWM = @Value3, total_cost = @Value4, unit_cost = @Value5, total_target = @Value6, accomplishment = @Value7 WHERE maintenance_id = @Value1"
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
                    Dim deleteQuery As String = "DELETE FROM maintenance_tbl WHERE maintenance_id = @Value1"
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = If(DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtact.Text = If(DataGridView1.Item("Activities", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Activities", DataGridView1.CurrentRow.Index).Value.ToString(), "")
        txtuwm.Text = If(DataGridView1.Item("UWM", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("UWM", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtcost.Text = If(DataGridView1.Item("Total Contract Cost", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Total Contract Cost", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtunit.Text = If(DataGridView1.Item("Unit Cost", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Unit Cost", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txttarget.Text = If(DataGridView1.Item("Total Target", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Total Target", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtpercent.Text = If(DataGridView1.Item("% of Accomplishment", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("% of Accomplishment", DataGridView1.CurrentRow.Index).Value.ToString().Replace("%", ""), "")

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

    Private Sub btneditSurvival_Click(sender As Object, e As EventArgs) Handles btneditSurvival.Click
        btneditSurvival.Visible = False
        txtcommodity.ReadOnly = False
        txtareaplanted.ReadOnly = False
        txtseedlingsurvive.ReadOnly = False
        txtseedplanted.ReadOnly = False
        txtsurvivalrate.ReadOnly = False
    End Sub

    Private Sub btnsaveSurvival_Click(sender As Object, e As EventArgs) Handles btnsaveSurvival.Click
        updatedataSurvival()
        survivalratedatagrid()
        btneditSurvival.Visible = True
        txtcommodity.ReadOnly = True
        txtareaplanted.ReadOnly = True
        txtseedlingsurvive.ReadOnly = True
        txtseedplanted.ReadOnly = True
        txtsurvivalrate.ReadOnly = True
    End Sub

    Private Sub btndeleteSurvival_Click(sender As Object, e As EventArgs) Handles btndeleteSurvival.Click
        deleteDataSurvival()
        survivalratedatagrid()
        btneditSurvival.Visible = True
        txtcommodity.ReadOnly = True
        txtareaplanted.ReadOnly = True
        txtseedlingsurvive.ReadOnly = True
        txtseedplanted.ReadOnly = True
        txtsurvivalrate.ReadOnly = True
    End Sub

    Public Sub updatedataSurvival()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtcommodity.Text = "" Or txtareaplanted.Text = "" Or txtseedlingsurvive.Text = "" Or txtseedplanted.Text = "" Or txtsurvivalrate.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE survival_rate_year1 SET commodity = @Value2, area_planted = @Value3, no_seedling_planted = @Value4, no_seedling_survive = @Value5, survival_rate = @Value6 WHERE survival_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtidsurvival.Text)
                    command.Parameters.AddWithValue("@Value2", txtcommodity.Text)
                    command.Parameters.AddWithValue("@Value3", txtareaplanted.Text)
                    command.Parameters.AddWithValue("@Value4", txtseedplanted.Text)
                    command.Parameters.AddWithValue("@Value5", txtseedlingsurvive.Text)
                    command.Parameters.AddWithValue("@Value6", txtsurvivalrate.Text)
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
            btneditSurvival.Visible = True
        End If
    End Sub

    Public Sub deleteDataSurvival()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If txtidsurvival.Text = "" Then
            MsgBox("Please select a record to delete!", MsgBoxStyle.Exclamation, "Warning")
        Else
            ' Display a confirmation dialog with a danger icon
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, proceed with the deletion operation
            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    ' Delete record from plantation_estab_tbl
                    Dim deleteQuery As String = "DELETE FROM survival_rate_year1 WHERE survival_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtidsurvival.Text)

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
                btneditSurvival.Visible = True
            End If
        End If
    End Sub



    Public Sub LoadReportMaintenancePro()
        Dim rptDSDetails As ReportDataSource
        Dim rptDSSurvivalRate As ReportDataSource

        Try
            MaintenanceProtectionReport.ReportViewer1.RefreshReport()

            ' Load report files
            With MaintenanceProtectionReport.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\MaintenanceProtectionReport.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' Query for MaintenanceProDetails
                Dim queryDetails As String = "SELECT t1.main_code, t1.date_request, t1.date_inspected, t2.maintenance_id, t2.activities, t2.uwm, t2.total_cost, t2.unit_cost, t2.total_target, t2.accomplishment, t2.main_code " &
                                         "FROM maintenance_pro_tbl AS t1 " &
                                         "INNER JOIN maintenance_tbl AS t2 ON t1.main_code = t2.main_code " &
                                         "WHERE t2.unique_code = @value;"
                Dim commandDetails As New MySqlCommand(queryDetails, connection)
                commandDetails.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

                ' Fill data into a DataSet for MaintenanceProDetails
                Dim dsDetails As New DataSet
                Dim daDetails As New MySqlDataAdapter(commandDetails)
                daDetails.Fill(dsDetails, "MaintenanceProDetails")

                ' Query for MaintenanceProSurvivalRate
                Dim querySurvivalRate As String = "SELECT commodity, area_planted, no_seedling_planted, no_seedling_survive, survival_rate " &
                                              "FROM survival_rate_year1 " &
                                              "WHERE unique_code = @value;"
                Dim commandSurvivalRate As New MySqlCommand(querySurvivalRate, connection)
                commandSurvivalRate.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

                ' Fill data into a DataSet for MaintenanceProSurvivalRate
                Dim dsSurvivalRate As New DataSet
                Dim daSurvivalRate As New MySqlDataAdapter(commandSurvivalRate)
                daSurvivalRate.Fill(dsSurvivalRate, "MaintenanceProSurvivalRate")

                ' Close the connection
                connection.Close()

                ' Get the number of rows retrieved for both queries
                Dim rowCountDetails As Integer = dsDetails.Tables("MaintenanceProDetails").Rows.Count
                Dim rowCountSurvivalRate As Integer = dsSurvivalRate.Tables("MaintenanceProSurvivalRate").Rows.Count

                ' Display the number of rows retrieved
                MsgBox("Details rows retrieved: " & rowCountDetails & vbCrLf & "Survival Rate rows retrieved: " & rowCountSurvivalRate, vbInformation)

                ' Create ReportDataSources and bind them to the ReportViewer
                rptDSDetails = New ReportDataSource("DataSet2", dsDetails.Tables("MaintenanceProDetails"))
                rptDSSurvivalRate = New ReportDataSource("DataSet1", dsSurvivalRate.Tables("MaintenanceProSurvivalRate"))
                MaintenanceProtectionReport.ReportViewer1.LocalReport.DataSources.Add(rptDSDetails)
                MaintenanceProtectionReport.ReportViewer1.LocalReport.DataSources.Add(rptDSSurvivalRate)
            End Using

            ' Set display mode and zoom level
            MaintenanceProtectionReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            MaintenanceProtectionReport.ReportViewer1.ZoomMode = ZoomMode.Percent
            MaintenanceProtectionReport.ReportViewer1.ZoomPercent = 30

        Catch ex As Exception
            Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Public Sub parameters()
        Try
            ' Get the values from textboxes
            Dim uniqueCodeValue As String = uniquecodeloading  ' Assuming uniquecodeloading is a variable containing the unique code
            Dim org As String = txtorg.Text  ' Assuming txtorg is the name of your textbox for the organization
            Dim remarks As String = txtremarks.Text  ' Assuming txtremarks is the name of your textbox for remarks

            ' Specify the parameters you want to pass to the report
            Dim reportParameters As New List(Of ReportParameter)()
            reportParameters.Add(New ReportParameter("uniquecode", uniqueCodeValue))
            reportParameters.Add(New ReportParameter("org", org))
            reportParameters.Add(New ReportParameter("remarks", remarks))

            ' Set the path of the RDLC file
            MaintenanceProtectionReport.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\MaintenanceProtectionReport.rdlc"

            ' Set the parameters to the ReportViewer control
            MaintenanceProtectionReport.ReportViewer1.LocalReport.SetParameters(reportParameters)

            ' Refresh the report
            MaintenanceProtectionReport.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadReportMaintenancePro()
        parameters()
        MaintenanceProtectionReport.ShowDialog()
    End Sub

    Private Sub user()
        If personnel = 1 Then
            btndelete.Enabled = True
            btnedit.Enabled = True
            btnsave.Enabled = True

            btnreedit.Enabled = True
            btnresave.Enabled = True
            btnredelete.Enabled = True

            btneditSurvival.Enabled = True
            btnredelete.Enabled = True
            btnsaveSurvival.Enabled = True


        Else
            btndelete.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = False

            btnreedit.Enabled = False
            btnresave.Enabled = False
            btnredelete.Enabled = False

            btneditSurvival.Enabled = False
            btnredelete.Enabled = False
            btnsaveSurvival.Enabled = False

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