
Imports System.Drawing.Printing
Imports System.IO

'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports PdfiumViewer

Public Class ongoing_details
    Public polygonCode As String
    Dim progressresultsr As Integer
    Dim pc1 As Double
    Dim pc2 As Double
    Dim pc3 As Double
    Public selectedContract As String = ""

    Private Sub ongoing_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ongoing_details_Load()
    End Sub

    Private Sub ongoing_details_Load()
        LoadOngoingDetails()
        dateformat()
        sitestatus()
        registrystatus()
        projectcost()
        Retrievespecies()
        panelone()
        Me.ControlBox = False
        If txtyear.Text >= 2020 Then
            MaintenanceToolStripMenuItem.Visible = False
            Displaysurvivalratingyear3()
            displayprojectcost2year()
            displayprojectcost1year()
            displayprojectcost3year()

        Else
            MaintenanceToolStripMenuItem.Visible = True
            Displaysurvivalrating()
            loadpolycounts()


        End If

        start4()
        datev()
        dateturnover()
    End Sub


    Private Sub txtarea_TextChanged(sender As Object, e As EventArgs) Handles txtarea.TextChanged
        If Not String.IsNullOrWhiteSpace(txtarea.Text) Then
            Dim value As Decimal
            If Decimal.TryParse(txtarea.Text, value) Then
                txtarea.Text = value.ToString("0.00")

            Else
                ' If the input is not a valid number, clear the textbox

            End If
        End If
    End Sub

    Private Sub txtcomponent_TextChanged(sender As Object, e As EventArgs) Handles txtcomponent.TextChanged
        If txtcomponent.Text = "0" Then

            txtcomponent.Text = "For Updating"
            txtcomponent.BackColor = Color.Yellow
        Else

            txtcomponent.BackColor = Color.White



        End If
    End Sub

    Private Sub txtcommodity_TextChanged(sender As Object, e As EventArgs) Handles txtcommodity.TextChanged
        If txtcommodity.Text = "0" Then

            txtcommodity.Text = "For Updating"
            txtcommodity.BackColor = Color.Yellow
        Else

            txtcommodity.BackColor = Color.White



        End If
    End Sub


    Private Sub panelone()
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Panel1.Width, Panel1.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, Panel1.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(Panel1.Width, radius, Panel1.Width, Panel1.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(Panel1.Width - radius, Panel1.Height, radius, Panel1.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        Panel1.Region = New Region(panelPath)
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Ongoingcon.Show()
        Me.Hide()

    End Sub


    Private Sub ComprehensiveToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ComprehensiveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ComprehensiveToolStripMenuItem.Click
        tic_change = 0

        With TICdashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(TICdashboard)
            .BringToFront()
            .Show()
        End With


    End Sub

    Private Sub txtseedpro_TextChanged(sender As Object, e As EventArgs) Handles txtseedpro.TextChanged
        If txtseedpro.Text = "0.00" Then
            txtseedpro.Text = "For Updating"
            txtseedpro.BackColor = Color.Yellow
        Else

            txtseedpro.BackColor = Color.White
        End If


    End Sub

    Private Sub txtseedplanted_TextChanged(sender As Object, e As EventArgs) Handles txtseedplanted.TextChanged
        If txtseedplanted.Text = "0.00" Then
            txtseedplanted.Text = "For Updating"
            txtseedplanted.BackColor = Color.Yellow
        Else

            txtseedplanted.BackColor = Color.White
        End If
    End Sub

    Private Sub NdYearMaintenanceAndProtectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdYearMaintenanceAndProtectionToolStripMenuItem.Click
        tic_change = 1

        With Year2_dashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(Year2_dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Ongoing_details_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub RdYearMaintenanceAndProtectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdYearMaintenanceAndProtectionToolStripMenuItem.Click
        tic_change = 2

        With Year3_dashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(Year3_dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub statusreg()

    End Sub

    Private Sub sitestatus()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT date_updated, status, adopting_entity " &
                         "FROM site_status_tbl WHERE unique_code = @uniquecode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check for DBNull before converting to string
                            dateupdated.Text = If(Not IsDBNull(reader("date_updated")), reader("date_updated").ToString(), "")
                            txtstatus.Text = If(Not IsDBNull(reader("status")), reader("status").ToString(), "")
                            TxtAe.Text = If(Not IsDBNull(reader("adopting_entity")), reader("adopting_entity").ToString(), "")
                            dateupdated.BackColor = Color.White
                            txtstatus.BackColor = Color.White
                            TxtAe.BackColor = Color.White
                            addsitestatus.Visible = False
                            viewsitestatus.Visible = True

                        Else
                            addsitestatus.Visible = True
                            viewsitestatus.Visible = False
                            dateupdated.Text = ""

                            txtstatus.Text = "For Updating"

                            TxtAe.Text = "For Updating"

                            dateupdated.BackColor = Color.Yellow
                            txtstatus.BackColor = Color.Yellow
                            TxtAe.BackColor = Color.Yellow
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub registrystatus()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT amount_cip, amount_under " &
                     "FROM status_registry WHERE unique_code = @uniquecode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check for DBNull before converting to string and format as "N2"
                            Dim amountCip As Object = reader("amount_cip")
                            Dim amountUnder As Object = reader("amount_under")

                            txtcip.Text = If(amountCip IsNot DBNull.Value, Convert.ToDecimal(amountCip).ToString("N2"), "0.00")
                            txtunder.Text = If(amountUnder IsNot DBNull.Value, Convert.ToDecimal(amountUnder).ToString("N2"), "0.00")

                            UpdateTextBoxIfZero(txtcip)
                            UpdateTextBoxIfZero(txtunder)


                            addstatus.Visible = False
                            viewstatus.Visible = True

                        Else

                            addstatus.Visible = True
                            viewstatus.Visible = False
                            txtcip.Text = "For Updating"
                            txtunder.Text = "For Updating"
                            txtcip.BackColor = Color.Yellow
                            txtunder.BackColor = Color.Yellow
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Private Sub projectcost()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT project_cost, year1, year2, year3, gross_amount, polygon_code " &
                     "FROM projectcost_tbl WHERE unique_code = @uniquecode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check for DBNull before converting to string and format as "N2"
                            Dim pc As Object = reader("project_cost")
                            Dim y1 As Object = reader("year1")
                            Dim y2 As Object = reader("year2")
                            Dim y3 As Object = reader("year3")
                            Dim ga As Object = reader("gross_amount")
                            Dim polycode As Object = reader("polygon_code")
                            polygonCode = polycode.ToString
                            txtpolycode.Text = polycode.ToString

                            txtprojectcost.Text = If(pc IsNot DBNull.Value, Convert.ToDecimal(pc).ToString("N2"), "0.00")
                            txtyear1.Text = If(y1 IsNot DBNull.Value, Convert.ToDecimal(y1).ToString("N2"), "0.00")
                            txtyear2.Text = If(y2 IsNot DBNull.Value, Convert.ToDecimal(y2).ToString("N2"), "0.00")
                            txtyear3.Text = If(y3 IsNot DBNull.Value, Convert.ToDecimal(y3).ToString("N2"), "0.00")
                            txtgrossamount.Text = If(ga IsNot DBNull.Value, Convert.ToDecimal(ga).ToString("N2"), "0.00")

                            UpdateTextBoxIfZero(txtprojectcost)
                            UpdateTextBoxIfZero(txtyear1)
                            UpdateTextBoxIfZero(txtyear2)
                            UpdateTextBoxIfZero(txtyear3)
                            UpdateTextBoxIfZero(txtgrossamount)

                            If txtprojectcost.Text = "For Updating" OrElse txtyear1.Text = "For Updating" OrElse txtyear2.Text = "For Updating" OrElse txtyear3.Text = "For Updating" OrElse txtgrossamount.Text = "For Updating" Then
                                addprojectcost.Visible = False
                                viewprojectcost.Visible = True
                            End If
                        Else
                            ' Handle the case where no data is returned
                            addprojectcost.Visible = True
                            viewprojectcost.Visible = False

                            txtprojectcost.Text = "For Updating"
                            txtyear1.Text = "For Updating"
                            txtyear2.Text = "For Updating"
                            txtyear3.Text = "For Updating"
                            txtgrossamount.Text = "For Updating"

                            txtprojectcost.BackColor = Color.Yellow
                            txtyear1.BackColor = Color.Yellow
                            txtyear2.BackColor = Color.Yellow
                            txtyear3.BackColor = Color.Yellow
                            txtgrossamount.BackColor = Color.Yellow
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Public Sub displayprojectcost1year()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM( DISTINCT obtc) AS total_payment " &
                          "FROM flexible_disbursement_tbl " &
                          "WHERE unique_code = @id AND yearcode = @year " &
                          "GROUP BY unique_code, yearcode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@year", "year1") ' Replace with the actual year value

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                        Dim totalAmount As Decimal = Convert.ToDecimal(result)
                        pc1 = totalAmount
                        txtyear1.Text = totalAmount.ToString("N2")
                        ' Update the TextBox
                    Else
                        ' Handle the case where no data is returned
                        txtyear1.Text = "For Updating"
                        txtyear1.BackColor = Color.Yellow
                    End If
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Public Sub displayprojectcost2year()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM( DISTINCT obtc) AS total_payment " &
                          "FROM flexible_disbursement_tbl " &
                          "WHERE unique_code = @id AND yearcode = @year " &
                          "GROUP BY unique_code, yearcode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@year", "year2") ' Replace with the actual year value

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                        Dim totalAmount As Decimal = Convert.ToDecimal(result)
                        pc2 = totalAmount
                        txtyear2.Text = totalAmount.ToString("N2")
                        ' Update the TextBox
                    Else
                        ' Handle the case where no data is returned
                        txtyear2.Text = "For Updating"
                        txtyear2.BackColor = Color.Yellow
                    End If
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub displayprojectcost3year()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM( DISTINCT obtc) AS total_payment " &
                          "FROM flexible_disbursement_tbl " &
                          "WHERE unique_code = @id AND yearcode = @year " &
                          "GROUP BY unique_code, yearcode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@year", "year3") ' Replace with the actual year value

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                        Dim totalAmount As Decimal = Convert.ToDecimal(result)
                        pc3 = totalAmount
                        txtyear3.Text = totalAmount.ToString("N2")
                        ' Update the TextBox
                    Else
                        ' Handle the case where no data is returned
                        txtyear3.Text = "For Updating"
                        txtyear3.BackColor = Color.Yellow
                    End If
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub




    ' Function to calculate the total and display it in txttotalyear
    Private Sub CalculateTotal()
        Dim value1 As Decimal
        Dim value2 As Decimal
        Dim value3 As Decimal

        ' Parse the values from the textboxes, handling any invalid input
        If Decimal.TryParse(txtyear1.Text.Replace(",", "").Trim(), value1) AndAlso
           Decimal.TryParse(txtyear2.Text.Replace(",", "").Trim(), value2) AndAlso
           Decimal.TryParse(txtyear3.Text.Replace(",", "").Trim(), value3) Then

            ' Calculate the total
            Dim total As Decimal = value1 + value2 + value3

            ' Display the total in the txttotalyear textbox
            txtprojectcost.Text = total.ToString("N")
        Else
            ' If any value is invalid, set the total to 0 or handle it appropriately
            txtprojectcost.Text = "For Updating"
            txtprojectcost.BackColor = Color.Yellow
        End If
    End Sub


    Private Sub datev()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT date_validation " &
                         "FROM date_validation_report WHERE unique_code = @uniquecode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check for DBNull before converting to string


                            dateofreport.Text = If(Not IsDBNull(reader("date_validation")), reader("date_validation").ToString(), "")
                            projectinfo_frm.dateofreport.Text = If(Not IsDBNull(reader("date_validation")), reader("date_validation").ToString(), "")
                            dateofreport.Visible = True
                            txtreport.Visible = False


                        Else
                            ' Handle the case where no data is returned
                            dateofreport.Visible = False
                            txtreport.Visible = True
                            txtreport.BackColor = Color.Yellow
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dateturnover()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT date_turnover " &
                         "FROM date_turnover_tbl WHERE unique_code = @uniquecode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Check for DBNull before converting to string


                            dateofactual.Text = If(Not IsDBNull(reader("date_turnover")), reader("date_turnover").ToString(), "")
                            projectinfo_frm.dateofactual.Text = If(Not IsDBNull(reader("date_turnover")), reader("date_turnover").ToString(), "")
                            dateofactual.Visible = True
                            txtactual.Visible = False


                        Else
                            ' Handle the case where no data is returned
                            dateofactual.Visible = False
                            txtactual.Visible = True
                            txtactual.BackColor = Color.Yellow
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Displaysurvivalrating()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT survival_rate FROM survival_rate_year3 WHERE survival_id = (SELECT MAX(survival_id) FROM survival_rate_year3 WHERE unique_code = @id);"

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
                    txtsr.Update()
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub Displaysurvivalratingyear3()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT survival_rate FROM survival_rate_year3 WHERE filter_code = 'qrt4' AND unique_code = @id;"

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


    Sub dateformat()
        datecontractexe.DropDownAlign = LeftRightAlignment.Right
        datecontractexe.Format = DateTimePickerFormat.Custom
        datecontractexe.CustomFormat = "MMMM yyyy"

        datecontractexp.DropDownAlign = LeftRightAlignment.Right
        datecontractexp.Format = DateTimePickerFormat.Custom
        datecontractexp.CustomFormat = "MMMM yyyy"

        dateofactual.DropDownAlign = LeftRightAlignment.Right
        dateofactual.Format = DateTimePickerFormat.Custom
        dateofactual.CustomFormat = "MMMM yyyy"

        dateofreport.DropDownAlign = LeftRightAlignment.Right
        dateofreport.Format = DateTimePickerFormat.Custom
        dateofreport.CustomFormat = "MMMM yyyy"

        dateupdated.DropDownAlign = LeftRightAlignment.Right
        dateupdated.Format = DateTimePickerFormat.Custom
        dateupdated.CustomFormat = "MMMM yyyy"


    End Sub





    Dim percentage As Double = 0.0
    Dim percentage4 As Double = 0.0

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

        End If
    End Sub



    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click

    End Sub

    Private Sub AddDateOfTurnOverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDateOfTurnOverToolStripMenuItem.Click
        date_turnover.ShowDialog()
    End Sub

    Private Sub AddDateOfPVDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        date_vreport.ShowDialog()
    End Sub

    Private Sub AddDisturbancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDisturbancesToolStripMenuItem.Click
        disturbances.ShowDialog()
    End Sub

    Private Sub AddDateOfPVDToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddDateOfPVDToolStripMenuItem.Click
        date_vreport.ShowDialog()

    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles adddisturbance.Click
        disturbances.ShowDialog()
    End Sub



    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addstatus.Click
        status_frm.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles addsitestatus.Click
        site_status_frm.ShowDialog()

    End Sub



    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles addprojectcost.Click
        projectcost_frm.ShowDialog()
    End Sub

    Private Sub AddSurvivalRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSurvivalRateToolStripMenuItem.Click
        finalsurvivalrate_frm.btnsub2.Visible = False
        finalsurvivalrate_frm.btnsub3.Visible = False
        finalsurvivalrate_frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        projectinfo_frm.ShowDialog()
    End Sub

    Private Sub txtseedreq_TextChanged(sender As Object, e As EventArgs) Handles txtseedreq.TextChanged
        If txtseedreq.Text = "0.00" Then

            txtseedreq.Text = "For Updating"
            txtseedreq.BackColor = Color.Yellow
        Else

            txtseedreq.BackColor = Color.White
        End If
    End Sub

    Private Sub txtprojectcost_TextChanged(sender As Object, e As EventArgs) Handles txtprojectcost.TextChanged
        If txtprojectcost.Text = "0" Then

            txtprojectcost.Text = "For Updating"
            txtprojectcost.BackColor = Color.Yellow
        Else

            txtprojectcost.BackColor = Color.White
        End If
    End Sub

    Private Sub txtyear1_TextChanged(sender As Object, e As EventArgs) Handles txtyear1.TextChanged
        If txtyear.Text >= 2020 Then
            CalculateTotal()
        End If


        If txtyear1.Text = "0.00" Then

            txtyear1.Text = "For Updating"
            txtyear1.BackColor = Color.Yellow
        Else

            txtyear1.BackColor = Color.White
        End If
    End Sub

    Private Sub txtyear2_TextChanged(sender As Object, e As EventArgs) Handles txtyear2.TextChanged
        If txtyear.Text >= 2020 Then
            CalculateTotal()
        End If

        If txtyear2.Text = "0.00" Then

            txtyear2.Text = "For Updating"
            txtyear2.BackColor = Color.Yellow
        Else

            txtyear2.BackColor = Color.White
        End If
    End Sub

    Private Sub txtyear3_TextChanged(sender As Object, e As EventArgs) Handles txtyear3.TextChanged
        If txtyear.Text >= 2020 Then
            CalculateTotal()
        End If
        If txtyear3.Text = "0.00" Then

            txtyear3.Text = "For Updating"
            txtyear3.BackColor = Color.Yellow
        Else

            txtyear3.BackColor = Color.White
        End If
    End Sub

    Private Sub txtcip_TextChanged(sender As Object, e As EventArgs) Handles txtcip.TextChanged
        If txtcip.Text = "0.00" Then

            txtcip.Text = "For Updating"
            txtcip.BackColor = Color.Yellow
        Else
            txtcip.BackColor = Color.White
        End If
    End Sub

    Private Sub txtunder_TextChanged(sender As Object, e As EventArgs) Handles txtunder.TextChanged
        If txtunder.Text = "0.00" Then

            txtunder.Text = "For Updating"
            txtunder.BackColor = Color.Yellow
        Else

            txtunder.BackColor = Color.White
        End If
    End Sub

    Private Sub txtreq_TextChanged(sender As Object, e As EventArgs) Handles txtspe.TextChanged
        If txtspe.Text = "0" Then

            txtspe.Text = "For Updating"
            txtspe.BackColor = Color.Yellow
        Else

            txtspe.BackColor = Color.White
        End If
    End Sub

    Public Sub LoadOngoingDetails()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT t1.unique_code, t1.date_execution, t1.date_expiry, t1.zone, t1.fund, t1.activities, t1.year, t1.region, t1.district, t1.baranggay, t1.municipality, t1.province, " &
                              "t1.penro, t1.cenro, t1.component, t1.commodity, t1.species, t1.seed_reqdisplay, t2.data_id, t2.target_area, t2.area_planted, t2.seed_req, t2.seed_pro, t2.seed_plant, " &
                              "t3.Org_name, t3.Org_type, t3.Org_tenure, t4.Firstname, t4.Middlename, t4.Lastname " &
                              "FROM contract_tbl AS t1 " &
                              "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                              "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                              "WHERE t1.unique_code = @uniquecodeloading"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@uniquecodeloading", uniquecodeloading)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtuniquecode.Text = reader("unique_code").ToString()
                        txtorg.Text = reader("Org_name").ToString()

                        txttenure.Text = reader("Org_tenure").ToString()


                        Dim firstName As String = reader("Firstname").ToString()
                        Dim middleName As String = reader("Middlename").ToString()
                        Dim lastName As String = reader("Lastname").ToString()
                        Dim contact As String = $"{firstName} {middleName} {lastName}"
                        newcontact.Text = contact

                        txttypeorg.Text = reader("Org_type").ToString()

                        txtconregion.Text = reader("region").ToString()
                        condistricttxt.Text = reader("district").ToString()

                        txtarea.Text = Decimal.Parse(reader("area_planted").ToString()).ToString("N")
                        txtseedreq.Text = Decimal.Parse(reader("seed_req").ToString()).ToString("N")
                        txtspe.Text = reader("seed_reqdisplay").ToString()
                        txtseedpro.Text = Decimal.Parse(reader("seed_pro").ToString()).ToString("N")
                        txtseedplanted.Text = Decimal.Parse(reader("seed_plant").ToString()).ToString("N")

                        datecontractexe.Text = reader("date_execution").ToString()
                        datecontractexp.Text = reader("date_expiry").ToString()

                        txtyear.Text = reader("year").ToString()
                        txtbarangay.Text = reader("baranggay").ToString()
                        txtmunicipality.Text = reader("municipality").ToString()
                        txtprovince.Text = reader("province").ToString()
                        txtspecies.Text = reader("species").ToString()
                        txtcomponent.Text = reader("component").ToString()
                        txtcommodity.Text = reader("commodity").ToString()

                        If dateofactual.Value.Date = DateTime.Today Then
                            dateofactual.Visible = False
                            txtactual.Visible = True
                            txtactual.BackColor = Color.Yellow
                        Else
                            dateofactual.Visible = True
                            txtactual.Visible = False
                        End If

                        If dateofreport.Value.Date = DateTime.Today Then
                            dateofreport.Visible = False
                            txtreport.Visible = True
                            txtreport.BackColor = Color.Yellow
                        Else
                            dateofreport.Visible = True
                            txtreport.Visible = False
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewstatus.Click
        viewstatusofregisty_frm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles viewdisturbance.Click
        viewforestdisturbances.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles viewsitestatus.Click
        viewstatusofsite_frm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles viewprojectcost.Click
        viewprojectcost_frm.ShowDialog()
    End Sub


    Public Sub displayprojectcostyear2()
        Dim pc As Double
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT SUM( DISTINCT obtc) AS total_payment " &
                          "FROM flexible_disbursement_tbl " &
                          "WHERE unique_code = @id AND yearcode = @year " &
                          "GROUP BY unique_code, yearcode"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@year", "year2") ' Replace with the actual year value

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                        Dim totalAmount As Decimal = Convert.ToDecimal(result)
                        pc = totalAmount

                        ' Update the TextBox
                    Else
                        ' Handle the case where no data is returned

                    End If
                Catch ex As Exception
                    ' Handle any exceptions here
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub AddToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles addpoly.Click
        polygonsites.ShowDialog()
    End Sub

    Private Sub loadpolycounts()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connStr)
            ' SQL query to count rows with the same polygon_code
            Dim query As String = "SELECT COUNT(*) AS RowCount FROM projectcost_tbl WHERE polygon_code = @polygoncode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@polygoncode", polygonCode)

            Try
                connection.Open()
                Dim rowCount As Integer
                rowCount = Convert.ToInt32(command.ExecuteScalar())
                If rowCount = 0 Then
                    txtcountpoly.Text = 1
                Else
                    txtcountpoly.Text = rowCount.ToString
                End If

            Catch ex As Exception
                ' Handle exceptions here (e.g., log the error or show an error message)
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure that the connection is closed, even if an exception occurs
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub


    Dim connStr As String = "server=localhost;username=root;password=;database=ngp"


    Public Sub LoadConsolidatedProjectReporter()
        Dim rptDSDetails As ReportDataSource

        Try
            NGPdata_Report.ReportViewer1.RefreshReport()

            ' Load report files
            With NGPdata_Report.ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\report\ConsolidatedData.rdlc"
                .DataSources.Clear()
            End With

            Using connection As New MySqlConnection(connStr)
                ' Open the connection
                connection.Open()

                ' Consolidated query
                Dim consolidatedQuery As String = "SELECT " &
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
            "WHERE t1.unique_code = @uniquecode " &
            "LIMIT 1"

                Dim consolidatedCommand As New MySqlCommand(consolidatedQuery, connection)
                consolidatedCommand.Parameters.AddWithValue("@uniquecode", txtuniquecode.Text)

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





    Private Sub btnprintreport_Click(sender As Object, e As EventArgs) Handles btnprintreport.Click

        LoadConsolidatedProjectReporter()
        NGPdata_Report.ShowDialog()
    End Sub

    Public Sub Retrievespecies()
        Dim connStr As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connStr)
            ' SQL query with WHERE clause
            Dim query As String = "SELECT t2.multispecies_name " &
                                  "FROM seedproduction_tbl AS t1 " &
                                  "INNER JOIN multispecies AS t2 ON t1.seed_code = t2.seed_produce_code " &
                                  "WHERE t2.unique_code = @value;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value", txtuniquecode.Text)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                Dim result As New List(Of String)

                While reader.Read()
                    Dim multispeciesName As String = reader("multispecies_name").ToString()
                    result.Add(multispeciesName)
                End While

                reader.Close()
                connection.Close()

                If result.Count > 0 Then
                    txtspe.Text = String.Join(", ", result)
                Else
                    txtspe.Text = "No data found."
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UpdateTextBoxIfZero(ByRef textBox As TextBox)
        Dim value As Decimal
        If Decimal.TryParse(textBox.Text, value) AndAlso value = 0D Then
            textBox.Text = "For Updating"
            textBox.BackColor = Color.Yellow
        Else
            textBox.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        If selectedContract = "ONGOING" Then
            Dim NextIndex = Ongoingcon.DataGridView1.SelectedRows(0).Index + 1
            If NextIndex >= Ongoingcon.DataGridView1.Rows.Count Then
                MessageBox.Show("You have reach the end of the Record", "End of Record", MessageBoxButtons.OK)
                Return
            End If
            Ongoingcon.DataGridView1.SelectedRows(0).Selected = False
            Ongoingcon.DataGridView1.Rows(NextIndex).Selected = True
            Dim dgr As DataGridViewRow = Ongoingcon.DataGridView1.Rows(NextIndex)
            LoadOngoingContractData(dgr)
        ElseIf selectedContract = "COMPLETED" Then
            Dim NextIndex = completed_contracts.DataGridView1.SelectedRows(0).Index + 1
            If NextIndex >= completed_contracts.DataGridView1.Rows.Count Then
                MessageBox.Show("You have reach the end of the Record", "End of Record", MessageBoxButtons.OK)
                Return
            End If
            completed_contracts.DataGridView1.SelectedRows(0).Selected = False
            completed_contracts.DataGridView1.Rows(NextIndex).Selected = True
            Dim dgr As DataGridViewRow = completed_contracts.DataGridView1.Rows(NextIndex)
            LoadCompletedContractData(dgr)

        End If
    End Sub

    Private Sub LoadOngoingContractData(dvg As DataGridViewRow)

        seedlingproduceprimamry = Ongoingcon.DataGridView1.Item("data_id", Ongoingcon.DataGridView1.SelectedRows(0).Index).Value
        uniquecode = Ongoingcon.DataGridView1.Item("unique_code", Ongoingcon.DataGridView1.SelectedRows(0).Index).Value
        uniquecodeloading = Ongoingcon.DataGridView1.Item("unique_code", Ongoingcon.DataGridView1.SelectedRows(0).Index).Value

        ongoing_details_Load()
    End Sub

    Private Sub LoadCompletedContractData(dvg As DataGridViewRow)
        lblprimarykey.Text = completed_contracts.DataGridView1.Item("data_id", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        seedlingproduceprimamry = completed_contracts.DataGridView1.Item("data_id", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtuniquecode.Text = completed_contracts.DataGridView1.Item("unique_code", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        uniquecode = completed_contracts.DataGridView1.Item("unique_code", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        uniquecodeloading = completed_contracts.DataGridView1.Item("unique_code", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtorg.Text = completed_contracts.DataGridView1.Item("Org_name", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txttenure.Text = completed_contracts.DataGridView1.Item("Org_tenure", completed_contracts.DataGridView1.SelectedRows(0).Index).Value


        Dim firstName As String = completed_contracts.DataGridView1.Item("Firstname", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()
        Dim middleName As String = completed_contracts.DataGridView1.Item("Middlename", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()
        Dim lastName As String = completed_contracts.DataGridView1.Item("Lastname", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()
        Dim contact As String = $"{firstName} {middleName} {lastName}"
        newcontact.Text = contact

        txttypeorg.Text = completed_contracts.DataGridView1.Item("Org_type", completed_contracts.DataGridView1.SelectedRows(0).Index).Value



        txtconregion.Text = completed_contracts.DataGridView1.Item("region", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        condistricttxt.Text = completed_contracts.DataGridView1.Item("district", completed_contracts.DataGridView1.SelectedRows(0).Index).Value

        txtarea.Text = Decimal.Parse(completed_contracts.DataGridView1.Item("area_planted", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()).ToString("N")
        txtseedreq.Text = Decimal.Parse(completed_contracts.DataGridView1.Item("seed_req", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()).ToString("N")
        txtspe.Text = completed_contracts.DataGridView1.Item("seed_reqdisplay", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtseedpro.Text = Decimal.Parse(completed_contracts.DataGridView1.Item("seed_pro", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()).ToString("N")
        txtseedplanted.Text = Decimal.Parse(completed_contracts.DataGridView1.Item("seed_plant", completed_contracts.DataGridView1.SelectedRows(0).Index).Value.ToString()).ToString("N")
        datecontractexe.Text = completed_contracts.DataGridView1.Item("date_execution", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        datecontractexp.Text = completed_contracts.DataGridView1.Item("date_expiry", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtyear.Text = completed_contracts.DataGridView1.Item("year", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtbarangay.Text = completed_contracts.DataGridView1.Item("baranggay", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtmunicipality.Text = completed_contracts.DataGridView1.Item("municipality", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtprovince.Text = completed_contracts.DataGridView1.Item("province", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtspecies.Text = completed_contracts.DataGridView1.Item("species", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtcomponent.Text = completed_contracts.DataGridView1.Item("component", completed_contracts.DataGridView1.SelectedRows(0).Index).Value
        txtcommodity.Text = completed_contracts.DataGridView1.Item("commodity", completed_contracts.DataGridView1.SelectedRows(0).Index).Value


        If dateofactual.Value.Date = DateTime.Today Then
            dateofactual.Visible = False
            txtactual.Visible = True
            txtactual.BackColor = Color.Yellow
        Else

        End If

        If dateofreport.Value.Date = DateTime.Today Then
            dateofreport.Visible = False
            txtreport.Visible = True
            txtreport.BackColor = Color.Yellow

        Else

        End If
        ongoing_details_Load()
    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        If selectedContract = "ONGOING" Then
            Dim NextIndex = Ongoingcon.DataGridView1.SelectedRows(0).Index - 1
            If NextIndex < 0 Then
                MessageBox.Show("You have reach the end of the Record", "End of Record", MessageBoxButtons.OK)
                Return
            End If
            Ongoingcon.DataGridView1.SelectedRows(0).Selected = False
            Ongoingcon.DataGridView1.Rows(NextIndex).Selected = True
            Dim dgr As DataGridViewRow = Ongoingcon.DataGridView1.Rows(NextIndex)
            LoadOngoingContractData(dgr)
        ElseIf selectedContract = "COMPLETED" Then
            Dim NextIndex = completed_contracts.DataGridView1.SelectedRows(0).Index - 1
            If NextIndex < 0 Then
                MessageBox.Show("You have reach the end of the Record", "End of Record", MessageBoxButtons.OK)
                Return
            End If
            completed_contracts.DataGridView1.SelectedRows(0).Selected = False
            completed_contracts.DataGridView1.Rows(NextIndex).Selected = True
            Dim dgr As DataGridViewRow = completed_contracts.DataGridView1.Rows(NextIndex)
            LoadCompletedContractData(dgr)

        End If
    End Sub

    Private Sub btnUploadDoc_Click(sender As Object, e As EventArgs) Handles btnUploadDoc.Click
        UploadContractDoc.ShowDialog()
    End Sub

    Private Sub btnPrintDoc_Click(sender As Object, e As EventArgs) Handles btnPrintDoc.Click
        Dim contractDocFileName = "C:/ngpsys/storage/contracts/" + uniquecode + ".pdf"
        Dim fileExists As Boolean = My.Computer.FileSystem.FileExists(contractDocFileName)

        If Not fileExists Then
            MessageBox.Show("Can't find the document for this contract.")
            Return
        End If

        ViewPdf.fileName = contractDocFileName
        ViewPdf.ShowDialog()
    End Sub
End Class