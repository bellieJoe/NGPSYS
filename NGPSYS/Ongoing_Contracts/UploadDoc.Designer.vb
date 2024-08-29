<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadDoc
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
        btnChooseFile.Location = New Point(14, 44)
        btnChooseFile.Margin = New Padding(3, 4, 3, 4)
        btnChooseFile.Name = "btnChooseFile"
        btnChooseFile.Size = New Size(328, 111)
        btnChooseFile.TabIndex = 0
        btnChooseFile.Text = "Choose a PDF File"
        btnChooseFile.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 20)
        Label1.TabIndex = 1
        Label1.Text = "Contract Document"
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(256, 181)
        btnUpload.Margin = New Padding(3, 4, 3, 4)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(86, 31)
        btnUpload.TabIndex = 2
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Pdf Files|*.pdf"
        ' 
        ' UploadDoc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(355, 232)
        Controls.Add(btnUpload)
        Controls.Add(Label1)
        Controls.Add(btnChooseFile)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UploadDoc"
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
