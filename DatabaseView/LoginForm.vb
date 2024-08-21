Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim myconnection As New dbconnect
    Dim objadapter As New MySqlDataAdapter
    Dim dtable As New DataTable



    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click

        If txtpass.Text = "" And txtuser.Text = "" Then

            MsgBox("Please Enter username & password")


        ElseIf txtpass.Text = "" Then
            MsgBox("Please Enter password")


        ElseIf txtuser.Text = "" Then

            MsgBox("Please Enter username")

        Else
            Dim cmd As New MySqlCommand("Select * From useraccount WHERE username = '" & txtuser.Text & "' and 
                                password= '" & txtpass.Text & "'", myconnection.open)
            cmd.Parameters.AddWithValue("username", txtuser.Text.Trim)
            cmd.Parameters.AddWithValue("password", txtpass.Text.Trim)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password")
                txtuser.Clear()
                txtpass.Clear()

            End If

            myconnection.close()


        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class