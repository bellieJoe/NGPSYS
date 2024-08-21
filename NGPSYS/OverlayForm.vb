Imports System.Runtime.InteropServices

Public Class OverlayForm
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ApplyBlur()
    End Sub

    Public Sub ApplyBlur()
        Dim accent = New AccentPolicy()
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND
        Dim accentStructSize = Marshal.SizeOf(accent)

        Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)
        Dim data = New WindowCompositionAttributeData()
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
        data.SizeOfData = accentStructSize
        data.Data = accentPtr

        SetWindowCompositionAttribute(Me.Owner.Handle, data)

        Marshal.FreeHGlobal(accentPtr)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Structure AccentPolicy
        Public AccentState As AccentState
        Public AccentFlags As Integer
        Public GradientColor As Integer
        Public AnimationId As Integer
    End Structure

    Private Enum AccentState
        ACCENT_DISABLED = 0
        ACCENT_ENABLE_GRADIENT = 1
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2
        ACCENT_ENABLE_BLURBEHIND = 3
        ACCENT_ENABLE_ACRYLICBLURBEHIND = 4
        ACCENT_ENABLE_HOSTBACKDROP = 5
    End Enum

    <StructLayout(LayoutKind.Sequential)>
    Private Structure WindowCompositionAttributeData
        Public Attribute As WindowCompositionAttribute
        Public Data As IntPtr
        Public SizeOfData As Integer
    End Structure

    Private Enum WindowCompositionAttribute
        WCA_ACCENT_POLICY = 19
    End Enum

    <DllImport("user32.dll")>
    Private Shared Function SetWindowCompositionAttribute(ByVal hwnd As IntPtr, ByRef data As WindowCompositionAttributeData) As Integer
    End Function
End Class
