Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class TICdashboard

    Dim progressresult As Integer
    Dim progressresult2 As Integer
    Dim progressresult3 As Integer
    Dim progressresultsr As Integer
    Public passmfpe As Double

    Dim displaypc As String



    Private Sub TICdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = uniquecode
        txtsitecode.Text = uniquecode
        txtorg.Text = ongoing_details.txtorg.Text.ToString
        LoadAccomplishmentAndPercentage()
        Displayseedproduction()
        DisplayMainprotection()
        Displaysurvivalrating()
        DisplayTIC()

        panel(Panel5)
        'displaytotalcost()
        'displayspPayment()
        'display3rmfPayment()
        'display76pePayment()
        'displayeyPayment()


        start()
        start2()
        start3()
        start4()

        projectcostbill()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        date_inspection.AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = True
        date_inspection.AddSeedlingPlantedToolStripMenuItem.Visible = False
        date_inspection.AddSeedlingProductionToolStripMenuItem.Visible = False
        date_inspection.AddSeedlingRePlantedToolStripMenuItem.Visible = False
        date_inspection.ShowDialog()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If String.IsNullOrEmpty(tic_counted.Text) OrElse tic_counted.Text.Trim() = "0.00" Then
            ' Hide the menu items in date_inspection form
            date_inspection.AddSeedlingProductionToolStripMenuItem.Visible = True
            date_inspection.AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
            date_inspection.AddSeedlingPlantedToolStripMenuItem.Visible = False
            date_inspection.AddSeedlingRePlantedToolStripMenuItem.Visible = False
            date_inspection.ShowDialog()
        Else
            closesystemMF = 1
            Seedling_pro.ShowDialog()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If String.IsNullOrEmpty(txtOverallPercentage.Text) OrElse txtOverallPercentage.Text.Trim() = "0" Then
            ' Hide the menu items in date_inspection form
            date_inspection.AddSeedlingPlantedToolStripMenuItem.Visible = True
            date_inspection.AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = True
            date_inspection.AddSeedlingRePlantedToolStripMenuItem.Visible = False
            date_inspection.AddSeedlingProductionToolStripMenuItem.Visible = False
            date_inspection.ShowDialog()
        Else
            closesystemMF = 1
            Seedling_planted.ShowDialog()
        End If




    End Sub






    Dim percentage As Double = 0.0
    Public Sub Displayseedproduction()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(tic_counted) AS total_counted FROM multispecies WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_counted")) Then
                            tic_counted.Text = "0.00" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_counted"))
                            tic_counted.Text = totalAmount.ToString("N") ' Update the TextBox
                        End If
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
            progess.Text = ProgressBar1.Value.ToString() & "%"

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

        If Decimal.TryParse(tic_counted.Text, value1) AndAlso Decimal.TryParse(ongoing_details.txtseedreq.Text, value2) Then
            ' Calculate the percentage
            Dim percentage As Double = (value1 / value2) * 100

            ' Display the result in a message box
            progressresult = percentage

        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter valid integer values in both textboxes.", "Error")
        End If


    End Sub


    Dim percentage2 As Double = 0.0

    Public Sub LoadAccomplishmentAndPercentage()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT accomplishment FROM plantation_estab_tbl WHERE unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        Dim accomplishment As Decimal = reader.GetDecimal(0)

                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    End If
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)

                ' Display the overall percentage and individual accomplishment in a TextBox

                txtOverallPercentage.Text = overallPercentage.ToString()
            End Using
        End Using
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim currentProgress As Integer = ProgressBar2.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult2 Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar2.Increment(1)

            ' Update the label to display the current percentage
            progress2.Text = ProgressBar2.Value.ToString() & "%"

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

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
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
    Public Sub start2()
        Timer2.Start()
        Dim valueplantation As Decimal


        If Decimal.TryParse(txtOverallPercentage.Text, valueplantation) Then
            ' Calculate the percentage
            Dim percentage As Double = valueplantation

            ' Display the result in a message box
            progressresult2 = percentage

        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter valid integer values in both textboxes.", "Error")
        End If
    End Sub


    Dim percentage3 As Double = 0.0

    Private Sub DisplayMainprotection()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT accomplishment FROM maintenance_tbl WHERE unique_code = @value;"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", ongoing_details.txtuniquecode.Text)

            connection.Open()

            ' Initialize variables for total accomplishment and total rows
            Dim totalAccomplishment As Decimal = 0
            Dim totalRows As Integer = 0

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        Dim accomplishment As Decimal = reader.GetDecimal(0)

                        ' Add the accomplishment to the total
                        totalAccomplishment += accomplishment
                        totalRows += 1
                    End If
                End While

                ' Calculate the overall percentage
                Dim overallPercentage As Decimal = If(totalRows > 0, totalAccomplishment / totalRows, 0)

                ' Display the overall percentage and individual accomplishment in a TextBox

                mainpro.Text = overallPercentage.ToString()
            End Using
        End Using
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim currentProgress As Integer = ProgressBar3.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresult3 Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar3.Increment(1)

            ' Update the label to display the current percentage
            progress3.Text = ProgressBar3.Value.ToString() & "%"

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
        Dim sweepAngle As Integer = CInt(percentage * 3.6) ' Convert percentage to degrees
        Dim progressColor As New Pen(Color.Green, 5) ' Adjust color and width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub

    Public Sub start3()
        Timer3.Start()
        Dim valueplantation As Decimal


        If Decimal.TryParse(mainpro.Text, valueplantation) Then
            ' Calculate the percentage
            Dim percentage As Double = valueplantation

            ' Display the result in a message box
            progressresult3 = percentage

        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter valid integer values in both textboxes.", "Error")
        End If
    End Sub

    Dim percentage4 As Double = 0.0

    Private Sub Displaysurvivalrating()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT survival_rate  FROM survival_rate_year1 WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)

                Try
                    connection.Open()

                    Dim totalSurvival As Decimal = 0
                    Dim totalRows As Integer = 0

                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        If Not reader.IsDBNull(reader.GetOrdinal("survival_rate")) Then
                            totalSurvival += reader.GetDecimal(reader.GetOrdinal("survival_rate"))
                            totalRows += 1
                        End If
                    End While

                    reader.Close()

                    ' Calculate the percentage based on the total survival and the total row count
                    Dim percentage As Decimal = If(totalRows > 0, (totalSurvival / totalRows), 0)

                    txtsr.Text = percentage.ToString("N2") ' Display the percentage with two decimal places
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim currentProgress As Integer = ProgressBar4.Value

        ' Check if the progress is less than 90%
        If currentProgress < progressresultsr Then
            ' Increment the progress (for example, increment by 1%)
            ProgressBar4.Increment(1)

            ' Update the label to display the current percentage
            progress4.Text = ProgressBar4.Value.ToString() & "%"

        Else
            ' Stop the timer when the progress reaches 90%
            Timer4.Stop()


        End If

        percentage4 += 1 ' Adjust the increment value to control the speed of progress

        ' Limit the progress to 100%
        If percentage4 >= progressresultsr Then
            percentage4 = progressresultsr ' Set the percentage to 100%
            Timer4.Stop() ' Stop the Timer
        End If

        ' Redraw the circular progress bar
        PictureBox4.Invalidate()

        ' Redraw the circular progress bar
        PictureBox4.Invalidate()
    End Sub

    Private Sub PictureBox4_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox4.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(20, 20, PictureBox4.Width - 40, PictureBox4.Height - 40) ' Adjust the size and position
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

        ' Define a color scale (hazard to good)
        Dim colors() As Color = {Color.Red, Color.Yellow, Color.Green}

        ' Determine the color based on the percentage
        Dim colorIndex As Integer = CInt((percentage4 / 100) * (colors.Length - 1))
        Dim progressColor As New Pen(colors(colorIndex), 15) ' Adjust width as needed

        ' Adjust the position of the circular arc
        g.DrawArc(progressColor, rect, startAngle, sweepAngle)
    End Sub


    Private Sub start4()
        Timer4.Start()
        Dim valuesr As Decimal


        If Decimal.TryParse(txtsr.Text, valuesr) Then
            ' Calculate the percentage
            Dim percentage As Double = valuesr

            ' Display the result in a message box
            progressresultsr = percentage

        Else
            ' Display an error message if parsing fails
            MessageBox.Show("Please enter valid integer values in both textboxes.", "Error")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If String.IsNullOrEmpty(mainpro.Text) OrElse mainpro.Text.Trim() = "0" Then
            ' Hide the menu items in date_inspection form
            date_inspection.AddSeedlingRePlantedToolStripMenuItem.Visible = True
            date_inspection.AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
            date_inspection.AddSeedlingPlantedToolStripMenuItem.Visible = False
            date_inspection.AddSeedlingProductionToolStripMenuItem.Visible = False
            date_inspection.ShowDialog()
        Else
            closesystemMF = 1
            Maintenance_Protection.ShowDialog()
        End If



    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        closesystemMF = 0
        ReadOn = 0

        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With

        FormUtilities.ClearFormControls(Me)
        Me.Close()
    End Sub







    Public Sub displaytotalcost()


        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(total_cost) AS total_cost FROM disbursement_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_cost")) Then
                            txtmf.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_cost"))
                            txtmf.Text = totalAmount.ToString("N")
                            ' Update the TextBox
                        End If


                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Public Sub displayspPayment()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(payment) AS total_payment FROM disbursement_2nd WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_payment")) Then
                            txtspPayment.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_payment"))
                            txtspPayment.Text = totalAmount.ToString("N") ' Update the TextBox
                        End If


                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub






    Public Sub display3rmfPayment()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(payment) AS total_payment FROM disbursement_3rd_mf WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_payment")) Then
                            txt3rd_mf.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_payment"))
                            txt3rd_mf.Text = totalAmount.ToString("N") ' Update the TextBox
                            passmfpe = totalAmount
                            pemf = totalAmount
                        End If


                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub





    Public Sub display76pePayment()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(payment) AS total_payment FROM disbursement_76_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_payment")) Then
                            txt76pe.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_payment"))
                            txt76pe.Text = totalAmount.ToString("N") ' Update the TextBox
                        End If


                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub






    Public Sub displayeyPayment()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM(payment) AS total_payment FROM disbursement_yearend_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ongoing_details.txtuniquecode.Text)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the "total_counted" column is DBNull.Value
                        If reader.IsDBNull(reader.GetOrdinal("total_payment")) Then
                            txtyearend.Text = "0" ' Set total_amount to zero as a string
                        Else
                            Dim totalAmount As Decimal = reader.GetDecimal(reader.GetOrdinal("total_payment"))
                            txtyearend.Text = totalAmount.ToString("N") ' Update the TextBox
                        End If


                    End If
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Private Sub projectcostbill()
        Dim uniqueCode As String = uniquecodeloading  ' Replace with the actual source of unique_code
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT SUM(total_cost_seeds) " &
                                "FROM commodity_unitcost_tbl " &
                                "WHERE unique_code = @uniqueCode;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                ' Add a parameter for unique_code
                command.Parameters.AddWithValue("@uniqueCode", uniqueCode)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Dim projectcost As Integer = Convert.ToInt32(result)
                        displaypc = projectcost.ToString

                    Else
                        displaypc = "0"
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Public Sub DisplayTIC()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) FROM inspector_details_tbl WHERE unique_code = @id;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' If count is greater than 0, the record with the given id exists.
                    tic.Text = count.ToString
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using

        ' If an error occurred, or no record was found, return false.
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        'If Not String.IsNullOrWhiteSpace(txtmf.Text) AndAlso Not txtmf.Text.Trim() = "0" AndAlso
        'Not String.IsNullOrWhiteSpace(txtspPayment.Text) AndAlso Not txtspPayment.Text.Trim() = "0" AndAlso
        ' Not String.IsNullOrWhiteSpace(txt3rd_mf.Text) AndAlso Not txt3rd_mf.Text.Trim() = "0" AndAlso
        '   Not String.IsNullOrWhiteSpace(txt76pe.Text) AndAlso Not txt76pe.Text.Trim() = "0" AndAlso
        '   Not String.IsNullOrWhiteSpace(txtyearend.Text) AndAlso Not txtyearend.Text.Trim() = "0" Then

        'MsgBox("All the payments have been paid.", MsgBoxStyle.Information, "Information")

        ' Else

        'End If
    End Sub



    Private Sub tICdashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel8.Left = (Me.Width - Panel8.Width) / 2
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub AddPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPaymentToolStripMenuItem.Click
        flexible_disbursement_frm.ShowDialog()
    End Sub

    Private Sub ViewPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPaymentToolStripMenuItem.Click
        payment_frm.ShowDialog()
    End Sub
End Class

