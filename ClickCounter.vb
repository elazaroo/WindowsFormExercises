Public Class ClickCounter
    Private Sub btCount_Click(sender As Object, e As EventArgs) Handles btCount.Click
        If String.IsNullOrEmpty(lbCounter.Text) Then
            lbCounter.Text = "0"
        End If
        lbCounter.Text = (Convert.ToInt32(lbCounter.Text) + 1).ToString()

    End Sub
End Class