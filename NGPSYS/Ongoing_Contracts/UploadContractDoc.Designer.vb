<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadContractDoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnChooseFile = New Button()
        Label1 = New Label()
        btnUpload = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' btnChooseFile
        ' 
        btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnChooseFile.FlatStyle = FlatStyle.Flat
        btnChooseFile.Location = New Point(12, 33)
        btnChooseFile.Name = "btnChooseFile"
        btnChooseFile.Size = New Size(287, 83)
        btnChooseFile.TabIndex = 0
        btnChooseFile.Text = "Choose a PDF File"
        btnChooseFile.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 15)
        Label1.TabIndex = 1
        Label1.Text = "Contract Document"
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(224, 136)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(75, 23)
        btnUpload.TabIndex = 2
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Pdf Files|*.pdf"
        ' 
        ' UploadContractDoc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(311, 174)
        Controls.Add(btnUpload)
        Controls.Add(Label1)
        Controls.Add(btnChooseFile)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "UploadContractDoc"
        StartPosition = FormStartPosition.CenterParent
        Text = "Upload or Change Document"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnChooseFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
