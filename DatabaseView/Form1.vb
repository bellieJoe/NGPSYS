Imports System.Diagnostics.Eventing.Reader
Imports Mysqlx.XDevAPI.Relational

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()

        loadTable()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        opencon()

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO data (No,Year,Region,District,CENRO,PENRO,Municipality,Barangay,Name_of_org,Type_org,
                                Tenure,Target_area,Seedling_req,Seedling_pro,Seedling_plant,Contract_c,Component,Commodity,
                                Narra,Zone,Unique_code,Dis_date,Dis_area_dam,Activities_conducted,funding_source,Final_date,Survival_rate11_20,
                                Classification,After_date,After_area_dam,After_type_dam,third_date,third_survival,Date_visit,Final_inspect_date,Survival_rate(11-20),remarks) VALUES ('" & TextBox1.Text & "',
                                '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & cenro.Text & "' ,'" & Penro.Text & "' ,'" & TextMunicipality.Text & "' ,'" & TextBoxBarangay.Text & "'
                                   ,'" & TextOrg.Text & "' ,'" & Texttype.Text & "' ,'" & Texttenure.Text & "' ,'" & Textregion.Text & "' ,'" & Texttarget.Text & "' ,'" & Textseedreq.Text & "' ,'" & Textseedpro.Text & "' ,'" & Textseedplantno.Text & "' ,'" & Textcontract.Text & "' ,'" & Textcomponent.Text & "'
                                        ,'" & Textcommodity.Text & "' ,'" & Textspeciesplant.Text & "' ,'" & Textzone.Text & "' ,'" & Textunique.Text & "' ,'" & Textdateofoccur.Text & "' ,'" & Textareadam.Text & "' ,'" & Textactconduct.Text & "' ,'" & Textsource.Text & "' ,'" & textdate.Text & "'
                                            ,'" & finalsurvival.Text & "' ,'" & classification.Text & "', '" & after_dis_date.Text & "' ,'" & after_dis_area_dam.Text & "', '" & Textactconduct.Text & "', '" & finalsurvival.Text & "', '" & classification.Text & "', '" & after_dis_date.Text & "','" & after_dis_area_dam.Text & "',
                                              '" & after_dis_type_dam.Text & "', '" & thirdparty.Text & "', '" & survivalpercent.Text & "', '" & Textdatevisit.Text & "', '" & Textdateconduct.Text & "', '" & Textsurvival1120.Text & "', '" & remark.Text & "' )"


            cmd.ExecuteNonQuery()
            MsgBox("Successfully added method")
            con.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            loadTable()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE data SET Firstname = '" & TextBox2.Text & "', Lastname = '" & TextBox3.Text & "'
                               , Age = '" & TextBox4.Text & "' WHERE ID = '" & TextBox1.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Successfully Updated Record")

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            loadTable()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Sub loadTable()
        opencon()


        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ngpalldate"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.Item("No", DataGridView1.CurrentRow.Index).Value
        TextBox2.Text = DataGridView1.Item("Year", DataGridView1.CurrentRow.Index).Value
        TextBox3.Text = DataGridView1.Item("Region", DataGridView1.CurrentRow.Index).Value
        TextBox4.Text = DataGridView1.Item("District", DataGridView1.CurrentRow.Index).Value
        cenro.Text = DataGridView1.Item("CENRO", DataGridView1.CurrentRow.Index).Value
        Penro.Text = DataGridView1.Item("PENRO", DataGridView1.CurrentRow.Index).Value
        TextMunicipality.Text = DataGridView1.Item("Municipality", DataGridView1.CurrentRow.Index).Value
        TextBoxBarangay.Text = DataGridView1.Item("Barangay", DataGridView1.CurrentRow.Index).Value
        TextOrg.Text = DataGridView1.Item("Name_of_Org", DataGridView1.CurrentRow.Index).Value
        Texttype.Text = DataGridView1.Item("Type_org", DataGridView1.CurrentRow.Index).Value
        Texttenure.Text = DataGridView1.Item("Tenure", DataGridView1.CurrentRow.Index).Value
        Textregion.Text = DataGridView1.Item("Region", DataGridView1.CurrentRow.Index).Value
        Texttarget.Text = DataGridView1.Item("Target_area", DataGridView1.CurrentRow.Index).Value
        Textseedreq.Text = DataGridView1.Item("Seedling_req", DataGridView1.CurrentRow.Index).Value
        Textseedpro.Text = DataGridView1.Item("Seedling_pro", DataGridView1.CurrentRow.Index).Value
        Textseedplantno.Text = DataGridView1.Item("Seedling_plant", DataGridView1.CurrentRow.Index).Value
        Textcontract.Text = DataGridView1.Item("Contract_c", DataGridView1.CurrentRow.Index).Value
        Textcomponent.Text = DataGridView1.Item("Component", DataGridView1.CurrentRow.Index).Value
        Textcommodity.Text = DataGridView1.Item("Commodity", DataGridView1.CurrentRow.Index).Value
        Textspeciesplant.Text = DataGridView1.Item("Narra", DataGridView1.CurrentRow.Index).Value
        Textzone.Text = DataGridView1.Item("Zone", DataGridView1.CurrentRow.Index).Value
        Textunique.Text = DataGridView1.Item("Unique_code", DataGridView1.CurrentRow.Index).Value
        Textdateofoccur.Text = DataGridView1.Item("Dis_date", DataGridView1.CurrentRow.Index).Value
        Textareadam.Text = DataGridView1.Item("Dis_area_dam", DataGridView1.CurrentRow.Index).Value
        Textactconduct.Text = DataGridView1.Item("Activities_conducted", DataGridView1.CurrentRow.Index).Value
        Textsource.Text = DataGridView1.Item("Funding_source", DataGridView1.CurrentRow.Index).Value
        textdate.Text = DataGridView1.Item("Final_date", DataGridView1.CurrentRow.Index).Value

        Dim finalsur As Decimal
        finalsur = DataGridView1.Item("Survival_rate11_20", DataGridView1.CurrentRow.Index).Value
        finalsurvival.Text = finalsur.ToString("0.00%")
        classification.Text = DataGridView1.Item("Classification", DataGridView1.CurrentRow.Index).Value
        after_dis_date.Text = DataGridView1.Item("After_date", DataGridView1.CurrentRow.Index).Value
        after_dis_area_dam.Text = DataGridView1.Item("After_area_dam", DataGridView1.CurrentRow.Index).Value
        after_dis_type_dam.Text = DataGridView1.Item("After_type_dam", DataGridView1.CurrentRow.Index).Value
        thirdparty.Text = DataGridView1.Item("third_date", DataGridView1.CurrentRow.Index).Value
        survivalpercent.Text = DataGridView1.Item("third_survival", DataGridView1.CurrentRow.Index).Value
        Textdatevisit.Text = DataGridView1.Item("Date_visit", DataGridView1.CurrentRow.Index).Value
        Textdateconduct.Text = DataGridView1.Item("Final_inspect_date", DataGridView1.CurrentRow.Index).Value

        Dim textsur As Decimal
        textsur = DataGridView1.Item("Survival_rate(11-20)", DataGridView1.CurrentRow.Index).Value
        Textsurvival1120.Text = textsur.ToString("0.00%")


        Textdateconduct.Text = DataGridView1.Item("Final_inspect_date", DataGridView1.CurrentRow.Index).Value
        remark.Text = DataGridView1.Item("remarks", DataGridView1.CurrentRow.Index).Value





    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        opencon()

        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ngpalldate WHERE Year = '" & ComboBox1.SelectedItem.ToString() & "' and Municipality='" & ComboBox2.SelectedItem.ToString() & "'
                                and Narra='" & ComboBox3.SelectedItem.ToString() & "'".ToLower()

            table = New DataTable()
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            con.Close()

            Label43.Text = table.Rows.Count.ToString
            comboboxclear()

            Dim colsum As Decimal
            Dim avesum As Decimal
            Dim survivalrate As Decimal
            Dim all As Decimal

            For Each R As DataGridViewRow In DataGridView1.Rows

                colsum += R.Cells(16).Value
                avesum += R.Cells(29).Value

            Next

            TextBox5.Text = colsum
            all = Convert.ToDouble(Label43.Text)
            survivalrate = (avesum / all)

            TextBox6.Text = survivalrate.ToString("0.00%")
            TextBox6.Enabled = False
            TextBox5.Enabled = False




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        opencon()

        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ngpalldate WHERE Year = '" & ComboBox1.SelectedItem.ToString() & "'".ToLower()

            table = New DataTable()
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            con.Close()

            Label43.Text = table.Rows.Count.ToString
            comboboxclear()

            If Label43.Text = "0" Then
                MsgBox("No data")
            End If

            Dim colsum As Decimal
            Dim avesum As Decimal
            Dim survivalrate As Decimal
            Dim all As Decimal

            ranny = New DataGridViewRow


            For Each R As DataGridViewRow In DataGridView1.Rows

                colsum += R.Cells(16).Value
                avesum += R.Cells(29).Value

            Next
            TextBox5.Text = colsum.ToString("n")

            all = Convert.ToDouble(Label43.Text)

            survivalrate = (avesum / all)

            TextBox6.Text = survivalrate.ToString("0.00%")

            TextBox6.Enabled = False
            TextBox5.Enabled = False







        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        opencon()

        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ngpalldate WHERE Municipality = '" & ComboBox2.SelectedItem.ToString() & "'".ToLower()

            table = New DataTable()
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            con.Close()

            Label43.Text = table.Rows.Count.ToString
            comboboxclear()

            If Label43.Text = "0" Then
                MsgBox("No data")
            End If

            Dim colsum As Decimal
            Dim avesum As Decimal
            Dim survivalrate As Decimal
            Dim all As Decimal


            For Each R As DataGridViewRow In DataGridView1.Rows

                colsum += R.Cells(16).Value
                avesum += R.Cells(29).Value

            Next
            TextBox5.Text = colsum
            all = Convert.ToDouble(Label43.Text)

            survivalrate = (avesum / all)

            TextBox6.Text = survivalrate.ToString("0.00%")

            TextBox6.Enabled = False
            TextBox5.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        opencon()

        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ngpalldate WHERE Narra = '" & ComboBox3.SelectedItem.ToString() & "'".ToLower()

            table = New DataTable()
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            con.Close()

            Label43.Text = table.Rows.Count.ToString
            comboboxclear()



            Dim colsum As Decimal
            Dim avesum As Decimal
            Dim survivalrate As Decimal
            Dim all As Decimal



            For Each R As DataGridViewRow In DataGridView1.Rows

                colsum += R.Cells(16).Value
                avesum += R.Cells(29).Value




            Next
            TextBox5.Text = colsum
            all = Convert.ToDouble(Label43.Text)

            survivalrate = (avesum / all)



            TextBox6.Text = survivalrate.ToString("0.00%")

            TextBox6.Enabled = False
            TextBox5.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub comboboxclear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
