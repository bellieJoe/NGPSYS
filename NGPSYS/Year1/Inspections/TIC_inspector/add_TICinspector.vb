Imports MySql.Data.MySqlClient

Public Class add_TICinspector

    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub add_TICinspector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tic_change = 2 Then
            btn3save.BringToFront()
        ElseIf tic_change = 1 Then
            Btn2tic.BringToFront()
        Else
            Btnsavecontact.BringToFront()
        End If
    End Sub

    Private Sub Btnsavecontact_Click(sender As Object, e As EventArgs) Handles Btnsavecontact.Click


        TICdashboard.Close()
        With TICdashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(TICdashboard)
            .BringToFront()
            .Show()
        End With
        connection.Open()
        Try
            If txtfirstname.Text = "" Or txtlastname.Text = "" Or txtjob.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO inspector_details_tbl (unique_code, firstname, middlename, lastname, job_position, date_request, date_inspection) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", ongoing_details.txtuniquecode.Text)
                command.Parameters.AddWithValue("@Value2", txtfirstname.Text)
                command.Parameters.AddWithValue("@Value3", txtmiddlename.Text)
                command.Parameters.AddWithValue("@Value4", txtlastname.Text)
                command.Parameters.AddWithValue("@Value5", txtjob.Text)
                command.Parameters.AddWithValue("@Value6", date_inspection.daterequest.Value)
                command.Parameters.AddWithValue("@Value7", date_inspection.dateinspection.Value)

                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("TIC Inspector added succesfully.")
                FormUtilities.ClearFormControls(Me)

                Establisment_Pro.cmbdateinspected()

                Establisment_Pro.ShowDialog()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub Btn2tic_Click(sender As Object, e As EventArgs) Handles Btn2tic.Click
        Year2_dashboard.Close()
        With Year2_dashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(Year2_dashboard)
            .BringToFront()
            .Show()
        End With
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Try
            If txtfirstname.Text = "" Or txtlastname.Text = "" Or txtjob.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO inspector_details_tbl (unique_code, filter_code, firstname, middlename, lastname, job_position, date_request, date_inspection) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", ongoing_details.txtuniquecode.Text)
                command.Parameters.AddWithValue("@Value2", year2_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", txtfirstname.Text)
                command.Parameters.AddWithValue("@Value4", txtmiddlename.Text)
                command.Parameters.AddWithValue("@Value5", txtlastname.Text)
                command.Parameters.AddWithValue("@Value6", txtjob.Text)
                command.Parameters.AddWithValue("@Value7", year2_inspection.daterequest.Value)
                command.Parameters.AddWithValue("@Value8", year2_inspection.dateinspection.Value)

                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("TIC Inspector added succesfully.")
                FormUtilities.ClearFormControls(Me)

                Establisment_Pro.displayinspector()

                Establisment_Pro.ShowDialog()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn3save_Click(sender As Object, e As EventArgs) Handles btn3save.Click
        Year3_dashboard.Close()
        With Year3_dashboard
            .TopLevel = False
            maindash.Panel5.Controls.Add(Year3_dashboard)
            .BringToFront()
            .Show()
        End With
        connection.Open()
        Try
            If txtfirstname.Text = "" Or txtlastname.Text = "" Or txtjob.Text = "" Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")
            Else

                Dim query As String = "INSERT INTO inspector_details_tbl (unique_code, filter_code, firstname, middlename, lastname, job_position, date_request, date_inspection) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Value1", ongoing_details.txtuniquecode.Text)
                command.Parameters.AddWithValue("@Value2", Year3_inspection.lblcode.Text)
                command.Parameters.AddWithValue("@Value3", txtfirstname.Text)
                command.Parameters.AddWithValue("@Value4", txtmiddlename.Text)
                command.Parameters.AddWithValue("@Value5", txtlastname.Text)
                command.Parameters.AddWithValue("@Value6", txtjob.Text)
                command.Parameters.AddWithValue("@Value7", Year3_inspection.daterequest.Value)
                command.Parameters.AddWithValue("@Value8", Year3_inspection.dateinspection.Value)

                command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Optionally, display a success message
                MessageBox.Show("TIC Inspector added succesfully.")
                FormUtilities.ClearFormControls(Me)

                Establisment_Pro.displayinspector()

                Establisment_Pro.ShowDialog()

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Add your custom code here
        ' This code will run when the form is closing

        ' For example, you can prompt the user to confirm before closing:
        Dim result As DialogResult = MessageBox.Show("Do you want to add more Inspector details?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            e.Cancel = True ' Cancel the form closing event
        Else
            FormUtilities.ClearFormControls(Me)
            date_inspection.Close()
            year2_inspection.Close()
            Year3_inspection.Close()
        End If
    End Sub


End Class