Imports System.Net
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
        btnView.Visible = isContract
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
            Dim urlIndex = reader.GetOrdinal("url")
            While reader.Read()
                dgvDocList.Rows.Add(reader.GetString(nameIndex), reader.GetInt32(idIndex), reader.GetString(urlIndex))

            End While
            myconnection.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Delete(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim delConfirmation = MessageBox.Show("Are you sure you want to delete this document?", "Deleting Document", MessageBoxButtons.YesNo)
            If delConfirmation = DialogResult.No Then
                Return
            End If
            Dim file As String = dgvDocList.Item("Url", dgvDocList.SelectedRows(0).Index).Value
            Dim Id As Integer = dgvDocList.Item("Id", dgvDocList.SelectedRows(0).Index).Value
            My.Computer.FileSystem.DeleteFile(file)
            Dim q As String = If(isContract, "DELETE FROM `contract_doc_tbl` WHERE contract_doc_id = @Id", "DELETE FROM `amap_doc_tbl` WHERE amap_doc_id = @Id")
            Dim cmd As New MySqlCommand(q, myconnection.open)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.ExecuteNonQuery()
            FetchFiles()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myconnection.close()
    End Sub

    Private Sub Download(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim file As String = dgvDocList.Item("Url", dgvDocList.SelectedRows(0).Index).Value
            Dim name As String = dgvDocList.Item("docName", dgvDocList.SelectedRows(0).Index).Value
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Title = "Save File"
            saveFileDialog.FileName = name
            saveFileDialog.Filter = "All Files| *" + System.IO.Path.GetExtension(file)
            saveFileDialog.DefaultExt = System.IO.Path.GetExtension(file)
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using webClient As New WebClient()
                    webClient.DownloadFile(file, saveFileDialog.FileName)
                End Using
            End If
            MessageBox.Show("File successfully saved.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub View(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim fileName = dgvDocList.Item("Url", dgvDocList.SelectedRows(0).Index).Value

            If Not My.Computer.FileSystem.FileExists(fileName) Then
                MessageBox.Show("Can't find the area map for this contract.")
                Return
            End If

            ViewPdf.Text = "View Contract"
            ViewPdf.fileName = fileName
            ViewPdf.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class