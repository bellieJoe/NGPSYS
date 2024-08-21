Imports System.Diagnostics.Contracts
Imports System.Drawing.Drawing2D
Imports System.Windows
Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class New_Organization

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub New_Organization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtorgcon.Enabled = False
    End Sub

    Private Sub btnaddcontact_Click(sender As Object, e As EventArgs) Handles btnaddcontact.Click

        btnaddcontact.Visible = False
        Contact.ShowDialog()


    End Sub

    Private Sub Btnconupdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnconupdate_Click_1(sender As Object, e As EventArgs) Handles Btnconupdate.Click
        connection.Open()


        Dim reader1 As MySqlDataReader
        'Replace column_name And your_table with the actual column name And table you want to retrieve the last value from.
        Dim query As String = "SELECT Firstname,Middlename,Lastname,Phone,Address FROM Contact_tbl ORDER BY Contact_ID DESC LIMIT 1"
        Using cmd1 As MySqlCommand = New MySqlCommand(query, connection)

            ' Execute the query and read the data.
            reader1 = cmd1.ExecuteReader()


            If reader1.Read() Then
                ' Get the value of the column from the last row.
                Contact.txtfirstname.Text = reader1("Firstname").ToString()
                Contact.txtmiddlename.Text = reader1("Middlename").ToString()
                Contact.txtlastname.Text = reader1("Lastname").ToString()
                Contact.txtphonenum.Text = reader1("Phone").ToString()
                Contact.txtaddress.Text = reader1("Address").ToString()

                ' Display the concatenated string in the textbox.
                Me.Hide()
                Contact.Show()
                Contact.Btnsavecontact.Hide()


            Else
                ' Handle the case where no data is found.

            End If

            connection.Close()

        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Try
            If txtorg.Text = "" Or txtorgcon.Text = "" Or txtneworgtype.Text = "" Or txtneworgten.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                connection.Open()

                Dim query As String = "INSERT INTO Organizational_tbl (Org_name, Org_type, Org_tenure) VALUES (@Value1, @Value2, @Value3)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtorg.Text)
                command.Parameters.AddWithValue("@Value2", txtneworgtype.Text)
                command.Parameters.AddWithValue("@Value3", txtneworgten.Text)
                command.ExecuteNonQuery()

                ' Replace column1, column2, and column3 with the actual column names you want to retrieve.



                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                ClearFormData()
                btnaddcontact.Show()
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub

    Private Sub ClearFormData()
        For Each ctrl As Control In Me.Controls
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


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ClearFormData()
    End Sub

End Class