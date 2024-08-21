Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class user_profile
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub user_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        profile()
        panel()

    End Sub

    Sub profile()
        Try
            connection.Open()

            Dim query As String = "SELECT * FROM account WHERE username = @searchValue"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@searchValue", maindash.txtusername.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Assuming you have one column in the result set
                txtuser.Text = reader("username").ToString()
                txtemail.Text = reader("email_address").ToString()
                txtpass.Text = reader("password").ToString()
                txtfirstname.Text = reader("firstname").ToString()
                txtmiddlename.Text = reader("middlename").ToString()
                txtlastname.Text = reader("lastname").ToString()
                txtaddress.Text = reader("address").ToString()
                txtphonenum.Text = reader("phone_num").ToString()

                Dim gen As String = reader("gender").ToString()

                If gen = "Male" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True

                End If

            Else

            End If

            reader.Close()
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database operation
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Sub profile_update()
        Try
            connection.Open()

            Dim query As String = "UPDATE account SET " &
                          "username = @Value1, " &
                          "email_address = @Value2, " &
                          "password = @Value3, " &
                          "firstname = @Value4, " &
                          "middlename = @Value5, " &
                          "lastname = @Value6, " &
                          "address = @Value7, " &
                          "phone_num = @Value8, " &
                          "gender = @Value9 " &
                          "WHERE username = @searchValue"
            Dim cmd As New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@searchValue", maindash.txtusername.Text)
            cmd.Parameters.AddWithValue("@Value1", txtuser.Text)
            cmd.Parameters.AddWithValue("@Value2", txtemail.Text)
            cmd.Parameters.AddWithValue("@Value3", txtpass.Text)
            cmd.Parameters.AddWithValue("@Value4", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Value5", txtmiddlename.Text)
            cmd.Parameters.AddWithValue("@Value6", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Value7", txtaddress.Text)
            cmd.Parameters.AddWithValue("@Value8", txtphonenum.Text)

            Dim gender As String

            If RadioButton1.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            cmd.Parameters.AddWithValue("@Value9", gender)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Update successful. " & rowsAffected & " row(s) affected.")


            Else
                MessageBox.Show("No matching records found.")
            End If
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database operation
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        profile_update()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub panel()
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Panel11.Width, Panel11.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, panel11.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(panel11.Width, radius, panel11.Width, panel11.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(panel11.Width - radius, panel11.Height, radius, panel11.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        panel11.Region = New Region(panelPath)
    End Sub
End Class