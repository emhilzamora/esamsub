Public Class Print_Id_Cards

    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'disabled the buttons
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnManageUsers.Enabled = False
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnEmployee.Enabled = False
        Dashboard.btnMonitoring.Enabled = False
        Dashboard.btnStudents.Enabled = False
        animateWin(Me, False)
        Me.Hide()
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub
End Class