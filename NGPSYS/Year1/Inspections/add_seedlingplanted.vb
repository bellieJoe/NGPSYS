Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class add_seedlingplanted
    Dim totalplanted As Double
    Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub add_seedlingplanted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuniquecode.Text = ongoing_details.txtuniquecode.Text.ToString
        txtorg.Text = ongoing_details.txtorg.Text.ToString

        panelone()
        PopulateTextBoxesAndLabels(txtuniquecode.Text.ToString)


    End Sub

    Private Sub panelone()
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, Panel1.Width, Panel1.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, Panel1.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(Panel1.Width, radius, Panel1.Width, Panel1.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(Panel1.Width - radius, Panel1.Height, radius, Panel1.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        Panel1.Region = New Region(panelPath)
    End Sub

    Private Sub PopulateTextBoxesAndLabels(uniqueCode As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim columnName As String = "multispecies_name" ' Replace with the name of your column
        Dim species_id As String = "multispecies_id"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = $"SELECT {species_id},{columnName} FROM multispecies WHERE unique_code = @UniqueCode"
            Dim a As Integer = 20
            Dim b As Integer = 30
            Dim c As Integer = 120
            Dim d As Integer = 30
            Dim e As Integer = 220
            Dim f As Integer = 30
            Dim itemHeight As Integer = 50
            Dim panelHeight As Integer = Panel1.Height ' Initialize panelHeight with the current height of Panel2
            Dim numItems As Integer = 0

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UniqueCode", uniqueCode)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Create a Label for the data


                        Dim label As New Label()
                        label.Text = reader(columnName).ToString()

                        Dim label2 As New LinkLabel()
                        label2.Text = reader(species_id).ToString()

                        ' Create a TextBox for data entry (if needed)
                        Dim textBox As New TextBox()

                        ' Position the Label and TextBox controls as desired
                        label.Location = New Point(a, b)
                        label2.Location = New Point(e, f)
                        textBox.Location = New Point(c, d)

                        ' Add Label and TextBox to Panel2
                        Panel1.Controls.Add(label)
                        Panel1.Controls.Add(textBox)
                        label2.Visible = False
                        Panel1.Controls.Add(label2)

                        ' Increment the Y-coordinate for the next item
                        b += itemHeight
                        d += itemHeight
                        f += itemHeight
                        ' Increment the panelHeight and numItems
                        panelHeight += itemHeight
                        numItems += 1
                    End While
                End Using
            End Using

            ' Check if the content exceeds the visible area of Panel2
            If panelHeight > Panel1.Height Then
                ' Enable automatic scrolling for Panel2
                Panel1.AutoScroll = True
            End If


        End Using
    End Sub

    Private Sub GetTextboxValues()
        ' Create a list to store the textbox values
        Dim textboxValues As New List(Of String)


        ' Iterate through the controls in Panel2
        For Each control As Control In Panel1.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                Dim value As String = textBox.Text
                textboxValues.Add(value)
            End If
        Next

        ' Display the collected values (you can modify this part as needed)
        For Each value As String In textboxValues
            ListBox1.Items.Add(value)
        Next


    End Sub

    Private Sub GetspeciesId()
        ' Create a list to store the textbox values
        Dim species_id As New List(Of String)


        ' Iterate through the controls in Panel2
        For Each control As Control In Panel1.Controls
            If TypeOf control Is LinkLabel Then
                Dim label2 As Label = DirectCast(control, Label)
                Dim value As String = label2.Text
                species_id.Add(value)
            End If
        Next

        ' Display the collected values (you can modify this part as needed)
        For Each value As String In species_id
            ListBox2.Items.Add(value)
        Next


    End Sub

    Private Sub UpdateDied()
        ' Update query with placeholders for parameters
        Dim updateQuery As String = "UPDATE multispecies SET seed_code = @SeedValue, seed_planted = @UpdateValue WHERE multispecies_id = @ConditionValue"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                For i As Integer = 0 To ListBox1.Items.Count - 1
                    Dim updateValue As String = ListBox1.Items(i).ToString()
                    Dim conditionValue As String = ListBox2.Items(i).ToString()

                    Using command As New MySqlCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@UpdateValue", updateValue)
                        command.Parameters.AddWithValue("@ConditionValue", conditionValue)
                        command.Parameters.AddWithValue("@SeedValue", date_inspection.lblcode.Text)

                        ' Execute the SQL command to update the database
                        command.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetTextboxValues()
        GetspeciesId()
        UpdatePlanted()
        Updateseedlingplanted()

    End Sub

    Private Sub UpdatePlanted()
        ' Update query with placeholders for parameters
        Dim updateQuery As String = "UPDATE multispecies SET seed_code = @SeedValue, seed_planted = @UpdateValue WHERE multispecies_id = @ConditionValue"

        ' Insert query with placeholders for parameters
        Dim insertQuery As String = "INSERT INTO seedplanted_tbl (seed_code, date_request, date_inspected) VALUES (@Value1, @Value2, @Value3)"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                For i As Integer = 0 To ListBox1.Items.Count - 1
                    Dim updateValue As String = ListBox1.Items(i).ToString()
                    Dim conditionValue As String = ListBox2.Items(i).ToString()
                    Dim inputValue As Double = Double.Parse(ListBox1.Items(i).ToString())
                    totalplanted += inputValue
                    ' Update existing records
                    Using updateCommand As New MySqlCommand(updateQuery, connection)
                        updateCommand.Parameters.AddWithValue("@UpdateValue", updateValue)
                        updateCommand.Parameters.AddWithValue("@ConditionValue", conditionValue)
                        updateCommand.Parameters.AddWithValue("@SeedValue", date_inspection.lblcode.Text)

                        ' Execute the SQL command to update the database
                        updateCommand.ExecuteNonQuery()
                    End Using

                    ' Data inserted successfully message
                    MessageBox.Show("Data inserted successfully.")
                Next
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    ' Set parameter values for the insert query
                    insertCommand.Parameters.AddWithValue("@Value1", date_inspection.lblcode.Text) ' Replace with the actual values to insert
                    insertCommand.Parameters.AddWithValue("@Value2", date_inspection.daterequest.Value)
                    insertCommand.Parameters.AddWithValue("@Value3", date_inspection.dateinspection.Value)

                    ' Execute the SQL command to insert into the database
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions here, e.g., display an error message or log the exception.
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Updateseedlingplanted()


        Try
            connection.Open()

            Dim query As String = "UPDATE data_tbl SET seed_plant = @newValue WHERE data_id = @primaryKeyValue"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@newValue", totalplanted) ' Set the new value you want to update
                cmd.Parameters.AddWithValue("@primaryKeyValue", ongoing_details.lblprimarykey.Text) ' Set the primary key value
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data updated successfully.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class