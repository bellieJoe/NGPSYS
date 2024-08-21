Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentYear As Integer = DateTime.Now.Year
        For year As Integer = 2011 To currentYear
            cmbyear.Items.Add(year.ToString())
        Next
        rowcountcompleted()
        rowcountongoing()
        totalareaplanted()
        seedlingplanted()
        panel(Panel3)
        panel(Panel1)
        panel(Panel2)
        panel(Panel4)
        panel(Panel11)
        Me.MaximizeBox = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ongoingcon.Show()
        Me.Close()

    End Sub

    Private Function ExecuteScalar(query As String) As Object
        Dim connString As String = "server=localhost;username=root;password=;database=ngp"
        Dim conn As New MySqlConnection(connString)
        Dim result As Object = Nothing

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            result = cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return result
    End Function

    Private Sub rowcountongoing()
        lbloc.Text = ExecuteScalar("SELECT COUNT(*), YEAR(NOW()) FROM contract_tbl WHERE year <= YEAR(NOW())")
    End Sub

    Private Sub rowcountcompleted()
        lblcc.Text = ExecuteScalar("SELECT COUNT(*) FROM date_turnover_tbl")
    End Sub


    Private Sub totalareaplanted()

        Dim areaPlanted As Object = ExecuteScalar("SELECT SUM(t2.area_planted) " &
                                          "FROM contract_tbl AS t1 " &
                                          "JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code;")

        If areaPlanted IsNot DBNull.Value AndAlso Not areaPlanted.Equals(DBNull.Value) Then
            lbltap.Text = Convert.ToInt32(areaPlanted).ToString("N0")

        Else

            txtareaplant.Text = "N/A" ' or any other default value or error message
        End If

    End Sub

    Private Sub seedlingplanted()

        Dim seedPlanted As Object = ExecuteScalar("SELECT SUM(t2.seed_plant) " &
                                           "FROM contract_tbl AS t1 " &
                                           "JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code;")

        If seedPlanted IsNot DBNull.Value AndAlso Not seedPlanted.Equals(DBNull.Value) Then
            lblsp.Text = Convert.ToInt32(seedPlanted).ToString("N0")
        Else
            txtseedplanted.Text = "0" ' or any other default value
        End If
    End Sub

    Private Sub panel(PanelControl As Panel)
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, PanelControl.Width, PanelControl.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, PanelControl.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(PanelControl.Width, radius, PanelControl.Width, PanelControl.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(PanelControl.Width - radius, PanelControl.Height, radius, PanelControl.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        PanelControl.Region = New Region(panelPath)
    End Sub

    Private Sub AddNewContractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewContractToolStripMenuItem.Click
        add2022contract.ShowDialog()

    End Sub

    Private Sub AddUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem1.Click
        userpass.ShowDialog()
    End Sub

    Private Sub AddOrganizationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddOrganizationToolStripMenuItem1.Click
        New_Organization.ShowDialog()
    End Sub

    Private Sub AddComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComponentToolStripMenuItem.Click
        NewComponent.ShowDialog()
    End Sub

    Private Sub AddCommodityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCommodityToolStripMenuItem.Click
        NewCommodity.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        NewSpecies.ShowDialog()
    End Sub

    Private Sub AddNewTenureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewTenureToolStripMenuItem.Click
        NewTenure.ShowDialog()
    End Sub

    Private Sub AddNewZoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewZoneToolStripMenuItem.Click
        NewZone.Show()
    End Sub

    Private Sub AddNewFundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewFundToolStripMenuItem.Click
        NewFunding.ShowDialog()
    End Sub

    Private Sub AddNewActivitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewActivitiesToolStripMenuItem.Click
        NewActivities.ShowDialog()
    End Sub

    Private Sub WelcomwToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WelcomwToolStripMenuItem.Click
        user_profile.ShowDialog()
    End Sub

    Private Sub dashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel11.Left = (Me.Width - Panel11.Width) / 2
    End Sub

    Private Sub projectcount()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT COUNT(*)" &
                              "FROM contract_tbl " &
                              "WHERE year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim projectcount As Object = command.ExecuteScalar()

                    If projectcount IsNot Nothing AndAlso Not projectcount.Equals(DBNull.Value) Then
                        txtproject.Text = Convert.ToInt32(projectcount).ToString("N0")
                    Else
                        txtproject.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub yearlyinfoAreaPlanted()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT SUM(t2.area_planted)" &
                              "FROM contract_tbl AS t1 " &
                              "JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "WHERE t1.year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim YearareaPlanted As Object = command.ExecuteScalar()

                    If YearareaPlanted IsNot Nothing AndAlso Not YearareaPlanted.Equals(DBNull.Value) Then
                        txtyearAreaPlanted.Text = Convert.ToInt32(YearareaPlanted).ToString("N0")
                    Else
                        txtyearAreaPlanted.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub yearlyinfoSeedlingPro()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT SUM(t2.seed_pro)" &
                              "FROM contract_tbl AS t1 " &
                              "JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "WHERE t1.year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim YearareaSeedPro As Object = command.ExecuteScalar()

                    If YearareaSeedPro IsNot Nothing AndAlso Not YearareaSeedPro.Equals(DBNull.Value) Then
                        txtyearSeedlingProduce.Text = Convert.ToInt32(YearareaSeedPro).ToString("N0")
                    Else
                        txtyearSeedlingProduce.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub yearlyinfoSeedlingPlanted()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT SUM(t2.seed_plant)" &
                              "FROM contract_tbl AS t1 " &
                              "JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "WHERE t1.year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim YearareaSeedPlant As Object = command.ExecuteScalar()

                    If YearareaSeedPlant IsNot Nothing AndAlso Not YearareaSeedPlant.Equals(DBNull.Value) Then
                        txtyearSeedlingPlanted.Text = Convert.ToInt32(YearareaSeedPlant).ToString("N0")
                    Else
                        txtyearSeedlingPlanted.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub yearlyinfoProjectCost()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT SUM(t2.project_cost)" &
                              "FROM contract_tbl AS t1 " &
                              "JOIN projectcost_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "WHERE t1.year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim YearProject As Object = command.ExecuteScalar()

                    If YearProject IsNot Nothing AndAlso Not YearProject.Equals(DBNull.Value) Then
                        txtyearProjectCost.Text = Convert.ToInt32(YearProject).ToString("N0")
                    Else
                        txtyearProjectCost.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub yearlyinfoGrossAmount()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT SUM(t2.gross_amount)" &
                              "FROM contract_tbl AS t1 " &
                              "JOIN projectcost_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                              "WHERE t1.year = @SelectedYear;"

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SelectedYear", cmbyear.SelectedItem.ToString())

                    ' Execute the query and read the result
                    Dim YearProject As Object = command.ExecuteScalar()

                    If YearProject IsNot Nothing AndAlso Not YearProject.Equals(DBNull.Value) Then
                        txtyearGrossAmount.Text = Convert.ToInt32(YearProject).ToString("N0")
                    Else
                        txtyearGrossAmount.Text = "N/A" ' or any other default value or error message
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cmbyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyear.SelectedIndexChanged
        If cmbyear.SelectedItem IsNot Nothing Then
            yearlyinfoAreaPlanted()
            yearlyinfoSeedlingPro()
            yearlyinfoSeedlingPlanted()
            yearlyinfoProjectCost()
            yearlyinfoGrossAmount()
            projectcount()
        End If
    End Sub




End Class