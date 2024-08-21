
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient

Public Class MultipleSpecies

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Public totalproduce As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection.Open()

        Try
            If spec1.Text = "" Or txt1.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec1.Text)
                command.Parameters.AddWithValue("@Value4", txt1.Text)
                command.Parameters.AddWithValue("@Value5", ticspec1.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt1.Text)
                totalproduce += inputValue



                spec2.Enabled = True
                txt2.Enabled = True
                btn2add.Enabled = True
                btn2clear.Enabled = True
                ticspec2.Enabled = True
                Button3.Enabled = True




                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn2add.Click
        connection.Open()

        Try
            If spec2.Text = "" Or txt2.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req, tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec2.Text)
                command.Parameters.AddWithValue("@Value4", txt2.Text)
                command.Parameters.AddWithValue("@Value5", ticspec2.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt2.Text)
                totalproduce += inputValue


                spec3.Enabled = True
                txt3.Enabled = True
                btn3add.Enabled = True
                btn3clear.Enabled = True
                ticspec3.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayAllItems()
        Dim allItems As String = ""
        Dim allseed As String = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn3add.Click
        connection.Open()

        Try
            If spec3.Text = "" Or txt3.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req, tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec3.Text)
                command.Parameters.AddWithValue("@Value4", txt3.Text)
                command.Parameters.AddWithValue("@Value5", ticspec3.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt3.Text)
                totalproduce += inputValue


                spec4.Enabled = True
                txt4.Enabled = True
                btn4add.Enabled = True
                btn4clear.Enabled = True
                ticspec4.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")



            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn4add.Click
        connection.Open()

        Try
            If spec4.Text = "" Or txt4.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req, tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec4.Text)
                command.Parameters.AddWithValue("@Value4", txt4.Text)
                command.Parameters.AddWithValue("@Value5", ticspec4.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt4.Text)
                totalproduce += inputValue

                spec5.Enabled = True
                txt5.Enabled = True
                btn5add.Enabled = True
                btn5clear.Enabled = True
                ticspec5.Enabled = True


                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn5add.Click
        connection.Open()

        Try
            If spec5.Text = "" Or txt5.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req, tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec5.Text)
                command.Parameters.AddWithValue("@Value4", txt5.Text)
                command.Parameters.AddWithValue("@Value5", ticspec5.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt5.Text)
                totalproduce += inputValue

                spec6.Enabled = True
                txt6.Enabled = True
                btn6add.Enabled = True
                btn6clear.Enabled = True
                ticspec6.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub btn6add_Click(sender As Object, e As EventArgs) Handles btn6add.Click
        connection.Open()

        Try
            If spec6.Text = "" Or txt6.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec6.Text)
                command.Parameters.AddWithValue("@Value4", txt6.Text)
                command.Parameters.AddWithValue("@Value5", ticspec6.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt6.Text)
                totalproduce += inputValue

                spec7.Enabled = True
                txt7.Enabled = True
                btn7add.Enabled = True
                btn7clear.Enabled = True
                ticspec7.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn7add_Click(sender As Object, e As EventArgs) Handles btn7add.Click
        connection.Open()

        Try
            If spec7.Text = "" Or txt7.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec7.Text)
                command.Parameters.AddWithValue("@Value4", txt7.Text)
                command.Parameters.AddWithValue("@Value5", ticspec7.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt7.Text)
                totalproduce += inputValue

                spec8.Enabled = True
                txt8.Enabled = True
                btn8add.Enabled = True
                btn8clear.Enabled = True
                ticspec8.Enabled = True
                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn8add_Click(sender As Object, e As EventArgs) Handles btn8add.Click
        connection.Open()

        Try
            If spec8.Text = "" Or txt8.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec8.Text)
                command.Parameters.AddWithValue("@Value4", txt8.Text)
                command.Parameters.AddWithValue("@Value5", ticspec8.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()


                Dim inputValue As Double = Double.Parse(txt8.Text)
                totalproduce += inputValue

                spec9.Enabled = True
                txt9.Enabled = True
                btn9add.Enabled = True
                btn9clear.Enabled = True
                ticspec9.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn9add_Click(sender As Object, e As EventArgs) Handles btn9add.Click
        connection.Open()

        Try
            If spec9.Text = "" Or txt9.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec9.Text)
                command.Parameters.AddWithValue("@Value4", txt9.Text)
                command.Parameters.AddWithValue("@Value5", ticspec9.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()




                Dim inputValue As Double = Double.Parse(txt9.Text)
                totalproduce += inputValue

                spec10.Enabled = True
                txt10.Enabled = True
                btn10add.Enabled = True
                btn10clear.Enabled = True
                ticspec10.Enabled = True

                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn10add_Click(sender As Object, e As EventArgs) Handles btn10add.Click
        connection.Open()

        Try
            If spec10.Text = "" Or txt10.Text = "" Then
                MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO multispecies (unique_code,seed_produce_code,multispecies_name,multiseed_req,tic_counted) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", uniquecode)
                command.Parameters.AddWithValue("@Value2", date_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", spec10.Text)
                command.Parameters.AddWithValue("@Value4", txt10.Text)
                command.Parameters.AddWithValue("@Value5", ticspec10.Text)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()



                Dim inputValue As Double = Double.Parse(txt10.Text)
                totalproduce += inputValue


                ' Optionally, display a success message
                MessageBox.Show("Species successfully added.")

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub MultipleSpecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbspecies()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Enabled = False Then
            MessageBox.Show("Add first your species!")
        Else
            Updateseedlingproduce()
            date_inspection.Close()
            ResetFormControls(Me)
            Me.Close()

        End If



    End Sub
    Private Sub Updateseedlingproduce()

        Try
            connection.Open()

            Dim query As String = "UPDATE data_tbl SET seed_pro = @newValue WHERE data_id = @primaryKeyValue"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@newValue", totalproduce) ' Set the new value you want to update
                cmd.Parameters.AddWithValue("@primaryKeyValue", seedlingproduceprimamry) ' Set the primary key value
                cmd.ExecuteNonQuery()
                MessageBox.Show("Seedling production report succesfully added.")
                totalproduce = 0
                Seedling_pro.Close()
                Seedling_pro.Show(maindash)

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Sub cmbspecies()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT species_name FROM species_tbl ORDER BY species_name ASC;"

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            spec1.Items.Clear()
            spec2.Items.Clear()
            spec3.Items.Clear()
            spec4.Items.Clear()
            spec5.Items.Clear()
            spec6.Items.Clear()
            spec7.Items.Clear()
            spec8.Items.Clear()
            spec9.Items.Clear()
            spec10.Items.Clear()
            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                spec1.Items.Add(reader.GetString(0))
                spec2.Items.Add(reader.GetString(0))
                spec3.Items.Add(reader.GetString(0))
                spec4.Items.Add(reader.GetString(0))
                spec5.Items.Add(reader.GetString(0))
                spec6.Items.Add(reader.GetString(0))
                spec7.Items.Add(reader.GetString(0))
                spec8.Items.Add(reader.GetString(0))
                spec9.Items.Add(reader.GetString(0))
                spec10.Items.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub InitializeComboBoxes()
        ' Your database connection code here...
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"


        Try
            connection.Open()
            Dim allComboBoxes As ComboBox() = {spec1, spec2, spec3, spec4, spec5, spec6, spec7, spec8, spec9, spec10}

            For Each cmb In allComboBoxes
                cmb.Items.Clear()
            Next

            Dim selectRecordQuery As String = "SELECT species_name FROM species_tbl ORDER BY species_name ASC;"
            Dim command As New MySqlCommand(selectRecordQuery, connection)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim speciesName As String = reader.GetString(0)
                For Each cmb In allComboBoxes
                    cmb.Items.Add(speciesName)
                Next
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(control, ComboBox)
                comboBox.SelectedIndex = -1 ' Deselect all items
            ElseIf TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                textBox.Clear() ' Clear the text
            End If
        Next
        cmbspecies()
    End Sub

    'Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    ' TICdashboard.Show()
    'date_inspection.Close()
    ' End Sub

    Private Sub AddSpeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSpeciesToolStripMenuItem.Click
        NewSpecies.ShowDialog()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? Your progress wont be saved", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            FormUtilities.ClearFormControls(Me)
            Me.Close()
        Else

        End If
    End Sub

    Private Sub ResetFormControls(control As Control)
        For Each ctrl As Control In control.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = "" ' Reset text boxes to empty
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1 ' Reset combo boxes to no selection
            ElseIf ctrl.HasChildren Then
                ResetFormControls(ctrl) ' Recursively reset controls in containers
            End If
        Next
    End Sub
End Class