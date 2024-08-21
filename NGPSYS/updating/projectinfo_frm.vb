Imports MySql.Data.MySqlClient

Public Class projectinfo_frm
    Private Sub projectinfo_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectData()
        If personnel = 0 Then
            btndelete.Visible = False
        Else
            btndelete.Visible = True

        End If
    End Sub



    Public Sub SelectData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "SELECT t1.*, t2.*, t3.*, t4.* " &
                                  "FROM contract_tbl AS t1 " &
                                  "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                                  "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                                  "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                                  "WHERE t1.unique_code = @uniquecode"
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

                    ' Execute the query and read the results
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Assuming these are the column names in your database. Adjust accordingly.

                            txtuniquecode.Text = reader("unique_code").ToString()
                            txtorg.Text = reader("Org_name").ToString()
                            txttenure.Text = reader("Org_tenure").ToString()
                            txtfund.Text = reader("fund").ToString()

                            txttypeorg.Text = reader("Org_type").ToString()
                            txtzone.Text = reader("zone").ToString()
                            txtconregion.Text = reader("region").ToString()
                            condistricttxt.Text = reader("district").ToString()
                            txtarea.Text = reader("area_planted").ToString()
                            txtseedreq.Text = reader("seed_req").ToString()
                            txtreq.Text = reader("seed_reqdisplay").ToString()
                            txtseedpro.Text = reader("seed_pro").ToString()
                            txtseedplanted.Text = reader("seed_plant").ToString()
                            datecontractexe.Value = Convert.ToDateTime(reader("date_execution"))
                            datecontractexp.Value = Convert.ToDateTime(reader("date_expiry"))
                            txtyear.Text = reader("year").ToString()
                            txtbarangay.Text = reader("baranggay").ToString()
                            txtmunicipality.Text = reader("municipality").ToString()
                            txtprovince.Text = reader("province").ToString()
                            txtspecies.Text = reader("species").ToString()
                            txtcomponent.Text = reader("component").ToString()
                            txtcommodity.Text = reader("commodity").ToString()

                            MessageBox.Show("Data retrieved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using


                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub






    Public Sub update2()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Construct the SQL query
                Dim query As String = "UPDATE contract_tbl AS t1 " &
                       "INNER JOIN data_tbl AS t2 ON t1.unique_code = t2.unique_code " &
                       "INNER JOIN organizational_tbl AS t3 ON t1.org_id = t3.Org_ID " &
                       "INNER JOIN contact_tbl AS t4 ON t3.Org_ID = t4.Contact_ID " &
                       "SET t1.date_execution = @Dexe, t1.date_expiry = @Exp, t1.zone = @Zone, t1.fund = @Fund, t1.year = @Year, t1.region = @Reg, t1.district = @Dist, t1.baranggay = @Brgy, t1.municipality = @Muni, t1.province = @Pro, " &
                       "t1.component = @Compo, t1.commodity = @Comm, t1.species = @Species, t1.seed_reqdisplay = @Seed, t2.area_planted = @Area, t2.seed_req = @Seed_req, t2.seed_pro = @Seed_pro, t2.seed_plant = @Seedplant, t3.Org_name = @Orgname, t3.Org_type = @Orgtype, t3.Org_tenure = @Orgtenure " &
                       "WHERE t1.unique_code = @uniquecode"


                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                    command.Parameters.AddWithValue("@Dexe", datecontractexe.Value)
                    command.Parameters.AddWithValue("@Exp", datecontractexp.Value)
                    command.Parameters.AddWithValue("@Zone", txtzone.Text)
                    command.Parameters.AddWithValue("@Fund", txtfund.Text)
                    command.Parameters.AddWithValue("@Year", txtyear.Text)
                    command.Parameters.AddWithValue("@Reg", txtconregion.Text)
                    command.Parameters.AddWithValue("@Dist", condistricttxt.Text)
                    command.Parameters.AddWithValue("@Brgy", txtbarangay.Text)
                    command.Parameters.AddWithValue("@Muni", txtmunicipality.Text)
                    command.Parameters.AddWithValue("@Pro", txtprovince.Text)
                    command.Parameters.AddWithValue("@Compo", txtcomponent.Text)
                    command.Parameters.AddWithValue("@Comm", txtcommodity.Text)
                    command.Parameters.AddWithValue("@Species", txtspecies.Text)
                    command.Parameters.AddWithValue("@Seed", txtseedreq.Text)
                    command.Parameters.AddWithValue("@Area", txtarea.Text)
                    command.Parameters.AddWithValue("@Seed_req", txtseedreq.Text)
                    command.Parameters.AddWithValue("@Seed_pro", txtseedpro.Text)
                    command.Parameters.AddWithValue("@Seedplant", txtseedplanted.Text)
                    command.Parameters.AddWithValue("@Orgname", txtorg.Text)
                    command.Parameters.AddWithValue("@Orgtype", txttypeorg.Text)
                    command.Parameters.AddWithValue("@Orgtenure", txttenure.Text)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No data updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub

    Public Sub deleterecords()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Confirmation message box before deletion
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If confirmationResult = DialogResult.Yes Then
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    Dim query As String =
                        "DELETE FROM contract_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM data_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM organizational_tbl WHERE Org_ID IN (SELECT org_id FROM contract_tbl WHERE unique_code = @uniquecode); " &
                        "DELETE FROM contact_tbl WHERE Contact_ID IN (SELECT Org_ID FROM organizational_tbl WHERE Org_ID IN (SELECT org_id FROM contract_tbl WHERE unique_code = @uniquecode)); " &
                        "DELETE FROM commodity_unitcost_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM date_turnover_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM date_validation_report WHERE unique_code = @uniquecode; " &
                        "DELETE FROM disbursement_2nd WHERE unique_code = @uniquecode; " &
                        "DELETE FROM disbursement_76_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM disbursement_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM disbursement_yearend_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM disturbances_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM flexible_disbursement_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM inspector_details_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM maintenance_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM multispecies WHERE unique_code = @uniquecode; " &
                        "DELETE FROM plantation_estab_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM projectcost_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM remarks WHERE unique_code = @uniquecode; " &
                        "DELETE FROM site_status_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM status_registry WHERE unique_code = @uniquecode; " &
                        "DELETE FROM survival_rate_year1 WHERE unique_code = @uniquecode; " &
                        "DELETE FROM survival_rate_year2 WHERE unique_code = @uniquecode; " &
                        "DELETE FROM survival_rate_year3 WHERE unique_code = @uniquecode; " &
                        "DELETE FROM year2nd_data_tbl WHERE unique_code = @uniquecode; " &
                        "DELETE FROM year2_remarks WHERE unique_code = @uniquecode; " &
                        "DELETE FROM year3rd_data_tbl WHERE unique_code = @uniquecode; "
                    ' Create a command with parameters
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No data deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Public Sub updateKeycode()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        ' Confirmation message box before update
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If confirmationResult = DialogResult.Yes Then
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    Dim query As String =
                    "UPDATE contract_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE data_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE commodity_unitcost_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE date_turnover_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE date_validation_report SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE disbursement_2nd SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE disbursement_76_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE disbursement_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE disbursement_yearend_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE disturbances_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE flexible_disbursement_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE inspector_details_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE maintenance_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE multispecies SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE plantation_estab_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE projectcost_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE remarks SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE site_status_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE status_registry SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE survival_rate_year1 SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE survival_rate_year2 SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE survival_rate_year3 SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE year2nd_data_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE year2_remarks SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; " &
                    "UPDATE year3rd_data_tbl SET unique_code = @newuniquecode WHERE unique_code = @uniquecode; "

                    ' Create a command with parameters
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@uniquecode", uniquecodeloading)
                        command.Parameters.AddWithValue("@newuniquecode", txtuniquecode.Text) ' Set new unique code here

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No data updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update2()
        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        deleterecords()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateKeycode()
        ongoing_details.Close()
        With ongoing_details
            .TopLevel = False
            maindash.Panel5.Controls.Add(ongoing_details)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub
End Class