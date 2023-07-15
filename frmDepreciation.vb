Public Class frmDepreciation

    Private Sub frmDepreciation_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 40
            cboLife.Items.Add(i)
        Next i
    End Sub

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        If IsValidData() Then
            Dim cost As Decimal = CDec(txtInitialCost.Text)
            Dim finalValue As Decimal = CDec(txtFinalValue.Text)
            Dim life As Integer = CInt(cboLife.Text)
            lstDepreciation.Items.Clear()
            For i As Integer = 1 To life
                lstDepreciation.Items.Add("Year " & i & ":   " &
                    FormatCurrency(SYD(cost, finalValue, life, i)))
            Next i
            txtInitialCost.Select()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        If Validator.IsPresent(txtInitialCost) AndAlso
                Validator.IsDecimal(txtInitialCost) AndAlso
                Validator.IsWithinRange(txtInitialCost, 500, 1000000) Then
            Dim dMaximum As Decimal = CDec(txtInitialCost.Text)
            If Validator.IsPresent(txtFinalValue) AndAlso
                    Validator.IsDecimal(txtFinalValue) AndAlso
                    Validator.IsWithinRange(txtFinalValue, 0, dMaximum) AndAlso
                    Validator.IsSelected(cboLife) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnClose_Click(sender As Object,
            e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class