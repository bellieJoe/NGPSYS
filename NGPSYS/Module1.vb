Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public ranny As New DataGridViewRow
    Public user As String
    Public closesystemMF As Integer = 0
    Public component As String
    Public globalValue As Integer
    Public loadingthis As Integer
    Public resultproduce As Double
    Public uniquecode As String
    Public seedlingproduceprimamry As String
    Public switch As Integer = 0
    Public uniquecodeloading As String
    Public ReadOn As Integer
    Public pemf As Double

    Public sysremark As Integer = 0
    Public closesys As Integer = 0
    Public syssurvive As Integer = 0

    Public changeremark As Integer


    '2nd year
    Public tic_change As Integer = 0
    Public quarter12 As String
    Public lblcode As String

    'hidemenu
    Public a As Integer


    'switch user'
    Public personnel As Integer = 2

    Public Sub panel(PanelControl As Panel)
        Dim panelPath As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, PanelControl.Width, PanelControl.Height)
        Dim radius As Integer = 20 ' Adjust the radius for desired roundness

        panelPath.StartFigure()
        panelPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        panelPath.AddLine(radius, 0, PanelControl.Width - radius, 0)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        panelPath.AddLine(PanelControl.Width, radius, PanelControl.Width, PanelControl.Height - radius)
        panelPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        panelPath.AddLine(PanelControl.Width - radius, PanelControl.Height, radius, PanelControl.Height)
        panelPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        panelPath.CloseFigure()

        PanelControl.Region = New Region(panelPath)
    End Sub



    Sub opencon()
        con.ConnectionString = "server=localhost;username=root;password=;database=ngp"
        con.Open()
    End Sub

    Public Class dbconnect
        Dim connect As New MySqlConnection("server = 'localhost';uid='root';pwd='';database='ngp'")

        Public Function open() As MySqlConnection
            Try
                connect.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return connect
        End Function

        Public Function close() As MySqlConnection
            Try
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return connect
        End Function


    End Class


    Public Sub ShowLoadingScreen()
        Form1.Hide() ' Hide the main form instead of closing it
        Form1.txtuser.Clear()
        Form1.txtpass.Clear()
        Dim loadingForm As New Guest()
        loadingForm.StartPosition = FormStartPosition.CenterScreen
        loadingForm.Show()

        ' Simulate some loading process here...
        ' For demonstration purposes, we'll just use a loop.
        For i As Integer = 1 To 100
            System.Threading.Thread.Sleep(50) ' Simulating some work being done
            loadingForm.ProgressBar1.Value = i
            Application.DoEvents() ' Allow the form to update
        Next

        loadingForm.Close()


    End Sub


End Module

