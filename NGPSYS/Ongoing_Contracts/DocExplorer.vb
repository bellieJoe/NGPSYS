Imports MySql.Data.MySqlClient

Public Class formDocExplorer
    Dim myconnection As New dbconnect
    Public contractId As Integer
    Public FolderLocation As String
    Public isContract As Boolean
    Dim Docs As IList

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocList.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not isContract Then
            UploadDoc.OpenFileDialog1.Filter = "All Files|*.pdf;*.png;*.jpg;*.jpeg"
        Else
            UploadDoc.OpenFileDialog1.Filter = "All Files|*.pdf"
        End If
        UploadDoc.isContract = isContract
        UploadDoc.storageFolder = FolderLocation
        UploadDoc.ShowDialog()
        FetchFiles()
    End Sub

    Private Sub formDocExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchFiles()
    End Sub

    Public Sub FetchFiles()
        Try
            dgvDocList.Rows.Clear()
            Dim q As String = If(isContract, "SELECT * FROM contract_doc_tbl WHERE unique_code = @unique_code;", "SELECT * FROM amap_doc_tbl WHERE unique_code = @unique_code;")

            Dim cmd As New MySqlCommand(q, myconnection.open)
            cmd.Parameters.AddWithValue("@unique_code", Module1.uniquecode)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim idIndex = If(isContract, reader.GetOrdinal("contract_doc_id"), reader.GetOrdinal("amap_doc_id"))

            Dim nameIndex = reader.GetOrdinal("name")
            While reader.Read()
                dgvDocList.Rows.Add(reader.GetString(nameIndex), reader.GetInt32(idIndex))

            End While
            myconnection.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class