Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Drawing

Imports System.Security.Cryptography

Imports MySql.Data.MySqlClient
Imports System.Text
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Public Class Form1

    Inherits Form



    Public closeme As String



    Dim myconnection As New dbconnect
    Dim objadapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"


    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click

        loadingthis = 1


        If txtpass.Text = "" And txtuser.Text = "" Then

            MsgBox(" Please enter Username & Password! ", MsgBoxStyle.Information, "Information")


        ElseIf txtpass.Text = "" Then

            MsgBox(" Please enter Password! ", MsgBoxStyle.Information, "Information")


        ElseIf txtuser.Text = "" Then

            MsgBox("Please enter Username!", MsgBoxStyle.Information, "Information")


        Else
            Dim cmd As New MySqlCommand("Select * From account WHERE BINARY username = '" & txtuser.Text & "' and 
                                password= '" & txtpass.Text & "'", myconnection.open)
            cmd.Parameters.AddWithValue("username", txtuser.Text.Trim)
            cmd.Parameters.AddWithValue("password", txtpass.Text.Trim)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then

                user = reader("account_type").ToString()

                'change to super admin 
                If user = "ADMIN" Then
                    Dim name As String = txtuser.Text
                    maindash.txtusername.Text = name
                    personnel = 1
                    maindash.Show()

                ElseIf user = "SUPER ADMIN" Then
                    Dim name As String = txtuser.Text
                    maindash.txtusername.Text = name
                    personnel = 2
                    maindash.Show()

                Else
                    Dim name As String = txtuser.Text
                    maindash.txtusername.Text = name
                    personnel = 0
                    maindash.Show()
                    maindash.btnAdminNav.Visible = False



                End If


                Me.Hide()
            Else
                MsgBox("Invalid Username or Password!", MsgBoxStyle.Exclamation, "Warning")
                txtuser.Clear()
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

    Private Sub Btncancel_Click(sender As Object, e As EventArgs)


        Dim result As DialogResult = MessageBox.Show("Are you sure to exit the program ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()


        Else
            Me.Show()

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True


        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 20 ' You can adjust the radius to control the roundness of the edges

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddLine(radius, 0, Me.Width - radius, 0)
        path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddLine(Me.Width, radius, Me.Width, Me.Height - radius)
        path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddLine(Me.Width - radius, Me.Height, radius, Me.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()



        Me.Region = New Region(path)

        panel()


    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub panel()
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Panel3.Width, Panel3.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, Panel3.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(Panel3.Width, radius, Panel3.Width, Panel3.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(Panel3.Width - radius, Panel3.Height, radius, Panel3.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        Panel3.Region = New Region(panelPath)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add_user.Show()
        Me.Hide()


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

    Private Sub txtpass_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus
        CheckBox1.Checked = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        zone_maintenance.ShowDialog()
    End Sub


    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If closeme = 1 Then
            Application.Exit()
        Else

        End If



    End Sub

End Class
