Public Class AvgPrices
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        MessageBox.Show(((Convert.ToInt32(tbPrice1.Text) + Convert.ToInt32(tbPrice2.Text) + Convert.ToInt32(tbPrice3.Text)) / 3).ToString)
    End Sub
End Class