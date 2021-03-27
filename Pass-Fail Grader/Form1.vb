Public Class Form1
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim score As Integer = CType(txtScore.Text, Integer)

        Select Case score
            Case 60 To 100
                lblResult.Text = "Pass"
                lblResult.BackColor = Color.LightGreen
            Case Else
                lblResult.Text = "Fail"
                lblResult.BackColor = Color.IndianRed
        End Select
    End Sub
End Class
