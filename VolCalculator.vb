Public Class VolCalculator
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Dim diameter As Decimal
        Dim height As Decimal

        If Decimal.TryParse(tbDiameter.Text, diameter) AndAlso Decimal.TryParse(tbHeight.Text, height) Then
            Dim volume As Decimal = Math.PI * (diameter / 2) * (diameter / 2) * height
            lbResult.Text = volume.ToString()
        Else
            MessageBox.Show("You must write valid numbers in both textboxes")
        End If
    End Sub
End Class