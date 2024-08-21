
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Contact

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)



    Private Sub Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Btnsavecontact_Click(sender As Object, e As EventArgs) Handles Btnsavecontact.Click
        connection.Open()

        Try
            If txtfirstname.Text = "" Or txtlastname.Text = "" Or txtaddress.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO Contact_tbl (Firstname, Middlename, Lastname, Phone, Address) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", txtfirstname.Text)
                command.Parameters.AddWithValue("@Value2", txtmiddlename.Text)
                command.Parameters.AddWithValue("@Value3", txtlastname.Text)
                command.Parameters.AddWithValue("@Value4", txtphonenum.Text)
                command.Parameters.AddWithValue("@Value5", txtaddress.Text)
                command.ExecuteNonQuery()

                ' Replace column1, column2, and column3 with the actual column names you want to retrieve.


                contactdisplay()



                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                New_Organization.btnaddcontact.Visible = False
                New_Organization.Btnconupdate.Visible = True
                ClearFormData()



                Me.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub txtphonenum_TextChanged(sender As Object, e As EventArgs) Handles txtphonenum.TextChanged

    End Sub

    Private Sub txtphonenum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphonenum.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(8) Then
            ' If it's not a digit or Backspace, suppress the keypress
            e.Handled = True
        ElseIf txtphonenum.Text.Length > 11 Then
            ' Trim the input to keep only the first 11 numeric characters
            txtphonenum.Text = txtphonenum.Text.Substring(0, 11)

        End If
    End Sub




    Private Sub LoadCounterValue()
        Try
            connection.Open()
            Dim sql As String = "SELECT Contact_ID FROM contact_tbl"
            Dim cmd As New MySqlCommand(sql, connection)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Label1.Text = "Current Value: " & result.ToString()
            Else
                Label1.Text = "Current Value: 0"
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading counter value: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub IncrementCounter()
        Try
            connection.Open()
            Dim sql As String = "UPDATE Contact_tbl SET Contact_ID = Contact_ID + 1"
            Dim cmd As New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error incrementing counter value: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub contactdisplay()


        Dim reader1 As MySqlDataReader
        'Replace column_name And your_table with the actual column name And table you want to retrieve the last value from.
        Dim query As String = "SELECT Contact_ID,Firstname,Middlename,Lastname FROM Contact_tbl ORDER BY Contact_ID DESC LIMIT 1"
        Using cmd1 As MySqlCommand = New MySqlCommand(query, connection)

            ' Execute the query and read the data.
            reader1 = cmd1.ExecuteReader()


            If reader1.Read() Then
                ' Get the value of the column from the last row.
                Dim lastValue As String = reader1("Contact_ID").ToString
                Dim concatenatedValues As String = reader1("Firstname").ToString() & " " & reader1("Middlename").ToString() & " " & reader1("Lastname").ToString()

                ' Display the concatenated string in the textbox.
                New_Organization.txtorgcon.Text = concatenatedValues
                globalValue = CInt(lastValue)
            Else
                ' Handle the case where no data is found.

            End If



        End Using

    End Sub



















    Private Shared systemDefinedValue As Integer = 1
    Private Function GetSystemDefinedCustomerId() As Integer
        ' You can replace this with your own logic to get the system-defined customer ID.
        Return 1
    End Function
    Private Function GetNextSystemDefinedValue() As Integer
        ' Increment the system-defined value.
        systemDefinedValue += 1

        ' Return the incremented value.
        Return systemDefinedValue
    End Function

    Private Sub Btnnewupdate_Click(sender As Object, e As EventArgs) Handles Btnnewupdate.Click

        Dim query As String = "UPDATE Contact_tbl SET Firstname = @value1, Middlename= @value2, Lastname= @value3, Phone= @value4, Address= @value5 WHERE Contact_ID = @PrimaryKeyValue"
        Using command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@value1", txtfirstname.Text)
            command.Parameters.AddWithValue("@value2", txtmiddlename.Text)
            command.Parameters.AddWithValue("@value3", txtlastname.Text)
            command.Parameters.AddWithValue("@value4", txtphonenum.Text)
            command.Parameters.AddWithValue("@value5", txtaddress.Text)
            command.Parameters.AddWithValue("@PrimaryKeyValue", globalValue)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated successfully.")
                    contactdisplay()

                    Me.Close()

                Else
                    MessageBox.Show("No rows updated. Please check the primary key value.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error while updating data: " & ex.Message)
            End Try
        End Using


    End Sub

    Private Sub btnexitcontact_Click(sender As Object, e As EventArgs) Handles btnexitcontact.Click
        New_Organization.Show()
        New_Organization.btnaddcontact.Visible = True
        New_Organization.Btnconupdate.Visible = False
        Me.Close()
    End Sub

    Private Sub txtphonenum_GotFocus(sender As Object, e As EventArgs) Handles txtphonenum.GotFocus

        ' Check if the current text in the TextBox matches the placeholder text
        If txtphonenum.Text = "Ex.09777633512" Then
            ' Clear the TextBox when it's focused (to let the user start typing)
            txtphonenum.Text = ""
            ' Set the font color to black (optional, you can keep it the same if you prefer)
            txtphonenum.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtphonenum_LostFocus(sender As Object, e As EventArgs) Handles txtphonenum.LostFocus

        ' Check if the TextBox is empty
        If txtphonenum.Text = "" Then
            ' If it's empty, show the placeholder text again
            txtphonenum.Text = "Ex.09777633512"
            ' Set the font color to a placeholder color (optional, you can keep it the same if you prefer)
            txtphonenum.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtaddress_GotFocus(sender As Object, e As EventArgs) Handles txtaddress.GotFocus
        ' Check if the current text in the TextBox matches the placeholder text
        If txtaddress.Text = "Baranggay,Municipality" Then
            ' Clear the TextBox when it's focused (to let the user start typing)
            txtaddress.Text = ""
            ' Set the font color to black (optional, you can keep it the same if you prefer)
            txtaddress.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtaddress_LostFocus(sender As Object, e As EventArgs) Handles txtaddress.LostFocus
        If txtaddress.Text = "" Then
            ' If it's empty, show the placeholder text again
            txtaddress.Text = "Baranggay,Municipality"
            ' Set the font color to a placeholder color (optional, you can keep it the same if you prefer)
            txtaddress.ForeColor = Color.Gray
        End If
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
End Class