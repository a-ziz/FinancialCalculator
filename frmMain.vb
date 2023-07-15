Public Class frmMain
    Private Sub btnFutureValue_Click(sender As Object, e As EventArgs) Handles btnFutureValue.Click

        Dim futureValueForm As New frmFutureValue
        futureValueForm.Show()
    End Sub
    Private Sub btnDepreciation_Click(sender As Object, e As EventArgs) Handles btnDepreciation.Click

        Dim depreciationForm As New frmDepreciation
        depreciationForm.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

End Class