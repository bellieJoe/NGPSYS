Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class _4th_quarter
    Private Sub _4th_quarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user()


        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString

        ResetLoadingAnimation1()
        ResetLoadingAnimation2()
        ResetLoadingAnimation3()
        ResetLoadingAnimation4()

        loadrwrs()
        Datagridloadrwrs()
        loadreplanting()
        Datagridloadreplanting()
        loadpatrol()
        Datagridloadpatrol()
        start()
        start2()
        start3()
        start4()
        remark()

        txtOverallPercentage.Text = accomplished.ToString
    End Sub

    Private totalproduce As Double
    Public quartercode As String
    Dim progressresult As Integer
    Dim progressresult2 As Integer
    Dim progressresult3 As Integer
    Dim progressresult4 As Integer
    Dim survival As Decimal
    Public accomplished As Integer

    Public Sub loadrwrs()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t1.quarter_code, t2.commodity, t2.quantity, t2.unit, t2.total_cost , t2.accomplished, t2.color " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous items and columns
                ListView1.Items.Clear()
                ListView1.Columns.Clear()

                ' Set the view and add columns
                ListView1.View = System.Windows.Forms.View.Details
                ListView1.Columns.Add("Commodity", 150)
                ListView1.Columns.Add("Quantity", 150)
                ListView1.Columns.Add("Unit", 150)
                ListView1.Columns.Add("Total Cost", 150)

                ' Populate the ListView
                While reader.Read()

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    Dim item As New ListViewItem(reader.GetString(3))

                    Dim quantity As Decimal
                    If Decimal.TryParse(reader.GetString(4), quantity) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(quantity.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim unit As Decimal
                    If Decimal.TryParse(reader.GetString(5), unit) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(unit.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim totalcost As Decimal
                    If Decimal.TryParse(reader.GetString(6), totalcost) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(totalcost.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim accomplished As Decimal
                    If Not reader.IsDBNull(7) Then
                        If Decimal.TryParse(reader.GetString(7), accomplished) Then
                            txtacomm.Text = accomplished.ToString("N2")
                        Else
                            ' Handle the case where the value is not a valid decimal.
                            txtacomm.Text = "Invalid Value"
                        End If
                    Else
                        ' Handle the case where the value is NULL.
                        txtacomm.Text = ""
                    End If

                    txtcolor.Text = reader("color").ToString
                    quartercode = reader("quarter_code").ToString

                    If String.IsNullOrEmpty(txtacomm.Text) OrElse txtcolor.Text.Trim() = "" Then
                        btnrwrs.Visible = True
                    Else
                        btnrwrs.Visible = False
                    End If

                    ListView1.Items.Add(item)
                End While
            End Using
        End Using
    End Sub

    Public Sub loadreplanting()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.planted " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous items and columns
                ListView2.Items.Clear()
                ListView2.Columns.Clear()

                ' Set the view and add columns
                ListView2.View = System.Windows.Forms.View.Details
                ListView2.Columns.Add("Commodity", 150)
                ListView2.Columns.Add("Quantity", 150)
                ListView2.Columns.Add("Unit", 150)
                ListView2.Columns.Add("Total Cost", 150)

                ' Populate the ListView
                While reader.Read()


                    Dim planted As Decimal
                    If Not reader.IsDBNull(6) Then
                        If Decimal.TryParse(reader.GetString(6), planted) Then
                            txtplanted.Text = planted.ToString("N2")
                        Else
                            ' Handle the case where the value is not a valid decimal.
                            txtplanted.Text = "Invalid Value"
                        End If
                    Else
                        ' Handle the case where the value is NULL.
                        txtplanted.Text = ""
                    End If


                    If String.IsNullOrEmpty(txtplanted.Text) OrElse txtplanted.Text.Trim() = "0" Then
                        btnreplant.Visible = True
                    Else
                        btnreplant.Visible = False
                    End If


                    Dim produceValue As Decimal
                    If Decimal.TryParse(reader.GetString(1), produceValue) Then
                        totalproduce += produceValue ' Add the value to the total
                    End If

                    Dim item As New ListViewItem(reader.GetString(2)) ' Assuming the first column is a string

                    ' Assuming the second column is a numeric value
                    Dim quantity As Decimal
                    If Decimal.TryParse(reader.GetString(3), quantity) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(quantity.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim unit As Decimal
                    If Decimal.TryParse(reader.GetString(4), unit) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(unit.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim totalcost As Decimal
                    If Decimal.TryParse(reader.GetString(5), totalcost) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(totalcost.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If
                    ListView2.Items.Add(item)
                End While
            End Using
        End Using
    End Sub

    Public Sub loadpatrol()

        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)

            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.status " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value1 ;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()

                ' Clear previous items and columns
                ListView3.Items.Clear()
                ListView3.Columns.Clear()

                ' Set the view and add columns
                ListView3.View = System.Windows.Forms.View.Details
                ListView3.Columns.Add("Commodity", 150)
                ListView3.Columns.Add("Quantity", 150)
                ListView3.Columns.Add("Unit", 150)
                ListView3.Columns.Add("Total Cost", 150)

                ' Populate the ListView
                While reader.Read()



                    Dim produceValue As Decimal
                    If Decimal.TryParse(reader.GetString(1), produceValue) Then
                        totalproduce += produceValue ' Add the value to the total
                    End If


                    Dim status As String = "" ' Set a value for status

                    If Not reader.IsDBNull(6) Then

                        txtstatus.Text = reader.GetString(6) ' Display the value if it matches status
                    Else
                        ' Handle the case where the value is NULL.
                        txtstatus.Text = ""
                    End If


                    If String.IsNullOrEmpty(txtstatus.Text) OrElse txtstatus.Text.Trim() = "" Then
                        btnpatrol.Visible = True
                    Else
                        btnpatrol.Visible = False
                    End If


                    Dim item As New ListViewItem(reader.GetString(2)) ' Assuming the first column is a string

                    ' Assuming the second column is a numeric value
                    Dim quantity As Decimal
                    If Decimal.TryParse(reader.GetString(3), quantity) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(quantity.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim unit As Decimal
                    If Decimal.TryParse(reader.GetString(4), unit) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(unit.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If

                    Dim totalcost As Decimal
                    If Decimal.TryParse(reader.GetString(5), totalcost) Then
                        ' Format the numeric value as money and add it as a subitem
                        item.SubItems.Add(totalcost.ToString("N"))
                    Else
                        ' Handle invalid numeric value
                        item.SubItems.Add("Invalid Value")
                    End If
                    ListView3.Items.Add(item)
                End While
            End Using
        End Using
    End Sub



    Private Sub btnreplant_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.planted = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value2;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@value1", txtplanted.Text)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value2", quarter12)
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful.")
                    Else
                        MessageBox.Show("No records updated.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        start2()

        btnreplant.Visible = False
    End Sub

    Private Sub btnpatrol_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.status = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value2 ;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@value1", txtstatus.Text)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value2", quarter12)
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful.")
                    Else
                        MessageBox.Show("No records updated.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        start3()
        btnpatrol.Visible = False
    End Sub


    Private Sub AddSurvivalRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSurvivalRateToolStripMenuItem.Click
        survival_rate_year2.Show(maindash)
        Me.Hide()
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

        If Not String.IsNullOrEmpty(txtacomm.Text) Then
            value1 = 50
        Else

            ' If the TextBox is empty, you can set the variable to a different value or handle it as needed.
        End If

        Dim value2 As Decimal
        If Not String.IsNullOrEmpty(txtcolor.Text) Then
            value2 = 50
        Else
            ' If the TextBox is empty, you can set the variable to a different value or handle it as needed.
        End If

        If Not String.IsNullOrEmpty(txtcolor.Text) OrElse Not String.IsNullOrEmpty(txtacomm.Text) Then
            Dim percentage As Double = (value1 / value2) * 100
            accomplished += value1 + value2
            progressresult = percentage
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim currentProgress As Integer = ProgressBar2.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult2 Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar2.Increment(1)

            ' Update the label to display the current percentage
            progress2.Text = ProgressBar2.Value.ToString() & "%"
            txtprogress2.Text = "Accomplished"
        Else
            ' Stop the timer when the progress reaches 90%
            Timer2.Stop()


        End If

        percentage2 += 1 ' Adjust the increment value to control the speed of progress

        ' Limit the progress to 100%
        If percentage2 >= progressresult2 Then
            percentage2 = progressresult2 ' Set the percentage to 100%
            Timer2.Stop() ' Stop the Timer
        End If

        ' Redraw the circular progress bar
        PictureBox2.Invalidate()

        ' Redraw the circular progress bar
        PictureBox2.Invalidate()
    End Sub

    Dim percentage2 As Double = 0.0

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

        If Not String.IsNullOrEmpty(txtplanted.Text) Then
            value1 = 100

            Dim percentage As Double = (value1 / value1) * 100
            accomplished += value1
            ' Display the result in a message box
            progressresult2 = percentage
        Else

        End If



        ' Calculate the percentage



    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim currentProgress As Integer = ProgressBar3.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult3 Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar3.Increment(1)

            ' Update the label to display the current percentage
            progress3.Text = ProgressBar3.Value.ToString() & "%"
            txtprogress3.Text = "Accomplished"
        Else
            ' Stop the timer when the progress reaches 90%
            Timer3.Stop()


        End If

        percentage3 += 1 ' Adjust the increment value to control the speed of progress

        ' Limit the progress to 100%
        If percentage3 >= progressresult3 Then
            percentage3 = progressresult3 ' Set the percentage to 100%
            Timer3.Stop() ' Stop the Timer
        End If

        ' Redraw the circular progress bar
        PictureBox3.Invalidate()

        ' Redraw the circular progress bar
        PictureBox3.Invalidate()
    End Sub

    Dim percentage3 As Double = 0.0

    Private Sub PictureBox3_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox3.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, PictureBox3.Width - 20, PictureBox3.Height - 20) ' Adjust the size and position
        Dim center As New Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2)

        ' Create a custom gradient background with a system color
        Dim startColor As Color = SystemColors.GradientActiveCaption
        Dim endColor As Color = SystemColors.GradientActiveCaption
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(rect, startColor, endColor, Drawing2D.LinearGradientMode.ForwardDiagonal)

        ' Fill the background with the gradient brush
        g.FillEllipse(gradientBrush, rect)

        ' Calculate the sweep angle based on the percentage
        Dim startAngle As Integer = -90 ' Start angle (12 o'clock position)
        Dim sweepAngle As Integer = CInt(percentage3 * 3.6) ' Convert percentage to degrees
        Dim progressColor As New Pen(Color.Green, 5) ' Adjust color and width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub

    Public Sub start3()
        Timer3.Start()


        Dim value1 As Decimal

        If Not String.IsNullOrEmpty(txtstatus.Text) Then
            value1 = 100
            Dim percentage As Double = (value1 / value1) * 100

            ' Display the result in a message box
            progressresult3 = percentage
        Else

        End If



        ' Calculate the percentage



    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim currentProgress As Integer = ProgressBar4.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult4 Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar4.Increment(1)

            ' Update the label to display the current percentage
            progress4.Text = ProgressBar4.Value.ToString() & "%"
            txtprogress4.Text = "Survival rating"
        Else
            ' Stop the timer when the progress reaches 90%
            Timer4.Stop()


        End If

        percentage4 += 1 ' Adjust the increment value to control the speed of progress

        ' Limit the progress to 100%
        If percentage4 >= progressresult4 Then
            percentage4 = progressresult4 ' Set the percentage to 100%
            Timer4.Stop() ' Stop the Timer
        End If

        ' Redraw the circular progress bar
        PictureBox4.Invalidate()

        ' Redraw the circular progress bar
        PictureBox4.Invalidate()
    End Sub

    Dim percentage4 As Double = 0.0

    Private Sub PictureBox4_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox4.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, PictureBox4.Width - 20, PictureBox4.Height - 20) ' Adjust the size and position
        Dim center As New Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2)

        ' Create a custom gradient background with a system color
        Dim startColor As Color = SystemColors.GradientActiveCaption
        Dim endColor As Color = SystemColors.GradientActiveCaption
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(rect, startColor, endColor, Drawing2D.LinearGradientMode.ForwardDiagonal)

        ' Fill the background with the gradient brush
        g.FillEllipse(gradientBrush, rect)

        ' Calculate the sweep angle based on the percentage
        Dim startAngle As Integer = -90 ' Start angle (12 o'clock position)
        Dim sweepAngle As Integer = CInt(percentage4 * 3.6) ' Convert percentage to degrees
        Dim progressColor As New Pen(Color.Green, 5) ' Adjust color and width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub

    Public Sub start4()
        Timer4.Start()

        survivalrating()

        Dim value1 As Decimal

        If Not String.IsNullOrEmpty(txtstatus.Text) Then
            value1 = survival
            progressresult4 = value1

            accomplished += value1
        Else
            ' If the TextBox is empty, you can set the variable to a different value or handle it as needed.
        End If

        ' Calculate the percentage


        ' Display the result in a message box


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        year2_remark.Show(maindash)
        Me.Hide()
    End Sub




    Public Sub remark()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            Dim query As String = "SELECT remarks_id, remark FROM year2_remarks WHERE unique_code = @value AND quarter_code = @value1 AND filter_code = @value2;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)
            command.Parameters.AddWithValue("@value1", quartercode)
            command.Parameters.AddWithValue("@value2", quarter12)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    If Not reader.IsDBNull(0) Then
                        txtreid.Text = reader.GetString("remarks_id")
                        txtremarks.Text = reader.GetString("remark").ToString ' Correct the column name to "remark"
                        ToolStripMenuItem1.Visible = False
                        txtremarks.ReadOnly = True
                        btnreadd.Visible = False
                    End If
                Else
                    btnreadd.Visible = True
                    ToolStripMenuItem1.Visible = True

                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Year2_dashboard.Close()
        With Year2_dashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(Year2_dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub



    Public Sub Datagridloadrwrs()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t1.quarter_code, t2.year2_data_id, t2.commodity, t2.quantity, t2.unit, t2.total_cost , t2.accomplished, t2.color " &
                     "FROM year2nd_inspection_date AS t1 " &
                     "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            DataGridView1.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()

                DataGridView1.ColumnCount = 5
                DataGridView1.Columns(0).Name = "ID"
                DataGridView1.Columns(1).Name = "Commodity"
                DataGridView1.Columns(2).Name = "Quantity"
                DataGridView1.Columns(3).Name = "Unit"
                DataGridView1.Columns(4).Name = "Totalcost"

                DataGridView1.Columns(0).Visible = False
                ' Set DataGridView properties


                ' Populate the DataGridView
                While reader.Read()

                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    Dim quantity As Decimal
                    Dim unit As Decimal
                    Dim totalcost As Decimal

                    row.Cells(0).Value = reader.GetString("year2_data_id")
                    row.Cells(1).Value = reader.GetString("commodity")

                    If Decimal.TryParse(reader.GetString(5), quantity) Then
                        row.Cells(2).Value = quantity.ToString("N")
                    Else
                        row.Cells(2).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(6), unit) Then
                        row.Cells(3).Value = unit.ToString("N")
                    Else
                        row.Cells(3).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(7), totalcost) Then
                        row.Cells(4).Value = totalcost.ToString("N")
                    Else
                        row.Cells(4).Value = "Invalid Value"
                    End If



                    DataGridView1.Rows.Add(row)
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = If(DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtact.Text = If(DataGridView1.Item("Commodity", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Commodity", DataGridView1.CurrentRow.Index).Value.ToString(), "")
        txtqty.Text = If(DataGridView1.Item("Quantity", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Quantity", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtunit.Text = If(DataGridView1.Item("Unit", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Unit", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txttotalcost.Text = If(DataGridView1.Item("Totalcost", DataGridView1.CurrentRow.Index).Value IsNot Nothing, DataGridView1.Item("Totalcost", DataGridView1.CurrentRow.Index).Value.ToString().Replace(",", ""), "")

    End Sub

    Public Sub updatedata()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtact.Text = "" Or txtunit.Text = "" Or txttotalcost.Text = "" Or txtqty.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_data_tbl SET commodity = @Value2, quantity = @Value3, unit = @Value4, total_cost = @Value5 WHERE year2_data_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtid.Text)
                    command.Parameters.AddWithValue("@Value2", txtact.Text)
                    command.Parameters.AddWithValue("@Value3", txtqty.Text)
                    command.Parameters.AddWithValue("@Value4", txtunit.Text)
                    command.Parameters.AddWithValue("@Value5", txttotalcost.Text)

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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        updatedata()
        Datagridloadrwrs()
        btnedit.Visible = True
        txtact.ReadOnly = True
        txttotalcost.ReadOnly = True
        txtunit.ReadOnly = True
        txtqty.ReadOnly = True
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
                    Dim deleteQuery As String = "DELETE FROM year2nd_data_tbl WHERE year2_data_id = @Value1"
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
                txtid.Clear()
                txtreplantingact.Clear()
                txtreplantingtotalcost.Clear()
                txtreplantingunit.Clear()
                txtreplantingqty.Clear()
            End If
        End If
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        deleteData()
        Datagridloadrwrs()
        btnedit.Visible = True
        txtact.ReadOnly = True
        txttotalcost.ReadOnly = True
        txtunit.ReadOnly = True
        txtqty.ReadOnly = True
    End Sub

    Private Sub btnrwrs_Click(sender As Object, e As EventArgs) Handles btnrwrs.Click
        If String.IsNullOrEmpty(txtacomm.Text) OrElse String.IsNullOrEmpty(txtcolor.Text) Then
            MessageBox.Show("Please complete all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.accomplished = @value1, t2.color = @value2 " & ' Remove the extra comma here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value3;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@value1", txtacomm.Text)
                command.Parameters.AddWithValue("@value2", txtcolor.Text)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value3", quarter12)
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful.")
                    Else
                        MessageBox.Show("No records updated.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        start()
        btnrwrs.Visible = False
    End Sub

    Private Sub btneditrwrs_Click(sender As Object, e As EventArgs) Handles btneditrwrs.Click
        txtacomm.ReadOnly = False
        txtcolor.ReadOnly = False
        btneditrwrs.Visible = False

    End Sub

    Public Sub updaterwrs()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtacomm.Text = "" Or txtcolor.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.accomplished = @value1, t2.color = @value2 " & ' Remove the extra comma here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value3;"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", txtacomm.Text)
                    command.Parameters.AddWithValue("@value2", txtcolor.Text)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value3", quarter12)
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
            btneditrwrs.Visible = True
        End If
    End Sub

    Private Sub btnsaverwrs_Click(sender As Object, e As EventArgs) Handles btnsaverwrs.Click
        updaterwrs()
        Datagridloadrwrs()
        txtplanted.ReadOnly = True
    End Sub


    Private Sub deleterwrs()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)



        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user confirms the deletion, proceed with the deletion operation
        If result = DialogResult.Yes Then
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.accomplished = @value1, t2.color = @value2 " & ' Remove the extra comma here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value3;"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", DBNull.Value)
                    command.Parameters.AddWithValue("@value2", DBNull.Value)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value3", quarter12)
                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
            ResetLoadingAnimation1()
            btnrwrs.Visible = True
            txtacomm.Clear()
            txtcolor.Clear()
        End If

    End Sub

    Private Sub btndeleterwrs_Click(sender As Object, e As EventArgs) Handles btndeleterwrs.Click
        deleterwrs()
        Datagridloadrwrs()
        txtacomm.ReadOnly = False
        txtcolor.ReadOnly = False
    End Sub

    Public Sub Datagridloadreplanting()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t1.quarter_code, t2.year2_data_id, t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.planted " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            DataGridView2.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()

                DataGridView2.ColumnCount = 5
                DataGridView2.Columns(0).Name = "ID"
                DataGridView2.Columns(1).Name = "Commodity"
                DataGridView2.Columns(2).Name = "Quantity"
                DataGridView2.Columns(3).Name = "Unit"
                DataGridView2.Columns(4).Name = "Totalcost"

                DataGridView2.Columns(0).Visible = False
                ' Set DataGridView properties


                ' Populate the DataGridView
                While reader.Read()

                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView2)

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    Dim quantity As Decimal
                    Dim unit As Decimal
                    Dim totalcost As Decimal

                    row.Cells(0).Value = reader.GetString("year2_data_id")
                    row.Cells(1).Value = reader.GetString("commodity")

                    If Decimal.TryParse(reader.GetString(5), quantity) Then
                        row.Cells(2).Value = quantity.ToString("N")
                    Else
                        row.Cells(2).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(6), unit) Then
                        row.Cells(3).Value = unit.ToString("N")
                    Else
                        row.Cells(3).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(7), totalcost) Then
                        row.Cells(4).Value = totalcost.ToString("N")
                    Else
                        row.Cells(4).Value = "Invalid Value"
                    End If

                    DataGridView2.Rows.Add(row)
                End While
            End Using
        End Using
    End Sub


    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        txtidreplanting.Text = If(DataGridView2.Item("ID", DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item("ID", DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtreplantingact.Text = If(DataGridView2.Item("Commodity", DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item("Commodity", DataGridView2.CurrentRow.Index).Value.ToString(), "")
        txtreplantingqty.Text = If(DataGridView2.Item("Quantity", DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item("Quantity", DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtreplantingunit.Text = If(DataGridView2.Item("Unit", DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item("Unit", DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtreplantingtotalcost.Text = If(DataGridView2.Item("Totalcost", DataGridView2.CurrentRow.Index).Value IsNot Nothing, DataGridView2.Item("Totalcost", DataGridView2.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
    End Sub


    Private Sub btneditreplanting_Click(sender As Object, e As EventArgs) Handles btneditreplanting.Click
        If String.IsNullOrEmpty(txtidreplanting.Text) Then
            MessageBox.Show("Please choose a data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        btneditreplanting.Visible = False
        txtreplantingact.ReadOnly = False
        txtreplantingtotalcost.ReadOnly = False
        txtreplantingunit.ReadOnly = False
        txtreplantingqty.ReadOnly = False
    End Sub

    Public Sub updatedatareplanting()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtreplantingact.Text = "" Or txtreplantingunit.Text = "" Or txtreplantingtotalcost.Text = "" Or txtreplantingqty.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_data_tbl SET commodity = @Value2, quantity = @Value3, unit = @Value4, total_cost = @Value5 WHERE year2_data_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtidreplanting.Text)
                    command.Parameters.AddWithValue("@Value2", txtreplantingact.Text)
                    command.Parameters.AddWithValue("@Value3", txtreplantingqty.Text)
                    command.Parameters.AddWithValue("@Value4", txtreplantingunit.Text)
                    command.Parameters.AddWithValue("@Value5", txtreplantingtotalcost.Text)
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
            btneditreplanting.Visible = True
        End If
    End Sub

    Private Sub btnsavereplanting_Click(sender As Object, e As EventArgs) Handles btnsavereplanting.Click
        updatedatareplanting()
        Datagridloadreplanting()
        btneditreplanting.Visible = True
        txtreplantingact.ReadOnly = True
        txtreplantingtotalcost.ReadOnly = True
        txtreplantingunit.ReadOnly = True
        txtreplantingqty.ReadOnly = True
    End Sub


    Public Sub deleteDatareplanting()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If txtidreplanting.Text = "" Then
            MsgBox("Please select a record to delete!", MsgBoxStyle.Exclamation, "Warning")
        Else
            ' Display a confirmation dialog with a danger icon
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, proceed with the deletion operation
            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    ' Delete record from plantation_estab_tbl
                    Dim deleteQuery As String = "DELETE FROM year2nd_data_tbl WHERE year2_data_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtidreplanting.Text)

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
                btneditreplanting.Visible = True
                txtidreplanting.Clear()
                txtreplantingact.Clear()
                txtreplantingtotalcost.Clear()
                txtreplantingunit.Clear()
                txtreplantingqty.Clear()
            End If
        End If
    End Sub

    Private Sub btndeletereplanting_Click(sender As Object, e As EventArgs) Handles btndeletereplanting.Click
        deleteDatareplanting()
        Datagridloadreplanting()
        btneditreplanting.Visible = True
        txtreplantingact.ReadOnly = True
        txtreplantingtotalcost.ReadOnly = True
        txtreplantingunit.ReadOnly = True
        txtreplantingqty.ReadOnly = True
    End Sub

    Private Sub btnreplant_Click_1(sender As Object, e As EventArgs) Handles btnreplant.Click
        ' Check if the required fields are filled
        If String.IsNullOrEmpty(txtplanted.Text) Or String.IsNullOrEmpty(uniquecodeloading) Or String.IsNullOrEmpty(quarter12) Then
            MessageBox.Show("Please complete all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                                "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                                "SET t2.planted = @value1 " &
                                "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value2;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@value1", txtplanted.Text)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value2", quarter12)
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful.")
                    Else
                        MessageBox.Show("No records updated.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        start2()
        btnreplant.Visible = False
    End Sub


    Private Sub btneditplanted_Click(sender As Object, e As EventArgs) Handles btneditplanted.Click
        txtplanted.ReadOnly = False
        btneditplanted.Visible = False

    End Sub

    Public Sub updateplanted()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtplanted.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.planted = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value2 ;"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", txtplanted.Text)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value2", quarter12)
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
            btneditplanted.Visible = True
        End If
    End Sub

    Private Sub btnsaveplanted_Click(sender As Object, e As EventArgs) Handles btnsaveplanted.Click
        updateplanted()
        Datagridloadreplanting()
        txtplanted.ReadOnly = True
    End Sub

    Private Sub deleteplanted()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)



        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user confirms the deletion, proceed with the deletion operation
        If result = DialogResult.Yes Then
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.planted = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value2 ;"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", DBNull.Value)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value2", quarter12)
                    command.ExecuteNonQuery()
                End Using

                ' Display a success message with an information icon
                MessageBox.Show("Data successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            Finally
                ' Ensure the connection is closed, even in the case of an exception
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
            ResetLoadingAnimation2()
            btnreplant.Visible = True
            txtplanted.Clear()
        End If

    End Sub

    Private Sub btndeleteplanted_Click(sender As Object, e As EventArgs) Handles btndeleteplanted.Click
        deleteplanted()
        Datagridloadreplanting()
        txtplanted.ReadOnly = False
    End Sub


    Public Sub Datagridloadpatrol()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT t1.date_request, t1.date_inspection, t1.quarter_code, t2.year2_data_id, t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.planted " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", uniquecodeloading)  ' Replace some_value with your filter value
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            DataGridView3.Columns.Clear()

            Using reader As MySqlDataReader = command.ExecuteReader()

                DataGridView3.ColumnCount = 5
                DataGridView3.Columns(0).Name = "ID"
                DataGridView3.Columns(1).Name = "Commodity"
                DataGridView3.Columns(2).Name = "Quantity"
                DataGridView3.Columns(3).Name = "Unit"
                DataGridView3.Columns(4).Name = "Totalcost"

                DataGridView3.Columns(0).Visible = False
                ' Set DataGridView properties


                ' Populate the DataGridView
                While reader.Read()

                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView3)

                    Dim datetic As Date = Convert.ToDateTime(reader("date_inspection").ToString)
                    Dim datestake As Date = Convert.ToDateTime(reader("date_request"))
                    txtboxrequest.Text = datestake.ToString("MMMM dd, yyyy")
                    txtboxinspection.Text = datetic.ToString("MMMM dd, yyyy")

                    Dim quantity As Decimal
                    Dim unit As Decimal
                    Dim totalcost As Decimal

                    row.Cells(0).Value = reader.GetString("year2_data_id")
                    row.Cells(1).Value = reader.GetString("commodity")

                    If Decimal.TryParse(reader.GetString(5), quantity) Then
                        row.Cells(2).Value = quantity.ToString("N")
                    Else
                        row.Cells(2).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(6), unit) Then
                        row.Cells(3).Value = unit.ToString("N")
                    Else
                        row.Cells(3).Value = "Invalid Value"
                    End If

                    If Decimal.TryParse(reader.GetString(7), totalcost) Then
                        row.Cells(4).Value = totalcost.ToString("N")
                    Else
                        row.Cells(4).Value = "Invalid Value"
                    End If

                    DataGridView3.Rows.Add(row)
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        txtidpatrol.Text = If(DataGridView3.Item("ID", DataGridView3.CurrentRow.Index).Value IsNot Nothing, DataGridView3.Item("ID", DataGridView3.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtactpatrol.Text = If(DataGridView3.Item("Commodity", DataGridView3.CurrentRow.Index).Value IsNot Nothing, DataGridView3.Item("Commodity", DataGridView3.CurrentRow.Index).Value.ToString(), "")
        txtqtypatrol.Text = If(DataGridView3.Item("Quantity", DataGridView3.CurrentRow.Index).Value IsNot Nothing, DataGridView3.Item("Quantity", DataGridView3.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txtunitpatrol.Text = If(DataGridView3.Item("Unit", DataGridView3.CurrentRow.Index).Value IsNot Nothing, DataGridView3.Item("Unit", DataGridView3.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
        txttotalcostpatrol.Text = If(DataGridView3.Item("Totalcost", DataGridView3.CurrentRow.Index).Value IsNot Nothing, DataGridView3.Item("Totalcost", DataGridView3.CurrentRow.Index).Value.ToString().Replace(",", ""), "")
    End Sub

    Private Sub btneditpatrol_Click(sender As Object, e As EventArgs) Handles btneditpatrol.Click
        If String.IsNullOrEmpty(txtidpatrol.Text) Then
            MessageBox.Show("Please choose a data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        btneditpatrol.Visible = False
        txtactpatrol.ReadOnly = False
        txttotalcostpatrol.ReadOnly = False
        txtunitpatrol.ReadOnly = False
        txtqtypatrol.ReadOnly = False
    End Sub

    Public Sub updatedatapatrol()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtactpatrol.Text = "" Or txtunitpatrol.Text = "" Or txttotalcostpatrol.Text = "" Or txtqtypatrol.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_data_tbl SET commodity = @Value2, quantity = @Value3, unit = @Value4, total_cost = @Value5 WHERE year2_data_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtidpatrol.Text)
                    command.Parameters.AddWithValue("@Value2", txtactpatrol.Text)
                    command.Parameters.AddWithValue("@Value3", txtqtypatrol.Text)
                    command.Parameters.AddWithValue("@Value4", txtunitpatrol.Text)
                    command.Parameters.AddWithValue("@Value5", txttotalcostpatrol.Text)
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
            btneditpatrol.Visible = True
        End If
    End Sub

    Private Sub btnsavepatrol_Click(sender As Object, e As EventArgs) Handles btnsavepatrol.Click
        updatedatapatrol()
        Datagridloadpatrol()
        btneditpatrol.Visible = True
        txtactpatrol.ReadOnly = True
        txttotalcostpatrol.ReadOnly = True
        txtunitpatrol.ReadOnly = True
        txtqtypatrol.ReadOnly = True
    End Sub


    Public Sub deleteDatapatrol()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If txtidpatrol.Text = "" Then
            MsgBox("Please select a record to delete!", MsgBoxStyle.Exclamation, "Warning")
        Else
            ' Display a confirmation dialog with a danger icon
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, proceed with the deletion operation
            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    ' Delete record from plantation_estab_tbl
                    Dim deleteQuery As String = "DELETE FROM year2nd_data_tbl WHERE year2_data_id = @Value1"
                    Using command As New MySqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@Value1", txtidpatrol.Text)

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
                btneditpatrol.Visible = True
                txtidpatrol.Clear()
                txttotalcostpatrol.Clear()
                txtunitpatrol.Clear()
                txtqtypatrol.Clear()
            End If
        End If
    End Sub

    Private Sub btndeletepatrol_Click(sender As Object, e As EventArgs) Handles btndeletepatrol.Click
        deleteDatapatrol()
        Datagridloadpatrol()
        btneditpatrol.Visible = True
        txtactpatrol.ReadOnly = True
        txttotalcostpatrol.ReadOnly = True
        txtunitpatrol.ReadOnly = True
        txtqtypatrol.ReadOnly = True
    End Sub

    Private Sub btnpatrol_Click_1(sender As Object, e As EventArgs) Handles btnpatrol.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        If (txtstatus.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.status = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value2 ;"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", txtstatus.Text)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value2", quarter12)
                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Added successfully.")
                        Else
                            MessageBox.Show("No records updated.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using

        End If
        start3()
        txtstatus.ReadOnly = True
        btnpatrol.Visible = False
        btneditstatus.Visible = True
    End Sub

    Private Sub btneditstatus_Click(sender As Object, e As EventArgs) Handles btneditstatus.Click
        txtstatus.ReadOnly = False
        btneditstatus.Visible = False

    End Sub

    Public Sub updatestatus()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtstatus.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.status = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value2 ;"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@value1", txtstatus.Text)
                    command.Parameters.AddWithValue("@value", uniquecodeloading)
                    command.Parameters.AddWithValue("@value2", quarter12)
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
            btneditstatus.Visible = True
        End If
    End Sub

    Private Sub btnsavestatus_Click(sender As Object, e As EventArgs) Handles btnsavestatus.Click
        updatestatus()
        Datagridloadpatrol()
        txtstatus.ReadOnly = True
    End Sub


    Private Sub deletestatus()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtstatus.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' If the user confirms the deletion, proceed with the deletion operation
            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    ' Update plantation_estab_tbl
                    Dim updateQuery As String = "UPDATE year2nd_inspection_date AS t1 " &
                               "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                               "SET t2.status = @value1 " & ' Add a space here
                               "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value2 ;"
                    Using command As New MySqlCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@value1", DBNull.Value)
                        command.Parameters.AddWithValue("@value", uniquecodeloading)
                        command.Parameters.AddWithValue("@value2", quarter12)
                        command.ExecuteNonQuery()
                    End Using

                    ' Display a success message with an information icon
                    MessageBox.Show("Data successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.ToString())
                Finally
                    ' Ensure the connection is closed, even in the case of an exception
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
                ResetLoadingAnimation3()
                btnpatrol.Visible = True
                txtstatus.Clear()
            End If
        End If
    End Sub

    Private Sub btndeletestatus_Click(sender As Object, e As EventArgs) Handles btndeletestatus.Click
        deletestatus()
        Datagridloadpatrol()
        txtstatus.ReadOnly = False
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
            Dim updateQuery As String = "UPDATE year2_remarks SET remark = @Value1 WHERE remarks_id = @Value2"
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
        remark()
    End Sub


    Public Sub deleteRemarks()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try
            connection.Open()
            ' Delete remark
            Dim deleteQuery As String = "DELETE FROM year2_remarks WHERE remarks_id = @Value1"
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
        txtremarks.ReadOnly = False
        txtremarks.Clear()
        txtreid.Clear()
        btnreadd.Visible = True
    End Sub

    Private Sub btnredelete_Click(sender As Object, e As EventArgs) Handles btnredelete.Click
        deleteRemarks()
        remark()
    End Sub

    Private Sub btnreadd_Click(sender As Object, e As EventArgs) Handles btnreadd.Click
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        connection.Open()

        Try
            If txtremarks.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO year2_remarks (unique_code, quarter_code, remark, filter_code) VALUES (@Value1, @Value2, @Value3, @Value4)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecodeloading)
                command.Parameters.AddWithValue("@Value2", quartercode)
                command.Parameters.AddWithValue("@Value3", txtremarks.Text)
                command.Parameters.AddWithValue("@Value4", quarter12)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                remark()
                btnreadd.Visible = False

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub survivalrating()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT survival_id, survival_rate FROM survival_rate_year2 WHERE unique_code = @value AND filter_code = @value1;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)
            command.Parameters.AddWithValue("@value1", quarter12)
            connection.Open()

            ' Initialize variables for total accomplishment and total rows


            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(1) Then
                        Dim accomplishment As Decimal = reader.GetDecimal(1)
                        survival = accomplishment
                        Dim survival_rate As String = "Survival Rate"
                        txtsurvival.Text = accomplishment
                        AddSurvivalRateToolStripMenuItem.Visible = False
                    Else
                        AddSurvivalRateToolStripMenuItem.Visible = True

                    End If

                    txtidsurvival.Text = reader.GetString("survival_id")
                End While

                ' Calculate the overall percentage

            End Using
        End Using
    End Sub

    Private Sub btneditsurvival_Click(sender As Object, e As EventArgs) Handles btneditsurvival.Click
        btneditsurvival.Visible = False
        txtsurvival.ReadOnly = False
    End Sub

    Private Sub updatesurvival()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        If (txtsurvival.Text = "") Then
            MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
        Else
            Try
                connection.Open()

                ' Update plantation_estab_tbl
                Dim updateQuery As String = "UPDATE survival_rate_year2 SET survival_rate = @Value2 WHERE survival_id = @Value1"
                Using command As New MySqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Value1", txtidsurvival.Text)
                    command.Parameters.AddWithValue("@Value2", txtsurvival.Text)

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
            ResetLoadingAnimation4()
            btneditsurvival.Visible = True
            txtsurvival.ReadOnly = True
        End If
    End Sub

    Private Sub btnsavesurvival_Click(sender As Object, e As EventArgs) Handles btnsavesurvival.Click
        updatesurvival()
        start4()
    End Sub

    Private Sub deletesurvival()
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
                    Dim deleteQuery As String = "DELETE FROM survival_rate_year2 WHERE survival_id = @Value1"
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
                AddSurvivalRateToolStripMenuItem.Visible = True
                ResetLoadingAnimation4()
                btneditsurvival.Visible = True
                txtsurvival.ReadOnly = False
                txtidsurvival.Clear()
                txtsurvival.Clear()
            End If
        End If
    End Sub

    Private Sub btnsurvivaldelete_Click(sender As Object, e As EventArgs) Handles btnsurvivaldelete.Click
        deletesurvival()
        survivalrating()
    End Sub


    Public Sub ResetLoadingAnimation1()
        Timer1.Stop()
        ProgressBar1.Value = 0
        percentage = 0.0
        progressresult = 0.0
        progress.Text = "0%"
        PictureBox1.Invalidate()
    End Sub

    Public Sub ResetLoadingAnimation2()
        Timer2.Stop()
        ProgressBar2.Value = 0
        percentage2 = 0.0
        progressresult2 = 0.0
        progress2.Text = "0%"
        PictureBox2.Invalidate()
    End Sub

    Public Sub ResetLoadingAnimation3()
        Timer3.Stop()
        ProgressBar3.Value = 0
        percentage3 = 0.0
        progressresult3 = 0.0
        progress3.Text = "0%"
        PictureBox3.Invalidate()
    End Sub

    Public Sub ResetLoadingAnimation4()
        Timer4.Stop()
        ProgressBar4.Value = 0
        percentage4 = 0.0
        progressresult4 = 0.0
        progress4.Text = "0%"
        survival = 0.0
        PictureBox4.Invalidate()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If String.IsNullOrEmpty(txtid.Text) Then
            MessageBox.Show("Please choose a data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        btnedit.Visible = False
        txtact.ReadOnly = False
        txttotalcost.ReadOnly = False
        txtunit.ReadOnly = False
        txtqty.ReadOnly = False
    End Sub


    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
    Public Sub LoadReportquarter4()
        Dim rptDSDetails As ReportDataSource
        Dim rptDSReplanting As ReportDataSource
        Dim rptDSPatrol As ReportDataSource
        Dim rptDSSurvival As ReportDataSource

        Try
            year2_4qaurter_Report.ReportViewer1.RefreshReport()

            ' Load report files
            With year2_4qaurter_Report.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\year2_4quarter_MP.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' Query for MaintenanceProDetails
                Dim queryDetails As String = "SELECT t1.date_request, t1.date_inspection, t1.quarter_code, t2.commodity, t2.quantity, t2.unit, t2.total_cost , t2.accomplished, t2.color " &
                     "FROM year2nd_inspection_date AS t1 " &
                     "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value AND t2.type_code = 'rwrs' AND t2.filter_code = @value1;"
                Dim commandDetails As New MySqlCommand(queryDetails, connection)
                commandDetails.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)
                commandDetails.Parameters.AddWithValue("@value1", quarter12)


                ' Fill data into a DataSet for MaintenanceProDetails
                Dim dsDetails As New DataSet
                Dim daDetails As New MySqlDataAdapter(commandDetails)
                daDetails.Fill(dsDetails, "quarter4dbrwrs")

                ' Query for replanting
                Dim queryreplanting As String = "SELECT t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.planted " &
                         "FROM year2nd_inspection_date AS t1 " &
                         "INNER JOIN year2nd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                         "WHERE t2.unique_code = @value AND t2.type_code = 'replant' AND t2.filter_code = @value1;"
                Dim commandreplanting As New MySqlCommand(queryreplanting, connection)
                commandreplanting.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)
                commandreplanting.Parameters.AddWithValue("@value1", quarter12)

                ' Fill data into a DataSet for Replanting
                Dim dsReplanting As New DataSet
                Dim daReplanting As New MySqlDataAdapter(commandreplanting)
                daReplanting.Fill(dsReplanting, "quarter4dbreplanting")

                ' Query for patrol
                Dim querypatrol As String = "SELECT t2.commodity, t2.quantity, t2.unit, t2.total_cost, t2.planted, t2.status " &
                            "FROM year2nd_data_tbl t2 " &
                            "INNER JOIN (" &
                            "    SELECT DISTINCT t2_inner.status " &
                            "    FROM year2nd_inspection_date t1 " &
                            "    INNER JOIN year2nd_data_tbl t2_inner ON t1.quarter_code = t2_inner.quarter_code " &
                            "    WHERE t2_inner.unique_code = @value AND t2_inner.type_code = 'patrol' AND t2_inner.filter_code = @value1" &
                            ") AS distinct_statuses ON t2.status = distinct_statuses.status " &
                            "WHERE t2.unique_code = @value AND t2.type_code = 'patrol' AND t2.filter_code = @value1;"

                Dim commandpatrol As New MySqlCommand(querypatrol, connection)
                commandpatrol.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)
                commandpatrol.Parameters.AddWithValue("@value1", quarter12)

                ' Fill data into a DataSet for MaintenanceProSurvivalRate
                Dim dsPatrol As New DataSet
                Dim daPatrol As New MySqlDataAdapter(commandpatrol)
                daPatrol.Fill(dsPatrol, "quarter4dbpatrol")



                ' Query for  survival
                Dim querysurvival As String = "SELECT CONCAT(survival_rate, '%') AS survival_rate " &
                              "FROM survival_rate_year2 " &
                              "WHERE unique_code = @value AND filter_code = @value1;"
                Dim commandsurvival As New MySqlCommand(querysurvival, connection)
                commandsurvival.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)
                commandsurvival.Parameters.AddWithValue("@value1", quarter12)

                ' Fill data into a DataSet for MaintenanceProSurvivalRate
                Dim dsSurvival As New DataSet
                Dim daSurvival As New MySqlDataAdapter(commandsurvival)
                daSurvival.Fill(dsSurvival, "quarter4dbsurvival")


                ' Close the connection
                connection.Close()



                ' Create ReportDataSources and bind them to the ReportViewer
                rptDSDetails = New ReportDataSource("quarter4DBrwrs", dsDetails.Tables("quarter4dbrwrs"))
                rptDSReplanting = New ReportDataSource("quarter4DBreplanting", dsReplanting.Tables("quarter4dbreplanting"))
                rptDSPatrol = New ReportDataSource("quarter4DBpatrol", dsPatrol.Tables("quarter4dbpatrol"))
                rptDSSurvival = New ReportDataSource("quarter4DBsurvival", dsSurvival.Tables("quarter4dbsurvival"))
                year2_4qaurter_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSDetails)
                year2_4qaurter_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSReplanting)
                year2_4qaurter_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSPatrol)
                year2_4qaurter_Report.ReportViewer1.LocalReport.DataSources.Add(rptDSSurvival)
            End Using

            ' Set display mode and zoom level
            year2_4qaurter_Report.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            year2_4qaurter_Report.ReportViewer1.ZoomMode = ZoomMode.Percent
            year2_4qaurter_Report.ReportViewer1.ZoomPercent = 30

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

            If String.IsNullOrWhiteSpace(remarks) Then
                remarks = "No remarks provided"  ' Default value if no remarks are given
            End If

            ' Specify the parameters you want to pass to the report
            Dim reportParameters As New List(Of ReportParameter)()
            reportParameters.Add(New ReportParameter("uniquecode", uniqueCodeValue))
            reportParameters.Add(New ReportParameter("org", org))
            reportParameters.Add(New ReportParameter("remarks", remarks))

            ' Set the path of the RDLC file
            year2_4qaurter_Report.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\year2_4quarter_MP.rdlc"

            ' Set the parameters to the ReportViewer control
            year2_4qaurter_Report.ReportViewer1.LocalReport.SetParameters(reportParameters)

            ' Refresh the report
            year2_4qaurter_Report.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub btnprintreport_Click(sender As Object, e As EventArgs) Handles btnprintreport.Click
        LoadReportquarter4()
        parameters()
        year2_4qaurter_Report.ShowDialog()
    End Sub

    Private Sub user()
        If personnel = 1 Then
            btndelete.Enabled = True
            btnedit.Enabled = True
            btnsave.Enabled = True

            btnreedit.Enabled = True
            btnresave.Enabled = True
            btnredelete.Enabled = True

            btneditsurvival.Enabled = True
            btnredelete.Enabled = True
            btnsavesurvival.Enabled = True


        Else
            btndelete.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = False

            btnreedit.Enabled = False
            btnresave.Enabled = False
            btnredelete.Enabled = False

            btneditsurvival.Enabled = False
            btnredelete.Enabled = False
            btnsavesurvival.Enabled = False

        End If
    End Sub
End Class
