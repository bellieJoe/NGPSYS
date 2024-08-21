Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class add_user

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub DrawColoredBorder(panel As Panel, borderColor As Color, e As PaintEventArgs)
        Dim borderRect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
        Dim borderPen As New Pen(borderColor)
        e.Graphics.DrawRectangle(borderPen, borderRect)
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = Color.Gray
        DrawColoredBorder(panel, borderColor, e)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtuser_GotFocus(sender As Object, e As EventArgs) Handles txtuser.GotFocus
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtuser_LostFocus(sender As Object, e As EventArgs) Handles txtuser.LostFocus
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Enter Email" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter Email"
            TextBox1.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub



    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Enter Password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Enter Password"
            TextBox2.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub



    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        If TextBox3.Text = "Re Enter Password" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.Text = "Re Enter Password"
            TextBox3.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub


    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click

        If txtuser.Text = "username" Or TextBox1.Text = "Enter Email" Or TextBox2.Text = "Enter Password" Or TextBox3.Text = "Re Enter Password" Or ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please Complete all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Your password is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            submit()
        End If




    End Sub



    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckBox1.Checked = True
        CheckBox2.Checked = True

        If CheckBox1.Checked = True Then

            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If


        If CheckBox2.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If


    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then

            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then

            TextBox3.UseSystemPasswordChar = True
        Else
            TextBox3.UseSystemPasswordChar = False
        End If
    End Sub


    Private Sub submit()




        Try
            If ComboBox1.SelectedIndex = -1 Or txtuser.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else
                connection.Open()
                Dim selectedValue As String = ""


                If RadioButton1.Checked Then
                    selectedValue = RadioButton1.Text
                ElseIf RadioButton2.Checked Then
                    selectedValue = RadioButton2.Text
                End If


                Dim query As String = "INSERT INTO account (account_type, username, email_address, password, firstname, middlename, lastname, address, phone_num, gender) 
                                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", ComboBox1.Text)
                command.Parameters.AddWithValue("@Value2", txtuser.Text)
                command.Parameters.AddWithValue("@Value3", TextBox1.Text)
                command.Parameters.AddWithValue("@Value4", TextBox2.Text)
                command.Parameters.AddWithValue("@Value5", txtfirstname.Text)
                command.Parameters.AddWithValue("@Value6", txtmiddlename.Text)
                command.Parameters.AddWithValue("@Value7", txtlastname.Text)
                command.Parameters.AddWithValue("@Value8", txtaddress.Text)
                command.Parameters.AddWithValue("@Value9", txtphonenum.Text)
                command.Parameters.AddWithValue("@Value10", selectedValue)
                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("You must enter the admin password for this type of account", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ' Check if the user clicked the OK button.
            If result = DialogResult.OK Then
                ' Code to execute after OK button is clicked.
                authentication.ShowDialog()


            Else

                ComboBox1.SelectedIndex = -1
                Me.Show()


            End If

        End If


    End Sub

    Private Sub txtfirstname_GotFocus(sender As Object, e As EventArgs) Handles txtfirstname.GotFocus
        If txtfirstname.Text = "Firstname" Then
            txtfirstname.Text = ""
            txtfirstname.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtfirstname_LostFocus(sender As Object, e As EventArgs) Handles txtfirstname.LostFocus
        If txtfirstname.Text = "" Then
            txtfirstname.Text = "Firstname"
            txtfirstname.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub txtmiddlename_GotFocus(sender As Object, e As EventArgs) Handles txtmiddlename.GotFocus
        If txtmiddlename.Text = "Middlename" Then
            txtmiddlename.Text = ""
            txtmiddlename.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtmiddlename_LostFocus(sender As Object, e As EventArgs) Handles txtmiddlename.LostFocus
        If txtmiddlename.Text = "" Then
            txtmiddlename.Text = "Middlename"
            txtmiddlename.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub txtlastname_GotFocus(sender As Object, e As EventArgs) Handles txtlastname.GotFocus
        If txtlastname.Text = "Lastname" Then
            txtlastname.Text = ""
            txtlastname.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtlastname_LostFocus(sender As Object, e As EventArgs) Handles txtlastname.LostFocus
        If txtlastname.Text = "" Then
            txtlastname.Text = "Lastname"
            txtlastname.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub txtaddress_GotFocus(sender As Object, e As EventArgs) Handles txtaddress.GotFocus
        If txtaddress.Text = "Address" Then
            txtaddress.Text = ""
            txtaddress.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtaddress_LostFocus(sender As Object, e As EventArgs) Handles txtaddress.LostFocus
        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
            txtaddress.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub txtphonenum_GotFocus(sender As Object, e As EventArgs) Handles txtphonenum.GotFocus
        If txtphonenum.Text = "Phone number" Then
            txtphonenum.Text = ""
            txtphonenum.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtphonenum_LostFocus(sender As Object, e As EventArgs) Handles txtphonenum.LostFocus
        If txtphonenum.Text = "" Then
            txtphonenum.Text = "Phone number"
            txtphonenum.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub
End Class