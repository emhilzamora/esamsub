Public Class SelectMonitoring

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click
        Me.Hide()
        animateWin(Dashboard, False)
        Dashboard.Hide()
        animateWin(Monitoring, True)
        Monitoring.Show()
        Monitoring.txtMonitoring.Focus()
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click
        Me.Hide()
        animateWin(Dashboard, False)
        Dashboard.Hide()
        animateWin(Monitoring_Time_Out, True)
        Monitoring_Time_Out.Show()
        Monitoring.txtMonitoring.Focus()
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        Me.Hide()
        Dashboard.Show()
    End Sub
End Class