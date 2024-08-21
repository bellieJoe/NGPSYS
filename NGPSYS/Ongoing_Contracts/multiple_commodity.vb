Imports MySql.Data.MySqlClient

Public Class multiple_commodity

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub multiple_commodity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbcommodity()
        DisplayAllItems()


    End Sub

    Sub cmbcommodity()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity_name FROM commodity_tbl ;"

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbcom1.Items.Clear()
            cmbcom2.Items.Clear()
            cmbcom3.Items.Clear()
            cmbcom4.Items.Clear()
            cmbcom5.Items.Clear()

            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                cmbcom1.Items.Add(reader.GetString(0))
                cmbcom2.Items.Add(reader.GetString(0))
                cmbcom3.Items.Add(reader.GetString(0))
                cmbcom4.Items.Add(reader.GetString(0))
                cmbcom5.Items.Add(reader.GetString(0))

            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim commodity As String
        Dim seedling As String

        If cmbcom1.SelectedIndex = -1 Or txt1.Text = "" Then
            MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
        Else
            commodity = cmbcom1.Text
            seedling = txt1.Text
            add2022contract.ListBox1.Items.Add(cmbcom1.Text)
            add2022contract.ListBox2.Items.Add(txt1.Text)
            add2022contract.conspecies.Enabled = False

            insertcommodity(commodity, seedling)


            DisplayAllItems()

            cmbcom2.Enabled = True
            txt2.Enabled = True
            btn2add.Enabled = True
            btn2clear.Enabled = True
            MessageBox.Show("Data inserted successfully.")

        End If

    End Sub

    Private Sub btn2add_Click(sender As Object, e As EventArgs) Handles btn2add.Click
        Dim commodity As String
        Dim seedling As String
        If cmbcom2.SelectedIndex = -1 Or txt2.Text = "" Then
            MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
        Else
            commodity = cmbcom2.Text
            seedling = txt2.Text
            add2022contract.ListBox1.Items.Add(cmbcom2.Text)
            add2022contract.ListBox2.Items.Add(txt2.Text)
            add2022contract.conspecies.Enabled = False

            insertcommodity(commodity, seedling)

            DisplayAllItems()
            cmbcom3.Enabled = True
            txt3.Enabled = True
            btn3add.Enabled = True
            btn3clear.Enabled = True
            MessageBox.Show("Data inserted successfully.")

        End If
    End Sub

    Private Sub btn3add_Click(sender As Object, e As EventArgs) Handles btn3add.Click
        Dim commodity As String
        Dim seedling As String
        If cmbcom3.SelectedIndex = -1 Or txt3.Text = "" Then
            MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
        Else
            commodity = cmbcom3.Text
            seedling = txt3.Text
            add2022contract.ListBox1.Items.Add(cmbcom3.Text)
            add2022contract.ListBox2.Items.Add(txt3.Text)
            add2022contract.conspecies.Enabled = False

            insertcommodity(commodity, seedling)

            DisplayAllItems()
            cmbcom4.Enabled = True
            txt4.Enabled = True
            btn4add.Enabled = True
            btn4clear.Enabled = True
            MessageBox.Show("Data inserted successfully.")

        End If
    End Sub

    Private Sub btn4add_Click(sender As Object, e As EventArgs) Handles btn4add.Click
        If cmbcom4.SelectedIndex = -1 Or txt4.Text = "" Then
            MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
        Else

            add2022contract.ListBox1.Items.Add(cmbcom4.Text)
            add2022contract.ListBox2.Items.Add(txt4.Text)
            add2022contract.conspecies.Enabled = False
            DisplayAllItems()
            cmbcom5.Enabled = True
            txt5.Enabled = True
            btn5add.Enabled = True
            btn5clear.Enabled = True
            MessageBox.Show("Data inserted successfully.")

        End If
    End Sub

    Private Sub btn5add_Click(sender As Object, e As EventArgs) Handles btn5add.Click
        If cmbcom5.SelectedIndex = -1 Or txt5.Text = "" Then
            MsgBox("Please Add two or more species !", MsgBoxStyle.Exclamation, "Warning")
        Else

            add2022contract.ListBox1.Items.Add(cmbcom5.Text)
            add2022contract.ListBox2.Items.Add(txt5.Text)
            DisplayAllItems()
            addcontract.conspecies.Enabled = False
            MessageBox.Show("Data inserted successfully.")

        End If
    End Sub

    Private Sub DisplayAllItems()
        Dim allcommodity As String = ""
        Dim allseed As String = ""

        For Each item As Object In add2022contract.ListBox1.Items
            allcommodity &= item.ToString() & Environment.NewLine
        Next

        add2022contract.txtlist1.Text = allcommodity

        For Each itemseed As Object In add2022contract.ListBox2.Items
            allseed &= itemseed.ToString() & Environment.NewLine
        Next

        add2022contract.txtlist2.Text = allseed
    End Sub

    Private Sub insertcommodity(commodity As String, seedling As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Try

            Dim query As String = "INSERT INTO commodity_unitcost_tbl (unique_code, commodity_name, seedlingcount ) VALUES (@Value1, @Value2, @Value3)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", add2022contract.randomid.Text)
            command.Parameters.AddWithValue("@Value2", commodity)
            command.Parameters.AddWithValue("@Value3", seedling)
            command.ExecuteNonQuery()

            ' Close the connection
            connection.Close()

            ' Optionally, display a success message
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFormData()

        For Each ctrl As Control In Me.Controls
            add2022contract.conspecies.Enabled = True
            If TypeOf ctrl Is TextBox Then
                ' Clear TextBox
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                ' Reset ComboBox selection
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                ' Uncheck CheckBox
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is ListBox Then
                ' Clear ListBox items
                DirectCast(ctrl, ListBox).Items.Clear()
                ' Add more conditions based on the types of controls you have
            End If
        Next



    End Sub
    Private Sub FormClosing(sender As Object, e As FormClosingEventArgs)
        ClearFormData()

    End Sub


End Class