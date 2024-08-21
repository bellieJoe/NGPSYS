Imports MySql.Data.MySqlClient

Public Class authentication

    Dim myconnection As New dbconnect
    Dim objadapter As New MySqlDataAdapter
    Private Sub authentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub txtpass_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus
        If txtpass.Text = "Enter Password" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black ' Change the text color when typing starts
        End If
    End Sub

    Private Sub txtpass_LostFocus(sender As Object, e As EventArgs) Handles txtpass.LostFocus
        If txtpass.Text = "" Then
            txtpass.Text = "Enter Password"
            txtpass.ForeColor = Color.Gray ' Change the text color when no text is entered
        End If
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click



        If txtpass.Text = "" Then

            MsgBox(" Please enter Password! ", MsgBoxStyle.Information, "Information")

        Else
            Dim cmd As New MySqlCommand("Select * From account WHERE username = '" & txtuser.Text & "' and 
                                password= '" & txtpass.Text & "'", myconnection.open)
            cmd.Parameters.AddWithValue("username", txtuser.Text.Trim)
            cmd.Parameters.AddWithValue("password", txtpass.Text.Trim)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then

                user = reader("account_type").ToString()

                If user = "ADMIN" Then
                    add_user.Show()
                    Me.Close()
                Else



                End If

                Me.Hide()
            Else
                MsgBox("Invalid Password!", MsgBoxStyle.Exclamation, "Warning")

                txtpass.Clear()

            End If






            myconnection.close()


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then

            txtpass.UseSystemPasswordChar = True
        Else
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        add_user.ComboBox1.SelectedIndex = -1
        add_user.Show()
        Me.Close()


    End Sub
End Class