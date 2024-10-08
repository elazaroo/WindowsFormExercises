Public Class Salary
    Private salary As Decimal = 0
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click
        Select Case lboxPost.Text
            Case "Worker"
                salary = 800
            Case "Administrative"
                salary = 900
            Case "Technical"
                salary = 1000
            Case "Professional"
                salary = 1200
        End Select
        If cboxSyndicate.Text = "Yes" Then
            salary += 50
        End If
        Select Case cboxSeniority.Text
            Case "Less than 5"
                salary = salary
            Case "Between 5 and 10"
                salary += 100
            Case "More than 10"
                salary += 200
        End Select
        salary = salary + (nudSons.Value * 100)
        MessageBox.Show(salary)
    End Sub
End Class