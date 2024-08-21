Public Class _2MP_mf_dibursement

    Dim totalpayment As Double

    Private Sub _2MP_mf_dibursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbill_TextChanged(sender As Object, e As EventArgs) Handles txtbill.TextChanged
        Dim inputValue As Double
        If Double.TryParse(txtbill.Text, inputValue) Then
            ' Calculate 15% of the input value.
            Dim result As Double = inputValue * 0.15

            ' Display the result in the txtResult TextBox.
            txtpayment.Text = result.ToString("N2")
            ' Format the result with 2 decimal places.
            totalpayment = result
        Else
            ' If the input is not a valid number, clear the result TextBox.
            txtpayment.Clear()
        End If
    End Sub
End Class