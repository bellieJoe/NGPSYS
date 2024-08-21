Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class maindash
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dashboard.Close()
        With dashboard
            .TopLevel = False
            Panel5.Controls.Add(dashboard)
            .BringToFront()
            .Show()
        End With
        ongoing_details.Close()
        Ongoingcon.Close()
        TICdashboard.Close()
        Year2_dashboard.Close()
    End Sub

    Private Sub maindash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If personnel = 2 Then
            btnAdminNav.Visible = True
        Else
            btnAdminNav.Visible = False
        End If


        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        ' Set the Renderer to a custom ToolStripProfessionalRenderer
        MenuStrip1.Renderer = New CustomProfessionalRenderer()
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        ' Set the Renderer to a custom ToolStripProfessionalRenderer
        MenuStrip2.Renderer = New CustomProfessionalRenderer()

        If loadingthis = 1 Then ShowLoadingScreen()

        With dashboard
            .TopLevel = False
            Panel5.Controls.Add(dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ongoingcon.Close()
        With Ongoingcon
            .TopLevel = False
            Panel5.Controls.Add(Ongoingcon)
            .BringToFront()
            .Show()
        End With
        ongoing_details.Close()
        TICdashboard.Close()
        Year2_dashboard.Close()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        completed_contracts.Close()
        With completed_contracts
            .TopLevel = False
            Panel5.Controls.Add(completed_contracts)
            .BringToFront()
            .Show()
        End With
        ongoing_details.Close()
        TICdashboard.Close()
        Year2_dashboard.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If personnel = 0 Or personnel = 1 Then


            If MenuStrip1.Items.ContainsKey("AddOrganizationToolStripMenuItem") Then
                Dim menuItem As ToolStripMenuItem = DirectCast(MenuStrip1.Items("AddOrganizationToolStripMenuItem"), ToolStripMenuItem)
                AddUserToolStripMenuItem1.Visible = False
                menuItem.ShowDropDown()
            End If

        Else
            If MenuStrip1.Items.ContainsKey("AddOrganizationToolStripMenuItem") Then
                Dim menuItem As ToolStripMenuItem = DirectCast(MenuStrip1.Items("AddOrganizationToolStripMenuItem"), ToolStripMenuItem)
                menuItem.ShowDropDown()
            End If

        End If


    End Sub

    Private Sub AddNewContractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewContractToolStripMenuItem.Click
        add2022contract.ShowDialog()
    End Sub

    Private Sub AddUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem1.Click
        userpass.ShowDialog()
    End Sub

    Private Sub AddOrganizationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddOrganizationToolStripMenuItem1.Click
        New_Organization.ShowDialog()
    End Sub

    Private Sub AddComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComponentToolStripMenuItem.Click
        NewComponent.ShowDialog()
    End Sub

    Private Sub AddCommodityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCommodityToolStripMenuItem.Click
        NewCommodity.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        NewSpecies.ShowDialog()
    End Sub

    Private Sub AddNewTenureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewTenureToolStripMenuItem.Click
        NewTenure.ShowDialog()
    End Sub





    Public Sub user()
        Button6.Visible = False
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAdminNav.Click


        If MenuStrip2.Items.ContainsKey("ToolStripMenuItem1") Then
            Dim menuItem As ToolStripMenuItem = DirectCast(MenuStrip2.Items("ToolStripMenuItem1"), ToolStripMenuItem)
            'btnAdminNav.Visible = True
            menuItem.ShowDropDown()
        End If


    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        user_maintenance.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        organization_maintenance.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        component_maintenance.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        commodity_maintenance.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        species_maintenance.ShowDialog()

    End Sub



    Private overlay As OverlayForm

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If overlay Is Nothing OrElse overlay.IsDisposed Then
            overlay = New OverlayForm()
            overlay.Owner = Me
            overlay.Bounds = Me.Bounds
            overlay.Show()
            overlay.ApplyBlur()
        End If

        ' Ensure the overlay form is closed when the button is clicked again
        AddHandler Me.FormClosed, Sub()
                                      If overlay IsNot Nothing AndAlso Not overlay.IsDisposed Then
                                          overlay.Close()
                                      End If
                                  End Sub
    End Sub

    Private Sub maindash_FormClosed(sender As Object, e As FormClosedEventArgs)

    End Sub

    Private Sub maindash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.closeme = 1
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            e.Cancel = True
            Return
        End If
        If result = DialogResult.OK Then
            Form1.Show()
        End If
    End Sub
End Class

Public Class CustomProfessionalRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        ' Customize the appearance of the menu item background here
        Dim rectangle As New Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1)

        If e.Item.Selected Then
            ' Set the background color when the item is selected
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(179, 55, 113)), rectangle)
        Else
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(34, 47, 62)), rectangle)
        End If
    End Sub

End Class


