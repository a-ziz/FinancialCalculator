Public Class frmFutureValue

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Try
            If isValidData() Then
                Dim monthlyInvestment As Decimal =
                    CDec(txtMonthlyInvestment.Text)
                Dim yearlyInterestRate As Decimal =
                    CDec(txtInterestRate.Text)
                Dim years As Integer = CInt(txtYears.Text)

                Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
                Dim months As Integer = years * 12

                Dim futureValue As Decimal = Me.CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months)

                txtFutureValue.Text = FormatCurrency(futureValue)
                txtMonthlyInvestment.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf &
            ex.GetType.ToString & vbCrLf &
            ex.StackTrace, "Exception")
        End Try
    End Sub

    Private Function isValidData() As Boolean
        Return _
            Validator.IsPresent(txtMonthlyInvestment) AndAlso
            Validator.IsDecimal(txtMonthlyInvestment) AndAlso
            Validator.IsWithinRange(txtMonthlyInvestment, 0, 1000) AndAlso
            Validator.IsPresent(txtInterestRate) AndAlso
            Validator.IsDecimal(txtInterestRate) AndAlso
            Validator.IsWithinRange(txtInterestRate, 0, 20) AndAlso
            Validator.IsPresent(txtYears) AndAlso
            Validator.IsInt32(txtYears) AndAlso
            Validator.IsWithinRange(txtYears, 0, 40)
    End Function

    Private Function CalculateFutureValue(monthlyInvestment As Decimal,
            monthlyInterestRate As Decimal, months As Integer) _
            As Decimal
        Dim futureValue As Decimal
        For index As Integer = 1 To months
            futureValue = (futureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
        Next index
        Return futureValue
    End Function

    Private Sub ClearFutureValue(sender As Object,
            e As EventArgs) Handles txtMonthlyInvestment.TextChanged,
            txtYears.TextChanged, txtInterestRate.TextChanged
        txtFutureValue.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class