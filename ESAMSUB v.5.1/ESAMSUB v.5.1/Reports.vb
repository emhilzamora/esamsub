Public Class Reports

    Private Sub tmrDigitalClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDigitalClock.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub
End Class