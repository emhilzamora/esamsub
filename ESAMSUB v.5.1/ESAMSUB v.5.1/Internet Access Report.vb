Imports MySql.Data.MySqlClient
Public Class Internet_Access_Report
    Dim sConnection As New MySqlConnection
    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub
End Class