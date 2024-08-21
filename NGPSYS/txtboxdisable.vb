Public Class txtboxdisable

    Inherits TextBox

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim bgColor As Color = If(Enabled, BackColor, Color.White)
        Using backBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(backBrush, ClientRectangle)
        End Using

        Dim textRect As New Rectangle(0, 0, Width - 1, Height - 1)
        TextRenderer.DrawText(e.Graphics, Text, Font, textRect, ForeColor, bgColor, TextFormatFlags.Default)
    End Sub
End Class
