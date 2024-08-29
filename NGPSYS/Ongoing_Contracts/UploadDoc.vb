Imports System.Security.Policy
Imports MySql.Data.MySqlClient

Public Class UploadDoc
    Dim myconnection As New dbconnect
    Public contractId As Integer
    Dim fileToUpload As String
    Public uniqueName As String
    Public storageFolder As String
    Public isContract As Boolean
    Dim fileExtension As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim file = OpenFileDialog1.ShowDialog()
        If file = DialogResult.OK Then
            fileToUpload = OpenFileDialog1.FileName
            btnChooseFile.Text = OpenFileDialog1.SafeFileName
            fileExtension = System.IO.Path.GetExtension(fileToUpload)
        End If

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            uniqueName = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString() + "-" + Module1.uniquecode + fileExtension
            My.Computer.FileSystem.CopyFile(fileToUpload, storageFolder + uniqueName, True)
            InsertContractAndAmap(uniqueName, storageFolder + uniqueName)
            MessageBox.Show("Document Successfully Uploaded", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnChooseFile.Text = "Choose file to upload"
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub InsertContractAndAmap(name As String, url As String)
        Try
            Dim q As String
            If isContract Then
                q = $"INSERT INTO contract_doc_tbl(name, url, unique_code) VALUES(@name, @url, @unique_code);"

            Else
                q = $"INSERT INTO amap_doc_tbl(name, url, unique_code) VALUES(@name, @url, @unique_code);"
            End If
            Dim cmd As New MySqlCommand(q, myconnection.open)

            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@url", url)
            cmd.Parameters.AddWithValue("@unique_code", Module1.uniquecode)
            cmd.ExecuteNonQuery()
            myconnection.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UploadDoc_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fileToUpload = ""
    End Sub
End Class