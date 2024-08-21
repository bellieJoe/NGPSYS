Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class Year3_dashboard

    Dim progressresultsr As Integer
    Private Sub Year3_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = uniquecode
        txtsitecode.Text = uniquecode
        txtorg.Text = ongoing_details.txtorg.Text.ToString

        DisplayTIC()
        firstquarterchecker()
        thirdquarterviewer()
        fourthquarterviewer()
        Displaysurvivalrating()

        start4()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        ReadOn = 0
        tic_change = 0

        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With

        Me.Close()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Year3_inspection.AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = True
        Year3_inspection.ShowDialog()

    End Sub


    Public Sub DisplayTIC()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) FROM inspector_details_tbl WHERE unique_code = @id AND LENGTH(filter_code) = 4"

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ringwedding_restaking.Show()
        'year2_view.Show()
        quarter12 = "qrt12"

        finalsurvivalrate_frm.btnyear3.Visible = True
        finalsurvivalrate_frm.btnsub1.Visible = False
        finalsurvivalrate_frm.btnsub2.Visible = False
        finalsurvivalrate_frm.btnsub3.Visible = False

        year3_remark.btn1.Visible = True
        year3_remark.btn2.Visible = False
        year3_remark.btn3.Visible = False

        If String.IsNullOrEmpty(txt1stquarter.Text) OrElse txt1stquarter.Text.Trim() = "0" Then
            Year3_inspection.AddRingWeddingAndRestakingToolStripMenuItem.Visible = True
            year3_view.btnsubmit.Visible = True
            Year3_inspection.ShowDialog()
        Else
            year3_1st2nd_quarter.ShowDialog()
        End If



    End Sub

    Private Sub firstquarterchecker()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) " &
                     "FROM year3rd_inspection_date AS t1 " &
                     "INNER JOIN year3rd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' If count is greater than 0, the record with the given id exists.
                    txt1stquarter.Text = count.ToString
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using
    End Sub

    Private Sub firstquarterviewer()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) " &
                     "FROM year3rd_inspection_date AS t1 " &
                     "INNER JOIN year3rd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' If count is greater than 0, the record with the given id exists.
                    txt1stquarter.Text = count.ToString
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quarter12 = "qrt3"

        finalsurvivalrate_frm.btnyear3.Visible = False
        finalsurvivalrate_frm.btnsub1.Visible = False
        finalsurvivalrate_frm.btnsub2.Visible = True
        finalsurvivalrate_frm.btnsub3.Visible = False

        year3_remark.btn1.Visible = False
        year3_remark.btn2.Visible = True
        year3_remark.btn3.Visible = False

        If String.IsNullOrEmpty(txt3rdquarter.Text) OrElse txt3rdquarter.Text.Trim() = "0" Then
            Year3_inspection.AddRingWeddingAndRestakingToolStripMenuItem.Visible = True
            year3_view.btnsub2.Visible = True
            Year3_inspection.ShowDialog()

        Else
            year3_3rdquarter.ShowDialog()
        End If
    End Sub

    Private Sub thirdquarterviewer()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) " &
                     "FROM year3rd_inspection_date AS t1 " &
                     "INNER JOIN year3rd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value AND t2.filter_code = @value1;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value1", "qrt3")
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' If count is greater than 0, the record with the given id exists.
                    txt3rdquarter.Text = count.ToString
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using
    End Sub

    Private Sub fourthquarterviewer()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectQuery As String = "SELECT COUNT(*) " &
                     "FROM year3rd_inspection_date AS t1 " &
                     "INNER JOIN year3rd_data_tbl AS t2 ON t1.quarter_code = t2.quarter_code " &
                     "WHERE t2.unique_code = @value AND t2.filter_code = @value1;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@value", uniquecodeloading)
                command.Parameters.AddWithValue("@value1", "qrt4")
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' If count is greater than 0, the record with the given id exists.
                    txt4thquarter.Text = count.ToString
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    ' You can handle the error as needed.
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        quarter12 = "qrt4"
        finalsurvivalrate_frm.btnyear3.Visible = False
        finalsurvivalrate_frm.btnsub1.Visible = False
        finalsurvivalrate_frm.btnsub2.Visible = False
        finalsurvivalrate_frm.btnsub3.Visible = True

        year3_remark.btn1.Visible = False
        year3_remark.btn2.Visible = False
        year3_remark.btn3.Visible = True

        If String.IsNullOrEmpty(txt4thquarter.Text) OrElse txt4thquarter.Text.Trim() = "0" Then
            Year3_inspection.AddRingWeddingAndRestakingToolStripMenuItem.Visible = True
            year3_view.btnsub3.Visible = True
            Year3_inspection.ShowDialog()
        Else
            year3_4thquarter.ShowDialog()
        End If
    End Sub

    Private Sub Year3_dashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel8.Left = (Me.Width - Panel8.Width) / 2
    End Sub

    Private Sub RdQuarterPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdQuarterPaymentToolStripMenuItem.Click
        year3_viewpayment_frm.ShowDialog()
    End Sub

    Private Sub NdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdToolStripMenuItem.Click
        year3_addpayment_frm.ShowDialog()
    End Sub
    Dim percentage As Double = 0.0
    Dim percentage4 As Double = 0.0

    Private Sub Displaysurvivalrating()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT survival_rate  FROM survival_rate_year3 WHERE unique_code = @id and filter_code = @value;"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", uniquecodeloading)
                command.Parameters.AddWithValue("@value", "qrt4")

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

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class