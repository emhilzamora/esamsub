Public Class SelectMonitoring

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click
        Me.Hide()
        animateWin(Monitoring, True)
        Monitoring.Show()
        Monitoring.txtMonitoring.Focus()
        Monitoring.pnlWindow.Visible = True
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click
        Me.Hide()
        animateWin(Monitoring_Time_Out, True)
        Monitoring.Show()
        Monitoring_Time_Out.txtMonitoring.Focus()
        Monitoring_Time_Out.pnlWindow.Visible = True
    End Sub
End Class