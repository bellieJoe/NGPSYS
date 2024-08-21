Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class year2_inspection


    Private Sub year2_inspection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomCode As String = GenerateRandomUniqueCode(4)
        lblcode.Text = randomCode

    End Sub

    Public Function GenerateRandomUniqueCode(length As Integer) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim data As Byte() = New Byte(3) {}
        Dim result As New StringBuilder(length)
        Dim rng As New RNGCryptoServiceProvider()

        While result.Length < length
            rng.GetBytes(data)
            For Each b As Byte In data
                Dim charIndex As Integer = Convert.ToInt32(b) Mod chars.Length
                If result.Length < length Then
                    result.Append(chars(charIndex))
                End If
            Next
        End While

        Return result.ToString()
    End Function

    Private Sub daterequest_ValueChanged(sender As Object, e As EventArgs) Handles daterequest.ValueChanged

    End Sub

    Private Sub dateinspection_ValueChanged(sender As Object, e As EventArgs) Handles dateinspection.ValueChanged

    End Sub

    Private Sub AddTechnicalInspectionCommitteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTechnicalInspectionCommitteeToolStripMenuItem.Click
        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please change the date of request and inspection first!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            tic_change = 1
            add_TICinspector.ShowDialog()
        End If
    End Sub


    Private Sub AddRingWeddingAndRestakingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRingWeddingAndRestakingToolStripMenuItem.Click
        Dim currentDate As DateTime = DateTime.Now

        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = daterequest.Value

        ' Check if the selected date is equal to today's date
        If selectedDate.Date = currentDate.Date Then
            ' Display a message box to inform the user
            MessageBox.Show("Please change the date of request and inspection first!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            quarter1and2()
            ringwedding_restaking.Show(maindash)
            Me.Hide()
        End If
    End Sub

    Sub quarter1and2()
        ' Insert query with placeholders for parameters
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim insertQuery As String = "INSERT INTO year2nd_inspection_date (quarter_code, date_request, date_inspection) VALUES (@Value1, @Value2, @Value3)"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    ' Set parameter values for the insert query
                    insertCommand.Parameters.AddWithValue("@Value1", lblcode.Text) ' Replace with the actual values to insert
                    insertCommand.Parameters.AddWithValue("@Value2", daterequest.Value)
                    insertCommand.Parameters.AddWithValue("@Value3", dateinspection.Value)
                    ' Execute the SQL command to insert into the database
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        AddTechnicalInspectionCommitteeToolStripMenuItem.Visible = False
        AddRingWeddingAndRestakingToolStripMenuItem.Visible = False
    End Sub

    Private Sub TICInspectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TICInspectorToolStripMenuItem.Click
        Establisment_Pro.ShowDialog()
    End Sub
End Class