Public Class Form1
    Dim decInputValue As Decimal = 0
    Const inchToMeter As Decimal = 0.0254
    Const meterToInch As Decimal = 39.36
    Dim result As Decimal

    Dim errorMessageHeader = "Input Error"
    Dim strNotNumeric As String = "Enter a positive number"
    Dim strNegativeValue As String = "The measurement must be greater than zero"
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If IsNumeric((txtInputValue.Text)) Then
            Dim strInputValue As String = txtInputValue.Text
            decInputValue = Convert.ToDecimal(strInputValue)
            If decInputValue > 0 Then
                If rdoInchesToMeters.Checked = True Then
                    result = (decInputValue * 0.0254)
                    lblConversionOutput.Text = decInputValue.ToString() + " inches is " + result.ToString("F3") + " meters"
                End If
                If rdoMetersToInches.Checked = True Then
                    result = (decInputValue * meterToInch)
                    lblConversionOutput.Text = decInputValue.ToString() + " meters is " + result.ToString("F3") + " inches"
                End If
            Else
                MessageBox.Show(strNegativeValue, errorMessageHeader)
            End If
        Else
            MessageBox.Show(strNotNumeric, errorMessageHeader)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblConversionOutput.Text = ""
        rdoMetersToInches.Checked = False
        rdoInchesToMeters.Checked = False
        txtInputValue.Text = ""
        txtInputValue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConversionOutput.Text = ""
        rdoMetersToInches.Checked = False
        rdoInchesToMeters.Checked = False
        txtInputValue.Text = ""
        txtInputValue.Focus()
    End Sub
End Class
