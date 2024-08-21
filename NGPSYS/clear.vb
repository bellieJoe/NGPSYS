Public Module FormUtilities
    Public Sub ClearFormControls(form As Form)
        For Each control As Control In form.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                textBox.Clear()
            ElseIf TypeOf control Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(control, DateTimePicker)
                dateTimePicker.Value = DateTime.Now ' Set to the default value (you can customize this value as needed)
            End If
        Next

        ' Clear ListView (if needed)

    End Sub
End Module
