Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx


Public Class addcontract
    Private Sub addcontract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim randomCode As String = GenerateRandomUniqueCode(10)
        randomid.Text = randomCode
        cmborgselect()
        cmbcomponent()
        cmbcommodity()
        clear()


    End Sub

    Private Sub Btnbackadmin_Click(sender As Object, e As EventArgs) Handles Btnbackadmin.Click

        loadingthis += 1

        dashboard.Show()

        Me.Close()

    End Sub



    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub contenure_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Organization.Show()

    End Sub


    Private Function comboorgname()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim query As String = "SELECT DISTINCT Org_name FROM organizational_tbl"
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
        Dim selectRecordQuery As String = "SELECT Org_name FROM Organizational_tbl ;"

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
        SaveData2()


    End Sub






    Public Sub save()

        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If (cmbcom.SelectedItem Is Nothing Or cmbOrg.SelectedItem Is Nothing Or newcontact.Text = "" Or txttypeorg.Text = "" Or
                 newtxtarea.Text = "" Or newtxtseedreq.Text = "" Or newcost1.Text = "" Or newyear.Text = "" Or
                 txt1st.Text = "" Or txt2nd.Text = "" Or txt3rd.Text = "" Or txt4th.Text = "" Or txtretention.Text = "" Or
                  cmbbrgy.SelectedItem Is Nothing Or cmbmuni.SelectedItem Is Nothing Or txtpenro.SelectedItem Is Nothing Or txtcenro.SelectedItem Is Nothing) Then





                MsgBox("Please complete all the fields !", MsgBoxStyle.Exclamation, "Warning")

            Else

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "INSERT INTO contract_tbl (unique_code, org_id, date_execution, date_expiry, zone, fund, activities, year, region, district, baranggay,
                                        municipality, province, penro, cenro, component, commodity, species, seed_reqdisplay)
                                        VALUES (@Value1, @Value2, @Value3, @Value4, 
                                        @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11, @Value12, @Value13, @Value14, @Value15, @Value16, @Value17, @Value18, @Value19)"
                    Using command As New MySqlCommand(query, connection)


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


                        If conspecies.Enabled = True Then
                            valuecom = conspecies.Text
                        Else
                            valuecom = txtlist1.Text
                        End If
                        command.Parameters.AddWithValue("@Value17", valuecom)



                        command.Parameters.AddWithValue("@Value18", 0)


                        Dim valueitem As String


                        If conspecies.Enabled = True Then
                            valueitem = newtxtseedreq.Text.ToString
                        Else
                            valueitem = txtlist2.Text
                        End If

                        command.Parameters.AddWithValue("@Value19", valueitem)




                        command.ExecuteNonQuery()

                        ' Replace column1, column2, and column3 with the actual column names you want to retrieve.



                        ' Close the connection

                    End Using

                    Dim query1 As String = "INSERT INTO data_tbl (unique_code, target_area, area_planted, seed_req, seed_pro, seed_plant, cost_1, cost_2, cost_3,total_cost)
                                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"

                    Dim inputcost1 As String = newcost1.Text
                    Dim intcost1 As Integer = 0

                    Dim inputseedreq As String = newtxtseedreq.Text
                    Dim intseedreq As Integer = 0

                    Dim inputarea As String = newtxtarea.Text
                    Dim intarea As Decimal = 0

                    Using command1 As New MySqlCommand(query1, connection)
                        command1.Parameters.AddWithValue("@Value1", randomid.Text)
                        command1.Parameters.AddWithValue("@Value2", 0)

                        If Decimal.TryParse(inputarea, intarea) Then
                            command1.Parameters.AddWithValue("@Value3", intarea)
                        End If

                        If Integer.TryParse(inputseedreq, intseedreq) Then
                            command1.Parameters.AddWithValue("@Value4", intseedreq)
                        End If

                        command1.Parameters.AddWithValue("@Value5", 0)
                        command1.Parameters.AddWithValue("@Value6", 0)

                        If Integer.TryParse(inputcost1, intcost1) Then
                            command1.Parameters.AddWithValue("@Value7", intcost1)
                        End If


                        command1.Parameters.AddWithValue("@Value8", 0)
                        command1.Parameters.AddWithValue("@Value9", 0)
                        command1.Parameters.AddWithValue("@Value10", 0)

                        command1.ExecuteNonQuery()
                    End Using


                    Dim query2 As String = "INSERT INTO year1_disbursement (unique_code, 1st_payment, 2nd_payment, 3rd_payment, 4th_payment, retention_fund)
                                        VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"

                    Dim input1st As String = txt1st.Text
                    Dim int1st As Integer = 0

                    Dim input2nd As String = txt2nd.Text
                    Dim int2nd As Integer = 0

                    Dim input3rd As String = txt3rd.Text
                    Dim int3rd As Integer = 0

                    Dim input4th As String = txt4th.Text
                    Dim int4th As Integer = 0

                    Dim inputren As String = txtretention.Text
                    Dim intren As Integer = 0



                    Using command2 As New MySqlCommand(query2, connection)

                        command2.Parameters.AddWithValue("@Value1", randomid.Text)

                        If Integer.TryParse(input1st, int1st) Then
                            command2.Parameters.AddWithValue("@Value2", int1st)
                        End If

                        If Integer.TryParse(input2nd, int2nd) Then
                            command2.Parameters.AddWithValue("@Value3", int2nd)
                        End If

                        If Integer.TryParse(input3rd, int3rd) Then
                            command2.Parameters.AddWithValue("@Value4", int3rd)
                        End If

                        If Integer.TryParse(input4th, int4th) Then
                            command2.Parameters.AddWithValue("@Value5", int4th)
                        End If


                        If Integer.TryParse(inputren, intren) Then
                            command2.Parameters.AddWithValue("@Value6", intren)
                        End If



                        command2.ExecuteNonQuery()
                    End Using




                    ' Optionally, display a success message
                    MessageBox.Show("Data inserted successfully.")
                    connection.Close()





                End Using



            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

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
        newcost1.Text = ""
        newyear.Text = ""
        txtindigenous.Text = ""
        txtfruit.Text = ""
        txt1st.Text = ""
        txt2nd.Text = ""
        txt3rd.Text = ""
        txt4th.Text = ""
        txtretention.Text = ""
        cmbbrgy.SelectedIndex = -1
        cmbmuni.SelectedIndex = -1
        txtpenro.SelectedIndex = -1
        txtcenro.SelectedIndex = -1
        contenure.Text = ""

    End Sub

    Private Sub conspecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles conspecies.SelectedIndexChanged
        If conspecies.SelectedIndex <> -1 Then
            txtindigenous.Enabled = False
            txtfruit.Enabled = False ' Disable the button when an item is selected
            btnmultiplecom.Enabled = False
            ListBox1.Enabled = False
            ListBox2.Enabled = False


        Else
            txtindigenous.Enabled = True
            txtfruit.Enabled = True
            btnmultiplecom.Enabled = True
            ListBox1.Enabled = True
            ListBox2.Enabled = True
        End If

        Label39.Text = conspecies.SelectedItem.ToString()
    End Sub

    Private Sub newcost1_TextChanged(sender As Object, e As EventArgs) Handles newcost1.TextChanged

        If Not String.IsNullOrWhiteSpace(newcost1.Text) Then
            txt2nd.Enabled = True
            If Decimal.TryParse(newcost1.Text, Nothing) Then
                ' Calculate 15% of the input and display it in TextBox2
                Dim inputNumber As Decimal = Decimal.Parse(newcost1.Text)
                Dim result As Decimal = inputNumber * 0.15
                first.Text = result.ToString()

                txt1st.Text = result.ToString("N")

            Else
                txt1st.Text = "Invalid input"
            End If
        Else
            txt1st.Text = String.Empty
            txt2nd.Enabled = False
        End If

        If Not String.IsNullOrWhiteSpace(newcost1.Text) Then
            ' Parse the input as a decimal
            If Decimal.TryParse(newcost1.Text, Nothing) Then
                ' Calculate 15% of the input and display it in TextBox2
                Dim inputNumber As Decimal = Decimal.Parse(newcost1.Text)
                Dim result As Decimal = inputNumber * 0.1
                retention.Text = result.ToString
                txtretention.Text = result.ToString("N")

            Else
                txtretention.Text = "Invalid input"
            End If
        Else
            txtretention.Text = String.Empty
        End If



    End Sub

    Private Sub newcost1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles newcost1.KeyPress

        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ControlChars.Back) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Prevent the character from being entered
            MessageBox.Show("Please input valid number!")
        End If
    End Sub



    Private Sub txt2nd_TextChanged(sender As Object, e As EventArgs) Handles txt2nd.TextChanged
        If Not String.IsNullOrWhiteSpace(txt2nd.Text) Then
            txt3rd.Enabled = True

        Else

            txt3rd.Enabled = False
        End If
    End Sub

    Private Sub txt2nd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2nd.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ControlChars.Back) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Prevent the character from being entered
            MessageBox.Show("Please input valid number!")
        End If
    End Sub

    Private Sub txt3rd_TextChanged(sender As Object, e As EventArgs) Handles txt3rd.TextChanged
        If Not String.IsNullOrWhiteSpace(txt3rd.Text) Then
            txt4th.Enabled = True

        Else

            txt4th.Enabled = False
        End If
    End Sub

    Private Sub txt3rd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3rd.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ControlChars.Back) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Prevent the character from being entered
            MessageBox.Show("Please input valid number!")
        End If
    End Sub

    Private Sub txt4th_TextChanged(sender As Object, e As EventArgs) Handles txt4th.TextChanged
        Dim total As Decimal = 0

        ' Parse the input in TextBox2 to decimal and add it to the total


        ' Repeat the same for TextBox3, TextBox4, TextBox5, and TextBox6
        If Decimal.TryParse(txt2nd.Text, Nothing) Then
            total += Decimal.Parse(txt2nd.Text)
        End If

        If Decimal.TryParse(txt3rd.Text, Nothing) Then
            total += Decimal.Parse(txt3rd.Text)
        End If

        If Decimal.TryParse(txt4th.Text, Nothing) Then
            total += Decimal.Parse(txt4th.Text)
        End If



        ' Check if the total matches TextBox1
        If total = Decimal.Parse(newcost1.Text) Then
            lbloutput.Text = "Project Cost is equal to total payment"

        Else
            lbloutput.Text = "Project Cost is not equal to total payment"

        End If
    End Sub

    Private Sub txt4th_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4th.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ControlChars.Back) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Prevent the character from being entered
            MessageBox.Show("Please input valid number!")
        End If
    End Sub

    Private Sub newdatecontractexe_ValueChanged(sender As Object, e As EventArgs) Handles newdatecontractexe.ValueChanged
        ' Get the selected date from DateTimePicker1
        Dim selectedDate As DateTime = newdatecontractexe.Value

        ' Calculate the new date for DateTimePicker2 (add 3 years and set the month to December)
        Dim newDate As DateTime = selectedDate.AddYears(2)
        newDate = newDate.AddMonths(12 - newDate.Month) ' Ensure the month is December

        ' Set the value of DateTimePicker2
        newdatecontractexp.Value = newDate
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmultiplecom.Click
        conspecies.Enabled = False
        multiple_commodity.ShowDialog()

    End Sub



    Private Sub newcost1_LostFocus(sender As Object, e As EventArgs) Handles newcost1.LostFocus
        Dim project_cost As Decimal
        If Decimal.TryParse(newcost1.Text, project_cost) Then
            ' Format the inputNumber as money and display it back in the TextBox
            projectcost.Text = project_cost.ToString()
            newcost1.Text = project_cost.ToString("N")
        Else
        End If
    End Sub

    Private Sub txt1st_LostFocus(sender As Object, e As EventArgs) Handles txt1st.LostFocus
        Dim percent15 As Decimal
        If Decimal.TryParse(txt1st.Text, percent15) Then
            ' Format the inputNumber as money and display it back in the TextBox
            first.Text = percent15.ToString("N")
            txt1st.Text = percent15.ToString("N")
        Else
        End If
    End Sub

    Private Sub txt2nd_LostFocus(sender As Object, e As EventArgs) Handles txt2nd.LostFocus
        Dim second As Decimal
        If Decimal.TryParse(txt2nd.Text, second) Then
            ' Format the inputNumber as money and display it back in the TextBox
            seconds.Text = second.ToString()
            txt2nd.Text = second.ToString("N")
        Else
        End If
    End Sub

    Private Sub txt3rd_LostFocus(sender As Object, e As EventArgs) Handles txt3rd.LostFocus
        Dim third As Decimal
        If Decimal.TryParse(txt3rd.Text, third) Then
            ' Format the inputNumber as money and display it back in the TextBox
            thirds.Text = third.ToString()
            txt3rd.Text = third.ToString("N")
        Else
        End If
    End Sub

    Private Sub txt4th_LostFocus(sender As Object, e As EventArgs) Handles txt4th.LostFocus
        Dim fourth As Decimal
        If Decimal.TryParse(txt4th.Text, fourth) Then
            ' Format the inputNumber as money and display it back in the TextBox
            fourths.Text = fourth.ToString()
            txt4th.Text = fourth.ToString("N")
        Else
        End If
    End Sub


    Public Sub SaveData()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If IsInputValid() Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Insert into contract_tbl
                    Dim contractQuery As String = "INSERT INTO contract_tbl (unique_code, org_id, date_execution, date_expiry, zone, fund, activities, year, region, district, baranggay, municipality, province, penro, cenro, component, commodity, species, seed_reqdisplay) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11, @Value12, @Value13, @Value14, @Value15, @Value16, @Value17, @Value18, @Value19)"
                    Using command As New MySqlCommand(contractQuery, connection)
                        '
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


                        If conspecies.Enabled = True Then
                            valuecom = conspecies.Text
                        Else
                            valuecom = txtlist1.Text
                        End If
                        command.Parameters.AddWithValue("@Value17", valuecom)



                        command.Parameters.AddWithValue("@Value18", 0)


                        Dim valueitem As String


                        If conspecies.Enabled = True Then
                            valueitem = newtxtseedreq.Text.ToString
                        Else
                            valueitem = txtlist2.Text
                        End If

                        command.Parameters.AddWithValue("@Value19", valueitem)
                        ' ...

                        command.ExecuteNonQuery()
                    End Using

                    ' Insert into data_tbl
                    Dim query1 As String = "INSERT INTO data_tbl (unique_code, target_area, area_planted, seed_req, seed_pro, seed_plant, cost_1, cost_2, cost_3, total_cost) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
                    Using command1 As New MySqlCommand(query1, connection)
                        ' Set parameter values
                        ' ...


                        Dim inputcost1 As String = newcost1.Text
                        Dim intcost1 As Integer = 0

                        Dim inputseedreq As String = newtxtseedreq.Text
                        Dim intseedreq As Integer = 0

                        Dim inputarea As String = newtxtarea.Text
                        Dim intarea As Decimal = 0




                        command1.Parameters.AddWithValue("@Value1", randomid.Text)
                        command1.Parameters.AddWithValue("@Value2", 0)

                        If Decimal.TryParse(inputarea, intarea) Then
                            command1.Parameters.AddWithValue("@Value3", intarea)
                        End If

                        If Integer.TryParse(inputseedreq, intseedreq) Then
                            command1.Parameters.AddWithValue("@Value4", intseedreq)
                        End If

                        command1.Parameters.AddWithValue("@Value5", 0)
                        command1.Parameters.AddWithValue("@Value6", 0)

                        If Integer.TryParse(inputcost1, intcost1) Then
                            command1.Parameters.AddWithValue("@Value7", intcost1)
                        End If


                        command1.Parameters.AddWithValue("@Value8", 0)
                        command1.Parameters.AddWithValue("@Value9", 0)
                        command1.Parameters.AddWithValue("@Value10", 0)


                        command1.ExecuteNonQuery()

                    End Using


                    ' Insert into year1_disbursement
                    Dim disbursementQuery As String = "INSERT INTO year1_disbursement (unique_code, 1st_payment, 2nd_payment, 3rd_payment, 4th_payment, retention_fund) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
                    Using command2 As New MySqlCommand(disbursementQuery, connection)
                        ' Set parameter values
                        ' ...
                        Dim input1st As String = txt1st.Text
                        Dim int1st As Integer = 0

                        Dim input2nd As String = txt2nd.Text
                        Dim int2nd As Integer = 0

                        Dim input3rd As String = txt3rd.Text
                        Dim int3rd As Integer = 0

                        Dim input4th As String = txt4th.Text
                        Dim int4th As Integer = 0

                        Dim inputren As String = txtretention.Text
                        Dim intren As Integer = 0


                        command2.Parameters.AddWithValue("@Value1", randomid.Text)

                        If Integer.TryParse(input1st, int1st) Then
                            command2.Parameters.AddWithValue("@Value2", int1st)
                        End If

                        If Integer.TryParse(input2nd, int2nd) Then
                            command2.Parameters.AddWithValue("@Value3", int2nd)
                        End If

                        If Integer.TryParse(input3rd, int3rd) Then
                            command2.Parameters.AddWithValue("@Value4", int3rd)
                        End If

                        If Integer.TryParse(input4th, int4th) Then
                            command2.Parameters.AddWithValue("@Value5", int4th)
                        End If


                        If Integer.TryParse(inputren, intren) Then
                            command2.Parameters.AddWithValue("@Value6", intren)
                        End If


                        command2.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data inserted successfully.")
                End Using
            Else
                MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed

        End Try
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

    Public Sub SaveData1()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"

        Try
            If IsInputValid() Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()


                    connection.Open()

                    ' Insert into contract_tbl
                    Dim contractQuery As String = "INSERT INTO contract_tbl (unique_code, org_id, date_execution, date_expiry, zone, fund, activities, year, region, district, baranggay, municipality, province, penro, cenro, component, commodity, species, seed_reqdisplay) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10, @Value11, @Value12, @Value13, @Value14, @Value15, @Value16, @Value17, @Value18, @Value19)"
                    Using command As New MySqlCommand(contractQuery, connection)
                        '
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


                        If conspecies.Enabled = True Then
                            valuecom = conspecies.Text
                        Else
                            valuecom = txtlist1.Text
                        End If
                        command.Parameters.AddWithValue("@Value17", valuecom)



                        command.Parameters.AddWithValue("@Value18", 0)


                        Dim valueitem As String


                        If conspecies.Enabled = True Then
                            valueitem = newtxtseedreq.Text.ToString
                        Else
                            valueitem = txtlist2.Text
                        End If

                        command.Parameters.AddWithValue("@Value19", valueitem)
                        ' ...

                        command.ExecuteNonQuery()
                    End Using

                    ' Insert into data_tbl
                    Dim query1 As String = "INSERT INTO data_tbl (unique_code, target_area, area_planted, seed_req, seed_pro, seed_plant, cost_1, cost_2, cost_3, total_cost) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
                    Using command1 As New MySqlCommand(query1, connection)
                        ' Set parameter values
                        ' ...


                        Dim inputcost1 As String = newcost1.Text
                        Dim intcost1 As Integer = 0

                        Dim inputseedreq As String = newtxtseedreq.Text
                        Dim intseedreq As Integer = 0

                        Dim inputarea As String = newtxtarea.Text
                        Dim intarea As Decimal = 0




                        command1.Parameters.AddWithValue("@Value1", randomid.Text)
                        command1.Parameters.AddWithValue("@Value2", 0)

                        If Decimal.TryParse(inputarea, intarea) Then
                            command1.Parameters.AddWithValue("@Value3", intarea)
                        End If

                        If Integer.TryParse(inputseedreq, intseedreq) Then
                            command1.Parameters.AddWithValue("@Value4", intseedreq)
                        End If

                        command1.Parameters.AddWithValue("@Value5", 0)
                        command1.Parameters.AddWithValue("@Value6", 0)

                        If Integer.TryParse(inputcost1, intcost1) Then
                            command1.Parameters.AddWithValue("@Value7", intcost1)
                        End If


                        command1.Parameters.AddWithValue("@Value8", 0)
                        command1.Parameters.AddWithValue("@Value9", 0)
                        command1.Parameters.AddWithValue("@Value10", 0)


                        command1.ExecuteNonQuery()

                    End Using


                    ' Insert into year1_disbursement
                    Dim disbursementQuery As String = "INSERT INTO year1_disbursement (unique_code, 1st_payment, 2nd_payment, 3rd_payment, 4th_payment, retention_fund) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
                    Using command2 As New MySqlCommand(disbursementQuery, connection)
                        ' Set parameter values
                        ' ...
                        Dim input1st As String = txt1st.Text
                        Dim int1st As Integer = 0

                        Dim input2nd As String = txt2nd.Text
                        Dim int2nd As Integer = 0

                        Dim input3rd As String = txt3rd.Text
                        Dim int3rd As Integer = 0

                        Dim input4th As String = txt4th.Text
                        Dim int4th As Integer = 0

                        Dim inputren As String = txtretention.Text
                        Dim intren As Integer = 0


                        command2.Parameters.AddWithValue("@Value1", randomid.Text)

                        If Integer.TryParse(input1st, int1st) Then
                            command2.Parameters.AddWithValue("@Value2", int1st)
                        End If

                        If Integer.TryParse(input2nd, int2nd) Then
                            command2.Parameters.AddWithValue("@Value3", int2nd)
                        End If

                        If Integer.TryParse(input3rd, int3rd) Then
                            command2.Parameters.AddWithValue("@Value4", int3rd)
                        End If

                        If Integer.TryParse(input4th, int4th) Then
                            command2.Parameters.AddWithValue("@Value5", int4th)
                        End If


                        If Integer.TryParse(inputren, intren) Then
                            command2.Parameters.AddWithValue("@Value6", intren)
                        End If


                        command2.ExecuteNonQuery()
                    End Using

                    ' Optionally, display a success message
                    MessageBox.Show("Data inserted successfully.")
                End Using
            Else
                MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed, even in the case of an exception

        End Try
    End Sub


    Public Sub SaveData2()
        Dim connectionString As String = "server=localhost;username=root;password=;database=ngp"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        Try
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


                    If conspecies.Enabled = True Then
                        valuecom = conspecies.Text
                    Else
                        valuecom = txtlist1.Text
                    End If
                    command.Parameters.AddWithValue("@Value17", valuecom)



                    command.Parameters.AddWithValue("@Value18", 0)


                    Dim valueitem As String


                    If conspecies.Enabled = True Then
                        valueitem = newtxtseedreq.Text.ToString
                    Else
                        valueitem = txtlist2.Text
                    End If

                    command.Parameters.AddWithValue("@Value19", valueitem)
                    command.ExecuteNonQuery()
                End Using

                ' Insert into data_tbl
                Dim query1 As String = "INSERT INTO data_tbl (unique_code, target_area, area_planted, seed_req, seed_pro, seed_plant, cost_1, cost_2, cost_3, total_cost) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)"
                Using command1 As New MySqlCommand(query1, connection)
                    ' ... (your parameter setting code)

                    command1.Parameters.AddWithValue("@Value1", randomid.Text)
                    command1.Parameters.AddWithValue("@Value2", 0)
                    command1.Parameters.AddWithValue("@Value3", newtxtarea.Text)
                    command1.Parameters.AddWithValue("@Value4", newtxtseedreq.Text)
                    command1.Parameters.AddWithValue("@Value5", 0)
                    command1.Parameters.AddWithValue("@Value6", 0)
                    command1.Parameters.AddWithValue("@Value7", projectcost.Text)
                    command1.Parameters.AddWithValue("@Value8", 0)
                    command1.Parameters.AddWithValue("@Value9", 0)
                    command1.Parameters.AddWithValue("@Value10", 0)

                    command1.ExecuteNonQuery()
                End Using

                ' Insert into year1_disbursement
                Dim disbursementQuery As String = "INSERT INTO year1_disbursement (unique_code, 1st_payment, 2nd_payment, 3rd_payment, 4th_payment, retention_fund) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
                Using command2 As New MySqlCommand(disbursementQuery, connection)
                    ' ... (your parameter setting code)

                    command2.Parameters.AddWithValue("@Value1", randomid.Text)


                    command2.Parameters.AddWithValue("@Value2", first.Text)



                    command2.Parameters.AddWithValue("@Value3", seconds.Text)



                    command2.Parameters.AddWithValue("@Value4", thirds.Text)



                    command2.Parameters.AddWithValue("@Value5", fourths.Text)


                    command2.Parameters.AddWithValue("@Value6", retention.Text)


                    command2.ExecuteNonQuery()
                End Using

                ' Optionally, display a success message
                MessageBox.Show("Data inserted successfully.")
            Else
                MsgBox("Please complete all the fields!", MsgBoxStyle.Exclamation, "Warning")
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

    Private Sub projectcost_TextChanged(sender As Object, e As EventArgs) Handles projectcost.TextChanged

    End Sub

    Private Sub area_TextChanged(sender As Object, e As EventArgs) Handles area.TextChanged

    End Sub
End Class