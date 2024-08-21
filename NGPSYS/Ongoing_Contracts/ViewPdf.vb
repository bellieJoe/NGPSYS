Imports PdfiumViewer

Public Class ViewPdf
    Public fileName As String
    Private Sub ViewPdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pdfViewer As PdfViewer = New PdfViewer()
        pdfViewer.Dock = DockStyle.Fill
        Controls.Add(pdfViewer)
        Dim document As PdfDocument = PdfDocument.Load(fileName)
        pdfViewer.Document = document
        pdfViewer.Show()
    End Sub
End Class