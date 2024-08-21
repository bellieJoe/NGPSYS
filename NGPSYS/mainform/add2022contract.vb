Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Text

Public Class add2022contract

    Public switchorg As New Integer

    Public Sub add2022contract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomCode As String = GenerateRandomUniqueCode(10)
        randomid.Text = randomCode
        cmborgselect()
        cmbcomponent()
        cmbcommodity()
        clear()
    End Sub

    Private Sub Btnbackadmin_Click(sender As Object, e As EventArgs) Handles Btnbackadmin.Click

        loadingthis += 1

        With dashboard
            .TopLevel = False
            Panel5.Controls.Add(dashboard)
            .BringToFront()
            .Show()
        End With


        Me.Close()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Organization.ShowDialog()

    End Sub


    Private Function comboorgname()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT DISTINCT Org_name FROM organizational_tbl "
        Dim choices As New List(Of String)


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Add each distinct choice to the list

                            choices.Add(reader("Org_name").ToString())
                        End While
                        reader.Close()
                    End Using
                End Using
                connection.Close()
            End Using

            ' Populate the combo box with the distinct choices

            cmbOrg.DataSource = choices


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally

        End Try

        Return choices



    End Function



    Private Sub newcontact_TextChanged(sender As Object, e As EventArgs) Handles newcontact.TextChanged

    End Sub

    Private Sub cmbOrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrg.SelectedIndexChanged

        If cmbOrg.SelectedIndex >= 0 Then
            Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

            Dim selectedRecordID As String = cmbOrg.SelectedItem.ToString()

            ' Query to retrieve data from two tables (replace with your actual query)
            Dim query As String = "SELECT * " &
                                 "FROM organizational_tbl " &
                                 "JOIN contact_tbl ON organizational_tbl.Org_ID = contact_tbl.Contact_ID " &
                                 "WHERE organizational_tbl.Org_name = @selectedID;"

            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@selectedID", selectedRecordID)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Display data in TextBoxes
                    Dim concatenatedValues As String = reader("Firstname").ToString() & " " & reader("Middlename").ToString() & " " & reader("Lastname").ToString()
                    newcontact.Text = concatenatedValues
                    Label18.Text = reader.GetString(0)
                    txttypeorg.Text = reader.GetString(2)
                    contenure.Text = reader.GetString(3)
                Else
                    MessageBox.Show("Error: ")

                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Sub cmborgselect()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT DISTINCT Org_name FROM organizational_tbl ORDER BY Org_name"


        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbOrg.Items.Clear()
            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                cmbOrg.Items.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Sub cmbcomponent()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT component_name FROM component_tbl ;"

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbcom.Items.Clear()
            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                cmbcom.Items.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Sub cmbcommodity()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim selectRecordQuery As String = "SELECT commodity_name FROM commodity_tbl ;"

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(selectRecordQuery, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            conspecies.Items.Clear()
            While reader.Read()
                ' Populate ComboBox with record IDs (replace 0 with the appropriate index if necessary)
                conspecies.Items.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub cmbmuni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmuni.SelectedIndexChanged
        If cmbmuni.SelectedIndex <> -1 Then
            ' Enable ComboBox2
            cmbbrgy.Enabled = True
            ' Clear previous items in ComboBox2 (optional)
            cmbbrgy.Items.Clear()
            ' Populate ComboBox2 based on the selected value in ComboBox1
            Select Case cmbmuni.SelectedItem.ToString()
                Case "BOAC"
                    cmbbrgy.Items.Add("AGOT")
                    cmbbrgy.Items.Add("AGUMAYMAYAN")
                    cmbbrgy.Items.Add("AMOINGON")
                    cmbbrgy.Items.Add("APITONG")
                    cmbbrgy.Items.Add("BALAGASAN")
                    cmbbrgy.Items.Add("BALARING")
                    cmbbrgy.Items.Add("BALIMBING")
                    cmbbrgy.Items.Add("BALOGO")
                    cmbbrgy.Items.Add("BAMBAN")
                    cmbbrgy.Items.Add("BANGBANGALON")
                    cmbbrgy.Items.Add("BANTAD")
                    cmbbrgy.Items.Add("BANTAY")
                    cmbbrgy.Items.Add("BAYUTI")
                    cmbbrgy.Items.Add("BINUNGA")
                    cmbbrgy.Items.Add("BOI")
                    cmbbrgy.Items.Add("BOTON")
                    cmbbrgy.Items.Add("BULIASNIN")
                    cmbbrgy.Items.Add("BUNGANAY")
                    cmbbrgy.Items.Add("CAGANHAO")
                    cmbbrgy.Items.Add("CANAT")
                    cmbbrgy.Items.Add("CATUBUGAN")
                    cmbbrgy.Items.Add("CAWIT")
                    cmbbrgy.Items.Add("DAIG")
                    cmbbrgy.Items.Add("DAYPAY")
                    cmbbrgy.Items.Add("DUYAY")
                    cmbbrgy.Items.Add("HINAPULAN")
                    cmbbrgy.Items.Add("IHATUB")
                    cmbbrgy.Items.Add("ISOK I")
                    cmbbrgy.Items.Add("ISOK II POBLACION")
                    cmbbrgy.Items.Add("LAYLAY")
                    cmbbrgy.Items.Add("LUPAC")
                    cmbbrgy.Items.Add("MAHINHIN")
                    cmbbrgy.Items.Add("MAINIT")
                    cmbbrgy.Items.Add("MALBOG")
                    cmbbrgy.Items.Add("MALIGAYA")
                    cmbbrgy.Items.Add("MALUSAK")
                    cmbbrgy.Items.Add("MANSIWAT")
                    cmbbrgy.Items.Add("MATAAS NA BAYAN")
                    cmbbrgy.Items.Add("MAYBO")
                    cmbbrgy.Items.Add("MERCADO")
                    cmbbrgy.Items.Add("MURALLON")
                    cmbbrgy.Items.Add("OGBAC")
                    cmbbrgy.Items.Add("PAWA")
                    cmbbrgy.Items.Add("PILI")
                    cmbbrgy.Items.Add("POCTOY")
                    cmbbrgy.Items.Add("PORAS")
                    cmbbrgy.Items.Add("PUTING BUHANGIN")
                    cmbbrgy.Items.Add("PUYOG")
                    cmbbrgy.Items.Add("SABONG")
                    cmbbrgy.Items.Add("SAN MIGUEL")
                    cmbbrgy.Items.Add("SANTOL")
                    cmbbrgy.Items.Add("SAWI")
                    cmbbrgy.Items.Add("TABIGUE")
                    cmbbrgy.Items.Add("TAGWAK")
                    cmbbrgy.Items.Add("TAMBUNAN")
                    cmbbrgy.Items.Add("TAMPUS")
                    cmbbrgy.Items.Add("TANZA")
                    cmbbrgy.Items.Add("TUGOS")
                    cmbbrgy.Items.Add("TUMAGABOK")
                    cmbbrgy.Items.Add("TUMAPON")



                Case "BUENAVISTA"
                    cmbbrgy.Items.Add("BAGACAY")
                    cmbbrgy.Items.Add("BAGTINGON")
                    cmbbrgy.Items.Add("BARANGAY I")
                    cmbbrgy.Items.Add("BARANGAY II")
                    cmbbrgy.Items.Add("BARANGAY III")
                    cmbbrgy.Items.Add("BARANGAY IV")
                    cmbbrgy.Items.Add("BICAS-BICAS")
                    cmbbrgy.Items.Add("CAIGANGAN")
                    cmbbrgy.Items.Add("DAYKITIN")
                    cmbbrgy.Items.Add("LIBAS")
                    cmbbrgy.Items.Add("MALBOG")
                    cmbbrgy.Items.Add("SIHI")
                    cmbbrgy.Items.Add("TIMBO")
                    cmbbrgy.Items.Add("TUNGIB-LIPATA")
                    cmbbrgy.Items.Add("YOOK")

                Case "GASAN"
                    cmbbrgy.Items.Add("ANTIPOLO")
                    cmbbrgy.Items.Add("BACHAO IBABA")
                    cmbbrgy.Items.Add("BACHAO ILAYA")
                    cmbbrgy.Items.Add("BACONGBACONG")
                    cmbbrgy.Items.Add("BAHI")
                    cmbbrgy.Items.Add("BANGBANG")
                    cmbbrgy.Items.Add("BANOT")
                    cmbbrgy.Items.Add("BANUYO")
                    cmbbrgy.Items.Add("BARANGAY I")
                    cmbbrgy.Items.Add("BARANGAY II")
                    cmbbrgy.Items.Add("BARANGAY III")
                    cmbbrgy.Items.Add("BOGNUYAN")
                    cmbbrgy.Items.Add("CABUGAO")
                    cmbbrgy.Items.Add("DAWIS")
                    cmbbrgy.Items.Add("DILI")
                    cmbbrgy.Items.Add("LIBTANGIN")
                    cmbbrgy.Items.Add("MAHUNIG")
                    cmbbrgy.Items.Add("MANGILIOL")
                    cmbbrgy.Items.Add("MASIGA")
                    cmbbrgy.Items.Add("MATANDANG GASAN")
                    cmbbrgy.Items.Add("PANGI")
                    cmbbrgy.Items.Add("PINGAN")
                    cmbbrgy.Items.Add("TABIONAN")
                    cmbbrgy.Items.Add("TAPUYAN")
                    cmbbrgy.Items.Add("TIGUION")

                Case "MOGPOG"
                    cmbbrgy.Items.Add("ANAPOG-SIBUCAO")
                    cmbbrgy.Items.Add("ARGAO")
                    cmbbrgy.Items.Add("BALANACAN")
                    cmbbrgy.Items.Add("BANTO")
                    cmbbrgy.Items.Add("BAHI")
                    cmbbrgy.Items.Add("BINTAKAY")
                    cmbbrgy.Items.Add("BOCBOC")
                    cmbbrgy.Items.Add("BUTANSAPA")
                    cmbbrgy.Items.Add("CANDAHON")
                    cmbbrgy.Items.Add("CAPAYANG")
                    cmbbrgy.Items.Add("DANAO")
                    cmbbrgy.Items.Add("DULONG BAYAN")
                    cmbbrgy.Items.Add("GITNANG BAYAN")
                    cmbbrgy.Items.Add("GUISAN")
                    cmbbrgy.Items.Add("HINADHARAN")
                    cmbbrgy.Items.Add("HINANGGAYON")
                    cmbbrgy.Items.Add("INO")
                    cmbbrgy.Items.Add("JANAGDONG")
                    cmbbrgy.Items.Add("LAMESA")
                    cmbbrgy.Items.Add("LAON")
                    cmbbrgy.Items.Add("MAGAPUA")
                    cmbbrgy.Items.Add("MALAYAK")
                    cmbbrgy.Items.Add("MALUSAK")
                    cmbbrgy.Items.Add("MAMPAITAN")
                    cmbbrgy.Items.Add("MANGYAN-MABABAD")
                    cmbbrgy.Items.Add("MARKET SITE")
                    cmbbrgy.Items.Add("MATAAS NA BAYAN")
                    cmbbrgy.Items.Add("MENDEZ")
                    cmbbrgy.Items.Add("NANGKA I")
                    cmbbrgy.Items.Add("NANGKA II")
                    cmbbrgy.Items.Add("PAYE")
                    cmbbrgy.Items.Add("PILI")
                    cmbbrgy.Items.Add("PUTING BUHANGIN")
                    cmbbrgy.Items.Add("SAYAO")
                    cmbbrgy.Items.Add("SILANGAN")
                    cmbbrgy.Items.Add("SUMANGGA")
                    cmbbrgy.Items.Add("TARUG")
                    cmbbrgy.Items.Add("VILLA MENDEZ")


                Case "STA. CRUZ"
                    cmbbrgy.Items.Add("ALOBO")
                    cmbbrgy.Items.Add("ANGAS")
                    cmbbrgy.Items.Add("ATURAN")
                    cmbbrgy.Items.Add("BAGONG SILANG POB.")
                    cmbbrgy.Items.Add("BAGUIDBIRIN")
                    cmbbrgy.Items.Add("BALIIS")
                    cmbbrgy.Items.Add("BALOGO")
                    cmbbrgy.Items.Add("BANAHAW POB.")
                    cmbbrgy.Items.Add("BANCUANGAN")
                    cmbbrgy.Items.Add("BANOGBOG")
                    cmbbrgy.Items.Add("BIGA")
                    cmbbrgy.Items.Add("BOTILAO")
                    cmbbrgy.Items.Add("BUYABOD")
                    cmbbrgy.Items.Add("DATING BAYAN")
                    cmbbrgy.Items.Add("DEVILLA")
                    cmbbrgy.Items.Add("DOLORES")
                    cmbbrgy.Items.Add("HAGUIMIT")
                    cmbbrgy.Items.Add("HUPI")
                    cmbbrgy.Items.Add("IPIL")
                    cmbbrgy.Items.Add("JOLO")
                    cmbbrgy.Items.Add("KAGANHAO")
                    cmbbrgy.Items.Add("KALANGKANG")
                    cmbbrgy.Items.Add("KAMANDUGAN")
                    cmbbrgy.Items.Add("KASILY")
                    cmbbrgy.Items.Add("KILO-KILO")
                    cmbbrgy.Items.Add("KIñAMAN")
                    cmbbrgy.Items.Add("LABO")
                    cmbbrgy.Items.Add("LAMESA")
                    cmbbrgy.Items.Add("LANDY")
                    cmbbrgy.Items.Add("LAPU-LAPU POB")
                    cmbbrgy.Items.Add("LIBJO")
                    cmbbrgy.Items.Add("LIPA")
                    cmbbrgy.Items.Add("LUSOK.")
                    cmbbrgy.Items.Add("MAHARLIKA POB")
                    cmbbrgy.Items.Add("MAKULAPNIT")
                    cmbbrgy.Items.Add("MANIWAYA")
                    cmbbrgy.Items.Add("MANLIBUNAN")
                    cmbbrgy.Items.Add("MASAGUISI")
                    cmbbrgy.Items.Add("MASALUKOT")
                    cmbbrgy.Items.Add("MATALABA")
                    cmbbrgy.Items.Add("MONGPONG")
                    cmbbrgy.Items.Add("MORALES")
                    cmbbrgy.Items.Add("NAPO")
                    cmbbrgy.Items.Add("PAG-ASA POB.")
                    cmbbrgy.Items.Add("PANTAYIN")
                    cmbbrgy.Items.Add("POLO")
                    cmbbrgy.Items.Add("PULONG PARANG")
                    cmbbrgy.Items.Add("PUNONG")
                    cmbbrgy.Items.Add("SAN ANTONIO")
                    cmbbrgy.Items.Add("SAN-ISIDRO")
                    cmbbrgy.Items.Add("TAGUM")
                    cmbbrgy.Items.Add("TAMAYO")
                    cmbbrgy.Items.Add("TAMBANGAN")
                    cmbbrgy.Items.Add("TAWIRAN")
                    cmbbrgy.Items.Add("TAYTAY")


                Case "TORRIJOS"
                    cmbbrgy.Items.Add("BANGWAYIN")
                    cmbbrgy.Items.Add("BAYAKBAKIN")
                    cmbbrgy.Items.Add("BOLO")
                    cmbbrgy.Items.Add("BONLIW")
                    cmbbrgy.Items.Add("BUANGAN")
                    cmbbrgy.Items.Add("CABUYO")
                    cmbbrgy.Items.Add("CAGPO")
                    cmbbrgy.Items.Add("DAMPULAN")
                    cmbbrgy.Items.Add("KAY DUKE")
                    cmbbrgy.Items.Add("MABUHAY")
                    cmbbrgy.Items.Add("MAKAWAYAN")
                    cmbbrgy.Items.Add("MALIBAGO")
                    cmbbrgy.Items.Add("MALINAO")
                    cmbbrgy.Items.Add("MARANLIG")
                    cmbbrgy.Items.Add("MARLANGGA")
                    cmbbrgy.Items.Add("MATUYATUYA")
                    cmbbrgy.Items.Add("NANGKA")
                    cmbbrgy.Items.Add("PAKASKASAN")
                    cmbbrgy.Items.Add("PAYANAS")
                    cmbbrgy.Items.Add("POBLACION")
                    cmbbrgy.Items.Add("POCTOY")
                    cmbbrgy.Items.Add("SIBUYAO")
                    cmbbrgy.Items.Add("SUHA")
                    cmbbrgy.Items.Add("TALAWAN")
                    cmbbrgy.Items.Add("TIGWI")


            End Select
            cmbbrgy.SelectedIndex = 0
            ' Set an initial selection for ComboBox2 (optional)
        End If
    End Sub



    Private Sub Btnsavecon_Click(sender As Object, e As EventArgs) Handles Btnsavecon.Click
        loadingthis += 1
        SaveData2()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()


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

    Sub clear()
        cmbcom.SelectedIndex = -1
        cmbOrg.SelectedIndex = -1
        newcontact.Text = ""
        txttypeorg.Text = ""
        newtxtarea.Text = ""
        newtxtseedreq.Text = ""

        newyear.Text = ""

        cmbbrgy.SelectedIndex = -1
        cmbmuni.SelectedIndex = -1
        txtpenro.SelectedIndex = -1
        txtcenro.SelectedIndex = -1
        contenure.Text = ""

    End Sub

    Private Sub conspecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles conspecies.SelectedIndexChanged
        If conspecies.SelectedIndex <> -1 Then

            btnmultiplecom.Enabled = False
            ListBox1.Enabled = False
            ListBox2.Enabled = False
        Else

            btnmultiplecom.Enabled = True
            ListBox1.Enabled = True
            ListBox2.Enabled = True
        End If

        Label39.Text = conspecies.SelectedItem.ToString()
    End Sub



    Private Sub newdatecontractexe_ValueChanged(sender As Object, e As EventArgs) Handles newdatecontractexe.ValueChanged
        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = newdatecontractexe.Value

        ' Calculate the new date for DateTimePicker2 (add 3 years and set the month to December)
        Dim newDate As DateTime = selectedDate.AddYears(2)
        newDate = newDate.AddMonths(12 - newDate.Month) ' Ensure the month is December

        ' Set the value of DateTimePicker2
        newdatecontractexp.Value = newDate
        newyear.Value = New Date(newdatecontractexe.Value.Year, newyear.Value.Month, newyear.Value.Day)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmultiplecom.Click
        conspecies.Enabled = False
        multiple_commodity.ShowDialog()
    End Sub



    Private Function IsInputValid() As Boolean
        ' Perform input validation here for all fields and return True if valid, False otherwise
        ' Example:
        ' If cmbcom.SelectedItem Is Nothing OrElse cmbOrg.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(newcontact.Text) Then
        '     Return False
        ' End If

        ' Add more validation logic as needed

        Return True ' Return True if all validation checks pass
    End Function
    Public Sub SaveData2()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try


            If (cmbOrg.SelectedItem Is Nothing Or newcontact.Text = "" Or txttypeorg.Text = "" Or
                 newtxtarea.Text = "" Or newtxtseedreq.Text = "" Or newyear.Text = "" Or
                  cmbbrgy.SelectedItem Is Nothing Or cmbmuni.SelectedItem Is Nothing Or txtpenro.SelectedItem Is Nothing Or txtcenro.SelectedItem Is Nothing) Then
                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")

            Else

                If IsInputValid() Then
                    connection.Open()


                    ' Insert into contract_tbl
                    Dim contractQuery As String = "INSERT INTO contract_tbl (unique_code, org_id, date_execution, date_expiry, zone, fund, activities, year, region, district, baranggay, municipality, province, penro, cenro, component, commodity, species, seed_reqdisplay) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11, @Value12, @Value13, @Value14, @Value15, @Value16, @Value17, @Value18, @Value19)"
                    Using command As New MySqlCommand(contractQuery, connection)
                        ' ... (your parameter setting code)
                        command.Parameters.AddWithValue("@Value1", randomid.Text)
                        command.Parameters.AddWithValue("@Value2", Label18.Text)
                        command.Parameters.AddWithValue("@Value3", newdatecontractexe.Value.Date)
                        command.Parameters.AddWithValue("@Value4", newdatecontractexp.Value.Date)

                        command.Parameters.AddWithValue("@Value5", 0)
                        command.Parameters.AddWithValue("@Value6", 0)
                        command.Parameters.AddWithValue("@Value7", 0)
                        command.Parameters.AddWithValue("@Value8", newyear.Text)
                        command.Parameters.AddWithValue("@Value9", txtconregion.Text)
                        command.Parameters.AddWithValue("@Value10", condistricttxt.Text)
                        command.Parameters.AddWithValue("@Value11", cmbbrgy.Text)
                        command.Parameters.AddWithValue("@Value12", cmbmuni.Text)
                        command.Parameters.AddWithValue("@Value13", newtxtprovince.Text)
                        command.Parameters.AddWithValue("@Value14", txtpenro.Text)
                        command.Parameters.AddWithValue("@Value15", txtcenro.Text)
                        command.Parameters.AddWithValue("@Value16", cmbcom.Text)
                        Dim valuecom As String

                        Dim commodity As String = "N/A"
                        Dim seedling As String = "N/A"

                        If conspecies.Enabled = True Then
                            valuecom = conspecies.Text
                            commodity = conspecies.Text
                        Else
                            valuecom = txtlist1.Text

                        End If
                        command.Parameters.AddWithValue("@Value17", valuecom)
                        command.Parameters.AddWithValue("@Value18", 0)


                        Dim valueitem As String
                        If conspecies.Enabled = True Then
                            valueitem = newtxtseedreq.Text.ToString
                            seedling = newtxtseedreq.Text
                        Else
                            valueitem = txtlist2.Text

                        End If
                        If conspecies.Enabled = True Then
                            insertcommodity(commodity, seedling)
                        End If


                        command.Parameters.AddWithValue("@Value19", valueitem)
                        command.ExecuteNonQuery()
                    End Using

                    ' Insert into data_tbl
                    Dim query1 As String = "INSERT INTO data_tbl (unique_code, target_area, area_planted, seed_req, seed_pro, seed_plant) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
                    Using command1 As New MySqlCommand(query1, connection)
                        ' ... (your parameter setting code)

                        command1.Parameters.AddWithValue("@Value1", randomid.Text)
                        command1.Parameters.AddWithValue("@Value2", 0)
                        command1.Parameters.AddWithValue("@Value3", newtxtarea.Text)
                        command1.Parameters.AddWithValue("@Value4", newtxtseedreq.Text)
                        command1.Parameters.AddWithValue("@Value5", 0)
                        command1.Parameters.AddWithValue("@Value6", 0)

                        command1.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Contract information has been successfully registered.")
                    dashboard.Close()
                    With dashboard
                        .TopLevel = False
                        maindash.Panel5.Controls.Add(dashboard)
                        .BringToFront()
                        .Show()
                    End With
                    Me.Close()
                    ClearFormData()
                    btnmultiplecom.Enabled = True


                Else
                    MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
                End If

            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        Finally
            ' Ensure the connection is closed, even in the case of an exception
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try




    End Sub

    Private Sub insertcommodity(commodity As String, seedling As String)
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Try

            Dim query As String = "INSERT INTO commodity_unitcost_tbl (unique_code, commodity_name, seedlingcount ) VALUES (@Value1, @Value2, @Value3)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", randomid.Text)
            command.Parameters.AddWithValue("@Value2", commodity)
            command.Parameters.AddWithValue("@Value3", seedling)
            command.ExecuteNonQuery()

            ' Close the connection
            connection.Close()

            ' Optionally, display a success message
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub newyear_ValueChanged(sender As Object, e As EventArgs) Handles newyear.ValueChanged
        newdatecontractexe.Value = New Date(newyear.Value.Year, newyear.Value.Month, newyear.Value.Day)
    End Sub

    Private Sub ClearFormData()

        For Each ctrl As Control In Me.Controls
            btnmultiplecom.Enabled = True
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


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cmborgselect()
        cmbcomponent()
        cmbcommodity()
    End Sub



End Class

