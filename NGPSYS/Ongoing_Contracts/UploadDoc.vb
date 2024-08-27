Public Class UploadDoc
    Dim fileToUpload As String
    Public uniqueCode As String
    Public storageFolder As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim file = OpenFileDialog1.ShowDialog()
        If file = DialogResult.OK Then
            fileToUpload = OpenFileDialog1.FileName
            btnChooseFile.Text = OpenFileDialog1.SafeFileName
        End If

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        My.Computer.FileSystem.CopyFile(fileToUpload, storageFolder + Module1.uniquecode + ".pdf", True)
        MessageBox.Show("Document Successfully Uploaded", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnChooseFile.Text = "Choose file to upload"
        Close()
    End Sub
End Class